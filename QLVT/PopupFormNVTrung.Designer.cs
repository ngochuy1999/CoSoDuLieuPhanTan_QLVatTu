namespace QLVT
{
    partial class PopupFormNVTrung
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
            this.dSListNVTrung = new QLVT.DSListNVTrung();
            this.sP_ListNVTrungChuyenChiNhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_ListNVTrungChuyenChiNhanhTableAdapter = new QLVT.DSListNVTrungTableAdapters.SP_ListNVTrungChuyenChiNhanhTableAdapter();
            this.tableAdapterManager = new QLVT.DSListNVTrungTableAdapters.TableAdapterManager();
            this.sP_ListNVTrungChuyenChiNhanhGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dSListNVTrung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_ListNVTrungChuyenChiNhanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_ListNVTrungChuyenChiNhanhGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dSListNVTrung
            // 
            this.dSListNVTrung.DataSetName = "DSListNVTrung";
            this.dSListNVTrung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_ListNVTrungChuyenChiNhanhBindingSource
            // 
            this.sP_ListNVTrungChuyenChiNhanhBindingSource.DataMember = "SP_ListNVTrungChuyenChiNhanh";
            this.sP_ListNVTrungChuyenChiNhanhBindingSource.DataSource = this.dSListNVTrung;
            // 
            // sP_ListNVTrungChuyenChiNhanhTableAdapter
            // 
            this.sP_ListNVTrungChuyenChiNhanhTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSListNVTrungTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_ListNVTrungChuyenChiNhanhGridControl
            // 
            this.sP_ListNVTrungChuyenChiNhanhGridControl.DataSource = this.sP_ListNVTrungChuyenChiNhanhBindingSource;
            this.sP_ListNVTrungChuyenChiNhanhGridControl.Location = new System.Drawing.Point(12, 2);
            this.sP_ListNVTrungChuyenChiNhanhGridControl.MainView = this.gridView1;
            this.sP_ListNVTrungChuyenChiNhanhGridControl.Name = "sP_ListNVTrungChuyenChiNhanhGridControl";
            this.sP_ListNVTrungChuyenChiNhanhGridControl.Size = new System.Drawing.Size(654, 247);
            this.sP_ListNVTrungChuyenChiNhanhGridControl.TabIndex = 2;
            this.sP_ListNVTrungChuyenChiNhanhGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridView1.GridControl = this.sP_ListNVTrungChuyenChiNhanhGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã NV";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa Chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày Sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 4;
            // 
            // colLUONG
            // 
            this.colLUONG.Caption = "Lương";
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 5;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã CN";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.Caption = "Trạng Thái Xóa";
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 7;
            // 
            // btnNew
            // 
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Location = new System.Drawing.Point(398, 269);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(107, 33);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Tạo mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplace.Location = new System.Drawing.Point(522, 269);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(107, 33);
            this.btnReplace.TabIndex = 5;
            this.btnReplace.Text = "Ghi đè";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // PopupFormNVTrung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 314);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.sP_ListNVTrungChuyenChiNhanhGridControl);
            this.Name = "PopupFormNVTrung";
            this.Text = "Danh sách nhân viên trùng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PopupFormNVTrung_FormClosing);
            this.Load += new System.EventHandler(this.PopupFormNVTrung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSListNVTrung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_ListNVTrungChuyenChiNhanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_ListNVTrungChuyenChiNhanhGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSListNVTrung dSListNVTrung;
        private System.Windows.Forms.BindingSource sP_ListNVTrungChuyenChiNhanhBindingSource;
        private DSListNVTrungTableAdapters.SP_ListNVTrungChuyenChiNhanhTableAdapter sP_ListNVTrungChuyenChiNhanhTableAdapter;
        private DSListNVTrungTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_ListNVTrungChuyenChiNhanhGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnReplace;
    }
}