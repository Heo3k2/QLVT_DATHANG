
namespace QLVT_DATHANG
{
    partial class FormPhieuXuat
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
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuXuat));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnChiTietPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.labelChiNhanh = new System.Windows.Forms.Label();
            this.DS = new QLVT_DATHANG.DS();
            this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
            this.PXTableAdapter = new QLVT_DATHANG.DSTableAdapters.PhieuXuatTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.DSTableAdapters.TableAdapterManager();
            this.CTPXTableAdapter = new QLVT_DATHANG.DSTableAdapters.CTPXTableAdapter();
            this.gcPX = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhapLieuPX = new DevExpress.XtraEditors.GroupControl();
            this.cmbTenKho = new System.Windows.Forms.ComboBox();
            this.bdsDSKho = new System.Windows.Forms.BindingSource(this.components);
            this.cmbHoTen = new System.Windows.Forms.ComboBox();
            this.bdsDSNV = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKho = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTenKH = new DevExpress.XtraEditors.TextEdit();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtMaPX = new DevExpress.XtraEditors.TextEdit();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCTPX = new System.Windows.Forms.DataGridView();
            this.MAPX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAVT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiVT = new System.Windows.Forms.ToolStripMenuItem();
            this.DSNVTableAdapter = new QLVT_DATHANG.DSTableAdapters.DSNVTableAdapter();
            this.DSKhoTableAdapter = new QLVT_DATHANG.DSTableAdapters.DSKhoTableAdapter();
            this.VatTuTableAdapter = new QLVT_DATHANG.DSTableAdapters.VattuTableAdapter();
            mAPXLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhapLieuPX)).BeginInit();
            this.NhapLieuPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAPXLabel.Location = new System.Drawing.Point(23, 63);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(124, 21);
            mAPXLabel.TabIndex = 0;
            mAPXLabel.Text = "Mã Phiếu Xuất:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYLabel.Location = new System.Drawing.Point(346, 63);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(53, 21);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày:";
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENKHLabel.Location = new System.Drawing.Point(297, 114);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(102, 21);
            hOTENKHLabel.TabIndex = 4;
            hOTENKHLabel.Text = "Họ Tên KH:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHOLabel.Location = new System.Drawing.Point(23, 227);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(75, 21);
            mAKHOLabel.TabIndex = 6;
            mAKHOLabel.Text = "Mã Kho:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(23, 168);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(120, 21);
            mANVLabel.TabIndex = 8;
            mANVLabel.Text = "Mã Nhân Viên:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENLabel.Location = new System.Drawing.Point(328, 168);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(71, 21);
            hOTENLabel.TabIndex = 10;
            hOTENLabel.Text = "Họ Tên:";
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENKHOLabel.Location = new System.Drawing.Point(319, 227);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(80, 21);
            tENKHOLabel.TabIndex = 12;
            tENKHOLabel.Text = "Tên Kho:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnGhi,
            this.btnUndo,
            this.btnReload,
            this.btnThoat,
            this.btnChiTietPX});
            this.barManager1.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnChiTietPX, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Id = 3;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnChiTietPX
            // 
            this.btnChiTietPX.Caption = "Chi tiết phiếu xuất";
            this.btnChiTietPX.Id = 6;
            this.btnChiTietPX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChiTietPX.ImageOptions.SvgImage")));
            this.btnChiTietPX.Name = "btnChiTietPX";
            this.btnChiTietPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChiTietPX_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControl2
            // 
            this.barDockControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDockControl2.Appearance.Options.UseFont = true;
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl2.Location = new System.Drawing.Point(0, 0);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl2.Size = new System.Drawing.Size(1255, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 745);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1255, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 715);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1255, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 715);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.labelChiNhanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1255, 68);
            this.panelControl1.TabIndex = 9;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(168, 20);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(5);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(602, 24);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // labelChiNhanh
            // 
            this.labelChiNhanh.AutoSize = true;
            this.labelChiNhanh.Location = new System.Drawing.Point(40, 25);
            this.labelChiNhanh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelChiNhanh.Name = "labelChiNhanh";
            this.labelChiNhanh.Size = new System.Drawing.Size(75, 17);
            this.labelChiNhanh.TabIndex = 0;
            this.labelChiNhanh.Text = "Chi nhánh:";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPX
            // 
            this.bdsPX.DataMember = "PhieuXuat";
            this.bdsPX.DataSource = this.DS;
            // 
            // PXTableAdapter
            // 
            this.PXTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = this.CTPXTableAdapter;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.PXTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // CTPXTableAdapter
            // 
            this.CTPXTableAdapter.ClearBeforeFill = true;
            // 
            // gcPX
            // 
            this.gcPX.DataSource = this.bdsPX;
            this.gcPX.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPX.Location = new System.Drawing.Point(0, 98);
            this.gcPX.MainView = this.gridView1;
            this.gcPX.MenuManager = this.barManager1;
            this.gcPX.Name = "gcPX";
            this.gcPX.Size = new System.Drawing.Size(1255, 370);
            this.gcPX.TabIndex = 10;
            this.gcPX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY,
            this.colHOTENKH,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.gcPX;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colMAPX
            // 
            this.colMAPX.Caption = "Mã Phiếu Xuất";
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.MinWidth = 25;
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
            this.colMAPX.Width = 94;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 94;
            // 
            // colHOTENKH
            // 
            this.colHOTENKH.Caption = "Họ Tên Khách Hàng";
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.MinWidth = 25;
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 2;
            this.colHOTENKH.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã Nhân Viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 94;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã Kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 25;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 94;
            // 
            // NhapLieuPX
            // 
            this.NhapLieuPX.Controls.Add(tENKHOLabel);
            this.NhapLieuPX.Controls.Add(this.cmbTenKho);
            this.NhapLieuPX.Controls.Add(hOTENLabel);
            this.NhapLieuPX.Controls.Add(this.cmbHoTen);
            this.NhapLieuPX.Controls.Add(mANVLabel);
            this.NhapLieuPX.Controls.Add(this.txtMaNV);
            this.NhapLieuPX.Controls.Add(mAKHOLabel);
            this.NhapLieuPX.Controls.Add(this.txtMaKho);
            this.NhapLieuPX.Controls.Add(hOTENKHLabel);
            this.NhapLieuPX.Controls.Add(this.txtHoTenKH);
            this.NhapLieuPX.Controls.Add(nGAYLabel);
            this.NhapLieuPX.Controls.Add(this.txtDate);
            this.NhapLieuPX.Controls.Add(mAPXLabel);
            this.NhapLieuPX.Controls.Add(this.txtMaPX);
            this.NhapLieuPX.Dock = System.Windows.Forms.DockStyle.Left;
            this.NhapLieuPX.Location = new System.Drawing.Point(0, 468);
            this.NhapLieuPX.Name = "NhapLieuPX";
            this.NhapLieuPX.Size = new System.Drawing.Size(696, 277);
            this.NhapLieuPX.TabIndex = 11;
            this.NhapLieuPX.Text = "Phiếu Xuất";
            // 
            // cmbTenKho
            // 
            this.cmbTenKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSKho, "TENKHO", true));
            this.cmbTenKho.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPX, "MAKHO", true));
            this.cmbTenKho.DataSource = this.bdsDSKho;
            this.cmbTenKho.DisplayMember = "TENKHO";
            this.cmbTenKho.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenKho.FormattingEnabled = true;
            this.cmbTenKho.Location = new System.Drawing.Point(422, 220);
            this.cmbTenKho.Name = "cmbTenKho";
            this.cmbTenKho.Size = new System.Drawing.Size(221, 28);
            this.cmbTenKho.TabIndex = 13;
            this.cmbTenKho.ValueMember = "MAKHO";
            this.cmbTenKho.SelectedIndexChanged += new System.EventHandler(this.cmbTenKho_SelectedIndexChanged);
            // 
            // bdsDSKho
            // 
            this.bdsDSKho.DataMember = "DSKho";
            this.bdsDSKho.DataSource = this.DS;
            // 
            // cmbHoTen
            // 
            this.cmbHoTen.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPX, "MANV", true));
            this.cmbHoTen.DataSource = this.bdsDSNV;
            this.cmbHoTen.DisplayMember = "HOTEN";
            this.cmbHoTen.Enabled = false;
            this.cmbHoTen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHoTen.FormattingEnabled = true;
            this.cmbHoTen.Location = new System.Drawing.Point(422, 163);
            this.cmbHoTen.Name = "cmbHoTen";
            this.cmbHoTen.Size = new System.Drawing.Size(221, 28);
            this.cmbHoTen.TabIndex = 11;
            this.cmbHoTen.ValueMember = "MANV";
            this.cmbHoTen.SelectedIndexChanged += new System.EventHandler(this.cmbHoTen_SelectedIndexChanged);
            // 
            // bdsDSNV
            // 
            this.bdsDSNV.DataMember = "DSNV";
            this.bdsDSNV.DataSource = this.DS;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "MANV", true));
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(153, 165);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Size = new System.Drawing.Size(125, 26);
            this.txtMaNV.TabIndex = 9;
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "MAKHO", true));
            this.txtMaKho.Enabled = false;
            this.txtMaKho.Location = new System.Drawing.Point(153, 224);
            this.txtMaKho.MenuManager = this.barManager1;
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKho.Properties.Appearance.Options.UseFont = true;
            this.txtMaKho.Size = new System.Drawing.Size(125, 26);
            this.txtMaKho.TabIndex = 7;
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "HOTENKH", true));
            this.txtHoTenKH.Location = new System.Drawing.Point(422, 111);
            this.txtHoTenKH.MenuManager = this.barManager1;
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenKH.Properties.Appearance.Options.UseFont = true;
            this.txtHoTenKH.Size = new System.Drawing.Size(221, 26);
            this.txtHoTenKH.TabIndex = 5;
            // 
            // txtDate
            // 
            this.txtDate.CustomFormat = "dd/MM/yyyy";
            this.txtDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsPX, "NGAY", true));
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDate.Location = new System.Drawing.Point(422, 59);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(221, 28);
            this.txtDate.TabIndex = 3;
            // 
            // txtMaPX
            // 
            this.txtMaPX.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "MAPX", true));
            this.txtMaPX.Enabled = false;
            this.txtMaPX.Location = new System.Drawing.Point(153, 60);
            this.txtMaPX.MenuManager = this.barManager1;
            this.txtMaPX.Name = "txtMaPX";
            this.txtMaPX.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPX.Properties.Appearance.Options.UseFont = true;
            this.txtMaPX.Size = new System.Drawing.Size(125, 26);
            this.txtMaPX.TabIndex = 1;
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "FK_CTPX_PX";
            this.bdsCTPX.DataSource = this.bdsPX;
            // 
            // dgvCTPX
            // 
            this.dgvCTPX.AllowUserToAddRows = false;
            this.dgvCTPX.AllowUserToDeleteRows = false;
            this.dgvCTPX.AutoGenerateColumns = false;
            this.dgvCTPX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPX,
            this.MAVT,
            this.SOLUONG,
            this.DONGIA});
            this.dgvCTPX.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCTPX.DataSource = this.bdsCTPX;
            this.dgvCTPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTPX.Location = new System.Drawing.Point(696, 468);
            this.dgvCTPX.Name = "dgvCTPX";
            this.dgvCTPX.RowHeadersWidth = 51;
            this.dgvCTPX.RowTemplate.Height = 24;
            this.dgvCTPX.Size = new System.Drawing.Size(559, 277);
            this.dgvCTPX.TabIndex = 11;
            this.dgvCTPX.Visible = false;
            this.dgvCTPX.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCTPX_DataError);
            // 
            // MAPX
            // 
            this.MAPX.DataPropertyName = "MAPX";
            this.MAPX.HeaderText = "Mã Phiếu Xuất";
            this.MAPX.MinimumWidth = 6;
            this.MAPX.Name = "MAPX";
            this.MAPX.ReadOnly = true;
            this.MAPX.Width = 175;
            // 
            // MAVT
            // 
            this.MAVT.DataPropertyName = "MAVT";
            this.MAVT.DataSource = this.bdsVatTu;
            this.MAVT.DisplayMember = "TENVT";
            this.MAVT.HeaderText = "Tên Vật Tư";
            this.MAVT.MinimumWidth = 6;
            this.MAVT.Name = "MAVT";
            this.MAVT.ValueMember = "MAVT";
            this.MAVT.Width = 300;
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.DS;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Width = 125;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn Giá";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemVT,
            this.btnSuaVT,
            this.btnXoaVT,
            this.btnGhiVT});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 100);
            // 
            // btnThemVT
            // 
            this.btnThemVT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.Size = new System.Drawing.Size(157, 24);
            this.btnThemVT.Text = "Thêm vật tư";
            this.btnThemVT.Click += new System.EventHandler(this.btnThemVT_Click);
            // 
            // btnSuaVT
            // 
            this.btnSuaVT.Name = "btnSuaVT";
            this.btnSuaVT.Size = new System.Drawing.Size(157, 24);
            this.btnSuaVT.Text = "Sửa vật tư";
            this.btnSuaVT.Click += new System.EventHandler(this.btnSuaVT_Click);
            // 
            // btnXoaVT
            // 
            this.btnXoaVT.Name = "btnXoaVT";
            this.btnXoaVT.Size = new System.Drawing.Size(157, 24);
            this.btnXoaVT.Text = "Xóa vật tư";
            this.btnXoaVT.Click += new System.EventHandler(this.btnXoaVT_Click);
            // 
            // btnGhiVT
            // 
            this.btnGhiVT.Name = "btnGhiVT";
            this.btnGhiVT.Size = new System.Drawing.Size(157, 24);
            this.btnGhiVT.Text = "Ghi vật tư";
            this.btnGhiVT.Click += new System.EventHandler(this.btnGhiVT_Click);
            // 
            // DSNVTableAdapter
            // 
            this.DSNVTableAdapter.ClearBeforeFill = true;
            // 
            // DSKhoTableAdapter
            // 
            this.DSKhoTableAdapter.ClearBeforeFill = true;
            // 
            // VatTuTableAdapter
            // 
            this.VatTuTableAdapter.ClearBeforeFill = true;
            // 
            // FormPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 745);
            this.Controls.Add(this.dgvCTPX);
            this.Controls.Add(this.NhapLieuPX);
            this.Controls.Add(this.gcPX);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl2);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPhieuXuat";
            this.Text = "Phiếu Xuất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhapLieuPX)).EndInit();
            this.NhapLieuPX.ResumeLayout(false);
            this.NhapLieuPX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnChiTietPX;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label labelChiNhanh;
        private System.Windows.Forms.BindingSource bdsPX;
        private DS DS;
        private DSTableAdapters.PhieuXuatTableAdapter PXTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcPX;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl NhapLieuPX;
        private DSTableAdapters.CTPXTableAdapter CTPXTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private System.Windows.Forms.DataGridView dgvCTPX;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.TextEdit txtMaKho;
        private DevExpress.XtraEditors.TextEdit txtHoTenKH;
        private System.Windows.Forms.DateTimePicker txtDate;
        private DevExpress.XtraEditors.TextEdit txtMaPX;
        private System.Windows.Forms.BindingSource bdsDSNV;
        private DSTableAdapters.DSNVTableAdapter DSNVTableAdapter;
        private System.Windows.Forms.ComboBox cmbHoTen;
        private System.Windows.Forms.BindingSource bdsDSKho;
        private DSTableAdapters.DSKhoTableAdapter DSKhoTableAdapter;
        private System.Windows.Forms.ComboBox cmbTenKho;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private DSTableAdapters.VattuTableAdapter VatTuTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemVT;
        private System.Windows.Forms.ToolStripMenuItem btnSuaVT;
        private System.Windows.Forms.ToolStripMenuItem btnXoaVT;
        private System.Windows.Forms.ToolStripMenuItem btnGhiVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPX;
        private System.Windows.Forms.DataGridViewComboBoxColumn MAVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
    }
}