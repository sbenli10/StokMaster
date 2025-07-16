using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GirisEkranı
{
    public class BaseForm: DevExpress.XtraEditors.XtraForm
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                AttachTextBoxHandlers(this.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klavye kontrolü sırasında hata oluştu: " + ex.Message);
            }
        }

        private void AttachTextBoxHandlers(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox txt)
                {
                    txt.Click += (s, ev) =>
                    {
                        if (GlobalForms.KlavyeForm != null &&
                            !GlobalForms.KlavyeForm.IsDisposed &&
                            GlobalForms.KlavyeForm.Visible)
                        {
                            GlobalForms.KlavyeForm.TargetTextBox = txt;
                        }
                    };
                }
                else if (control.HasChildren)
                {
                    AttachTextBoxHandlers(control.Controls); 
                }
            }
        }
    }
}
