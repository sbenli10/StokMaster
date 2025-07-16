using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirisEkranı
{
    public partial class MusteriBorc : BaseForm
    {
        public int MusteriID { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public decimal KalanTaksitToplam { get; set; }
        public decimal ToplamBorc { get; set; }
        public decimal VeresiyeToplam { get; set; }

        public MusteriBorc(int musteriID, string musteriAdi, string musteriSoyadi, decimal kalanTaksitToplam, decimal toplamBorc, decimal veresiyeToplam)
        {
            InitializeComponent();
            MusteriID = musteriID;
            MusteriAdi = musteriAdi;
            MusteriSoyadi = musteriSoyadi;
            KalanTaksitToplam = kalanTaksitToplam;
            ToplamBorc = toplamBorc;
            VeresiyeToplam = veresiyeToplam;
        }

        private void MusteriBorc_Load(object sender, EventArgs e)
        {
            txtAd.Text = MusteriAdi;
            txtMusteriSoyad.Text = MusteriSoyadi;
            txtKalanTaksitToplam.Text = KalanTaksitToplam.ToString("N2");
            txtVeresiyeBorcMiktarı.Text = VeresiyeToplam.ToString("C2");
            txtÖdenmesiGerekenTutar.Text = ToplamBorc.ToString("C2");

            string connStr = "Data Source=StokMaster.db;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();

                // 1. BÖLÜM: BORÇ DETAYLARI → üstteki grid'e
                string borcQuery = @"
                SELECT 
                    s.Tarih AS 'Satış Tarihi',
                    s.OdemeTipi AS 'Ödeme Tipi',
                    s.ToplamTutar AS 'Toplam Tutar',
                    s.TaksitSayisi AS 'Taksit Sayısı',
                    s.TaksitTutar AS 'Taksit Tutarı',
                    s.AlinanPara AS 'Alınan Para',
                    s.ParaUstu AS 'Para Üstü',
                    s.Kasiyer AS 'Kasiyer'
                FROM Satis s
                WHERE s.MusteriID = @MusteriID
                ORDER BY s.Tarih DESC;";

                SQLiteCommand borcCmd = new SQLiteCommand(borcQuery, conn);
                borcCmd.Parameters.AddWithValue("@MusteriID", MusteriID);

                SQLiteDataAdapter borcAdapter = new SQLiteDataAdapter(borcCmd);
                DataTable borcTable = new DataTable();
                borcAdapter.Fill(borcTable);
                dataGridViewBorcDetay.DataSource = borcTable;

                // Formatlama
                dataGridViewBorcDetay.Columns["Toplam Tutar"].DefaultCellStyle.Format = "C2";
                dataGridViewBorcDetay.Columns["Taksit Tutarı"].DefaultCellStyle.Format = "C2";
                dataGridViewBorcDetay.Columns["Alınan Para"].DefaultCellStyle.Format = "C2";
                dataGridViewBorcDetay.Columns["Para Üstü"].DefaultCellStyle.Format = "C2";
                dataGridViewBorcDetay.Columns["Satış Tarihi"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";

                // 2. BÖLÜM: ALIŞVERİŞ DETAYLARI → alttaki grid'e
                string detayQuery = @"
                SELECT 
                    d.SatisTarihi AS 'Tarih',
                    d.Barkod AS 'Barkod',
                    d.UrunAdi AS 'Ürün',
                    d.Miktar AS 'Miktar',
                    d.Fiyat AS 'Fiyat',
                    d.ToplamTutar AS 'Tutar'
                FROM SatisDetay d
                INNER JOIN Satis s ON s.SatisID = d.SatisID
                WHERE s.MusteriID = @MusteriID
                ORDER BY d.SatisTarihi DESC;";

                SQLiteCommand detayCmd = new SQLiteCommand(detayQuery, conn);
                detayCmd.Parameters.AddWithValue("@MusteriID", MusteriID);

                SQLiteDataAdapter detayAdapter = new SQLiteDataAdapter(detayCmd);
                DataTable detayTable = new DataTable();
                detayAdapter.Fill(detayTable);
                dataGridViewAlisverisDetay.DataSource = detayTable;

                // Formatlama
                dataGridViewAlisverisDetay.Columns["Fiyat"].DefaultCellStyle.Format = "C2";
                dataGridViewAlisverisDetay.Columns["Tutar"].DefaultCellStyle.Format = "C2";
                dataGridViewAlisverisDetay.Columns["Tarih"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            }
        }

        private void btnBorcEKle_Click(object sender, EventArgs e)
        {
            MusteriBorcEkle musteriBorcEkle = new MusteriBorcEkle();
            musteriBorcEkle.Show();
        }

        private void btnTahsilatYap_Click(object sender, EventArgs e)
        {
            
            MüsteriÖdemeAlma müsteriÖdemeAlma = new MüsteriÖdemeAlma();
            müsteriÖdemeAlma.Show();
            
        }
    }
}