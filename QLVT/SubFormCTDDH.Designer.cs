namespace QLVT
{
    partial class SubFormCTDDH
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
            System.Windows.Forms.Label mAVTLabel1;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label masoDDHLabel;
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
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter();
            this.tbMasoDDH = new DevExpress.XtraEditors.TextEdit();
            this.tbMaVT = new DevExpress.XtraEditors.TextEdit();
            this.nuSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.nuDonGia = new DevExpress.XtraEditors.SpinEdit();
            this.btnOK = new System.Windows.Forms.Button();
            mAVTLabel1 = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasoDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel1
            // 
            mAVTLabel1.AutoSize = true;
            mAVTLabel1.Location = new System.Drawing.Point(52, 102);
            mAVTLabel1.Name = "mAVTLabel1";
            mAVTLabel1.Size = new System.Drawing.Size(40, 13);
            mAVTLabel1.TabIndex = 16;
            mAVTLabel1.Text = "Mã VT:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(44, 169);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(48, 13);
            dONGIALabel.TabIndex = 15;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(39, 135);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(53, 13);
            sOLUONGLabel.TabIndex = 14;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(29, 65);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(63, 13);
            masoDDHLabel.TabIndex = 13;
            masoDDHLabel.Text = "Mã số DDH:";
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
            this.tableAdapterManager.CTDDHTableAdapter = this.cTDDHTableAdapter;
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
            this.vattuGridControl.Location = new System.Drawing.Point(295, 12);
            this.vattuGridControl.MainView = this.gvVatTu;
            this.vattuGridControl.Name = "vattuGridControl";
            this.vattuGridControl.Size = new System.Drawing.Size(480, 243);
            this.vattuGridControl.TabIndex = 17;
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
            this.gvVatTu.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvVatTu_RowClick);
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã VT";
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
            // cTDDHBindingSource
            // 
            this.cTDDHBindingSource.DataMember = "CTDDH";
            this.cTDDHBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // tbMasoDDH
            // 
            this.tbMasoDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTDDHBindingSource, "MasoDDH", true));
            this.tbMasoDDH.Location = new System.Drawing.Point(98, 62);
            this.tbMasoDDH.Name = "tbMasoDDH";
            this.tbMasoDDH.Size = new System.Drawing.Size(164, 20);
            this.tbMasoDDH.TabIndex = 18;
            // 
            // tbMaVT
            // 
            this.tbMaVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTDDHBindingSource, "MAVT", true));
            this.tbMaVT.Location = new System.Drawing.Point(98, 99);
            this.tbMaVT.Name = "tbMaVT";
            this.tbMaVT.Size = new System.Drawing.Size(164, 20);
            this.tbMaVT.TabIndex = 19;
            // 
            // nuSoLuong
            // 
            this.nuSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTDDHBindingSource, "SOLUONG", true));
            this.nuSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nuSoLuong.Location = new System.Drawing.Point(98, 132);
            this.nuSoLuong.Name = "nuSoLuong";
            this.nuSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nuSoLuong.Size = new System.Drawing.Size(164, 20);
            this.nuSoLuong.TabIndex = 20;
            // 
            // nuDonGia
            // 
            this.nuDonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTDDHBindingSource, "DONGIA", true));
            this.nuDonGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nuDonGia.Location = new System.Drawing.Point(98, 166);
            this.nuDonGia.Name = "nuDonGia";
            this.nuDonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nuDonGia.Size = new System.Drawing.Size(164, 20);
            this.nuDonGia.TabIndex = 21;
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(172, 212);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 25);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SubFormCTDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 275);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.nuDonGia);
            this.Controls.Add(this.nuSoLuong);
            this.Controls.Add(this.tbMaVT);
            this.Controls.Add(this.tbMasoDDH);
            this.Controls.Add(this.vattuGridControl);
            this.Controls.Add(mAVTLabel1);
            this.Controls.Add(dONGIALabel);
            this.Controls.Add(sOLUONGLabel);
            this.Controls.Add(masoDDHLabel);
            this.Name = "SubFormCTDDH";
            this.Text = "Lập Chi Tiết DDH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormCTDDH_FormClosing);
            this.Load += new System.EventHandler(this.SubFormCTDDH_Load);
            this.Shown += new System.EventHandler(this.SubFormCTDDH_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasoDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private DevExpress.XtraGrid.GridControl vattuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private DevExpress.XtraEditors.TextEdit tbMasoDDH;
        private DevExpress.XtraEditors.TextEdit tbMaVT;
        private DevExpress.XtraEditors.SpinEdit nuSoLuong;
        private DevExpress.XtraEditors.SpinEdit nuDonGia;
        private System.Windows.Forms.Button btnOK;
    }
}