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
    public partial class Bai08 : Form
    {
        public Bai08()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text.Trim();
                if(input == "") MessageBox.Show("Vui lòng nhập món ăn!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBox1.Items.Add(input);
                textBox1.Clear();
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Lỗi " + ex, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, listBox1.Items.Count);
                string random = listBox1.Items[index].ToString();
                textBox2.Text = random;
            }
            else
            {
                MessageBox.Show("Không có món ăn nào có sẵn! Vui lòng nhập thêm món ăn.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
