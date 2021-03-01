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
    public partial class SubFormDDH : DevExpress.XtraEditors.XtraForm
    {
        private bool flagSuccess = false;
        public SubFormDDH()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datHangBDS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void SubFormDDH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet.Kho);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);
            this.datHangBDS.DataSource = Program.formNhanVien.getDatHangBDS();
        }
        private void SubFormDDH_Shown(object sender, EventArgs e)
        {
            this.datHangBDS.AddNew();
            ((DataRowView)datHangBDS[datHangBDS.Position])["MANV"] = Program.manv;
            ((DataRowView)datHangBDS[datHangBDS.Position])["NGAY"] = DateTime.Today;
            tbMaKho.Text = ((DataRowView)khoBDS[khoBDS.Position])["MAKHO"].ToString().Trim();
        }
        private void SubFormDDH_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagSuccess == false) datHangBDS.CancelEdit();
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
            if (khoBDS.Position != -1) //Trường hợp không có dữ liệu
            {
                tbMaKho.Text = gvKho.GetRowCellValue(khoBDS.Position, "MAKHO").ToString().Trim();
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!checkValidate(tbMaDDH, "Mã DDH is not empty!")) return;
            if (!checkValidate(tbNCC, "Nhà cung cấp is not empty!")) return;
            if (!checkValidate(tbMaKho, "Mã Kho is not empty!")) return;

            string query = "DECLARE	@result int " +
                           "EXEC @result = SP_CheckID @p1, @p2 " +
                           "SELECT 'result' = @result";
            SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
            sqlCommand.Parameters.AddWithValue("@p1", tbMaDDH.Text);
            sqlCommand.Parameters.AddWithValue("@p2", "MADDH");
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

            int positionMaDDH = datHangBDS.Find("MasoDDH", tbMaDDH.Text);
            int postionCurrent = datHangBDS.Position;
            //Bỏ qua TH tồn tại ở CN hiện tại khi vị trí MasoDDH đang nhập đúng băng vị trí đang đứng
            if (result == 1 && (positionMaDDH != postionCurrent))
            {
                MessageBox.Show("Mã DDH đã tồn tại ở Chi Nhánh hiện tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (result == 2)
            {
                MessageBox.Show("Mã DDH đã tồn tại ở Chi Nhánh khác!", "Thông báo",
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
                        this.datHangBDS.EndEdit();
                        this.datHangTableAdapter.Update(Program.formNhanVien.getDataSet().DatHang);
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