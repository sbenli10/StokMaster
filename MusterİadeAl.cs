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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirisEkranı
{
    public partial class MusterİadeAl : DevExpress.XtraEditors.XtraForm
    {
        private bool iskontoUygulandi = false;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["StokMasterDB"].ConnectionString;

        public MusterİadeAl()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {
            this.AcceptButton = btnUrunAra;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT BarkodNo, UrunAdi, OlcuBirimi, SatisFiyati FROM Urunler";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    DataTable data = new DataTable();
                    da.Fill(data);

                    dataGridView2.DataSource = data;

                    dataGridView2.Columns["BarkodNo"].HeaderText = "Barkod No";
                    dataGridView2.Columns["UrunAdi"].HeaderText = "Ürün Adı";
                    dataGridView2.Columns["OlcuBirimi"].HeaderText = "Ölçü Birimi";
                    dataGridView2.Columns["SatisFiyati"].HeaderText = "Satış Fiyatı";
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                foreach (DataGridViewColumn column in dataGridView2.Columns)
                {
                    dataGridView1.Columns.Add((DataGridViewColumn)column.Clone());
                }

                dataGridView1.Columns.Add("Miktar", "Miktar");
                dataGridView1.Columns.Add("IkinciSatisFiyati", "İkinci Satış Fiyatı");
                dataGridView1.Columns.Add("Fiyati", "Fiyatı");
                dataGridView1.Columns.Add("Tutar", "Tutar");

                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                object[] rowData = new object[selectedRow.Cells.Count + 4];

                for (int i = 0; i < selectedRow.Cells.Count; i++)
                    rowData[i] = selectedRow.Cells[i].Value;

                rowData[selectedRow.Cells.Count] = 1;
                rowData[selectedRow.Cells.Count + 1] = DBNull.Value;
                rowData[selectedRow.Cells.Count + 2] = selectedRow.Cells["SatisFiyati"].Value;
                rowData[selectedRow.Cells.Count + 3] = selectedRow.Cells["SatisFiyati"].Value;

                dataGridView1.Rows.Add(rowData);

                txtBarkodNo.Text = selectedRow.Cells["BarkodNo"].Value?.ToString() ?? "";
                txtBarkodNo.Focus();

                if (decimal.TryParse(selectedRow.Cells["SatisFiyati"].Value?.ToString(), out decimal fiyat))
                    lblToplamTutar.Text = fiyat.ToString("C2");
                else
                    lblToplamTutar.Text = "0,00 ₺";

                xtraTabControl1.SelectedTabPage = xtraTabPage1;
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.ShowDialog();
        }

        private void MusterİadeAl_Load(object sender, EventArgs e)
        {

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

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

        private void IskontoyuUygula(decimal iskontoOrani)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                int miktar = 1;
                if (row.Cells["Miktar"]?.Value != null)
                    int.TryParse(row.Cells["Miktar"].Value.ToString(), out miktar);

                decimal orijinalFiyat = 0;

                if (row.Cells["IkinciSatisFiyati"]?.Value != null &&
                    decimal.TryParse(row.Cells["IkinciSatisFiyati"].Value.ToString(), out decimal ikinciFiyat))
                {
                    orijinalFiyat = ikinciFiyat;
                }
                else if (row.Cells["SatisFiyati"]?.Value != null &&
                         decimal.TryParse(row.Cells["SatisFiyati"].Value.ToString(), out decimal satisFiyat))
                {
                    orijinalFiyat = satisFiyat;
                }

                decimal iskontoFiyati = Math.Round(orijinalFiyat * (1 - iskontoOrani), 2);
                decimal yeniTutar = Math.Round(iskontoFiyati * miktar, 2);

                if (row.Cells["Fiyati"] != null)
                    row.Cells["Fiyati"].Value = iskontoFiyati;

                if (row.Cells["Tutar"] != null)
                    row.Cells["Tutar"].Value = yeniTutar;
            }

            iskontoUygulandi = true;
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

        private void btnMusteriyeNakitOde_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("İade edilecek ürün bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal toplamIadeTutar = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                if (decimal.TryParse(row.Cells["Tutar"].Value?.ToString(), out decimal tutar))
                    toplamIadeTutar += tutar;
            }

            DialogResult result = MessageBox.Show($"Müşteriye {toplamIadeTutar:C2} iade edilecek. Onaylıyor musunuz?",
                "İade Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    MessageBox.Show($"Müşteriye {toplamIadeTutar:C2} nakit ödeme yapıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.Rows.Clear();
                    lblToplamTutar.Text = "0,00 ₺";
                    txtBarkodNo.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ödeme sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnMusteriBorcudanDusurulecek_Click(object sender, EventArgs e)
        {

        }

        private void btnUrunAra_Click(object sender, EventArgs e)
        {
            if (dataGridView2.DataSource != null)
            {
                DataView dv = null;

                if (dataGridView2.DataSource is DataTable dt)
                {
                    dv = dt.DefaultView;
                }
                else if (dataGridView2.DataSource is DataView view)
                {
                    dv = view;
                }

                if (dv != null)
                {

                    string aranan = textBox1.Text.Trim();


                    if (string.IsNullOrEmpty(aranan))
                    {
                        dv.RowFilter = "";
                    }
                    else
                    {

                        dv.RowFilter = $"UrunAdi LIKE '%{aranan}%'";
                    }
                }
                else
                {
                    MessageBox.Show("Veri kaynağı geçerli değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Listede Böyle Bir Ürün Yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}