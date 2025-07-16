namespace GirisEkranı
{
    partial class MusteriBorc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriBorc));
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtMusteriSoyad = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtÖdenmesiGerekenTutar = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtKalanTaksitToplam = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtVeresiyeBorcMiktarı = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            dataGridViewBorcDetay = new System.Windows.Forms.DataGridView();
            txtAd = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnTahsilatYap = new DevExpress.XtraEditors.SimpleButton();
            btnBorcEKle = new DevExpress.XtraEditors.SimpleButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            dataGridViewAlisverisDetay = new System.Windows.Forms.DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBorcDetay).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlisverisDetay).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMusteriSoyad);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtÖdenmesiGerekenTutar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtKalanTaksitToplam);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtVeresiyeBorcMiktarı);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dataGridViewBorcDetay);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.Location = new System.Drawing.Point(23, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1044, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Borç Detay";
            // 
            // txtMusteriSoyad
            // 
            txtMusteriSoyad.Location = new System.Drawing.Point(354, 36);
            txtMusteriSoyad.Name = "txtMusteriSoyad";
            txtMusteriSoyad.Size = new System.Drawing.Size(189, 32);
            txtMusteriSoyad.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(271, 41);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(77, 24);
            label5.TabIndex = 11;
            label5.Text = "Soyad :";
            // 
            // txtÖdenmesiGerekenTutar
            // 
            txtÖdenmesiGerekenTutar.Location = new System.Drawing.Point(801, 89);
            txtÖdenmesiGerekenTutar.Name = "txtÖdenmesiGerekenTutar";
            txtÖdenmesiGerekenTutar.Size = new System.Drawing.Size(189, 32);
            txtÖdenmesiGerekenTutar.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(471, 89);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(324, 24);
            label4.TabIndex = 9;
            label4.Text = "Ödenmesi Gereken Toplam Tutarı :";
            // 
            // txtKalanTaksitToplam
            // 
            txtKalanTaksitToplam.Location = new System.Drawing.Point(234, 91);
            txtKalanTaksitToplam.Name = "txtKalanTaksitToplam";
            txtKalanTaksitToplam.Size = new System.Drawing.Size(189, 32);
            txtKalanTaksitToplam.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(18, 94);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(206, 24);
            label3.TabIndex = 7;
            label3.Text = "Kalan Taksit Toplam :";
            // 
            // txtVeresiyeBorcMiktarı
            // 
            txtVeresiyeBorcMiktarı.Location = new System.Drawing.Point(801, 36);
            txtVeresiyeBorcMiktarı.Name = "txtVeresiyeBorcMiktarı";
            txtVeresiyeBorcMiktarı.Size = new System.Drawing.Size(189, 32);
            txtVeresiyeBorcMiktarı.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(585, 39);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(210, 24);
            label2.TabIndex = 5;
            label2.Text = "Veresiye Borç Miktarı :";
            // 
            // dataGridViewBorcDetay
            // 
            dataGridViewBorcDetay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBorcDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBorcDetay.Location = new System.Drawing.Point(6, 132);
            dataGridViewBorcDetay.Name = "dataGridViewBorcDetay";
            dataGridViewBorcDetay.RowHeadersWidth = 51;
            dataGridViewBorcDetay.Size = new System.Drawing.Size(1035, 290);
            dataGridViewBorcDetay.TabIndex = 4;
            // 
            // txtAd
            // 
            txtAd.Location = new System.Drawing.Point(65, 39);
            txtAd.Name = "txtAd";
            txtAd.Size = new System.Drawing.Size(189, 32);
            txtAd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 24);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            // 
            // btnTahsilatYap
            // 
            btnTahsilatYap.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            btnTahsilatYap.Appearance.Options.UseFont = true;
            btnTahsilatYap.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnTahsilatYap.ImageOptions.Image");
            btnTahsilatYap.Location = new System.Drawing.Point(1123, 65);
            btnTahsilatYap.Name = "btnTahsilatYap";
            btnTahsilatYap.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnTahsilatYap.Size = new System.Drawing.Size(181, 55);
            btnTahsilatYap.TabIndex = 1;
            btnTahsilatYap.Text = "Tahsilat Yap";
            btnTahsilatYap.Click += btnTahsilatYap_Click;
            // 
            // btnBorcEKle
            // 
            btnBorcEKle.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            btnBorcEKle.Appearance.Options.UseFont = true;
            btnBorcEKle.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnBorcEKle.ImageOptions.Image");
            btnBorcEKle.Location = new System.Drawing.Point(1123, 166);
            btnBorcEKle.Name = "btnBorcEKle";
            btnBorcEKle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnBorcEKle.Size = new System.Drawing.Size(181, 55);
            btnBorcEKle.TabIndex = 2;
            btnBorcEKle.Text = "Borç Ekle";
            btnBorcEKle.Click += btnBorcEKle_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewAlisverisDetay);
            groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox2.Location = new System.Drawing.Point(20, 449);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(1052, 331);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Alışveriş Detayı";
            // 
            // dataGridViewAlisverisDetay
            // 
            dataGridViewAlisverisDetay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAlisverisDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlisverisDetay.Location = new System.Drawing.Point(9, 31);
            dataGridViewAlisverisDetay.Name = "dataGridViewAlisverisDetay";
            dataGridViewAlisverisDetay.RowHeadersWidth = 51;
            dataGridViewAlisverisDetay.Size = new System.Drawing.Size(1035, 290);
            dataGridViewAlisverisDetay.TabIndex = 4;
            // 
            // MusteriBorc
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1357, 815);
            Controls.Add(groupBox2);
            Controls.Add(btnBorcEKle);
            Controls.Add(btnTahsilatYap);
            Controls.Add(groupBox1);
            Name = "MusteriBorc";
            Text = "MusteriBorc";
            Load += MusteriBorc_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBorcDetay).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlisverisDetay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtÖdenmesiGerekenTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKalanTaksitToplam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVeresiyeBorcMiktarı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewBorcDetay;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnTahsilatYap;
        private DevExpress.XtraEditors.SimpleButton btnBorcEKle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewAlisverisDetay;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.Label label5;
    }
}