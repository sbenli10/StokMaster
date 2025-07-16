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
    public partial class FiyatGör : DevExpress.XtraEditors.XtraForm
    {
        public delegate void UrunSecildiEventHandler(DataRow secilenUrun);
        public event UrunSecildiEventHandler UrunSecildi;
        public FiyatGör()
        {
            InitializeComponent();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ÜrünAraSil urunAraSilForm = new ÜrünAraSil(this); 
            urunAraSilForm.ShowDialog();

        }

        private void FiyatGör_Load(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {

        }

       

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
        }
    }
}