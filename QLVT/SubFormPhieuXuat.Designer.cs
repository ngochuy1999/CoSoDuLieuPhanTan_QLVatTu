namespace QLVT
{
    partial class SubFormPhieuXuat
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
            System.Windows.Forms.Label mAPXLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label hOTENKHLabel;
            this.btnOK = new System.Windows.Forms.Button();
            this.qLVT_DATHANGDataSet = new QLVT.QLVT_DATHANGDataSet();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.KhoTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.khoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phieuXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.PhieuXuatTableAdapter();
            this.tbMaPX = new DevExpress.XtraEditors.TextEdit();
            this.tbKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.tbMaKho = new DevExpress.XtraEditors.TextEdit();
            mAPXLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaPX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaKho.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(30, 68);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(79, 13);
            mAPXLabel.TabIndex = 13;
            mAPXLabel.Text = "Mã Phiếu Xuất:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(63, 138);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(46, 13);
            mAKHOLabel.TabIndex = 11;
            mAKHOLabel.Text = "Mã Kho:";
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(6, 103);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(103, 13);
            hOTENKHLabel.TabIndex = 9;
            hOTENKHLabel.Text = "Họ tên Khách Hàng:";
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(203, 178);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 25);
            this.btnOK.TabIndex = 14;
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
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // khoGridControl
            // 
            this.khoGridControl.DataSource = this.khoBindingSource;
            this.khoGridControl.Location = new System.Drawing.Point(313, 12);
            this.khoGridControl.MainView = this.gvKho;
            this.khoGridControl.Name = "khoGridControl";
            this.khoGridControl.Size = new System.Drawing.Size(476, 263);
            this.khoGridControl.TabIndex = 15;
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
            this.gvKho.OptionsBehavior.Editable = false;
            this.gvKho.OptionsView.ShowGroupPanel = false;
            this.gvKho.OptionsView.ShowViewCaption = true;
            this.gvKho.ViewCaption = "Kho";
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
            // phieuXuatBindingSource
            // 
            this.phieuXuatBindingSource.DataMember = "PhieuXuat";
            this.phieuXuatBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // tbMaPX
            // 
            this.tbMaPX.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuXuatBindingSource, "MAPX", true));
            this.tbMaPX.Location = new System.Drawing.Point(115, 65);
            this.tbMaPX.Name = "tbMaPX";
            this.tbMaPX.Size = new System.Drawing.Size(178, 20);
            this.tbMaPX.TabIndex = 16;
            // 
            // tbKhachHang
            // 
            this.tbKhachHang.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuXuatBindingSource, "HOTENKH", true));
            this.tbKhachHang.Location = new System.Drawing.Point(115, 100);
            this.tbKhachHang.Name = "tbKhachHang";
            this.tbKhachHang.Size = new System.Drawing.Size(178, 20);
            this.tbKhachHang.TabIndex = 17;
            // 
            // tbMaKho
            // 
            this.tbMaKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuXuatBindingSource, "MAKHO", true));
            this.tbMaKho.Location = new System.Drawing.Point(115, 135);
            this.tbMaKho.Name = "tbMaKho";
            this.tbMaKho.Size = new System.Drawing.Size(178, 20);
            this.tbMaKho.TabIndex = 18;
            // 
            // SubFormPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 349);
            this.Controls.Add(this.tbMaKho);
            this.Controls.Add(this.tbKhachHang);
            this.Controls.Add(this.tbMaPX);
            this.Controls.Add(this.khoGridControl);
            this.Controls.Add(mAPXLabel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(mAKHOLabel);
            this.Controls.Add(hOTENKHLabel);
            this.Name = "SubFormPhieuXuat";
            this.Text = "Lập Phiếu Xuất";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormPhieuXuat_FormClosing);
            this.Load += new System.EventHandler(this.SubFormPhieuXuat_Load);
            this.Shown += new System.EventHandler(this.SubFormPhieuXuat_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaPX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaKho.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl khoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKho;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private System.Windows.Forms.BindingSource phieuXuatBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private DevExpress.XtraEditors.TextEdit tbMaPX;
        private DevExpress.XtraEditors.TextEdit tbKhachHang;
        private DevExpress.XtraEditors.TextEdit tbMaKho;
    }
}