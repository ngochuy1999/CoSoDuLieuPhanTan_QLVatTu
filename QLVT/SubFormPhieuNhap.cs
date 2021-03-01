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
    public partial class SubFormPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        private bool flagSuccess = false;
        public SubFormPhieuNhap()
        {
            InitializeComponent();
        }

        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phieuNhapBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void SubFormPhieuNhap_Load(object sender, EventArgs e)
        {
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectionString;
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuNhap);
            this.phieuNhapBindingSource.DataSource = Program.formNhanVien.getPhieuNhapBDS();

        }
        private void SubFormPhieuNhap_Shown(object sender, EventArgs e)
        {
            //Đặt trong Event Load thì Thread kết thúc sớm hơn Fill nên không đồng bộ, nên dùng Event có thứ tự sau
            this.phieuNhapBindingSource.AddNew();
            BindingSource tempDDH = Program.formNhanVien.getDatHangBDS();
            tbMaSoDDH.Text = ((DataRowView)tempDDH[tempDDH.Position])["MasoDDH"].ToString().Trim();
            ((DataRowView)phieuNhapBindingSource[phieuNhapBindingSource.Position])["MAKHO"] = ((DataRowView)tempDDH[tempDDH.Position])["MAKHO"].ToString().Trim();
            ((DataRowView)phieuNhapBindingSource[phieuNhapBindingSource.Position])["MANV"] = Program.manv;
            ((DataRowView)phieuNhapBindingSource[phieuNhapBindingSource.Position])["NGAY"] = DateTime.Today;
        }
        private void SubFormPhieuNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagSuccess == false) phieuNhapBindingSource.CancelEdit();
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
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!checkValidate(tbMaPN, "Mã Phiếu Nhập is not empty!")) return;
            string query = "DECLARE	@result int " +
                           "EXEC @result = SP_CheckID @p1, @p2 " +
                           "SELECT 'result' = @result";
            SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
            sqlCommand.Parameters.AddWithValue("@p1", tbMaPN.Text);
            sqlCommand.Parameters.AddWithValue("@p2", "MAPN");
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
            int positionMaPN = phieuNhapBindingSource.Find("MAPN", tbMaPN.Text);
            int postionCurrent = phieuNhapBindingSource.Position;
            //Bỏ qua TH tồn tại ở CN hiện tại khi vị trí MANV đang nhập đúng băng vị trí đang đứng
            if (result == 1 && (positionMaPN != postionCurrent))
            {
                MessageBox.Show("Mã Phiếu Nhập đã tồn tại ở Chi Nhánh hiện tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (result == 2)
            {
                MessageBox.Show("Mã Phiếu Nhập đã tồn tại ở Chi Nhánh khác!", "Thông báo",
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
                        this.phieuNhapBindingSource.EndEdit();
                        this.phieuNhapTableAdapter.Update(Program.formNhanVien.getDataSet().PhieuNhap);
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