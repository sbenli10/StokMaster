namespace GirisEkranı
{
    partial class ToptancıBorcEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToptancıBorcEkle));
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
            txtToptancıAdı = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            btnOnayla = new DevExpress.XtraEditors.SimpleButton();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            maskedTextBox1.Location = new System.Drawing.Point(156, 110);
            maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new System.Drawing.Size(250, 34);
            maskedTextBox1.TabIndex = 24;
            maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // txtAcıklama
            // 
            txtAcıklama.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtAcıklama.Location = new System.Drawing.Point(156, 244);
            txtAcıklama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtAcıklama.Multiline = true;
            txtAcıklama.Name = "txtAcıklama";
            txtAcıklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtAcıklama.Size = new System.Drawing.Size(250, 82);
            txtAcıklama.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            label5.Location = new System.Drawing.Point(49, 256);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(100, 28);
            label5.TabIndex = 22;
            label5.Text = "Açıklama :";
            // 
            // txtEkleTutarı
            // 
            txtEkleTutarı.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtEkleTutarı.Location = new System.Drawing.Point(156, 202);
            txtEkleTutarı.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtEkleTutarı.Name = "txtEkleTutarı";
            txtEkleTutarı.Size = new System.Drawing.Size(250, 34);
            txtEkleTutarı.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            label6.Location = new System.Drawing.Point(14, 202);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(156, 28);
            label6.TabIndex = 20;
            label6.Text = "Eklenecek Tutar :";
            // 
            // txtSaat
            // 
            txtSaat.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtSaat.Location = new System.Drawing.Point(156, 160);
            txtSaat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtSaat.Name = "txtSaat";
            txtSaat.Size = new System.Drawing.Size(250, 34);
            txtSaat.TabIndex = 19;
            txtSaat.TextChanged += txtSaat_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(76, 165);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 28);
            label3.TabIndex = 18;
            label3.Text = "Saat :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            label4.Location = new System.Drawing.Point(82, 115);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 28);
            label4.TabIndex = 17;
            label4.Text = "Tarih :";
            // 
            // txtToplamBorc
            // 
            txtToplamBorc.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtToplamBorc.Location = new System.Drawing.Point(156, 66);
            txtToplamBorc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtToplamBorc.Name = "txtToplamBorc";
            txtToplamBorc.Size = new System.Drawing.Size(250, 34);
            txtToplamBorc.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(24, 66);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(129, 28);
            label2.TabIndex = 15;
            label2.Text = "Toplam Borç :";
            // 
            // txtToptancıAdı
            // 
            txtToptancıAdı.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtToptancıAdı.Location = new System.Drawing.Point(156, 16);
            txtToptancıAdı.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtToptancıAdı.Name = "txtToptancıAdı";
            txtToptancıAdı.Size = new System.Drawing.Size(250, 34);
            txtToptancıAdı.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Location = new System.Drawing.Point(23, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(130, 28);
            label1.TabIndex = 13;
            label1.Text = "Toptancı Adı :";
            // 
            // btnVazgec
            // 
            btnVazgec.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnVazgec.Appearance.Options.UseFont = true;
            btnVazgec.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnVazgec.ImageOptions.Image");
            btnVazgec.Location = new System.Drawing.Point(256, 352);
            btnVazgec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnVazgec.Size = new System.Drawing.Size(135, 46);
            btnVazgec.TabIndex = 26;
            btnVazgec.Text = "Vazgeç";
            // 
            // btnOnayla
            // 
            btnOnayla.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOnayla.Appearance.Options.UseFont = true;
            btnOnayla.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnOnayla.ImageOptions.Image");
            btnOnayla.Location = new System.Drawing.Point(58, 352);
            btnOnayla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnOnayla.Size = new System.Drawing.Size(146, 46);
            btnOnayla.TabIndex = 25;
            btnOnayla.Text = "Onayla";
            btnOnayla.Click += btnOnayla_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // ToptancıBorcEkle
            // 
            Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(438, 408);
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
            Controls.Add(txtToptancıAdı);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "ToptancıBorcEkle";
            Text = "ToptancıBorcEkle";
            Load += ToptancıBorcEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private System.Windows.Forms.TextBox txtToptancıAdı;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnOnayla;
        private System.Windows.Forms.Timer timer1;
    }
}