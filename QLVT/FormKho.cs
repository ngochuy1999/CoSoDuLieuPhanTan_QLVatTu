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

namespace QLVT
{
    public partial class FormKho : DevExpress.XtraEditors.XtraForm
    {
        private string macn = "";
        private int position;
        public FormKho()
        {
            InitializeComponent();
        }

        private void FormKho_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet.Kho);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.ChiNhanh' table. You can move, or remove it, as needed.
            if (Program.mGroup == "CONGTY")
            {
                cbChiNhanh.Enabled = true;
                btnAdd.Links[0].Visible = btnDelete.Links[0].Visible = btnSave.Links[0].Visible = false;
                btnEdit.Links[0].Visible = btnUndo.Links[0].Visible = false;
            }
            else if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                cbChiNhanh.Enabled = false;
            }
            macn = (((DataRowView)khoBindingSource[0])["MACN"].ToString());    //Cập nhật tự động vào label MACN khi tạo mới

            cbChiNhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";

            //Mặc định vừa vào groupbox không dx hiện để tránh lỗi sửa các dòng cũ chưa lưu đi qua dòng khác
            btnUndo.Enabled = btnSave.Enabled = gbInfor.Enabled = false;
            Program.flagCloseFormKho = true; //Khi load bật cho phép có thể đóng form

        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = khoBindingSource.Position;
            this.khoBindingSource.AddNew();
            mACNTextBox.Text = macn;
            btnAdd.Enabled = btnDelete.Enabled = khoGridControl.Enabled = false;
            btnRefresh.Enabled = btnEdit.Enabled = false;
            btnUndo.Enabled = gbInfor.Enabled = btnSave.Enabled = true;
            Program.flagCloseFormKho = false;    //Bật cờ lên để chặn tắt Form đột ngột khi nhập liệu
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string makho = "";
            if (khoBindingSource.Position != -1)
            {
                makho = ((DataRowView)khoBindingSource[khoBindingSource.Position])["MAKHO"].ToString();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu!", "Notification",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có thực sự muốn xóa nhân viên này?", "Xác nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    //Kiểm tra MAKHO có tồn tại trong các Phiếu
                    string query = "DECLARE	@result int " +
                          "EXEC @result = SP_CheckID @p1, @p2 " +
                          "SELECT 'result' = @result";
                    SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
                    sqlCommand.Parameters.AddWithValue("@p1", makho);
                    sqlCommand.Parameters.AddWithValue("@p2", "MAKHO_EXIST");
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
                        MessageBox.Show("Kho này đã tồn tại trong các Phiếu, không thể xóa. Vui lòng kiểm tra lại!\n", "Notification",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    khoBindingSource.RemoveCurrent();
                    this.khoTableAdapter.Update(this.qLVT_DATHANGDataSet.Kho);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Kho hãy xóa lại! \n" + ex.Message, "Thông báo lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet.Kho);
                    khoBindingSource.Position = khoBindingSource.Find("MAKHO", makho);
                    return;
                }
            }
            if (khoBindingSource.Count == 0) btnDelete.Enabled = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = khoBindingSource.Position;
            btnEdit.Enabled = khoGridControl.Enabled = btnAdd.Enabled = false;
            btnDelete.Enabled = btnRefresh.Enabled = false;
            gbInfor.Enabled = btnUndo.Enabled = btnSave.Enabled = true;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkValidate(mAKHOTextBox, "Mã Kho is not empty!")) return;
            if (!checkValidate(tENKHOTextBox, "Tên Kho is not empty!")) return;
            if (!checkValidate(dIACHITextBox, "Địa chỉ is not empty!")) return;
            if (mAKHOTextBox.Text.Trim().Length > 4)
            {
                MessageBox.Show("Mã KHO không được quá 4 kí tự!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (mAKHOTextBox.Text.Contains(" "))
            {
                MessageBox.Show("Mã KHO không được chứa khoảng trắng!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "DECLARE	@result int " +
                           "EXEC @result = SP_CheckID @p1, @p2 " +
                           "SELECT 'result' = @result";
            SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
            sqlCommand.Parameters.AddWithValue("@p1", mAKHOTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@p2", "MAKHO");
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
            int resultMAKHO = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();

            query = "DECLARE @result int " +
                    "EXEC @result = SP_CheckID @p1, @p2 " +
                    "SELECT 'result' = @result";
            sqlCommand = new SqlCommand(query, Program.connection);
            sqlCommand.Parameters.AddWithValue("@p1", tENKHOTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@p2", "TENKHO");
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
            int resultTENKHO = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();

            int positionMAKHO = khoBindingSource.Find("MAKHO", mAKHOTextBox.Text);
            int postionTENKHO = khoBindingSource.Find("TENKHO", tENKHOTextBox.Text);
            int postionCurrent = khoBindingSource.Position;
            //Bỏ qua TH tồn tại ở CN hiện tại khi vị trí MANV đang nhập đúng băng vị trí đang đứng
            if (resultMAKHO == 1 && (positionMAKHO != postionCurrent))
            {
                MessageBox.Show("Mã KHO đã tồn tại !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (resultTENKHO == 1 && (postionTENKHO != postionCurrent))
            {
                MessageBox.Show("Tên Kho đã tồn tại !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        Program.flagCloseFormKho = true; //Bật cờ cho phép tắt Form NV
                        btnAdd.Enabled = btnDelete.Enabled = khoGridControl.Enabled = true;
                        btnRefresh.Enabled = btnEdit.Enabled = true;
                        btnUndo.Enabled = gbInfor.Enabled = btnSave.Enabled = false;
                        this.khoBindingSource.EndEdit();
                        this.khoTableAdapter.Update(this.qLVT_DATHANGDataSet.Kho);
                        khoBindingSource.Position = position;
                    }
                    catch (Exception ex)
                    {
                        //Khi Update database lỗi thì xóa record vừa thêm trong bds
                        khoBindingSource.RemoveCurrent();
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAdd.Enabled = btnDelete.Enabled = khoGridControl.Enabled = true;
            btnRefresh.Enabled = btnEdit.Enabled = true;
            btnUndo.Enabled = gbInfor.Enabled = btnSave.Enabled = false;
            Program.flagCloseFormKho = true; //Undo lại thì cho phép thoát mà ko kiểm tra dữ liệu
            khoBindingSource.CancelEdit();
            khoBindingSource.Position = position;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int position = khoBindingSource.Position;
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet.Kho);
            khoBindingSource.Position = position;
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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

        private void FormKho_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.flagCloseFormKho == false)
            {
                DialogResult dr = MessageBox.Show("Dữ liệu Form Kho vẫn chưa lưu vào Database! \nBạn có chắn chắn muốn thoát?", "Thông báo",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else if (dr == DialogResult.Yes)
                {
                    Program.flagCloseFormKho = true;
                }

            }
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbChiNhanh.ValueMember != "")   //Xử lý trường hợp Event autorun khi vừa khởi chạy project
            {
                if (this.cbChiNhanh.SelectedValue != null && Program.servername != this.cbChiNhanh.SelectedValue.ToString()) //Khi enable FormNhanVien thì value = null nên lỗi
                {
                    Program.servername = this.cbChiNhanh.SelectedValue.ToString();
                    if (Program.mloginDN != Program.remotelogin) //Why?
                    {
                        Program.mloginDN = Program.remotelogin;
                        Program.passwordDN = Program.remotepassword;
                    }
                    else
                    {
                        Program.mloginDN= Program.mlogin;
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

                    this.khoTableAdapter.Connection.ConnectionString = Program.connectionString;
                    this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet.Kho);

                    //Đồng thời cũng tự động Fill lại cho FormNhanVien               
                    if (Program.formNhanVien != null)
                    {
                        Program.formNhanVien.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
                        Program.formNhanVien.datHangTableAdapter.Connection.ConnectionString = Program.connectionString;
                        Program.formNhanVien.cTDDHTableAdapter.Connection.ConnectionString = Program.connectionString;
                        Program.formNhanVien.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectionString;
                        Program.formNhanVien.cTPNTableAdapter.Connection.ConnectionString = Program.connectionString;
                        Program.formNhanVien.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectionString;
                        Program.formNhanVien.cTPXTableAdapter.Connection.ConnectionString = Program.connectionString;

                        Program.formNhanVien.nhanVienTableAdapter.Fill(Program.formNhanVien.getDataSet().NhanVien);
                        Program.formNhanVien.datHangTableAdapter.Fill(Program.formNhanVien.getDataSet().DatHang);
                        Program.formNhanVien.cTDDHTableAdapter.Fill(Program.formNhanVien.getDataSet().CTDDH);
                        Program.formNhanVien.phieuNhapTableAdapter.Fill(Program.formNhanVien.getDataSet().PhieuNhap);
                        Program.formNhanVien.cTPNTableAdapter.Fill(Program.formNhanVien.getDataSet().CTPN);
                        Program.formNhanVien.phieuXuatTableAdapter.Fill(Program.formNhanVien.getDataSet().PhieuXuat);
                        Program.formNhanVien.cTPXTableAdapter.Fill(Program.formNhanVien.getDataSet().CTPX);

                    }

                }
            }
        }

        public QLVT_DATHANGDataSet getDataSet()
        {
            return this.qLVT_DATHANGDataSet;
        }
    }
}