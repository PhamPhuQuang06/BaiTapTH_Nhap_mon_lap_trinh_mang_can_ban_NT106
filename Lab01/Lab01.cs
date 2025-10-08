namespace Lab01
{
    public partial class Lab01 : Form
    {
        public Lab01()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai02 f = new Bai02();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai01 f = new Bai01();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai03 f = new Bai03();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai04 f = new Bai04();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai05 f = new Bai05();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bai06 f = new Bai06();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bai07 f = new Bai07();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bai08 f = new Bai08();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        // Add this method to your Lab01 class (likely in Lab01.cs, but shown here for clarity)
        private void button9_Click(object sender, EventArgs e)
        {
            Bai3_1 f = new Bai3_1();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
