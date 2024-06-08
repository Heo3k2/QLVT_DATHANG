using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections;

namespace QLVT_DATHANG
{
    public partial class FormNhanVien : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        bool dangHieuChinh = false;
        String maCN;

        //Lưu các câu lệnh để hoàn tác
        Stack undoList = new Stack();
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            //Không kiểm tra các khóa ngoại
            DS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NhanVienTableAdapter.Fill(this.DS.NhanVien);

            // TODO: This line of code loads data into the 'DS.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            // TODO: This line of code loads data into the 'DS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

            // TODO: This line of code loads data into the 'DS.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);

            //Vẫn còn lỗi chưa sửa được
            maCN = ((DataRowView)bdsNhanVien[0])["MACN"].ToString();

            cmbChiNhanh.DataSource = Program.bindingSource; //sao chép bindingSource từ form đăng nhập
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;

            if(Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                barButtonItemThem.Enabled = false;
                barButtonItemHieuChinh.Enabled = false;
                barButtonItemGhi.Enabled = false;
                barButtonItemXoa.Enabled = false;
                barButtonItemPhucHoi.Enabled = false;
                barButtonItemChuyenChiNhanh.Enabled = false;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
                barButtonItemThem.Enabled = true;
                barButtonItemHieuChinh.Enabled = true;
                barButtonItemGhi.Enabled = true;
                barButtonItemXoa.Enabled = true;
                barButtonItemPhucHoi.Enabled = true;
                barButtonItemChuyenChiNhanh.Enabled = true;
            }
        }

        private void barButtonItemThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsNhanVien.Position;
            dangThemMoi = true;
            this.panelNhapLieu.Enabled = true;
            txtMaNV.Enabled = true;

            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsNhanVien.AddNew();
            txtMaCN.Text = maCN;
            dteNgaySinh.EditValue = "";
            chbTrangThaiXoa.Checked = false;

            gcNV.Enabled = false;
            barButtonItemThem.Enabled = barButtonItemHieuChinh.Enabled = barButtonItemXoa.Enabled = barButtonItemReload.Enabled = barButtonItemChuyenChiNhanh.Enabled = barButtonItemThoat.Enabled = false;
            barButtonItemGhi.Enabled = barButtonItemPhucHoi.Enabled = true;
        }

        private void barButtonItemHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangHieuChinh = true;
            viTri = bdsNhanVien.Position;
            panelNhapLieu.Enabled = true;
            txtMaNV.Enabled = false;

            barButtonItemThem.Enabled = barButtonItemHieuChinh.Enabled = barButtonItemXoa.Enabled = barButtonItemReload.Enabled = barButtonItemChuyenChiNhanh.Enabled = barButtonItemThoat.Enabled = false;
            barButtonItemGhi.Enabled = barButtonItemPhucHoi.Enabled = true;
            gcNV.Enabled = false;

        }

        private void barButtonItemReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.NhanVienTableAdapter.Fill(this.DS.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, " ", MessageBoxButtons.OK);
                return;
            }
        }

        private void barButtonItemThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }

        private Boolean kiemTraNhapLieu()
        {
            //Kiểm tra mã nhân viên
            if(txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return false;
            }    
            if(Regex.IsMatch(txtMaNV.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Mã nhân viên chỉ có thể là số", "Thông báo", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return false;
            }

            //Kiểm tra họ
            if (txtHo.Text == "")
            {
                MessageBox.Show("Không bỏ trống họ và tên", "Thông báo", MessageBoxButtons.OK);
                txtHo.Focus();
                return false;
            }
            if (Regex.IsMatch(txtHo.Text, @"^[a-zA-ZÀ-ỹ\s]+$") == false)
            {
                MessageBox.Show("Họ của người chỉ có chữ và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtHo.Focus();
                return false;
            }
            if (txtHo.Text.Length > 40)
            {
                MessageBox.Show("Họ không thể lớn hơn 40 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtHo.Focus();
                return false;
            }

            //Kiểm tra tên
            if (txtTen.Text == "")
            {
                MessageBox.Show("Không bỏ trống họ và tên", "Thông báo", MessageBoxButtons.OK);
                txtTen.Focus();
                return false;
            }
            if (Regex.IsMatch(txtTen.Text, @"^[a-zA-ZÀ-ỹ\s]+$") == false)
            {
                MessageBox.Show("Tên người chỉ có chữ và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtTen.Focus();
                return false;
            }
            if (txtTen.Text.Length > 10)
            {
                MessageBox.Show("Tên không thể lớn hơn 10 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTen.Focus();
                return false;
            }

            //Kiểm tra địa chỉ
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Không bỏ trống địa chỉ", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }
            /*if (Regex.IsMatch(txtDiaChi.Text, @"^[a-z0-9A-ZÀ-ỹ\s]+$") == false)
            {
                MessageBox.Show("Địa chỉ chỉ chấp nhận chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }*/
            if (txtDiaChi.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ không vượt quá 100 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }

            //Kiểm tra ngày sinh
            if (CalculateAge(dteNgaySinh.DateTime) < 18 && CalculateAge(dteNgaySinh.DateTime) >= 0)
            {
                MessageBox.Show("Nhân viên chưa đủ 18 tuổi", "Thông báo", MessageBoxButtons.OK);
                dteNgaySinh.Focus();
                return false;
            }
            if (CalculateAge(dteNgaySinh.DateTime) < 0)
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                dteNgaySinh.Focus();
                return false;
            }
            if (dteNgaySinh.EditValue == null || dteNgaySinh.DateTime == DateTime.MinValue)
            {
                MessageBox.Show("Ngày sinh không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                dteNgaySinh.Focus();
                return false;
            }

            //Kiểm tra số CMND
            if (txtSoCMND.Text == "")
            {
                MessageBox.Show("Chứng minh nhân dân không thể bỏ trống", "Thông báo", MessageBoxButtons.OK);
                txtSoCMND.Focus();
                return false;
            }    
            if(Regex.IsMatch(txtSoCMND.Text, @"^\d{10}$") == false)
            {
                MessageBox.Show("Chứng minh nhân dân chỉ có thể là 10 số", "Thông báo", MessageBoxButtons.OK);
                txtSoCMND.Focus();
                return false;
            }

            //Kiểm tra lương
            if (txtLuong.Text == "")
            {
                MessageBox.Show("Mức lương không thể bỏ trống", "Thông báo", MessageBoxButtons.OK);
                txtLuong.Focus();
                return false;
            }

            int luong = int.Parse(txtLuong.Text.Replace(".", ""));
            if (luong < 4000000)
            {
                MessageBox.Show("Mức lương phải lớn hơn hoặc bằng 4.000.000", "Thông báo", MessageBoxButtons.OK);
                txtLuong.Focus();
                return false;
            }


            return true;
        }

        private void barButtonItemGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsNhanVien.Position;

            if (kiemTraNhapLieu() == false)
            {
                return;
            }             

            String maNhanVien = txtMaNV.Text.Trim();
            String hoMoi = txtHo.Text.Trim();
            String tenMoi = txtTen.Text.Trim();
            String cmndMoi = txtSoCMND.Text.Trim();
            String diaChiMoi = txtDiaChi.Text.Trim();
            DateTime ngaySinhMoi = dteNgaySinh.DateTime;
            String luongMoi = txtLuong.Text.Trim();
            String macnMoi = txtMaCN.Text.Trim();
            bool trangThaiMoi = (bool)chbTrangThaiXoa.Checked;

            String cauTruyVanHoanTac;
            if(!dangThemMoi)
            {
                this.NhanVienTableAdapter.Fill(this.DS.NhanVien);
                bdsNhanVien.Position = viTri;
                DataRowView drv = ((DataRowView)bdsNhanVien[viTri]);
                String ho = drv["HO"].ToString().Trim();
                String ten = drv["TEN"].ToString().Trim();
                String cmnd = drv["SOCMND"].ToString().Trim();
                String diaChi = drv["DIACHI"].ToString().Trim();
                DateTime ngaySinh = ((DateTime)drv["NGAYSINH"]);
                String luong = drv["LUONG"].ToString().Trim();
                String macn = drv["MACN"].ToString().Trim();
                int trangThai = (bool)drv["TrangThaiXoa"] ? 1 : 0;

                cauTruyVanHoanTac = "UPDATE DBO.NHANVIEN " +
                                            "SET " +
                                            "HO = N'" + ho + "', " +
                                            "TEN = N'" + ten + "', " +
                                            "SOCMND = '" + cmnd + "', " +
                                            "DIACHI = N'" + diaChi + "', " +
                                            "NGAYSINH = '" + ngaySinh.ToString("yyyy-MM-dd") + "', " +
                                            "LUONG = '" + luong + "', " +
                                            "MACN = '" + macn + "', " +
                                            "TrangThaiXoa = " + trangThai + " " +
                                            "WHERE MANV = " + maNhanVien + " ";
            }   
            else
            {
                cauTruyVanHoanTac = "" +
                            "DELETE DBO.NHANVIEN " +
                            "WHERE MANV = " + txtMaNV.Text.Trim();
            }    

            String cauTruyVan = 
                                "DECLARE	@result int " +
                                "EXEC @result = [dbo].[sp_TraCuu_KiemTraMaNhanVienVaCMND] '" +
                                maNhanVien + "', '" + cmndMoi + "' " +
                                "SELECT 'Value' = @result";

            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);

            try 
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);

                //Trường hợp kết quả là null
                if(Program.myReader == null)
                {
                    return;
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }

            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();

            int viTriConTro = bdsNhanVien.Position;
            int viTriMaNV = bdsNhanVien.Find("MANV", txtMaNV.Text);
            int viTriCMNDNV = bdsNhanVien.Find("SOCMND", cmndMoi);

            if(result == 1 && viTriConTro != viTriMaNV)
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return;
            }
            else if(result == 2 && viTriConTro != viTriCMNDNV) //Bắt lỗi cmnd khi thêm
            {
                MessageBox.Show("CMND này đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                txtSoCMND.Focus();
                return;
            }
            else if (result == 2 && viTriMaNV != viTriCMNDNV) //Bắt lỗi cmnd khi sửa
            {
                MessageBox.Show("CMND này đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                txtSoCMND.Focus();
                return;
            }
            else
            {
                try
                {
                    if(!dangThemMoi)
                    {
                        txtHo.Text = hoMoi;
                        txtTen.Text = tenMoi;
                        txtSoCMND.Text = cmndMoi;
                        txtDiaChi.Text = diaChiMoi;
                        dteNgaySinh.DateTime = ngaySinhMoi;
                        txtLuong.Text = luongMoi;
                        txtMaCN.Text = macnMoi;
                        chbTrangThaiXoa.Checked = trangThaiMoi;
                    }    
                    this.bdsNhanVien.EndEdit();
                    this.NhanVienTableAdapter.Update(this.DS.NhanVien);

                    barButtonItemThem.Enabled = true;
                    barButtonItemHieuChinh.Enabled = true;
                    barButtonItemGhi.Enabled = true;
                    barButtonItemXoa.Enabled = true;
                    barButtonItemPhucHoi.Enabled = true;
                    barButtonItemReload.Enabled = true;
                    barButtonItemThoat.Enabled = true;
                    barButtonItemChuyenChiNhanh.Enabled = true;

                    gcNV.Enabled = true;
                    txtMaNV.Enabled = false;

                    Console.WriteLine(cauTruyVanHoanTac);
                    undoList.Push(cauTruyVanHoanTac);

                    dangThemMoi = false;
                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch(Exception ex)
                {
                    undoList.Pop();
                    bdsNhanVien.RemoveCurrent();
                    MessageBox.Show("Ghi thất bại! Vui lòng kiểm tra lại\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void barButtonItemXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int maNhanVien = int.Parse(((DataRowView)bdsNhanVien[bdsNhanVien.Position])["MANV"].ToString());
            if (bdsDatHang.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập đơn đặt hàng!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsPhieuNhap.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu nhập!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsPhieuXuat.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu xuất!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            
            //------------------------------Lệnh để hoàn tác cho xóa---------------------------------------------------------------------------------------------
            DateTime NGAYSINH = (DateTime)((DataRowView)bdsNhanVien[bdsNhanVien.Position])["NGAYSINH"];
            int trangThaiXoa = (chbTrangThaiXoa.Checked == true) ? 1 : 0;
            String cauTruyVanHoanTac = String.Format("INSERT INTO DBO.NHANVIEN(MANV, HO, TEN, SOCMND, DIACHI, NGAYSINH, LUONG, MACN, TrangThaiXoa)" +
                                               "VALUES({0}, N'{1}', N'{2}', '{3}', N'{4}', CAST('{5}' AS DATETIME), {6}, '{7}', {8})", 
                                               txtMaNV.Text, txtHo.Text, txtTen.Text, txtSoCMND.Text, txtDiaChi.Text, NGAYSINH.ToString("yyyy-MM-dd"), int.Parse(txtLuong.Text.Replace(".", "")), txtMaCN.Text.Trim(), trangThaiXoa);
            Console.WriteLine(cauTruyVanHoanTac);
            undoList.Push(cauTruyVanHoanTac);
            //---------------------------------------------------------------------------------------------------------------------------------------------------

            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsNhanVien.RemoveCurrent();
                    this.NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;                   
                    this.NhanVienTableAdapter.Update(this.DS.NhanVien);
                    barButtonItemPhucHoi.Enabled = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên! Vui lòng thử lại.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    this.NhanVienTableAdapter.Fill(this.DS.NhanVien);
                    bdsNhanVien.Position = bdsNhanVien.Find("MANV", maNhanVien);
                    return;
                }
            } 

            if(bdsNhanVien.Count == 0)
            {
                barButtonItemXoa.Enabled = false;
            }    
                
        }

        private void barButtonItemPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (dangThemMoi == true && barButtonItemThem.Enabled == false)
            {
                dangThemMoi = false;

                bdsNhanVien.EndEdit();
                bdsNhanVien.RemoveCurrent();
                bdsNhanVien.Position = viTri;

                cmbChiNhanh.Enabled = false;
                barButtonItemThem.Enabled = true;
                barButtonItemHieuChinh.Enabled = true;
                barButtonItemGhi.Enabled = false;
                barButtonItemXoa.Enabled = true;
                barButtonItemReload.Enabled = true;
                barButtonItemThoat.Enabled = true;


                gcNV.Enabled = true;
                panelNhapLieu.Enabled = false;

                if (undoList.Count == 0)
                {
                    barButtonItemPhucHoi.Enabled = false;
                }
                return;
            }    

            if(dangHieuChinh == true && barButtonItemHieuChinh.Enabled == false)
            {
                dangHieuChinh = false;

                bdsNhanVien.CancelEdit();
                bdsNhanVien.Position = viTri;
               
                cmbChiNhanh.Enabled = false;
                barButtonItemThem.Enabled = true;
                barButtonItemHieuChinh.Enabled = true;
                barButtonItemGhi.Enabled = false;
                barButtonItemXoa.Enabled = true;
                barButtonItemReload.Enabled = true;
                barButtonItemThoat.Enabled = true;

                gcNV.Enabled = true;
                panelNhapLieu.Enabled = false;

                if (undoList.Count == 0)
                {
                    barButtonItemPhucHoi.Enabled = false;
                }

                this.NhanVienTableAdapter.Fill(this.DS.NhanVien);
                return;
            }    

            bdsNhanVien.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();

            if (cauTruyVanHoanTac.Contains("sp_chuyenChiNhanh"))
            {
                try
                {
                    string chiNhanhHienTai = Program.serverName;
                    string chiNhanhMoi = Program.serverNameLeft;

                    Program.serverName = chiNhanhMoi;
                    Program.loginName = Program.remoteLogin;
                    Program.loginPassword = Program.remotePassword;

                    Console.WriteLine(Program.serverName + " " + Program.loginName + " " + Program.loginPassword);

                    if (Program.KetNoi() == 0)
                    {
                        return;
                    }

                    Console.WriteLine(cauTruyVanHoanTac);
                    int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);

                    MessageBox.Show("Phục hồi chuyển chi nhánh thành công", "Thông báo", MessageBoxButtons.OK);

                    Program.serverName = chiNhanhHienTai;
                    Program.loginName = Program.currentLogin;
                    Program.loginPassword = Program.currentPassword;

                    if (Program.KetNoi() == 0)
                    {
                        return;
                    }

                    Console.WriteLine(Program.serverName + " " + Program.loginName + " " + Program.loginPassword);

                    this.NhanVienTableAdapter.Fill(this.DS.NhanVien);
                    if (undoList.Count == 0)
                    {
                        barButtonItemPhucHoi.Enabled = false;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Phục hồi chuyển chi nhánh thất bại!\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Câu truy vấn: " + cauTruyVanHoanTac);
                    return;
                }
                  
            }
            else
            {
                if (Program.KetNoi() == 0)
                {
                    return;
                }
                int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);
                this.NhanVienTableAdapter.Fill(this.DS.NhanVien);
                if (undoList.Count == 0)
                {
                    barButtonItemPhucHoi.Enabled = false;
                }
            }

            if (undoList.Count == 0)
            {
                barButtonItemPhucHoi.Enabled = false;
                return;
            }
        }

        private void chuyenChiNhanh(string maChiNhanhHienTai, string soCMND)
        {
            string maChiNhanhMoi;
            if(maChiNhanhHienTai.Equals("CN1"))
            {
                maChiNhanhMoi = "CN2";
                Program.serverName = "MSI\\SERVER1";
                Program.serverNameLeft = "MSI\\SERVER2";
            }    
            else
            {
                maChiNhanhMoi = "CN1";
                Program.serverName = "MSI\\SERVER2";
                Program.serverNameLeft = "MSI\\SERVER1";
            }

            string cauTruyVanHoanTac = "EXEC sp_chuyenChiNhanh '" + soCMND + "', '" + maChiNhanhHienTai + "'";
            undoList.Push(cauTruyVanHoanTac);
            Console.WriteLine(cauTruyVanHoanTac);
            string cauTruyVan = "EXEC sp_chuyenChiNhanh '" + soCMND + "', '" + maChiNhanhMoi + "'";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);

            Console.WriteLine("Câu truy vấn: " + cauTruyVan);
            Console.WriteLine("Câu truy vấn hoàn tác: " + cauTruyVanHoanTac);
            Console.WriteLine("Server hiện tại: " + Program.serverName + ", Server mới: " + Program.serverNameLeft);

            try
            {
                SqlDataReader reader = Program.ExecSqlDataReader(cauTruyVan);
               
                if(reader == null)
                {
                    return;
                }

                reader.Read();
                MessageBox.Show("Chuyển chi nhánh thành công", "Thông báo", MessageBoxButtons.OK);
                barButtonItemPhucHoi.Enabled = true;
                this.NhanVienTableAdapter.Update(this.DS.NhanVien);
                this.NhanVienTableAdapter.Fill(this.DS.NhanVien);
                reader.Close();
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }       
        }

        private void barButtonItemChuyenChiNhanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int viTriHienTai = bdsNhanVien.Position;
            int trangThai = 0;
            if(((DataRowView)(bdsNhanVien[viTriHienTai]))["TrangThaiXoa"].ToString().Equals("True"))
            {
                trangThai = 1;
            }    
            string maNhanVien = ((DataRowView)(bdsNhanVien[viTriHienTai]))["MANV"].ToString().Trim();
            string soCMND = ((DataRowView)(bdsNhanVien[viTriHienTai]))["SOCMND"].ToString().Trim();
            string maChiNhanhHienTai = ((DataRowView)(bdsNhanVien[viTriHienTai]))["MACN"].ToString().Trim();
            Console.WriteLine(maNhanVien + " " + soCMND + " " + maChiNhanhHienTai);
            if (maNhanVien == Program.userName)
            {
                MessageBox.Show("Không thể chuyển chi nhánh người đang đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (trangThai == 1)
            {
                MessageBox.Show("Nhân viên này hiện không ở chi nhánh này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn chuyển chi nhánh nhân viên này không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.OK)
            {
                chuyenChiNhanh(maChiNhanhHienTai, soCMND);
            }    
            else
            {
                return;
            }    
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }

            Program.serverName = cmbChiNhanh.SelectedValue.ToString();

            if(cmbChiNhanh.SelectedIndex != Program.brand)
            {
                Program.loginName = Program.remoteLogin;
                Program.loginPassword = Program.remotePassword;
            }
            else
            {
                Program.loginName = Program.currentLogin;
                Program.loginPassword = Program.currentPassword;
            }

            if(Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nói chi nhánh mới", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
                this.NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NhanVienTableAdapter.Fill(this.DS.NhanVien);

                // TODO: This line of code loads data into the 'DS.DatHang' table. You can move, or remove it, as needed.
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.DS.DatHang);

                // TODO: This line of code loads data into the 'DS.PhieuNhap' table. You can move, or remove it, as needed.
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

                // TODO: This line of code loads data into the 'DS.PhieuXuat' table. You can move, or remove it, as needed.
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
            }    
        }
    }
}
