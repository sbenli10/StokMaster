namespace GirisEkranı
{
    partial class Ajanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajanda));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            dateTimePickerSaat = new System.Windows.Forms.DateTimePicker();
            txtBaslık = new System.Windows.Forms.TextBox();
            txtAcıklama = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            chkHatirlat = new System.Windows.Forms.CheckBox();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            timer1 = new System.Windows.Forms.Timer(components);
            txtEposta = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            btnKapat = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            label1.Location = new System.Drawing.Point(75, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 31);
            label1.TabIndex = 0;
            label1.Text = "Tarih :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            label2.Location = new System.Drawing.Point(78, 67);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 31);
            label2.TabIndex = 1;
            label2.Text = "Saat :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            label3.Location = new System.Drawing.Point(65, 206);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 31);
            label3.TabIndex = 2;
            label3.Text = "Başlık :";
            // 
            // dateTimePickerTarih
            // 
            dateTimePickerTarih.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dateTimePickerTarih.Location = new System.Drawing.Point(156, 26);
            dateTimePickerTarih.Name = "dateTimePickerTarih";
            dateTimePickerTarih.Size = new System.Drawing.Size(349, 30);
            dateTimePickerTarih.TabIndex = 3;
            // 
            // dateTimePickerSaat
            // 
            dateTimePickerSaat.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dateTimePickerSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dateTimePickerSaat.Location = new System.Drawing.Point(160, 67);
            dateTimePickerSaat.Name = "dateTimePickerSaat";
            dateTimePickerSaat.ShowUpDown = true;
            dateTimePickerSaat.Size = new System.Drawing.Size(345, 30);
            dateTimePickerSaat.TabIndex = 4;
            // 
            // txtBaslık
            // 
            txtBaslık.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtBaslık.Location = new System.Drawing.Point(160, 203);
            txtBaslık.Name = "txtBaslık";
            txtBaslık.Size = new System.Drawing.Size(345, 34);
            txtBaslık.TabIndex = 5;
            // 
            // txtAcıklama
            // 
            txtAcıklama.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtAcıklama.Location = new System.Drawing.Point(160, 252);
            txtAcıklama.Multiline = true;
            txtAcıklama.Name = "txtAcıklama";
            txtAcıklama.Size = new System.Drawing.Size(345, 140);
            txtAcıklama.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            label4.Location = new System.Drawing.Point(33, 255);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(118, 31);
            label4.TabIndex = 6;
            label4.Text = "Açıklama :";
            // 
            // chkHatirlat
            // 
            chkHatirlat.AutoSize = true;
            chkHatirlat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chkHatirlat.Location = new System.Drawing.Point(511, 67);
            chkHatirlat.Name = "chkHatirlat";
            chkHatirlat.Size = new System.Drawing.Size(99, 32);
            chkHatirlat.TabIndex = 8;
            chkHatirlat.Text = "Hatırlat";
            chkHatirlat.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnKaydet.Appearance.Options.UseFont = true;
            btnKaydet.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnKaydet.ImageOptions.Image");
            btnKaydet.Location = new System.Drawing.Point(17, 397);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnKaydet.Size = new System.Drawing.Size(191, 43);
            btnKaydet.TabIndex = 9;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 60000;
            timer1.Tick += timer1_Tick;
            // 
            // txtEposta
            // 
            txtEposta.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtEposta.Location = new System.Drawing.Point(160, 152);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new System.Drawing.Size(345, 34);
            txtEposta.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            label5.Location = new System.Drawing.Point(47, 152);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(101, 31);
            label5.TabIndex = 10;
            label5.Text = "E-Posta :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            label6.Location = new System.Drawing.Point(17, 110);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(130, 31);
            label6.TabIndex = 12;
            label6.Text = "Tekrar Tipi :";
            // 
            // comboBox1
            // 
            comboBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "", "Günlük", "Haftalık" });
            comboBox1.Location = new System.Drawing.Point(160, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(345, 33);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "Seç";
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new System.Drawing.Point(242, 404);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton1.Size = new System.Drawing.Size(191, 43);
            simpleButton1.TabIndex = 14;
            simpleButton1.Text = "Notlar";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // btnKapat
            // 
            btnKapat.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnKapat.Appearance.Options.UseFont = true;
            btnKapat.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnKapat.ImageOptions.Image");
            btnKapat.Location = new System.Drawing.Point(453, 398);
            btnKapat.Name = "btnKapat";
            btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnKapat.Size = new System.Drawing.Size(162, 48);
            btnKapat.TabIndex = 15;
            btnKapat.Text = "Vazgeç";
            btnKapat.Click += btnKapat_Click;
            // 
            // Ajanda
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(628, 472);
            Controls.Add(btnKapat);
            Controls.Add(simpleButton1);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(txtEposta);
            Controls.Add(label5);
            Controls.Add(btnKaydet);
            Controls.Add(chkHatirlat);
            Controls.Add(txtAcıklama);
            Controls.Add(label4);
            Controls.Add(txtBaslık);
            Controls.Add(dateTimePickerSaat);
            Controls.Add(dateTimePickerTarih);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ajanda";
            Text = "Ajanda";
            Load += Ajanda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        private System.Windows.Forms.DateTimePicker dateTimePickerSaat;
        private System.Windows.Forms.TextBox txtBaslık;
        private System.Windows.Forms.TextBox txtAcıklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkHatirlat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}