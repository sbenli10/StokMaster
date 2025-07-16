namespace GirisEkranı
{
    partial class MüsteriÖdemeAlma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MüsteriÖdemeAlma));
            label2 = new System.Windows.Forms.Label();
            txtMusteriAdı = new System.Windows.Forms.TextBox();
            msktxtTarih = new System.Windows.Forms.MaskedTextBox();
            txtToplamBorc = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtÖdemeTutarı = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtAcıklama = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            radioBtnHavale = new System.Windows.Forms.RadioButton();
            radioBtnKrediKartı = new System.Windows.Forms.RadioButton();
            radioBtnNakit = new System.Windows.Forms.RadioButton();
            btnOnayla = new DevExpress.XtraEditors.SimpleButton();
            btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            btnYazdır = new DevExpress.XtraEditors.SimpleButton();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new System.Windows.Forms.PrintDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 10.8F);
            label2.Location = new System.Drawing.Point(23, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(124, 22);
            label2.TabIndex = 1;
            label2.Text = "Müşterini Adı :";
            // 
            // txtMusteriAdı
            // 
            txtMusteriAdı.Font = new System.Drawing.Font("Tahoma", 10.8F);
            txtMusteriAdı.Location = new System.Drawing.Point(155, 17);
            txtMusteriAdı.Name = "txtMusteriAdı";
            txtMusteriAdı.Size = new System.Drawing.Size(289, 29);
            txtMusteriAdı.TabIndex = 2;
            // 
            // msktxtTarih
            // 
            msktxtTarih.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            msktxtTarih.Location = new System.Drawing.Point(155, 124);
            msktxtTarih.Mask = "00/00/0000";
            msktxtTarih.Name = "msktxtTarih";
            msktxtTarih.Size = new System.Drawing.Size(289, 32);
            msktxtTarih.TabIndex = 3;
            msktxtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtToplamBorc
            // 
            txtToplamBorc.Font = new System.Drawing.Font("Tahoma", 10.8F);
            txtToplamBorc.Location = new System.Drawing.Point(155, 71);
            txtToplamBorc.Name = "txtToplamBorc";
            txtToplamBorc.Size = new System.Drawing.Size(289, 29);
            txtToplamBorc.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 10.8F);
            label3.Location = new System.Drawing.Point(23, 74);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(122, 22);
            label3.TabIndex = 4;
            label3.Text = "Toplam Borç :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 10.8F);
            label4.Location = new System.Drawing.Point(83, 129);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 22);
            label4.TabIndex = 6;
            label4.Text = "Tarih :";
            // 
            // txtÖdemeTutarı
            // 
            txtÖdemeTutarı.Font = new System.Drawing.Font("Tahoma", 10.8F);
            txtÖdemeTutarı.Location = new System.Drawing.Point(155, 181);
            txtÖdemeTutarı.Name = "txtÖdemeTutarı";
            txtÖdemeTutarı.Size = new System.Drawing.Size(289, 29);
            txtÖdemeTutarı.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Tahoma", 10.8F);
            label5.Location = new System.Drawing.Point(23, 184);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(130, 22);
            label5.TabIndex = 7;
            label5.Text = "Ödeme Tutarı :";
            // 
            // txtAcıklama
            // 
            txtAcıklama.Font = new System.Drawing.Font("Tahoma", 10.8F);
            txtAcıklama.Location = new System.Drawing.Point(155, 236);
            txtAcıklama.Multiline = true;
            txtAcıklama.Name = "txtAcıklama";
            txtAcıklama.Size = new System.Drawing.Size(289, 72);
            txtAcıklama.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Tahoma", 10.8F);
            label6.Location = new System.Drawing.Point(54, 239);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(91, 22);
            label6.TabIndex = 9;
            label6.Text = "Açıklama :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioBtnHavale);
            groupBox1.Controls.Add(radioBtnKrediKartı);
            groupBox1.Controls.Add(radioBtnNakit);
            groupBox1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.Location = new System.Drawing.Point(12, 326);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(562, 97);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ödeme Türü";
            // 
            // radioBtnHavale
            // 
            radioBtnHavale.AutoSize = true;
            radioBtnHavale.Location = new System.Drawing.Point(396, 47);
            radioBtnHavale.Name = "radioBtnHavale";
            radioBtnHavale.Size = new System.Drawing.Size(101, 32);
            radioBtnHavale.TabIndex = 2;
            radioBtnHavale.TabStop = true;
            radioBtnHavale.Text = "Havale";
            radioBtnHavale.UseVisualStyleBackColor = true;
            // 
            // radioBtnKrediKartı
            // 
            radioBtnKrediKartı.AutoSize = true;
            radioBtnKrediKartı.Location = new System.Drawing.Point(203, 47);
            radioBtnKrediKartı.Name = "radioBtnKrediKartı";
            radioBtnKrediKartı.Size = new System.Drawing.Size(139, 32);
            radioBtnKrediKartı.TabIndex = 1;
            radioBtnKrediKartı.TabStop = true;
            radioBtnKrediKartı.Text = "Kredi Kartı";
            radioBtnKrediKartı.UseVisualStyleBackColor = true;
            // 
            // radioBtnNakit
            // 
            radioBtnNakit.AutoSize = true;
            radioBtnNakit.Location = new System.Drawing.Point(71, 47);
            radioBtnNakit.Name = "radioBtnNakit";
            radioBtnNakit.Size = new System.Drawing.Size(84, 32);
            radioBtnNakit.TabIndex = 0;
            radioBtnNakit.TabStop = true;
            radioBtnNakit.Text = "Nakit";
            radioBtnNakit.UseVisualStyleBackColor = true;
            // 
            // btnOnayla
            // 
            btnOnayla.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOnayla.Appearance.Options.UseFont = true;
            btnOnayla.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnOnayla.ImageOptions.Image");
            btnOnayla.Location = new System.Drawing.Point(16, 439);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnOnayla.Size = new System.Drawing.Size(129, 43);
            btnOnayla.TabIndex = 12;
            btnOnayla.Text = "Onayla";
            btnOnayla.Click += btnOnayla_Click;
            // 
            // btnVazgec
            // 
            btnVazgec.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnVazgec.Appearance.Options.UseFont = true;
            btnVazgec.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnVazgec.ImageOptions.Image");
            btnVazgec.Location = new System.Drawing.Point(180, 439);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnVazgec.Size = new System.Drawing.Size(129, 43);
            btnVazgec.TabIndex = 13;
            btnVazgec.Text = "Vazgeç";
            // 
            // btnYazdır
            // 
            btnYazdır.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnYazdır.Appearance.Options.UseFont = true;
            btnYazdır.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnYazdır.ImageOptions.Image");
            btnYazdır.Location = new System.Drawing.Point(331, 443);
            btnYazdır.Name = "btnYazdır";
            btnYazdır.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnYazdır.Size = new System.Drawing.Size(243, 43);
            btnYazdır.TabIndex = 14;
            btnYazdır.Text = "Ödeme Bilgisini Yazdır";
            btnYazdır.Click += btnYazdır_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // MüsteriÖdemeAlma
            // 
            Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(586, 498);
            Controls.Add(btnYazdır);
            Controls.Add(btnVazgec);
            Controls.Add(btnOnayla);
            Controls.Add(groupBox1);
            Controls.Add(txtAcıklama);
            Controls.Add(label6);
            Controls.Add(txtÖdemeTutarı);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtToplamBorc);
            Controls.Add(label3);
            Controls.Add(msktxtTarih);
            Controls.Add(txtMusteriAdı);
            Controls.Add(label2);
            Name = "MüsteriÖdemeAlma";
            Text = "MüsteriÖdemeAlma";
            Load += MüsteriÖdemeAlma_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusteriAdı;
        private System.Windows.Forms.MaskedTextBox msktxtTarih;
        private System.Windows.Forms.TextBox txtToplamBorc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtÖdemeTutarı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAcıklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnOnayla;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnYazdır;
        private System.Windows.Forms.RadioButton radioBtnHavale;
        private System.Windows.Forms.RadioButton radioBtnKrediKartı;
        private System.Windows.Forms.RadioButton radioBtnNakit;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}