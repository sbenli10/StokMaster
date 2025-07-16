using DevExpress.XtraCharts.Native;
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
    public partial class NotlarListesi : BaseForm
    {
        private SQLiteConnection conn;
        public NotlarListesi()
        {
            InitializeComponent();
            
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StokMaster.db");
            conn = new SQLiteConnection($"Data Source={dbPath};Version=3;");
        }

        private void NotlarListesi_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = @"
                    SELECT 
                        NotID, 
                        NotTarihi, 
                        NotSaati, 
                        Gun, 
                        Baslik, 
                        Aciklama 
                    FROM AjandaNotlari 
                    ORDER BY NotTarihi ASC, NotSaati ASC";

                using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Kolon başlıkları
                    dataGridView1.Columns["NotID"].HeaderText = "ID";
                    dataGridView1.Columns["NotTarihi"].HeaderText = "Tarih";
                    dataGridView1.Columns["NotSaati"].HeaderText = "Saat";
                    dataGridView1.Columns["Gun"].HeaderText = "Gün";
                    dataGridView1.Columns["Baslik"].HeaderText = "Başlık";
                    dataGridView1.Columns["Aciklama"].HeaderText = "Açıklama";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
