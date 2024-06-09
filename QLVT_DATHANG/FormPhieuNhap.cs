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
    public partial class FormPhieuNhap : Form
    {
        int viTri = 0;

        bool dangThemMoi = false;

        Stack undoList = new Stack();
        
        Dictionary<string, object> rowData = new Dictionary<string, object>();

        public FormPhieuNhap()
        {
            InitializeComponent();
        }

        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            
            /*không kiểm tra khóa ngoại nữa*/
            DS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
            this.PNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.PNTableAdapter.Fill(this.DS.PhieuNhap);

            // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
            this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPNTableAdapter.Fill(this.DS.CTPN);

            // TODO: This line of code loads data into the 'DS.DSNV' table. You can move, or remove it, as needed.
            this.DSNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DSNVTableAdapter.Fill(this.DS.DSNV);

            // TODO: This line of code loads data into the 'DS.Vattu' table. You can move, or remove it, as needed.
            this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.VatTuTableAdapter.Fill(this.DS.Vattu);

            //Combobox chọn chi nhánh
            cmbChiNhanh.DataSource = Program.bindingSource; //sao chép bindingSource từ form đăng nhập
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;

            //Phân quyền
            if(Program.role == "CONGTY")
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
                if(cmbHoTen.SelectedValue != null)
                    txtMaNV.Text = cmbHoTen.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!\n\n" + ex.Message, "Thông báo",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
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
                this.PNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PNTableAdapter.Fill(this.DS.PhieuNhap);

                // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
                this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTPNTableAdapter.Fill(this.DS.CTPN);

                // TODO: This line of code loads data into the 'DS.DSNV' table. You can move, or remove it, as needed.
                this.DSNVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DSNVTableAdapter.Fill(this.DS.DSNV);

                // TODO: This line of code loads data into the 'DS.Vattu' table. You can move, or remove it, as needed.
                //this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
                //this.VatTuTableAdapter.Fill(this.DS.Vattu);
            }    
        }

        private void barButtonItemReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.PNTableAdapter.Fill(this.DS.PhieuNhap);
                this.CTPNTableAdapter.Fill(this.DS.CTPN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới dữ liệu!\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
        }

        private void barButtonItemThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void barButtonItemThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsPN.Position;
            dangThemMoi = true;

            bdsPN.AddNew();

            btnChonDDH.Enabled = true;
            txtMaPN.Enabled = true;

            cmbHoTen.SelectedValue = Program.userName;
            txtMaNV.Text = Program.userName;

            DataRowView drv = ((DataRowView)bdsPN.Current);
            drv["NGAY"] = DateTime.Now;
            drv["MasoDDH"] = Program.maDonDatHangDuocChon;
            drv["MANV"] = Program.userName;
            drv["MAKHO"] = Program.maKhoDuocChon;

            Console.WriteLine("userName:" + Program.userName);
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnChiTietPN.Enabled= false;
            btnGhi.Enabled = btnUndo.Enabled = true;

            gcPN.Enabled = false;
            dgvCTPN.Enabled = false;
        }

        private void btnChonDDH_Click(object sender, EventArgs e)
        {
            FormChonDonDatHang form = new FormChonDonDatHang();
            form.ShowDialog();

            this.txtMaDDH.Text = Program.maDonDatHangDuocChon;
            this.txtMaKho.Text = Program.maKhoDuocChon;
        }

        private bool kiemTraDuLieu()
        {
            if (txtMaPN.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã phiếu nhập !", "Thông báo", MessageBoxButtons.OK);
                txtMaPN.Focus();
                return false;
            }


            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã nhân viên !", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtMaKho.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã kho !", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtMaDDH.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã đơn đặt hàng !", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kiemTraDuLieu() == false)
                return;

            string maPN = txtMaPN.Text.Trim();

            string cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_KiemTraMaPhieuNhap '" +
                    maPN + "' " +
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


            int viTriConTro = bdsPN.Position;
            int viTriMaPhieuNhap = bdsPN.Find("MAPN", maPN);

            if (result == 1 && viTriMaPhieuNhap != viTriConTro)
            {
                MessageBox.Show("Mã phiếu nhập đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                txtMaPN.Focus();
                return;
            }
            else
            {
                try
                {
                    string cauTruyVanHoanTac = "EXEC sp_TuDongThemCTPNvaSLVatTu '" + maPN + "', '" + Program.maDonDatHangDuocChon + "', 'UNDO'"; 

                    undoList.Push(cauTruyVanHoanTac);
                    Console.WriteLine("Câu truy vấn hoàn tác: " + cauTruyVanHoanTac);
                    this.bdsPN.EndEdit();
                    this.PNTableAdapter.Update(this.DS.PhieuNhap);

                    this.btnThem.Enabled = true;
                    this.btnXoa.Enabled = true;
                    this.btnGhi.Enabled = false;
                    this.btnUndo.Enabled = true;
                    this.btnReload.Enabled = true;
                    this.btnChiTietPN.Enabled = true;
                    this.btnThoat.Enabled = true;

                    this.txtMaPN.Enabled = false;
                    this.gcPN.Enabled = true;
                    this.dgvCTPN.Enabled = true;

                    string cauTruyVanCTPN = "EXEC sp_TuDongThemCTPNvaSLVatTu '" + maPN + "', '" + Program.maDonDatHangDuocChon + "', 'ADD'";
                    Console.WriteLine(cauTruyVanCTPN);
                    int n = Program.ExecSqlNonQuery(cauTruyVanCTPN);

                    dangThemMoi = false;
                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    this.PNTableAdapter.Fill(this.DS.PhieuNhap);
                    this.CTPNTableAdapter.Fill(this.DS.CTPN);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    bdsPN.RemoveCurrent();
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

                this.txtMaPN.Enabled = false;
                this.btnChonDDH.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnGhi.Enabled = false;
                this.btnUndo.Enabled = true;
                this.btnReload.Enabled = true;
                this.btnChiTietPN.Enabled = true;
                this.btnThoat.Enabled = true;

                this.gcPN.Enabled = true;
                this.dgvCTPN.Enabled = true;

                bdsPN.CancelEdit();
                bdsPN.RemoveCurrent();
                this.PNTableAdapter.Fill(this.DS.PhieuNhap);
                bdsPN.Position = viTri;

                return;
            }

            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnUndo.Enabled = false;
                return;
            }

            bdsPN.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();

            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);

            this.PNTableAdapter.Fill(this.DS.PhieuNhap);

            bdsPN.Position = viTri;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv = ((DataRowView)bdsPN[bdsPN.Position]);
            string maPN = drv["MANV"].ToString();

            if(Program.userName != maPN)
            {
                MessageBox.Show("Không thể xóa phiếu nhập của nhân viên khác!", "Thông báo", MessageBoxButtons.OK);
                return;
            }    

            if(bdsCTPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa phiếu nhập vì đã có chi tiết phiếu nhập!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if(MessageBox.Show("Bạn có chắc chắn muốn xóa không?","Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    viTri = bdsPN.Position;

                    //*******************Phục vụ cho Undo*****************
                    DateTime ngay = ((DateTime)drv["NGAY"]);

                    string cauTruyVanHoanTac = "INSERT INTO DBO.PHIEUNHAP(MAPN, NGAY, MasoDDH, MANV, MAKHO) " +
                            "VALUES( '" + drv["MAPN"].ToString().Trim() + "', '" +
                            ngay.ToString("yyyy-MM-dd") + "', '" +
                            drv["MasoDDH"].ToString() + "', '" +
                            drv["MANV"].ToString() + "', '" +
                            drv["MAKHO"].ToString() + "')";

                    undoList.Push(cauTruyVanHoanTac);
                    Console.WriteLine("Câu truy vấn hoàn tác: " + cauTruyVanHoanTac);
                    //****************************************************

                    bdsPN.RemoveCurrent();
                    this.PNTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.PNTableAdapter.Update(this.DS.PhieuNhap);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUndo.Enabled = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu nhập! Hãy thử lại!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.PNTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.PNTableAdapter.Fill(this.DS.PhieuNhap);

                    bdsPN.Position = viTri;

                    return;
                }
            }    
        }

        private bool kiemTraDuLieuVT()
        {
            if (dgvCTPN.Rows[viTri].Cells["MAVT"].Value.ToString() == "")
            {
                MessageBox.Show("Vật tư không được để trống!", "Thông báo", MessageBoxButtons.OK);
                dgvCTPN.CurrentCell = dgvCTPN.Rows[viTri].Cells[1];
                dgvCTPN.Focus();
                return false;
            }
            if (kiemTraSLVT(txtMaDDH.Text.Trim(), dgvCTPN.Rows[viTri].Cells["MAVT"].Value.ToString()) == 0)
            {
                MessageBox.Show("Vật tư không có trong chi tiết đơn đặt hàng!", "Thông báo", MessageBoxButtons.OK);
                dgvCTPN.CurrentCell = dgvCTPN.Rows[viTri].Cells[1];
                dgvCTPN.Focus();
                return false;
            }

            // Kiểm tra xem giá trị có trong bất kỳ hàng nào khác không (trừ hàng hiện tại)
            foreach (DataGridViewRow row in dgvCTPN.Rows)
            {
                if (row.Index != viTri) // Đảm bảo không so sánh với chính nó
                {
                    if (row.Cells["MAVT"].Value.ToString().Equals(dgvCTPN.Rows[viTri].Cells["MAVT"].Value.ToString()))
                    {
                        // Nếu tìm thấy giá trị giống nhau, hủy thay đổi và thông báo
                        MessageBox.Show("Đã tồn tại tên vật tư trong chi tiết phiếu nhập này rồi!", "Thông báo", MessageBoxButtons.OK);
                        dgvCTPN.CurrentCell = dgvCTPN.Rows[viTri].Cells[1];
                        dgvCTPN.Focus();
                        return false;
                    }
                }
            }

            if (dgvCTPN.Rows[viTri].Cells["SOLUONG"].Value.ToString() == "")
            {
                MessageBox.Show("Số lượng không được để trống!", "Thông báo", MessageBoxButtons.OK);
                dgvCTPN.CurrentCell = dgvCTPN.Rows[viTri].Cells[2];
                dgvCTPN.Focus();
                return false;
            }    
            if(int.Parse(dgvCTPN.Rows[viTri].Cells["SOLUONG"].Value.ToString()) <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK);
                dgvCTPN.CurrentCell = dgvCTPN.Rows[viTri].Cells[2];
                dgvCTPN.Focus();
                return false;
            }
            if(int.Parse(dgvCTPN.Rows[viTri].Cells["SOLUONG"].Value.ToString()) > kiemTraSLVT(txtMaDDH.Text.Trim(), dgvCTPN.Rows[viTri].Cells["MAVT"].Value.ToString()))
            {
                MessageBox.Show("Số lượng vật tư nhập vào không được lớn hơn số lượng đặt hàng!", "Thông báo", MessageBoxButtons.OK);
                dgvCTPN.CurrentCell = dgvCTPN.Rows[viTri].Cells[2];
                dgvCTPN.Focus();
                return false;
            }    

            if (dgvCTPN.Rows[viTri].Cells["DONGIA"].Value.ToString() == "")
            {
                MessageBox.Show("Đơn giá không được để trống!", "Thông báo", MessageBoxButtons.OK);
                dgvCTPN.CurrentCell = dgvCTPN.Rows[viTri].Cells[3];
                dgvCTPN.Focus();
                return false;
            }
            if (float.Parse(dgvCTPN.Rows[viTri].Cells["DONGIA"].Value.ToString()) < 0)
            {
                MessageBox.Show("Đơn giá không được nhỏ hơn 0!", "Thông báo", MessageBoxButtons.OK);
                dgvCTPN.CurrentCell = dgvCTPN.Rows[viTri].Cells[3];
                dgvCTPN.Focus();
                return false;
            }


            return true;
        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            String MaNV = ((DataRowView)bdsPN[bdsPN.Position])["MANV"].ToString();
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
            bdsCTPN.AddNew();

            // Đặt hàng mới là có thể chỉnh sửa
            dgvCTPN.CurrentRow.ReadOnly = false;
            viTri = dgvCTPN.CurrentRow.Index;
        }

        private void btnXoaVT_Click(object sender, EventArgs e)
        {
            if (dgvCTPN.CurrentRow.Index < 0)
                return;

            String MaNV = ((DataRowView)bdsPN[bdsPN.Position])["MANV"].ToString();
            if (Program.userName != MaNV)
            {
                MessageBox.Show("Không xóa chi tiết phiếu nhập trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (int.Parse(dgvCTPN.CurrentRow.Cells["SOLUONG"].Value.ToString()) > kiemTraSLVTTrongVattu(dgvCTPN.CurrentRow.Cells["MAVT"].Value.ToString()))
            {
                MessageBox.Show("Số lượng tồn trong kho hiện đang thấp hơn số lượng xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsCTPN.Position = viTri;
                    capNhatSoLuongVatTu("XUAT", dgvCTPN.CurrentRow.Cells["MAVT"].Value.ToString(), int.Parse(dgvCTPN.CurrentRow.Cells["SOLUONG"].Value.ToString()));
                    bdsCTPN.RemoveCurrent();
                    
                    this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTPNTableAdapter.Update(this.DS.CTPN);
                    this.CTPNTableAdapter.Fill(this.DS.CTPN);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa chi tiết phiếu nhập!. Hãy thử lại\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);

                    this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTPNTableAdapter.Fill(this.DS.CTPN);
                    return;
                }
            }    
        }

        private void btnGhiVT_Click(object sender, EventArgs e)
        {
            if (dgvCTPN.CurrentRow.Index < 0)
                return;

            if (!dgvCTPN.EndEdit())
            {
                return;
            }

            dgvCTPN.CurrentCell = dgvCTPN.CurrentRow.Cells[0];
            dgvCTPN.Focus();

            if (kiemTraDuLieuVT() == false)
            {
                return;
            }

            if (dangThemMoi == true)
            {
                try
                {
                    capNhatSoLuongVatTu("NHAP", dgvCTPN.CurrentRow.Cells["MAVT"].Value.ToString(), int.Parse(dgvCTPN.CurrentRow.Cells["SOLUONG"].Value.ToString()));
                    this.dgvCTPN.EndEdit();
                    this.CTPNTableAdapter.Update(this.DS.CTPN);
                    this.CTPNTableAdapter.Fill(this.DS.CTPN);
                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    dangThemMoi = false;
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    bdsCTPN.RemoveCurrent();
                    MessageBox.Show("Ghi thất bại!\n\n" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (int.Parse(rowData["SOLUONG"].ToString()) > kiemTraSLVTTrongVattu(rowData["MAVT"].ToString()))
                {
                    MessageBox.Show("Số lượng tồn trong kho hiện đang thấp hơn số lượng vật tư trước khi thay đổi!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                try
                {
                    capNhatSoLuongVatTu("XUAT", rowData["MAVT"].ToString(), int.Parse(rowData["SOLUONG"].ToString()));
                    capNhatSoLuongVatTu("NHAP", dgvCTPN.CurrentRow.Cells["MAVT"].Value.ToString(), int.Parse(dgvCTPN.CurrentRow.Cells["SOLUONG"].Value.ToString()));
                    
                    this.bdsCTPN.EndEdit();
                    this.CTPNTableAdapter.Update(this.DS.CTPN);
                    this.CTPNTableAdapter.Fill(this.DS.CTPN);

                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Ghi thất bại!\n\n" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            foreach (DataGridViewRow row in dgvCTPN.Rows)
                row.ReadOnly = true;

            btnThemVT.Enabled = true;
            btnSuaVT.Enabled = true;
            btnXoaVT.Enabled = true;
            btnGhiVT.Enabled = false;
        }

        private void btnChiTietPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dgvCTPN.Visible = !dgvCTPN.Visible;
            gcPN.Enabled = !dgvCTPN.Visible;

            undoList.Clear();

            btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnUndo.Enabled = btnReload.Enabled = btnThoat.Enabled = !dgvCTPN.Visible;

            btnThemVT.Enabled = btnSuaVT.Enabled = btnXoaVT.Enabled = true;
            btnGhiVT.Enabled = false;

            this.CTPNTableAdapter.Fill(this.DS.CTPN);

            foreach (DataGridViewRow row in dgvCTPN.Rows)
            {
                row.ReadOnly = true;
            }
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

        private void btnSuaVT_Click(object sender, EventArgs e)
        {
            if (dgvCTPN.CurrentRow.Index < 0)
                return;

            dgvCTPN.CurrentRow.ReadOnly = false;
            viTri = dgvCTPN.CurrentRow.Index;
            foreach (DataGridViewCell cell in dgvCTPN.CurrentRow.Cells)
            {
                rowData[cell.OwningColumn.Name] = cell.Value;
            }

            btnThemVT.Enabled = false;
            btnSuaVT.Enabled = false;
            btnXoaVT.Enabled = false;
            btnGhiVT.Enabled = true;
        }

        private void dgvCTPN_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            if (dgvCTPN.Columns[e.ColumnIndex].Name == "SOLUONG")
            {
                e.Cancel = true;
                MessageBox.Show("Số lượng chỉ có thể là số", "Thông báo", MessageBoxButtons.OK);
            }

            if (dgvCTPN.Columns[e.ColumnIndex].Name == "DONGIA")
            {
                e.Cancel = true;
                MessageBox.Show("Đơn giá chỉ có thể là số", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
