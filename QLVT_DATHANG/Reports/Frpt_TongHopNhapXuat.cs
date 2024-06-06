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
    public partial class FormTongHopNhapXuat : Form
    {
        public FormTongHopNhapXuat()
        {
            InitializeComponent();
            dteDenNgay.EditValue = DateTime.Now;
            dteTuNgay.EditValue = DateTime.Now;

            cmbChiNhanh.DataSource = Program.bindingSource; //sao chép bindingSource từ form đăng nhập
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;

            if (Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
            }    
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }

            Program.serverName = cmbChiNhanh.SelectedValue.ToString();

            if (cmbChiNhanh.SelectedIndex != Program.brand)
            {
                Program.loginName = Program.remoteLogin;
                Program.loginPassword = Program.remotePassword;
            }
            else
            {
                Program.loginName = Program.currentLogin;
                Program.loginPassword = Program.currentPassword;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nói chi nhánh mới", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXemTruoc_Click_1(object sender, EventArgs e)
        {

            DateTime fromDate = dteTuNgay.DateTime;
            DateTime toDate = dteDenNgay.DateTime;
            ReportTongHopNhapXuat report = new ReportTongHopNhapXuat(fromDate, toDate);

   
            if (Program.role != "CONGTY")
                if (Program.serverName.Contains("1"))
                    report.lblChiNhanh.Text = "Chi Nhánh 1";
                else
                    report.lblChiNhanh.Text = "Chi Nhánh 2";

            report.lblDateFrom.Text = fromDate.ToString("dd-MM-yyyy");
            report.lblDateTo.Text = toDate.ToString("dd-MM-yyyy");
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
