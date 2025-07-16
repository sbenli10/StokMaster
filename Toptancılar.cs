using DevExpress.XtraRichEdit.Layout;
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
    public partial class Toptancılar : BaseForm
    {
        public Toptancılar()
        {
            InitializeComponent();
        }

        private SQLiteConnection conn = new SQLiteConnection($"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StokMaster.db")};Version=3;");



        private void Toptancılar_Load(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT ToptanciID, ToptanciAdi, ToptanciBorc FROM Toptancilar";
            var cmd = new SQLiteCommand(query, conn);
            var adapter = new SQLiteDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

            dataGridView1.Columns["ToptanciAdi"].HeaderText = "Toptancı Adı";
            dataGridView1.Columns["ToptanciBorc"].HeaderText = "Toplam Borç";

            ToptanciVerileriYukle();
        }

        private void btnToptancıEkle_Click(object sender, EventArgs e)
        {
            ToptancıEkle toptancıEkle = new ToptancıEkle();
            toptancıEkle.Show();
        }

        private void btnToptancıSil_Click(object sender, EventArgs e)
        {
            ToptancıSil toptancıSil = new ToptancıSil();
            toptancıSil.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

            this.Close();
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int toptanciID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ToptanciID"].Value);
                string toptanciAdi = dataGridView1.CurrentRow.Cells["ToptanciAdi"].Value.ToString();
                decimal toplamBorc = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["ToptanciBorc"].Value);

                var odemeForm = new ToptancıOdemeAl(toptanciID, toptanciAdi, toplamBorc);
                odemeForm.FormClosed += (s, args) => ToptanciVerileriYukle();
                odemeForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir toptancı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ToptanciVerileriYukle()
        {
            using (var connection = new SQLiteConnection($"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StokMaster.db")};Version=3;"))
            {
                string query = "SELECT ToptanciID, ToptanciAdi, ToptanciBorc FROM Toptancilar";
                var adapter = new SQLiteDataAdapter(query, connection);
                var dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnBorcEkle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int toptanciID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ToptanciID"].Value);
                string toptanciAdi = dataGridView1.CurrentRow.Cells["ToptanciAdi"].Value.ToString();
                decimal toplamBorc = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["ToptanciBorc"].Value);

                var borcekle = new ToptancıBorcEkle(toptanciID, toptanciAdi, toplamBorc);
                borcekle.FormClosed += (s, args) => ToptanciVerileriYukle();
                borcekle.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir toptancı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string arama = textBox1.Text.Trim().ToLower();
            if (dataGridView1.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter = $"ToptanciAdi LIKE '%{arama.Replace("'", "''")}%'";
            }
        }

        private void btnBilgiDüzenle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ToptanciID"].Value);

                using (var conn = new SQLiteConnection($"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StokMaster.db")};Version=3;"))
                {
                    conn.Open();
                    var cmd = new SQLiteCommand("SELECT * FROM Toptancilar WHERE ToptanciID = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var form = new ToptancıEkle(
                                id,
                                reader["ToptanciAdi"].ToString(),
                                reader["SirketYetkilisi"].ToString(),
                                reader["EPosta"].ToString(),
                                reader["InternetAdresi"].ToString(),
                                reader["IsTelefonu"].ToString(),
                                reader["GsmTelefonu"].ToString(),
                                reader["Fax"].ToString(),
                                reader["VD"].ToString(),
                                reader["VN"].ToString(),
                                reader["Adres"].ToString(),
                                reader["OzelNotlar"].ToString()
                            );

                            form.ShowDialog();
                            ToptanciVerileriYukle();
                        }
                    }
                }
            }
        }
    }
}
