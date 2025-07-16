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
    public partial class MusteriBorcEkle : Form
    {
        private readonly int MusteriID;
        private readonly string Adi;
        private readonly string Soyadi;
        private decimal ToplamBorc;
        private readonly string connStr = "Data Source=StokMaster.db;Version=3;";
        public MusteriBorcEkle()
        {
            InitializeComponent();
        }
        public MusteriBorcEkle(int id, string adi, string soyad, decimal borc) : this()
        {
            MusteriID = id;
            Adi = adi;
            Soyadi = soyad;
            ToplamBorc = borc;
        }
        /*
        private void ToplamBorcGuncelle(int toptanciId, decimal yeniBorc)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["StokMasterDB"].ConnectionString))
                {
                    string query = "UPDATE Musteri SET ToplamBorc = @YeniBorc WHERE MusteriID = @MusteriID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@YeniBorc", yeniBorc);
                        cmd.Parameters.AddWithValue("@MusteriID", toptanciId);

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
        */

        private void MusteriBorcEkle_Load(object sender, EventArgs e)
        {
            timer1.Start();
            txtMusteriAdı.Text = Adi;
            txtMusteriSoyad.Text = Soyadi;
            txtToplamBorc.Text = ToplamBorc.ToString("C2");
            maskedTextBox1.Text = DateTime.Now.ToShortDateString();
            txtSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
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

            decimal eskiToplamBorc = ToplamBorc;
            decimal yeniToplamBorc = eskiToplamBorc + eklenecekTutar;

            string musteriAdi = txtMusteriAdı.Text.Trim();
            string musteriSoyadi = txtMusteriSoyad.Text.Trim();
            string saat = DateTime.Now.ToString("HH:mm:ss");

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connStr))
                {
                    conn.Open();

                    string insertQuery = @"
                    INSERT INTO MusteriBorcEkleLog 
                    (MusteriID, MusteriAdi, MusteriSoyadi, EskiToplamBorc, EklenenTutar, Tarih, Saat, Aciklama, KayitTarihi)
                    VALUES 
                    (@MusteriID, @MusteriAdi, @MusteriSoyadi, @EskiToplamBorc, @EklenenTutar, @Tarih, @Saat, @Aciklama, @KayitTarihi)";

                    using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MusteriID", MusteriID);
                        cmd.Parameters.AddWithValue("@MusteriAdi", musteriAdi);
                        cmd.Parameters.AddWithValue("@MusteriSoyadi", musteriSoyadi);
                        cmd.Parameters.AddWithValue("@EskiToplamBorc", eskiToplamBorc);
                        cmd.Parameters.AddWithValue("@EklenenTutar", eklenecekTutar);
                        cmd.Parameters.AddWithValue("@Tarih", tarih.Date);
                        cmd.Parameters.AddWithValue("@Saat", saat);
                        cmd.Parameters.AddWithValue("@Aciklama", txtAcıklama.Text.Trim());
                        cmd.Parameters.AddWithValue("@KayitTarihi", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }

                    ToplamBorcGuncelle(conn, MusteriID, yeniToplamBorc);
                }

                MessageBox.Show($"Borç başarıyla eklendi!\nYeni Borç: {yeniToplamBorc:C2}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                MusteriBilgileri musteriBilgileri = new MusteriBilgileri();
                musteriBilgileri.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToplamBorcGuncelle(SQLiteConnection conn, int musteriId, decimal yeniBorc)
        {
            string query = "UPDATE Musteri SET ToplamBorc = @YeniBorc WHERE MusteriID = @MusteriID";

            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@YeniBorc", yeniBorc);
                cmd.Parameters.AddWithValue("@MusteriID", musteriId);
                cmd.ExecuteNonQuery();
            }

            ToplamBorc = yeniBorc;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
            MusteriBilgileri musteriBilgileri = new MusteriBilgileri();
            musteriBilgileri.Show();
        }
    }
}
