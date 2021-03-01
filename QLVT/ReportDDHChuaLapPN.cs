using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using System.Data;


namespace QLVT
{
    public partial class ReportDDHChuaLapPN : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDDHChuaLapPN()
        {
            InitializeComponent();
        }
        private void ReportDDHChuaLapPN_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            sP_DanhSachDDHChuaLapPNTableAdapter1.Connection.ConnectionString = Program.connectionString;
            BindingSource bdsCN = Program.bds_dspm;
            lbChiNhanh.Text = (((DataRowView)bdsCN[bdsCN.Position])["TENCN"].ToString());
            sP_DanhSachDDHChuaLapPNTableAdapter1.Fill(this.qlvT_DATHANGDataSet1.SP_DanhSachDDHChuaLapPN);
        }
    }
}
