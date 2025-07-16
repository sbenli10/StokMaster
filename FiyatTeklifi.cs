
using DevExpress.Utils.Helpers;
using DevExpress.XtraPrinting;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace GirisEkranı
{
    public partial class FiyatTeklifi : DevExpress.XtraEditors.XtraForm
    {
        private bool indirimUygulandi = false;
        private bool iskontoUygulandi = false;
        public bool IsNormalFiyatChecked => chckNormalFiyat.Checked;
        public bool IsIkinciFiyatChecked => chckİkinciFiyat.Checked;
        public DataGridView TeklifGrid => dataGridView1;


        PrintDocument printDocument = new PrintDocument();

        public FiyatTeklifi()
        {
            InitializeComponent();
        }

        private void btnUrunAdıAra_Click(object sender, EventArgs e)
        {
            if (!chckNormalFiyat.Checked && !chckİkinciFiyat.Checked)
            {
                MessageBox.Show("Lütfen önce bir fiyat türü seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ÜrünAraSil urunForm = new ÜrünAraSil(this); 
            urunForm.ShowDialog();
        }
        private void btnFiyatİptal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fiyat Teklifi İptal Ediliyor Emin Misin?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            lblToplamTutar.Text = "0,00";
            dataGridView1.Rows.Clear();
        //    txtBarkodNo.Clear();
        }
        private void FiyatTeklifi_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("BarkodNo", "Barkod No");
            dataGridView1.Columns.Add("UrunAdi", "Ürün Adı");
            dataGridView1.Columns.Add("Fiyati", "Fiyat");
            dataGridView1.Columns.Add("Miktar", "Miktar");
            dataGridView1.Columns.Add("Birim", "Birim");
            dataGridView1.Columns.Add("Tutar", "Tutar");
            dataGridView1.Columns.Add("UrunID", "Ürün ID");
            dataGridView1.Columns.Add("SatisFiyati", "");       
            dataGridView1.Columns.Add("IkinciSatisFiyati", ""); 

            dataGridView1.Columns["SatisFiyati"].Visible = false;
            dataGridView1.Columns["IkinciSatisFiyati"].Visible = false;

            dataGridView1.Columns.Add("OrijinalTutar", "");
            dataGridView1.Columns["OrijinalTutar"].Visible = false;


            dataGridView1.Columns["Fiyati"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Tutar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Miktar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns["Fiyati"].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns["Tutar"].DefaultCellStyle.Format = "C2";

            foreach (DataGridViewColumn col in dataGridView1.Columns)
                col.ReadOnly = true;

            dataGridView1.Columns["Miktar"].ReadOnly = false;

            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;

            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int startX = 50;
            int startY = 50;
            int offsetY = 0;

            System.Drawing.Font titleFont = new System.Drawing.Font("Arial", 26, System.Drawing.FontStyle.Bold);
            System.Drawing.Font headerFont = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            System.Drawing.Font regularFont = new System.Drawing.Font("Arial", 13, System.Drawing.FontStyle.Regular);

         
            string baslik = "FİYAT TEKLİFİ";
            SizeF titleSize = e.Graphics.MeasureString(baslik, titleFont);
            e.Graphics.DrawString(baslik, titleFont, System.Drawing.Brushes.Black, (e.PageBounds.Width - titleSize.Width) / 2, startY);
            offsetY += 80;

           
            string fiyatTuru = chckNormalFiyat.Checked ? "Normal Satış Fiyatı Geçerli" :
                               chckİkinciFiyat.Checked ? "2. Satış Fiyatı Geçerli" :
                               "Fiyat Türü Seçilmedi!";

            e.Graphics.DrawString($"Fiyat Türü: {fiyatTuru}", headerFont, System.Drawing.Brushes.Black, startX, startY + offsetY);
            offsetY += 40;

            
            string indirimBilgi = indirimUygulandi ? "İndirim Uygulandı" :
                                  iskontoUygulandi ? "İskonto Uygulandı" :
                                  "İndirim / İskonto Var";

            e.Graphics.DrawString($"İndirim/İskonto: {indirimBilgi}", headerFont, System.Drawing.Brushes.Black, startX, startY + offsetY);
            offsetY += 50;

           
            e.Graphics.DrawString("Barkod No".PadRight(18) + "Ürün Adı".PadRight(25) + "Fiyat".PadRight(12) + "Miktar".PadRight(10) + "Birim".PadRight(10) + "Tutar", headerFont, System.Drawing.Brushes.Black, startX, startY + offsetY);
            offsetY += 35;

           
            decimal toplamOrijinal = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string barkod = (row.Cells["BarkodNo"].Value ?? "").ToString();
                string urunAdi = (row.Cells["UrunAdi"].Value ?? "").ToString();
                string fiyat = (row.Cells["Fiyati"].Value ?? "").ToString();
                string miktar = (row.Cells["Miktar"].Value ?? "").ToString();
                string birim = (row.Cells["Birim"].Value ?? "").ToString();
                string tutar = (row.Cells["Tutar"].Value ?? "").ToString();

                string line = barkod.PadRight(18) + urunAdi.PadRight(25) + fiyat.PadRight(12) + miktar.PadRight(10) + birim.PadRight(10) + tutar;
                e.Graphics.DrawString(line, regularFont, System.Drawing.Brushes.Black, startX, startY + offsetY);
                offsetY += 30;

                
                if (row.Cells["OrijinalTutar"].Value != null && decimal.TryParse(row.Cells["OrijinalTutar"].Value.ToString(), out decimal orijinalTutar))
                {
                    toplamOrijinal += orijinalTutar;
                }
                else
                {
                    
                    if (decimal.TryParse(row.Cells["Tutar"].Value?.ToString(), out decimal tutarValue))
                        toplamOrijinal += tutarValue;
                }
            }

            
            offsetY += 30;

         
            decimal toplamGuncel = 0;
            string toplamText = lblToplamTutar.Text.Replace("₺", "").Replace(".", "").Replace(",", ".").Trim();

            decimal.TryParse(toplamText, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out toplamGuncel);

            
            decimal indirimTutar = toplamOrijinal - toplamGuncel;

           
            e.Graphics.DrawString($"TOPLAM: ₺{toplamGuncel:F2}", new System.Drawing.Font("Arial", 18, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Black, startX, startY + offsetY);
            offsetY += 40;

            
            if (Math.Abs(indirimTutar) > 0.01m)
            {
                e.Graphics.DrawString($"İNDİRİM TUTARI: ₺{indirimTutar:F2}", new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Red, startX, startY + offsetY);
            }
        }


        public void UrunEkleFromAraSil(DataGridViewRow seciliRow)
        {
            string barkod = seciliRow.Cells["BarkodNo"].Value?.ToString();
            string urunAdi = seciliRow.Cells["UrunAdi"].Value?.ToString();
            string birim = seciliRow.Cells["OlcuBirimi"].Value?.ToString();
            int urunID = Convert.ToInt32(seciliRow.Cells["UrunID"].Value);

            decimal fiyat = chckNormalFiyat.Checked
                ? Convert.ToDecimal(seciliRow.Cells["SatisFiyati"].Value)
                : Convert.ToDecimal(seciliRow.Cells["IkinciSatisFiyati"].Value);

            int miktar = 1;
            decimal tutar = fiyat * miktar;

            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["BarkodNo"].Value?.ToString() == barkod)
                {
                    int mevcutMiktar = Convert.ToInt32(row.Cells["Miktar"].Value);
                    mevcutMiktar += miktar;
                    row.Cells["Miktar"].Value = mevcutMiktar;
                    row.Cells["Tutar"].Value = fiyat * mevcutMiktar;
                    ToplamTutariGuncelle();
                    return;
                }
            }

          
            dataGridView1.Rows.Add(
                barkod,
                urunAdi,
                fiyat,
                miktar,
                birim,
                tutar,
                urunID,
                seciliRow.Cells["SatisFiyati"].Value,
                seciliRow.Cells["IkinciSatisFiyati"].Value,
                tutar
            );

            ToplamTutariGuncelle(); 
        }



        private void ToplamTutariGuncelle()
        {
            decimal toplam = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                int miktar = Convert.ToInt32(row.Cells["Miktar"].Value);
                decimal fiyat = Convert.ToDecimal(row.Cells["Fiyati"].Value); 

                decimal tutar = fiyat * miktar;
                row.Cells["Tutar"].Value = Math.Round(tutar, 2);

                toplam += tutar;
            }

            lblToplamTutar.Text = toplam.ToString("C2"); 
        }




        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Miktar")
            {
                var row = dataGridView1.Rows[e.RowIndex];
                if (int.TryParse(row.Cells["Miktar"].Value?.ToString(), out int miktar))
                {
                    decimal fiyat = Convert.ToDecimal(row.Cells["Fiyati"].Value);
                    row.Cells["Tutar"].Value = miktar * fiyat;
                    ToplamTutariGuncelle();
                }
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["Miktar"].Index)
            {
                TextBox tb = e.Control as TextBox;
                tb.KeyPress -= Tb_KeyPress;
                tb.KeyPress += Tb_KeyPress;
            }
        }

        private void Tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void chckNormalFiyat_CheckedChanged(object sender, EventArgs e)
        {
            if (chckNormalFiyat.Checked)
                chckİkinciFiyat.Checked = false;
        }

        private void chckİkinciFiyat_CheckedChanged(object sender, EventArgs e)
        {
            if (chckİkinciFiyat.Checked)
                chckNormalFiyat.Checked = false;
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

        private void IndirimiUygula(decimal indirim)
        {
            decimal toplam = 0;


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                int miktar = Convert.ToInt32(row.Cells["Miktar"].Value);
                decimal fiyat;

                if (chckNormalFiyat.Checked)
                    fiyat = Convert.ToDecimal(row.Cells["SatisFiyati"].Value);
                else
                    fiyat = Convert.ToDecimal(row.Cells["IkinciSatisFiyati"].Value);

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
                decimal fiyat;

                if (chckNormalFiyat.Checked)
                    fiyat = Convert.ToDecimal(row.Cells["SatisFiyati"].Value);
                else
                    fiyat = Convert.ToDecimal(row.Cells["IkinciSatisFiyati"].Value);

                decimal yeniTutar = fiyat * miktar * (1 - indirimOrani);
                row.Cells["Tutar"].Value = Math.Round(yeniTutar, 2);
            }

            
            decimal netToplam = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                netToplam += Convert.ToDecimal(row.Cells["Tutar"].Value);
            }

            lblToplamTutar.Text = netToplam.ToString("C2");
        }

        private void btnİskontoUygula_Click(object sender, EventArgs e)
        {
            if (indirimUygulandi)
            {
                MessageBox.Show("İndirim zaten uygulanmış. Aynı anda iskonto uygulanamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            İskontoUygula iskontoForm = new İskontoUygula();
            if (iskontoForm.ShowDialog() == DialogResult.OK)
            {
                decimal oran = iskontoForm.IskontoOrani;
                IskontoyuUygula(oran);
            }
        }

        private void IskontoyuUygula(decimal iskontoOrani)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                int miktar = Convert.ToInt32(row.Cells["Miktar"].Value);

             
                decimal orijinalFiyat;
                if (chckNormalFiyat.Checked)
                    orijinalFiyat = Convert.ToDecimal(row.Cells["SatisFiyati"].Value);
                else
                    orijinalFiyat = Convert.ToDecimal(row.Cells["IkinciSatisFiyati"].Value);

           
                decimal iskontoFiyati = Math.Round(orijinalFiyat * (1 - iskontoOrani), 2);

                decimal yeniTutar = iskontoFiyati * miktar;

         
                row.Cells["Fiyati"].Value = iskontoFiyati;

                row.Cells["Tutar"].Value = Math.Round(yeniTutar, 2);
            }

            iskontoUygulandi = true;

            ToplamTutariGuncelle(); 
        }



        private void btnİndirimİptal_Click(object sender, EventArgs e)
        {
            if (!indirimUygulandi && !iskontoUygulandi)
            {
                MessageBox.Show("Uygulanmış bir indirim veya iskonto bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["OrijinalTutar"].Value != null)
                {
                    decimal orijinalTutar = Convert.ToDecimal(row.Cells["OrijinalTutar"].Value);
                    row.Cells["Tutar"].Value = orijinalTutar;
                }
            }

            indirimUygulandi = false;
            iskontoUygulandi = false;

            ToplamTutariGuncelle();
            MessageBox.Show("İndirim ve iskonto iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTeklifiKaydet_Click(object sender, EventArgs e)
        {
            decimal toplamTutar = 0;
            decimal indirimTutar = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    toplamTutar += Convert.ToDecimal(row.Cells["Tutar"].Value);
                }
            }

            if (indirimUygulandi)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        decimal orijinal = Convert.ToDecimal(row.Cells["OrijinalTutar"].Value);
                        decimal guncel = Convert.ToDecimal(row.Cells["Tutar"].Value);
                        indirimTutar += (orijinal - guncel);
                    }
                }
            }

            string connStr = "Data Source=StokMasterDB.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                using (SQLiteTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        // Teklif Ekle
                        string insertTeklif = @"
                    INSERT INTO Teklifler (TeklifTarihi, ToplamTutar, IndirimTutar, Aciklama)
                    VALUES (@Tarih, @Toplam, @Indirim, @Aciklama);
                    SELECT last_insert_rowid();";

                        using (SQLiteCommand cmd = new SQLiteCommand(insertTeklif, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@Tarih", DateTime.Now);
                            cmd.Parameters.AddWithValue("@Toplam", toplamTutar);
                            cmd.Parameters.AddWithValue("@Indirim", indirimTutar);
                            cmd.Parameters.AddWithValue("@Aciklama", "Fiyat teklifi - müşteri adı vb");

                            long teklifID = (long)cmd.ExecuteScalar();

                            // Detay Ekle
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.IsNewRow) continue;

                                string insertDetay = @"
                            INSERT INTO TeklifDetay (TeklifID, UrunID, BarkodNo, UrunAdi, Birim, Fiyat, Miktar)
                            VALUES (@TeklifID, @UrunID, @Barkod, @UrunAdi, @Birim, @Fiyat, @Miktar);";

                                using (SQLiteCommand detayCmd = new SQLiteCommand(insertDetay, conn, trans))
                                {
                                    detayCmd.Parameters.AddWithValue("@TeklifID", teklifID);
                                    detayCmd.Parameters.AddWithValue("@UrunID", row.Cells["UrunID"].Value);
                                    detayCmd.Parameters.AddWithValue("@Barkod", row.Cells["BarkodNo"].Value);
                                    detayCmd.Parameters.AddWithValue("@UrunAdi", row.Cells["UrunAdi"].Value);
                                    detayCmd.Parameters.AddWithValue("@Birim", row.Cells["Birim"].Value);
                                    detayCmd.Parameters.AddWithValue("@Fiyat", row.Cells["Fiyati"].Value);
                                    detayCmd.Parameters.AddWithValue("@Miktar", row.Cells["Miktar"].Value);

                                    detayCmd.ExecuteNonQuery();
                                }
                            }

                            trans.Commit();
                            MessageBox.Show("Fiyat teklifi başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Kayıt başarısız: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnTeklifiYazdır_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument;
            printPreviewDialog1.ShowDialog();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close(); 
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
           
        }
    }
}