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
    public partial class TaksitYap : Form
    {
        public TaksitYap()
        {
            InitializeComponent();
        }


     
        public int TaksitSayisi { get; private set; } = 1;

        private void TaksitYap_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && int.TryParse(comboBox1.SelectedItem.ToString(), out int sayi))
            {
                TaksitSayisi = sayi;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir taksit sayısı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
      
    }
}
