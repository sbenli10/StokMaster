using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GirisEkranı
{
    public partial class EskiSatıslar : DevExpress.XtraEditors.XtraForm
    {
        public EskiSatıslar()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=StokMaster.db;Version=3;";


        private void EskiSatıslar_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM SatisDetay";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            string barkod = dataGridView1.SelectedRows[0].Cells["Barkod"].Value?.ToString();

            if (string.IsNullOrEmpty(barkod))
                return;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT SatisTarihi
                    FROM SatisDetay
                    WHERE Barkod = @Barkod
                    ORDER BY SatisTarihi DESC
                    LIMIT 1";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Barkod", barkod);

                    object result = cmd.ExecuteScalar();

                    txtBarkodNo.Text = barkod;

                    if (result != null && DateTime.TryParse(result.ToString(), out DateTime satisTarihi))
                    {
                        txtSatısTarihi.Text = satisTarihi.ToString("dd.MM.yyyy HH:mm");
                    }
                    else
                    {
                        txtSatısTarihi.Text = "Satış bulunamadı";
                    }
                }

                decimal toplamTutar = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["ToplamTutar"].Value != null &&
                        decimal.TryParse(row.Cells["ToplamTutar"].Value.ToString(), out decimal deger))
                    {
                        toplamTutar += deger;
                    }
                }

                lblToplamtutar.Text = toplamTutar.ToString("N2");
            }
        }

        private void btnTarihGit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Gösterilecek veri yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime secilenTarih = dateTimePicker1.Value.Date;
            bool bulundu = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                if (DateTime.TryParse(row.Cells["SatisTarihi"].Value?.ToString(), out DateTime satisTarihi))
                {
                    if (satisTarihi.Date == secilenTarih)
                    {
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        bulundu = true;
                        break;
                    }
                }
            }

            if (!bulundu)
            {
                MessageBox.Show("Seçilen tarihte satış bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}