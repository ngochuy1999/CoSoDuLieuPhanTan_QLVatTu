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
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace QLVT
{
    public partial class FormHoatDongNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public static int manv;     //Để khi Report chạy sẽ lấy dữ liệu từ đây qua
        public static String name;
        public static String dateOfBirth;
        public static String address;
        public static int salary;
        public static String macn;

        public FormHoatDongNhanVien()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            Program.SubFormNhanVien = new SubFormNhanVien();
            Program.SubFormNhanVien.Show();
            Program.formMain.Enabled = false;
        }

        private void FormHoatDongNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formMain.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbMANV_TextChanged(object sender, EventArgs e)
        {
            String query = "EXEC SP_InfoNV @p1";
            SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
            sqlCommand.Parameters.AddWithValue("@p1", tbMANV.Text);
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
            manv = int.Parse(dataReader.GetValue(0).ToString());
            name = dataReader.GetValue(1).ToString();
            dateOfBirth = dataReader.GetValue(2).ToString();
            address = dataReader.GetValue(3).ToString();
            salary = int.Parse(dataReader.GetValue(4).ToString());
            macn = dataReader.GetValue(5).ToString();
            tbName.Text = name;
            dataReader.Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string query = "DECLARE	@result int " +
                           "EXEC @result = SP_CheckID @p1, @p2 " +
                           "SELECT 'result' = @result";
            SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
            sqlCommand.Parameters.AddWithValue("@p1", tbMANV.Text);
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

                dataReader.Close();
                return;
            }
            dataReader.Read();
            int resultCheckMANV = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            if (resultCheckMANV != 1)
            {
                MessageBox.Show("Mã NV không tồn tại ở Chi Nhánh hiện tại vui lòng kiểm tra lại!\n", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (deStart.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn tháng năm bắt đầu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                deStart.Focus();
            }
            else if (deEnd.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn tháng năm kết thúc!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                deEnd.Focus();
            }
            else if (DateTime.Compare(deStart.DateTime, deEnd.DateTime) > 0)
            {
                MessageBox.Show("Tháng năm kết thúc < Tháng năm bắt đầu. Vui lòng kiểm tra lại!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                deEnd.Focus();
            }
            else if (!(rdNhap.Checked || rdXuat.Checked))
            {
                MessageBox.Show("Vui lòng chọn hàng Nhập or Xuất!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String role = (rdNhap.Checked) ? "NHAP" : "XUAT";

                ReportHoatDongNhanVien reportHoatDongNhanVien = new ReportHoatDongNhanVien(manv, deStart.DateTime, deEnd.DateTime, role);
                ReportPrintTool rpt = new ReportPrintTool(reportHoatDongNhanVien);
                reportHoatDongNhanVien.ShowPreviewDialog();
            }
        }
    }
}