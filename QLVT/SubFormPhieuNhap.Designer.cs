namespace QLVT
{
    partial class SubFormPhieuNhap
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label mAPNLabel;
            this.btnOK = new System.Windows.Forms.Button();
            this.qLVT_DATHANGDataSet = new QLVT.QLVT_DATHANGDataSet();
            this.phieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.tbMaSoDDH = new DevExpress.XtraEditors.TextEdit();
            this.tbMaPN = new DevExpress.XtraEditors.TextEdit();
            masoDDHLabel = new System.Windows.Forms.Label();
            mAPNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaSoDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaPN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(77, 103);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(63, 13);
            masoDDHLabel.TabIndex = 10;
            masoDDHLabel.Text = "Mã số DDH:";
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(58, 61);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(82, 13);
            mAPNLabel.TabIndex = 8;
            mAPNLabel.Text = "Mã Phiếu Nhập:";
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(230, 143);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 25);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.EnforceConstraints = false;
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieuNhapBindingSource
            // 
            this.phieuNhapBindingSource.DataMember = "PhieuNhap";
            this.phieuNhapBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // tbMaSoDDH
            // 
            this.tbMaSoDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MasoDDH", true));
            this.tbMaSoDDH.Location = new System.Drawing.Point(146, 100);
            this.tbMaSoDDH.Name = "tbMaSoDDH";
            this.tbMaSoDDH.Size = new System.Drawing.Size(174, 20);
            this.tbMaSoDDH.TabIndex = 14;
            // 
            // tbMaPN
            // 
            this.tbMaPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MAPN", true));
            this.tbMaPN.Location = new System.Drawing.Point(146, 58);
            this.tbMaPN.Name = "tbMaPN";
            this.tbMaPN.Size = new System.Drawing.Size(174, 20);
            this.tbMaPN.TabIndex = 15;
            // 
            // SubFormPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 230);
            this.Controls.Add(this.tbMaPN);
            this.Controls.Add(this.tbMaSoDDH);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(masoDDHLabel);
            this.Controls.Add(mAPNLabel);
            this.Name = "SubFormPhieuNhap";
            this.Text = "Lập Phiếu Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormPhieuNhap_FormClosing);
            this.Load += new System.EventHandler(this.SubFormPhieuNhap_Load);
            this.Shown += new System.EventHandler(this.SubFormPhieuNhap_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaSoDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaPN.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private System.Windows.Forms.BindingSource phieuNhapBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit tbMaSoDDH;
        private DevExpress.XtraEditors.TextEdit tbMaPN;
    }
}