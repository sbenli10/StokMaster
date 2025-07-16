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
    public partial class UrunGrubuSil : BaseForm
    {
        private SQLiteConnection conn = new SQLiteConnection($"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StokMaster.db")};Version=3;");


        public UrunGrubuSil()
        {
            InitializeComponent();
        }

        private void UrunGrubuSil_Load(object sender, EventArgs e)
        {
            VerileriYukle();
            UrunGrubuEkle();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silmek için bir ürün grubu seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            conn.Open();
            var cmd = new SQLiteCommand("DELETE FROM UrunGrubu WHERE UrunGrupAdi = @UrunGrupAdi", conn);
            cmd.Parameters.AddWithValue("@UrunGrupAdi", comboBox1.SelectedItem.ToString());
            int sonuc = cmd.ExecuteNonQuery();
            conn.Close();

            if (sonuc > 0)
            {
                MessageBox.Show("Ürün Grubu başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Girdiğiniz ürün grubu bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            VerileriYukle();
            UrunGrubuEkle();
        }

        private void UrunGrubuEkle()
        {
            comboBox1.Items.Clear();
            conn.Open();
            var cmd = new SQLiteCommand("SELECT UrunGrupAdi FROM UrunGrubu", conn);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["UrunGrupAdi"].ToString()); 
            }

        }

        private void VerileriYukle()
        {
            var da = new SQLiteDataAdapter("SELECT * FROM UrunGrubu", conn);
            var dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            if (dataGridView1.Columns.Contains("UrunGrupAdi")) 
                dataGridView1.Columns["UrunGrupAdi"].HeaderText = "Ürün Grup Adı";

        }

    }
}