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
    public partial class MusteriBorcDetay : BaseForm
    {
        SQLiteConnection conn = new SQLiteConnection("Data Source=StokMaster.db;Version=3;");


        public MusteriBorcDetay()
        {
            InitializeComponent();
            this.AcceptButton = btnAra;
        }

        private void btnAra_Click(object sender, EventArgs e)
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
                    string aranan = txtMusteriAdı.Text.Trim();

                    if (string.IsNullOrEmpty(aranan))
                    {
                        dv.RowFilter = "";
                    }
                    else
                    {
                        // SQLite LIKE büyük/küçük harf duyarlıdır, ihtiyaca göre COLLATE NOCASE kullanılabilir
                        dv.RowFilter = $"Adi LIKE '%{aranan}%'";
                    }

                    dataGridView1.DataSource = dv;
                }
                else
                {
                    MessageBox.Show("Veri kaynağı geçerli değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Müşteri listesi boş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MusteriBorcDetay_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = "SELECT MusteriID, Adi, Soyadi, ToplamBorc FROM Musteri";
                SQLiteCommand command = new SQLiteCommand(query, conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                dataGridView1.Columns["MusteriID"].HeaderText = "Müşteri ID";
                dataGridView1.Columns["Adi"].HeaderText = "Müşteri Adı";
                dataGridView1.Columns["Soyadi"].HeaderText = "Müşteri Soyadı";
                dataGridView1.Columns["ToplamBorc"].HeaderText = "Toplam Borç";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}