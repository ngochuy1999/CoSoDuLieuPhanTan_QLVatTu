namespace QLVT
{
    partial class FormTaoTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaoTaiKhoan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.rdUser = new System.Windows.Forms.RadioButton();
            this.rdChiNhanh = new System.Windows.Forms.RadioButton();
            this.rdCongTy = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.btnUser);
            this.groupBox1.Controls.Add(this.rdUser);
            this.groupBox1.Controls.Add(this.rdChiNhanh);
            this.groupBox1.Controls.Add(this.rdCongTy);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbUser);
            this.groupBox1.Controls.Add(this.cbShow);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbLogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 311);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(405, 198);
            this.btnClose.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 32);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Location = new System.Drawing.Point(298, 198);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 32);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Tạo Login";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnUser
            // 
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnUser.Location = new System.Drawing.Point(505, 128);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(31, 21);
            this.btnUser.TabIndex = 7;
            this.btnUser.Text = "...";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // rdUser
            // 
            this.rdUser.AutoSize = true;
            this.rdUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdUser.Location = new System.Drawing.Point(463, 164);
            this.rdUser.Name = "rdUser";
            this.rdUser.Size = new System.Drawing.Size(47, 17);
            this.rdUser.TabIndex = 11;
            this.rdUser.TabStop = true;
            this.rdUser.Text = "User";
            this.rdUser.UseVisualStyleBackColor = true;
            // 
            // rdChiNhanh
            // 
            this.rdChiNhanh.AutoSize = true;
            this.rdChiNhanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdChiNhanh.Location = new System.Drawing.Point(376, 164);
            this.rdChiNhanh.Name = "rdChiNhanh";
            this.rdChiNhanh.Size = new System.Drawing.Size(73, 17);
            this.rdChiNhanh.TabIndex = 10;
            this.rdChiNhanh.TabStop = true;
            this.rdChiNhanh.Text = "Chi nhánh";
            this.rdChiNhanh.UseVisualStyleBackColor = true;
            // 
            // rdCongTy
            // 
            this.rdCongTy.AutoSize = true;
            this.rdCongTy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdCongTy.Location = new System.Drawing.Point(299, 164);
            this.rdCongTy.Name = "rdCongTy";
            this.rdCongTy.Size = new System.Drawing.Size(63, 17);
            this.rdCongTy.TabIndex = 9;
            this.rdCongTy.TabStop = true;
            this.rdCongTy.Text = "Công ty";
            this.rdCongTy.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Role:";
            // 
            // tbUser
            // 
            this.tbUser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbUser.Enabled = false;
            this.tbUser.Location = new System.Drawing.Point(298, 128);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(201, 21);
            this.tbUser.TabIndex = 6;
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShow.Location = new System.Drawing.Point(505, 96);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(52, 17);
            this.cbShow.TabIndex = 5;
            this.cbShow.Text = "Show";
            this.cbShow.UseVisualStyleBackColor = true;
            this.cbShow.CheckedChanged += new System.EventHandler(this.cbShow_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(298, 94);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(201, 21);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(298, 60);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(201, 21);
            this.tbLogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.ImageOptions.Image")));
            this.labelControl1.Location = new System.Drawing.Point(44, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(128, 128);
            this.labelControl1.TabIndex = 16;
            // 
            // FormTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 311);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTaoTaiKhoan";
            this.Text = "Tạo Tài khoản";
            this.Load += new System.EventHandler(this.FormTaoTaiKhoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.RadioButton rdUser;
        private System.Windows.Forms.RadioButton rdChiNhanh;
        private System.Windows.Forms.RadioButton rdCongTy;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.CheckBox cbShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}