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
using System.Text.RegularExpressions;

namespace QLVT_DATHANG
{
    public partial class FormVatTu : Form
    {
        public FormVatTu()
        {
            InitializeComponent();
        }

        int viTri = 0;
        bool dangThemMoi = false;

        Stack undoList = new Stack();

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormVatTu_Load(object sender, EventArgs e)
        {
            // Không kiểm tra khóa ngoại nữa
            DS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.Vattu' table. You can move, or remove it, as needed.
            this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.VatTuTableAdapter.Fill(this.DS.Vattu);

            // TODO: This line of code loads data into the 'DS.CTDDH' table. You can move, or remove it, as needed.
            this.ctddhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ctddhTableAdapter.Fill(this.DS.CTDDH);

            // TODO: This line of code loads data into the 'DS.CTPN' table. You can move, or remove it, as needed.
            this.ctpnTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ctpnTableAdapter.Fill(this.DS.CTPN);

            // TODO: This line of code loads data into the 'DS.CTPX' table. You can move, or remove it, as needed.
            this.ctpxTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ctpxTableAdapter.Fill(this.DS.CTPX);

            if (Program.role == "CONGTY")
            {
                barButtonItemThem.Enabled = false;
                barButtonItemXoa.Enabled = false;
                barButtonItemGhi.Enabled = false;
                barButtonItemUndo.Enabled = false;
            }    
        }

