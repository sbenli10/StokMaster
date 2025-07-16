using DevExpress.CodeParser;
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
    public partial class ÜrünAraSil : BaseForm
    {

        private SQLiteConnection conn = new SQLiteConnection($"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StokMaster.db")};Version=3;");

        public delegate void ÜrünSeçildiHandler(string barkod, string isim, int stok, decimal fiyat);
        public event ÜrünSeçildiHandler ÜrünSeçildi;

        public delegate void Urunsec(
           int BarkodNo,
           string UrunAdi,
           int UrunKodu,
           string UrunGrubu,
           decimal AlisFiyatiKDVDahil,
           decimal AlisFiyatiKDVHaric,
           decimal SatisFiyati,
           decimal IkinciSatisFiyati,
           decimal KDVOrani,
           decimal MevcutStokMiktari,
           string OlcuBirimi,
           decimal AsgariStok,
           string ToptanciAdi,
           string OdemeSekli,
           DateTime KayitTarihi
       );

        public event Urunsec UrunSec;
        public event ÜrünSeçildiHandler Urunsecildi;
       
        public DataRow SecilenUrun { get; private set; }
        
        public ÜrünGirisi UrunGirisiFormu { get; set; }

        private FiyatGör _fiyatGorFormu;

        private FiyatTeklifi _fiyatTeklifi;

        private Satısİslemi satisForm;

        public ÜrünAraSil()
        {
            InitializeComponent();

        }

        public ÜrünAraSil(FiyatTeklifi fiyatTeklifiFormu)
        {
            InitializeComponent();
            _fiyatTeklifi = fiyatTeklifiFormu;
        }
        public ÜrünAraSil(FiyatGör fiyatGorFormu)
        {
            InitializeComponent(); 
            _fiyatGorFormu = fiyatGorFormu;
        }

        public ÜrünAraSil(Satısİslemi form)
        {
            InitializeComponent();
            satisForm = form;  
        }

        private void ÜrünAraSil_Load(object sender, EventArgs e)
        {
            string query = @"
            SELECT 
                u.UrunID, 
                u.BarkodNo, 
                u.UrunAdi,
                u.UrunKodu,
                g.UrunGrupAdi AS UrunGrubu, -- Grup adı buraya geldi
                u.OlcuBirimi,
                u.SatisFiyati, 
                u.IkinciSatisFiyati,
                u.MevcutStokMiktari, 
                u.AsgariStok,
                u.ToptanciAdi,     
                u.OdemeSekli
            FROM Urunler u
            LEFT JOIN UrunGrubu g ON u.UrunGrubu = g.UrunID";

            SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

          
            dataGridView1.Columns["BarkodNo"].HeaderText = "Barkod No";
            dataGridView1.Columns["UrunAdi"].HeaderText = "Ürün Adı";
            dataGridView1.Columns["UrunGrubu"].HeaderText = "Ürün Grubu"; 
            dataGridView1.Columns["SatisFiyati"].HeaderText = "Satış Fiyatı";
            dataGridView1.Columns["MevcutStokMiktari"].HeaderText = "Stok";
            dataGridView1.Columns["AsgariStok"].HeaderText = "Asgari Stok";

        }
        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string barkod = dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString();

            var cmd = new SQLiteCommand("DELETE FROM Urunler WHERE BarkodNo = @BarkodNo", conn);
            cmd.Parameters.AddWithValue("@BarkodNo", barkod);

            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            if (rowsAffected == 0)
            {
                MessageBox.Show("Silme başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            ÜrünAraSil_Load(null, null);
        }
        public void VerileriDoldur()
        {
            if (dataGridView1.CurrentRow != null)
            {
                var row = dataGridView1.CurrentRow;

                
                UrunGirisiFormu.txtBarkodNo.Text = row.Cells["BarkodNo"].Value?.ToString();
                UrunGirisiFormu.txtUrunAdi.Text = row.Cells["UrunAdi"].Value?.ToString();
                UrunGirisiFormu.txtUrunKoduAcıklama.Text = row.Cells["UrunKodu"].Value?.ToString();
                UrunGirisiFormu.txtAlısFiyatı.Text = row.Cells["SatisFiyati"].Value?.ToString();
                UrunGirisiFormu.txtİkinciAlısFiyatı.Text = row.Cells["IkinciSatisFiyati"].Value?.ToString();
                UrunGirisiFormu.txtMevcutStok.Text = row.Cells["MevcutStokMiktari"].Value?.ToString();
                UrunGirisiFormu.txtOlcuBirimi.Text = row.Cells["OlcuBirimi"].Value?.ToString();
                UrunGirisiFormu.txtAsgariStok.Text = row.Cells["AsgariStok"].Value?.ToString();

              
                string toptanciAdi = row.Cells["ToptanciAdi"].Value?.ToString();
                string odemeSekli = row.Cells["OdemeSekli"].Value?.ToString();

                if (UrunGirisiFormu.cmboxToptancıAdı.Items.Contains(toptanciAdi))
                    UrunGirisiFormu.cmboxToptancıAdı.SelectedItem = toptanciAdi;

                if (UrunGirisiFormu.cmboxOdemeTuru.Items.Contains(odemeSekli))
                    UrunGirisiFormu.cmboxOdemeTuru.SelectedItem = odemeSekli;

                
                if (int.TryParse(row.Cells["UrunGrubu"].Value?.ToString(), out int urunGrubuId))
                {
                    string urunGrupAdi = row.Cells["UrunGrubu"].Value?.ToString(); 

                    foreach (var item in UrunGirisiFormu.cmboxUrunGrubu.Items)
                    {
                        if (item is KeyValuePair<int, string> pair && pair.Value == urunGrupAdi)
                        {
                            UrunGirisiFormu.cmboxUrunGrubu.SelectedItem = pair;
                            break;
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnUrunAra_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                DataView dv = null;

                if (dataGridView1.DataSource is DataTable dt)
                {
                    dv = dt.DefaultView;
                }
                else if (dataGridView1.DataSource is DataView view)
                {
                    dv = view;
                }

                if (dv != null)
                {
                    dv.RowFilter = $"UrunAdi LIKE '%{textBox1.Text}%'";
                    dataGridView1.DataSource = dv;
                }
                else
                {
                    MessageBox.Show("Veri kaynağı geçerli değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Liste boş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // 🔄 Satışİslemi için seçim yapıldıysa (satisForm != null)
            if (satisForm != null && dataGridView1.DataSource is DataTable dt)
            {
                SecilenUrun = dt.Rows[e.RowIndex];
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            // 🔄 Ürün giriş formuna ürün aktarımı
            if (UrunGirisiFormu != null)
            {
                UrunGirisiFormu.txtBarkodNo.Text = row.Cells["BarkodNo"].Value?.ToString();
                UrunGirisiFormu.txtUrunAdi.Text = row.Cells["UrunAdi"].Value?.ToString();
                UrunGirisiFormu.txtUrunKoduAcıklama.Text = row.Cells["UrunKodu"].Value?.ToString();
                UrunGirisiFormu.txtAlısFiyatı.Text = row.Cells["SatisFiyati"].Value?.ToString();
                UrunGirisiFormu.txtİkinciAlısFiyatı.Text = row.Cells["IkinciSatisFiyati"].Value?.ToString();
                UrunGirisiFormu.txtMevcutStok.Text = row.Cells["MevcutStokMiktari"].Value?.ToString();
                UrunGirisiFormu.txtOlcuBirimi.Text = row.Cells["OlcuBirimi"].Value?.ToString();
                UrunGirisiFormu.txtAsgariStok.Text = row.Cells["AsgariStok"].Value?.ToString();

                UrunGirisiFormu.cmboxToptancıAdı.SelectedItem = row.Cells["ToptanciAdi"].Value?.ToString();
                UrunGirisiFormu.cmboxOdemeTuru.SelectedItem = row.Cells["OdemeSekli"].Value?.ToString();

                string urunGrubuAdi = row.Cells["UrunGrubu"].Value?.ToString();
                foreach (var item in UrunGirisiFormu.cmboxUrunGrubu.Items)
                {
                    if (item is KeyValuePair<int, string> pair && pair.Value == urunGrubuAdi)
                    {
                        UrunGirisiFormu.cmboxUrunGrubu.SelectedItem = pair;
                        break;
                    }
                }

                this.Close();
                return;
            }

            // 🔄 Fiyat Gör ekranı
            if (_fiyatGorFormu != null)
            {
                _fiyatGorFormu.txtBarkodNo.Text = row.Cells["BarkodNo"].Value?.ToString();
                _fiyatGorFormu.txtUrunİsmi.Text = row.Cells["UrunAdi"].Value?.ToString();
                _fiyatGorFormu.txtMevcutStok.Text = row.Cells["MevcutStokMiktari"].Value?.ToString();
                _fiyatGorFormu.txtUrunFiyatı.Text = row.Cells["SatisFiyati"].Value?.ToString();

                this.Close();
                return;
            }

            // 🔄 Fiyat Teklifi ekranı
            if (_fiyatTeklifi != null)
            {
                _fiyatTeklifi.UrunEkleFromAraSil(row);
                this.Close();
                return;
            }
        }
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

