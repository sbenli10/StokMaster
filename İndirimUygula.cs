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
    public partial class İndirimUygula : DevExpress.XtraEditors.XtraForm
    {
        public decimal IndirimTutari { get; private set; }
        public İndirimUygula()
        {
            InitializeComponent();
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtİndirim.Text, out decimal indirim))
            {
                IndirimTutari = indirim;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Geçerli bir indirim tutarı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void İndirimUygula_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnUygula;
            this.CancelButton = btnVazgec;
        }
    }
}