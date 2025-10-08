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
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long  a, b;
            long sum;
            try
                {
       
                a = int.Parse(textBox1.Text.Trim());
                b = int.Parse(textBox2.Text.Trim());
                sum = a + b;
                textBox3.Text = sum.ToString();
        
            } 
            catch(FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(OverflowException)
            {
                MessageBox.Show("Số nhập vào quá lớn hoặc quá nhỏ!", "Lỗi tràn số", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
