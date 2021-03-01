using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using System.Data;

namespace QLVT
{
    public partial class ReportDSNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDSNhanVien()
        {
            InitializeComponent();
        }

        private void ReportDSNhanVien_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            sP_DanhSachNhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
            BindingSource bdsCN = Program.bds_dspm;
            lbChiNhanh.Text = (((DataRowView)bdsCN[bdsCN.Position])["TENCN"].ToString());
            sP_DanhSachNhanVienTableAdapter.Fill(this.qlvT_DATHANGDataSet1.SP_DanhSachNhanVien);
        }
    }
}
