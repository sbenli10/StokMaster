using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GirisEkranı.Program;

namespace GirisEkranı
{
    public partial class AnaSayfa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            ÜrünGirisi ürünGirisi = new ÜrünGirisi();
            ürünGirisi.Show();
            this.Hide(); 
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

            Satısİslemi satısİslemi = new Satısİslemi();
            satısİslemi.Show();
            this.Hide(); 
        }

        private void btnFiyatTeklifi_ItemClick(object sender, ItemClickEventArgs e)
        {

            FiyatTeklifi fiyatTeklifi = new FiyatTeklifi();
            fiyatTeklifi.Show();
            this.Hide(); 
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            FiyatGör fiyatGör = new FiyatGör();
            fiyatGör.Show();
            this.Hide(); 
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            MusteriBilgileri musteriBilgileri = new MusteriBilgileri();
            musteriBilgileri.Show();
            this.Hide(); 
        }

        private void btnBarkodOkut_ItemClick(object sender, ItemClickEventArgs e)
        {
            BarkodOkuyucu barkodOkuyucu = new BarkodOkuyucu();
            barkodOkuyucu.Show();
            this.Hide(); 
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            MusterİadeAl musterİadeAl = new MusterİadeAl();
            musterİadeAl.Show();
            this.Hide();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Stoklar stoklar = new Stoklar();
            stoklar.Show();
            this.Hide();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            SifreGüncelle sifreGüncelle = new SifreGüncelle();
            sifreGüncelle.Show();
            this.Hide();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            Toptancılar toptancılar = new Toptancılar();
            toptancılar.Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            Ajanda ajanda = new Ajanda();
            ajanda.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (GlobalForms.KlavyeForm == null || GlobalForms.KlavyeForm.IsDisposed)
            {
                GlobalForms.KlavyeForm = new EkranKlavyesi();
                GlobalForms.KlavyeForm.TopMost = true;
                GlobalForms.KlavyeForm.Show();
            }
            else
            {
                GlobalForms.KlavyeForm.BringToFront();
            }

        }
    }
}