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
    public partial class Bai04 : Form
    {

        Dictionary<Button, (int phong, string ghe)> danhSachGhe = new Dictionary<Button, (int, string)>();


        HashSet<string> gheDaMua = new HashSet<string>();

        HashSet<string> gheDangChon = new HashSet<string>();

        Dictionary<string, double> giaPhim = new Dictionary<string, double>()
        {
            {"Đào, phở và piano", 45000},
            {"Mai", 100000},
            {"Gặp lại chị bầu", 70000},
            {"Tarot", 90000}
        };

        public Bai04()
        {
            InitializeComponent();
        }

        private void Bai04_Load(object sender, EventArgs e)
        {
            try
            {

                SelectedFilm_comboBox1.Items.AddRange(giaPhim.Keys.ToArray());


                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    int phong = i + 1;

                    foreach (Control c in tabControl1.TabPages[i].Controls)
                    {
                        if (c is Button btn && btn.Text.Length >= 2)
                        {
                            danhSachGhe[btn] = (phong, btn.Text);
                            btn.BackColor = Color.LightGray;
                            btn.Click += XuLyChonGhe;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi khởi tạo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectedFilm_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedFilm_comboBox1.SelectedItem == null) return;

            string phim = SelectedFilm_comboBox1.SelectedItem.ToString();
            try
            {
                if (phim == "Mai")
                {
                    tabPage1.Enabled = false;
                    tabPage2.Enabled = true;
                    tabPage3.Enabled = true;
                }
                else if (phim == "Gặp lại chị bầu")
                {
                    tabPage1.Enabled = true;
                    tabPage2.Enabled = false;
                    tabPage3.Enabled = false;
                }
                else if (phim == "Tarot")
                {
                    tabPage1.Enabled = false;
                    tabPage2.Enabled = false;
                    tabPage3.Enabled = true;
                }
                else
                {
                    tabPage1.Enabled = true;
                    tabPage2.Enabled = true;
                    tabPage3.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn phim: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XuLyChonGhe(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            try
            {

                var (phong, ghe) = danhSachGhe[btn];
                string key = $"{phong}-{ghe}";


                if (gheDaMua.Contains(key))
                {
                    MessageBox.Show($"Ghế {ghe} ở phòng {phong} đã được mua!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                if (gheDangChon.Contains(key))
                {
                    gheDangChon.Remove(key);
                    btn.BackColor = Color.LightGray;
                }
                else
                {

                    var phongDangChon = gheDangChon.Select(k => int.Parse(k.Split('-')[0])).Distinct().ToList();
                    if (phongDangChon.Count >= 2 && !phongDangChon.Contains(phong))
                    {
                        MessageBox.Show("Không thể chọn ghế từ hơn 2 phòng chiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    if (gheDangChon.Count >= 2 && phongDangChon.Count > 1)
                    {
                        MessageBox.Show("Không thể chọn quá 2 ghế khi ở 2 phòng chiếu khác nhau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    gheDangChon.Add(key);
                    btn.BackColor = Color.LightGreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn ghế: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThanhToan_button45_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(NameCotumer_textBox1.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (SelectedFilm_comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn phim!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (gheDangChon.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string phim = SelectedFilm_comboBox1.SelectedItem.ToString();
                string tenKhachHang = NameCotumer_textBox1.Text;
                double giaChuan = giaPhim[phim];
                double tongTien = 0;
                StringBuilder hoaDon = new StringBuilder();
                hoaDon.AppendLine($"Họ và tên: {tenKhachHang}");
                hoaDon.AppendLine($"Phim: {phim}");
                hoaDon.AppendLine("Vé đã chọn:");

                foreach (string key in gheDangChon)
                {
                    var parts = key.Split('-');
                    int phong = int.Parse(parts[0]);
                    string ghe = parts[1];

                    double tiLe = 1;
                    string loaiVe = "Vé thường";
                    if (new[] { "A1", "A5", "C1", "C5" }.Contains(ghe))
                    {
                        tiLe = 0.25;
                        loaiVe = "Vé vớt";
                    }
                    else if (new[] { "B2", "B3", "B4" }.Contains(ghe))
                    {
                        tiLe = 2;
                        loaiVe = "Vé VIP";
                    }

                    double giaVe = giaChuan * tiLe;
                    tongTien += giaVe;
                    gheDaMua.Add(key);
                    hoaDon.AppendLine($" - Ghế {ghe}, Phòng {phong}, Loại vé: {loaiVe}, Giá: {giaVe:N0} đ");
                }


                foreach (var kvp in danhSachGhe)
                {
                    var (phong, ghe) = kvp.Value;
                    if (gheDaMua.Contains($"{phong}-{ghe}"))
                        kvp.Key.BackColor = Color.IndianRed;
                }

                hoaDon.AppendLine($"Tổng tiền: {tongTien:N0} đ");
                textBox1.Text = hoaDon.ToString();
                gheDangChon.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thanh toán: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}