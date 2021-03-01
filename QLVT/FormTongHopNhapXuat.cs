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
    public partial class FormTongHopNhapXuat : DevExpress.XtraEditors.XtraForm
    {
        public FormTongHopNhapXuat()
        {
            InitializeComponent();
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
            else
            {
                ReportTongHopNhapXuat rpNhapXuat = new ReportTongHopNhapXuat(deStart.DateTime, deEnd.DateTime);
                ReportPrintTool rpt = new ReportPrintTool(rpNhapXuat);
                rpNhapXuat.ShowPreviewDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTongHopNhapXuat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formMain.Enabled = true;
        }
    }
}