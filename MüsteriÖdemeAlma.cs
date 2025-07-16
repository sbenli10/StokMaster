using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirisEkranı
{
    public partial class MüsteriÖdemeAlma : BaseForm
    {
        private string musteriAdi;
        private decimal toplamBorc;
        private int musteriId;

        public MüsteriÖdemeAlma()
        {
            InitializeComponent();
        }
        public MüsteriÖdemeAlma(int musteriID, string adi, decimal toplamborc)
        {
            InitializeComponent();
            musteriId = musteriID;
            musteriAdi = adi;
            decimal.TryParse(toplamborc.ToString(), out toplamBorc);
        }

        private void MüsteriÖdemeAlma_Load(object sender, EventArgs e)
        {
            txtMusteriAdı.Text = musteriAdi;
            txtToplamBorc.Text = toplamBorc.ToString("C2");
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }


        private void ToplamBorcGüncelle(int musteriID, decimal yeniBorc)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=StokMaster.db;Version=3;"))
            {
                string query = "UPDATE Musteri SET ToplamBorc = @YeniBorc WHERE MusteriID = @MusteriID";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@YeniBorc", yeniBorc);
                    cmd.Parameters.AddWithValue("@MusteriID", musteriID);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void LogOdeme(int musteriID, string musteriAdi, decimal tutar, string yontem, string aciklama)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=stok.db;Version=3;"))
            {
                string query = @"INSERT INTO MusteriOdemeLog 
                  (MusteriID, MusteriAdi, OdemeTarihi, OdemeTutari, OdemeYontemi, Aciklama)
                  VALUES (@MusteriID, @MusteriAdi, @OdemeTarihi, @OdemeTutari, @OdemeYontemi, @Aciklama)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MusteriID", musteriID);
                    cmd.Parameters.AddWithValue("@MusteriAdi", musteriAdi);
                    cmd.Parameters.AddWithValue("@OdemeTarihi", DateTime.Now);
                    cmd.Parameters.AddWithValue("@OdemeTutari", tutar);
                    cmd.Parameters.AddWithValue("@OdemeYontemi", yontem);
                    cmd.Parameters.AddWithValue("@Aciklama", aciklama);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtÖdemeTutarı.Text, out decimal odemeMiktari))
            {
                MessageBox.Show("Lütfen geçerli bir ödeme tutarı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!radioBtnNakit.Checked && !radioBtnKrediKartı.Checked && !radioBtnHavale.Checked)
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

            string secilenOdemeYontemi = radioBtnNakit.Checked ? "Nakit" :
                                          radioBtnKrediKartı.Checked ? "Kredi Kartı" :
                                          "Havale";

            ToplamBorcGüncelle(musteriId, kalanBorc);
            LogOdeme(musteriId, musteriAdi, odemeMiktari, secilenOdemeYontemi, txtAcıklama.Text);

            MessageBox.Show($"Ödeme işlemi başarılı!\nKalan Borç: {kalanBorc:C2}\nÖdeme Türü: {secilenOdemeYontemi}\nÖdeme Tarihi: {msktxtTarih.Text}",
                            "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
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
            e.Graphics.DrawString(txtMusteriAdı.Text, regularFont, Brushes.Black, valueX, lineY);
            lineY += 25;

            e.Graphics.DrawString("Toplam Borç:", headerFont, Brushes.Black, labelX, lineY);
            e.Graphics.DrawString(txtToplamBorc.Text, regularFont, Brushes.Black, valueX, lineY);
            lineY += 25;

            e.Graphics.DrawString("Tarih:", headerFont, Brushes.Black, labelX, lineY);
            e.Graphics.DrawString(msktxtTarih.Text, regularFont, Brushes.Black, valueX, lineY);
            lineY += 25;

            e.Graphics.DrawString("Ödeme Tutarı:", headerFont, Brushes.Black, labelX, lineY);
            e.Graphics.DrawString(txtÖdemeTutarı.Text + " ₺", regularFont, Brushes.Black, valueX, lineY);
            lineY += 25;

            e.Graphics.DrawString("Açıklama:", headerFont, Brushes.Black, labelX, lineY);
            e.Graphics.DrawString(txtAcıklama.Text, regularFont, Brushes.Black, valueX, lineY);
            lineY += 25;

            string odemeTuru = radioBtnNakit.Checked ? "Nakit" :
                               radioBtnKrediKartı.Checked ? "Kredi Kartı" :
                               radioBtnHavale.Checked ? "Havale" : "Belirtilmedi";

            e.Graphics.DrawString("Ödeme Türü:", headerFont, Brushes.Black, labelX, lineY);
            e.Graphics.DrawString(odemeTuru, regularFont, Brushes.Black, valueX, lineY);
            offsetY += 200;

         
            e.Graphics.DrawString("Teşekkür ederiz.", italicFont, Brushes.DarkGreen, startX, startY + offsetY + 10);
            e.Graphics.DrawString("Yetkili İmza: ___________________", regularFont, Brushes.Black, startX + 350, startY + offsetY + 30);
        }


        private void btnYazdır_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMusteriAdı.Text) || string.IsNullOrWhiteSpace(txtÖdemeTutarı.Text))
            {
                MessageBox.Show("Yazdırmadan önce ödeme bilgilerini doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }
    }
}