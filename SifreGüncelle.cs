using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirisEkranı
{
    public partial class SifreGüncelle : BaseForm
    {
        public string Email { get; set; }

        public SifreGüncelle()
        {
            InitializeComponent();
        }

        private void SifreGüncelle_Load(object sender, EventArgs e)
        {
            this.AcceptButton = simpleButton1;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string yeniSifre = txtSifre.Text.Trim();
            string sifreTekrar = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(yeniSifre) || string.IsNullOrEmpty(sifreTekrar))
            {
                MessageBox.Show("Şifre alanları boş olamaz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (yeniSifre != sifreTekrar)
            {
                MessageBox.Show("Lütfen girdiğiniz şifreler aynı olsun!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSifre.Clear();
                textBox1.Clear();
                return;
            }

            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StokMaster.db");
            string connectionString = $"Data Source={dbPath};Version=3;";
            MessageBox.Show("Kullanılan DB Yolu:\n" + dbPath);
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    // Her iki tabloda da güncelleme yap
                    string[] tablolar = { "Kullanicilar", "YeniKullanicilar" };

                    foreach (var tablo in tablolar)
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand(
                            $"UPDATE {tablo} SET PasswordHash = @PasswordHash WHERE Email = @Email", conn))
                        {
                            cmd.Parameters.AddWithValue("@PasswordHash", yeniSifre); // Hashleme yoksa düz yazılıyor!
                            cmd.Parameters.AddWithValue("@Email", this.Email);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Şifreniz başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n" + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }       
    }
}
