using System;

namespace GirisEkranı
{
    partial class Stoklar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stoklar));
            label1 = new System.Windows.Forms.Label();
            txtBarkodNo = new System.Windows.Forms.TextBox();
            txtUrunAdı = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtUrunGrubu = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtStokKodu = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtSatısFiyatı = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtAlısFiyatı = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtMevcutStok = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txtAsgariStok = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txtKdvOranı = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            txtİkinciSatısFiyatı = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            btnUrunuDüzelt = new DevExpress.XtraEditors.SimpleButton();
            btnUrunSil = new DevExpress.XtraEditors.SimpleButton();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            textBox1 = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            cmboxSıralama = new System.Windows.Forms.ComboBox();
            label12 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            btnUrunGrupları = new DevExpress.XtraEditors.SimpleButton();
            btnUrunEkle = new DevExpress.XtraEditors.SimpleButton();
            btnKapat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 12F);
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(115, 24);
            label1.TabIndex = 0;
            label1.Text = "Barkod No :";
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Font = new System.Drawing.Font("Tahoma", 12F);
            txtBarkodNo.Location = new System.Drawing.Point(133, 6);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new System.Drawing.Size(343, 32);
            txtBarkodNo.TabIndex = 1;
            // 
            // txtUrunAdı
            // 
            txtUrunAdı.Font = new System.Drawing.Font("Tahoma", 12F);
            txtUrunAdı.Location = new System.Drawing.Point(133, 55);
            txtUrunAdı.Name = "txtUrunAdı";
            txtUrunAdı.Size = new System.Drawing.Size(343, 32);
            txtUrunAdı.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 12F);
            label2.Location = new System.Drawing.Point(12, 58);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 24);
            label2.TabIndex = 2;
            label2.Text = "Ürün Adı :";
            // 
            // txtUrunGrubu
            // 
            txtUrunGrubu.Font = new System.Drawing.Font("Tahoma", 12F);
            txtUrunGrubu.Location = new System.Drawing.Point(133, 150);
            txtUrunGrubu.Name = "txtUrunGrubu";
            txtUrunGrubu.Size = new System.Drawing.Size(343, 32);
            txtUrunGrubu.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 12F);
            label3.Location = new System.Drawing.Point(12, 153);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(124, 24);
            label3.TabIndex = 6;
            label3.Text = "Ürün Grubu :";
            // 
            // txtStokKodu
            // 
            txtStokKodu.Font = new System.Drawing.Font("Tahoma", 12F);
            txtStokKodu.Location = new System.Drawing.Point(133, 102);
            txtStokKodu.Name = "txtStokKodu";
            txtStokKodu.Size = new System.Drawing.Size(343, 32);
            txtStokKodu.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 12F);
            label4.Location = new System.Drawing.Point(12, 105);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(113, 24);
            label4.TabIndex = 4;
            label4.Text = "Stok Kodu :";
            // 
            // txtSatısFiyatı
            // 
            txtSatısFiyatı.Font = new System.Drawing.Font("Tahoma", 12F);
            txtSatısFiyatı.Location = new System.Drawing.Point(133, 206);
            txtSatısFiyatı.Name = "txtSatısFiyatı";
            txtSatısFiyatı.Size = new System.Drawing.Size(208, 32);
            txtSatısFiyatı.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Tahoma", 12F);
            label5.Location = new System.Drawing.Point(12, 209);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(120, 24);
            label5.TabIndex = 8;
            label5.Text = "Satış Fiyatı :";
            // 
            // txtAlısFiyatı
            // 
            txtAlısFiyatı.Font = new System.Drawing.Font("Tahoma", 12F);
            txtAlısFiyatı.Location = new System.Drawing.Point(133, 258);
            txtAlısFiyatı.Name = "txtAlısFiyatı";
            txtAlısFiyatı.Size = new System.Drawing.Size(208, 32);
            txtAlısFiyatı.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Tahoma", 12F);
            label6.Location = new System.Drawing.Point(12, 261);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(108, 24);
            label6.TabIndex = 10;
            label6.Text = "Alış Fiyatı :";
            // 
            // txtMevcutStok
            // 
            txtMevcutStok.Font = new System.Drawing.Font("Tahoma", 12F);
            txtMevcutStok.Location = new System.Drawing.Point(133, 306);
            txtMevcutStok.Name = "txtMevcutStok";
            txtMevcutStok.Size = new System.Drawing.Size(208, 32);
            txtMevcutStok.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Tahoma", 12F);
            label7.Location = new System.Drawing.Point(12, 309);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(125, 24);
            label7.TabIndex = 12;
            label7.Text = "Mevcut Stok:";
            // 
            // txtAsgariStok
            // 
            txtAsgariStok.Font = new System.Drawing.Font("Tahoma", 12F);
            txtAsgariStok.Location = new System.Drawing.Point(480, 303);
            txtAsgariStok.Name = "txtAsgariStok";
            txtAsgariStok.Size = new System.Drawing.Size(208, 32);
            txtAsgariStok.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Tahoma", 12F);
            label8.Location = new System.Drawing.Point(359, 306);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(117, 24);
            label8.TabIndex = 18;
            label8.Text = "Asgari Stok:";
            // 
            // txtKdvOranı
            // 
            txtKdvOranı.Font = new System.Drawing.Font("Tahoma", 12F);
            txtKdvOranı.Location = new System.Drawing.Point(480, 255);
            txtKdvOranı.Name = "txtKdvOranı";
            txtKdvOranı.Size = new System.Drawing.Size(208, 32);
            txtKdvOranı.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Tahoma", 12F);
            label9.Location = new System.Drawing.Point(347, 263);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(141, 24);
            label9.TabIndex = 16;
            label9.Text = "KDV Oranı %: ";
            // 
            // txtİkinciSatısFiyatı
            // 
            txtİkinciSatısFiyatı.Font = new System.Drawing.Font("Tahoma", 12F);
            txtİkinciSatısFiyatı.Location = new System.Drawing.Point(480, 203);
            txtİkinciSatısFiyatı.Name = "txtİkinciSatısFiyatı";
            txtİkinciSatısFiyatı.Size = new System.Drawing.Size(208, 32);
            txtİkinciSatısFiyatı.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Tahoma", 12F);
            label10.Location = new System.Drawing.Point(347, 206);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(137, 24);
            label10.TabIndex = 14;
            label10.Text = "2.Satış Fiyatı :";
            // 
            // btnUrunuDüzelt
            // 
            btnUrunuDüzelt.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            btnUrunuDüzelt.Appearance.Options.UseFont = true;
            btnUrunuDüzelt.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnUrunuDüzelt.ImageOptions.Image");
            btnUrunuDüzelt.Location = new System.Drawing.Point(6, 211);
            btnUrunuDüzelt.Name = "btnUrunuDüzelt";
            btnUrunuDüzelt.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnUrunuDüzelt.Size = new System.Drawing.Size(206, 39);
            btnUrunuDüzelt.TabIndex = 20;
            btnUrunuDüzelt.Text = "Ürünü Düzelt";
            btnUrunuDüzelt.Click += btnUrunuDüzelt_Click;
            // 
            // btnUrunSil
            // 
            btnUrunSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            btnUrunSil.Appearance.Options.UseFont = true;
            btnUrunSil.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnUrunSil.ImageOptions.Image");
            btnUrunSil.Location = new System.Drawing.Point(6, 276);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnUrunSil.Size = new System.Drawing.Size(206, 44);
            btnUrunSil.TabIndex = 21;
            btnUrunSil.Text = "Ürünü Sil";
            btnUrunSil.Click += btnUrunSil_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(7, 441);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(924, 271);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.Yellow;
            textBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            textBox1.Location = new System.Drawing.Point(107, 398);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(260, 32);
            textBox1.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Tahoma", 12F);
            label11.Location = new System.Drawing.Point(12, 401);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(99, 24);
            label11.TabIndex = 23;
            label11.Text = "Ürün Adı :";
            // 
            // cmboxSıralama
            // 
            cmboxSıralama.BackColor = System.Drawing.Color.Yellow;
            cmboxSıralama.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cmboxSıralama.FormattingEnabled = true;
            cmboxSıralama.Items.AddRange(new object[] { "Ürün Adı", "Ürün Fiyatı", "Barkod No", "Ürün Grubu" });
            cmboxSıralama.Location = new System.Drawing.Point(514, 395);
            cmboxSıralama.Name = "cmboxSıralama";
            cmboxSıralama.Size = new System.Drawing.Size(218, 32);
            cmboxSıralama.TabIndex = 25;
            cmboxSıralama.Text = "Tümü";
            cmboxSıralama.SelectedIndexChanged += cmboxSıralama_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Tahoma", 12F);
            label12.Location = new System.Drawing.Point(435, 398);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(73, 24);
            label12.TabIndex = 26;
            label12.Text = "Sırala :";
            // 
            // groupBox1
            // 
            
            groupBox1.Controls.Add(simpleButton1);
            groupBox1.Controls.Add(btnUrunGrupları);
            groupBox1.Controls.Add(btnUrunEkle);
            groupBox1.Controls.Add(btnUrunuDüzelt);
            groupBox1.Controls.Add(btnUrunSil);
            groupBox1.Location = new System.Drawing.Point(708, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(214, 340);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new System.Drawing.Point(6, 152);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton1.Size = new System.Drawing.Size(169, 43);
            simpleButton1.TabIndex = 2;
            simpleButton1.Text = "Ürün Detayları";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // btnUrunGrupları
            // 
            btnUrunGrupları.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnUrunGrupları.Appearance.Options.UseFont = true;
            btnUrunGrupları.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnUrunGrupları.ImageOptions.Image");
            btnUrunGrupları.Location = new System.Drawing.Point(6, 88);
            btnUrunGrupları.Name = "btnUrunGrupları";
            btnUrunGrupları.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnUrunGrupları.Size = new System.Drawing.Size(169, 43);
            btnUrunGrupları.TabIndex = 1;
            btnUrunGrupları.Text = "Ürün Grupları";
            btnUrunGrupları.Click += btnUrunGrupları_Click;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnUrunEkle.Appearance.Options.UseFont = true;
            btnUrunEkle.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnUrunEkle.ImageOptions.SvgImage");
            btnUrunEkle.Location = new System.Drawing.Point(6, 22);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnUrunEkle.Size = new System.Drawing.Size(169, 43);
            btnUrunEkle.TabIndex = 0;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // btnKapat
            // 
            btnKapat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            btnKapat.Appearance.Options.UseFont = true;
            btnKapat.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton2.ImageOptions.Image");
            btnKapat.Location = new System.Drawing.Point(896, -5);
            btnKapat.Name = "btnKapat";
            btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnKapat.Size = new System.Drawing.Size(35, 38);
            btnKapat.TabIndex = 22;
            btnKapat.Click += btnKapat_Click;
            // 
            // Stoklar
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(934, 718);
            Controls.Add(btnKapat);
            Controls.Add(groupBox1);
            Controls.Add(label12);
            Controls.Add(cmboxSıralama);
            Controls.Add(textBox1);
            Controls.Add(label11);
            Controls.Add(dataGridView1);
            Controls.Add(txtAsgariStok);
            Controls.Add(label8);
            Controls.Add(txtKdvOranı);
            Controls.Add(label9);
            Controls.Add(txtİkinciSatısFiyatı);
            Controls.Add(label10);
            Controls.Add(txtMevcutStok);
            Controls.Add(label7);
            Controls.Add(txtAlısFiyatı);
            Controls.Add(label6);
            Controls.Add(txtSatısFiyatı);
            Controls.Add(label5);
            Controls.Add(txtUrunGrubu);
            Controls.Add(label3);
            Controls.Add(txtStokKodu);
            Controls.Add(label4);
            Controls.Add(txtUrunAdı);
            Controls.Add(label2);
            Controls.Add(txtBarkodNo);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Name = "Stoklar";
            Text = "Stoklar";
            Load += Stoklar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.TextBox txtUrunAdı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunGrubu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStokKodu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSatısFiyatı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlısFiyatı;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMevcutStok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAsgariStok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKdvOranı;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtİkinciSatısFiyatı;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton btnUrunuDüzelt;
        private DevExpress.XtraEditors.SimpleButton btnUrunSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmboxSıralama;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnUrunEkle;
        private DevExpress.XtraEditors.SimpleButton btnUrunGrupları;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}