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
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
            try
            {
                int Ngay = int.Parse(textBox1.Text);
                int Thang = int.Parse(textBox3.Text);
                if(Thang < 1 || Thang > 12) MessageBox.Show("Vui lòng nhập tháng hợp lệ!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                switch (Thang)
                {
                    case 1:
                        if (Ngay <= 20)
                            textBox2.Text = "Cung Ma Kết";
                        else
                            textBox2.Text = "Cung Bảo Bình";
                        break;
                    case 2:
                        if(Ngay <= 19)
                            textBox2.Text = "Cung Bảo Bình";
                        else
                            textBox2.Text = "Cung Song Ngư";
                        break;
                    case 3:
                        if (Ngay <= 20)
                            textBox2.Text = "Cung Song Ngư";
                        else
                            textBox2.Text = "Cung Bạch Dương";
                        break;
                    case 4:
                        if (Ngay <= 20)
                            textBox2.Text = "Cung Bạch Dương";
                        else
                            textBox2.Text = "Cung Kim Ngưu";
                        break;
                    case 5:
                        if(Ngay <= 22)
                        {
                            textBox2.Text = "Cung Kim Ngưu";
                        }
                        else
                            textBox2.Text = "Cung Song Tử";
                        break;
                    case 6:     
                                 
                        if (Ngay <= 21)
                            textBox2.Text = "Cung Song Tử";
                        else
                            textBox2.Text = "Cung Cự Giải";
                        break;
                    case 7: 
                        if (Ngay <= 22)
                            textBox2.Text = "Cung Cự Giải";
                        else
                            textBox2.Text = "Cung Sư Tử";
                        break;
                    case 8:
                        if (Ngay <= 23)
                            textBox2.Text = "Cung Sư Tử";
                        else
                            textBox2.Text = "Cung Xử Nữ";
                        break;
                    case 9:
                        if (Ngay <= 23)
                            textBox2.Text = "Cung Xử Nữ";
                        else
                            textBox2.Text = "Cung Thiên Bình";
                        break;
                    case 10:
                        if (Ngay <= 23)
                            textBox2.Text = "Cung Thiên Bình";
                        else
                            textBox2.Text = "Cung Bọ Cạp";
                        break;
                    case 11:
                        if (Ngay <= 22)
                            textBox2.Text = "Cung Bọ Cạp";
                        else
                            textBox2.Text = "Cung Nhân Mã";
                        break;
                    case 12:
                        if (Ngay <= 21)
                            textBox2.Text = "Cung Nhân Mã";
                        else
                            textBox2.Text = "Cung Ma Kết";
                        break;
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Vui lòng nhập ngày tháng năm hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