        private void barButtonItemThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItemReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.VatTuTableAdapter.Fill(this.DS.Vattu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "Error", MessageBoxButtons.OK);
                return;
            }
        }

        private void barButtonItemThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsVatTu.Position;
            dangThemMoi = true;
            this.panelNhapLieu.Enabled = true;
            txtMaVT.Enabled = true;

            bdsVatTu.AddNew();
            txtSoLuongTon.Value = 0;

            gcVatTu.Enabled = false;

            barButtonItemThem.Enabled = barButtonItemXoa.Enabled = barButtonItemReload.Enabled = barButtonItemThoat.Enabled = false;
            barButtonItemGhi.Enabled = barButtonItemUndo.Enabled = true;
        }

        private bool kiemTraNhapLieu()
        {
            /*Kiểm tra mã vật tư*/
            if (txtMaVT.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã vật tư", "Thông báo", MessageBoxButtons.OK);
                txtMaVT.Focus();
                return false;
            }

            if (Regex.IsMatch(txtMaVT.Text.Trim(), @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã vật tư chỉ có chữ cái và số", "Thông báo", MessageBoxButtons.OK);
                txtMaVT.Focus();
                return false;
            }

            if (txtMaVT.Text.Length > 4)
            {
                MessageBox.Show("Mã vật tư không quá 4 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMaVT.Focus();
                return false;
            }

            /*Kiểm tra tên vật tư*/
            if (txtTenVT.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên vật tư", "Thông báo", MessageBoxButtons.OK);
                txtTenVT.Focus();
                return false;
            }

            if (Regex.IsMatch(txtTenVT.Text.Trim(), @"^[a-zA-ZÀ-ỹ0-9\s]+$") == false)
            {
                MessageBox.Show("Tên vật tư chỉ chấp nhận chữ, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtTenVT.Focus();
                return false;
            }

            if (txtTenVT.Text.Length > 30)
            {
                MessageBox.Show("Tên vật tư không quá 30 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTenVT.Focus();
                return false;
            }
            /*Kiểm tra đơn vị tính*/
            if (txtDVT.Text == "")
            {
                MessageBox.Show("Không bỏ trống đơn vị tính", "Thông báo", MessageBoxButtons.OK);
                txtDVT.Focus();
                return false;
            }

            if (Regex.IsMatch(txtDVT.Text.Trim(), @"^[a-zA-ZÀ-ỹ]+$") == false)
            {
                MessageBox.Show("Đơn vị tính vật tư chỉ có chữ cái", "Thông báo", MessageBoxButtons.OK);
                txtDVT.Focus();
                return false;
            }

            if (txtDVT.Text.Length > 15)
            {
                MessageBox.Show("Đơn vị tính vật tự không quá 15 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtDVT.Focus();
                return false;
            }

            /*Kiểm tra số lượng tồn*/
            if (txtSoLuongTon.Value < 0)
            {
                MessageBox.Show("Sô lượng tồn phải ít nhất bằng 0", "Thông báo", MessageBoxButtons.OK);
                txtSoLuongTon.Focus();
                return false;
            }

            return true;
        }

        private void barButtonItemGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsVatTu.Position;

            if (kiemTraNhapLieu() == false)
            {
                return;
            }

            String maVatTu = txtMaVT.Text.Trim();

            String tenVatTuMoi = txtTenVT.Text.Trim();
            String donViTinhMoi = txtDVT.Text.Trim();
            String soLuongTonMoi = txtSoLuongTon.Value.ToString();
            
            if(dangThemMoi != true)
            {
                this.VatTuTableAdapter.Fill(this.DS.Vattu);
                bdsVatTu.Position = viTri;
            }    

            DataRowView drv = ((DataRowView)bdsVatTu[bdsVatTu.Position]);
            String tenVatTu = drv["TENVT"].ToString();
            String donViTinh = drv["DVT"].ToString();
            String soLuongTon = drv["SOLUONGTON"].ToString();

            String cauTruyVan = "DECLARE @result nvarchar(2) " +
                                "EXEC @result = sp_kiemTraMaVatTuVaTenVatTu '" +
                                maVatTu + "', N'" + tenVatTuMoi + "' " +
                                "SELECT 'Value' = @result";

            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                if(Program.myReader == null)
                {
                    return;
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                Console.WriteLine(ex.Message);
                return;
            }

            Program.myReader.Read();
            String result = Program.myReader.GetValue(0).ToString();
            Program.myReader.Close();

            int viTriConTro = bdsVatTu.Position;
            int viTriMaVatTu = bdsVatTu.Find("MAVT", maVatTu);
            int viTriTenVatTu = bdsVatTu.Find("TENVT", tenVatTuMoi);

            if(result.Contains("1") && viTriConTro != viTriMaVatTu)
            {
                MessageBox.Show("Mã vật tư đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                txtMaVT.Focus();
                return;
            }    
            else if(result.Contains("2") && viTriConTro != viTriTenVatTu) //Bắt lỗi trùng tên vật tư khi thêm mới
            {
                MessageBox.Show("Tên vật tư đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                txtTenVT.Focus();
                return;
            }
            else if (result.Contains("2") && viTriMaVatTu != viTriTenVatTu) //Bắt lỗi trùng tên vật tư khi chỉnh sửa
            {
                MessageBox.Show("Tên vật tư đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                txtTenVT.Focus();
                return;
            }
            else
            {
                try
                {
                    barButtonItemThem.Enabled = barButtonItemXoa.Enabled = barButtonItemReload.Enabled = barButtonItemThoat.Enabled = true;
                    barButtonItemGhi.Enabled = barButtonItemUndo.Enabled = true;

                    this.txtMaVT.Enabled = false;
                    this.gcVatTu.Enabled = true;

                    String cauTruyVanHoanTac;
                    if (dangThemMoi == true)
                    {
                        cauTruyVanHoanTac = "DELETE DBO.Vattu " +
                                            "WHERE MAVT = '" + maVatTu + "'";
                    }    
                    else
                    {
                        cauTruyVanHoanTac = "UPDATE DBO.Vattu " +
                                            "SET " +
                                            "TENVT = N'" + tenVatTu + "', " +
                                            "DVT = N'" + donViTinh + "', " +
                                            "SOLUONGTON = " + soLuongTon + " " +
                                            "WHERE MAVT = '" + maVatTu + "'";
                    }

                    undoList.Push(cauTruyVanHoanTac);
                    Console.WriteLine(cauTruyVanHoanTac);
 
                    if (dangThemMoi != true)
                    {
                        if (Program.KetNoi() == 0)
                        {
                            return;
                        }
                        String cauTruyVanUpdate = " ";
                        cauTruyVanUpdate = "UPDATE DBO.Vattu " +
                                           "SET " +
                                           "TENVT = N'" + tenVatTuMoi + "', " +
                                           "DVT = N'" + donViTinhMoi + "', " +
                                           "SOLUONGTON = " + soLuongTonMoi + " " +
                                           "WHERE MAVT = '" + maVatTu + "'";
                        Console.WriteLine(cauTruyVanUpdate);
                        int n = Program.ExecSqlNonQuery(cauTruyVanUpdate);
                    }
                    else
                    {
                        this.bdsVatTu.EndEdit();
                        this.VatTuTableAdapter.Update(this.DS.Vattu);
                    }

                    this.VatTuTableAdapter.Fill(this.DS.Vattu);
                    dangThemMoi = false;
                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    bdsVatTu.RemoveCurrent();
                    MessageBox.Show("Ghi thất bại!\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                    return;
                }
            }    
        }

        private void barButtonItemUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThemMoi == true && barButtonItemThem.Enabled == false)
            {
                barButtonItemThem.Enabled = barButtonItemXoa.Enabled = barButtonItemReload.Enabled = barButtonItemThoat.Enabled = true;

                this.txtMaVT.Enabled = false;
                this.gcVatTu.Enabled = true;

                bdsVatTu.CancelEdit();
                bdsVatTu.RemoveCurrent();
                bdsVatTu.Position = viTri;
                return;
            }  
            
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác để hoàn tác!", "Thông báo", MessageBoxButtons.OK);
                barButtonItemUndo.Enabled = false;
                return;
            }

            bdsVatTu.CancelEdit();

            if (Program.KetNoi() == 0)
            {
                return;
            }
            String cauTruyVanHoanTac = undoList.Pop().ToString();
            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);
            this.VatTuTableAdapter.Fill(this.DS.Vattu);
        }

        private Boolean KiemTraMaVatTuChiNhanhKhac(String maVatTu)
        {
            String cauTruyVan = "DECLARE @result int " +
                                "EXEC @result = sp_KiemTraMaVatTuChiNhanhKhac '" + maVatTu + "' " +
                                "SELECT 'Value' = @result";

            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                if(Program.myReader == null)
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return true;
            }

            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();

            if(result == 1)
                return true;   
            else
                return false;
        }

        private void barButtonItemXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsVatTu.Count == 0)
            {
                barButtonItemXoa.Enabled = false;
            }

            if (bdsCTDDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư này vì đã lập đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsCTPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư này vì đã lập phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsCTPX.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư này vì đã lập phiếu xuất", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            String maVatTu = txtMaVT.Text.Trim();
            if(KiemTraMaVatTuChiNhanhKhac(maVatTu))
            {
                MessageBox.Show("Vật tư đã được dùng ở chi nhánh khác! Không thể xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if(MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    String cauTruyVanHoanTac = "INSERT INTO DBO.Vattu(MAVT, TENVT, DVT, SOLUONGTON) " +
                                       "VALUES( '" + txtMaVT.Text.Trim() + "', N'" +
                                                     txtTenVT.Text.Trim() + "', N'" +
                                                     txtDVT.Text.Trim() + "', " +
                                                     txtSoLuongTon.Value + ") ";

                    Console.WriteLine(cauTruyVanHoanTac);
                    undoList.Push(cauTruyVanHoanTac);

                    viTri = bdsVatTu.Position;
                    bdsVatTu.RemoveCurrent();

                    this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.VatTuTableAdapter.Update(this.DS.Vattu);

                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Xóa vật tư thất bại!\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.VatTuTableAdapter.Fill(this.DS.Vattu);
                    bdsVatTu.Position = viTri;
                    return;
                }
            }    

        }
    }
}
