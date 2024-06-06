using DevExpress.XtraReports.UI;
using QLVT_DATHANG.SubForm;
using System;
using System.Windows.Forms;

namespace QLVT_DATHANG.Reports
{
    public partial class Frpt_TinhHinhHoatDongNhanVien : Form
    {
        public Frpt_TinhHinhHoatDongNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void Frpt_TinhHinhHoatDongNhanVien_Load(object sender, EventArgs e)
        {
            this.DS.EnforceConstraints = false;

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

            dtpTuNgay.Value = DateTime.Now;
            dtpToiNgay.Value = DateTime.Now;
        }

        private void btnChonNhanVien_Click(object sender, EventArgs e)
        {
            FormChonNhanVien form = new FormChonNhanVien();
            form.ShowDialog();

            txtMaNV.Text = Program.maNhanVienDuocChon;
            txtHoTen.Text = Program.hoTen;
            txtNgaySinh.Text = Program.ngaySinh;
            txtDiaChi.Text = Program.diaChi;
            txtCMND.Text = Program.CMND;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXemTruoc_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNV.Text;
            DateTime fromDate = dtpTuNgay.Value;
            DateTime toDate = dtpToiNgay.Value;

            ReportHoatDongNhanVien report = new ReportHoatDongNhanVien(maNhanVien, fromDate, toDate);
            /*GAN TEN CHI NHANH CHO BAO CAO*/
            report.txtHoTen.Text = Program.hoTen;
            report.txtTuNgay.Text = dtpTuNgay.Value.ToString("dd/MM/yyyy");
            report.txtToiNgay.Text = dtpToiNgay.Value.ToString("dd/MM/yyyy");
            report.txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");

            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}
