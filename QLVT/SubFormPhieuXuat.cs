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
    public partial class SubFormPhieuXuat : DevExpress.XtraEditors.XtraForm
    {
        private bool flagSuccess = false;
        public SubFormPhieuXuat()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void SubFormPhieuXuat_Load(object sender, EventArgs e)
        {
            this.khoTableAdapter.Connection.ConnectionString = Program.connectionString;
            //this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectionString;
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuXuat);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet.Kho);
            this.phieuXuatBindingSource.DataSource = Program.formNhanVien.getPhieuXuatBDS();
        }
        private void SubFormPhieuXuat_Shown(object sender, EventArgs e)
        {
            this.phieuXuatBindingSource.AddNew();
            ((DataRowView)phieuXuatBindingSource[phieuXuatBindingSource.Position])["MANV"] = Program.manv;
            ((DataRowView)phieuXuatBindingSource[phieuXuatBindingSource.Position])["NGAY"] = DateTime.Today;
            tbMaKho.Text = ((DataRowView)khoBindingSource[khoBindingSource.Position])["MAKHO"].ToString().Trim();
        }
        private void SubFormPhieuXuat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagSuccess == false) phieuXuatBindingSource.CancelEdit();
            Program.formMain.Enabled = true;
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
        private void gvKho_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (khoBindingSource.Position != -1) //Trường hợp không có dữ liệu
            {
                tbMaKho.Text = gvKho.GetRowCellValue(khoBindingSource.Position, "MAKHO").ToString().Trim();
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!checkValidate(tbMaPX, "Mã Phiếu Xuất is not empty!")) return;
            if (!checkValidate(tbKhachHang, "Họ tên Khách Hàng is not empty!")) return;
            if (!checkValidate(tbMaKho, "Mã Kho is not empty!")) return;
            string query = "DECLARE	@result int " +
                           "EXEC @result = SP_CheckID @p1, @p2 " +
                           "SELECT 'result' = @result";
            SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
            sqlCommand.Parameters.AddWithValue("@p1", tbMaPX.Text);
            sqlCommand.Parameters.AddWithValue("@p2", "MAPX");
            SqlDataReader dataReader = null;
            try
            {
                dataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataReader.Close();
                return;
            }
            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            int positionMaPX = phieuXuatBindingSource.Find("MAPX", tbMaPX.Text);
            int postionCurrent = phieuXuatBindingSource.Position;
            //Bỏ qua TH tồn tại ở CN hiện tại khi vị trí MAPX đang nhập đúng băng vị trí đang đứng
            if (result == 1 && (positionMaPX != postionCurrent))
            {
                MessageBox.Show("Mã Phiếu Xuất đã tồn tại ở Chi Nhánh hiện tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (result == 2)
            {
                MessageBox.Show("Mã Phiếu Xuất đã tồn tại ở Chi Nhánh khác!", "Thông báo",
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
                        this.phieuXuatBindingSource.EndEdit();
                        this.phieuXuatTableAdapter.Update(Program.formNhanVien.getDataSet().PhieuXuat);
                        flagSuccess = true;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}