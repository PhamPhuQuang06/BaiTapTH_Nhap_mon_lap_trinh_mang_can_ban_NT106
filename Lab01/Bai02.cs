using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;
            double numberMax = 0.0;
            double numberMin = 0.0;
            try
            {
                num1 = double.Parse(textBox1.Text.Trim());
                num2 = double.Parse(textBox2.Text.Trim());
                num3 = double.Parse(textBox3.Text.Trim());
                if (num1 >= num2 && num1 >= num3)
                {
                    numberMax = num1;
                    if (num2 >= num3) numberMin = num3;
                    else numberMin = num2;
                }
                else if (num2 >= num1 && num2 >= num3)
                {
                    numberMax = num2;
                    if (num1 >= num3) numberMin = num3;
                    else numberMin = num1;
                }
                else if (num3 >= num2 && num3 >= num1)
                {
                    numberMax = num3;
                    if (num1 >= num2) numberMin = num2;
                    else numberMin = num1;
                }
                textBox4.Text = numberMax.ToString();
                textBox5.Text = numberMin.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số thực hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //catch (OverflowException)
            //{
            //    MessageBox.Show("Số nhập vào quá lớn hoặc quá nhỏ!", "Lỗi tràn số", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}