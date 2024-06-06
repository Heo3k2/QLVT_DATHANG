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
    public partial class FormChonDonDatHang : Form
    {
        public FormChonDonDatHang()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDatHangKhongPN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormChonDonDatHang_Load(object sender, EventArgs e)
        {
            /*không kiểm tra khóa ngoại nữa*/
            DS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'DS.DSDDHKhongPN' table. You can move, or remove it, as needed.
            this.DatHangKhongPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DatHangKhongPNTableAdapter.Fill(this.DS.DSDDHKhongPN);

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bdsDatHangKhongPN.Current));
            string maNV = drv["MANV"].ToString().Trim();
            string maDDH = drv["MasoDDH"].ToString().Trim();
            string maKho = drv["MaKho"].ToString().Trim();

            if(Program.userName != maNV)
            {
                MessageBox.Show("Bạn không thể lập phiếu nhập trên đơn đặt hàng do người khác tạo!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            Program.maDonDatHangDuocChon = maDDH;
            Program.maKhoDuocChon = maKho;

            this.Close();
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
