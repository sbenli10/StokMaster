using DevExpress.XtraEditors;
using DevExpress.XtraMap.Drawing;
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
using System.Windows.Forms;

namespace GirisEkranı
{
    public partial class Login : BaseForm
    {
        private string captchaText;
        private string connectionString = ConfigurationManager.ConnectionStrings["StokMasterDB"].ConnectionString;
        
        public Login()
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
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtEmail.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Lütfen geçerli bir mail adresi giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtCaptch.Text != captchaText)
            {
                MessageBox.Show("Captcha hatalı. Lütfen tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GenerateCaptcha();
                txtCaptch.Clear();
                return;
            }

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT PasswordHash
                         FROM Kullanicilar
                         WHERE Email = @Email COLLATE NOCASE";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());

                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string storedPassword = dr.GetString(0); // düz metin şifre

                                if (txtSifre.Text == storedPassword)
                                {
                                    MessageBox.Show("Giriş Başarılı", "Bilgi",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();
                                    new AnaSayfa().Show();
                                }
                                else
                                {
                                    MessageBox.Show("Şifre yanlış!", "Giriş Hatası",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    GenerateCaptcha();
                                    txtCaptch.Clear();
                                }
                            }
                            else
                            {
                                MessageBox.Show("E-posta bulunamadı!", "Giriş Hatası",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                GenerateCaptcha();
                                txtCaptch.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message,
                                "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          // MessageBox.Show("DB Yolu:\n" + AppDomain.CurrentDomain.GetData("DataDirectory"));
            this.CancelButton = btnClose;
            this.AcceptButton = simpleButton1;
            txtSifre.PasswordChar = '*';
            checkBox1.Checked = true;
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            GenerateCaptcha();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = checkBox1.Checked ? '*' : '\0';
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            KayıtEkranı kayıt = new KayıtEkranı();
            kayıt.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SifremiUnuttum sifremiUnuttum = new SifremiUnuttum();
            sifremiUnuttum.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
