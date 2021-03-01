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
    public partial class SubFormNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public SubFormNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

     
        private void SubFormNhanVien_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                cbChiNhanh.Visible = false;
                label1.Visible = false;
            }
            /*
             * Trước khi đổ dữ liệu cần cập nhập Connection của Adapter điều này xảy ra khi
             * Trường hợp này xảy ra khi đăng nhập từ 1 Nhân viên ở CN2 và cần GrowTable dữ liệu cũng của CN2
            */
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
            this.cbChiNhanh.DataSource = Program.bds_dspm; //DataSource của cbChiNhanh tham chiếu đến bindingSource ở LoginForm
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";

        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbChiNhanh.ValueMember != "")   //Xử lý trường hợp Event autorun khi vừa khởi chạy project
            {
                if (this.cbChiNhanh.SelectedValue != null && Program.servername != this.cbChiNhanh.SelectedValue.ToString()) //Khi enable FormNhanVien thì value = null nên lỗi
                {
                    Program.servername = this.cbChiNhanh.SelectedValue.ToString();
                    if (Program.mloginDN != Program.remotelogin) //Why?
                    {
                        Program.mloginDN = Program.remotelogin;
                        Program.passwordDN = Program.remotepassword;
                    }
                    else
                    {
                        Program.mloginDN = Program.mlogin;
                        Program.passwordDN = Program.password;
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
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
                    this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Program.FormTaoTaiKhoan != null)    //Thỏa điều kiện Form Tạo TK đang mở => có đối tượng => mới set được value
            {
                Program.FormTaoTaiKhoan.tbUser.Text = ((DataRowView)nhanVienBindingSource.Current)["MANV"].ToString();
            }

            if (Program.FormHoatDongNhanVien != null) //Thỏa điều kiện Form Báo cáo Hoạt động NV đang mở => có đối tượng => mới set được value
            {
                Program.FormHoatDongNhanVien.tbMANV.Text = ((DataRowView)nhanVienBindingSource.Current)["MANV"].ToString();
            }
            this.Close();
        }

        private void SubFormNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formMain.Enabled = true;
        }
    }
}