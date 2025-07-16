namespace GirisEkranı
{
    partial class SifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttum));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtTelefonNo = new System.Windows.Forms.TextBox();
            btnSifreGüncelle = new DevExpress.XtraEditors.SimpleButton();
            btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            txtCaptch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Black;
            label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(82, 193);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 28);
            label1.TabIndex = 0;
            label1.Text = "E-Mail :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Black;
            label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(35, 248);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(135, 28);
            label2.TabIndex = 1;
            label2.Text = "Telefon No :";
            // 
            // txtEmail
            // 
            txtEmail.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            txtEmail.Location = new System.Drawing.Point(176, 196);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(269, 28);
            txtEmail.TabIndex = 2;
            // 
            // txtTelefonNo
            // 
            txtTelefonNo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            txtTelefonNo.Location = new System.Drawing.Point(176, 251);
            txtTelefonNo.Name = "txtTelefonNo";
            txtTelefonNo.Size = new System.Drawing.Size(269, 28);
            txtTelefonNo.TabIndex = 3;
            // 
            // btnSifreGüncelle
            // 
            btnSifreGüncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            btnSifreGüncelle.Appearance.ForeColor = System.Drawing.Color.White;
            btnSifreGüncelle.Appearance.Options.UseFont = true;
            btnSifreGüncelle.Appearance.Options.UseForeColor = true;
            btnSifreGüncelle.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnSifreGüncelle.ImageOptions.Image");
            btnSifreGüncelle.Location = new System.Drawing.Point(61, 493);
            btnSifreGüncelle.Name = "btnSifreGüncelle";
            btnSifreGüncelle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnSifreGüncelle.Size = new System.Drawing.Size(174, 56);
            btnSifreGüncelle.TabIndex = 4;
            btnSifreGüncelle.Text = "Doğrula";
            btnSifreGüncelle.Click += btnSifreGüncelle_Click;
            // 
            // btnVazgec
            // 
            btnVazgec.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            btnVazgec.Appearance.ForeColor = System.Drawing.Color.White;
            btnVazgec.Appearance.Options.UseFont = true;
            btnVazgec.Appearance.Options.UseForeColor = true;
            btnVazgec.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnVazgec.ImageOptions.Image");
            btnVazgec.Location = new System.Drawing.Point(297, 493);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnVazgec.Size = new System.Drawing.Size(193, 56);
            btnVazgec.TabIndex = 5;
            btnVazgec.Text = "Vazgeç";
            btnVazgec.Click += btnVazgec_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(176, 298);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(269, 123);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txtCaptch
            // 
            txtCaptch.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtCaptch.Location = new System.Drawing.Point(176, 436);
            txtCaptch.Name = "txtCaptch";
            txtCaptch.Size = new System.Drawing.Size(269, 28);
            txtCaptch.TabIndex = 7;
            // 
            // SifremiUnuttum
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            BackgroundImageStore = (System.Drawing.Image)resources.GetObject("$this.BackgroundImageStore");
            ClientSize = new System.Drawing.Size(592, 615);
            Controls.Add(txtCaptch);
            Controls.Add(pictureBox1);
            Controls.Add(btnVazgec);
            Controls.Add(btnSifreGüncelle);
            Controls.Add(txtTelefonNo);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "SifremiUnuttum";
            Text = "SifremiUnuttum";
            Load += SifremiUnuttum_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private DevExpress.XtraEditors.SimpleButton btnSifreGüncelle;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCaptch;
    }
}