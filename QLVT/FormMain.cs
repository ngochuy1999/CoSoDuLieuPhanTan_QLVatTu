using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using QLVT;
using DevExpress.XtraReports.UI;

namespace QLVT
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            
            string query = "EXEC SP_THONGTINDANGNHAP " + Program.mlogin;
            SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
            //sqlCommand.CommandType = CommandType.Text;
            //sqlCommand.CommandTimeout = 600;      //mặc định 3p cái nay set 10p
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            dataReader.Read();
            Program.manv = int.Parse(dataReader.GetString(0));
            sslMANV.Text = "Mã NV: " + Program.manv;
            sslTEN.Text = "Họ và tên: " + dataReader.GetString(1);
            Program.mGroup = dataReader.GetString(2);    //Đưa về global cho các subForm
            sslNHOM.Text = "Nhóm: " + Program.mGroup;
            dataReader.Close();

            if (Program.mGroup == "USER")
            {
                ribbonPageGroup4.Visible = false;   //Ẩn nút Tạo tài khoản
            }
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                ribbonPageGroup11.Visible = false;
            }
        }

        private void barbtnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormNhanVien));
            if (form != null) form.Activate();
            else
            {
                Program.formNhanVien = new FormNhanVien();
                Program.formNhanVien.MdiParent = this;
                Program.formNhanVien.Show();
            }
        }

        private void barbtnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barbtnTaoTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormTaoTaiKhoan));
            if (form != null) form.Activate();
            else
            {
                Program.FormTaoTaiKhoan = new FormTaoTaiKhoan();
                Program.FormTaoTaiKhoan.MdiParent = this;
                Program.FormTaoTaiKhoan.Show();
            }
        }

        private void barbtnVatTu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormVatTu));
            if (form != null) form.Activate();
            else
            {
                Program.FormVatTu = new FormVatTu();
                Program.FormVatTu.MdiParent = this;
                Program.FormVatTu.Show();
            }
        }

        private void barbtnKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormKho));
            if (form != null) form.Activate();
            else
            {
                Program.FormKho = new FormKho();
                Program.FormKho.MdiParent = this;
                Program.FormKho.Show();
            }
        }
        private void btnDSVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportDSVatTu reportDSVatTu = new ReportDSVatTu();
            ReportPrintTool rpt = new ReportPrintTool(reportDSVatTu);
            reportDSVatTu.ShowPreviewDialog();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Program.FormChiTietNhapXuat = new FormChiTietNhapXuat();
            Program.FormChiTietNhapXuat.Show();
            Program.formMain.Enabled = false;
        }

        private void btnLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btDSNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReportDSNhanVien reportDSNhanVien = new ReportDSNhanVien();
            ReportPrintTool rpt = new ReportPrintTool(reportDSNhanVien);
            reportDSNhanVien.ShowPreviewDialog();
        }

        private void btnCN1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormNhanVien));
            if (form != null) form.Activate();
            else
            {
                Program.formNhanVien = new FormNhanVien();
                Program.formNhanVien.MdiParent = this;
                Program.formNhanVien.Show();
            }
            Program.formNhanVien.cmbChiNhanh.SelectedIndex = 0;
            btnCN.Caption = "Chi Nhánh Hồ Chí Minh";
            changeConnectionString();
        }

        private void btnCN2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormNhanVien));
            if (form != null) form.Activate();
            else
            {
                Program.formNhanVien = new FormNhanVien();
                Program.formNhanVien.MdiParent = this;
                Program.formNhanVien.Show();
            }
            Program.formNhanVien.cmbChiNhanh.SelectedIndex = 1;
            btnCN.Caption = "Chi Nhánh Cần Thơ";
            changeConnectionString();
            
        }
        private void changeConnectionString()
        {
            if (Program.formNhanVien.cmbChiNhanh.SelectedValue != null && Program.servername != Program.formNhanVien.cmbChiNhanh.SelectedValue.ToString()) //Khi enable FormNhanVien thì value = null nên lỗi
            {
                Program.servername = Program.formNhanVien.cmbChiNhanh.SelectedValue.ToString();
                if (Program.mloginDN != Program.remotelogin) //Why?
                {
                    Program.mloginDN = Program.remotelogin;
                    Program.passwordDN = Program.remotepassword;
                }
                else
                {
                    Program.mloginDN = Program.mlogin;
                    Program.passwordDN  = Program.password;
                }
                try
                {
                    Program.connectionString = "Server=" + Program.servername + ";"
                                    + "database=QLVT_DATHANG;"
                                    + "User id=" + Program.mloginDN + ";"
                                    + "Password=" + Program.passwordDN;
                    Program.connection = new SqlConnection(Program.connectionString);
                    Program.connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kết nối Server thất bại! " + ex.Message, "Notification", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnHoatDongNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Program.FormHoatDongNhanVien = new FormHoatDongNhanVien();
            Program.FormHoatDongNhanVien.Show();
            Program.formMain.Enabled = false;
        }

        private void btnDDHChuaLapPN_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReportDDHChuaLapPN reportDDHChuaLapPN = new ReportDDHChuaLapPN();
            ReportPrintTool rpt = new ReportPrintTool(reportDDHChuaLapPN);
            reportDDHChuaLapPN.ShowPreviewDialog();
        }

        private void btnTongHopNX_ItemClick(object sender, ItemClickEventArgs e)
        {
            Program.FormTongHopNhapXuat = new FormTongHopNhapXuat();
            Program.FormTongHopNhapXuat.Show();
            Program.formMain.Enabled = false;
        }
    }
}