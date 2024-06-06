using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG.Reports
{
    public partial class Frpt_DanhSachDonDatHangChuaCoPhieuNhap : Form
    {
        public Frpt_DanhSachDonDatHangChuaCoPhieuNhap()
        {
            InitializeComponent();
        }

        private void Frpt_DanhSachDonDatHangChuaCoPhieuNhap_Load(object sender, EventArgs e)
        {
            this.DS.EnforceConstraints = false;

            this.DSDDHKhongPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DSDDHKhongPNTableAdapter.Fill(this.DS.DSDDHKhongPN);
        }

        private void btnXemTruoc_Click_1(object sender, EventArgs e)
        {
            ReportDonHangKhongPhieuNhap report = new ReportDonHangKhongPhieuNhap();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
