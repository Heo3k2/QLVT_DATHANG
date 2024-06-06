
namespace QLVT_DATHANG.SubForm
{
    partial class FormChonDonDatHang
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
            this.tableAdapterManager = new QLVT_DATHANG.DSTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btThoat = new System.Windows.Forms.Button();
            this.btChon = new System.Windows.Forms.Button();
            this.bdsDatHangKhongPN = new System.Windows.Forms.BindingSource(this.components);
            this.DatHangKhongPNTableAdapter = new QLVT_DATHANG.DSTableAdapters.DSDDHKhongPNTableAdapter();
            this.dSDDHKhongPNGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHangKhongPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDDHKhongPNGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btThoat);
            this.panel1.Controls.Add(this.btChon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 562);
            this.panel1.TabIndex = 2;
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Red;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.White;
            this.btThoat.Location = new System.Drawing.Point(651, 472);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(170, 51);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "THOÁT";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click_1);
            // 
            // btChon
            // 
            this.btChon.BackColor = System.Drawing.Color.Blue;
            this.btChon.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChon.ForeColor = System.Drawing.Color.White;
            this.btChon.Location = new System.Drawing.Point(155, 473);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(170, 51);
            this.btChon.TabIndex = 2;
            this.btChon.Text = "CHỌN";
            this.btChon.UseVisualStyleBackColor = false;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // bdsDatHangKhongPN
            // 
            this.bdsDatHangKhongPN.DataMember = "DSDDHKhongPN";
            this.bdsDatHangKhongPN.DataSource = this.DS;
            // 
            // DatHangKhongPNTableAdapter
            // 
            this.DatHangKhongPNTableAdapter.ClearBeforeFill = true;
            // 
            // dSDDHKhongPNGridControl
            // 
            this.dSDDHKhongPNGridControl.DataSource = this.bdsDatHangKhongPN;
            this.dSDDHKhongPNGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dSDDHKhongPNGridControl.Location = new System.Drawing.Point(0, 0);
            this.dSDDHKhongPNGridControl.MainView = this.gridView1;
            this.dSDDHKhongPNGridControl.Name = "dSDDHKhongPNGridControl";
            this.dSDDHKhongPNGridControl.Size = new System.Drawing.Size(1000, 419);
            this.dSDDHKhongPNGridControl.TabIndex = 2;
            this.dSDDHKhongPNGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dSDDHKhongPNGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // FormChonDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.dSDDHKhongPNGridControl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormChonDonDatHang";
            this.Text = "Chọn Đơn Đặt Hàng";
            this.Load += new System.EventHandler(this.FormChonDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHangKhongPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDDHKhongPNGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS DS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bdsDatHangKhongPN;
        private DSTableAdapters.DSDDHKhongPNTableAdapter DatHangKhongPNTableAdapter;
        private DevExpress.XtraGrid.GridControl dSDDHKhongPNGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btChon;
    }
}