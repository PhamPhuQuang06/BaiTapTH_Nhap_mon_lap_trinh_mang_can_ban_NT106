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
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            try
            {
                number = int.Parse(textBox1.Text.Trim());
                if(number < 0 || number > 9)
                {
                    MessageBox.Show("Vui long nhập số nguyên từ 0 đến 9!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                switch (number)
                {
                    case 0:
                        textBox2.Text = "Không";
                        break;
                    case 1:
                        textBox2.Text = "Một";
                        break;
                    case 2:
                        textBox2.Text = "Hai";
                        break;
                    case 3:
                        textBox2.Text = "Ba";
                        break;
                    case 4:
                        textBox2.Text = "Bốn";
                        break;
                    case 5:
                        textBox2.Text = "Năm";
                        break;
                    case 6:
                        textBox2.Text = "Sáu";
                        break;
                    case 7:
                        textBox2.Text = "Bảy";
                        break;
                    case 8:
                        textBox2.Text = "Tám";
                        break;
                    case 9:
                        textBox2.Text = "Chín";
                        break;
                    default:
                        break;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
