using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLVT
{
    public partial class ReportChitietNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        private String ngayBD;
        private String ngayKT;
        private String role;
        private String permissions;
        public ReportChitietNhapXuat(String ngayBD, String ngayKT, String role, String permissions)
        {
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
            this.role = role;
            this.permissions = permissions;

            InitializeComponent();
        }

        private void ReportChitietNhapXuat_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lbTitle.Text = "BẢNG KÊ CHI TIẾT HÀNG ";
            lbTitle.Text += (this.role == "NHAP") ? "NHẬP" : "XUẤT";
            String[] arrNgayBD = this.ngayBD.Split('-');
            String[] arrNgayKT = this.ngayKT.Split('-');
            lbNgayThang.Text = "Từ tháng " + arrNgayBD[0] + "/" + arrNgayBD[2];
            lbNgayThang.Text += " đến tháng " + arrNgayKT[0] + "/" + arrNgayKT[2];

            if (Program.mGroup == "CONGTY")
            {
                lbChiNhanh.Text = "CN1: TP.Hồ Chí Minh - CN2: Cần Thơ";
            }
            else
            {
                BindingSource bdsCN = Program.bds_dspm;
                lbChiNhanh.Text = (((DataRowView)bdsCN[bdsCN.Position])["TENCN"].ToString()); ;
            }

            String query = "EXEC SP_BangKeChiTietNhap_Xuat @p1, @p2, @p3, @p4";
            SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
            sqlCommand.Parameters.AddWithValue("@p1", this.ngayBD);
            sqlCommand.Parameters.AddWithValue("@p2", this.ngayKT);
            sqlCommand.Parameters.AddWithValue("@p3", this.permissions);
            sqlCommand.Parameters.AddWithValue("@p4", this.role);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            this.DataSource = dataTable;    //Lưu ý DataSource, DataMember, DataAdapter bên Design phải để None
        }

    }
}
