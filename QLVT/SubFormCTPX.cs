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
    public partial class SubFormCTPX : DevExpress.XtraEditors.XtraForm
    {
        private bool flagSuccess = false;
        public SubFormCTPX()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vattuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void SubFormCTPX_Load(object sender, EventArgs e)
        {
            this.vattuTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connectionString;
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPX);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.qLVT_DATHANGDataSet.Vattu);
            this.cTPXBindingSource.DataSource = Program.formNhanVien.getCTPhieuXuatBDS();

        }
        private void SubFormCTPX_Shown(object sender, EventArgs e)
        {
            this.cTPXBindingSource.AddNew();
            BindingSource tempPX = Program.formNhanVien.getPhieuXuatBDS();
            if (tempPX.Position != -1 && vattuBindingSource.Position != -1)
            {
                tbMaPX.Text = ((DataRowView)tempPX[tempPX.Position])["MAPX"].ToString().Trim();
                tbMaVT.Text = ((DataRowView)vattuBindingSource[vattuBindingSource.Position])["MAVT"].ToString().Trim();
                nuSoLuong.Maximum = int.Parse(gvVatTu.GetRowCellValue(vattuBindingSource.Position, "SOLUONGTON").ToString().Trim());
                nuSoLuong.Value = nuSoLuong.Minimum;
                nuDonGia.Value = 0;
                ((DataRowView)cTPXBindingSource[cTPXBindingSource.Position])["SOLUONG"] = nuSoLuong.Minimum;
                ((DataRowView)cTPXBindingSource[cTPXBindingSource.Position])["DONGIA"] = 0;
            }
        }
        private void SubFormCTPX_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagSuccess == false) cTPXBindingSource.CancelEdit();
            Program.formMain.Enabled = true;
        }
        private void gvVatTu_Click(object sender, EventArgs e)
        {
            if (vattuBindingSource.Position != -1) //Trường hợp không có dữ liệu
            {
                int soluong = int.Parse(gvVatTu.GetRowCellValue(vattuBindingSource.Position, "SOLUONGTON").ToString().Trim());
                if (soluong <= 0)
                {
                    MessageBox.Show("Vật Tư không còn hàng. Vui lòng kiểm tra lại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    nuSoLuong.Maximum = int.Parse(gvVatTu.GetRowCellValue(vattuBindingSource.Position, "SOLUONGTON").ToString().Trim());
                    nuSoLuong.Minimum = 1;
                    tbMaVT.Text = gvVatTu.GetRowCellValue(vattuBindingSource.Position, "MAVT").ToString().Trim();
                }

            }
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
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!checkValidate(tbMaPX, "Mã Phiếu Xuất is not empty!")) return;
            if (!checkValidate(tbMaVT, "Mã VT is not empty!")) return;
            if (nuSoLuong.Value == 0)    //Trường hợp khi vừa Load vật tư số lượng tồn còn 0
            {
                MessageBox.Show("Số lượng phải > 0!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Kiểm tra trùng CTPN
            int positionMaVT = cTPXBindingSource.Find("MAVT", tbMaVT.Text);
            if (positionMaVT != -1 && (positionMaVT != cTPXBindingSource.Position))
            {
                MessageBox.Show("Trùng Mã số PX & Mã VT của chi tiết PX khác!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    //Lưu lại MAVT và SOLUONG để khi EndEdit không bị mất dữ liệu vì con trỏ về đầu
                    string maVT = tbMaVT.Text;
                    int soLuong = int.Parse(nuSoLuong.Value.ToString());

                    this.cTPXBindingSource.EndEdit();
                    this.cTPXTableAdapter.Update(Program.formNhanVien.getDataSet().CTPX);
                    string query = "DECLARE	@result int " +
                           "EXEC @result = SP_UpdateVatTu @p1, @p2, @p3 " +
                           "SELECT 'result' = @result";
                    SqlCommand sqlCommand = new SqlCommand(query, Program.connection);

                    sqlCommand.Parameters.AddWithValue("@p1", maVT);
                    sqlCommand.Parameters.AddWithValue("@p2", soLuong);
                    sqlCommand.Parameters.AddWithValue("@p3", "DECREASE");
                    SqlDataReader dataReader = null;
                    try
                    {
                        dataReader = sqlCommand.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật Vật Tư vào Database!\n" + ex.Message, "Notification",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataReader.Close();
                        return;
                    }
                    dataReader.Read();
                    int result = int.Parse(dataReader.GetValue(0).ToString());
                    dataReader.Close();
                    if (result == 0)
                    {
                        MessageBox.Show("Lỗi khi cập nhật Vật Tư vào Database!\n", "Notification",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
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