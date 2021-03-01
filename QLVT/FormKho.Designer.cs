namespace QLVT
{
    partial class FormKho
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
            System.Windows.Forms.Label tENKHOLabel1;
            System.Windows.Forms.Label dIACHILabel1;
            System.Windows.Forms.Label mACNLabel1;
            System.Windows.Forms.Label mAKHOLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKho));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.qLVT_DATHANGDataSet = new QLVT.QLVT_DATHANGDataSet();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.khoTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.KhoTableAdapter();
            this.gbInfor = new System.Windows.Forms.GroupBox();
            this.dIACHITextBox = new DevExpress.XtraEditors.TextEdit();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mACNTextBox = new DevExpress.XtraEditors.TextEdit();
            this.tENKHOTextBox = new DevExpress.XtraEditors.TextEdit();
            this.mAKHOTextBox = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.khoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            tENKHOLabel1 = new System.Windows.Forms.Label();
            dIACHILabel1 = new System.Windows.Forms.Label();
            mACNLabel1 = new System.Windows.Forms.Label();
            mAKHOLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            this.gbInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACNTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENKHOTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKHOTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKho)).BeginInit();
            this.SuspendLayout();
            // 
            // tENKHOLabel1
            // 
            tENKHOLabel1.AutoSize = true;
            tENKHOLabel1.Location = new System.Drawing.Point(363, 64);
            tENKHOLabel1.Name = "tENKHOLabel1";
            tENKHOLabel1.Size = new System.Drawing.Size(50, 13);
            tENKHOLabel1.TabIndex = 15;
            tENKHOLabel1.Text = "Tên Kho:";
            // 
            // dIACHILabel1
            // 
            dIACHILabel1.AutoSize = true;
            dIACHILabel1.Location = new System.Drawing.Point(370, 92);
            dIACHILabel1.Name = "dIACHILabel1";
            dIACHILabel1.Size = new System.Drawing.Size(43, 13);
            dIACHILabel1.TabIndex = 13;
            dIACHILabel1.Text = "Địa chỉ:";
            // 
            // mACNLabel1
            // 
            mACNLabel1.AutoSize = true;
            mACNLabel1.Location = new System.Drawing.Point(192, 92);
            mACNLabel1.Name = "mACNLabel1";
            mACNLabel1.Size = new System.Drawing.Size(42, 13);
            mACNLabel1.TabIndex = 11;
            mACNLabel1.Text = "Mã CN:";
            // 
            // mAKHOLabel1
            // 
            mAKHOLabel1.AutoSize = true;
            mAKHOLabel1.Location = new System.Drawing.Point(188, 65);
            mAKHOLabel1.Name = "mAKHOLabel1";
            mAKHOLabel1.Size = new System.Drawing.Size(46, 13);
            mAKHOLabel1.TabIndex = 9;
            mAKHOLabel1.Text = "Mã Kho:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnAdd,
            this.btnDelete,
            this.btnEdit,
            this.btnSave,
            this.btnUndo,
            this.btnRefresh,
            this.btnLogout});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 14;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(262, 98);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLogout, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Add";
            this.btnAdd.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnAdd.Id = 7;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.LargeImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnDelete.Id = 8;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Edit";
            this.btnEdit.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnEdit.Id = 9;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.LargeImage")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnSave.Id = 10;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnUndo.Id = 11;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnRefresh.Id = 12;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Exit";
            this.btnLogout.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnLogout.Id = 13;
            this.btnLogout.ImageOptions.Image = global::QLVT.Properties.Resources.turn_off_32;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1005, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 477);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1005, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 437);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1005, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 437);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Add";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbChiNhanh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 40);
            this.panel1.TabIndex = 5;
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChiNhanh.Location = new System.Drawing.Point(73, 10);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(171, 21);
            this.cbChiNhanh.TabIndex = 9;
            this.cbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chi nhánh";
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.EnforceConstraints = false;
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // gbInfor
            // 
            this.gbInfor.Controls.Add(this.dIACHITextBox);
            this.gbInfor.Controls.Add(this.mACNTextBox);
            this.gbInfor.Controls.Add(this.tENKHOTextBox);
            this.gbInfor.Controls.Add(this.mAKHOTextBox);
            this.gbInfor.Controls.Add(tENKHOLabel1);
            this.gbInfor.Controls.Add(dIACHILabel1);
            this.gbInfor.Controls.Add(mACNLabel1);
            this.gbInfor.Controls.Add(mAKHOLabel1);
            this.gbInfor.Controls.Add(this.label2);
            this.gbInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInfor.Location = new System.Drawing.Point(0, 300);
            this.gbInfor.Name = "gbInfor";
            this.gbInfor.Size = new System.Drawing.Size(1005, 170);
            this.gbInfor.TabIndex = 8;
            this.gbInfor.TabStop = false;
            this.gbInfor.Text = "Information";
            // 
            // dIACHITextBox
            // 
            this.dIACHITextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBindingSource, "DIACHI", true));
            this.dIACHITextBox.Location = new System.Drawing.Point(415, 89);
            this.dIACHITextBox.MenuManager = this.barManager1;
            this.dIACHITextBox.Name = "dIACHITextBox";
            this.dIACHITextBox.Size = new System.Drawing.Size(148, 20);
            this.dIACHITextBox.TabIndex = 21;
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // mACNTextBox
            // 
            this.mACNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBindingSource, "MACN", true));
            this.mACNTextBox.Enabled = false;
            this.mACNTextBox.Location = new System.Drawing.Point(238, 89);
            this.mACNTextBox.MenuManager = this.barManager1;
            this.mACNTextBox.Name = "mACNTextBox";
            this.mACNTextBox.Size = new System.Drawing.Size(100, 20);
            this.mACNTextBox.TabIndex = 20;
            // 
            // tENKHOTextBox
            // 
            this.tENKHOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBindingSource, "TENKHO", true));
            this.tENKHOTextBox.Location = new System.Drawing.Point(415, 61);
            this.tENKHOTextBox.MenuManager = this.barManager1;
            this.tENKHOTextBox.Name = "tENKHOTextBox";
            this.tENKHOTextBox.Size = new System.Drawing.Size(148, 20);
            this.tENKHOTextBox.TabIndex = 19;
            // 
            // mAKHOTextBox
            // 
            this.mAKHOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBindingSource, "MAKHO", true));
            this.mAKHOTextBox.Location = new System.Drawing.Point(238, 62);
            this.mAKHOTextBox.MenuManager = this.barManager1;
            this.mAKHOTextBox.Name = "mAKHOTextBox";
            this.mAKHOTextBox.Size = new System.Drawing.Size(100, 20);
            this.mAKHOTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::QLVT.Properties.Resources.warehouse_128;
            this.label2.Location = new System.Drawing.Point(28, 17);
            this.label2.MinimumSize = new System.Drawing.Size(128, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 128);
            this.label2.TabIndex = 8;
            // 
            // khoGridControl
            // 
            this.khoGridControl.DataSource = this.khoBindingSource;
            this.khoGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.khoGridControl.Location = new System.Drawing.Point(0, 80);
            this.khoGridControl.MainView = this.gvKho;
            this.khoGridControl.MenuManager = this.barManager1;
            this.khoGridControl.Name = "khoGridControl";
            this.khoGridControl.Size = new System.Drawing.Size(1005, 220);
            this.khoGridControl.TabIndex = 8;
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
            this.colMACN.Caption = "Mã Chi Nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            // 
            // FormKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 477);
            this.Controls.Add(this.gbInfor);
            this.Controls.Add(this.khoGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormKho";
            this.Text = "Kho";
            this.Load += new System.EventHandler(this.FormKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            this.gbInfor.ResumeLayout(false);
            this.gbInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACNTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENKHOTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKHOTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.Label label1;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox gbInfor;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraBars.BarLargeButtonItem btnAdd;
        private DevExpress.XtraBars.BarLargeButtonItem btnDelete;
        private DevExpress.XtraBars.BarLargeButtonItem btnEdit;
        private DevExpress.XtraBars.BarLargeButtonItem btnSave;
        private DevExpress.XtraBars.BarLargeButtonItem btnUndo;
        private DevExpress.XtraBars.BarLargeButtonItem btnRefresh;
        private DevExpress.XtraBars.BarLargeButtonItem btnLogout;
        private DevExpress.XtraEditors.TextEdit dIACHITextBox;
        private DevExpress.XtraEditors.TextEdit mACNTextBox;
        private DevExpress.XtraEditors.TextEdit tENKHOTextBox;
        private DevExpress.XtraEditors.TextEdit mAKHOTextBox;
        private DevExpress.XtraGrid.GridControl khoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKho;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        public QLVT_DATHANGDataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        public System.Windows.Forms.BindingSource khoBindingSource;
    }
}