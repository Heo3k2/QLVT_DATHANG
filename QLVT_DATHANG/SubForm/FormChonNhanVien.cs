using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG.SubForm
{
    public partial class FormChonNhanVien : Form
    {
        public FormChonNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVienHienTai.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormChonNhanVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.dSNhanVienHienTaiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSNhanVienHienTaiTableAdapter.Fill(this.DS.DSNhanVienHienTai);
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCHON_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bdsNhanVienHienTai.Current));
            string maNhanVien = drv["MANV"].ToString().Trim();

            string ho = drv["HO"].ToString().Trim();
            string ten = drv["TEN"].ToString().Trim();
            string hoTen = ho + " " + ten;

            string ngaySinh = ((DateTime)drv["NGAYSINH"]).ToString("dd-MM-yyyy");
            string diaChi = drv["DIACHI"].ToString().Trim();
            string cmnd = drv["SOCMND"].ToString().Trim();

            Program.maNhanVienDuocChon = maNhanVien;
            Program.hoTen = hoTen;
            //Console.WriteLine(Program.hoTen);
            Program.ngaySinh = ngaySinh;
            Program.diaChi = diaChi;
            Program.CMND = cmnd;

            this.Close();
        }
    }
}
