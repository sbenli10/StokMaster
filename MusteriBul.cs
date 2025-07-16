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
    public partial class MusteriBul : BaseForm
    {
        SQLiteConnection conn = new SQLiteConnection("Data Source=StokMaster.db;Version=3;");
        public DataRow SecilenMusteri { get; private set; }

        public MusteriBul()
        {
            InitializeComponent();
        }

        private void MusteriBul_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Musteri";

            using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                dataGridView1.Columns["MusteriID"].HeaderText = "Müşteri ID";
                dataGridView1.Columns["Adi"].HeaderText = "Müşteri Adı";
                dataGridView1.Columns["Soyadi"].HeaderText = "Müşteri Soyadı";
                dataGridView1.Columns["DevredenBorc"].HeaderText = "Borç";
            }
        }

        private void btnMusteriAra_Click(object sender, EventArgs e)
        {

            string aramaAdi = txtMuster.Text.Trim();

            if (!string.IsNullOrEmpty(aramaAdi))
            {
                string query = "SELECT * FROM Musteri WHERE Adi LIKE @Adi";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Adi", "%" + aramaAdi + "%");

                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Veritabanında bu isme sahip müşteri bulunamadı.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir isim giriniz.");
            }

        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int musteriId = Convert.ToInt32(row.Cells["MusteriID"].Value);

                    string query = "DELETE FROM Musteri WHERE MusteriID = @MusteriID";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@MusteriID", musteriId);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    dataGridView1.Rows.Remove(row);

                    MessageBox.Show("Müşteri başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Listele();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz müşteriyi seçin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listele()
        {
            string query = "SELECT * FROM Musteri";

            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (e.RowIndex >= 0)
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                SecilenMusteri = dt.Rows[e.RowIndex];
                this.DialogResult = DialogResult.OK;
                this.Close();
            */
        }
        
        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                SecilenMusteri = dt.Rows[e.RowIndex];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}