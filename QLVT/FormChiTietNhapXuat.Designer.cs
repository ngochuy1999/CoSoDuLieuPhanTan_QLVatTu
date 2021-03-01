namespace QLVT
{
    partial class FormChiTietNhapXuat
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.deEnd = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.rdXuat = new System.Windows.Forms.RadioButton();
            this.rdNhap = new System.Windows.Forms.RadioButton();
            this.deStart = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStart.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(233, 178);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 27);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.Location = new System.Drawing.Point(96, 178);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(100, 27);
            this.btnPreview.TabIndex = 12;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(42, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bảng kê chi tiết Nhập - Xuất";
            // 
            // deEnd
            // 
            this.deEnd.EditValue = null;
            this.deEnd.Location = new System.Drawing.Point(136, 132);
            this.deEnd.Name = "deEnd";
            this.deEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deEnd.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.deEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deEnd.Properties.EditFormat.FormatString = "MM/yyyy";
            this.deEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deEnd.Properties.Mask.EditMask = "MM/yyyy";
            this.deEnd.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deEnd.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            this.deEnd.Size = new System.Drawing.Size(118, 20);
            this.deEnd.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Đến tháng/năm:";
            // 
            // rdXuat
            // 
            this.rdXuat.AutoSize = true;
            this.rdXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdXuat.Location = new System.Drawing.Point(297, 133);
            this.rdXuat.Name = "rdXuat";
            this.rdXuat.Size = new System.Drawing.Size(47, 17);
            this.rdXuat.TabIndex = 10;
            this.rdXuat.TabStop = true;
            this.rdXuat.Text = "Xuất";
            this.rdXuat.UseVisualStyleBackColor = true;
            // 
            // rdNhap
            // 
            this.rdNhap.AutoSize = true;
            this.rdNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdNhap.Location = new System.Drawing.Point(297, 100);
            this.rdNhap.Name = "rdNhap";
            this.rdNhap.Size = new System.Drawing.Size(50, 17);
            this.rdNhap.TabIndex = 11;
            this.rdNhap.TabStop = true;
            this.rdNhap.Text = "Nhập";
            this.rdNhap.UseVisualStyleBackColor = true;
            // 
            // deStart
            // 
            this.deStart.EditValue = null;
            this.deStart.Location = new System.Drawing.Point(136, 99);
            this.deStart.Name = "deStart";
            this.deStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deStart.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.deStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deStart.Properties.EditFormat.FormatString = "MM/yyyy";
            this.deStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deStart.Properties.Mask.EditMask = "MM/yyyy";
            this.deStart.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deStart.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            this.deStart.Size = new System.Drawing.Size(118, 20);
            this.deStart.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Từ tháng/năm:";
            // 
            // FormChiTietNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 268);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdXuat);
            this.Controls.Add(this.rdNhap);
            this.Controls.Add(this.deStart);
            this.Controls.Add(this.label1);
            this.Name = "FormChiTietNhapXuat";
            this.Text = "Lập Chi Tiết Nhập Xuất";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChiTietNhapXuat_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.deEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStart.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit deEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdXuat;
        private System.Windows.Forms.RadioButton rdNhap;
        private DevExpress.XtraEditors.DateEdit deStart;
        private System.Windows.Forms.Label label1;
    }
}