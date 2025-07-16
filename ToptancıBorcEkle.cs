using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirisEkranı
{
    public partial class ToptancıBorcEkle : BaseForm
    {
        private int toptanciID;
        private string toptanciAdi;
        private decimal toplamBorc;

        public ToptancıBorcEkle()
        {
            InitializeComponent();

        }

        public ToptancıBorcEkle(int id, string adi, decimal borc)
        {
            InitializeComponent();
            toptanciID = id;
            toptanciAdi = adi;
            toplamBorc = borc;
        }
        private void txtSaat_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToplamBorcGuncelle(int toptanciId, decimal yeniBorc)
        {
            try
            {
                string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StokMaster.db");
                using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    string query = "UPDATE Toptancilar SET ToptanciBorc = @YeniBorc WHERE ToptanciID = @ToptanciID";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@YeniBorc", yeniBorc);
                        cmd.Parameters.AddWithValue("@ToptanciID", toptanciId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Borç güncelleme sırasında hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToptancıBorcEkle_Load(object sender, EventArgs e)
        {
            timer1.Start();
            txtToptancıAdı.Text = toptanciAdi;
            txtToplamBorc.Text = toplamBorc.ToString("C2");
            maskedTextBox1.Text = DateTime.Now.ToShortDateString();
            txtSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtSaat.Text = DateTime.Now.ToLongTimeString();
        }


        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtEkleTutarı.Text, out decimal eklenecekTutar))
                {
                    MessageBox.Show("Lütfen geçerli bir tutar girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!DateTime.TryParse(maskedTextBox1.Text, out DateTime tarih))
                {
                    MessageBox.Show("Geçerli bir tarih girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal eskiToplamBorc = toplamBorc;
                decimal yeniToplamBorc = eskiToplamBorc + eklenecekTutar;
                toplamBorc = yeniToplamBorc;

                string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StokMaster.db");
                using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    string query = @"INSERT INTO ToptanciBorcLog 
                        (ToptanciID, ToptanciAdi, EskiToplamBorc, EklenenTutar, Tarih, Saat, Aciklama, KayitTarihi)
                        VALUES 
                        (@ToptanciID, @ToptanciAdi, @EskiToplamBorc, @EklenenTutar, @Tarih, @Saat, @Aciklama, @KayitTarihi)";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ToptanciID", toptanciID);
                        cmd.Parameters.AddWithValue("@ToptanciAdi", toptanciAdi);
                        cmd.Parameters.AddWithValue("@EskiToplamBorc", eskiToplamBorc);
                        cmd.Parameters.AddWithValue("@EklenenTutar", eklenecekTutar);
                        cmd.Parameters.AddWithValue("@Tarih", tarih.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Saat", DateTime.Now.ToString("HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@Aciklama", txtAcıklama.Text);
                        cmd.Parameters.AddWithValue("@KayitTarihi", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                ToplamBorcGuncelle(toptanciID, yeniToplamBorc);

                MessageBox.Show($"Borç ekleme işlemi başarılı!\nToptancı Adı: {toptanciAdi}\nYeni Toplam Borç: {yeniToplamBorc:C2}",
                                "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
