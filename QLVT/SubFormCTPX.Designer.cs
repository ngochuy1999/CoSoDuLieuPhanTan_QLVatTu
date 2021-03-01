namespace QLVT
{
    partial class SubFormCTPX
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
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label mAPXLabel;
            this.btnOK = new System.Windows.Forms.Button();
            this.qLVT_DATHANGDataSet = new QLVT.QLVT_DATHANGDataSet();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.vattuGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvVatTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTPXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTPXTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.CTPXTableAdapter();
            this.tbMaPX = new DevExpress.XtraEditors.TextEdit();
            this.tbMaVT = new DevExpress.XtraEditors.TextEdit();
            this.nuDonGia = new DevExpress.XtraEditors.SpinEdit();
            this.nuSoLuong = new System.Windows.Forms.NumericUpDown();
            dONGIALabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            mAPXLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaPX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(52, 159);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(48, 13);
            dONGIALabel.TabIndex = 16;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(47, 124);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(53, 13);
            sOLUONGLabel.TabIndex = 14;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(60, 90);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(40, 13);
            mAVTLabel.TabIndex = 12;
            mAVTLabel.Text = "Mã VT:";
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(21, 55);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(79, 13);
            mAPXLabel.TabIndex = 10;
            mAPXLabel.Text = "Mã Phiếu Xuất:";
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(188, 192);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 25);
            this.btnOK.TabIndex = 18;
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
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "Vattu";
            this.vattuBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // vattuGridControl
            // 
            this.vattuGridControl.DataSource = this.vattuBindingSource;
            this.vattuGridControl.Location = new System.Drawing.Point(299, 22);
            this.vattuGridControl.MainView = this.gvVatTu;
            this.vattuGridControl.Name = "vattuGridControl";
            this.vattuGridControl.Size = new System.Drawing.Size(455, 220);
            this.vattuGridControl.TabIndex = 19;
            this.vattuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVatTu});
            // 
            // gvVatTu
            // 
            this.gvVatTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gvVatTu.GridControl = this.vattuGridControl;
            this.gvVatTu.Name = "gvVatTu";
            this.gvVatTu.OptionsBehavior.Editable = false;
            this.gvVatTu.OptionsView.ShowGroupPanel = false;
            this.gvVatTu.OptionsView.ShowViewCaption = true;
            this.gvVatTu.ViewCaption = "Vật Tư";
            this.gvVatTu.Click += new System.EventHandler(this.gvVatTu_Click);
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã Vật Tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên Vật Tư";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "Đơn Vị Tính";
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.Caption = "Số Lượng Tồn";
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            // 
            // cTPXBindingSource
            // 
            this.cTPXBindingSource.DataMember = "CTPX";
            this.cTPXBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // tbMaPX
            // 
            this.tbMaPX.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPXBindingSource, "MAPX", true));
            this.tbMaPX.Location = new System.Drawing.Point(106, 52);
            this.tbMaPX.Name = "tbMaPX";
            this.tbMaPX.Size = new System.Drawing.Size(172, 20);
            this.tbMaPX.TabIndex = 20;
            // 
            // tbMaVT
            // 
            this.tbMaVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPXBindingSource, "MAVT", true));
            this.tbMaVT.Location = new System.Drawing.Point(106, 87);
            this.tbMaVT.Name = "tbMaVT";
            this.tbMaVT.Size = new System.Drawing.Size(172, 20);
            this.tbMaVT.TabIndex = 21;
            // 
            // nuDonGia
            // 
            this.nuDonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPXBindingSource, "DONGIA", true));
            this.nuDonGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nuDonGia.Location = new System.Drawing.Point(106, 156);
            this.nuDonGia.Name = "nuDonGia";
            this.nuDonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nuDonGia.Size = new System.Drawing.Size(172, 20);
            this.nuDonGia.TabIndex = 23;
            // 
            // nuSoLuong
            // 
            this.nuSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cTPXBindingSource, "SOLUONG", true));
            this.nuSoLuong.Location = new System.Drawing.Point(106, 122);
            this.nuSoLuong.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nuSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuSoLuong.Name = "nuSoLuong";
            this.nuSoLuong.Size = new System.Drawing.Size(172, 21);
            this.nuSoLuong.TabIndex = 24;
            this.nuSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SubFormCTPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 265);
            this.Controls.Add(this.nuSoLuong);
            this.Controls.Add(this.nuDonGia);
            this.Controls.Add(this.tbMaVT);
            this.Controls.Add(this.tbMaPX);
            this.Controls.Add(this.vattuGridControl);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(dONGIALabel);
            this.Controls.Add(sOLUONGLabel);
            this.Controls.Add(mAVTLabel);
            this.Controls.Add(mAPXLabel);
            this.Name = "SubFormCTPX";
            this.Text = "Lập Chi Tiết Phiếu Xuất";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormCTPX_FormClosing);
            this.Load += new System.EventHandler(this.SubFormCTPX_Load);
            this.Shown += new System.EventHandler(this.SubFormCTPX_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaPX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl vattuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private System.Windows.Forms.BindingSource cTPXBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private DevExpress.XtraEditors.TextEdit tbMaPX;
        private DevExpress.XtraEditors.TextEdit tbMaVT;
        private DevExpress.XtraEditors.SpinEdit nuDonGia;
        private System.Windows.Forms.NumericUpDown nuSoLuong;
    }
}