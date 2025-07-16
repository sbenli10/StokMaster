using DevExpress.CodeParser;
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
    public partial class UrunGrubu : BaseForm
    {
        private SQLiteConnection conn = new SQLiteConnection($"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StokMaster.db")};Version=3;");
        public UrunGrubu()
        {
            InitializeComponent();
        }

        private void UrunGrubu_Load(object sender, EventArgs e)
        {

        }
        private void btnVAZGEÇ_Click(object sender, EventArgs e)
        {
            UrunGrubuSil urunGrubuSil = new UrunGrubuSil();
            urunGrubuSil.Show();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUrunGrupAdı.Text))
            {
                MessageBox.Show("Lütfen ürün grubu adını girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            conn.Open();

            var cmd = new SQLiteCommand("INSERT INTO UrunGrubu (UrunGrupAdi) VALUES (@UrunGrupAdi)", conn);
            cmd.Parameters.AddWithValue("@UrunGrupAdi", txtUrunGrupAdı.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Yeni Ürün Grubu Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUrunGrupAdı.Clear();
            }

            conn.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            ÜrünGirisi ürünGirisi = new ÜrünGirisi();
            ürünGirisi.Show();
        }
    }
}