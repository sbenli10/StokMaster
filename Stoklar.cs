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
using System.Windows.Controls;
using System.Windows.Forms;

namespace GirisEkranı
{
    public partial class Stoklar : BaseForm
    {
        public Stoklar()
        {
            InitializeComponent();
        }

        SQLiteConnection conn = new SQLiteConnection($"Data Source=StokMaster.db;Version=3;");

        private void Stoklar_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT UrunID, BarkodNo, UrunAdi, UrunKodu, AsgariStok, MevcutStokMiktari, OlcuBirimi, AlisFiyatiKDVdahil, SatisFiyati, IkinciSatisFiyati, KDVOrani, UrunGrubu FROM Urunler";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                
                dataGridView1.Columns["BarkodNo"].HeaderText = "Barkod No";
                dataGridView1.Columns["UrunAdi"].HeaderText = "Ürün Adı";
                dataGridView1.Columns["UrunKodu"].HeaderText = "Ürün Kodu";
                dataGridView1.Columns["AsgariStok"].HeaderText = "Asgari Stok";
                dataGridView1.Columns["MevcutStokMiktari"].HeaderText = "Stok Miktarı";
                dataGridView1.Columns["AlisFiyatiKDVdahil"].HeaderText = "Alış Fiyatı";
                dataGridView1.Columns["SatisFiyati"].HeaderText = "Satış Fiyatı";
                dataGridView1.Columns["IkinciSatisFiyati"].HeaderText = "İkinci Satış Fiyatı";
                dataGridView1.Columns["KDVOrani"].HeaderText = "KDV Oranı";
                dataGridView1.Columns["UrunGrubu"].HeaderText = "Ürün Grubu";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu:\n" + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void UrunleriYukle(string siralamaKolonu)
        {
            try
            {
                conn.Open();

                string query = "SELECT UrunID, BarkodNo, UrunAdi, UrunKodu, AsgariStok, MevcutStokMiktari, OlcuBirimi, AlisFiyatiKDVdahil, SatisFiyati, IkinciSatisFiyati, KDVOrani, UrunGrubu FROM Urunler";

                if (!string.IsNullOrEmpty(siralamaKolonu))
                {
                    query += $" ORDER BY {siralamaKolonu}";
                }

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

              
                dataGridView1.Columns["BarkodNo"].HeaderText = "Barkod No";
                dataGridView1.Columns["UrunAdi"].HeaderText = "Ürün Adı";
                dataGridView1.Columns["UrunKodu"].HeaderText = "Ürün Kodu";
                dataGridView1.Columns["AsgariStok"].HeaderText = "Asgari Stok";
                dataGridView1.Columns["MevcutStokMiktari"].HeaderText = "Stok Miktarı";
                dataGridView1.Columns["AlisFiyatiKDVdahil"].HeaderText = "Alış Fiyatı";
                dataGridView1.Columns["SatisFiyati"].HeaderText = "Satış Fiyatı";
                dataGridView1.Columns["IkinciSatisFiyati"].HeaderText = "İkinci Satış Fiyatı";
                dataGridView1.Columns["KDVOrani"].HeaderText = "KDV Oranı";
                dataGridView1.Columns["UrunGrubu"].HeaderText = "Ürün Grubu";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu:\n" + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                

                txtBarkodNo.Text = row.Cells["BarkodNo"].Value.ToString();
                txtUrunAdı.Text = row.Cells["UrunAdi"].Value.ToString();
                txtStokKodu.Text = row.Cells["UrunKodu"].Value.ToString();
                txtAsgariStok.Text = row.Cells["AsgariStok"].Value.ToString();
                txtMevcutStok.Text = row.Cells["MevcutStokMiktari"].Value.ToString();
                txtAlısFiyatı.Text = row.Cells["AlisFiyatiKDVdahil"].Value.ToString();
                txtSatısFiyatı.Text = row.Cells["SatisFiyati"].Value.ToString();
                txtSatısFiyatı.Text = row.Cells["SatisFiyati"].Value.ToString();
                txtİkinciSatısFiyatı.Text = row.Cells["IkinciSatisFiyati"].Value.ToString();
                txtKdvOranı.Text = row.Cells["KDVOrani"].Value.ToString();
                txtUrunGrubu.Text = row.Cells["UrunGrubu"].Value.ToString();

            }
        }

