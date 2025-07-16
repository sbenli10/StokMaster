namespace GirisEkranı
{
    partial class MusteriBorcEkle
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriBorcEkle));
            btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            btnOnayla = new DevExpress.XtraEditors.SimpleButton();
            maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            txtAcıklama = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtEkleTutarı = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtSaat = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtToplamBorc = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtMusteriAdı = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtMusteriSoyad = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnVazgec
            // 
            btnVazgec.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnVazgec.Appearance.Options.UseFont = true;
            btnVazgec.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnVazgec.ImageOptions.Image");
            btnVazgec.Location = new System.Drawing.Point(294, 413);
            btnVazgec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnVazgec.Size = new System.Drawing.Size(135, 46);
            btnVazgec.TabIndex = 40;
            btnVazgec.Text = "Vazgeç";
            btnVazgec.Click += btnVazgec_Click;
            // 
            // btnOnayla
            // 
            btnOnayla.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOnayla.Appearance.Options.UseFont = true;
            btnOnayla.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnOnayla.ImageOptions.Image");
            btnOnayla.Location = new System.Drawing.Point(91, 413);
            btnOnayla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnOnayla.Size = new System.Drawing.Size(146, 46);
            btnOnayla.TabIndex = 39;
            btnOnayla.Text = "Onayla";
            btnOnayla.Click += btnOnayla_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            maskedTextBox1.Location = new System.Drawing.Point(179, 169);
            maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new System.Drawing.Size(250, 34);
            maskedTextBox1.TabIndex = 38;
            maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // txtAcıklama
            // 
            txtAcıklama.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtAcıklama.Location = new System.Drawing.Point(178, 312);
            txtAcıklama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtAcıklama.Multiline = true;
            txtAcıklama.Name = "txtAcıklama";
            txtAcıklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtAcıklama.Size = new System.Drawing.Size(251, 86);
            txtAcıklama.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            label5.Location = new System.Drawing.Point(72, 315);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(100, 28);
            label5.TabIndex = 36;
            label5.Text = "Açıklama :";
            // 
            // txtEkleTutarı
            // 
            txtEkleTutarı.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtEkleTutarı.Location = new System.Drawing.Point(179, 261);
            txtEkleTutarı.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtEkleTutarı.Name = "txtEkleTutarı";
            txtEkleTutarı.Size = new System.Drawing.Size(250, 34);
            txtEkleTutarı.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            label6.Location = new System.Drawing.Point(11, 264);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(156, 28);
            label6.TabIndex = 34;
            label6.Text = "Eklenecek Tutar :";
            // 
            // txtSaat
            // 
            txtSaat.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtSaat.Location = new System.Drawing.Point(179, 219);
            txtSaat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtSaat.Name = "txtSaat";
            txtSaat.Size = new System.Drawing.Size(250, 34);
            txtSaat.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(105, 225);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 28);
            label3.TabIndex = 32;
            label3.Text = "Saat :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            label4.Location = new System.Drawing.Point(105, 174);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 28);
            label4.TabIndex = 31;
            label4.Text = "Tarih :";
            // 
            // txtToplamBorc
            // 
            txtToplamBorc.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtToplamBorc.Location = new System.Drawing.Point(179, 125);
            txtToplamBorc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtToplamBorc.Name = "txtToplamBorc";
            txtToplamBorc.Size = new System.Drawing.Size(250, 34);
            txtToplamBorc.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(47, 125);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(129, 28);
            label2.TabIndex = 29;
            label2.Text = "Toplam Borç :";
            // 
            // txtMusteriAdı
            // 
            txtMusteriAdı.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtMusteriAdı.Location = new System.Drawing.Point(181, 22);
            txtMusteriAdı.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtMusteriAdı.Name = "txtMusteriAdı";
            txtMusteriAdı.Size = new System.Drawing.Size(250, 34);
            txtMusteriAdı.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Location = new System.Drawing.Point(47, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(122, 28);
            label1.TabIndex = 27;
            label1.Text = "Müşteri Adı :";
            // 
            // txtMusteriSoyad
            // 
            txtMusteriSoyad.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtMusteriSoyad.Location = new System.Drawing.Point(180, 77);
            txtMusteriSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtMusteriSoyad.Name = "txtMusteriSoyad";
            txtMusteriSoyad.Size = new System.Drawing.Size(250, 34);
            txtMusteriSoyad.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            label7.Location = new System.Drawing.Point(25, 77);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(147, 28);
            label7.TabIndex = 41;
            label7.Text = "Müşteri Soyad :";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 60000;
            timer1.Tick += timer1_Tick;
            // 
            // MusteriBorcEkle
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(475, 467);
            Controls.Add(txtMusteriSoyad);
            Controls.Add(label7);
            Controls.Add(btnVazgec);
            Controls.Add(btnOnayla);
            Controls.Add(maskedTextBox1);
            Controls.Add(txtAcıklama);
            Controls.Add(label5);
            Controls.Add(txtEkleTutarı);
            Controls.Add(label6);
            Controls.Add(txtSaat);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtToplamBorc);
            Controls.Add(label2);
            Controls.Add(txtMusteriAdı);
            Controls.Add(label1);
            Name = "MusteriBorcEkle";
            Text = "MusteriBorcEkle";
            Load += MusteriBorcEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnOnayla;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox txtAcıklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEkleTutarı;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToplamBorc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusteriAdı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}