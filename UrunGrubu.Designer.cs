namespace GirisEkranı
{
    partial class UrunGrubu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunGrubu));
            label1 = new System.Windows.Forms.Label();
            txtUrunGrupAdı = new System.Windows.Forms.TextBox();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            btnVAZGEÇ = new DevExpress.XtraEditors.SimpleButton();
            btnKapat = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(26, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(390, 28);
            label1.TabIndex = 0;
            label1.Text = "Lütfen Yeni Ürün Grubu Adını Yazınız ";
            // 
            // txtUrunGrupAdı
            // 
            txtUrunGrupAdı.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtUrunGrupAdı.Location = new System.Drawing.Point(26, 99);
            txtUrunGrupAdı.Name = "txtUrunGrupAdı";
            txtUrunGrupAdı.Size = new System.Drawing.Size(299, 29);
            txtUrunGrupAdı.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            btnKaydet.Appearance.Options.UseFont = true;
            btnKaydet.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnKaydet.ImageOptions.Image");
            btnKaydet.Location = new System.Drawing.Point(243, 147);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnKaydet.Size = new System.Drawing.Size(118, 38);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnVAZGEÇ
            // 
            btnVAZGEÇ.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            btnVAZGEÇ.Appearance.Options.UseFont = true;
            btnVAZGEÇ.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnVAZGEÇ.ImageOptions.Image");
            btnVAZGEÇ.Location = new System.Drawing.Point(26, 147);
            btnVAZGEÇ.Name = "btnVAZGEÇ";
            btnVAZGEÇ.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnVAZGEÇ.Size = new System.Drawing.Size(174, 38);
            btnVAZGEÇ.TabIndex = 3;
            btnVAZGEÇ.Text = "Ürün Grubu Sil";
            btnVAZGEÇ.Click += btnVAZGEÇ_Click;
            // 
            // btnKapat
            // 
            btnKapat.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            btnKapat.Location = new System.Drawing.Point(495, 3);
            btnKapat.Name = "btnKapat";
            btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnKapat.Size = new System.Drawing.Size(36, 29);
            btnKapat.TabIndex = 4;
            btnKapat.Click += btnKapat_Click;
            // 
            // UrunGrubu
            // 
            Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(530, 230);
            Controls.Add(btnKapat);
            Controls.Add(btnVAZGEÇ);
            Controls.Add(btnKaydet);
            Controls.Add(txtUrunGrupAdı);
            Controls.Add(label1);
            Name = "UrunGrubu";
            Text = "UrunGrubu";
            Load += UrunGrubu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunGrupAdı;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnVAZGEÇ;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}