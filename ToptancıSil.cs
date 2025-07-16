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
    public partial class ToptancıSil : BaseForm
    {
        private SQLiteConnection conn = new SQLiteConnection($"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StokMaster.db")};Version=3;");

        public ToptancıSil()
        {
            InitializeComponent();
        }

        private void ToptancıSil_Load(object sender, EventArgs e)
        {
            conn.Open();

            ToptancıAdıDoldur();

            var cmd = new SQLiteCommand("SELECT * FROM Toptancilar", conn);
            var da = new SQLiteDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Columns["ToptanciID"].HeaderText = "Toptancı ID";
            dataGridView1.Columns["ToptanciAdi"].HeaderText = "Toptancı Adı";
            dataGridView1.Columns["SirketYetkilisi"].HeaderText = "Şirket Yetkilisi";
            dataGridView1.Columns["EPosta"].HeaderText = "E-Mail";
            dataGridView1.Columns["InternetAdresi"].HeaderText = "İnternet Adresi";
            dataGridView1.Columns["IsTelefonu"].HeaderText = "İş Telefonu";
            dataGridView1.Columns["GsmTelefonu"].HeaderText = "Gsm Telefonu";
            dataGridView1.Columns["Fax"].HeaderText = "Fax";
            dataGridView1.Columns["VD"].HeaderText = "V.D";
            dataGridView1.Columns["VN"].HeaderText = "V.N";
            dataGridView1.Columns["Adres"].HeaderText = "Adres";
            dataGridView1.Columns["OzelNotlar"].HeaderText = "Özel Notlar";
            dataGridView1.Columns["ToptanciBorc"].HeaderText = "Toptancıya Olan Borcunuz";

            conn.Close();

            ToptancıAdıDoldur();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;

            bool toptanciVarMi = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ToptanciAdi"].Value != null && row.Cells["ToptanciAdi"].Value.ToString() == comboBox1.SelectedItem.ToString())
                {
                    toptanciVarMi = true;
                    break;
                }
            }

            if (toptanciVarMi)
            {
                var cmd = new SQLiteCommand("DELETE FROM Toptancilar WHERE ToptanciAdi = @ToptanciAdi", conn);
                cmd.Parameters.AddWithValue("@ToptanciAdi", comboBox1.SelectedItem.ToString());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                var da = new SQLiteDataAdapter("SELECT * FROM Toptancilar", conn);
                var dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }
        private void ToptancıAdıDoldur()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            using (var cmd = new SQLiteCommand("SELECT ToptanciAdi FROM Toptancilar", conn))
            using (var dr = cmd.ExecuteReader())
            {
                comboBox1.Items.Clear();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["ToptanciAdi"].ToString());
                }
            }

            conn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}