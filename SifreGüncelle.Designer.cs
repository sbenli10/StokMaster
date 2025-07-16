namespace GirisEkranı
{
    partial class SifreGüncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreGüncelle));
            label1 = new System.Windows.Forms.Label();
            txtSifre = new System.Windows.Forms.TextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            btnKapat = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Black;
            label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(91, 143);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 21);
            label1.TabIndex = 0;
            label1.Text = "Şifre :";
            // 
            // txtSifre
            // 
            txtSifre.Font = new System.Drawing.Font("Tahoma", 10.8F);
            txtSifre.Location = new System.Drawing.Point(151, 144);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new System.Drawing.Size(205, 29);
            txtSifre.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Tahoma", 10.8F);
            textBox1.Location = new System.Drawing.Point(151, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(205, 29);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Black;
            label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(24, 186);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(121, 21);
            label2.TabIndex = 2;
            label2.Text = "Şifre (Tekrar) :";
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.Appearance.Options.UseForeColor = true;
            simpleButton1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnGuncelle.ImageOptions.Image");
            simpleButton1.Location = new System.Drawing.Point(151, 247);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton1.Size = new System.Drawing.Size(205, 51);
            simpleButton1.TabIndex = 4;
            simpleButton1.Text = "Güncelle";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // btnKapat
            // 
            btnKapat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnKapat.Appearance.ForeColor = System.Drawing.Color.White;
            btnKapat.Appearance.Options.UseFont = true;
            btnKapat.Appearance.Options.UseForeColor = true;
            btnKapat.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnKapat.ImageOptions.Image");
            btnKapat.Location = new System.Drawing.Point(463, 1);
            btnKapat.Name = "btnKapat";
            btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnKapat.Size = new System.Drawing.Size(39, 32);
            btnKapat.TabIndex = 5;
            btnKapat.Click += btnKapat_Click;
            // 
            // SifreGüncelle
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            BackgroundImageStore = (System.Drawing.Image)resources.GetObject("$this.BackgroundImageStore");
            ClientSize = new System.Drawing.Size(500, 364);
            Controls.Add(btnKapat);
            Controls.Add(simpleButton1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(txtSifre);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "SifreGüncelle";
            Text = "SifreGüncelle";
            Load += SifreGüncelle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}