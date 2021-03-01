namespace QLVT
{
    partial class SubFormDDH
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
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label masoDDHLabel;
            this.btnOk = new System.Windows.Forms.Button();
            this.qLVT_DATHANGDataSet = new QLVT.QLVT_DATHANGDataSet();
            this.datHangBDS = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.khoTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.KhoTableAdapter();
            this.tbMaDDH = new DevExpress.XtraEditors.TextEdit();
            this.tbMaKho = new DevExpress.XtraEditors.TextEdit();
            this.tbNCC = new DevExpress.XtraEditors.TextEdit();
            this.khoBDS = new System.Windows.Forms.BindingSource(this.components);
            this.khoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            mAKHOLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKho)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(38, 141);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(46, 13);
            mAKHOLabel.TabIndex = 23;
            mAKHOLabel.Text = "Mã Kho:";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(8, 96);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(76, 13);
            nhaCCLabel.TabIndex = 20;
            nhaCCLabel.Text = "Nhà cung cấp:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(35, 51);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(49, 13);
            masoDDHLabel.TabIndex = 19;
            masoDDHLabel.Text = "Mã DDH:";
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Location = new System.Drawing.Point(185, 178);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 25);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.EnforceConstraints = false;
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datHangBDS
            // 
            this.datHangBDS.DataMember = "DatHang";
            this.datHangBDS.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // tbMaDDH
            // 
            this.tbMaDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBDS, "MasoDDH", true));
            this.tbMaDDH.Location = new System.Drawing.Point(90, 48);
            this.tbMaDDH.Name = "tbMaDDH";
            this.tbMaDDH.Size = new System.Drawing.Size(185, 20);
            this.tbMaDDH.TabIndex = 26;
            // 
            // tbMaKho
            // 
            this.tbMaKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBDS, "MAKHO", true));
            this.tbMaKho.Enabled = false;
            this.tbMaKho.Location = new System.Drawing.Point(90, 138);
            this.tbMaKho.Name = "tbMaKho";
            this.tbMaKho.Size = new System.Drawing.Size(185, 20);
            this.tbMaKho.TabIndex = 27;
            // 
            // tbNCC
            // 
            this.tbNCC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBDS, "NhaCC", true));
            this.tbNCC.Location = new System.Drawing.Point(90, 93);
            this.tbNCC.Name = "tbNCC";
            this.tbNCC.Size = new System.Drawing.Size(185, 20);
            this.tbNCC.TabIndex = 28;
            // 
            // khoBDS
            // 
            this.khoBDS.DataMember = "Kho";
            this.khoBDS.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // khoGridControl
            // 
            this.khoGridControl.DataSource = this.khoBDS;
            this.khoGridControl.Location = new System.Drawing.Point(302, 12);
            this.khoGridControl.MainView = this.gvKho;
            this.khoGridControl.Name = "khoGridControl";
            this.khoGridControl.Size = new System.Drawing.Size(525, 255);
            this.khoGridControl.TabIndex = 28;
            this.khoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKho});
            // 
            // gvKho
            // 
            this.gvKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colDIACHI,
            this.colMACN});
            this.gvKho.GridControl = this.khoGridControl;
            this.gvKho.Name = "gvKho";
            this.gvKho.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvKho_RowClick);
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã Kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 0;
            // 
            // colTENKHO
            // 
            this.colTENKHO.Caption = "Tên Kho";
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 1;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa Chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 2;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã CN";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            // 
            // SubFormDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 294);
            this.Controls.Add(this.khoGridControl);
            this.Controls.Add(this.tbNCC);
            this.Controls.Add(this.tbMaKho);
            this.Controls.Add(this.tbMaDDH);
            this.Controls.Add(mAKHOLabel);
            this.Controls.Add(nhaCCLabel);
            this.Controls.Add(masoDDHLabel);
            this.Controls.Add(this.btnOk);
            this.Name = "SubFormDDH";
            this.Text = "Lập Đơn Đặt Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormDDH_FormClosing);
            this.Load += new System.EventHandler(this.SubFormDDH_Load);
            this.Shown += new System.EventHandler(this.SubFormDDH_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private System.Windows.Forms.BindingSource datHangBDS;
        private QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLVT_DATHANGDataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private DevExpress.XtraEditors.TextEdit tbMaDDH;
        private DevExpress.XtraEditors.TextEdit tbMaKho;
        private DevExpress.XtraEditors.TextEdit tbNCC;
        private System.Windows.Forms.BindingSource khoBDS;
        private DevExpress.XtraGrid.GridControl khoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKho;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
    }
}