using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirisEkranı
{
    public partial class Ajanda : Form
    {
        List<AjandaNotu> notlar = new List<AjandaNotu>();
        private string connectionString = "Data Source=StokMasterDB.db;Version=3;";
        public Ajanda()
        {
            InitializeComponent();
        }

        private void Ajanda_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tarih = dateTimePickerTarih.Value.Date;
                DateTime saat = dateTimePickerSaat.Value;
                string gun = tarih.ToString("dddd", new System.Globalization.CultureInfo("tr-TR"));

                string tekrarTipi = comboBox1.SelectedItem?.ToString() ?? "Yok";
                bool hatirlatilsin = chkHatirlat.Checked;

                if (string.IsNullOrWhiteSpace(txtAcıklama.Text) ||
                    string.IsNullOrWhiteSpace(txtBaslık.Text) ||
                    comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen tüm gerekli alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string eposta = txtEposta.Text.Trim();
                if (!string.IsNullOrEmpty(eposta) &&
                    !System.Text.RegularExpressions.Regex.IsMatch(eposta, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Lütfen geçerli bir e-posta adresi girin.", "Geçersiz E-posta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(@"INSERT INTO AjandaNotlari 
                        (NotTarihi, NotSaati, EpostaAdresi, Gun, Baslik, Aciklama, Hatirlatilsin, TekrarTipi, Hatirlatildi)
                        VALUES 
                        (@Tarih, @Saat, @EpostaAdresi, @Gun, @Baslik, @Aciklama, @Hatirlatilsin, @TekrarTipi, 0)", conn);

                    cmd.Parameters.AddWithValue("@Tarih", tarih);
                    cmd.Parameters.AddWithValue("@Saat", saat.ToString("HH:mm"));
                    cmd.Parameters.AddWithValue("@EpostaAdresi", eposta);
                    cmd.Parameters.AddWithValue("@Gun", gun);
                    cmd.Parameters.AddWithValue("@Baslik", txtBaslık.Text);
                    cmd.Parameters.AddWithValue("@Aciklama", txtAcıklama.Text);
                    cmd.Parameters.AddWithValue("@Hatirlatilsin", hatirlatilsin ? 1 : 0);
                    cmd.Parameters.AddWithValue("@TekrarTipi", tekrarTipi);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Not başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtBaslık.Clear();
                txtAcıklama.Clear();
                txtEposta.Clear();
                chkHatirlat.Checked = false;
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MailGonder(string konu, string icerik, string alici)
        {
            MailMessage mail = new MailMessage("seninmail@ornek.com", alici);
            mail.Subject = konu;
            mail.Body = icerik;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("seninmail@ornek.com", "uygulama_sifresi");
            smtp.EnableSsl = true;

            smtp.Send(mail);
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            string nowSaat = DateTime.Now.ToString("HH:mm");
            string bugunGun = DateTime.Now.ToString("dddd", new System.Globalization.CultureInfo("tr-TR"));
            DateTime bugunTarih = DateTime.Now.Date;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT * FROM AjandaNotlari 
                WHERE Hatirlatilsin = 1 AND NotSaati = @saat
                AND (
                    (TekrarTipi = 'Yok' AND NotTarihi = @tarih AND Hatirlatildi = 0)
                    OR (TekrarTipi = 'Günlük')
                    OR (TekrarTipi = 'Haftalık' AND Gun = @gun)
                )
                LIMIT 1";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@saat", nowSaat);
                cmd.Parameters.AddWithValue("@tarih", bugunTarih);
                cmd.Parameters.AddWithValue("@gun", bugunGun);

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        int notId = Convert.ToInt32(dr["NotID"]);
                        string baslik = dr["Baslik"].ToString();
                        string aciklama = dr["Aciklama"].ToString();
                        string tekrar = dr["TekrarTipi"].ToString();
                        string eposta = dr["EpostaAdresi"].ToString();

                        System.Media.SystemSounds.Exclamation.Play();
                        MessageBox.Show($"{baslik}\n\n{aciklama}", "🔔 Hatırlatma", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (!string.IsNullOrWhiteSpace(eposta))
                        {
                            try
                            {
                                MailGonder("Ajanda Hatırlatma: " + baslik, aciklama, eposta);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("E-posta gönderilemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        if (tekrar == "Yok")
                        {
                            dr.Close(); // SQLite bağlantısı açıkken Update yapılmadan önce reader kapatılmalı
                            SQLiteCommand updateCmd = new SQLiteCommand("UPDATE AjandaNotlari SET Hatirlatildi = 1 WHERE NotID = @id", conn);
                            updateCmd.Parameters.AddWithValue("@id", notId);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            NotlarListesi notlarListesi = new NotlarListesi();
            notlarListesi.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
        }
    }
}
