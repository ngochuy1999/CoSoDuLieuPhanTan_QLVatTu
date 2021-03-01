using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QLVT;

namespace QLVT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";
        public static string connectionString = "";

        public static String database = "QLVT_DATHANG";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static int manv;
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mChinhanh = 0;
        public static int maNVChuyenCN;

        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập
        public static SqlConnection connection;     //Connection global giúp FormMain sử dụng connection từ LoginForm
        public static FormMain formMain;
        public static LoginForm loginForm;
        public static FormNhanVien formNhanVien;
        public static FormTaoTaiKhoan FormTaoTaiKhoan;
        public static FormHoatDongNhanVien FormHoatDongNhanVien;
        public static FormVatTu FormVatTu;
        public static FormKho FormKho;
        public static PopupFormNVTrung PopupFormNVTrung;
        public static SubFormNhanVien SubFormNhanVien;
        public static SubFormDDH SubFormDDH;
        public static SubFormPhieuNhap SubFormPhieuNhap;
        public static SubFormPhieuXuat SubFormPhieuXuat;
        public static SubFormCTDDH SubFormCTDDH;
        public static SubFormCTPN SubFormCTPN;
        public static SubFormCTPX SubFormCTPX;
        public static FormChiTietNhapXuat FormChiTietNhapXuat;
        public static FormTongHopNhapXuat FormTongHopNhapXuat;


        public static bool flagCloseFormNV;
        public static bool flagCloseFormVT;
        public static bool flagCloseFormKho;
        public static bool flagCloseFormTaoTaiKhoan;
            
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            loginForm = new LoginForm();
            Application.Run(loginForm);
         

        }
    }
}
