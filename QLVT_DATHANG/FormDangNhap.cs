﻿using System;
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
    public partial class FormDangNhap : Form
    {
        private SqlConnection connPublisher = new SqlConnection();

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void layDanhSachPhanManh(String cmd)
        {
            if (connPublisher.State == ConnectionState.Closed)
            {
                connPublisher.Open();
            }
            DataTable dt = new DataTable();
            // adapter dùng để đưa dữ liệu từ view sang database
            SqlDataAdapter da = new SqlDataAdapter(cmd, connPublisher);
            // dùng adapter thì mới đổ vào data table được
            da.Fill(dt);


            connPublisher.Close();
            Program.bindingSource.DataSource = dt;


            comboBoxChiNhanh.DataSource = Program.bindingSource;
            comboBoxChiNhanh.DisplayMember = "TENCN";
            comboBoxChiNhanh.ValueMember = "TENSERVER";
        }

        /******************************************************************
         * mở kết nối tới server 
         * @return trả về 1 nếu thành công
         *         trả về 0 nếu thất bại
         ******************************************************************/
        private int KetNoiDatabaseGoc()
        {
            if (connPublisher != null && connPublisher.State == ConnectionState.Open)
                connPublisher.Close();
            try
            {
                connPublisher.ConnectionString = Program.connstrPublisher;
                connPublisher.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // đặt sẵn mật khẩu để đỡ nhập lại nhiều lần
            textBoxTaiKhoan.Text = "TT";// nguyen long - chi nhanh
            textBoxMatKhau.Text = "123456";
            if (KetNoiDatabaseGoc() == 0)
                return;
            //Lấy 2 cái đầu tiên của danh sách
            layDanhSachPhanManh("SELECT TOP 2 * FROM view_DanhSachPhanManh");
            comboBoxChiNhanh.SelectedIndex = 0;
            comboBoxChiNhanh.SelectedIndex = 1;
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            /* Step 1*/
            if (textBoxTaiKhoan.Text.Trim() == "" || textBoxMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản & mật khẩu không thể bỏ trống", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            /* Step 2*/
            Program.loginName = textBoxTaiKhoan.Text.Trim();
            Program.loginPassword = textBoxMatKhau.Text.Trim();
            if (Program.KetNoi() == 0)
                return;
            /* Step 3*/
            Program.brand = comboBoxChiNhanh.SelectedIndex;
            Program.currentLogin = Program.loginName;
            Program.currentPassword = Program.loginPassword;


            /* Step 4*/
            String statement = "EXEC sp_DangNhap '" + Program.loginName + "'";// exec sp_DangNhap 'TP'
            Program.myReader = Program.ExecSqlDataReader(statement);
            if (Program.myReader == null)
                return;
            // đọc một dòng của myReader - điều này là hiển nhiên vì kết quả chỉ có 1 dùng duy nhất
            Program.myReader.Read();


            /* Step 5*/
            Program.userName = Program.myReader.GetString(0);// lấy userName
            if (Convert.IsDBNull(Program.userName))
            {
                MessageBox.Show("Tài khoản này không có quyền truy cập \n Hãy thử tài khoản khác", "Thông Báo", MessageBoxButtons.OK);
            }



            Program.staff = Program.myReader.GetString(1);
            Program.role = Program.myReader.GetString(2);

            Program.myReader.Close();
            Program.conn.Close();

            Program.formChinh.MANV.Text = "MÃ NHÂN VIÊN: " + Program.userName;
            Program.formChinh.HOTEN.Text = "HỌ TÊN: " + Program.staff;
            Program.formChinh.NHOM.Text = "VAI TRÒ: " + Program.role;

            /* Step 6*/
            this.Visible = false;
            Program.formChinh.enableButtons();
        }

        private void comboBoxChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.serverName = comboBoxChiNhanh.SelectedValue.ToString();
                //Console.WriteLine(cmbCHINHANH.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
