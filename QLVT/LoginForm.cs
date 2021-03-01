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
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_PHANMANH.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_PHANMANH.V_DS_PHANMANH);
            Program.bds_dspm = this.v_DS_PHANMANHBindingSource;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            executeLogin();
        }
        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter) executeLogin();
        }
        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) executeLogin();
        }

        private void executeLogin()
        {
            if (tbUsername.Text.Trim() == "")
            {
                MessageBox.Show("Username is not empty!", "Error message", MessageBoxButtons.OK);
                tbUsername.Focus();
                return;
            }
            Program.servername = cbChiNhanh.SelectedValue.ToString();
            Program.mlogin = tbUsername.Text;    //Successfully send the userID to Program to push through FormMain
            Program.password = tbPassword.Text;
            Program.connectionString = "Server=" + Program.servername + ";"
                                    + "database=QLVT_DATHANG;"
                                    + "User id=" + Program.mlogin+ ";"
                                    + "Password=" + Program.password;
            Program.connection = new SqlConnection(Program.connectionString);
            try
            {
                Program.connection.Open();
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;
                Program.mChinhanh = cbChiNhanh.SelectedIndex;
                Program.formMain = new FormMain();
                Program.formMain.Activate();
                Program.formMain.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Username or password incorrect " + ex.Message, "Error message", MessageBoxButtons.OK);
                tbUsername.Focus();
                return;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tbUsername.Text.Trim() != "" || tbPassword.Text.Trim() != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Notification", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = (cbShow.Checked) ? false : true;
        }
    }

}