using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
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
    public partial class KayıtEkranı : BaseForm
    {
        private string captchaText;
        private string connectionString = "Data Source=StokMaster.db;Version=3;";

        public KayıtEkranı()
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



        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnKayıtOL_Click(object sender, EventArgs e)
        {
            string sifretekrar = txtSifreTekrar.Text;

            if (string.IsNullOrWhiteSpace(txtİsimSoyisim.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelefonNo.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                string.IsNullOrWhiteSpace(sifretekrar))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (captchaText != txtCaptch.Text)
            {
                MessageBox.Show("Captcha hatalı. Lütfen tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GenerateCaptcha();
                txtCaptch.Clear();
                return;
            }

            if (txtSifre.Text != sifretekrar)
            {
                MessageBox.Show("Şifreler eşleşmiyor!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM YeniKullanicilar WHERE PhoneNumber = @PhoneNumber OR Email = @Email";
                    using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@PhoneNumber", txtTelefonNo.Text);
                        checkCmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                        int existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (existingCount > 0)
                        {
                            MessageBox.Show("Bu telefon numarası veya email ile kayıt zaten var!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // YeniKullanicilar tablosuna kayıt
                    string insertQuery1 = @"
                        INSERT INTO YeniKullanicilar (FullName, Email, PhoneNumber, PasswordHash, CreatedAt)
                        VALUES (@FullName, @Email, @PhoneNumber, @PasswordHash, @CreatedAt)";
                    using (SQLiteCommand cmd1 = new SQLiteCommand(insertQuery1, conn))
                    {
                        cmd1.Parameters.AddWithValue("@FullName", txtİsimSoyisim.Text);
                        cmd1.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd1.Parameters.AddWithValue("@PhoneNumber", txtTelefonNo.Text);
                        cmd1.Parameters.AddWithValue("@PasswordHash", txtSifre.Text); // Hash yoksa düz yazılır
                        cmd1.Parameters.AddWithValue("@CreatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd1.ExecuteNonQuery();
                    }

                    // Kullanicilar tablosuna kayıt
                    string insertQuery2 = @"
                        INSERT INTO Kullanicilar (Email, PasswordHash, CreatedAt)
                        VALUES (@Email, @PasswordHash, @CreatedAt)";
                    using (SQLiteCommand cmd2 = new SQLiteCommand(insertQuery2, conn))
                    {
                        cmd2.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd2.Parameters.AddWithValue("@PasswordHash", txtSifre.Text);
                        cmd2.Parameters.AddWithValue("@CreatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd2.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kayıt başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt işlemi sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KayıtEkranı_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnKayıtOL;
            txtSifre.PasswordChar = '*';
            txtSifreTekrar.PasswordChar = '*';
            checkBox1.Checked = false;
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            GenerateCaptcha();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = checkBox1.Checked ? '*' : '\0';
            txtSifreTekrar.PasswordChar = checkBox1.Checked ? '*' : '\0';
        }
    }
}