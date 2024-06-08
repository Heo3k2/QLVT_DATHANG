using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
    public partial class FormPhieuXuat : Form
    {
        int viTri;
        bool dangThemMoi = false;

        Stack undoList = new Stack();

        Dictionary<string, object> rowData = new Dictionary<string, object>();

        public FormPhieuXuat()
        {
            InitializeComponent();
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPX.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormPhieuXuat_Load(object sender, EventArgs e)
        {
            /*không kiểm tra khóa ngoại nữa*/
            DS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.PhieuXuat' table. You can move, or remove it, as needed.
            this.PXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.PXTableAdapter.Fill(this.DS.PhieuXuat);

            // TODO: This line of code loads data into the 'dS.CTPX' table. You can move, or remove it, as needed.
            this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPXTableAdapter.Fill(this.DS.CTPX);

            // TODO: This line of code loads data into the 'dS.DSNV' table. You can move, or remove it, as needed.
            this.DSNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DSNVTableAdapter.Fill(this.DS.DSNV);

            // TODO: This line of code loads data into the 'dS.DSKho' table. You can move, or remove it, as needed.
            this.DSKhoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DSKhoTableAdapter.Fill(this.DS.DSKho);

            // TODO: This line of code loads data into the 'dS.Vattu' table. You can move, or remove it, as needed.
            this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.VatTuTableAdapter.Fill(this.DS.Vattu);

            //Combobox chọn chi nhánh
            cmbChiNhanh.DataSource = Program.bindingSource; //sao chép bindingSource từ form đăng nhập
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;

            //Phân quyền
            if (Program.role == "CONGTY")
            {
                btnThem.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnUndo.Enabled = false;
                contextMenuStrip1.Enabled = false;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
            }
        }

        private void cmbHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbHoTen.SelectedValue != null)
                    txtMaNV.Text = cmbHoTen.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void cmbTenKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTenKho.SelectedValue != null)
                    txtMaKho.Text = cmbTenKho.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.PXTableAdapter.Fill(this.DS.PhieuXuat);
                this.CTPXTableAdapter.Fill(this.DS.CTPX);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới dữ liệu!\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
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
                this.PXTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PXTableAdapter.Fill(this.DS.PhieuXuat);

                // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
                this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTPXTableAdapter.Fill(this.DS.CTPX);

                // TODO: This line of code loads data into the 'DS.DSNV' table. You can move, or remove it, as needed.
                this.DSNVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DSNVTableAdapter.Fill(this.DS.DSNV);

                // TODO: This line of code loads data into the 'dS.DSKho' table. You can move, or remove it, as needed.
                this.DSKhoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DSKhoTableAdapter.Fill(this.DS.DSKho);

                // TODO: This line of code loads data into the 'DS.Vattu' table. You can move, or remove it, as needed.
                //this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
                //this.VatTuTableAdapter.Fill(this.DS.Vattu);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsPX.Position;

            bdsPX.AddNew();
            dangThemMoi = true;

            this.gcPX.Enabled = false;

            this.btnThem.Enabled = false;
            this.btnUndo.Enabled = true;
            this.btnXoa.Enabled = false;
            this.btnReload.Enabled = false;
            this.btnChiTietPX.Enabled = false;

            this.txtMaPX.Enabled = true;

            this.txtDate.Value = DateTime.Now;
            this.cmbHoTen.SelectedValue = Program.userName;
        }

        private bool kiemTraDuLieu()
        {
            if (txtMaPX.Text == "")
            {
                MessageBox.Show("Không được bỏ trống mã phiếu nhập!", "Thông báo", MessageBoxButtons.OK);
                txtMaPX.Focus();
                return false;
            }
            if (txtMaPX.Text.Length > 8)
            {
                MessageBox.Show("Mã phiếu xuất không thể quá 8 kí tự!", "Thông báo", MessageBoxButtons.OK);
                txtMaPX.Focus();
                return false;
            }
            /*if (Regex.IsMatch(txtMaPX.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã phiếu nhập chỉ có thể là chữ và số!", "Thông báo", MessageBoxButtons.OK);
                txtMaPX.Focus();
                return false;
            }*/

            if (txtHoTenKH.Text == "")
            {
                MessageBox.Show("Không được bỏ trống tên khách hàng!", "Thông báo", MessageBoxButtons.OK);
                txtHoTenKH.Focus();
                return false;
            }
            if (txtHoTenKH.Text.Length > 100)
            {
                MessageBox.Show("Tên khách hàng không quá 100 kí tự!", "Thông báo", MessageBoxButtons.OK);
                txtHoTenKH.Focus();
                return false;
            }

            if (cmbTenKho.SelectedValue == null)
            {
                MessageBox.Show("Không được bỏ trống kho!", "Thông báo", MessageBoxButtons.OK);
                cmbTenKho.Focus();
                return false;
            }

            return false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsPX.Position;

            if (Program.userName != txtMaNV.Text.ToString().Trim())
            {
                MessageBox.Show("Không thể ghi phiếu xuất do người khác tạo!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (kiemTraDuLieu())
                return;

            String maPX = txtMaPX.Text.ToString().Trim();
            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_KiemTraMaPhieuXuat '" + maPX + "' " +
                    "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);

                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }

            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();

            int viTriConTro = bdsPX.Position;
            int viTriMaPhieuXuat = bdsPX.Find("MAPX", maPX);

            if (result == 1 && viTriMaPhieuXuat != viTriConTro)
            {
                MessageBox.Show("Mã phiếu xuất đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                txtMaPX.Focus();
                return;
            }
            else
            {
                try
                {
                    string cauTruyVanHoanTac;

                    if (dangThemMoi)
                    {
                        cauTruyVanHoanTac = "DELETE FROM DBO.PHIEUXUAT " +
                                            "WHERE MAPX = '" + maPX + "'";
                    }
                    else
                    {
                        string maKhoMoi = txtMaKho.Text.ToString().Trim();
                        string hoTenKHMoi = txtHoTenKH.Text.ToString().Trim();

                        this.PXTableAdapter.Fill(this.DS.PhieuXuat);
                        bdsPX.Position = viTri;

                        cauTruyVanHoanTac = "UPDATE DBO.PHIEUXUAT " +
                                            "SET HOTENKH = N'" + txtHoTenKH.Text.ToString().Trim() + "', " +
                                            "MAKHO = '" + txtMaKho.Text.ToString().Trim() + "' " +
                                            "WHERE MAPX = '" + maPX + "'";

                        txtMaKho.Text = maKhoMoi;
                        txtHoTenKH.Text = hoTenKHMoi;
                    }


                    undoList.Push(cauTruyVanHoanTac);
                    Console.WriteLine("Câu truy vấn hoàn tác: " + cauTruyVanHoanTac);

                    this.bdsPX.EndEdit();
                    this.PXTableAdapter.Update(this.DS.PhieuXuat);
                    this.PXTableAdapter.Fill(this.DS.PhieuXuat);

                    this.gcPX.Enabled = true;

                    this.btnThem.Enabled = true;
                    this.btnUndo.Enabled = true;
                    this.btnXoa.Enabled = true;
                    this.btnReload.Enabled = true;
                    this.btnChiTietPX.Enabled = true;

                    this.txtMaPX.Enabled = false;

                    dangThemMoi = false;
                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    bdsPX.RemoveCurrent();
                    MessageBox.Show("Đã có lỗi xảy ra!\n\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThemMoi == true && this.btnThem.Enabled == false)
            {
                this.bdsPX.CancelEdit();
                this.PXTableAdapter.Fill(this.DS.PhieuXuat);

                this.gcPX.Enabled = true;

                this.btnThem.Enabled = true;
                this.btnUndo.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnReload.Enabled = true;
                this.btnChiTietPX.Enabled = true;

                this.txtMaPX.Enabled = false;

                dangThemMoi = false;
                bdsPX.Position = viTri;

                return;
            }

            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục!", "Thông báo", MessageBoxButtons.OK);
                btnUndo.Enabled = false;
                return;
            }

            bdsPX.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();

            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);

            this.PXTableAdapter.Fill(this.DS.PhieuXuat);
            this.CTPXTableAdapter.Fill(this.DS.CTPX);

            bdsPX.Position = viTri;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv = ((DataRowView)bdsPX[bdsPX.Position]);
            string maPX = drv["MANV"].ToString();

            if (Program.userName != maPX)
            {
                MessageBox.Show("Không thể xóa phiếu nhập của nhân viên khác!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsCTPX.Count > 0)
            {
                MessageBox.Show("Không thể xóa phiếu nhập vì đã có chi tiết phiếu nhập!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    viTri = bdsPX.Position;

                    //*******************Phục vụ cho Undo*****************
                    DateTime ngay = ((DateTime)drv["NGAY"]);

                    string cauTruyVanHoanTac = "INSERT INTO DBO.PHIEUXUAT(MAPX, NGAY, HOTENKH, MANV, MAKHO) " +
                            "VALUES( '" + drv["MAPX"].ToString().Trim() + "', '" +
                            ngay.ToString("yyyy-MM-dd") + "', '" +
                            drv["HOTENKH"].ToString() + "', '" +
                            drv["MANV"].ToString() + "', '" +
                            drv["MAKHO"].ToString() + "')";

                    undoList.Push(cauTruyVanHoanTac);
                    Console.WriteLine("Câu truy vấn hoàn tác: " + cauTruyVanHoanTac);
                    //****************************************************

                    bdsPX.RemoveCurrent();
                    this.PXTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.PXTableAdapter.Update(this.DS.PhieuXuat);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUndo.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu nhập! Hãy thử lại!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.PXTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.PXTableAdapter.Fill(this.DS.PhieuXuat);

                    bdsPX.Position = viTri;

                    return;
                }
            }
        }

        private void btnChiTietPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsPX.Position;
            dgvCTPX.Visible = !dgvCTPX.Visible;
            gcPX.Enabled = !dgvCTPX.Visible;
            NhapLieuPX.Enabled = !NhapLieuPX.Enabled;

            undoList.Clear();

            btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnUndo.Enabled = btnReload.Enabled = btnThoat.Enabled = !dgvCTPX.Visible;

            btnThemVT.Enabled = btnSuaVT.Enabled = btnXoaVT.Enabled = true;
            btnGhiVT.Enabled = false;

            this.CTPXTableAdapter.Fill(this.DS.CTPX);
            
            this.PXTableAdapter.Fill(this.DS.PhieuXuat);
            bdsPX.Position = viTri;

            foreach (DataGridViewRow row in dgvCTPX.Rows)
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

        private void capNhatSoLuongVatTu(string CheDo, string MaVT, int SoLuong)
        {
            try
            {
                string cauTruyVan = "EXEC sp_CapNhatSoLuongVatTu '" + CheDo + "', '" + MaVT + "', " + SoLuong;
                Console.WriteLine(cauTruyVan);
                int n = Program.ExecSqlNonQuery(cauTruyVan);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Đã xảy ra lỗi !\n\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            String MaNV = ((DataRowView)bdsPX[bdsPX.Position])["MANV"].ToString();
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
            bdsCTPX.AddNew();

            // Đặt hàng mới là có thể chỉnh sửa
            dgvCTPX.CurrentRow.ReadOnly = false;
            viTri = dgvCTPX.CurrentRow.Index;
        }

        private void btnSuaVT_Click(object sender, EventArgs e)
        {
            if (dgvCTPX.CurrentRow.Index < 0)
                return;

            dgvCTPX.CurrentRow.ReadOnly = false;
            viTri = dgvCTPX.CurrentRow.Index;
            foreach (DataGridViewCell cell in dgvCTPX.CurrentRow.Cells)
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
            if (dgvCTPX.CurrentRow.Index < 0)
                return;

            String MaNV = ((DataRowView)bdsPX[bdsPX.Position])["MANV"].ToString();
            if (Program.userName != MaNV)
            {
                MessageBox.Show("Không xóa chi tiết phiếu nhập trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsCTPX.Position = viTri;
                    capNhatSoLuongVatTu("NHAP", dgvCTPX.CurrentRow.Cells["MAVT"].Value.ToString(), int.Parse(dgvCTPX.CurrentRow.Cells["SOLUONG"].Value.ToString()));
                    bdsCTPX.RemoveCurrent();

                    this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTPXTableAdapter.Update(this.DS.CTPX);
                    this.CTPXTableAdapter.Fill(this.DS.CTPX);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa chi tiết phiếu nhập!. Hãy thử lại\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);

                    this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTPXTableAdapter.Fill(this.DS.CTPX);
                    return;
                }
            }
        }

        private bool kiemTraDuLieuVT()
        {
            if (dgvCTPX.Rows[viTri].Cells["MAVT"].Value.ToString() == "")
            {
                MessageBox.Show("Vật tư không được để trống!", "Thông báo", MessageBoxButtons.OK);
                dgvCTPX.CurrentCell = dgvCTPX.Rows[viTri].Cells[1];
                dgvCTPX.Focus();
                return false;
            }

            // Kiểm tra xem giá trị có trong bất kỳ hàng nào khác không (trừ hàng hiện tại)
            foreach (DataGridViewRow row in dgvCTPX.Rows)
            {
                if (row.Index != viTri) // Đảm bảo không so sánh với chính nó
                {
                    if (row.Cells["MAVT"].Value.ToString().Equals(dgvCTPX.Rows[viTri].Cells["MAVT"].Value.ToString()))
                    {
                        // Nếu tìm thấy giá trị giống nhau, hủy thay đổi và thông báo
                        MessageBox.Show("Đã tồn tại tên vật tư trong chi tiết phiếu nhập này rồi!", "Thông báo", MessageBoxButtons.OK);
                        dgvCTPX.CurrentCell = dgvCTPX.Rows[viTri].Cells[1];
                        dgvCTPX.Focus();
                        return false;
                    }
                }
            }

            if (dgvCTPX.Rows[viTri].Cells["SOLUONG"].Value.ToString() == "")
            {
                MessageBox.Show("Số lượng không được để trống!", "Thông báo", MessageBoxButtons.OK);
                dgvCTPX.CurrentCell = dgvCTPX.Rows[viTri].Cells[2];
                dgvCTPX.Focus();
                return false;
            }
            if (int.Parse(dgvCTPX.Rows[viTri].Cells["SOLUONG"].Value.ToString()) <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK);
                dgvCTPX.CurrentCell = dgvCTPX.Rows[viTri].Cells[2];
                dgvCTPX.Focus();
                return false;
            }

            if (dgvCTPX.Rows[viTri].Cells["DONGIA"].Value.ToString() == "")
            {
                MessageBox.Show("Đơn giá không được để trống!", "Thông báo", MessageBoxButtons.OK);
                dgvCTPX.CurrentCell = dgvCTPX.Rows[viTri].Cells[3];
                dgvCTPX.Focus();
                return false;
            }
            if (float.Parse(dgvCTPX.Rows[viTri].Cells["DONGIA"].Value.ToString()) < 0)
            {
                MessageBox.Show("Đơn giá không được nhỏ hơn 0!", "Thông báo", MessageBoxButtons.OK);
                dgvCTPX.CurrentCell = dgvCTPX.Rows[viTri].Cells[3];
                dgvCTPX.Focus();
                return false;
            }

            return true;
        }

        private void btnGhiVT_Click(object sender, EventArgs e)
        {
            if (dgvCTPX.CurrentRow.Index < 0)
                return;

            if (!dgvCTPX.EndEdit())
            {
                return;
            }
      
            dgvCTPX.CurrentCell = dgvCTPX.CurrentRow.Cells[0];
            dgvCTPX.Focus();

            if (kiemTraDuLieuVT() == false)
            {
                return;
            }

            if (dangThemMoi == true)
            {
                if (int.Parse(dgvCTPX.CurrentRow.Cells["SOLUONG"].Value.ToString()) > kiemTraSLVTTrongVattu(dgvCTPX.CurrentRow.Cells["MAVT"].Value.ToString()))
                {
                    MessageBox.Show("Số lượng tồn trong kho hiện đang thấp hơn số lượng cần xuất!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                try
                {
                    capNhatSoLuongVatTu("XUAT", dgvCTPX.CurrentRow.Cells["MAVT"].Value.ToString(), int.Parse(dgvCTPX.CurrentRow.Cells["SOLUONG"].Value.ToString()));
                    this.bdsCTPX.EndEdit();
                    this.CTPXTableAdapter.Update(this.DS.CTPX);
                    this.CTPXTableAdapter.Fill(this.DS.CTPX);
                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    dangThemMoi = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    bdsCTPX.RemoveCurrent();
                    MessageBox.Show("Ghi thất bại!\n\n" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                capNhatSoLuongVatTu("NHAP", rowData["MAVT"].ToString(), int.Parse(rowData["SOLUONG"].ToString()));
                if (int.Parse(dgvCTPX.CurrentRow.Cells["SOLUONG"].Value.ToString()) > kiemTraSLVTTrongVattu(rowData["MAVT"].ToString()))
                {
                    MessageBox.Show("Số lượng tồn trong kho hiện đang thấp hơn số lượng vật tư trước khi thay đổi!", "Thông báo", MessageBoxButtons.OK);
                    capNhatSoLuongVatTu("XUAT", rowData["MAVT"].ToString(), int.Parse(rowData["SOLUONG"].ToString()));
                    return;
                }

                try
                {
                    capNhatSoLuongVatTu("XUAT", dgvCTPX.CurrentRow.Cells["MAVT"].Value.ToString(), int.Parse(dgvCTPX.CurrentRow.Cells["SOLUONG"].Value.ToString()));
                    this.bdsCTPX.EndEdit();
                    this.CTPXTableAdapter.Update(this.DS.CTPX);
                    this.CTPXTableAdapter.Fill(this.DS.CTPX);
                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Ghi thất bại!\n\n" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            foreach (DataGridViewRow row in dgvCTPX.Rows)
                row.ReadOnly = true;

            btnThemVT.Enabled = true;
            btnSuaVT.Enabled = true;
            btnXoaVT.Enabled = true;
            btnGhiVT.Enabled = false;
        }

        private void dgvCTPX_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            if (dgvCTPX.Columns[e.ColumnIndex].Name == "SOLUONG")
            {
                    e.Cancel = true;
                    MessageBox.Show("Số lượng chỉ có thể là số", "Thông báo", MessageBoxButtons.OK);
            }

            if (dgvCTPX.Columns[e.ColumnIndex].Name == "DONGIA")
            {
                    e.Cancel = true;
                    MessageBox.Show("Đơn giá chỉ có thể là số", "Thông báo", MessageBoxButtons.OK);
            }

        }
    }
}
