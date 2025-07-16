namespace GirisEkranı
{
    partial class FiyatTeklifi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiyatTeklifi));
            chckNormalFiyat = new DevExpress.XtraEditors.CheckEdit();
            label1 = new System.Windows.Forms.Label();
            chckİkinciFiyat = new DevExpress.XtraEditors.CheckEdit();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            btnUrunAdıAra = new DevExpress.XtraEditors.SimpleButton();
            btnFiyatİptal = new DevExpress.XtraEditors.SimpleButton();
            btnİndirimUygula = new DevExpress.XtraEditors.SimpleButton();
            btnİskontoUygula = new DevExpress.XtraEditors.SimpleButton();
            panel1 = new System.Windows.Forms.Panel();
            lblToplamTutar = new System.Windows.Forms.Label();
            btnİndirim = new DevExpress.XtraEditors.SimpleButton();
            btnTeklifiKaydet = new DevExpress.XtraEditors.SimpleButton();
            btnTeklifiYazdır = new DevExpress.XtraEditors.SimpleButton();
            btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)chckNormalFiyat.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chckİkinciFiyat.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chckNormalFiyat
            // 
            chckNormalFiyat.Location = new System.Drawing.Point(81, 66);
            chckNormalFiyat.Name = "chckNormalFiyat";
            chckNormalFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chckNormalFiyat.Properties.Appearance.Options.UseFont = true;
            chckNormalFiyat.Properties.Caption = "Normal Satış Fiyatı Geçerli Olsun";
            chckNormalFiyat.Size = new System.Drawing.Size(467, 40);
            chckNormalFiyat.TabIndex = 0;
            chckNormalFiyat.CheckedChanged += chckNormalFiyat_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Tahoma", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            label1.Location = new System.Drawing.Point(454, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(359, 41);
            label1.TabIndex = 1;
            label1.Text = "Fiyat Teklifi Sayfası ";
            // 
            // chckİkinciFiyat
            // 
            chckİkinciFiyat.Location = new System.Drawing.Point(729, 66);
            chckİkinciFiyat.Name = "chckİkinciFiyat";
            chckİkinciFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chckİkinciFiyat.Properties.Appearance.Options.UseFont = true;
            chckİkinciFiyat.Properties.Caption = "2. Satış Fiyatı Geçerli Olsun";
            chckİkinciFiyat.Size = new System.Drawing.Size(389, 40);
            chckİkinciFiyat.TabIndex = 2;
            chckİkinciFiyat.CheckedChanged += chckİkinciFiyat_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(2, 185);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(1200, 407);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            // 
            // btnUrunAdıAra
            // 
            btnUrunAdıAra.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            btnUrunAdıAra.Appearance.Options.UseFont = true;
            btnUrunAdıAra.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnUrunAdıAra.ImageOptions.Image");
            btnUrunAdıAra.Location = new System.Drawing.Point(434, 128);
            btnUrunAdıAra.Name = "btnUrunAdıAra";
            btnUrunAdıAra.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnUrunAdıAra.Size = new System.Drawing.Size(193, 51);
            btnUrunAdıAra.TabIndex = 6;
            btnUrunAdıAra.Text = "Ürün Ekle";
            btnUrunAdıAra.Click += btnUrunAdıAra_Click;
            // 
            // btnFiyatİptal
            // 
            btnFiyatİptal.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            btnFiyatİptal.Appearance.Options.UseFont = true;
            btnFiyatİptal.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnFiyatİptal.ImageOptions.Image");
            btnFiyatİptal.Location = new System.Drawing.Point(656, 128);
            btnFiyatİptal.Name = "btnFiyatİptal";
            btnFiyatİptal.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnFiyatİptal.Size = new System.Drawing.Size(234, 51);
            btnFiyatİptal.TabIndex = 7;
            btnFiyatİptal.Text = "Fiyat Teklifini İptal Et";
            btnFiyatİptal.Click += btnFiyatİptal_Click;
            // 
            // btnİndirimUygula
            // 
            btnİndirimUygula.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            btnİndirimUygula.Appearance.Options.UseFont = true;
            btnİndirimUygula.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnİndirimUygula.ImageOptions.Image");
            btnİndirimUygula.Location = new System.Drawing.Point(7, 609);
            btnİndirimUygula.Name = "btnİndirimUygula";
            btnİndirimUygula.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnİndirimUygula.Size = new System.Drawing.Size(197, 51);
            btnİndirimUygula.TabIndex = 8;
            btnİndirimUygula.Text = "İndirim Uygula";
            btnİndirimUygula.Click += btnİndirimUygula_Click;
            // 
            // btnİskontoUygula
            // 
            btnİskontoUygula.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            btnİskontoUygula.Appearance.Options.UseFont = true;
            btnİskontoUygula.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnİskontoUygula.ImageOptions.Image");
            btnİskontoUygula.Location = new System.Drawing.Point(210, 609);
            btnİskontoUygula.Name = "btnİskontoUygula";
            btnİskontoUygula.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnİskontoUygula.Size = new System.Drawing.Size(199, 51);
            btnİskontoUygula.TabIndex = 9;
            btnİskontoUygula.Text = "İskonto Uygula";
            btnİskontoUygula.Click += btnİskontoUygula_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.SteelBlue;
            panel1.Controls.Add(lblToplamTutar);
            panel1.Location = new System.Drawing.Point(851, 598);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(341, 116);
            panel1.TabIndex = 10;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblToplamTutar.ForeColor = System.Drawing.Color.White;
            lblToplamTutar.Location = new System.Drawing.Point(21, 11);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new System.Drawing.Size(147, 72);
            lblToplamTutar.TabIndex = 0;
            lblToplamTutar.Text = "0,00";
            // 
            // btnİndirim
            // 
            btnİndirim.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            btnİndirim.Appearance.Options.UseFont = true;
            btnİndirim.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnİndirim.ImageOptions.Image");
            btnİndirim.Location = new System.Drawing.Point(434, 609);
            btnİndirim.Name = "btnİndirim";
            btnİndirim.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnİndirim.Size = new System.Drawing.Size(256, 51);
            btnİndirim.TabIndex = 12;
            btnİndirim.Text = "İndirim/İskonto iptal et";
            // 
            // btnTeklifiKaydet
            // 
            btnTeklifiKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            btnTeklifiKaydet.Appearance.Options.UseFont = true;
            btnTeklifiKaydet.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnTeklifiKaydet.ImageOptions.Image");
            btnTeklifiKaydet.Location = new System.Drawing.Point(12, 678);
            btnTeklifiKaydet.Name = "btnTeklifiKaydet";
            btnTeklifiKaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnTeklifiKaydet.Size = new System.Drawing.Size(194, 36);
            btnTeklifiKaydet.TabIndex = 13;
            btnTeklifiKaydet.Text = "Teklifi Kaydet";
            btnTeklifiKaydet.Click += btnTeklifiKaydet_Click;
            // 
            // btnTeklifiYazdır
            // 
            btnTeklifiYazdır.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            btnTeklifiYazdır.Appearance.Options.UseFont = true;
            btnTeklifiYazdır.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnTeklifiYazdır.ImageOptions.Image");
            btnTeklifiYazdır.Location = new System.Drawing.Point(212, 668);
            btnTeklifiYazdır.Name = "btnTeklifiYazdır";
            btnTeklifiYazdır.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnTeklifiYazdır.Size = new System.Drawing.Size(174, 46);
            btnTeklifiYazdır.TabIndex = 14;
            btnTeklifiYazdır.Text = "Teklifi Yazdır";
            btnTeklifiYazdır.Click += btnTeklifiYazdır_Click;
            // 
            // btnVazgec
            // 
            btnVazgec.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnVazgec.ImageOptions.Image");
            btnVazgec.Location = new System.Drawing.Point(1157, 4);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnVazgec.Size = new System.Drawing.Size(45, 41);
            btnVazgec.TabIndex = 15;
            btnVazgec.Click += btnVazgec_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(714, 609);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(131, 48);
            label2.TabIndex = 16;
            label2.Text = "Fiyat :";
            // 
            // FiyatTeklifi
            // 
            Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            Appearance.ForeColor = System.Drawing.Color.Transparent;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseForeColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1204, 726);
            Controls.Add(label2);
            Controls.Add(btnVazgec);
            Controls.Add(btnTeklifiYazdır);
            Controls.Add(btnTeklifiKaydet);
            Controls.Add(btnİndirim);
            Controls.Add(panel1);
            Controls.Add(btnİskontoUygula);
            Controls.Add(btnİndirimUygula);
            Controls.Add(btnFiyatİptal);
            Controls.Add(btnUrunAdıAra);
            Controls.Add(dataGridView1);
            Controls.Add(chckİkinciFiyat);
            Controls.Add(label1);
            Controls.Add(chckNormalFiyat);
            Name = "FiyatTeklifi";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FiyatTeklifi";
            Load += FiyatTeklifi_Load;
            ((System.ComponentModel.ISupportInitialize)chckNormalFiyat.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)chckİkinciFiyat.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chckNormalFiyat;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckEdit chckİkinciFiyat;
        private DevExpress.XtraEditors.SimpleButton btnUrunAdıAra;
        private DevExpress.XtraEditors.SimpleButton btnFiyatİptal;
        private DevExpress.XtraEditors.SimpleButton btnİndirimUygula;
        private DevExpress.XtraEditors.SimpleButton btnİskontoUygula;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblToplamTutar;
        private DevExpress.XtraEditors.SimpleButton btnİndirim;
        private DevExpress.XtraEditors.SimpleButton btnTeklifiKaydet;
        private DevExpress.XtraEditors.SimpleButton btnTeklifiYazdır;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}