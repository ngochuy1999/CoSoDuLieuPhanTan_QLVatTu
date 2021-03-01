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
    public partial class FormTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public static int manv = 0;

        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "CONGTY")
            {
                rdChiNhanh.Enabled = rdUser.Enabled = false;
            }
            else if (Program.mGroup == "CHINHANH")
            {
                rdCongTy.Enabled = false;
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Program.SubFormNhanVien = new SubFormNhanVien();
            Program.SubFormNhanVien.Show();
            Program.formMain.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!checkValidate(tbLogin, "Login name is not empty!")) return;
            if (!checkValidate(tbPassword, "Password is not empty!")) return;
            if (!checkValidate(tbUser, "User is not empty!")) return;
            if (!(rdCongTy.Checked || rdChiNhanh.Checked || rdUser.Checked))
            {
                MessageBox.Show("Role is not empty!!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbLogin.Text.Contains(" "))
            {
                MessageBox.Show("Login name không được chứa khoảng trắng!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "DECLARE	@result int " +
                           "EXEC @result = SP_CheckID @p1, @p2 " +
                           "SELECT 'result' = @result";
            SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
            sqlCommand.Parameters.AddWithValue("@p1", tbUser.Text);
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
                return;
            }
            dataReader.Read();
            int resultCheckMANV = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            if (resultCheckMANV != 1)
            {
                MessageBox.Show("Mã NV không tồn tại ở Chi Nhánh hiện tại vui lòng kiểm tra lại!\n", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbLogin.Focus();
                return;
            }

            query = "DECLARE	@result int " +
                           "EXEC @result = SP_CheckLogin @p1, @p2 " +
                           "SELECT 'result' = @result";
            sqlCommand = new SqlCommand(query, Program.connection);
            sqlCommand.Parameters.AddWithValue("@p1", tbLogin.Text);
            sqlCommand.Parameters.AddWithValue("@p2", tbUser.Text);
            dataReader = null;
            try
            {
                dataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Notification",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataReader.Read();
            int resultCheckLogin = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();

            if (resultCheckLogin == 1)
            {
                MessageBox.Show("Login name bị trùng. Vui lòng chọn tên login khác!\n", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbLogin.Focus();
                return;
            }
            else if (resultCheckLogin == 2)
            {
                MessageBox.Show("User bị trùng. Vui lòng chọn nhân viên khác!\n", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnUser.Focus();
                return;
            }
            else
            {
                String role = rdCongTy.Checked ? "CONGTY" : (rdChiNhanh.Checked ? "CHINHANH" : "USER");
                query = "DECLARE @result int " +
                           "EXEC @result = SP_TAOLOGIN @p1, @p2, @p3, @p4 " +
                           "SELECT 'result' = @result";
                sqlCommand = new SqlCommand(query, Program.connection);
                sqlCommand.Parameters.AddWithValue("@p1", tbLogin.Text);
                sqlCommand.Parameters.AddWithValue("@p2", tbPassword.Text);
                sqlCommand.Parameters.AddWithValue("@p3", tbUser.Text);
                sqlCommand.Parameters.AddWithValue("@p4", role);
                try
                {
                    dataReader = sqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();
                if (result == 0)
                {
                    MessageBox.Show("Tạo tài khoản thành công!", "Notification",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbLogin.Clear();
                    tbPassword.Clear();
                    tbUser.Clear();
                    rdCongTy.Checked = rdChiNhanh.Checked = rdUser.Checked = false;
                    tbLogin.Focus();
                }
            }
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = (cbShow.Checked) ? false : true;
        }

        private bool checkValidate(TextBox tb, string str)
        {
            if (tb.Text.Trim().Equals(""))
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
            return true;
        }

        private void FormTaoTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool checkNonEmpty = !tbLogin.Text.Equals("") || !tbPassword.Text.Equals("") || !tbUser.Text.Equals("");
            bool checkNonCheck = rdCongTy.Checked || rdChiNhanh.Checked || rdUser.Checked;
            Program.flagCloseFormTaoTaiKhoan = (checkNonEmpty || checkNonCheck) ? false : true;

            if (Program.flagCloseFormTaoTaiKhoan == false)
            {
                DialogResult dr = MessageBox.Show("Dữ liệu Form Tài Khoản vẫn chưa lưu! \nBạn có chắn chắn muốn thoát?", "Thông báo",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else if (dr == DialogResult.Yes)
                {
                    Program.flagCloseFormTaoTaiKhoan = true;
                }
            }
        }
    }
}