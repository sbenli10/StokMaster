using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class BarkodOkuyucu : DevExpress.XtraEditors.XtraForm
    {
        private string connectionString = "Data Source=StokMasterDB.db;Version=3;";
        public BarkodOkuyucu()
        {
            InitializeComponent();
        }

        private void BarkodOkuyucu_Load(object sender, EventArgs e)
        {

        }

        private void btnBarcodeOlustur_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBox1.Image = barcode.Draw(textBox1.Text, 50);
            }
            else
            {
                MessageBox.Show("Lütfen bir değer girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = barcode.Draw(textBox1.Text, 50);
        }

        private void btnBarcodeOlustur_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barcode = textBox1.Text.Trim();

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    string query = "SELECT * FROM Urunler WHERE BarkodNo = @BarkodNo";
                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@BarkodNo", barcode);
                        conn.Open();
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string urunAdi = reader["UrunAdi"].ToString();
                                string fiyat = reader["Fiyat"].ToString();
                                string stokMiktari = reader["StokMiktari"].ToString();
                                MessageBox.Show($"Ürün Adı: {urunAdi}\nFiyat: {fiyat}\nStok Miktarı: {stokMiktari}", "Ürün Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Barkod bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }

                textBox1.Clear();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
        }
    }
}
