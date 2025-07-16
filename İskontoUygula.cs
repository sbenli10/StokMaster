using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirisEkranı
{
    public partial class İskontoUygula : DevExpress.XtraEditors.XtraForm
    {
        public decimal IskontoOrani { get; private set; }
        public İskontoUygula()
        {
            InitializeComponent();
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            string giris = txtİskontoTutarı.Text.Trim().Replace("%", "").Replace(",", ".");

            if (decimal.TryParse(giris, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out decimal oran))
            {
                if (oran < 0 || oran > 100)
                {
                    MessageBox.Show("İskonto oranı 0 ile 100 arasında olmalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                IskontoOrani = oran / 100m;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Geçerli bir sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtİskontoTutarı_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsControl(ch) && !char.IsDigit(ch) && ch != ',' && ch != '.')
            {
                e.Handled = true;
            }
        }

        private void İskontoUygula_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnUygula;
            this.CancelButton = btnVazgec;
        }


    }
}