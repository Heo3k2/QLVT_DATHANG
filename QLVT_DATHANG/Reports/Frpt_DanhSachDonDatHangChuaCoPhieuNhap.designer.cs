
namespace QLVT_DATHANG.Reports
{
    partial class Frpt_DanhSachDonDatHangChuaCoPhieuNhap
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
            this.DS = new QLVT_DATHANG.DS();
            this.bdsDSDDHKhongPN = new System.Windows.Forms.BindingSource(this.components);
            this.DSDDHKhongPNTableAdapter = new QLVT_DATHANG.DSTableAdapters.DSDDHKhongPNTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.DSTableAdapters.TableAdapterManager();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXemTruoc = new System.Windows.Forms.Button();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gcDSDDHKhongPN = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSDDHKhongPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSDDHKhongPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSDDHKhongPN
            // 
            this.bdsDSDDHKhongPN.DataMember = "DSDDHKhongPN";
            this.bdsDSDDHKhongPN.DataSource = this.DS;
            // 
            // DSDDHKhongPNTableAdapter
            // 
            this.DSDDHKhongPNTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1233, 63);
            this.panelControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(131, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH ĐƠN ĐẶT HÀNG KHÔNG CÓ PHIẾU NHẬP";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnThoat);
            this.panelControl2.Controls.Add(this.btnXemTruoc);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 558);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1233, 116);
            this.panelControl2.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(747, 38);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(205, 48);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXemTruoc
            // 
            this.btnXemTruoc.BackColor = System.Drawing.Color.Blue;
            this.btnXemTruoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTruoc.ForeColor = System.Drawing.Color.White;
            this.btnXemTruoc.Location = new System.Drawing.Point(280, 38);
            this.btnXemTruoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemTruoc.Name = "btnXemTruoc";
            this.btnXemTruoc.Size = new System.Drawing.Size(205, 48);
            this.btnXemTruoc.TabIndex = 8;
            this.btnXemTruoc.Text = "XEM TRƯỚC";
            this.btnXemTruoc.UseVisualStyleBackColor = false;
            this.btnXemTruoc.Click += new System.EventHandler(this.btnXemTruoc_Click_1);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gcDSDDHKhongPN);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 63);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1233, 495);
            this.panelControl3.TabIndex = 2;
            // 
            // gcDSDDHKhongPN
            // 
            this.gcDSDDHKhongPN.DataSource = this.bdsDSDDHKhongPN;
            this.gcDSDDHKhongPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDSDDHKhongPN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcDSDDHKhongPN.Location = new System.Drawing.Point(2, 2);
            this.gcDSDDHKhongPN.MainView = this.gridView1;
            this.gcDSDDHKhongPN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcDSDDHKhongPN.Name = "gcDSDDHKhongPN";
            this.gcDSDDHKhongPN.Size = new System.Drawing.Size(1229, 491);
            this.gcDSDDHKhongPN.TabIndex = 0;
            this.gcDSDDHKhongPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.gridView1.GridControl = this.gcDSDDHKhongPN;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "MSĐĐH";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 27;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 100;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "NGÀY";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 27;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 100;
            // 
            // colNhaCC
            // 
            this.colNhaCC.Caption = "NHÀ CUNG CẤP";
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.MinWidth = 27;
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            this.colNhaCC.Width = 100;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "MÃ NV";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 27;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 100;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "MÃ KHO";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 27;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 100;
            // 
            // Frpt_DanhSachDonDatHangChuaCoPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 674);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frpt_DanhSachDonDatHangChuaCoPhieuNhap";
            this.Text = "Danh Sách Đơn ĐH Chưa Có Phiếu Nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frpt_DanhSachDonDatHangChuaCoPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSDDHKhongPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDSDDHKhongPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS DS;
        private System.Windows.Forms.BindingSource bdsDSDDHKhongPN;
        private DSTableAdapters.DSDDHKhongPNTableAdapter DSDDHKhongPNTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXemTruoc;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gcDSDDHKhongPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
    }
}