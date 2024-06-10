
namespace QLVT_DATHANG.Reports
{
    partial class Frpt_TinhHinhHoatDongNhanVien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label sOCMNDLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new QLVT_DATHANG.DS();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QLVT_DATHANG.DSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.DSTableAdapters.TableAdapterManager();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXemTruoc = new System.Windows.Forms.Button();
            this.groupBoxNhanVien = new System.Windows.Forms.GroupBox();
            this.txtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpToiNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.btnChonNhanVien = new System.Windows.Forms.Button();
            mANVLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            sOCMNDLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.groupBoxNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(39, 71);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(76, 23);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã NV:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(39, 111);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(79, 23);
            tENLabel.TabIndex = 2;
            tENLabel.Text = "Họ Tên:";
            // 
            // sOCMNDLabel
            // 
            sOCMNDLabel.AutoSize = true;
            sOCMNDLabel.Location = new System.Drawing.Point(428, 111);
            sOCMNDLabel.Name = "sOCMNDLabel";
            sOCMNDLabel.Size = new System.Drawing.Size(77, 23);
            sOCMNDLabel.TabIndex = 5;
            sOCMNDLabel.Text = "CMND:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(38, 151);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(80, 23);
            dIACHILabel.TabIndex = 7;
            dIACHILabel.Text = "Địa Chỉ:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(410, 151);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(102, 23);
            nGAYSINHLabel.TabIndex = 9;
            nGAYSINHLabel.Text = "Ngày Sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "HOẠT ĐỘNG CỦA NHÂN VIÊN";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.DS;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
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
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(811, 83);
            this.panelControl1.TabIndex = 5;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnThoat);
            this.panelControl2.Controls.Add(this.btnXemTruoc);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 385);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(811, 64);
            this.panelControl2.TabIndex = 6;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(460, 14);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(154, 39);
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
            this.btnXemTruoc.Location = new System.Drawing.Point(130, 14);
            this.btnXemTruoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnXemTruoc.Name = "btnXemTruoc";
            this.btnXemTruoc.Size = new System.Drawing.Size(154, 39);
            this.btnXemTruoc.TabIndex = 8;
            this.btnXemTruoc.Text = "XEM TRƯỚC";
            this.btnXemTruoc.UseVisualStyleBackColor = false;
            this.btnXemTruoc.Click += new System.EventHandler(this.btnXemTruoc_Click);
            // 
            // groupBoxNhanVien
            // 
            this.groupBoxNhanVien.Controls.Add(this.txtNgaySinh);
            this.groupBoxNhanVien.Controls.Add(this.txtCMND);
            this.groupBoxNhanVien.Controls.Add(this.txtDiaChi);
            this.groupBoxNhanVien.Controls.Add(this.txtHoTen);
            this.groupBoxNhanVien.Controls.Add(this.txtMaNV);
            this.groupBoxNhanVien.Controls.Add(this.label3);
            this.groupBoxNhanVien.Controls.Add(this.label2);
            this.groupBoxNhanVien.Controls.Add(this.dtpToiNgay);
            this.groupBoxNhanVien.Controls.Add(this.dtpTuNgay);
            this.groupBoxNhanVien.Controls.Add(nGAYSINHLabel);
            this.groupBoxNhanVien.Controls.Add(dIACHILabel);
            this.groupBoxNhanVien.Controls.Add(sOCMNDLabel);
            this.groupBoxNhanVien.Controls.Add(this.btnChonNhanVien);
            this.groupBoxNhanVien.Controls.Add(tENLabel);
            this.groupBoxNhanVien.Controls.Add(mANVLabel);
            this.groupBoxNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNhanVien.Location = new System.Drawing.Point(0, 83);
            this.groupBoxNhanVien.Name = "groupBoxNhanVien";
            this.groupBoxNhanVien.Size = new System.Drawing.Size(811, 302);
            this.groupBoxNhanVien.TabIndex = 7;
            this.groupBoxNhanVien.TabStop = false;
            this.groupBoxNhanVien.Text = "Thông Tin Nhân Viên";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.txtNgaySinh.Enabled = false;
            this.txtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgaySinh.Location = new System.Drawing.Point(511, 148);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(256, 30);
            this.txtNgaySinh.TabIndex = 19;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(511, 108);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Properties.Appearance.Options.UseFont = true;
            this.txtCMND.Properties.ReadOnly = true;
            this.txtCMND.Size = new System.Drawing.Size(256, 28);
            this.txtCMND.TabIndex = 18;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(126, 148);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Properties.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(256, 28);
            this.txtDiaChi.TabIndex = 17;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(126, 108);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Properties.Appearance.Options.UseFont = true;
            this.txtHoTen.Properties.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(256, 28);
            this.txtHoTen.TabIndex = 16;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(126, 68);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Properties.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(256, 28);
            this.txtMaNV.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tới Ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Từ Ngày:";
            // 
            // dtpToiNgay
            // 
            this.dtpToiNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpToiNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToiNgay.Location = new System.Drawing.Point(511, 197);
            this.dtpToiNgay.Name = "dtpToiNgay";
            this.dtpToiNgay.Size = new System.Drawing.Size(256, 30);
            this.dtpToiNgay.TabIndex = 12;
            this.dtpToiNgay.Value = new System.DateTime(2024, 6, 2, 0, 0, 0, 0);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(126, 197);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(256, 30);
            this.dtpTuNgay.TabIndex = 11;
            this.dtpTuNgay.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // btnChonNhanVien
            // 
            this.btnChonNhanVien.Location = new System.Drawing.Point(426, 65);
            this.btnChonNhanVien.Name = "btnChonNhanVien";
            this.btnChonNhanVien.Size = new System.Drawing.Size(341, 31);
            this.btnChonNhanVien.TabIndex = 4;
            this.btnChonNhanVien.Text = "Chọn Nhân Viên";
            this.btnChonNhanVien.UseVisualStyleBackColor = true;
            this.btnChonNhanVien.Click += new System.EventHandler(this.btnChonNhanVien_Click);
            // 
            // Frpt_TinhHinhHoatDongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 449);
            this.Controls.Add(this.groupBoxNhanVien);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frpt_TinhHinhHoatDongNhanVien";
            this.Text = "Tình Hình Hoạt Động Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frpt_TinhHinhHoatDongNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.groupBoxNhanVien.ResumeLayout(false);
            this.groupBoxNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DS DS;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.GroupBox groupBoxNhanVien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXemTruoc;
        private System.Windows.Forms.Button btnChonNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private System.Windows.Forms.DateTimePicker dtpToiNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
    }
}