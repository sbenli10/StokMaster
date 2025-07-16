namespace GirisEkranı
{
    partial class BarkodOkuyucu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarkodOkuyucu));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnBarcodeOlustur = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.White;
            pictureBox1.Location = new System.Drawing.Point(66, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(634, 339);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox1.Location = new System.Drawing.Point(140, 464);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(481, 28);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(45, 467);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 21);
            label1.TabIndex = 2;
            label1.Text = "Ürün Kod :";
            // 
            // btnBarcodeOlustur
            // 
            btnBarcodeOlustur.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            btnBarcodeOlustur.Appearance.ForeColor = System.Drawing.Color.Black;
            btnBarcodeOlustur.Appearance.Options.UseFont = true;
            btnBarcodeOlustur.Appearance.Options.UseForeColor = true;
            btnBarcodeOlustur.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnBarcodeOlustur.ImageOptions.Image");
            btnBarcodeOlustur.Location = new System.Drawing.Point(120, 567);
            btnBarcodeOlustur.Name = "btnBarcodeOlustur";
            btnBarcodeOlustur.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnBarcodeOlustur.Size = new System.Drawing.Size(219, 50);
            btnBarcodeOlustur.TabIndex = 3;
            btnBarcodeOlustur.Text = "Barkod Oluştur";
            btnBarcodeOlustur.Click += btnBarcodeOlustur_Click;
            btnBarcodeOlustur.KeyDown += btnBarcodeOlustur_KeyDown;
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.Appearance.Options.UseForeColor = true;
            simpleButton1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new System.Drawing.Point(450, 567);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton1.Size = new System.Drawing.Size(171, 50);
            simpleButton1.TabIndex = 4;
            simpleButton1.Text = "QR Oluştur";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // btnVazgec
            // 
            btnVazgec.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnVazgec.ImageOptions.Image");
            btnVazgec.Location = new System.Drawing.Point(724, 2);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnVazgec.Size = new System.Drawing.Size(37, 37);
            btnVazgec.TabIndex = 5;
            btnVazgec.Click += btnVazgec_Click;
            // 
            // BarkodOkuyucu
            // 
            Appearance.BackColor = System.Drawing.SystemColors.ScrollBar;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(763, 679);
            Controls.Add(btnVazgec);
            Controls.Add(simpleButton1);
            Controls.Add(btnBarcodeOlustur);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "BarkodOkuyucu";
            Text = "BarkodOkuyucu";
            Load += BarkodOkuyucu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnBarcodeOlustur;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
    }
}