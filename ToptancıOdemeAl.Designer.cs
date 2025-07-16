namespace GirisEkranı
{
    partial class ToptancıOdemeAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToptancıOdemeAl));
            label1 = new System.Windows.Forms.Label();
            txtToptancıAdı = new System.Windows.Forms.TextBox();
            txtToplamBorc = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtSaat = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtAcıklama = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtOdemeTutarı = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            radioButtonHavale = new System.Windows.Forms.RadioButton();
            radioButtonKrediKartı = new System.Windows.Forms.RadioButton();
            radioButtonNakit = new System.Windows.Forms.RadioButton();
            btnOnayla = new DevExpress.XtraEditors.SimpleButton();
            btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            btnYazdır = new DevExpress.XtraEditors.SimpleButton();
            timer1 = new System.Windows.Forms.Timer(components);
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new System.Windows.Forms.PrintDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Location = new System.Drawing.Point(34, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(130, 28);
            label1.TabIndex = 0;
            label1.Text = "Toptancı Adı :";
            // 
            // txtToptancıAdı
            // 
            txtToptancıAdı.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtToptancıAdı.Location = new System.Drawing.Point(167, 15);
            txtToptancıAdı.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtToptancıAdı.Name = "txtToptancıAdı";
            txtToptancıAdı.Size = new System.Drawing.Size(250, 34);
            txtToptancıAdı.TabIndex = 1;
            // 
            // txtToplamBorc
            // 
            txtToplamBorc.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtToplamBorc.Location = new System.Drawing.Point(167, 65);
            txtToplamBorc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtToplamBorc.Name = "txtToplamBorc";
            txtToplamBorc.Size = new System.Drawing.Size(250, 34);
            txtToplamBorc.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(35, 65);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(129, 28);
            label2.TabIndex = 2;
            label2.Text = "Toplam Borç :";
            // 
            // txtSaat
            // 
            txtSaat.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtSaat.Location = new System.Drawing.Point(167, 159);
            txtSaat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtSaat.Name = "txtSaat";
            txtSaat.Size = new System.Drawing.Size(250, 34);
            txtSaat.TabIndex = 7;
            txtSaat.TextChanged += txtSaat_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(88, 164);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 28);
            label3.TabIndex = 6;
            label3.Text = "Saat :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            label4.Location = new System.Drawing.Point(94, 114);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 28);
            label4.TabIndex = 4;
            label4.Text = "Tarih :";
            // 
            // txtAcıklama
            // 
            txtAcıklama.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtAcıklama.Location = new System.Drawing.Point(166, 252);
            txtAcıklama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtAcıklama.Multiline = true;
            txtAcıklama.Name = "txtAcıklama";
            txtAcıklama.Size = new System.Drawing.Size(255, 70);
            txtAcıklama.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            label5.Location = new System.Drawing.Point(60, 255);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(100, 28);
            label5.TabIndex = 10;
            label5.Text = "Açıklama :";
            // 
            // txtOdemeTutarı
            // 
            txtOdemeTutarı.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtOdemeTutarı.Location = new System.Drawing.Point(167, 201);
            txtOdemeTutarı.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtOdemeTutarı.Name = "txtOdemeTutarı";
            txtOdemeTutarı.Size = new System.Drawing.Size(250, 34);
            txtOdemeTutarı.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            label6.Location = new System.Drawing.Point(25, 201);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(140, 28);
            label6.TabIndex = 8;
            label6.Text = "Ödeme Tutarı :";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            maskedTextBox1.Location = new System.Drawing.Point(167, 110);
            maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new System.Drawing.Size(250, 34);
            maskedTextBox1.TabIndex = 12;
            maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonHavale);
            groupBox1.Controls.Add(radioButtonKrediKartı);
            groupBox1.Controls.Add(radioButtonNakit);
            groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.Location = new System.Drawing.Point(10, 317);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Size = new System.Drawing.Size(511, 94);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ödeme Türleri";
            // 
            // radioButtonHavale
            // 
            radioButtonHavale.AutoSize = true;
            radioButtonHavale.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            radioButtonHavale.Location = new System.Drawing.Point(342, 44);
            radioButtonHavale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            radioButtonHavale.Name = "radioButtonHavale";
            radioButtonHavale.Size = new System.Drawing.Size(121, 42);
            radioButtonHavale.TabIndex = 2;
            radioButtonHavale.TabStop = true;
            radioButtonHavale.Text = "Havale";
            radioButtonHavale.UseVisualStyleBackColor = true;
            // 
            // radioButtonKrediKartı
            // 
            radioButtonKrediKartı.AutoSize = true;
            radioButtonKrediKartı.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            radioButtonKrediKartı.Location = new System.Drawing.Point(161, 44);
            radioButtonKrediKartı.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            radioButtonKrediKartı.Name = "radioButtonKrediKartı";
            radioButtonKrediKartı.Size = new System.Drawing.Size(166, 42);
            radioButtonKrediKartı.TabIndex = 1;
            radioButtonKrediKartı.TabStop = true;
            radioButtonKrediKartı.Text = "Kredi Kartı";
            radioButtonKrediKartı.UseVisualStyleBackColor = true;
            // 
            // radioButtonNakit
            // 
            radioButtonNakit.AutoSize = true;
            radioButtonNakit.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            radioButtonNakit.Location = new System.Drawing.Point(24, 44);
            radioButtonNakit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            radioButtonNakit.Name = "radioButtonNakit";
            radioButtonNakit.Size = new System.Drawing.Size(103, 42);
            radioButtonNakit.TabIndex = 0;
            radioButtonNakit.TabStop = true;
            radioButtonNakit.Text = "Nakit";
            radioButtonNakit.UseVisualStyleBackColor = true;
            // 
            // btnOnayla
            // 
            btnOnayla.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOnayla.Appearance.Options.UseFont = true;
            btnOnayla.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnOnayla.ImageOptions.Image");
            btnOnayla.Location = new System.Drawing.Point(25, 430);
            btnOnayla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnOnayla.Size = new System.Drawing.Size(146, 46);
            btnOnayla.TabIndex = 14;
            btnOnayla.Text = "Onayla";
            btnOnayla.Click += btnOnayla_Click;
            // 
            // btnVazgec
            // 
            btnVazgec.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnVazgec.Appearance.Options.UseFont = true;
            btnVazgec.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnVazgec.ImageOptions.Image");
            btnVazgec.Location = new System.Drawing.Point(182, 430);
            btnVazgec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnVazgec.Size = new System.Drawing.Size(135, 46);
            btnVazgec.TabIndex = 15;
            btnVazgec.Text = "Vazgeç";
            // 
            // btnYazdır
            // 
            btnYazdır.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnYazdır.Appearance.Options.UseFont = true;
            btnYazdır.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnYazdır.ImageOptions.Image");
            btnYazdır.Location = new System.Drawing.Point(353, 430);
            btnYazdır.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnYazdır.Name = "btnYazdır";
            btnYazdır.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnYazdır.Size = new System.Drawing.Size(135, 46);
            btnYazdır.TabIndex = 16;
            btnYazdır.Text = "Yazdır";
            btnYazdır.Click += simpleButton1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // ToptancıOdemeAl
            // 
            Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(524, 486);
            Controls.Add(btnYazdır);
            Controls.Add(btnVazgec);
            Controls.Add(btnOnayla);
            Controls.Add(groupBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(txtAcıklama);
            Controls.Add(label5);
            Controls.Add(txtOdemeTutarı);
            Controls.Add(label6);
            Controls.Add(txtSaat);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtToplamBorc);
            Controls.Add(label2);
            Controls.Add(txtToptancıAdı);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "ToptancıOdemeAl";
            Text = "ToptancıOdemeAl";
            Load += ToptancıOdemeAl_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToptancıAdı;
        private System.Windows.Forms.TextBox txtToplamBorc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAcıklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOdemeTutarı;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonKrediKartı;
        private System.Windows.Forms.RadioButton radioButtonNakit;
        private System.Windows.Forms.RadioButton radioButtonHavale;
        private DevExpress.XtraEditors.SimpleButton btnOnayla;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnYazdır;
        private System.Windows.Forms.Timer timer1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}