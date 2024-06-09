using QLVT_DATHANG.SubForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
    public partial class FormDonDatHang : Form
    {
        int viTri = 0;

        bool dangThemMoi = false;

        Stack undoList = new Stack();

        Dictionary<string, object> rowData = new Dictionary<string, object>();
        public FormDonDatHang()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDatHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private bool kiemTraDuLieu()
        {
            if (txtMaSoDDH.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã đơn đặt hàng!", "Thông báo", MessageBoxButtons.OK);
                txtMaSoDDH.Focus();
                return false;
            }


            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã nhân viên!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtMaKho.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã kho!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtNhaCC.Text == "")
            {
                MessageBox.Show("Không bỏ trống nhà cung cấp!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void FormDonDatHang_Load(object sender, EventArgs e)
        {

            DS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
            this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTDDHTableAdapter.Fill(this.DS.CTDDH);

            // TODO: This line of code loads data into the 'DS.DSNV' table. You can move, or remove it, as needed.
            this.DSNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DSNVTableAdapter.Fill(this.DS.DSNV);

            // TODO: This line of code loads data into the 'DS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

            // TODO: This line of code loads data into the 'DS.Vattu' table. You can move, or remove it, as needed.
            this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.VatTuTableAdapter.Fill(this.DS.Vattu);

            //Combobox chọn chi nhánh
            cmbChiNhanh.DataSource = Program.bindingSource;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;

            if (Program.role == "CONGTY")
            {
                btnThem.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnCTDDH.Enabled = false;
                groupDatHang.Enabled = false;
                contextMenuStrip1.Enabled = false;
                dgvCTDDH.ReadOnly = true;
            }
            else
            {
                btnGhi.Enabled = true;
                cmbChiNhanh.Enabled = false;
                groupDatHang.Enabled = true;
                dgvCTDDH.Visible = false;
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
            else
            {
                // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.DS.DatHang);

                // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
                this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTDDHTableAdapter.Fill(this.DS.CTDDH);

                // TODO: This line of code loads data into the 'DS.DSNV' table. You can move, or remove it, as needed.
                this.DSNVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DSNVTableAdapter.Fill(this.DS.DSNV);

                // TODO: This line of code loads data into the 'DS.Vattu' table. You can move, or remove it, as needed.
                this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.VatTuTableAdapter.Fill(this.DS.Vattu);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.datHangTableAdapter.Fill(this.DS.DatHang);
                this.CTDDHTableAdapter.Fill(this.DS.CTDDH);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới dữ liệu!\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsDatHang.Position;
            dangThemMoi = true;

            bdsDatHang.AddNew();

            groupDatHang.Enabled = true;
            btnChonMaKho.Enabled = true;
            txtMaSoDDH.Enabled = true;
            txtMaNV.Enabled = cmbHoTen.Enabled = txtMaKho.Enabled = false;

            cmbHoTen.SelectedValue = Program.userName;
            txtMaNV.Text = Program.userName;

            DataRowView drv = ((DataRowView)bdsDatHang.Current);
            dtpNgay.Value = DateTime.Now;
            drv["MasoDDH"] = Program.maDonDatHangDuocChon;
            drv["MANV"] = Program.userName;
            drv["MAKHO"] = Program.maKhoDuocChon;

            Console.WriteLine("userName:" + Program.userName);
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnCTDDH.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;

            gcDatHang.Enabled = false;
            dgvCTDDH.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv = ((DataRowView)bdsDatHang[bdsDatHang.Position]);
            string maPN = drv["MANV"].ToString();

            if (Program.userName != maPN)
            {
                MessageBox.Show("Không thể xóa đơn đặt hàng của nhân viên khác!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsCTDDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa đơn đặt hàng vì đã có chi tiết đơn đặt hàng!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsPhieuNhap.Count > 0)
            {
                MessageBox.Show("Không thể xoá đơn đặt hàng vì đã có phiếu nhập!", "Thông báo", MessageBoxButtons.OK);
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    viTri = bdsDatHang.Position;

                    //*******************Phục vụ cho Undo*****************
                    DateTime ngay = ((DateTime)drv["NGAY"]);

                    string cauTruyVanHoanTac = "INSERT INTO DBO.DATHANG(MasoDDH, NGAY, NhaCC, MANV, MAKHO) " +
                            "VALUES( '" + drv["MasoDDH"].ToString().Trim() + "', '" +
                            ngay.ToString("yyyy-MM-dd") + "', '" +
                            drv["NhaCC"].ToString() + "', '" +
                            drv["MANV"].ToString() + "', '" +
                            drv["MAKHO"].ToString() + "')";

                    undoList.Push(cauTruyVanHoanTac);
                    Console.WriteLine("Câu truy vấn hoàn tác: " + cauTruyVanHoanTac);
                    //****************************************************

                    bdsDatHang.RemoveCurrent();
                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.datHangTableAdapter.Update(this.DS.DatHang);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUndo.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa đơn đặt hàng! Hãy thử lại!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.datHangTableAdapter.Fill(this.DS.DatHang);

                    bdsDatHang.Position = viTri;

                    return;
                }
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String MaNV = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MANV"].ToString();
            if (kiemTraDuLieu() == false)
                return;
            if (Program.userName != MaNV)
            {
                MessageBox.Show("Không thể chỉnh sửa phiếu của nhân viên khác", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.datHangTableAdapter.Fill(this.DS.DatHang);
                return;
            }
                string maSoDDH = txtMaSoDDH.Text.Trim();

            string cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_TraCuu_KiemTraMaDonDatHang '" +
                     maSoDDH + "' " +
                    "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();


            int viTriConTro = bdsDatHang.Position;
            int viTriMaSoDonDH = bdsDatHang.Find("MasoDDH", maSoDDH);

            if (result == 1 && viTriMaSoDonDH != viTriConTro)
            {
                MessageBox.Show("Mã phiếu nhập đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                txtMaSoDDH.Focus();
                return;
            }
            else
            {
                try
                {
                    string cauTruyVanHoanTac = "EXEC sp_TuDongThemCTPNvaSLVatTu '" + maSoDDH + "', '" + Program.maDonDatHangDuocChon + "', 'UNDO'";

                    undoList.Push(cauTruyVanHoanTac);
                    Console.WriteLine("Câu truy vấn hoàn tác: " + cauTruyVanHoanTac);
                    this.bdsDatHang.EndEdit();
                    this.datHangTableAdapter.Update(this.DS.DatHang);

                    this.btnThem.Enabled = true;
                    this.btnXoa.Enabled = true;
                    this.btnGhi.Enabled = true;
                    this.btnUndo.Enabled = true;
                    this.btnReload.Enabled = true;
                    this.btnCTDDH.Enabled = true;
                    this.btnThoat.Enabled = true;

                    this.txtMaSoDDH.Enabled = false;
                    this.gcDatHang.Enabled = true;
                    this.dgvCTDDH.Enabled = true;

                    dangThemMoi = false;
                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    this.datHangTableAdapter.Fill(this.DS.DatHang);
                    this.CTDDHTableAdapter.Fill(this.DS.CTDDH);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    bdsDatHang.RemoveCurrent();
                    MessageBox.Show("Đã xảy ra lỗi !\n\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThemMoi == true && this.btnThem.Enabled == false)
            {
                dangThemMoi = false;

                this.txtMaSoDDH.Enabled = false;
                this.btnChonMaKho.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnGhi.Enabled = false;
                this.btnUndo.Enabled = true;
                this.btnReload.Enabled = true;
                this.btnCTDDH.Enabled = true;
                this.btnThoat.Enabled = true;

                this.gcDatHang.Enabled = true;
                this.dgvCTDDH.Enabled = true;

                bdsDatHang.CancelEdit();
                bdsDatHang.RemoveCurrent();
                this.datHangTableAdapter.Fill(this.DS.DatHang);
                bdsDatHang.Position = viTri;

                return;
            }

            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnUndo.Enabled = false;
                return;
            }

            bdsDatHang.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();

            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);

            this.datHangTableAdapter.Fill(this.DS.DatHang);

            bdsDatHang.Position = viTri;
        }

        private void btnCTDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dgvCTDDH.Visible = !dgvCTDDH.Visible;
            gcDatHang.Enabled = !dgvCTDDH.Visible;
            groupDatHang.Enabled = !dgvCTDDH.Visible;

            btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnUndo.Enabled = btnReload.Enabled = btnThoat.Enabled = !dgvCTDDH.Visible;

            btnThemVT.Enabled = btnSuaVT.Enabled = btnXoaVT.Enabled = true;
            btnGhiVT.Enabled = false;

            this.CTDDHTableAdapter.Fill(this.DS.CTDDH);

            foreach (DataGridViewRow row in dgvCTDDH.Rows)
            {
                row.ReadOnly = true;
            }
        }

        private int kiemTraSLVTTrongVattu(string MAVT)
        {
            string cauTruyVan = "SELECT SOLUONGTON FROM Vattu WHERE MAVT = '" + MAVT + "'";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);

                if (Program.myReader == null)
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return -1;
            }

            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            return result;
        }

        private int kiemTraSLVT(string MasoDDH, string MAVT)
        {
            string cauTruyVan = "SELECT COALESCE(SUM(SOLUONG), 0) AS SOLUONG FROM CTDDH WHERE MasoDDH = '" + MasoDDH +
                                    "' AND MAVT = '" + MAVT + "'";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);

                if (Program.myReader == null)
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return -1;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            return result;
        }

        private bool kiemTraDuLieuVT()
        {
            if (dgvCTDDH.Rows[viTri].Cells["MAVT"].Value.ToString() == "")
            {
                MessageBox.Show("Vật tư không được để trống!", "Thông báo", MessageBoxButtons.OK);
                dgvCTDDH.CurrentCell = dgvCTDDH.Rows[viTri].Cells[1];
                dgvCTDDH.Focus();
                return false;
            }

            // Kiểm tra xem giá trị có trong bất kỳ hàng nào khác không (trừ hàng hiện tại)
            foreach (DataGridViewRow row in dgvCTDDH.Rows)
            {
                if (row.Index != viTri) // Đảm bảo không so sánh với chính nó
                {
                    if (row.Cells["MAVT"].Value.ToString().Equals(dgvCTDDH.Rows[viTri].Cells["MAVT"].Value.ToString()))
                    {
                        // Nếu tìm thấy giá trị giống nhau, hủy thay đổi và thông báo
                        MessageBox.Show("Đã tồn tại tên vật tư trong chi tiết phiếu nhập này rồi!", "Thông báo", MessageBoxButtons.OK);
                        dgvCTDDH.CurrentCell = dgvCTDDH.Rows[viTri].Cells[1];
                        dgvCTDDH.Focus();
                        return false;
                    }
                }
            }

            if (dgvCTDDH.Rows[viTri].Cells["SOLUONG"].Value.ToString() == "")
            {
                MessageBox.Show("Số lượng không được để trống!", "Thông báo", MessageBoxButtons.OK);
                dgvCTDDH.CurrentCell = dgvCTDDH.Rows[viTri].Cells[2];
                dgvCTDDH.Focus();
                return false;
            }
            if (int.Parse(dgvCTDDH.Rows[viTri].Cells["SOLUONG"].Value.ToString()) <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK);
                dgvCTDDH.CurrentCell = dgvCTDDH.Rows[viTri].Cells[2];
                dgvCTDDH.Focus();
                return false;
            }

            if (dgvCTDDH.Rows[viTri].Cells["DONGIA"].Value.ToString() == "")
            {
                MessageBox.Show("Đơn giá không được để trống!", "Thông báo", MessageBoxButtons.OK);
                dgvCTDDH.CurrentCell = dgvCTDDH.Rows[viTri].Cells[3];
                dgvCTDDH.Focus();
                return false;
            }
            if (float.Parse(dgvCTDDH.Rows[viTri].Cells["DONGIA"].Value.ToString()) < 0)
            {
                MessageBox.Show("Đơn giá không được nhỏ hơn 0!", "Thông báo", MessageBoxButtons.OK);
                dgvCTDDH.CurrentCell = dgvCTDDH.Rows[viTri].Cells[3];
                dgvCTDDH.Focus();
                return false;
            }


            return true;
        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            String MaNV = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MANV"].ToString();
            if (Program.userName != MaNV)
            {
                MessageBox.Show("Không thêm chi tiết phiếu nhập trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            btnThemVT.Enabled = false;
            btnSuaVT.Enabled = false;
            btnXoaVT.Enabled = false;
            btnGhiVT.Enabled = true;


            dangThemMoi = true;
            bdsCTDDH.AddNew();

            // Đặt hàng mới là có thể chỉnh sửa
            dgvCTDDH.CurrentRow.ReadOnly = false;
            viTri = dgvCTDDH.CurrentRow.Index;
        }

        private void btnSuaVT_Click(object sender, EventArgs e)
        {
            if (dgvCTDDH.CurrentRow.Index < 0)
                return;

            dgvCTDDH.CurrentRow.ReadOnly = false;
            viTri = dgvCTDDH.CurrentRow.Index;
            foreach (DataGridViewCell cell in dgvCTDDH.CurrentRow.Cells)
            {
                rowData[cell.OwningColumn.Name] = cell.Value;
            }

            btnThemVT.Enabled = false;
            btnSuaVT.Enabled = false;
            btnXoaVT.Enabled = false;
            btnGhiVT.Enabled = true;
        }

        private void btnXoaVT_Click(object sender, EventArgs e)
        {
            if (dgvCTDDH.CurrentRow.Index < 0)
                return;

            String MaNV = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MANV"].ToString();
            if (Program.userName != MaNV)
            {
                MessageBox.Show("Không xóa chi tiết đặt hàng trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                return;
            }


            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsCTDDH.Position = viTri;
                    bdsCTDDH.RemoveCurrent();

                    this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTDDHTableAdapter.Update(this.DS.CTDDH);
                    this.CTDDHTableAdapter.Fill(this.DS.CTDDH);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa chi tiết phiếu nhập!. Hãy thử lại\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);

                    this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTDDHTableAdapter.Fill(this.DS.CTDDH);
                    return;
                }
            }
        }

        private void btnGhiVT_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu không có hàng hiện tại được chọn
                if (dgvCTDDH.CurrentRow == null || dgvCTDDH.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Không có hàng nào được chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kết thúc chế độ chỉnh sửa hiện tại
                if (!dgvCTDDH.EndEdit())
                {
                    MessageBox.Show("Kết thúc chế độ chỉnh sửa thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dgvCTDDH.CurrentCell = dgvCTDDH.CurrentRow.Cells[0];
                dgvCTDDH.Focus();

                // Kiểm tra dữ liệu hợp lệ
                if (!kiemTraDuLieuVT())
                {
                    MessageBox.Show("Dữ liệu không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try {
                    // Lưu lại vị trí hiện tại
                    int currentRowIndex = dgvCTDDH.CurrentRow.Index;

                    // Thử ghi dữ liệu vào CSDL
                    this.bdsCTDDH.EndEdit();
                    this.CTDDHTableAdapter.Update(this.DS.CTDDH);
                    this.CTDDHTableAdapter.Fill(this.DS.CTDDH);

                    // Khôi phục lại vị trí của row
                    if (currentRowIndex >= 0 && currentRowIndex < dgvCTDDH.Rows.Count)
                    {
                        dgvCTDDH.CurrentCell = dgvCTDDH.Rows[currentRowIndex].Cells[0];
                    }

                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    dangThemMoi = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Chi tiết lỗi: " + ex.ToString());
                    MessageBox.Show("Ghi thất bại!\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Đặt tất cả các hàng thành chỉ đọc
                foreach (DataGridViewRow row in dgvCTDDH.Rows)
                    row.ReadOnly = true;

                // Cập nhật trạng thái các nút
                btnThemVT.Enabled = true;
                btnSuaVT.Enabled = true;
                btnXoaVT.Enabled = true;
                btnGhiVT.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChonMaKho_Click(object sender, EventArgs e)
        {
            FormChonKhoHang form = new FormChonKhoHang();
            form.ShowDialog();

            this.txtMaKho.Text = Program.maKhoDuocChon;
        }
    }
}
