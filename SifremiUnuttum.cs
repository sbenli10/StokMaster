using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirisEkranı
{
    public partial class SifremiUnuttum : BaseForm
    {
        private string captchaText;

        public SifremiUnuttum()
        {
            InitializeComponent();
            GenerateCaptcha();
        }

        private void GenerateCaptcha()
        {
            captchaText = GenerateRandomText(6);
            pictureBox1.Image = GenerateCaptchaImage(captchaText);
        }


        private string GenerateRandomText(int length)
        {
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            Random random = new Random();
            return new string(Enumerable.Range(0, length)
                               .Select(_ => chars[random.Next(chars.Length)])
                               .ToArray());
        }
        private Bitmap GenerateCaptchaImage(string text)
        {
            int width = 150, height = 50;
            Bitmap bitmap = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
                using (Font font = new Font("Arial", 18, FontStyle.Bold))
                using (Brush brush = new SolidBrush(Color.Black))
                {
                    g.DrawString(text, font, brush, new PointF(10, 10));
                }


                Random rand = new Random();
                for (int i = 0; i < 10; i++)
                {
                    g.DrawLine(Pens.Gray, rand.Next(width), rand.Next(height), rand.Next(width), rand.Next(height));
                }
            }
            return bitmap;
        }
        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {

        }

        private void btnSifreGüncelle_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string telefon = txtTelefonNo.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefon))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtCaptch.Text != captchaText)
            {
                MessageBox.Show("Captcha hatalı. Lütfen tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GenerateCaptcha();
                txtCaptch.Clear();
                return;
            }

            string dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StokMaster.db");
            string connectionString = $"Data Source={dbPath};Version=3;";

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT COUNT(*) FROM YeniKullanicilar 
                                     WHERE Email = @Email AND PhoneNumber = @PhoneNumber";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@PhoneNumber", telefon);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 0)
                        {
                            MessageBox.Show("Email veya Telefon Numarası bulunamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        MessageBox.Show("Bilgiler doğru. Şifre güncelleme sayfasına yönlendiriliyorsunuz...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        SifreGüncelle sifreGuncelle = new SifreGüncelle
                        {
                            Email = email
                        };
                        sifreGuncelle.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}