using DevExpress.XtraEditors;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static DevExpress.Data.Helpers.ExpressiveSortInfo;

namespace GirisEkranı
{
    public partial class Satısİslemi : BaseForm
    {
        SQLiteConnection conn = new SQLiteConnection("Data Source=StokMaster.db;Version=3;");
        private DataRow secilenMusteri;


        private EkranKlavyesi keyboard;

        public Satısİslemi()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MusteriBul musteriBul = new MusteriBul();
            if (musteriBul.ShowDialog() == DialogResult.OK && musteriBul.SecilenMusteri != null)
            {
                secilenMusteri = musteriBul.SecilenMusteri;

               
                txtMusteriAdı.Text = secilenMusteri["Adi"].ToString();
                txtMusteriSoyisim.Text = secilenMusteri["Soyadi"].ToString();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Satış İşlemi İptal Edildi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtMiktar.Text = "";
            txtAlınanPara.Text = 0.ToString("N2");
            txtParaÜstü.Text = 0.ToString("N2");
            lblToplamTutar.Text = 0.ToString("N2");

            txtMusteriAdı.Clear();
            txtMusteriSoyisim.Clear();

            dataGridView1.DataSource = null;  

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ÜrünAraSil urunAra = new ÜrünAraSil(this);
            if (urunAra.ShowDialog() == DialogResult.OK && urunAra.SecilenUrun != null)
            {
                DataRow urun = urunAra.SecilenUrun;

                DataTable dt;
                if (dataGridView1.DataSource == null)
                {
                    dt = new DataTable();
                    dt.Columns.Add("BarkodNo");
                    dt.Columns.Add("UrunAdi");
                    dt.Columns.Add("SatisFiyati", typeof(decimal));
                    dt.Columns.Add("Miktar", typeof(int));
                    dt.Columns.Add("Tutar", typeof(decimal));
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    dt = (DataTable)dataGridView1.DataSource;
                }

                string barkod = urun["BarkodNo"].ToString();
                DataRow mevcutSatir = dt.Rows.Cast<DataRow>().FirstOrDefault(row => row["BarkodNo"].ToString() == barkod);

                if (mevcutSatir != null)
                {
                    int mevcutMiktar = Convert.ToInt32(mevcutSatir["Miktar"]);
                    decimal fiyat = Convert.ToDecimal(mevcutSatir["SatisFiyati"]);
                    mevcutSatir["Miktar"] = mevcutMiktar + 1;
                    mevcutSatir["Tutar"] = fiyat * (mevcutMiktar + 1);
                }
                else
                {
                    DataRow newRow = dt.NewRow();
                    newRow["BarkodNo"] = urun["BarkodNo"];
                    newRow["UrunAdi"] = urun["UrunAdi"];
                    newRow["SatisFiyati"] = urun["SatisFiyati"];
                    newRow["Miktar"] = 1;
                    newRow["Tutar"] = Convert.ToDecimal(urun["SatisFiyati"]);
                    dt.Rows.Add(newRow);
                }


                ToplamTutariGuncelle(); 

                lblToplamTutar.Text = Convert.ToDecimal(urun["SatisFiyati"]).ToString("C2");


            }
        }

        private void Satısİslemi_Load(object sender, EventArgs e)
        {

            decimal toplamTutar = 0;

            /*
            if (Row.Cells["SatisFiyati"].Value != null && Row.Cells["MevcutStokMiktari"].Value != null)
            {
                decimal fiyat = Convert.ToDecimal(row.Cells["SatisFiyati"].Value);
                int miktar = Convert.ToInt32(row.Cells["MevcutStokMiktari"].Value);
                toplamTutar += fiyat * miktar;
            }
            */



            lblToplamTutar.Text = toplamTutar.ToString("C2"); // ₺ formatında göstermek için
        }

        private void btnNakitSatıs_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 ||
        !int.TryParse(txtMiktar.Text, out int miktar) || miktar <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir ürün ve miktar girin.");
                return;
            }

