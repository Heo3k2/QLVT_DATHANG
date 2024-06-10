
namespace QLVT_DATHANG
{
    partial class FormVatTu
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
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label sOLUONGTONLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVatTu));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemThem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemGhi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemUndo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemReload = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DS = new QLVT_DATHANG.DS();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.VatTuTableAdapter = new QLVT_DATHANG.DSTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.DSTableAdapters.TableAdapterManager();
            this.gcVatTu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapLieu = new System.Windows.Forms.Panel();
            this.txtSoLuongTon = new DevExpress.XtraEditors.SpinEdit();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.ctpxTableAdapter = new QLVT_DATHANG.DSTableAdapters.CTPXTableAdapter();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.ctpnTableAdapter = new QLVT_DATHANG.DSTableAdapters.CTPNTableAdapter();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.ctddhTableAdapter = new QLVT_DATHANG.DSTableAdapters.CTDDHTableAdapter();
            mAVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            sOLUONGTONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongTon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(47, 52);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(96, 21);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Mã Vật Tư:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(416, 52);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(101, 21);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "Tên Vật Tư:";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(47, 114);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(110, 21);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "Đơn Vị Tính:";
            // 
            // sOLUONGTONLabel
            // 
            sOLUONGTONLabel.AutoSize = true;
            sOLUONGTONLabel.Location = new System.Drawing.Point(416, 114);
            sOLUONGTONLabel.Name = "sOLUONGTONLabel";
            sOLUONGTONLabel.Size = new System.Drawing.Size(125, 21);
            sOLUONGTONLabel.TabIndex = 6;
            sOLUONGTONLabel.Text = "Số Lượng Tồn:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemThem,
            this.barButtonItemXoa,
            this.barButtonItemGhi,
            this.barButtonItemUndo,
            this.barButtonItemReload,
            this.barButtonItemThoat});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItemThem
            // 
            this.barButtonItemThem.Caption = "Thêm";
            this.barButtonItemThem.Id = 0;
            this.barButtonItemThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemThem.ImageOptions.SvgImage")));
            this.barButtonItemThem.Name = "barButtonItemThem";
            this.barButtonItemThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemThem_ItemClick);
            // 
            // barButtonItemXoa
            // 
            this.barButtonItemXoa.Caption = "Xóa";
            this.barButtonItemXoa.Id = 1;
            this.barButtonItemXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemXoa.ImageOptions.SvgImage")));
            this.barButtonItemXoa.Name = "barButtonItemXoa";
            this.barButtonItemXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemXoa_ItemClick);
            // 
            // barButtonItemGhi
            // 
            this.barButtonItemGhi.Caption = "Ghi";
            this.barButtonItemGhi.Id = 2;
            this.barButtonItemGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemGhi.ImageOptions.SvgImage")));
            this.barButtonItemGhi.Name = "barButtonItemGhi";
            this.barButtonItemGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemGhi_ItemClick);
            // 
            // barButtonItemUndo
            // 
            this.barButtonItemUndo.Caption = "Undo";
            this.barButtonItemUndo.Id = 3;
            this.barButtonItemUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemUndo.ImageOptions.SvgImage")));
            this.barButtonItemUndo.Name = "barButtonItemUndo";
            this.barButtonItemUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemUndo_ItemClick);
            // 
            // barButtonItemReload
            // 
            this.barButtonItemReload.Caption = "Reload";
            this.barButtonItemReload.Id = 4;
            this.barButtonItemReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemReload.ImageOptions.SvgImage")));
            this.barButtonItemReload.Name = "barButtonItemReload";
            this.barButtonItemReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemReload_ItemClick);
            // 
            // barButtonItemThoat
            // 
            this.barButtonItemThoat.Caption = "Thoát";
            this.barButtonItemThoat.Id = 5;
            this.barButtonItemThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemThoat.ImageOptions.SvgImage")));
            this.barButtonItemThoat.Name = "barButtonItemThoat";
            this.barButtonItemThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDockControlTop.Appearance.Options.UseFont = true;
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1104, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 557);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1104, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 527);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1104, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 527);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.DS;
            // 
            // VatTuTableAdapter
            // 
            this.VatTuTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.VatTuTableAdapter;
            // 
            // gcVatTu
            // 
            this.gcVatTu.DataSource = this.bdsVatTu;
            this.gcVatTu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcVatTu.Location = new System.Drawing.Point(0, 30);
            this.gcVatTu.MainView = this.gridView1;
            this.gcVatTu.MenuManager = this.barManager1;
            this.gcVatTu.Name = "gcVatTu";
            this.gcVatTu.Size = new System.Drawing.Size(1104, 358);
            this.gcVatTu.TabIndex = 5;
            this.gcVatTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridView1.GridControl = this.gcVatTu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã Vật Tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 94;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên Vặt Tư";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.MinWidth = 25;
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 94;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "Đơn Vị Tính";
            this.colDVT.FieldName = "DVT";
            this.colDVT.MinWidth = 25;
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 94;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.Caption = "Số Lượng Tồn";
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.MinWidth = 25;
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            this.colSOLUONGTON.Width = 94;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Controls.Add(sOLUONGTONLabel);
            this.panelNhapLieu.Controls.Add(this.txtSoLuongTon);
            this.panelNhapLieu.Controls.Add(dVTLabel);
            this.panelNhapLieu.Controls.Add(this.txtDVT);
            this.panelNhapLieu.Controls.Add(tENVTLabel);
            this.panelNhapLieu.Controls.Add(this.txtTenVT);
            this.panelNhapLieu.Controls.Add(mAVTLabel);
            this.panelNhapLieu.Controls.Add(this.txtMaVT);
            this.panelNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieu.Location = new System.Drawing.Point(0, 388);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(1104, 169);
            this.panelNhapLieu.TabIndex = 6;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "SOLUONGTON", true));
            this.txtSoLuongTon.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoLuongTon.Location = new System.Drawing.Point(547, 111);
            this.txtSoLuongTon.MenuManager = this.barManager1;
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongTon.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuongTon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuongTon.Size = new System.Drawing.Size(266, 26);
            this.txtSoLuongTon.TabIndex = 7;
            // 
            // txtDVT
            // 
            this.txtDVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVatTu, "DVT", true));
            this.txtDVT.Location = new System.Drawing.Point(163, 111);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(100, 28);
            this.txtDVT.TabIndex = 5;
            // 
            // txtTenVT
            // 
            this.txtTenVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVatTu, "TENVT", true));
            this.txtTenVT.Location = new System.Drawing.Point(547, 49);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(266, 28);
            this.txtTenVT.TabIndex = 3;
            // 
            // txtMaVT
            // 
            this.txtMaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVatTu, "MAVT", true));
            this.txtMaVT.Enabled = false;
            this.txtMaVT.Location = new System.Drawing.Point(163, 49);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(100, 28);
            this.txtMaVT.TabIndex = 1;
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "FK_CTPX_VatTu";
            this.bdsCTPX.DataSource = this.bdsVatTu;
            // 
            // ctpxTableAdapter
            // 
            this.ctpxTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_VatTu";
            this.bdsCTPN.DataSource = this.bdsVatTu;
            // 
            // ctpnTableAdapter
            // 
            this.ctpnTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK_CTDDH_VatTu";
            this.bdsCTDDH.DataSource = this.bdsVatTu;
            // 
            // ctddhTableAdapter
            // 
            this.ctddhTableAdapter.ClearBeforeFill = true;
            // 
            // FormVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 557);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.gcVatTu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVatTu";
            this.Text = "Vật Tư";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongTon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItemThem;
        private DevExpress.XtraBars.BarButtonItem barButtonItemXoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGhi;
        private DevExpress.XtraBars.BarButtonItem barButtonItemUndo;
        private DevExpress.XtraBars.BarButtonItem barButtonItemReload;
        private DevExpress.XtraBars.BarButtonItem barButtonItemThoat;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private DS DS;
        private DSTableAdapters.VattuTableAdapter VatTuTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panelNhapLieu;
        private DevExpress.XtraGrid.GridControl gcVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private DevExpress.XtraEditors.SpinEdit txtSoLuongTon;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtTenVT;
        private System.Windows.Forms.TextBox txtMaVT;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private DSTableAdapters.CTPXTableAdapter ctpxTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DSTableAdapters.CTPNTableAdapter ctpnTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DSTableAdapters.CTDDHTableAdapter ctddhTableAdapter;
    }
}