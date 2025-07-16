namespace GirisEkranı
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtSifre = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            txtCaptch = new System.Windows.Forms.TextBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Black;
            label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(47, 230);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "E-mail :";
            // 
            // txtEmail
            // 
            txtEmail.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtEmail.Location = new System.Drawing.Point(136, 230);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(264, 28);
            txtEmail.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtSifre.Location = new System.Drawing.Point(136, 281);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new System.Drawing.Size(264, 28);
            txtSifre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Black;
            label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(64, 281);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Şifre :";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(138, 337);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(262, 115);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtCaptch
            // 
            txtCaptch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtCaptch.Location = new System.Drawing.Point(136, 470);
            txtCaptch.Name = "txtCaptch";
            txtCaptch.Size = new System.Drawing.Size(264, 26);
            txtCaptch.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = System.Drawing.Color.Black;
            checkBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            checkBox1.ForeColor = System.Drawing.Color.White;
            checkBox1.Location = new System.Drawing.Point(406, 285);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(85, 22);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Göster";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            simpleButton1.Appearance.Font = new System.Drawing.Font("Verdana", 13.8F);
            simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            simpleButton1.Appearance.Options.UseBackColor = true;
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.Appearance.Options.UseForeColor = true;
            simpleButton1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new System.Drawing.Point(33, 574);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton1.Size = new System.Drawing.Size(139, 48);
            simpleButton1.TabIndex = 7;
            simpleButton1.Text = "Giriş Yap";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.BackColor = System.Drawing.Color.White;
            simpleButton2.Appearance.Font = new System.Drawing.Font("Verdana", 13.8F);
            simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            simpleButton2.Appearance.Options.UseBackColor = true;
            simpleButton2.Appearance.Options.UseFont = true;
            simpleButton2.Appearance.Options.UseForeColor = true;
            simpleButton2.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton2.ImageOptions.Image");
            simpleButton2.Location = new System.Drawing.Point(203, 574);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton2.Size = new System.Drawing.Size(139, 48);
            simpleButton2.TabIndex = 8;
            simpleButton2.Text = "Kayıt OL";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // simpleButton3
            // 
            simpleButton3.Appearance.BackColor = System.Drawing.Color.White;
            simpleButton3.Appearance.Font = new System.Drawing.Font("Verdana", 13.8F);
            simpleButton3.Appearance.ForeColor = System.Drawing.Color.White;
            simpleButton3.Appearance.Options.UseBackColor = true;
            simpleButton3.Appearance.Options.UseFont = true;
            simpleButton3.Appearance.Options.UseForeColor = true;
            simpleButton3.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton3.ImageOptions.Image");
            simpleButton3.Location = new System.Drawing.Point(361, 574);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton3.Size = new System.Drawing.Size(231, 48);
            simpleButton3.TabIndex = 9;
            simpleButton3.Text = "Şifremi Unuttum";
            simpleButton3.Click += simpleButton3_Click;
            // 
            // btnClose
            // 
            btnClose.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.Location = new System.Drawing.Point(568, 2);
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnClose.Size = new System.Drawing.Size(36, 47);
            btnClose.TabIndex = 10;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            BackgroundImageStore = (System.Drawing.Image)resources.GetObject("$this.BackgroundImageStore");
            ClientSize = new System.Drawing.Size(604, 666);
            Controls.Add(btnClose);
            Controls.Add(simpleButton3);
            Controls.Add(simpleButton2);
            Controls.Add(simpleButton1);
            Controls.Add(checkBox1);
            Controls.Add(txtCaptch);
            Controls.Add(pictureBox1);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCaptch;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}

