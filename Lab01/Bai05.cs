using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public static long GiaiThua(int n)
        {
            long gt = 1;
            if (n < 0)
                MessageBox.Show("B - A  là số âm, không thể tính giai thừa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                for(int i = 1; i <= n; i++)
                {
                    gt *= i;
                }
            }
            return gt;
        }
        public static long TinhTong(int a, int b)
        {
            long rs = 0;
            for(int i = 1; i <= b; i++)
            {
                rs += (long)Math.Pow(a, i);
            }
            return rs;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string loai = comboBox1.SelectedItem.ToString();
                if (loai == "Bảng cửu chương")
                {
                    int A = int.Parse(textBox1.Text);
                    int B = int.Parse(textBox2.Text);
                    int KQ = B - A;
                    textBox3.Text = KQ.ToString();
                }
                else
                {
                    int A = int.Parse(textBox1.Text);
                    int B = int.Parse(textBox2.Text);
                    long KQ1 = GiaiThua(A - B);
                    long KQ2 = TinhTong(A, B);
                    textBox3.Text = "Giai thừa (A - B) = " + KQ1.ToString() + "  " + "Tổng S = " + KQ2.ToString();

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số nhập vào quá lớn hoặc quá nhỏ!", "Lỗi tràn số", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Vui lòng chọn loại tính toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
