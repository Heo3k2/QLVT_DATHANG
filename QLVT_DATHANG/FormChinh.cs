using QLVT_DATHANG.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
    public partial class FormChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        /************************************************************
         * CheckExists:
         * Để tránh việc người dùng ấn vào 1 form đến 2 lần chúng ta 
         * cần sử dụng hàm này để kiểm tra xem cái form hiện tại đã 
         * có trong bộ nhớ chưa
         * Nếu có trả về "f"
         * Nếu không trả về "null"
         ************************************************************/
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        /************************************************************
         * Kiểm tra xem form đăng nhập đã có trong hệ thống chưa?
         * Step 1: Nếu có thì chạy form đăng nhập
         * Step 2: Nếu không thì khởi tạo một form đăng nhập mới rồi 
         * ném vào đưa vào xtraTabbedMdiManager
         * 
         * f.MdiParent = this; cái form này có form cha là this - tức form chính
         ************************************************************/
        private void barButtonItemDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDangNhap));
            if(f != null)
            {
                f.Activate();
            }    
            else
            {
                FormDangNhap form = new FormDangNhap();
                form.MdiParent = this;
                form.Show();
            }    
        }

        public void enableButtons()
        {

            barButtonItemDangNhap.Enabled = false;
            barButtonItemDangXuat.Enabled = true;

            ribbonPageNhapXuat.Visible = true;
            ribbonPageBaoCao.Visible = true;
            barButtonItemTaoTaiKhoan.Enabled = true;

            if (Program.role == "USER")
            {
                barButtonItemTaoTaiKhoan.Enabled = false;
            }

            //pageTaiKhoan.Visible = true;


        }

        private void barButtonItemNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormNhanVien));
            if(f != null)
            {
                f.Activate();
            }
            else
            {
                FormNhanVien form = new FormNhanVien();
                form.MdiParent = this;
                form.Show();
            } 
                
        }

        private void logout()
        {
            foreach(Form f in this.MdiChildren)
            {
                f.Dispose();
            }    
        }

        private void barButtonItemDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logout();

            barButtonItemDangNhap.Enabled = true;
            barButtonItemDangXuat.Enabled = false;
            ribbonPageNhapXuat.Visible = false;
            ribbonPageBaoCao.Visible = false;

            Form f = this.CheckExists(typeof(FormDangNhap));
            if(f != null)
            {
                f.Activate();
            }    
            else
            {
                FormDangNhap form = new FormDangNhap();
                form.MdiParent = this;
                form.Show();
            }    
        }

        private void barButtonItemVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormVatTu));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormVatTu form = new FormVatTu();
                form.MdiParent = this;
                form.Show();
            } 
                
        }

        private void barButtonItemPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormPhieuNhap));
            if(f != null)
            {
                f.Activate();
            }
            else
            {
                FormPhieuNhap form = new FormPhieuNhap();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormPhieuXuat));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormPhieuXuat form = new FormPhieuXuat();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItemKhoHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormKho));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormKho form = new FormKho();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItemDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDonDatHang));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDonDatHang form = new FormDonDatHang();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnInDanhSachNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(Frpt_DanhSachNhanVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                Frpt_DanhSachNhanVien form = new Frpt_DanhSachNhanVien();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barInChiTietNhapXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(Frpt_ChiTietSoLuongTriGiaHangNhapHoacXuat));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                Frpt_ChiTietSoLuongTriGiaHangNhapHoacXuat form = new Frpt_ChiTietSoLuongTriGiaHangNhapHoacXuat();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnInTongHopNhapXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormTongHopNhapXuat));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormTongHopNhapXuat form = new FormTongHopNhapXuat();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnInDanhSachVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(Frpt_DanhSachVatTu));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                Frpt_DanhSachVatTu form = new Frpt_DanhSachVatTu();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnInDDHKhongPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(Frpt_DanhSachDonDatHangChuaCoPhieuNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                Frpt_DanhSachDonDatHangChuaCoPhieuNhap form = new Frpt_DanhSachDonDatHangChuaCoPhieuNhap();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnInHoatDongNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(Frpt_TinhHinhHoatDongNhanVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                Frpt_TinhHinhHoatDongNhanVien form = new Frpt_TinhHinhHoatDongNhanVien();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItemTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormTaoTaiKhoan));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormTaoTaiKhoan form = new FormTaoTaiKhoan();
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}
