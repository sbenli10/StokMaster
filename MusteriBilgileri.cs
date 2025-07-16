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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GirisEkranı
{
    public partial class MusteriBilgileri : BaseForm
    {
        SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["StokMasterDB"].ConnectionString);

        public MusteriBilgileri()
        {
            InitializeComponent();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MusteriBilgileri_Load(object sender, EventArgs e)
        {
            conn.Open();

            string query = @"
            SELECT 
                MusteriID,
                Adi,
                Soyadi,
                TicariUnvani,
                GsmTelefonu,
                VergiDairesi,
                VergiNumarasi,
                Adres,
                IlIlce,
                Ulke,
                OzelNotlar,
                Email,
                DevredenBorc,
                LimitBelirle,
                KayitTarihi,
                VeresiyeToplam,
                KalanTaksitToplam,
                ToplamBorc
            FROM Musteri";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Kolon başlıklarını kullanıcı dostu hale getiriyoruz
          //  dataGridView1.Columns["MusteriID"].HeaderText = "Müşteri ID";
            dataGridView1.Columns["Adi"].HeaderText = "Adı";
            dataGridView1.Columns["Soyadi"].HeaderText = "Soyadı";
            dataGridView1.Columns["TicariUnvani"].HeaderText = "Ticari Ünvan";
            dataGridView1.Columns["GsmTelefonu"].HeaderText = "GSM Telefonu";
            dataGridView1.Columns["VergiDairesi"].HeaderText = "Vergi Dairesi";
            dataGridView1.Columns["VergiNumarasi"].HeaderText = "Vergi No";
            dataGridView1.Columns["Adres"].HeaderText = "Adres";
            dataGridView1.Columns["IlIlce"].HeaderText = "İl / İlçe";
            dataGridView1.Columns["Ulke"].HeaderText = "Ülke";
            dataGridView1.Columns["OzelNotlar"].HeaderText = "Özel Notlar";
            dataGridView1.Columns["Email"].HeaderText = "E-posta";
            dataGridView1.Columns["DevredenBorc"].HeaderText = "Devreden Borç";
            dataGridView1.Columns["LimitBelirle"].HeaderText = "Belirlenen Limit";
            dataGridView1.Columns["KayitTarihi"].HeaderText = "Kayıt Tarihi";
            dataGridView1.Columns["VeresiyeToplam"].HeaderText = "Veresiye Toplam";
            dataGridView1.Columns["KalanTaksitToplam"].HeaderText = "Kalan Taksit";
            dataGridView1.Columns["ToplamBorc"].HeaderText = "Toplam Borç";

            conn.Close();

        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriYeniKayıt yeniMusteri = new MusteriYeniKayıt();
            yeniMusteri.ShowDialog();
            MusteriBilgileri_Load(sender, e);

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();

        }

        private void btnMüsteriBorcDetayı_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int musteriID = Convert.ToInt32(selectedRow.Cells["MusteriID"].Value);
                string musteriAdi = selectedRow.Cells["Adi"].Value.ToString();
                string musteriSoyadı = selectedRow.Cells["Soyadi"].Value.ToString();
                decimal kalantaksitToplam = Convert.ToDecimal(selectedRow.Cells["KalanTaksitToplam"].Value);
                decimal veresiyeToplam = Convert.ToDecimal(selectedRow.Cells["VeresiyeToplam"].Value);
                decimal toplamBorc = Convert.ToDecimal(selectedRow.Cells["ToplamBorc"].Value);

                MusteriBorc borc = new MusteriBorc(musteriID, musteriAdi, musteriSoyadı, kalantaksitToplam, toplamBorc, veresiyeToplam);
                borc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen önce bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                txtAdı.Text = row.Cells["Adi"].Value.ToString();
                txtSoyadı.Text = row.Cells["Soyadi"].Value.ToString();
                txtTicariUnvanı.Text = row.Cells["TicariUnvani"].Value.ToString();
                txtGsmTelefonu.Text = row.Cells["GsmTelefonu"].Value.ToString();
                txtVergiDairesi.Text = row.Cells["VergiDairesi"].Value.ToString();
                txtVergiNo.Text = row.Cells["VergiNumarasi"].Value.ToString();
                txtAdres.Text = row.Cells["Adres"].Value.ToString();
                txtİlveİlce.Text = row.Cells["IlIlce"].Value.ToString();
                //  txtUlke.Text = row.Cells["Ulke"].Value.ToString();
                txtOzelNotlar.Text = row.Cells["OzelNotlar"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                //   txt.Text = row.Cells["DevredenBorc"].Value.ToString();
                txtLimitBelirle.Text = row.Cells["LimitBelirle"].Value.ToString();
                //txtKayitTarihi.Text = Convert.ToDateTime(row.Cells["KayitTarihi"].Value).ToString("dd/MM/yyyy");
                txtVeresiyeToplam.Text = row.Cells["VeresiyeToplam"].Value.ToString();
                txtKalanTaksitTutarı.Text = row.Cells["KalanTaksitToplam"].Value.ToString();
                txtToplamBorc.Text = row.Cells["ToplamBorc"].Value.ToString();
            }
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silmek için bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int musteriID = Convert.ToInt32(selectedRow.Cells["MusteriID"].Value);
                decimal toplamBorc = Convert.ToDecimal(selectedRow.Cells["ToplamBorc"].Value);
                string musteriAdi = selectedRow.Cells["Adi"].Value.ToString() + " " + selectedRow.Cells["Soyadi"].Value.ToString();

                if (toplamBorc > 0)
                {
                    DialogResult result = MessageBox.Show(
                        $"Seçilen müşteri ({musteriAdi}) toplam {toplamBorc:C} borca sahip.\nYine de silmek istiyor musunuz?",
                        "Borçlu Müşteri - Silme Onayı",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }

                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["StokMasterDB"].ConnectionString))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM Musteri WHERE MusteriID = @MusteriID";
                    using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@MusteriID", musteriID);
                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Müşteri başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Müşteri silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MusteriBilgileri_Load(sender, e);
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            MusterİadeAl musteriIadeAl = new MusterİadeAl();
            musteriIadeAl.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen Düzenlemek için bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int musteriID = Convert.ToInt32(selectedRow.Cells["MusteriID"].Value);

                string updateQuery = "UPDATE Musteri SET " +
                    "Adi = @Adi, " +
                    "Soyadi = @Soyadi, " +
                    "TicariUnvani = @TicariUnvani, " +
                    "GsmTelefonu = @GsmTelefonu, " +
                    "VergiDairesi = @VergiDairesi, " +
                    "VergiNumarasi = @VergiNumarasi, " +
                    "Adres = @Adres, " +
                    "IlIlce = @IlIlce, " +
                    "OzelNotlar = @OzelNotlar, " +
                    "Email = @Email, " +
                    "DevredenBorc = @DevredenBorc, " +
                    "LimitBelirle = @LimitBelirle, " +
                    "VeresiyeToplam = @VeresiyeToplam, " +
                    "KalanTaksitToplam = @KalanTaksitToplam, " +
                    "ToplamBorc = @ToplamBorc " +
                    "WHERE MusteriID = @MusteriID";

                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["StokMasterDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Adi", txtAdı.Text.Trim());
                        cmd.Parameters.AddWithValue("@Soyadi", txtSoyadı.Text.Trim());
                        cmd.Parameters.AddWithValue("@TicariUnvani", txtTicariUnvanı.Text.Trim());
                        cmd.Parameters.AddWithValue("@GsmTelefonu", txtGsmTelefonu.Text.Trim());
                        cmd.Parameters.AddWithValue("@VergiDairesi", txtVergiDairesi.Text.Trim());
                        cmd.Parameters.AddWithValue("@VergiNumarasi", txtVergiNo.Text.Trim());
                        cmd.Parameters.AddWithValue("@Adres", txtAdres.Text.Trim());
                        cmd.Parameters.AddWithValue("@IlIlce", txtİlveİlce.Text.Trim());
                        cmd.Parameters.AddWithValue("@OzelNotlar", txtOzelNotlar.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@DevredenBorc", Convert.ToDecimal(txtVeresiyeToplam.Text.Trim()));
                        cmd.Parameters.AddWithValue("@LimitBelirle", Convert.ToDecimal(txtLimitBelirle.Text.Trim()));
                        cmd.Parameters.AddWithValue("@VeresiyeToplam", Convert.ToDecimal(txtVeresiyeToplam.Text.Trim()));
                        cmd.Parameters.AddWithValue("@KalanTaksitToplam", Convert.ToDecimal(txtKalanTaksitTutarı.Text.Trim()));
                        cmd.Parameters.AddWithValue("@ToplamBorc", Convert.ToDecimal(txtToplamBorc.Text.Trim()));
                        cmd.Parameters.AddWithValue("@MusteriID", musteriID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Müşteri bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MusteriBilgileri_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme yapılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                    string aranan = txtMusteriAra.Text.Trim();


                    if (string.IsNullOrEmpty(aranan))
                    {
                        dv.RowFilter = "";
                    }
                    else
                    {

                        dv.RowFilter = $"Adi LIKE '%{aranan}%'";
                    }
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

        private void btnTahsilatYap_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int musteriID = Convert.ToInt32(selectedRow.Cells["MusteriID"].Value);
                string musteriAdi = selectedRow.Cells["Adi"].Value.ToString();
                decimal toplamBorc = Convert.ToDecimal(selectedRow.Cells["ToplamBorc"].Value);

                MüsteriÖdemeAlma odemeFormu = new MüsteriÖdemeAlma(musteriID, musteriAdi, toplamBorc);
                odemeFormu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen önce bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMusteriBorcListesi_Click(object sender, EventArgs e)
        {

            MusteriBorcDetay musteriBorcDetay = new MusteriBorcDetay();
            musteriBorcDetay.ShowDialog();
        }

        private void btnHesabaBorcEkle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                int id = Convert.ToInt32(row.Cells["MusteriID"].Value);
                string adi = row.Cells["Adi"].Value.ToString();
                string soyadi = row.Cells["Soyadi"].Value.ToString();
                decimal toplamBorc = Convert.ToDecimal(row.Cells["ToplamBorc"].Value);

                this.Close();
                MusteriBorcEkle borcEkleForm = new MusteriBorcEkle(id, adi, soyadi, toplamBorc);
                borcEkleForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz.");
            }
        }
    }
}