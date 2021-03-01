namespace QLVT
{
    partial class SubFormCTPN
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
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label mAPNLabel;
            this.btnOK = new System.Windows.Forms.Button();
            this.qLVT_DATHANGDataSet = new QLVT.QLVT_DATHANGDataSet();
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.cTDDHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvCTDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTPNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTPNTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.CTPNTableAdapter();
            this.tbMaPN = new DevExpress.XtraEditors.TextEdit();
            this.tbMaVT = new DevExpress.XtraEditors.TextEdit();
            this.nuDonGia = new DevExpress.XtraEditors.SpinEdit();
            this.nuSoLuong = new System.Windows.Forms.NumericUpDown();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            mAPNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(53, 124);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(53, 13);
            sOLUONGLabel.TabIndex = 17;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(58, 161);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(48, 13);
            dONGIALabel.TabIndex = 15;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(66, 88);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(40, 13);
            mAVTLabel.TabIndex = 13;
            mAVTLabel.Text = "Mã VT:";
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(24, 51);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(82, 13);
            mAPNLabel.TabIndex = 11;
            mAPNLabel.Text = "Mã Phiếu Nhập:";
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(184, 195);
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
            // cTDDHBindingSource
            // 
            this.cTDDHBindingSource.DataMember = "CTDDH";
            this.cTDDHBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTDDHGridControl
            // 
            this.cTDDHGridControl.DataSource = this.cTDDHBindingSource;
            this.cTDDHGridControl.Location = new System.Drawing.Point(280, 2);
            this.cTDDHGridControl.MainView = this.gvCTDDH;
            this.cTDDHGridControl.Name = "cTDDHGridControl";
            this.cTDDHGridControl.Size = new System.Drawing.Size(480, 256);
            this.cTDDHGridControl.TabIndex = 20;
            this.cTDDHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTDDH});
            // 
            // gvCTDDH
            // 
            this.gvCTDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gvCTDDH.GridControl = this.cTDDHGridControl;
            this.gvCTDDH.Name = "gvCTDDH";
            this.gvCTDDH.OptionsBehavior.Editable = false;
            this.gvCTDDH.OptionsView.ShowGroupPanel = false;
            this.gvCTDDH.OptionsView.ShowViewCaption = true;
            this.gvCTDDH.ViewCaption = "Chi Tiết Đơn Đặt Hàng";
            this.gvCTDDH.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCTDDH_RowClick);
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã DDH";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã Vật Tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số Lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn Giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            // 
            // cTPNBindingSource
            // 
            this.cTPNBindingSource.DataMember = "CTPN";
            this.cTPNBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // tbMaPN
            // 
            this.tbMaPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "MAPN", true));
            this.tbMaPN.Location = new System.Drawing.Point(112, 48);
            this.tbMaPN.Name = "tbMaPN";
            this.tbMaPN.Size = new System.Drawing.Size(162, 20);
            this.tbMaPN.TabIndex = 21;
            // 
            // tbMaVT
            // 
            this.tbMaVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "MAVT", true));
            this.tbMaVT.Location = new System.Drawing.Point(112, 85);
            this.tbMaVT.Name = "tbMaVT";
            this.tbMaVT.Size = new System.Drawing.Size(162, 20);
            this.tbMaVT.TabIndex = 22;
            // 
            // nuDonGia
            // 
            this.nuDonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "DONGIA", true));
            this.nuDonGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nuDonGia.Location = new System.Drawing.Point(112, 158);
            this.nuDonGia.Name = "nuDonGia";
            this.nuDonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nuDonGia.Size = new System.Drawing.Size(162, 20);
            this.nuDonGia.TabIndex = 24;
            // 
            // nuSoLuong
            // 
            this.nuSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cTPNBindingSource, "SOLUONG", true));
            this.nuSoLuong.Location = new System.Drawing.Point(112, 122);
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
            this.nuSoLuong.Size = new System.Drawing.Size(162, 21);
            this.nuSoLuong.TabIndex = 25;
            this.nuSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SubFormCTPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 278);
            this.Controls.Add(this.nuSoLuong);
            this.Controls.Add(this.nuDonGia);
            this.Controls.Add(this.tbMaVT);
            this.Controls.Add(this.tbMaPN);
            this.Controls.Add(this.cTDDHGridControl);
            this.Controls.Add(sOLUONGLabel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(dONGIALabel);
            this.Controls.Add(mAVTLabel);
            this.Controls.Add(mAPNLabel);
            this.Name = "SubFormCTPN";
            this.Text = "Lập Chi Tiết Phiếu Nhập ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormCTPN_FormClosing);
            this.Load += new System.EventHandler(this.SubFormCTPN_Load);
            this.Shown += new System.EventHandler(this.SubFormCTPN_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl cTDDHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.BindingSource cTPNBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private DevExpress.XtraEditors.TextEdit tbMaPN;
        private DevExpress.XtraEditors.TextEdit tbMaVT;
        private DevExpress.XtraEditors.SpinEdit nuDonGia;
        private System.Windows.Forms.NumericUpDown nuSoLuong;
    }
}