            var row = dataGridView1.SelectedRows[0];
            string barkod = row.Cells["BarkodNo"].Value.ToString();
            string urunAdi = row.Cells["UrunAdi"].Value.ToString();
            decimal fiyat = Convert.ToDecimal(row.Cells["SatisFiyati"].Value);

           
            if (secilenMusteri == null)
            {
                MessageBox.Show("Lütfen önce bir müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object musteriID = secilenMusteri["MusteriID"];

            conn.Open();
            var transaction = conn.BeginTransaction();

            try
            {
                var stokCmd = new SQLiteCommand("SELECT MevcutStokMiktari FROM Urunler WHERE BarkodNo = @Barkod", conn);
                stokCmd.Parameters.AddWithValue("@Barkod", barkod);
                int stok = Convert.ToInt32(stokCmd.ExecuteScalar());
                if (stok < miktar) throw new Exception("Yetersiz stok.");

                var cmd = new SQLiteCommand(@"
            INSERT INTO Satis (Tarih, MusteriID, ToplamTutar, OdemeTipi, AlinanPara, ParaUstu, Kasiyer)
            VALUES (@Tarih, @MusteriID, @ToplamTutar, 'Nakit', @AlinanPara, @ParaUstu, @Kasiyer);
            SELECT last_insert_rowid();", conn);

                cmd.Parameters.AddWithValue("@Tarih", DateTime.Now);
                cmd.Parameters.AddWithValue("@MusteriID", musteriID);
                cmd.Parameters.AddWithValue("@ToplamTutar", miktar * fiyat);
                cmd.Parameters.AddWithValue("@AlinanPara", Convert.ToDecimal(txtAlınanPara.Text));
                cmd.Parameters.AddWithValue("@ParaUstu", Convert.ToDecimal(txtParaÜstü.Text));
                cmd.Parameters.AddWithValue("@Kasiyer", cmboxKasiyer.SelectedItem?.ToString() ?? "");
                long satisID = (long)cmd.ExecuteScalar();

                var detayCmd = new SQLiteCommand(@"
            INSERT INTO SatisDetay (SatisID, Barkod, UrunAdi, Birim, Miktar, Fiyat, ToplamTutar, SatisTarihi)
            VALUES (@SatisID, @Barkod, @UrunAdi, 'Adet', @Miktar, @Fiyat, @ToplamTutar, @SatisTarihi);", conn);
                detayCmd.Parameters.AddWithValue("@SatisID", satisID);
                detayCmd.Parameters.AddWithValue("@Barkod", barkod);
                detayCmd.Parameters.AddWithValue("@UrunAdi", urunAdi);
                detayCmd.Parameters.AddWithValue("@Miktar", miktar);
                detayCmd.Parameters.AddWithValue("@Fiyat", fiyat);
                detayCmd.Parameters.AddWithValue("@ToplamTutar", miktar * fiyat);
                detayCmd.Parameters.AddWithValue("@SatisTarihi", DateTime.Now);
                detayCmd.ExecuteNonQuery();

                var stokUpdate = new SQLiteCommand("UPDATE Urunler SET MevcutStokMiktari = MevcutStokMiktari - @Miktar WHERE BarkodNo = @Barkod", conn);
                stokUpdate.Parameters.AddWithValue("@Miktar", miktar);
                stokUpdate.Parameters.AddWithValue("@Barkod", barkod);
                stokUpdate.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Satış başarılı.");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (keyboard == null || keyboard.IsDisposed)
            {
                keyboard = new EkranKlavyesi();
            }
        }

        private void btnEkranKlavyesi_Click(object sender, EventArgs e)
        {
            if (GlobalForms.KlavyeForm == null || GlobalForms.KlavyeForm.IsDisposed)
            {
                GlobalForms.KlavyeForm = new EkranKlavyesi();
                GlobalForms.KlavyeForm.TopMost = true;
                GlobalForms.KlavyeForm.Show();
            }
            else
            {
                GlobalForms.KlavyeForm.BringToFront();
            }
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow seciliSatir = dataGridView1.SelectedRows[0];
                if (decimal.TryParse(seciliSatir.Cells["SatisFiyati"].Value?.ToString(), out decimal fiyat) &&
                    int.TryParse(txtMiktar.Text, out int miktar) && miktar > 0)
                {
                    lblToplamTutar.Text = (fiyat * miktar).ToString("N2");
                }
                else
                {
                    lblToplamTutar.Text = "0,00";
                }
            }
        }

        private void btnVeresiyeSatıs_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen satmak istediğiniz ürünü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMiktar.Text, out int miktar) || miktar <= 0)
            {
                MessageBox.Show("Geçerli bir miktar giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (secilenMusteri == null)
            {
                MessageBox.Show("Lütfen önce bir müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object musteriID = secilenMusteri["MusteriID"];

            DataGridViewRow seciliSatir = dataGridView1.SelectedRows[0];
            string barkod = seciliSatir.Cells["BarkodNo"].Value?.ToString();
            string urunAdi = seciliSatir.Cells["UrunAdi"].Value?.ToString();
            decimal fiyat = Convert.ToDecimal(seciliSatir.Cells["SatisFiyati"].Value);
            string birim = "Adet";

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=StokMaster.db;Version=3;"))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        using (var stokKontrolCmd = new SQLiteCommand("SELECT MevcutStokMiktari FROM Urunler WHERE BarkodNo = @Barkod", conn))
                        {
                            stokKontrolCmd.Parameters.AddWithValue("@Barkod", barkod);
                            int mevcutStok = Convert.ToInt32(stokKontrolCmd.ExecuteScalar());

                            if (miktar > mevcutStok)
                            {
                                throw new Exception("Yeterli stok yok. Mevcut stok: " + mevcutStok);
                            }
                        }

                        var cmd = new SQLiteCommand(@"
                    INSERT INTO Satis (Tarih, MusteriID, ToplamTutar, OdemeTipi, AlinanPara, ParaUstu, Kasiyer)
                    VALUES (@Tarih, @MusteriID, @ToplamTutar, 'Veresiye', 0, 0, @Kasiyer);
                    SELECT last_insert_rowid();", conn);

                        cmd.Parameters.AddWithValue("@Tarih", DateTime.Now);
                        cmd.Parameters.AddWithValue("@MusteriID", musteriID);
                        cmd.Parameters.AddWithValue("@ToplamTutar", miktar * fiyat);
                        cmd.Parameters.AddWithValue("@Kasiyer", cmboxKasiyer.SelectedItem?.ToString() ?? "");

                        long satisID = (long)cmd.ExecuteScalar();

                        var detayCmd = new SQLiteCommand(@"
                    INSERT INTO SatisDetay (SatisID, Barkod, UrunAdi, Birim, Miktar, Fiyat, ToplamTutar, SatisTarihi)
                    VALUES (@SatisID, @Barkod, @UrunAdi, @Birim, @Miktar, @Fiyat, @ToplamTutar, @SatisTarihi);", conn);

                        detayCmd.Parameters.AddWithValue("@SatisID", satisID);
                        detayCmd.Parameters.AddWithValue("@Barkod", barkod);
                        detayCmd.Parameters.AddWithValue("@UrunAdi", urunAdi);
                        detayCmd.Parameters.AddWithValue("@Birim", birim);
                        detayCmd.Parameters.AddWithValue("@Miktar", miktar);
                        detayCmd.Parameters.AddWithValue("@Fiyat", fiyat);
                        detayCmd.Parameters.AddWithValue("@ToplamTutar", miktar * fiyat);
                        detayCmd.Parameters.AddWithValue("@SatisTarihi", DateTime.Now);
                        detayCmd.ExecuteNonQuery();

                        var updateStok = new SQLiteCommand(@"
                    UPDATE Urunler
                    SET MevcutStokMiktari = MevcutStokMiktari - @Miktar
                    WHERE BarkodNo = @Barkod", conn);

                        updateStok.Parameters.AddWithValue("@Miktar", miktar);
                        updateStok.Parameters.AddWithValue("@Barkod", barkod);
                        updateStok.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show("Veresiye satış başarıyla yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtMiktar.Text = "";
                        txtAlınanPara.Text = "0,00";
                        txtParaÜstü.Text = "0,00";
                        lblToplamTutar.Text = "0,00";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Satış yapılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public DataRow SecilenUrun { get; private set; }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SecilenUrun = ((DataTable)dataGridView1.DataSource).Rows[e.RowIndex];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow seciliSatir = dataGridView1.SelectedRows[0];
                if (decimal.TryParse(seciliSatir.Cells["SatisFiyati"].Value?.ToString(), out decimal fiyat) &&
                    int.TryParse(txtMiktar.Text, out int miktar) && miktar > 0)
                {
                    lblToplamTutar.Text = (fiyat * miktar).ToString("N2");
                }
                else
                {
                    lblToplamTutar.Text = fiyat.ToString("N2");
                }
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            EskiSatıslar eskiSatıslar = new EskiSatıslar();
            eskiSatıslar.Show();
        }

        private void btnİndirimUygula_Click(object sender, EventArgs e)
        {
            İndirimUygula indirimForm = new İndirimUygula();
            if (indirimForm.ShowDialog() == DialogResult.OK)
            {
                decimal indirimTutari = indirimForm.IndirimTutari;

                IndirimiUygula(indirimTutari);
            }
        }




        private void btnİskontoUygula_Click(object sender, EventArgs e)
        {

            İskontoUygula iskontoForm = new İskontoUygula();
            if (iskontoForm.ShowDialog() == DialogResult.OK)
            {
                decimal oran = iskontoForm.IskontoOrani;
                IskontoyuUygula(oran);
            }
        }

        private void IndirimiUygula(decimal indirim)
        {
            decimal toplam = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                int miktar = Convert.ToInt32(row.Cells["Miktar"].Value);
                decimal fiyat = Convert.ToDecimal(row.Cells["SatisFiyati"].Value);

                toplam += fiyat * miktar;
            }

            if (indirim > toplam)
            {
                MessageBox.Show("İndirim, toplamdan büyük olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal indirimOrani = indirim / toplam;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                int miktar = Convert.ToInt32(row.Cells["Miktar"].Value);
                decimal fiyat = Convert.ToDecimal(row.Cells["SatisFiyati"].Value);

                decimal yeniTutar = fiyat * miktar * (1 - indirimOrani);
                row.Cells["Tutar"].Value = Math.Round(yeniTutar, 2);
            }

            ToplamTutariGuncelle();
        }

        private void IskontoyuUygula(decimal iskontoOrani)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                int miktar = Convert.ToInt32(row.Cells["Miktar"].Value);
                decimal fiyat = Convert.ToDecimal(row.Cells["SatisFiyati"].Value);

                decimal yeniTutar = fiyat * miktar * (1 - iskontoOrani);

                row.Cells["Tutar"].Value = Math.Round(yeniTutar, 2);
            }

           
            ToplamTutariGuncelle();
        }


        private void ToplamTutariGuncelle()
        {
            decimal toplam = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                decimal satirTutar = Convert.ToDecimal(row.Cells["Tutar"].Value);

                toplam += satirTutar;
            }

            lblToplamTutar.Text = toplam.ToString("C2");
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
        }

        private void btnTaksit_Click(object sender, EventArgs e)
        {
            if (secilenMusteri == null)
            {
                MessageBox.Show("Lütfen önce bir müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TaksitYap taksitForm = new TaksitYap();
            if (taksitForm.ShowDialog() == DialogResult.OK)
            {
                int taksitSayisi = taksitForm.TaksitSayisi;

                if (taksitSayisi <= 0)
                {
                    MessageBox.Show("Lütfen geçerli bir taksit sayısı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SatisiTaksitliGerceklestir(taksitSayisi);
            }
        }

        private void SatisiTaksitliGerceklestir(int taksitSayisi)
        {

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Sepet boş. Lütfen ürün ekleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Müşteri kontrolü
            if (secilenMusteri == null)
            {
                MessageBox.Show("Lütfen önce bir müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object musteriID = secilenMusteri["MusteriID"];

            decimal toplamTutar = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    toplamTutar += Convert.ToDecimal(row.Cells["Tutar"].Value);
                }
            }

            decimal taksitTutar = toplamTutar / taksitSayisi;

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=StokMaster.db;Version=3;"))
            {
                conn.Open();
                using (SQLiteTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string insertSatis = @"
                    INSERT INTO Satis (Tarih, MusteriID, ToplamTutar, OdemeTipi, AlinanPara, ParaUstu, Kasiyer, TaksitSayisi, TaksitTutar)
                    VALUES (@Tarih, @MusteriID, @ToplamTutar, 'Taksit', 0, 0, @Kasiyer, @TaksitSayisi, @TaksitTutar);
                    SELECT last_insert_rowid();";

                        SQLiteCommand cmd = new SQLiteCommand(insertSatis, conn, transaction);
                        cmd.Parameters.AddWithValue("@Tarih", DateTime.Now);
                        cmd.Parameters.AddWithValue("@MusteriID", musteriID);
                        cmd.Parameters.AddWithValue("@ToplamTutar", toplamTutar);
                        cmd.Parameters.AddWithValue("@Kasiyer", cmboxKasiyer.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@TaksitSayisi", taksitSayisi);
                        cmd.Parameters.AddWithValue("@TaksitTutar", taksitTutar);

                        long satisID = (long)(cmd.ExecuteScalar() ?? 0);

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.IsNewRow) continue;

                            string barkod = row.Cells["BarkodNo"].Value.ToString();
                            string urunAdi = row.Cells["UrunAdi"].Value.ToString();
                            decimal fiyat = Convert.ToDecimal(row.Cells["SatisFiyati"].Value);
                            int miktar = Convert.ToInt32(row.Cells["Miktar"].Value);
                            decimal tutar = Convert.ToDecimal(row.Cells["Tutar"].Value);

                            SQLiteCommand detayCmd = new SQLiteCommand(@"
                        INSERT INTO SatisDetay (SatisID, Barkod, UrunAdi, Birim, Miktar, Fiyat, ToplamTutar, SatisTarihi)
                        VALUES (@SatisID, @Barkod, @UrunAdi, 'Adet', @Miktar, @Fiyat, @ToplamTutar, @SatisTarihi);", conn, transaction);

                            detayCmd.Parameters.AddWithValue("@SatisID", satisID);
                            detayCmd.Parameters.AddWithValue("@Barkod", barkod);
                            detayCmd.Parameters.AddWithValue("@UrunAdi", urunAdi);
                            detayCmd.Parameters.AddWithValue("@Miktar", miktar);
                            detayCmd.Parameters.AddWithValue("@Fiyat", fiyat);
                            detayCmd.Parameters.AddWithValue("@ToplamTutar", tutar);
                            detayCmd.Parameters.AddWithValue("@SatisTarihi", DateTime.Now);
                            detayCmd.ExecuteNonQuery();

                            SQLiteCommand stokGuncelle = new SQLiteCommand(@"
                        UPDATE Urunler
                        SET MevcutStokMiktari = MevcutStokMiktari - @Miktar
                        WHERE BarkodNo = @Barkod", conn, transaction);

                            stokGuncelle.Parameters.AddWithValue("@Miktar", miktar);
                            stokGuncelle.Parameters.AddWithValue("@Barkod", barkod);
                            stokGuncelle.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show($"Satış başarıyla {taksitSayisi} taksite bölündü. Her taksit: {taksitTutar:C2}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView1.DataSource = null;
                        lblToplamTutar.Text = "0,00";
                        txtMiktar.Text = "";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



    }
}