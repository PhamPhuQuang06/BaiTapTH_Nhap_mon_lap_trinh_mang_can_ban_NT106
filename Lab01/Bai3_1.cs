using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01
{
    public partial class Bai3_1 : Form
    {
        public Bai3_1()
        {
            InitializeComponent(); // Designer sẽ tạo control
        }

        private string DocBaChuSo(int num)
        {
            string[] ChuSo = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            int tram = num / 100;
            int chuc = (num % 100) / 10;
            int donvi = num % 10;
            string kq = "";

            if (tram > 0)
            {
                kq += ChuSo[tram] + " trăm";
                if (chuc == 0 && donvi > 0) kq += " linh";
            }

            if (chuc > 1)
            {
                kq += " " + ChuSo[chuc] + " mươi";
                if (donvi == 1) kq += " mốt";
                else if (donvi == 5) kq += " lăm";
                else if (donvi > 0) kq += " " + ChuSo[donvi];
            }
            else if (chuc == 1)
            {
                kq += " mười";
                if (donvi == 1) kq += " một";
                else if (donvi == 5) kq += " lăm";
                else if (donvi > 0) kq += " " + ChuSo[donvi];
            }
            else if (chuc == 0 && donvi > 0)
            {
                kq += " " + ChuSo[donvi];
            }

            return kq.Trim();
        }

        private string DocSo(long num)
        {
            string[] DonVi = { "", "nghìn", "triệu", "tỷ" };
            if (num == 0) return "Không";

            string result = "";
            int i = 0;

            while (num > 0)
            {
                int block = (int)(num % 1000);
                if (block > 0)
                {
                    string temp = DocBaChuSo(block);
                    if (DonVi[i] != "") temp += " " + DonVi[i];
                    result = temp + " " + result;
                }
                num /= 1000;
                i++;
            }

            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(result.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (long.TryParse(textBox1.Text, out long so))
            {
                textBox2.Text = DocSo(so); // ✅ xuất kết quả ra textBox2
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ (tối đa 12 chữ số).");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
