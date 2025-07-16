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
    public partial class MusteriYeniKayıt : BaseForm
    {

        public MusteriYeniKayıt()
        {
            InitializeComponent();
        }
        SQLiteConnection conn = new SQLiteConnection("Data Source=StokMaster.db;Version=3;");

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(txtTicarUnvan.Text) ||
               string.IsNullOrEmpty(txtGsmNumarası.Text) || string.IsNullOrEmpty(txtVergiDairesi.Text) || string.IsNullOrEmpty(txtVergiNumarası.Text) ||
               string.IsNullOrEmpty(txtAdres.Text) || string.IsNullOrEmpty(txtİlVeİlce.Text) || comboBox1.SelectedItem == null ||
               string.IsNullOrEmpty(txtOzelNotlar.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtLimitBelirle.Text) ||
               string.IsNullOrEmpty(txtDevredenBorc.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"INSERT INTO Musteri 
                (Adi, Soyadi, TicariUnvani, GsmTelefonu, VergiDairesi, VergiNumarasi, Adres, IlIlce, Ulke, OzelNotlar, Email, LimitBelirle, KayitTarihi, DevredenBorc, ToplamBorc) 
                VALUES 
                (@Adi, @Soyadi, @TicariUnvani, @GsmTelefonu, @VergiDairesi, @VergiNumarasi, @Adres, @IlIlce, @Ulke, @OzelNotlar, @Email, @LimitBelirle, @KayitTarihi, @DevredenBorc, @ToplamBorc)";

            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Adi", txtAd.Text.Trim());
                cmd.Parameters.AddWithValue("@Soyadi", txtSoyad.Text.Trim());
                cmd.Parameters.AddWithValue("@TicariUnvani", txtTicarUnvan.Text.Trim());
                cmd.Parameters.AddWithValue("@GsmTelefonu", txtGsmNumarası.Text.Trim());
                cmd.Parameters.AddWithValue("@VergiDairesi", txtVergiDairesi.Text.Trim());
                cmd.Parameters.AddWithValue("@VergiNumarasi", txtVergiNumarası.Text.Trim());
                cmd.Parameters.AddWithValue("@Adres", txtAdres.Text.Trim());
                cmd.Parameters.AddWithValue("@IlIlce", txtİlVeİlce.Text.Trim());
                cmd.Parameters.AddWithValue("@Ulke", comboBox1.SelectedItem.ToString().Trim());
                cmd.Parameters.AddWithValue("@OzelNotlar", txtOzelNotlar.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@LimitBelirle", txtLimitBelirle.Text.Trim());
                cmd.Parameters.AddWithValue("@KayitTarihi", DateTime.Now);
                cmd.Parameters.AddWithValue("@DevredenBorc", Convert.ToDecimal(txtDevredenBorc.Text.Trim()));
                cmd.Parameters.AddWithValue("@ToplamBorc", Convert.ToDecimal(txtDevredenBorc.Text.Trim())); // Başlangıçta devreden borçla eşitleniyor

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Yeni müşteri kaydı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                    this.Close();
                }
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void MusteriYeniKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}