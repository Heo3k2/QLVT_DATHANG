using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT_DATHANG.Reports
{
    public partial class ReportHoatDongNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        private static readonly string[] Units = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        private static readonly string[] Tens = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
        private static readonly string[] Teens = { "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín" };

        public static string Convert(string number)
        {
            number = number.Replace(".", "");
            number = number.Replace(" đồng", "");
            if (!long.TryParse(number, out long numericValue))
                return "";

            return Convert(numericValue);
        }
        public static string Convert(long number)
        {
            if (number == 0)
                return "không";

            if (number < 0)
                return "âm " + Convert(Math.Abs(number));

            string words = "";

            if ((number / 1000000000) > 0)
            {
                words += Convert(number / 1000000000) + " tỷ ";
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                words += Convert(number / 1000000) + " triệu ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += Convert(number / 1000) + " nghìn ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += Convert(number / 100) + " trăm ";
                number %= 100;
            }

            if (number > 0)
            {
                if (number < 10)
                    words += Units[number];
                else if (number < 20)
                    words += Teens[number - 10];
                else
                {
                    words += Tens[number / 10];
                    if ((number % 10) > 0)
                        words += " " + Units[number % 10];
                }
            }
            return words = words.Trim();
        }

        public ReportHoatDongNhanVien(String maNhanVien, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maNhanVien;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = fromDate;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = toDate;

            this.sqlDataSource1.Fill();

            txtTongTriGia.AfterPrint += txtTongTriGia_AfterPrint;
        }

        private void txtTongTriGia_AfterPrint(object sender, EventArgs e)
        {
            // Thực hiện các câu lệnh khác sau khi XRLabel cập nhật kết quả
            string chu = txtTongTriGia.Text;
            chu = Convert(chu) + " đồng";
            chu = chu.Substring(0, 1).ToUpper() + chu.Substring(1);
            txtChu.Text = chu;
            //Console.WriteLine(txtChu.Text);
        }
    }
}
