namespace GirisEkranı
{
    partial class Toptancılar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toptancılar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            btnKapat = new DevExpress.XtraEditors.SimpleButton();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            btnToptancıEkle = new DevExpress.XtraEditors.SimpleButton();
            btnToptancıSil = new DevExpress.XtraEditors.SimpleButton();
            btnBilgiDüzenle = new DevExpress.XtraEditors.SimpleButton();
            btnOdemeYap = new DevExpress.XtraEditors.SimpleButton();
            btnBorcEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnKapat
            // 
            btnKapat.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnKapat.ImageOptions.Image");
            btnKapat.Location = new System.Drawing.Point(837, -3);
            btnKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnKapat.Name = "btnKapat";
            btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnKapat.Size = new System.Drawing.Size(33, 34);
            btnKapat.TabIndex = 1;
            btnKapat.Click += btnKapat_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(255, 128, 0);
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridView1.Location = new System.Drawing.Point(5, 86);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(626, 385);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(228, 6);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(370, 38);
            label2.TabIndex = 2;
            label2.Text = ">>Toptancı Adı İle Arama<<";
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox1.Location = new System.Drawing.Point(235, 45);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(306, 34);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnToptancıEkle
            // 
            btnToptancıEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnToptancıEkle.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnToptancıEkle.Appearance.Options.UseFont = true;
            btnToptancıEkle.Appearance.Options.UseForeColor = true;
            btnToptancıEkle.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnToptancıEkle.ImageOptions.Image");
            btnToptancıEkle.Location = new System.Drawing.Point(649, 86);
            btnToptancıEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnToptancıEkle.Name = "btnToptancıEkle";
            btnToptancıEkle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnToptancıEkle.Size = new System.Drawing.Size(183, 38);
            btnToptancıEkle.TabIndex = 4;
            btnToptancıEkle.Text = "Toptancı Ekle";
            btnToptancıEkle.Click += btnToptancıEkle_Click;
            // 
            // btnToptancıSil
            // 
            btnToptancıSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnToptancıSil.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnToptancıSil.Appearance.Options.UseFont = true;
            btnToptancıSil.Appearance.Options.UseForeColor = true;
            btnToptancıSil.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnToptancıSil.ImageOptions.Image");
            btnToptancıSil.Location = new System.Drawing.Point(649, 146);
            btnToptancıSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnToptancıSil.Name = "btnToptancıSil";
            btnToptancıSil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnToptancıSil.Size = new System.Drawing.Size(192, 42);
            btnToptancıSil.TabIndex = 5;
            btnToptancıSil.Text = "Toptancı Sil";
            btnToptancıSil.Click += btnToptancıSil_Click;
            // 
            // btnBilgiDüzenle
            // 
            btnBilgiDüzenle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnBilgiDüzenle.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnBilgiDüzenle.Appearance.Options.UseFont = true;
            btnBilgiDüzenle.Appearance.Options.UseForeColor = true;
            btnBilgiDüzenle.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnBilgiDüzenle.ImageOptions.Image");
            btnBilgiDüzenle.Location = new System.Drawing.Point(649, 214);
            btnBilgiDüzenle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnBilgiDüzenle.Name = "btnBilgiDüzenle";
            btnBilgiDüzenle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnBilgiDüzenle.Size = new System.Drawing.Size(206, 42);
            btnBilgiDüzenle.TabIndex = 6;
            btnBilgiDüzenle.Text = "Bilgileri Düzenle";
            btnBilgiDüzenle.Click += btnBilgiDüzenle_Click;
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOdemeYap.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnOdemeYap.Appearance.Options.UseFont = true;
            btnOdemeYap.Appearance.Options.UseForeColor = true;
            btnOdemeYap.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnOdemeYap.ImageOptions.Image");
            btnOdemeYap.Location = new System.Drawing.Point(660, 284);
            btnOdemeYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnOdemeYap.Size = new System.Drawing.Size(172, 46);
            btnOdemeYap.TabIndex = 7;
            btnOdemeYap.Text = "Ödeme Yap";
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // btnBorcEkle
            // 
            btnBorcEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnBorcEkle.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnBorcEkle.Appearance.Options.UseFont = true;
            btnBorcEkle.Appearance.Options.UseForeColor = true;
            btnBorcEkle.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnBorcEkle.ImageOptions.Image");
            btnBorcEkle.Location = new System.Drawing.Point(660, 365);
            btnBorcEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnBorcEkle.Name = "btnBorcEkle";
            btnBorcEkle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnBorcEkle.Size = new System.Drawing.Size(172, 46);
            btnBorcEkle.TabIndex = 8;
            btnBorcEkle.Text = "Borç Ekle";
            btnBorcEkle.Click += btnBorcEkle_Click;
            // 
            // Toptancılar
            // 
            Appearance.ForeColor = System.Drawing.Color.Black;
            Appearance.Options.UseForeColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(867, 494);
            Controls.Add(btnKapat);
            Controls.Add(btnBorcEkle);
            Controls.Add(btnOdemeYap);
            Controls.Add(btnBilgiDüzenle);
            Controls.Add(btnToptancıSil);
            Controls.Add(btnToptancıEkle);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Toptancılar";
            Text = "Toptancılar";
            Load += Toptancılar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton btnToptancıEkle;
        private DevExpress.XtraEditors.SimpleButton btnToptancıSil;
        private DevExpress.XtraEditors.SimpleButton btnBilgiDüzenle;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnOdemeYap;
        private DevExpress.XtraEditors.SimpleButton btnBorcEkle;
    }
}