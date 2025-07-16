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
using static GirisEkranı.Program;

namespace GirisEkranı
{
    public partial class EkranKlavyesi : DevExpress.XtraEditors.XtraForm
    {
        public TextBox TargetTextBox { get; set; }
        public EkranKlavyesi()
        {
            InitializeComponent();                      
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (TargetTextBox == null) return;

            Button clickedButton = sender as Button;
            string btnText = clickedButton.Text;

            int selectionStart = TargetTextBox.SelectionStart;

            switch (btnText)
            {
                case "Sil":
                    if (selectionStart > 0)
                    {
                        TargetTextBox.Text = TargetTextBox.Text.Remove(selectionStart - 1, 1);
                        TargetTextBox.SelectionStart = selectionStart - 1;
                    }
                    break;

                case "Enter":
                    this.Close();
                    break;

                default:
                    TargetTextBox.Text = TargetTextBox.Text.Insert(selectionStart, btnText);
                    TargetTextBox.SelectionStart = selectionStart + btnText.Length;
                    break;
            }
        }

        private void EkranKlavyesi_Load(object sender, EventArgs e)
        {
            // Butonlara tıklama olaylarını ekle
            foreach (Control control in this.Controls)
            {
                if (control is Button btn)
                {
                    btn.Click += Button_Click;
                }

                // Form üzerindeki TextBox'lara tıklanınca hedef olarak ayarla
                if (control is TextBox txt)
                {
                    txt.Click += (s, ev) =>
                    {
                        if (GlobalForms.KlavyeForm != null && !GlobalForms.KlavyeForm.IsDisposed)
                        {
                            GlobalForms.KlavyeForm.TargetTextBox = (TextBox)s;
                        }
                    };
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}