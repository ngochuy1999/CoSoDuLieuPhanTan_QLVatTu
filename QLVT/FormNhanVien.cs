using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Views.Grid;
using System.Runtime.InteropServices;

namespace QLVT
{
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string macn = "";
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            //this.qLVT_DATHANGDataSet.EnforceConstraints = false;// bỏ qua kiểm tra khóa phụ null
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.ChiNhanh' table. You can move, or remove it, as needed.
            this.chiNhanhTableAdapter.Fill(this.qLVT_DATHANGDataSet.ChiNhanh);
            // TODO: This line of code loads data into the 'qLVTDataSet.SP_DanhSachNhanVien' table. You can move, or remove it, as needed.
            //this.sP_DanhSachNhanVienTableAdapter.Fill(this.qLVTDataSet.SP_DanhSachNhanVien);

            //Cấu hình Default chiều cao của các panel =))
            gbInfor.Height = 270;
            gbDatHang.Height = 270;
            gbPhieuNhap.Height = 270;
            gbPhieuXuat.Height = 270;
            //Tắt các panel của PhieuNhap - PhieuXuat - DatHang trước
            /*
             * Trước khi đổ dữ liệu cần cập nhập Connection của Adapter điều này xảy ra khi
             * Trường hợp này xảy ra khi đăng nhập từ 1 Nhân viên ở CN2 và cần GrowTable dữ liệu cũng của CN2
            */
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.datHangTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connectionString;

            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
            this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);
            this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTDDH);
            this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuNhap);
            this.cTPNTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPN);
            this.phieuXuatTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuXuat);
            this.cTPXTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPX);
           
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                btnAdd.Links[0].Visible = btnDelete.Links[0].Visible = btnSave.Links[0].Visible = false;
                btnEdit.Links[0].Visible = btnChuyenCN.Links[0].Visible = btnUndo.Links[0].Visible = false;
            }
            else if (Program.mGroup == "CHINHANH")
            {
                cmbChiNhanh.Enabled = false;
            }
            else if (Program.mGroup == "USER")
            {
                cmbChiNhanh.Enabled  = btnChuyenCN.Links[0].Visible = false;
            }
            macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
            cmbChiNhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            //Mặc định vừa vào groupbox không dx hiện để tránh lỗi sửa các dòng cũ chưa lưu đi qua dòng khác
            btnUndo.Enabled = btnSave.Enabled = gbInfor.Enabled = false;
            Program.flagCloseFormNV = true; //Khi load bật cho phép có thể đóng form
        
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switchPanel("Thông tin", Properties.Resources.info_user_32, gbInfor);
            vitri = bdsNV.Position;
            this.bdsNV.AddNew();
            //Giá trị mặc định khi Thêm NV
            mANVNumericUpDown.Value = newMANV();
            lUONGNumericUpDown.Value = 4000000;
            ((DataRowView)bdsNV[bdsNV.Position])["LUONG"] = 4000000;
            mACNTextBox.Text = macn;

            trangThaiXoaCheckBox.Checked = btnSwitch.Enabled = trangThaiXoaCheckBox.Enabled = false;
            btnAdd.Enabled = btnDelete.Enabled = nhanVienGridControl.Enabled = false;
            btnChuyenCN.Enabled = btnRefresh.Enabled = btnEdit.Enabled = false;
            btnUndo.Enabled = gbInfor.Enabled = btnSave.Enabled = true;
            Program.flagCloseFormNV = false;    //Bật cờ lên để chặn tắt Form đột ngột 
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbChiNhanh.ValueMember != "")   //Xử lý trường hợp Event autorun khi vừa khởi chạy project
            {
                if (this.cmbChiNhanh.SelectedValue != null && Program.servername != this.cmbChiNhanh.SelectedValue.ToString()) //Khi enable FormNhanVien thì value = null nên lỗi
                {
                    Program.servername = this.cmbChiNhanh.SelectedValue.ToString();
                    if (Program.mloginDN != Program.remotelogin) //Why?
                    {
                        Program.mloginDN = Program.remotelogin;
                        Program.passwordDN = Program.remotepassword;
                    }
                    else
                    {
                        Program.mloginDN = Program.mlogin;
                        Program.passwordDN = Program.password;
                    }
                    try
                    {
                        Program.connectionString = "Server=" + Program.servername + ";"
                                        + "database=QLVT_DATHANG;"
                                        + "User id=" + Program.mloginDN + ";"
                                        + "Password=" + Program.passwordDN;
                        Program.connection = new SqlConnection(Program.connectionString);
                        Program.connection.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kết nối Server thất bại! " + ex.Message, "Notification", MessageBoxButtons.OK);
                        return;
                    }

                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
                    this.datHangTableAdapter.Connection.ConnectionString = Program.connectionString;
                    this.cTDDHTableAdapter.Connection.ConnectionString = Program.connectionString;
                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectionString;
                    this.cTPNTableAdapter.Connection.ConnectionString = Program.connectionString;
                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectionString;
                    this.cTPXTableAdapter.Connection.ConnectionString = Program.connectionString;

                    this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
                    this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);
                    this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTDDH);
                    this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuNhap);
                    this.cTPNTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPN);
                    this.phieuXuatTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuXuat);
                    this.cTPXTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPX);

                    //Đồng thời cập nhật cho Form Kho nếu thay đổi ConnectionString và Fill lại
                    if (Program.FormKho != null)
                    {
                       
                        Program.FormKho.khoTableAdapter.Connection.ConnectionString = Program.connectionString;

                        Program.FormKho.khoTableAdapter.Fill(Program.FormKho.getDataSet().Kho);

                    }
                }
            }

        }

        public static int newMANV()
        {
            string query = "SELECT *FROM ListMANV";
            SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
            SqlDataReader dataReader = null;
            List<int> list = new List<int>();
            try
            {
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    list.Add(dataReader.GetInt32(0));
                }
                dataReader.Close();

                for (int i = 1; i <= list[list.Count - 1]; i++)
                {
                    if (list.BinarySearch(i) < 0) return i; //Tìm thấy số âm tức số đó chưa tồn tại. Nhận số đó là ID mới
                }
                return list[(list.Count - 1)] + 1;    //Nếu duyệt từ bé đến lớn trong dãy không có MANV mới sẽ +1 lên
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm Mã Nhân Viên mới! \n" + ex.Message, "Notification", MessageBoxButtons.OK);
                dataReader.Close();
            }
            return -1;  //Không tìm thấy trả -1 đánh dấu Dừng chương trình
        }


        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switchPanel("Thông tin", Properties.Resources.info_user_32, gbInfor);
            vitri = bdsNV.Position;
            btnEdit.Enabled = nhanVienGridControl.Enabled = btnAdd.Enabled = false;
            btnDelete.Enabled = btnRefresh.Enabled = btnChuyenCN.Enabled = btnSwitch.Enabled = false;
            gbInfor.Enabled = btnUndo.Enabled = btnSave.Enabled = trangThaiXoaCheckBox.Enabled = true;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (!checkValidatesp(mANVNumericUpDown, "Mã NV is not empty!")) return;
            if (!checkValidate(hOTextBox, "Họ is not empty!")) return;
            if (!checkValidate(tENTextBox, "Tên is not empty!")) return;
            if (nGAYSINHDateEdit.Text.Equals(""))
            {
                MessageBox.Show("Ngày sinh is not empty!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nGAYSINHDateEdit.Focus();
                return;
            }

            string query = "DECLARE	@result int " +
                           "EXEC @result = SP_CheckID @p1, @p2 " +
                           "SELECT 'result' = @result";
            SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
            sqlCommand.Parameters.AddWithValue("@p1", mANVNumericUpDown.Value);
            sqlCommand.Parameters.AddWithValue("@p2", "MANV");
            SqlDataReader dataReader = null;
            try
            {
                dataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();

            int positionMANV = bdsNV.Find("MANV", mANVNumericUpDown.Value);
            int postionCurrent = bdsNV.Position;
            //Bỏ qua TH tồn tại ở CN hiện tại khi vị trí MANV đang nhập đúng băng vị trí đang đứng
            if (result == 1 && (positionMANV != postionCurrent))
            {
                MessageBox.Show("Mã NV đã tồn tại !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        Program.flagCloseFormNV = true; //Bật cờ cho phép tắt Form NV
                        btnAdd.Enabled = btnDelete.Enabled = nhanVienGridControl.Enabled = true;
                        btnChuyenCN.Enabled = btnRefresh.Enabled = btnEdit.Enabled = btnSwitch.Enabled = true;
                        btnUndo.Enabled = gbInfor.Enabled = btnSave.Enabled = false;
                        this.bdsNV.EndEdit();
                        this.nhanVienTableAdapter.Update(this.qLVT_DATHANGDataSet.NhanVien);
                        bdsNV.Position = vitri;
                    }
                    catch (Exception ex)
                    {
                        //Khi Update database lỗi thì xóa record vừa thêm trong bds
                        bdsNV.RemoveCurrent();
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
            this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);
            this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTDDH);
            this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuNhap);
            this.cTPNTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPN);
            this.phieuXuatTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuXuat);
            this.cTPXTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPX);

            if (gbDatHang.Visible || gbPhieuNhap.Visible || gbPhieuXuat.Visible)
            {
                //Nếu đăng Nhập các phiếu khi Refresh cho về vị trí Nhân Viên đang đăng nhập
                bdsNV.Position = bdsNV.Find("MANV", Program.manv);
            }
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void FormNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.flagCloseFormNV == false)
            {
                DialogResult dr = MessageBox.Show("Dữ liệu Form Nhân Viên vẫn chưa lưu vào Database! \nBạn có chắn chắn muốn thoát?", "Thông báo",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else if (dr == DialogResult.Yes)
                {
                    Program.flagCloseFormNV = true;
                }
            }
        }

        private void btnChuyenCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int positionNV = bdsNV.Find("MANV", mANVNumericUpDown.Value);
            int trangthaixoaNV = int.Parse(((DataRowView)bdsNV[positionNV])["TrangThaiXoa"].ToString());
            if (trangthaixoaNV == 1)
            {
                MessageBox.Show("Nhân Viên này đã bị xóa hoặc chuyển chi nhánh. Vui lòng chọn nhân viên khác!\n", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (mANVNumericUpDown.Value == Program.manv)
            {
                MessageBox.Show("Tài khoản Nhân Viên đang được đăng nhập không thể chuyển chi nhánh. Vui lòng chọn nhân viên khác!\n", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult resultDR = MessageBox.Show("Bạn có chắc muốn chuyển nhân viên này?", "Xác nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultDR == DialogResult.OK)
            {
                vitri = bdsNV.Position;
                int MANVCurrent = 0;
                int MANVNew = 0;
                try
                {
                    MANVCurrent = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString());
                    MANVNew = newMANV();
                    if (MANVNew == -1) return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi Parse Int!\n" + ex.Message, "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "DECLARE	@result int " +
                               "EXEC @result = SP_ChuyenCN @p1, @p2 " +
                               "SELECT 'result' = @result";
                SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
                sqlCommand.Parameters.AddWithValue("@p1", MANVCurrent);
                sqlCommand.Parameters.AddWithValue("@p2", MANVNew);
                SqlDataReader dataReader = null;
                try
                {
                    dataReader = sqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //dataReader.Close();
                    return;
                }
                dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();

                if (result == -2)         //Trường hợp 1: Kiểm tra thấy bên chi nhánh kia có ít nhất 1 NV giống nhau về họ tên, ngày sinh
                {
                    Program.maNVChuyenCN = MANVCurrent;
                    Program.PopupFormNVTrung = new PopupFormNVTrung();
                    Program.PopupFormNVTrung.Show();
                    Program.formMain.Enabled = false;
                }
                else if (result == -1)    //Trường hợp thất bại
                {
                    MessageBox.Show("Chuyển Chi nhánh thất bại! Dữ liệu đã được Roolback!", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == -3)
                {
                    MessageBox.Show("Xóa Login không thành công. Vui lòng liên hệ Quản trị viên!", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == -4)
                {
                    MessageBox.Show("Xóa User không thành công. Vui lòng liên hệ Quản trị viên!", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == 0)     //Trường hợp thành công khi bên Chi nhánh kia nhân viên chưa từng chuyển chi nhánh
                {
                    MessageBox.Show("Chuyển chi nhánh thành công. Với Mã Nhân Viên mới là: " + MANVNew, "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);  //Cập nhật xong Refresh lại 
                bdsNV.Position = vitri;                  //Cho con trỏ chuột về vị trí trước đó
            }
        }
        //===========Khu vực Xử Lý Switch Đơn Đặt Hàng, Phiếu Nhập, Phiếu Xuất==========
        private void btnInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switchPanel("Thông tin", Properties.Resources.info_user_32, gbInfor);
        }
        private void btnDatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switchPanel("Đặt hàng", Properties.Resources.order_32, gbDatHang);
            //Đồng thời cho con trỏ chuột về đúng vị trí NV đang login
            bdsNV.Position = bdsNV.Find("MANV", Program.manv);
        }
        private void btnPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switchPanel("Phiếu nhập", Properties.Resources.import_32, gbPhieuNhap);
            //Đồng thời cho con trỏ chuột về đúng vị trí NV đang login
            bdsNV.Position = bdsNV.Find("MANV", Program.manv);
        }
        private void btnPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switchPanel("Phiếu Xuất", Properties.Resources.export_32, gbPhieuXuat);
            //Đồng thời cho con trỏ chuột về đúng vị trí NV đang login
            bdsNV.Position = bdsNV.Find("MANV", Program.manv);
        }
        private void switchPanel(string caption, Bitmap image, GroupBox groupBox)
        {
            btnSwitch.Links[0].Caption = caption;
            btnSwitch.Links[0].ImageOptions.Image = image;
            gbInfor.Visible = false;
            gbDatHang.Visible = false;
            gbPhieuNhap.Visible = false;
            gbPhieuXuat.Visible = false;
            groupBox.Visible = true;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int positionNV = bdsNV.Find("MANV", mANVNumericUpDown.Value);
            int trangthaixoaNV = int.Parse(((DataRowView)bdsNV[positionNV])["TrangThaiXoa"].ToString());
            if (trangthaixoaNV == 1)
            {
                MessageBox.Show("Nhân Viên này đã bị xóa hoặc chuyển chi nhánh. Vui lòng chọn nhân viên khác!\n", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (mANVNumericUpDown.Value == Program.manv)
            {
                MessageBox.Show("Tài khoản Nhân Viên đang được đăng nhập không thể xóa. Vui lòng chọn nhân viên khác!\n", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Int32 manv = 0;
            DialogResult dr1 = MessageBox.Show("Bạn có thực sự muốn xóa nhân viên này?", "Xác nhận",
                                                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr1 == DialogResult.OK)
            {
                manv = int.Parse(getDataRow(bdsNV, "MANV"));
                //Kiểm tra MANV có tồn tại trong các Phiếu
                string query = "DECLARE	@result int " +
                      "EXEC @result = SP_CheckID @p1, @p2 " +
                      "SELECT 'result' = @result";
                SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
                sqlCommand.Parameters.AddWithValue("@p1", manv);
                sqlCommand.Parameters.AddWithValue("@p2", "MANV_EXIST");
                SqlDataReader dataReader = null;
                try
                {
                    dataReader = sqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();
                if (result == 1)
                {
                    DialogResult ketqua = MessageBox.Show("Nhân Viên này đã lập các loại Phiếu. Bạn có chắc muốn xóa?", "Xác nhận",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (ketqua == DialogResult.Cancel) return;
                }

                //Update trạng thái và xóa login, user(nếu có)
                query = "DECLARE @result int " +
                      "EXEC @result = SP_DeleteNV @p1 " +
                      "SELECT 'result' = @result";
                sqlCommand = new SqlCommand(query, Program.connection);
                sqlCommand.Parameters.AddWithValue("@p1", manv);
                dataReader = null;
                try
                {
                    dataReader = sqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
                    bdsNV.Position = bdsNV.Find("MANV", manv);
                    return;
                }
                dataReader.Read();
                result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();
                if (result == 1)
                {
                    MessageBox.Show("Xóa Login không thành công. Vui lòng liên hệ Quản trị viên!", "Notification",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == 2)
                {
                    MessageBox.Show("Xóa User không thành công. Vui lòng liên hệ Quản trị viên!", "Notification",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (bdsNV.Count == 0) btnDelete.Enabled = false;
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
            bdsNV.Position = bdsNV.Find("MANV", manv);
        }
        //===========================Khu vực Xử Lý Đơn Đặt Hàng=========================       
        private void gvDDH_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                int maNVLapDDH = 0;
                if (gvDDH.GetRowCellValue(bdsDatHang.Position, "MANV") != null)
                {
                    maNVLapDDH = int.Parse(gvDDH.GetRowCellValue(bdsDatHang.Position, "MANV").ToString().Trim());
                }
                if (e.MenuType == GridMenuType.Row)
                {
                    GridViewMenu menu = e.Menu;
                    DXMenuItem menuAddDDH = createMenuItem("Thêm DDH", Properties.Resources.add_16);
                    menuAddDDH.Click += new EventHandler(menuAddDDH_Click);
                    menu.Items.Add(menuAddDDH);

                    if (maNVLapDDH == Program.manv)
                    {
                        DXMenuItem menuAddCTDDH = createMenuItem("Thêm chi tiết DDH", Properties.Resources.add_detail1_16);
                        menuAddCTDDH.Click += new EventHandler(menuAddChiTietDDH_Click);
                        menu.Items.Add(menuAddCTDDH);
                    }
                    DXMenuItem menuAddPN = createMenuItem("Thêm Phiếu Nhập", Properties.Resources.add_detail2_16);
                    menuAddPN.Click += new EventHandler(menuAddPN_Click);
                    menu.Items.Add(menuAddPN);
                }
            }
        }
        private void menuAddDDH_Click(object sender, EventArgs e)   //MenuItem của PopupMenu
        {
            Program.SubFormDDH = new SubFormDDH();
            Program.SubFormDDH.Show();
            Program.formMain.Enabled = false;
            bdsNV.Position = bdsNV.Find("MANV", Program.manv);
        }

        private void smiAddDDH_Click(object sender, EventArgs e)    //MenuItem của ContextMenuStrip
        {
            Program.SubFormDDH = new SubFormDDH();
            Program.SubFormDDH.Show();
            Program.formMain.Enabled = false;
            bdsNV.Position = bdsNV.Find("MANV", Program.manv);
        }
        private void gcDDH_MouseHover(object sender, EventArgs e)
        {
            gcDDH.ContextMenuStrip = (bdsDatHang.Count == 0) ? cmsDDH : null;
        }

        //=======================Khu vực Xử Lý Chi Tiết Đơn Đặt Hàng====================
        private void gvCTDDH_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                if (e.MenuType == GridMenuType.Row && kiemTraCTDDHCuaNV())
                {
                    GridViewMenu menu = e.Menu;
                    DXMenuItem menuAddChiTietDDH = createMenuItem("Thêm chi tiết DDH", Properties.Resources.add_16);
                    menuAddChiTietDDH.Click += new EventHandler(menuAddChiTietDDH_Click);
                    menu.Items.Add(menuAddChiTietDDH);
                }
            }
        }
        private void menuAddChiTietDDH_Click(object sender, EventArgs e)//MenuItem của PopupMenu
        {
            Program.SubFormCTDDH = new SubFormCTDDH();
            Program.SubFormCTDDH.Show();
            Program.formMain.Enabled = false;
        }
        private bool kiemTraCTDDHCuaNV()
        {
            int maNVLapDDH = 0;
            if (gvDDH.GetRowCellValue(bdsDatHang.Position, "MANV") != null)
            {
                maNVLapDDH = int.Parse(gvDDH.GetRowCellValue(bdsDatHang.Position, "MANV").ToString().Trim());
            }
            return (maNVLapDDH == Program.manv);
        }
        private void smiAddCTDDH_Click(object sender, EventArgs e)      //MenuItem của ContextMenuStrip
        {
            Program.SubFormCTDDH = new SubFormCTDDH();
            Program.SubFormCTDDH.Show();
            Program.formMain.Enabled = false;
        }
        private void gcCTDDH_MouseHover(object sender, EventArgs e)
        {
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                gcCTDDH.ContextMenuStrip = (bdsCTDDH.Count == 0 && kiemTraCTDDHCuaNV()) ? cmsCTDDH : null;
            }
        }

        //===========================Khu vực Xử Lý Phiếu Nhập===========================
        private void gvDatHangByPN_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                if (bdsDatHang.Count != 0)
                {
                    GridViewMenu menu = e.Menu;
                    DXMenuItem menuAddPN = createMenuItem("Thêm Phiếu Nhập", Properties.Resources.add_16);
                    menuAddPN.Click += new EventHandler(menuAddPN_Click);
                    menu.Items.Add(menuAddPN);
                }
            }
        }
        private void gvPhieuNhap_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            int maNVLapPN = 0;
            if (gvPhieuNhap.GetRowCellValue(bdsPhieuNhap.Position, "MANV") != null)
            {
                maNVLapPN = int.Parse(gvPhieuNhap.GetRowCellValue(bdsPhieuNhap.Position, "MANV").ToString().Trim());
            }
            if (e.MenuType == GridMenuType.Row && maNVLapPN == Program.manv)
            {
                GridViewMenu menu = e.Menu;
                DXMenuItem menuAddCTPN = createMenuItem("Thêm chi tiết Phiếu Nhập", Properties.Resources.add_16);
                menuAddCTPN.Click += new EventHandler(menuAddCTPN_Click);
                menu.Items.Add(menuAddCTPN);
            }
        }
        private void menuAddPN_Click(object sender, EventArgs e)
        {
            if (bdsPhieuNhap.Count > 0)
            {
                MessageBox.Show("Đơn đặt hàng này đã được lập Phiếu Nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Program.SubFormPhieuNhap = new SubFormPhieuNhap();
            Program.SubFormPhieuNhap.Show();
            Program.formMain.Enabled = false;
        }

        private void smiAddPN_Click(object sender, EventArgs e)
        {
            Program.SubFormPhieuNhap = new SubFormPhieuNhap();
            Program.SubFormPhieuNhap.Show();
            Program.formMain.Enabled = false;
        }
        private void gcPhieuNhap_MouseHover(object sender, EventArgs e)
        {
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                if (bdsDatHang.Count != 0)
                {
                    gcPhieuNhap.ContextMenuStrip = (bdsPhieuNhap.Count == 0) ? cmsPN : null;
                }
            }
        }

        //===========================Khu vực Xử Lý Chi Tiết Phiếu Nhập==================
        private void gvCTPN_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                int maNVLapPN = 0;
                if (gvPhieuNhap.GetRowCellValue(bdsPhieuNhap.Position, "MANV") != null)
                {
                    maNVLapPN = int.Parse(gvPhieuNhap.GetRowCellValue(bdsPhieuNhap.Position, "MANV").ToString().Trim());
                }
                if (e.MenuType == GridMenuType.Row && maNVLapPN == Program.manv)
                {
                    GridViewMenu menu = e.Menu;
                    DXMenuItem menuAddCTPN = createMenuItem("Thêm chi tiết Phiếu Nhập", Properties.Resources.add_16);
                    menuAddCTPN.Click += new EventHandler(menuAddCTPN_Click);
                    menu.Items.Add(menuAddCTPN);
                }
            }
        }
        private void menuAddCTPN_Click(object sender, EventArgs e)
        {
            if (bdsCTDDH.Count == 0)
            {
                MessageBox.Show("Đơn Đặt hàng của Phiếu Nhập này chưa có Chi Tiết Đơn Đặt Hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (bdsCTDDH.Count == bdsCTPN.Count)
            {
                MessageBox.Show("Đơn đặt hàng này đã lập đủ Chi Tiết Phiếu Nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Program.SubFormCTPN = new SubFormCTPN();
            Program.SubFormCTPN.Show();
            Program.formMain.Enabled = false;
        }

        private void smiAddCTPN_Click(object sender, EventArgs e)
        {
            if (bdsCTDDH.Count == 0)
            {
                MessageBox.Show("Đơn Đặt hàng của Phiếu Nhập này chưa có Chi Tiết Đơn Đặt Hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Program.SubFormCTPN = new SubFormCTPN();
            Program.SubFormCTPN.Show();
            Program.formMain.Enabled = false;
        }
        private void gcCTPN_MouseHover(object sender, EventArgs e)
        {
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                int maNVLapPN = 0;
                if (gvPhieuNhap.GetRowCellValue(bdsPhieuNhap.Position, "MANV") != null)
                {
                    maNVLapPN = int.Parse(gvPhieuNhap.GetRowCellValue(bdsPhieuNhap.Position, "MANV").ToString().Trim());
                }
                gcCTPN.ContextMenuStrip = (maNVLapPN == Program.manv && bdsCTPN.Count == 0) ? cmsCTPN : null;
            }
        }


        //===========================Khu vực Xử Lý Phiếu Xuất===========================
        private void gvPhieuXuat_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                int maNVLapPX = 0;
                if (gvPhieuXuat.GetRowCellValue(bdsPhieuXuat.Position, "MANV") != null)
                {
                    maNVLapPX = int.Parse(gvPhieuXuat.GetRowCellValue(bdsPhieuXuat.Position, "MANV").ToString().Trim());
                }
                if (e.MenuType == GridMenuType.Row)
                {
                    GridViewMenu menu = e.Menu;
                    DXMenuItem menuAddPX = createMenuItem("Thêm Phiếu Xuất", Properties.Resources.add_16);
                    menuAddPX.Click += new EventHandler(menuAddPX_Click);
                    menu.Items.Add(menuAddPX);

                    if (maNVLapPX == Program.manv)
                    {
                        DXMenuItem menuAddCTPX = createMenuItem("Thêm chi tiết Phiếu Xuất", Properties.Resources.add_detail1_16);
                        menuAddCTPX.Click += new EventHandler(menuAddCTPX_Click);
                        menu.Items.Add(menuAddCTPX);
                    }
                }
            }
        }
        private void menuAddPX_Click(object sender, EventArgs e)
        {
            Program.SubFormPhieuXuat = new SubFormPhieuXuat();
            Program.SubFormPhieuXuat.Show();
            Program.formMain.Enabled = false;
            bdsNV.Position = bdsNV.Find("MANV", Program.manv);
        }
        private void smiAddPX_Click(object sender, EventArgs e)
        {
            Program.SubFormPhieuXuat = new SubFormPhieuXuat();
            Program.SubFormPhieuXuat.Show();
            Program.formMain.Enabled = false;
            bdsNV.Position = bdsNV.Find("MANV", Program.manv);
        }
        private void gcPhieuXuat_MouseHover(object sender, EventArgs e)
        {
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                gcPhieuXuat.ContextMenuStrip = (bdsPhieuXuat.Count == 0) ? cmsPX : null;
            }
        }


        //======================Khu vực Xử Lý Chi Tiết Phiếu Xuất=======================
        private void gvCTPX_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                int maNVLapPX = 0;
                if (gvPhieuXuat.GetRowCellValue(bdsPhieuXuat.Position, "MANV") != null)
                {
                    maNVLapPX = int.Parse(gvPhieuXuat.GetRowCellValue(bdsPhieuXuat.Position, "MANV").ToString().Trim());
                }
                if (e.MenuType == GridMenuType.Row && maNVLapPX == Program.manv)
                {
                    GridViewMenu menu = e.Menu;
                    DXMenuItem menuAddCTPX = createMenuItem("Thêm chi tiết Phiếu Xuất", Properties.Resources.add_16);
                    menuAddCTPX.Click += new EventHandler(menuAddCTPX_Click);
                    menu.Items.Add(menuAddCTPX);
                }
            }
        }
        private void menuAddCTPX_Click(object sender, EventArgs e)
        {
            Program.SubFormCTPX = new SubFormCTPX();
            Program.SubFormCTPX.Show();
            Program.formMain.Enabled = false;
        }
        private void smiAddCTPX_Click(object sender, EventArgs e)
        {
            Program.SubFormCTPX = new SubFormCTPX();
            Program.SubFormCTPX.Show();
            Program.formMain.Enabled = false;
        }
        private void gcCTPX_MouseHover(object sender, EventArgs e)
        {
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                int maNVLapPX = 0;
                if (gvPhieuXuat.GetRowCellValue(bdsPhieuXuat.Position, "MANV") != null)
                {
                    maNVLapPX = int.Parse(gvPhieuXuat.GetRowCellValue(bdsPhieuXuat.Position, "MANV").ToString().Trim());
                }
                gcCTPX.ContextMenuStrip = (maNVLapPX == Program.manv && bdsCTPX.Count == 0) ? cmsCTPX : null;
            }
        }


        //================Các Method hỗ trợ================

        private DXMenuItem createMenuItem(string caption, Bitmap image)
        {
            DXMenuItem menuItem = new DXMenuItem();
            menuItem.Image = image;
            menuItem.Caption = caption;
            return menuItem;
        }
        private string getDataRow(BindingSource bindingSource, string column)
        {
            return ((DataRowView)bindingSource[bindingSource.Position])[column].ToString().Trim();
        }

        private bool checkValidate(TextEdit tb, string str)
        {
            if (tb.Text.Trim().Equals(""))
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
            return true;
        }
        private bool checkValidatesp(SpinEdit spinEdit, string str)
        {
            if (spinEdit.Value == 0)
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                spinEdit.Focus();
                return false;
            }
            return true;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAdd.Enabled = btnDelete.Enabled = nhanVienGridControl.Enabled = true;
            btnRefresh.Enabled = btnChuyenCN.Enabled = btnEdit.Enabled = btnSwitch.Enabled = true;
            btnUndo.Enabled = gbInfor.Enabled = btnSave.Enabled = false;
            Program.flagCloseFormNV = true; //Undo lại thì cho phép thoát mà ko kiểm tra dữ liệu
            bdsNV.CancelEdit();
            bdsNV.Position = vitri;
        }
        //Getter-Setter các DataSet và BindingSource
        public BindingSource getDatHangBDS()
        {
            return this.bdsDatHang;
        }
        public BindingSource getCTDatHangBDS()
        {
            return this.bdsCTDDH;
        }
        public BindingSource getPhieuNhapBDS()
        {
            return this.bdsPhieuNhap;
        }
        public BindingSource getCTPhieuNhapBDS()
        {
            return this.bdsCTPN;
        }
        public BindingSource getPhieuXuatBDS()
        {
            return this.bdsPhieuXuat;
        }
        public BindingSource getCTPhieuXuatBDS()
        {
            return this.bdsCTPX;
        }
            public QLVT_DATHANGDataSet getDataSet()
        {
            return this.qLVT_DATHANGDataSet;
        }

    }
}