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
using static GirisEkranı.ÜrünAraSil;

namespace GirisEkranı
{
    public partial class ÜrünGirisi : BaseForm
    {
        private SQLiteConnection conn = new SQLiteConnection($"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StokMaster.db")};Version=3;");


        public event Urunsec UrunSec;
        public event ÜrünSeçildiHandler Urunsecildi;



        public ÜrünGirisi()
        {
            InitializeComponent();
        }

        private void ÜrünGirisi_Load(object sender, EventArgs e)
        {
            UrunGrubuDoldur();
            ToptancıAdıDoldur();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBarkodNo.Text) || string.IsNullOrEmpty(txtUrunAdi.Text)
            || string.IsNullOrEmpty(txtUrunKoduAcıklama.Text) || cmboxUrunGrubu.SelectedItem == null
            || string.IsNullOrEmpty(txtAlısFiyatı.Text) || string.IsNullOrEmpty(txtİkinciAlısFiyatı.Text)
             || string.IsNullOrEmpty(txtKdvOranı.Text) || string.IsNullOrEmpty(txtMevcutStok.Text)
            || string.IsNullOrEmpty(txtOlcuBirimi.Text) || string.IsNullOrEmpty(txtAsgariStok.Text)
            || cmboxToptancıAdı.SelectedItem == null || cmboxOdemeTuru.SelectedItem == null)
                {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();

                var Checkcmd = new SQLiteCommand("SELECT COUNT(*) FROM Urunler WHERE BarkodNo = @BarkodNo", conn);
                Checkcmd.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);

                int count = Convert.ToInt32(Checkcmd.ExecuteScalar());

                // ❗ UrunGrubu -> UrunID olarak KeyValuePair'ten alınmalı
                int urunGrubuId = (cmboxUrunGrubu.SelectedItem is KeyValuePair<int, string> secim)
                    ? secim.Key
                    : 0;

                string toptanciAdi = cmboxToptancıAdı.SelectedItem.ToString();
                string odemeSekli = cmboxOdemeTuru.SelectedItem.ToString();

                var cmd = new SQLiteCommand(conn);

                if (count > 0)
                {
                    cmd.CommandText = @"UPDATE Urunler SET 
                UrunAdi = @UrunAdi,
                UrunKodu = @UrunKodu,
                UrunGrubu = @UrunGrubu,
                AlisFiyatiKDVdahil = @AlisFiyatiKDVdahil,
                AlisFiyatiKDVharic = @AlisFiyatiKDVharic,
                SatisFiyati = @SatisFiyati,
                IkinciSatisFiyati = @IkinciSatisFiyati,
                KDVOrani = @KDVOrani,
                MevcutStokMiktari = @MevcutStokMiktari,
                OlcuBirimi = @OlcuBirimi,
                AsgariStok = @AsgariStok,
                ToptanciAdi = @ToptanciAdi,
                OdemeSekli = @OdemeSekli,
                KayitTarihi = @KayitTarihi
                WHERE BarkodNo = @BarkodNo";
                }
                else
                {
                    cmd.CommandText = @"INSERT INTO Urunler 
                (BarkodNo, UrunAdi, UrunKodu, UrunGrubu, AlisFiyatiKDVdahil, AlisFiyatiKDVharic, 
                SatisFiyati, IkinciSatisFiyati, KDVOrani, MevcutStokMiktari, OlcuBirimi, AsgariStok, 
                ToptanciAdi, OdemeSekli, KayitTarihi)
                VALUES 
                (@BarkodNo, @UrunAdi, @UrunKodu, @UrunGrubu, @AlisFiyatiKDVdahil, @AlisFiyatiKDVharic, 
                @SatisFiyati, @IkinciSatisFiyati, @KDVOrani, @MevcutStokMiktari, @OlcuBirimi, @AsgariStok, 
                @ToptanciAdi, @OdemeSekli, @KayitTarihi)";
                }

                cmd.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
                cmd.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text);
                cmd.Parameters.AddWithValue("@UrunKodu", txtUrunKoduAcıklama.Text);
                cmd.Parameters.AddWithValue("@UrunGrubu", urunGrubuId); // ❗ UrunGrupAdi değil, UrunID
                cmd.Parameters.AddWithValue("@AlisFiyatiKDVdahil", decimal.Parse(txtAlısFiyatı.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@AlisFiyatiKDVharic", decimal.Parse(txtİkinciAlısFiyatı.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@SatisFiyati", decimal.Parse(txtAlısFiyatı.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@IkinciSatisFiyati", decimal.Parse(txtİkinciAlısFiyatı.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@KDVOrani", decimal.Parse(txtKdvOranı.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@MevcutStokMiktari", int.Parse(txtMevcutStok.Text));
                cmd.Parameters.AddWithValue("@OlcuBirimi", txtOlcuBirimi.Text);
                cmd.Parameters.AddWithValue("@AsgariStok", int.Parse(txtAsgariStok.Text));
                cmd.Parameters.AddWithValue("@ToptanciAdi", toptanciAdi);
                cmd.Parameters.AddWithValue("@OdemeSekli", odemeSekli);
                cmd.Parameters.AddWithValue("@KayitTarihi", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                cmd.ExecuteNonQuery();

                MessageBox.Show(count > 0 ? "Ürün başarıyla GÜNCELLENDİ." : "Ürün başarıyla KAYDEDİLDİ.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            BarkodOkuyucu barkodOkuyucu = new BarkodOkuyucu();
            barkodOkuyucu.Show();
           
        }

        private void btnUrunAra_Click(object sender, EventArgs e)
        {

            ÜrünAraSil frmAraSil = new ÜrünAraSil();
            frmAraSil.UrunGirisiFormu = this; 
            frmAraSil.ShowDialog();
        }

        private void btnUrunGrubuEkle_Click(object sender, EventArgs e)
        {
            this.Close();
            UrunGrubu urunGrubu = new UrunGrubu();
            urunGrubu.Show();
        }


        private void UrunGrubuDoldur()
        {

            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT UrunID, UrunGrupAdi FROM UrunGrubu", conn);
            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string adi = dr.GetString(1);
                    cmboxUrunGrubu.Items.Add(new KeyValuePair<int, string>(id, adi));
                }
            }

            cmboxUrunGrubu.DisplayMember = "Value";
            cmboxUrunGrubu.ValueMember = "Key";
        
        }


        private void ToptancıAdıDoldur()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            using (var cmd = new SQLiteCommand("SELECT ToptanciAdi FROM Toptancilar", conn))
            using (var dr = cmd.ExecuteReader())
            {
                cmboxToptancıAdı.Items.Clear();
                while (dr.Read())
                {
                    cmboxToptancıAdı.Items.Add(dr["ToptanciAdi"].ToString());
                }
            }

            conn.Close();
        }

        private void btnToptancıEkle_Click(object sender, EventArgs e)
        {
            ToptancıEkle toptancıEkle = new ToptancıEkle();
            toptancıEkle.Show();
        }

        private void cmboxUrunGrubu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            
        }
    }
}