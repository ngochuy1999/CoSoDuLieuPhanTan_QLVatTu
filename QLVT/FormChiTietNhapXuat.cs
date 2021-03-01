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
using DevExpress.XtraReports.UI;

namespace QLVT
{
    public partial class FormChiTietNhapXuat : DevExpress.XtraEditors.XtraForm
    {
        public FormChiTietNhapXuat()
        {
            InitializeComponent();
        }

        private void FormChiTietNhapXuat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formMain.Enabled = true;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
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

                //Từ tháng và năm phải chuyển ngayBD về MM-01-yyyy và ngày ngayKT về MM-31-yyyy
                DateTime dateTimeBD = new DateTime(deStart.DateTime.Year, deStart.DateTime.Month, 1);
                int dayOfMounthKT = DateTime.DaysInMonth(deEnd.DateTime.Year, deEnd.DateTime.Month);
                DateTime dateTimeKT = new DateTime(deEnd.DateTime.Year, deEnd.DateTime.Month, dayOfMounthKT);

                String ngayBD = dateTimeBD.ToString("MM-dd-yyyy");    // chuyển về đúng định dạng trong SQL
                String ngayKT = dateTimeKT.ToString("MM-dd-yyyy");
                String role = (rdNhap.Checked) ? "NHAP" : "XUAT";
                String permissions = Program.mGroup;

                ReportChitietNhapXuat reportChitietNhapXuat = new ReportChitietNhapXuat(ngayBD, ngayKT, role, permissions);
                ReportPrintTool rpt = new ReportPrintTool(reportChitietNhapXuat);
                reportChitietNhapXuat.ShowPreviewDialog();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}