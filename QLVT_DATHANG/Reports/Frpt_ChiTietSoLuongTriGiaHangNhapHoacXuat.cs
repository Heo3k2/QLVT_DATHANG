using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG.Reports
{
    public partial class Frpt_ChiTietSoLuongTriGiaHangNhapHoacXuat : Form
    {
        public Frpt_ChiTietSoLuongTriGiaHangNhapHoacXuat()
        {
            InitializeComponent();
            this.cmbLoaiPhieu.SelectedIndex = 1;
            this.dteTuNgay.EditValue = DateTime.Now;
            this.dteDenNgay.EditValue = DateTime.Now;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXemTruoc_Click(object sender, EventArgs e)
        {
            string vaiTro = Program.role;
            string loaiPhieu = (cmbLoaiPhieu.SelectedItem.ToString() == "Nhập") ? "NHAP" : "XUAT";

            DateTime fromDate = dteTuNgay.DateTime;
            DateTime toDate = dteDenNgay.DateTime;
            ReportChiTietSoLuongTriGiaHangNhapHoacXuat report = new ReportChiTietSoLuongTriGiaHangNhapHoacXuat(vaiTro, loaiPhieu, fromDate, toDate);
            /*GAN TEN CHI NHANH CHO BAO CAO*/
            report.lblTieuDe.Text = "BẢNG KÊ CHI TIẾT SỐ LƯỢNG - TRỊ GIÁ HÀNG " + cmbLoaiPhieu.SelectedItem.ToString().ToUpper();
            if (Program.role != "CONGTY")
                if(Program.serverName.Contains("1"))
                    report.lblChiNhanh.Text = "Chi Nhánh 1";
                else
                    report.lblChiNhanh.Text = "Chi Nhánh 2";
            report.lblDateFrom.Text = fromDate.ToString("dd-MM-yyyy");
            report.lblDateTo.Text = toDate.ToString("dd-MM-yyyy");
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void dteDenNgay_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dteTuNgay_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