        private void btnUrunuDüzelt_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Düzenlemek İstediğiniz Ürünü Seçiniz!");
                    return;
                }

                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int urunId = Convert.ToInt32(row.Cells["UrunId"].Value);

                string updateQuery = @"UPDATE Urunler SET 
                    BarkodNo = @BarkodNo,
                    UrunAdi = @UrunAdi,
                    UrunKodu = @UrunKodu,
                    AsgariStok = @AsgariStok,
                    MevcutStokMiktari = @MevcutStokMiktari,
                    AlisFiyatiKDVdahil = @AlisFiyatiKDVdahil,
                    SatisFiyati = @SatisFiyati,
                    IkinciSatisFiyati = @IkinciSatisFiyati,
                    KDVOrani = @KDVOrani,
                    UrunGrubu = @UrunGrubu
                    WHERE UrunID = @UrunID";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@UrunID", urunId);
                cmd.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
                cmd.Parameters.AddWithValue("@UrunAdi", txtUrunAdı.Text);
                cmd.Parameters.AddWithValue("@UrunKodu", txtStokKodu.Text);
                cmd.Parameters.AddWithValue("@AsgariStok", txtAsgariStok.Text);
                cmd.Parameters.AddWithValue("@MevcutStokMiktari", txtMevcutStok.Text);
                cmd.Parameters.AddWithValue("@AlisFiyatiKDVdahil", txtAlısFiyatı.Text);
                cmd.Parameters.AddWithValue("@SatisFiyati", txtSatısFiyatı.Text);
                cmd.Parameters.AddWithValue("@IkinciSatisFiyati", txtİkinciSatısFiyatı.Text);
                cmd.Parameters.AddWithValue("@KDVOrani", txtKdvOranı.Text);
                cmd.Parameters.AddWithValue("@UrunGrubu", txtUrunGrubu.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Ürün güncellendi.");
                    Stoklar_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Ürün güncellenemedi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA:\n" + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void textboxTemizle()
        {
            txtBarkodNo.Clear();
            txtUrunAdı.Clear();
            txtStokKodu.Clear();
            txtAsgariStok.Clear();
            txtMevcutStok.Clear();
            txtAlısFiyatı.Clear();
            txtSatısFiyatı.Clear();
            txtİkinciSatısFiyatı.Clear();
            txtKdvOranı.Clear();
            txtUrunGrubu.Clear();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silmek için bir ürün seçin!");
                    return;
                }

                int urunId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UrunID"].Value);
                string deleteQuery = "DELETE FROM Urunler WHERE UrunID = @UrunID";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@UrunID", urunId);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Ürün başarıyla silindi.");
                    textboxTemizle();
                }
                else
                {
                    MessageBox.Show("Ürün silinemedi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:\n" + ex.Message);
            }
            finally
            {
                conn.Close();
                Stoklar_Load(sender, e);
            }
        }

        private void cmboxSıralama_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kol = cmboxSıralama.SelectedItem?.ToString();
            string siralama = kol switch
            {
                "Ürün Adı" => "UrunAdi",
                "Ürün Fiyatı" => "SatisFiyati",
                "Barkod No" => "BarkodNo",
                "Ürün Grubu" => "UrunGrubu",
                _ => ""
            };
            UrunleriYukle(siralama);

        }

        private void btnUrunEkle_Click(object sender, EventArgs e) => new ÜrünGirisi().Show();
        private void btnUrunGrupları_Click(object sender, EventArgs e) => new UrunGrubuSil().Show();
        private void simpleButton1_Click(object sender, EventArgs e) => new ÜrünAraSil().Show();
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            new AnaSayfa().Show();
        }
    }
}