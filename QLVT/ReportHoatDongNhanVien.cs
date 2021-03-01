using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using System.Data;

namespace QLVT
{
    public partial class ReportHoatDongNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        private int manv;
        private DateTime ngayBD;
        private DateTime ngayKT;
        private String role;
        public ReportHoatDongNhanVien(int manv, DateTime ngayBD, DateTime ngayKT, String role)
        {
            this.manv = manv;
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
            this.role = role;
            InitializeComponent();
        }

        private void ReportHoatDongNhanVien_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            sP_HoatDongNhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;

            String query = "EXEC SP_HoatDongNhanVien @p1, @p2, @p3, @p4";
            SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
            sqlCommand.Parameters.AddWithValue("@p1", this.manv);
            sqlCommand.Parameters.AddWithValue("@p2", this.ngayBD);
            sqlCommand.Parameters.AddWithValue("@p3", this.ngayKT);
            sqlCommand.Parameters.AddWithValue("@p4", this.role);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            this.DataSource = dataTable;    //Lưu ý DataSource, DataMember, DataAdapter bên Design phải để None

            lbMaNV.Text = FormHoatDongNhanVien.manv.ToString();
            lbHoTen.Text = FormHoatDongNhanVien.name;
            lbNgaysinh.Text = DateTime.Parse(FormHoatDongNhanVien.dateOfBirth).ToString("dd/MM/yyyy");
            lbDiaChi.Text = FormHoatDongNhanVien.address;
            lbLuong.Text = FormHoatDongNhanVien.salary.ToString("#,#");
            lbCN.Text = FormHoatDongNhanVien.macn;
            lbBangKeChungTu.Text = "BẢNG KÊ CHỨNG TỪ PHIẾU ";
            lbBangKeChungTu.Text += (this.role == "NHAP") ? "NHẬP" : "XUẤT";
            tableCell3.Text = (this.role == "NHAP") ? "Mã PN" : "Mã PX";
            lbTuNgay.Text = ngayBD.ToString("dd/MM/yyyy");
            lbDenNgay.Text = ngayKT.ToString("dd/MM/yyyy");
        }

    }
}
