using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Bai07 : Form
    {
        public Bai07()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            string input = textBox1.Text.Trim();
            string[] rs = input.Split(',');
            if(rs.Length < 2)
            {
                MessageBox.Show("Sai format!, vui lòng nhập lại");
                return;
            }
            string hoten = rs[0].Trim();
            textBox2.Text = hoten;
            List<double> diem = new List<double>();
            for(int i = 0; i < rs.Length - 1; i++)
            {
                    double d = double.Parse(rs[i + 1].Trim());
                    if (d < 0 || d > 10)
                    {
                        MessageBox.Show("Điểm không hợp lệ, vui lòng nhập lại");
                        return;
                    }
                    diem.Add(d);
            }
            double dtb = diem.Average();
            dtb = Math.Round(dtb, 2);
            double scoreMin = diem.Min();
            double scoreMax = diem.Max();
            int countPass = diem.Count(x => x >= 5.0);
            int countFail = diem.Count(x => x < 5.0);
            foreach(double d in diem)
            {
                textBox3.Text += d.ToString() + " ";
            }
            if(dtb >= 8.0 && diem.Count(x => x < 6.5) == 0)
                textBox9.Text = "Giỏi";
            else if (dtb >= 6.5 && diem.Count(x => x < 5) == 0)
                textBox9.Text = "Khá";
            else if (dtb >= 5.0 && diem.Count(x => x < 3.5) == 0)
                textBox9.Text = "Trung Bình";
            else if(dtb >= 3.5 && diem.Count(x => x < 2) == 0)
                textBox9.Text = "Yếu";
            else
                textBox9.Text = "Kém";
            textBox4.Text = dtb.ToString();
            textBox6.Text = scoreMin.ToString();
            textBox5.Text = scoreMax.ToString();
            textBox7.Text = countPass.ToString();
            textBox8.Text = countFail.ToString();
            

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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bai07_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
