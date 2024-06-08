
namespace QLVT_DATHANG
{
    partial class FormDonDatHang
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
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDonDatHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnCTDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.labelChiNhanh = new System.Windows.Forms.Label();
            this.DS = new QLVT_DATHANG.DS();
            this.bdsDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT_DATHANG.DSTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.DSTableAdapters.TableAdapterManager();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.CTDDHTableAdapter = new QLVT_DATHANG.DSTableAdapters.CTDDHTableAdapter();
            this.groupDatHang = new DevExpress.XtraEditors.GroupControl();
            this.cmbHoTen = new System.Windows.Forms.ComboBox();
            this.bdsDSNV = new System.Windows.Forms.BindingSource(this.components);
            this.btnChonMaKho = new System.Windows.Forms.Button();
            this.txtMaKho = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.txtNhaCC = new DevExpress.XtraEditors.TextEdit();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.txtMaSoDDH = new DevExpress.XtraEditors.TextEdit();
            this.DSNVTableAdapter = new QLVT_DATHANG.DSTableAdapters.DSNVTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCTDDH = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAVT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsVattu = new System.Windows.Forms.BindingSource(this.components);
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT_DATHANG.DSTableAdapters.PhieuNhapTableAdapter();
            this.VatTuTableAdapter = new QLVT_DATHANG.DSTableAdapters.VattuTableAdapter();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDatHang = new DevExpress.XtraGrid.GridControl();
            this.btnThemVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiVT = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            masoDDHLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDatHang)).BeginInit();
            this.groupDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoDDH.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVattu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatHang)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(30, 54);
            masoDDHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(103, 17);
            masoDDHLabel.TabIndex = 0;
            masoDDHLabel.Text = "Mã Số Đơn ĐH:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(381, 53);
            nGAYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(45, 17);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày:";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(34, 99);
            nhaCCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(102, 17);
            nhaCCLabel.TabIndex = 4;
            nhaCCLabel.Text = "Nhà Cung Cấp:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(83, 146);
            mANVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(51, 17);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "Mã NV:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(77, 192);
            mAKHOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(58, 17);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "Mã Kho:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(369, 145);
            hOTENLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(57, 17);
            hOTENLabel.TabIndex = 11;
            hOTENLabel.Text = "Họ Tên:";
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
            this.btnCTDDH});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCTDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            this.btnGhi.Enabled = false;
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
            // btnCTDDH
            // 
            this.btnCTDDH.Caption = "Chi Tiết Đơn Đặt Hàng";
            this.btnCTDDH.Id = 6;
            this.btnCTDDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCTDDH.ImageOptions.SvgImage")));
            this.btnCTDDH.Name = "btnCTDDH";
            this.btnCTDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCTDDH_ItemClick);
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
            this.barDockControl2.Size = new System.Drawing.Size(1179, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 705);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1179, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 675);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1179, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 675);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.labelChiNhanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1179, 81);
            this.panelControl1.TabIndex = 9;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(224, 25);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(801, 24);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // labelChiNhanh
            // 
            this.labelChiNhanh.AutoSize = true;
            this.labelChiNhanh.Location = new System.Drawing.Point(53, 31);
            this.labelChiNhanh.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
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
            // bdsDatHang
            // 
            this.bdsDatHang.DataMember = "DatHang";
            this.bdsDatHang.DataSource = this.DS;
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
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK_CTDDH_DatHang";
            this.bdsCTDDH.DataSource = this.bdsDatHang;
            // 
            // CTDDHTableAdapter
            // 
            this.CTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // groupDatHang
            // 
            this.groupDatHang.Controls.Add(hOTENLabel);
            this.groupDatHang.Controls.Add(this.cmbHoTen);
            this.groupDatHang.Controls.Add(this.btnChonMaKho);
            this.groupDatHang.Controls.Add(mAKHOLabel);
            this.groupDatHang.Controls.Add(this.txtMaKho);
            this.groupDatHang.Controls.Add(mANVLabel);
            this.groupDatHang.Controls.Add(this.txtMaNV);
            this.groupDatHang.Controls.Add(nhaCCLabel);
            this.groupDatHang.Controls.Add(this.txtNhaCC);
            this.groupDatHang.Controls.Add(nGAYLabel);
            this.groupDatHang.Controls.Add(this.dtpNgay);
            this.groupDatHang.Controls.Add(masoDDHLabel);
            this.groupDatHang.Controls.Add(this.txtMaSoDDH);
            this.groupDatHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupDatHang.Location = new System.Drawing.Point(0, 382);
            this.groupDatHang.Margin = new System.Windows.Forms.Padding(4);
            this.groupDatHang.Name = "groupDatHang";
            this.groupDatHang.Size = new System.Drawing.Size(696, 323);
            this.groupDatHang.TabIndex = 19;
            this.groupDatHang.Text = "Đơn Đặt Hàng";
            // 
            // cmbHoTen
            // 
            this.cmbHoTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSNV, "HOTEN", true));
            this.cmbHoTen.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsDatHang, "MANV", true));
            this.cmbHoTen.DataSource = this.bdsDSNV;
            this.cmbHoTen.DisplayMember = "HOTEN";
            this.cmbHoTen.FormattingEnabled = true;
            this.cmbHoTen.Location = new System.Drawing.Point(437, 141);
            this.cmbHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHoTen.Name = "cmbHoTen";
            this.cmbHoTen.Size = new System.Drawing.Size(198, 24);
            this.cmbHoTen.TabIndex = 12;
            this.cmbHoTen.ValueMember = "MANV";
            // 
            // bdsDSNV
            // 
            this.bdsDSNV.DataMember = "DSNV";
            this.bdsDSNV.DataSource = this.DS;
            // 
            // btnChonMaKho
            // 
            this.btnChonMaKho.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonMaKho.Location = new System.Drawing.Point(373, 184);
            this.btnChonMaKho.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonMaKho.Name = "btnChonMaKho";
            this.btnChonMaKho.Size = new System.Drawing.Size(262, 28);
            this.btnChonMaKho.TabIndex = 10;
            this.btnChonMaKho.Text = "Chọn Mã Kho";
            this.btnChonMaKho.UseVisualStyleBackColor = true;
            this.btnChonMaKho.Click += new System.EventHandler(this.btnChonMaKho_Click);
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "MAKHO", true));
            this.txtMaKho.Location = new System.Drawing.Point(147, 188);
            this.txtMaKho.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKho.MenuManager = this.barManager1;
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(198, 22);
            this.txtMaKho.TabIndex = 9;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(146, 142);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(200, 22);
            this.txtMaNV.TabIndex = 7;
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "NhaCC", true));
            this.txtNhaCC.Location = new System.Drawing.Point(146, 96);
            this.txtNhaCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhaCC.MenuManager = this.barManager1;
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.Size = new System.Drawing.Size(200, 22);
            this.txtNhaCC.TabIndex = 5;
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgay.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsDatHang, "NGAY", true));
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(437, 48);
            this.dtpNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(198, 23);
            this.dtpNgay.TabIndex = 3;
            // 
            // txtMaSoDDH
            // 
            this.txtMaSoDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "MasoDDH", true));
            this.txtMaSoDDH.Location = new System.Drawing.Point(146, 50);
            this.txtMaSoDDH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSoDDH.MenuManager = this.barManager1;
            this.txtMaSoDDH.Name = "txtMaSoDDH";
            this.txtMaSoDDH.Size = new System.Drawing.Size(200, 22);
            this.txtMaSoDDH.TabIndex = 1;
            // 
            // DSNVTableAdapter
            // 
            this.DSNVTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCTDDH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(696, 382);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 323);
            this.panel1.TabIndex = 24;
            // 
            // dgvCTDDH
            // 
            this.dgvCTDDH.AllowUserToAddRows = false;
            this.dgvCTDDH.AllowUserToDeleteRows = false;
            this.dgvCTDDH.AutoGenerateColumns = false;
            this.dgvCTDDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.MAVT,
            this.SOLUONG,
            this.DONGIA});
            this.dgvCTDDH.DataSource = this.bdsCTDDH;
            this.dgvCTDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTDDH.Location = new System.Drawing.Point(0, 0);
            this.dgvCTDDH.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCTDDH.Name = "dgvCTDDH";
            this.dgvCTDDH.RowHeadersWidth = 51;
            this.dgvCTDDH.Size = new System.Drawing.Size(483, 323);
            this.dgvCTDDH.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MasoDDH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Số Đơn ĐH";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 175;
            // 
            // MAVT
            // 
            this.MAVT.DataPropertyName = "MAVT";
            this.MAVT.DataSource = this.bdsVattu;
            this.MAVT.DisplayMember = "TENVT";
            this.MAVT.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.MAVT.HeaderText = "Tên Vật Tư";
            this.MAVT.MinimumWidth = 6;
            this.MAVT.Name = "MAVT";
            this.MAVT.ValueMember = "MAVT";
            this.MAVT.Width = 300;
            // 
            // bdsVattu
            // 
            this.bdsVattu.DataMember = "Vattu";
            this.bdsVattu.DataSource = this.DS;
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
            // bdsPhieuNhap
            // 
            this.bdsPhieuNhap.DataMember = "FK_PhieuNhap_DatHang";
            this.bdsPhieuNhap.DataSource = this.bdsDatHang;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // VatTuTableAdapter
            // 
            this.VatTuTableAdapter.ClearBeforeFill = true;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gcDatHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã Số Đơn ĐH";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 27;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 100;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 27;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 100;
            // 
            // colNhaCC
            // 
            this.colNhaCC.Caption = "Nhà Cung Cấp";
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.MinWidth = 27;
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            this.colNhaCC.Width = 100;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã NV";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 27;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 100;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã Kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 27;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 100;
            // 
            // gcDatHang
            // 
            this.gcDatHang.DataSource = this.bdsDatHang;
            this.gcDatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDatHang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcDatHang.Location = new System.Drawing.Point(0, 111);
            this.gcDatHang.MainView = this.gridView1;
            this.gcDatHang.Margin = new System.Windows.Forms.Padding(4);
            this.gcDatHang.MenuManager = this.barManager1;
            this.gcDatHang.Name = "gcDatHang";
            this.gcDatHang.Size = new System.Drawing.Size(1179, 271);
            this.gcDatHang.TabIndex = 18;
            this.gcDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // btnThemVT
            // 
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.Size = new System.Drawing.Size(162, 24);
            this.btnThemVT.Text = "Thêm Vật Tư";
            this.btnThemVT.Click += new System.EventHandler(this.btnThemVT_Click);
            // 
            // btnSuaVT
            // 
            this.btnSuaVT.Name = "btnSuaVT";
            this.btnSuaVT.Size = new System.Drawing.Size(162, 24);
            this.btnSuaVT.Text = "Sửa Vật Tư";
            this.btnSuaVT.Click += new System.EventHandler(this.btnSuaVT_Click);
            // 
            // btnXoaVT
            // 
            this.btnXoaVT.Name = "btnXoaVT";
            this.btnXoaVT.Size = new System.Drawing.Size(162, 24);
            this.btnXoaVT.Text = "Xoá Vật Tư";
            this.btnXoaVT.Click += new System.EventHandler(this.btnXoaVT_Click);
            // 
            // btnGhiVT
            // 
            this.btnGhiVT.Name = "btnGhiVT";
            this.btnGhiVT.Size = new System.Drawing.Size(162, 24);
            this.btnGhiVT.Text = "Ghi Vật Tư";
            this.btnGhiVT.Click += new System.EventHandler(this.btnGhiVT_Click);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 100);
            // 
            // FormDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 705);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupDatHang);
            this.Controls.Add(this.gcDatHang);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDonDatHang";
            this.Text = "Đơn Đặt Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDatHang)).EndInit();
            this.groupDatHang.ResumeLayout(false);
            this.groupDatHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoDDH.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVattu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatHang)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnCTDDH;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label labelChiNhanh;
        private System.Windows.Forms.BindingSource bdsDatHang;
        private DS DS;
        private DSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DSTableAdapters.CTDDHTableAdapter CTDDHTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupDatHang;
        private System.Windows.Forms.Button btnChonMaKho;
        private DevExpress.XtraEditors.TextEdit txtMaKho;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.TextEdit txtNhaCC;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private DevExpress.XtraEditors.TextEdit txtMaSoDDH;
        private System.Windows.Forms.BindingSource bdsDSNV;
        private DSTableAdapters.DSNVTableAdapter DSNVTableAdapter;
        private System.Windows.Forms.ComboBox cmbHoTen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource bdsVattu;
        private DSTableAdapters.VattuTableAdapter VatTuTableAdapter;
        private DevExpress.XtraGrid.GridControl gcDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemVT;
        private System.Windows.Forms.ToolStripMenuItem btnSuaVT;
        private System.Windows.Forms.ToolStripMenuItem btnXoaVT;
        private System.Windows.Forms.ToolStripMenuItem btnGhiVT;
        private System.Windows.Forms.DataGridView dgvCTDDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn MAVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
    }
}