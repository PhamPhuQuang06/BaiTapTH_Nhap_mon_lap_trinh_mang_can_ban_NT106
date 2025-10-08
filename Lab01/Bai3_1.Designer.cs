namespace Lab01
{
    partial class Bai3_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button4;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            this.label1.Location = new Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số nguyên:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Point(200, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(250, 23);
            this.textBox1.TabIndex = 1;
            // 
            // button1 (Đọc)
            // 
            this.button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.button1.Location = new Point(500, 30);
            this.button1.Name = "button1";
            this.button1.Size = new Size(100, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đọc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            // 
            // button4 (Xóa)
            // 
            this.button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.button4.Location = new Point(500, 90);
            this.button4.Name = "button4";
            this.button4.Size = new Size(100, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new EventHandler(this.button4_Click);
            // 
            // button2 (Thoát)
            // 
            this.button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.button2.Location = new Point(500, 150);
            this.button2.Name = "button2";
            this.button2.Size = new Size(100, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            this.label2.Location = new Point(30, 200);
            this.label2.Name = "label2";
            this.label2.Size = new Size(80, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kết quả:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Point(30, 240);
            this.textBox2.Multiline = true;
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new Size(570, 80);
            this.textBox2.TabIndex = 6;
            // 
            // Bai3_1
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(650, 350);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Bai3_1";
            this.Text = "Bài 3.1 - Đọc số";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
