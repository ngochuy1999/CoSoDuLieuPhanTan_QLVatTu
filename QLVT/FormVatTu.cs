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
    public partial class FormVatTu : DevExpress.XtraEditors.XtraForm
    {
        private int position;

        public FormVatTu()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vattuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void FormVatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.vattuTableAdapter.Fill(this.qLVT_DATHANGDataSet.Vattu);

            if (Program.mGroup == "CONGTY")
            {
                btnAdd.Links[0].Visible = btnDelete.Links[0].Visible = btnSave.Links[0].Visible = false;
                btnEdit.Links[0].Visible = btnUndo.Links[0].Visible = false;
            }
            //Mặc định vừa vào groupbox không dx hiện để tránh lỗi sửa các dòng cũ chưa lưu đi qua dòng khác
            btnUndo.Enabled = btnSave.Enabled = gbInfor.Enabled = false;
            Program.flagCloseFormVT = true; //Khi load bật cho phép có thể đóng form

        }
       
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = vattuBindingSource.Position;
            this.vattuBindingSource.AddNew();
            btnAdd.Enabled = btnDelete.Enabled = vattuGridControl.Enabled = btnRefresh.Enabled = btnEdit.Enabled = false;
            btnUndo.Enabled = gbInfor.Enabled = btnSave.Enabled = true;
            Program.flagCloseFormVT = false;    //Bật cờ lên để chặn tắt Form đột ngột khi nhập liệu
            //Giá trị mặc định khi Thêm VT
            sOLUONGTONSpinEdit.Value = 0;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mavt = "";
            if (vattuBindingSource.Position != -1)
            {
                mavt = ((DataRowView)vattuBindingSource[vattuBindingSource.Position])["MAVT"].ToString();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu!", "Notification",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có thực sự muốn xóa vật tư này?", "Xác nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    //Kiểm tra MAVT có tồn tại trong các Phiếu
                    string query = "DECLARE	@result int " +
                          "EXEC @result = SP_CheckID @p1, @p2 " +
                          "SELECT 'result' = @result";
                    SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
                    sqlCommand.Parameters.AddWithValue("@p1", mavt);
                    sqlCommand.Parameters.AddWithValue("@p2", "MAVT_EXIST");
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
                        MessageBox.Show("Vật tư này đã tồn tại trong các Phiếu, không thể xóa. Vui lòng kiểm tra lại!\n", "Notification",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    vattuBindingSource.RemoveCurrent();
                    this.vattuTableAdapter.Update(this.qLVT_DATHANGDataSet.Vattu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa vật tư hãy xóa lại! \n" + ex.Message, "Thông báo lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.vattuTableAdapter.Fill(this.qLVT_DATHANGDataSet.Vattu);
                    vattuBindingSource.Position = vattuBindingSource.Find("MAVT", mavt);
                    return;
                }
            }
            if (vattuBindingSource.Count == 0) btnDelete.Enabled = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = vattuBindingSource.Position;
            btnEdit.Enabled = vattuGridControl.Enabled = btnAdd.Enabled = false;
            btnDelete.Enabled = btnRefresh.Enabled = false;
            gbInfor.Enabled = btnUndo.Enabled = btnSave.Enabled = true;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkValidate(mAVTTextBox, "Mã VT is not empty!")) return;
            if (!checkValidate(tENVTTextBox, "Tên VT is not empty!")) return;
            if (!checkValidate(dVTTextBox, "Đơn vị tính is not empty!")) return;
            if (mAVTTextBox.Text.Trim().Length > 4)
            {
                MessageBox.Show("Mã VT không được quá 4 kí tự!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (mAVTTextBox.Text.Contains(" "))
            {
                MessageBox.Show("Mã VT không được chứa khoảng trắng!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int findPositionTENVT = vattuBindingSource.Find("TENVT", tENVTTextBox.Text);
            if (findPositionTENVT != -1 && (findPositionTENVT != vattuBindingSource.Position))
            {
                MessageBox.Show("Tên Vật tư trùng. Vui lòng chọn tên Vật tư khác!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "DECLARE	@result int " +
                           "EXEC @result = SP_CheckID @p1, @p2 " +
                           "SELECT 'result' = @result";
            SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
            sqlCommand.Parameters.AddWithValue("@p1", mAVTTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@p2", "MAVT");
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
            int positionMAVT = vattuBindingSource.Find("MAVT", mAVTTextBox.Text);
            int postionCurrent = vattuBindingSource.Position;
            //Bỏ qua TH tồn tại ở CN hiện tại khi vị trí MANV đang nhập đúng băng vị trí đang đứng
            if (result == 1 && (positionMAVT != postionCurrent))
            {
                MessageBox.Show("Mã VT đã tồn tại!", "Thông báo",
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
                        Program.flagCloseFormVT = true; //Bật cờ cho phép tắt Form NV
                        btnAdd.Enabled = btnDelete.Enabled = vattuGridControl.Enabled = btnRefresh.Enabled = btnEdit.Enabled = true;
                        btnUndo.Enabled = btnSave.Enabled = gbInfor.Enabled = false;
                        this.vattuBindingSource.EndEdit();
                        this.vattuTableAdapter.Update(this.qLVT_DATHANGDataSet.Vattu);
                        vattuBindingSource.Position = position;
                    }
                    catch (Exception ex)
                    {
                        //Khi Update database lỗi thì xóa record vừa thêm trong bds
                        vattuBindingSource.RemoveCurrent();
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAdd.Enabled = btnDelete.Enabled = vattuGridControl.Enabled = btnRefresh.Enabled = btnEdit.Enabled = true;
            btnUndo.Enabled = gbInfor.Enabled = btnSave.Enabled = false;
            Program.flagCloseFormVT = true; //Undo lại thì cho phép thoát mà ko kiểm tra dữ liệu
            vattuBindingSource.CancelEdit();
            vattuBindingSource.Position = position;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int position = vattuBindingSource.Position;
            this.vattuTableAdapter.Fill(this.qLVT_DATHANGDataSet.Vattu);
            vattuBindingSource.Position = position;
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

        private void FormVatTu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.flagCloseFormVT == false)
            {
                DialogResult dr = MessageBox.Show("Dữ liệu Form Vật Tư vẫn chưa lưu vào Database! \nBạn có chắn chắn muốn thoát?", "Thông báo",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else if (dr == DialogResult.Yes)
                {
                    Program.flagCloseFormVT = true;
                }

            }
        }
    }
}