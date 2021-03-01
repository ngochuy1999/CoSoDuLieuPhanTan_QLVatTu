namespace QLVT
{
    partial class FormHoatDongNhanVien
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
            this.tbMANV = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.rdXuat = new System.Windows.Forms.RadioButton();
            this.rdNhap = new System.Windows.Forms.RadioButton();
            this.tbName = new System.Windows.Forms.TextBox();
            this.deEnd = new DevExpress.XtraEditors.DateEdit();
            this.deStart = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStart.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMANV
            // 
            this.tbMANV.Location = new System.Drawing.Point(175, 94);
            this.tbMANV.Name = "tbMANV";
            this.tbMANV.ReadOnly = true;
            this.tbMANV.Size = new System.Drawing.Size(51, 21);
            this.tbMANV.TabIndex = 28;
            this.tbMANV.TextChanged += new System.EventHandler(this.tbMANV_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(327, 196);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 27);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.Location = new System.Drawing.Point(175, 196);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(100, 27);
            this.btnPreview.TabIndex = 26;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // rdXuat
            // 
            this.rdXuat.AutoSize = true;
            this.rdXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdXuat.Location = new System.Drawing.Point(359, 163);
            this.rdXuat.Name = "rdXuat";
            this.rdXuat.Size = new System.Drawing.Size(47, 17);
            this.rdXuat.TabIndex = 25;
            this.rdXuat.TabStop = true;
            this.rdXuat.Text = "Xuất";
            this.rdXuat.UseVisualStyleBackColor = true;
            // 
            // rdNhap
            // 
            this.rdNhap.AutoSize = true;
            this.rdNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdNhap.Location = new System.Drawing.Point(359, 137);
            this.rdNhap.Name = "rdNhap";
            this.rdNhap.Size = new System.Drawing.Size(50, 17);
            this.rdNhap.TabIndex = 24;
            this.rdNhap.TabStop = true;
            this.rdNhap.Text = "Nhập";
            this.rdNhap.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(371, 95);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(139, 21);
            this.tbName.TabIndex = 23;
            // 
            // deEnd
            // 
            this.deEnd.EditValue = null;
            this.deEnd.Location = new System.Drawing.Point(175, 162);
            this.deEnd.Name = "deEnd";
            this.deEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deEnd.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deEnd.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deEnd.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.deEnd.Size = new System.Drawing.Size(141, 20);
            this.deEnd.TabIndex = 22;
            // 
            // deStart
            // 
            this.deStart.EditValue = null;
            this.deStart.Location = new System.Drawing.Point(175, 136);
            this.deStart.Name = "deStart";
            this.deStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deStart.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deStart.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deStart.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.deStart.Size = new System.Drawing.Size(141, 20);
            this.deStart.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Đến ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Họ và Tên:";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowser.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnBrowser.Location = new System.Drawing.Point(232, 93);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(31, 21);
            this.btnBrowser.TabIndex = 17;
            this.btnBrowser.Text = "...";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(157, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hoạt Động Nhân Viên";
            // 
            // FormHoatDongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 268);
            this.Controls.Add(this.tbMANV);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.rdXuat);
            this.Controls.Add(this.rdNhap);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.deEnd);
            this.Controls.Add(this.deStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHoatDongNhanVien";
            this.Text = "Hoạt Động Nhân Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHoatDongNhanVien_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.deEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStart.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbMANV;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.RadioButton rdXuat;
        private System.Windows.Forms.RadioButton rdNhap;
        private System.Windows.Forms.TextBox tbName;
        private DevExpress.XtraEditors.DateEdit deEnd;
        private DevExpress.XtraEditors.DateEdit deStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}