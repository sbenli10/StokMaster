using DevExpress.XtraCharts.Native;
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
    public partial class ToptancıEkle : BaseForm
    {
        private bool guncellemeModu = false;
        private int mevcutToptanciID = -1;

        public ToptancıEkle(int id, string ad, string yetkili, string eposta, string internetAdresi,
        string isTel, string gsmTel, string fax, string vd, string vn,
        string adres, string notlar)
        {
            InitializeComponent();

            txtToptancıAdı.Text = ad;
            txtSirketYetkilisi.Text = yetkili;
            txtEmail.Text = eposta;
            txtInsternetAdresi.Text = internetAdresi;
            txtİsTelefonu.Text = isTel.Replace(" ", "");
            txtGsmTelefonu.Text = gsmTel.Replace(" ", "");
            txtFax.Text = fax.Replace(" ", "");
            txtVergiDairesi.Text = vd;
            txtVergİNumarası.Text = vn;
            txtAdres.Text = adres;
            txtÖzelNotlar.Text = notlar;

            guncellemeModu = true;
            mevcutToptanciID = id;
        }

        public ToptancıEkle()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ToptancıSil toptancıSil = new ToptancıSil();
            toptancıSil.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Controls.OfType<TextBox>().Any(tb => string.IsNullOrWhiteSpace(tb.Text)))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!txtGsmTelefonu.Text.StartsWith("05") || txtGsmTelefonu.Text.Length != 11)
                {
                    MessageBox.Show("GSM numarası 05 ile başlamalı ve 11 hane olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!txtİsTelefonu.Text.StartsWith("0") || txtİsTelefonu.Text.Length != 11)
                {
                    MessageBox.Show("İş telefonu 0 ile başlamalı ve 11 hane olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StokMaster.db");
                using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    conn.Open();
                    SQLiteCommand cmd;

                    if (guncellemeModu)
                    {
                        cmd = new SQLiteCommand(@"
                            UPDATE Toptancilar SET 
                                ToptanciAdi = @ToptanciAdi,
                                SirketYetkilisi = @SirketYetkilisi,
                                EPosta = @EPosta,
                                InternetAdresi = @InternetAdresi,
                                IsTelefonu = @IsTelefonu,
                                GsmTelefonu = @GsmTelefonu,
                                Fax = @Fax,
                                VD = @VD,
                                VN = @VN,
                                Adres = @Adres,
                                OzelNotlar = @OzelNotlar
                            WHERE ToptanciID = @ToptanciID", conn);
                        cmd.Parameters.AddWithValue("@ToptanciID", mevcutToptanciID);
                    }
                    else
                    {
                        cmd = new SQLiteCommand(@"
                            INSERT INTO Toptancilar
                            (ToptanciAdi, SirketYetkilisi, EPosta, InternetAdresi, IsTelefonu, GsmTelefonu, Fax, VD, VN, Adres, OzelNotlar, ToptanciBorc)
                            VALUES
                            (@ToptanciAdi, @SirketYetkilisi, @EPosta, @InternetAdresi, @IsTelefonu, @GsmTelefonu, @Fax, @VD, @VN, @Adres, @OzelNotlar, 0)", conn);
                    }

                    cmd.Parameters.AddWithValue("@ToptanciAdi", txtToptancıAdı.Text.Trim());
                    cmd.Parameters.AddWithValue("@SirketYetkilisi", txtSirketYetkilisi.Text.Trim());
                    cmd.Parameters.AddWithValue("@EPosta", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@InternetAdresi", txtInsternetAdresi.Text.Trim());
                    cmd.Parameters.AddWithValue("@IsTelefonu", txtİsTelefonu.Text.Trim());
                    cmd.Parameters.AddWithValue("@GsmTelefonu", txtGsmTelefonu.Text.Trim());
                    cmd.Parameters.AddWithValue("@Fax", txtFax.Text.Trim());
                    cmd.Parameters.AddWithValue("@VD", txtVergiDairesi.Text.Trim());
                    cmd.Parameters.AddWithValue("@VN", txtVergİNumarası.Text.Trim());
                    cmd.Parameters.AddWithValue("@Adres", txtAdres.Text.Trim());
                    cmd.Parameters.AddWithValue("@OzelNotlar", txtÖzelNotlar.Text.Trim());

                    int sonuc = cmd.ExecuteNonQuery();

                    if (sonuc > 0)
                    {
                        MessageBox.Show(guncellemeModu ? "Bilgiler güncellendi." : "Yeni toptancı eklendi.",
                                        "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("İşlem başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToptancıEkle_Load(object sender, EventArgs e)
        {

        }
    }
}