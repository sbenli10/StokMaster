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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirisEkranı
{
    public partial class ToptancıOdemeAl : BaseForm
    {
        private int toptanciID;
        private string toptanciAdi;
        private decimal toplamBorc;
        public ToptancıOdemeAl(int id, string adi, decimal borc)
        {
            InitializeComponent();
            toptanciID = id;
            toptanciAdi = adi;
            toplamBorc = borc;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAcıklama.Text) || string.IsNullOrWhiteSpace(txtOdemeTutarı.Text))
            {
                MessageBox.Show("Yazdırmadan önce ödeme bilgilerini doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }

        private void ToptancıOdemeAl_Load(object sender, EventArgs e)
        {
            timer1.Start();
            txtToptancıAdı.Text = toptanciAdi;
            txtToplamBorc.Text = toplamBorc.ToString("C2");
            maskedTextBox1.Text = DateTime.Now.ToShortDateString();
            txtSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void ToplamBorcGuncelle(int toptanciId, decimal yeniBorc)
        {
            try
            {
                using (var conn = new SQLiteConnection($"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StokMaster.db")};Version=3;"))
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
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtOdemeTutarı.Text, out decimal odemeMiktari))
                {
                    MessageBox.Show("Lütfen geçerli bir ödeme tutarı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!radioButtonNakit.Checked && !radioButtonKrediKartı.Checked && !radioButtonHavale.Checked)
                {
                    MessageBox.Show("Lütfen bir ödeme yöntemi seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal kalanBorc = toplamBorc - odemeMiktari;

                if (kalanBorc < 0)
                {
                    MessageBox.Show("Ödeme tutarı toplam borçtan fazla olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string secilenOdemeYontemi = radioButtonNakit.Checked ? "Nakit" :
                                              radioButtonKrediKartı.Checked ? "Kredi Kartı" :
                                              "Havale";

                using (var connection = new SQLiteConnection($"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StokMaster.db")};Version=3;"))
                {
                    string query = @"INSERT INTO ToptanciOdemeLog 
                            (ToptanciID, ToptanciAdi, OdemeTarihi, OdemeSaati, OdemeTutari, OdemeYontemi, Aciklama, KayitTarihi)
                            VALUES (@ToptanciID, @ToptanciAdi, @OdemeTarihi, @OdemeSaati, @OdemeTutari, @OdemeYontemi, @Aciklama, @KayitTarihi)";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ToptanciID", toptanciID);
                        cmd.Parameters.AddWithValue("@ToptanciAdi", toptanciAdi);
                        cmd.Parameters.AddWithValue("@OdemeTarihi", DateTime.Parse(maskedTextBox1.Text));
                        cmd.Parameters.AddWithValue("@OdemeSaati", DateTime.Now.ToLongTimeString());
                        cmd.Parameters.AddWithValue("@OdemeTutari", odemeMiktari);
                        cmd.Parameters.AddWithValue("@OdemeYontemi", secilenOdemeYontemi);
                        cmd.Parameters.AddWithValue("@Aciklama", txtAcıklama.Text);
                        cmd.Parameters.AddWithValue("@KayitTarihi", DateTime.Now);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                ToplamBorcGuncelle(toptanciID, kalanBorc);

                MessageBox.Show($"Ödeme işlemi başarılı!\nKalan Borç: {kalanBorc:C2}\nÖdeme Türü: {secilenOdemeYontemi}",
                                "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtSaat.Text = DateTime.Now.ToLongTimeString();

        }

        private void txtSaat_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int startX = 50;
            int startY = 50;
            int offsetY = 0;

            Font titleFont = new Font("Arial", 20, FontStyle.Bold);
            Font headerFont = new Font("Arial", 11, FontStyle.Bold);
            Font regularFont = new Font("Arial", 11);
            Font italicFont = new Font("Arial", 10, FontStyle.Italic);

            Pen boxPen = new Pen(Color.Gray);

   
            e.Graphics.DrawString("STOKMASTER LTD. ŞTİ.", headerFont, Brushes.Black, startX, startY);
            e.Graphics.DrawString("Tel: (212) 000 00 00", regularFont, Brushes.Black, startX, startY + 20);
            e.Graphics.DrawString("Tarih: " + DateTime.Now.ToShortDateString(), regularFont, Brushes.Black, startX + 400, startY);
            offsetY += 60;

         
            string baslik = "ÖDEME BİLGİSİ";
            SizeF titleSize = e.Graphics.MeasureString(baslik, titleFont);
            e.Graphics.DrawString(baslik, titleFont, Brushes.Black, (e.PageBounds.Width - titleSize.Width) / 2, startY + offsetY);
            offsetY += 60;

      
            Rectangle infoBox = new Rectangle(startX, startY + offsetY, 500, 180);
            e.Graphics.DrawRectangle(boxPen, infoBox);

            int labelX = startX + 10;
            int valueX = startX + 150;
            int lineY = startY + offsetY + 10;

     
            e.Graphics.DrawString("Müşteri Adı:", headerFont, Brushes.Black, labelX, lineY);
            e.Graphics.DrawString(txtToptancıAdı.Text, regularFont, Brushes.Black, valueX, lineY);
            lineY += 25;

            e.Graphics.DrawString("Toplam Borç:", headerFont, Brushes.Black, labelX, lineY);
            e.Graphics.DrawString(txtToplamBorc.Text, regularFont, Brushes.Black, valueX, lineY);
            lineY += 25;

            e.Graphics.DrawString("Tarih:", headerFont, Brushes.Black, labelX, lineY);
            e.Graphics.DrawString(maskedTextBox1.Text, regularFont, Brushes.Black, valueX, lineY);
            lineY += 25;

            e.Graphics.DrawString("Saat:", headerFont, Brushes.Black, labelX, lineY);
            e.Graphics.DrawString(txtSaat.Text, regularFont, Brushes.Black, valueX, lineY);
            lineY += 25;

            e.Graphics.DrawString("Ödeme Tutarı:", headerFont, Brushes.Black, labelX, lineY);
            e.Graphics.DrawString(txtOdemeTutarı.Text + " ₺", regularFont, Brushes.Black, valueX, lineY);
            lineY += 25;

            e.Graphics.DrawString("Açıklama:", headerFont, Brushes.Black, labelX, lineY);
            e.Graphics.DrawString(txtAcıklama.Text, regularFont, Brushes.Black, valueX, lineY);
            lineY += 25;

            string odemeTuru = radioButtonNakit.Checked ? "Nakit" :
                               radioButtonKrediKartı.Checked ? "Kredi Kartı" :
                               radioButtonHavale.Checked ? "Havale" : "Belirtilmedi";

            e.Graphics.DrawString("Ödeme Türü:", headerFont, Brushes.Black, labelX, lineY);
            e.Graphics.DrawString(odemeTuru, regularFont, Brushes.Black, valueX, lineY);
            offsetY += 200;

            
            e.Graphics.DrawString("Teşekkür ederiz.", italicFont, Brushes.DarkGreen, startX, startY + offsetY + 10);
            e.Graphics.DrawString("Yetkili İmza: ___________________", regularFont, Brushes.Black, startX + 350, startY + offsetY + 30);
        }
    }
}
