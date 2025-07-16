namespace GirisEkranı
{
    partial class FiyatGör
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiyatGör));
            label1 = new System.Windows.Forms.Label();
            txtBarkodNo = new System.Windows.Forms.TextBox();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtUrunİsmi = new System.Windows.Forms.TextBox();
            txtMevcutStok = new System.Windows.Forms.TextBox();
            txtUrunFiyatı = new System.Windows.Forms.TextBox();
            btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            label1.Location = new System.Drawing.Point(110, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(230, 48);
            label1.TabIndex = 0;
            label1.Text = "Barkod No";
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.BackColor = System.Drawing.Color.Yellow;
            txtBarkodNo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtBarkodNo.ForeColor = System.Drawing.Color.Black;
            txtBarkodNo.Location = new System.Drawing.Point(346, 41);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new System.Drawing.Size(502, 44);
            txtBarkodNo.TabIndex = 1;
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new System.Drawing.Point(543, 122);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton1.Size = new System.Drawing.Size(305, 74);
            simpleButton1.TabIndex = 4;
            simpleButton1.Text = "Ürün Adı İle Ara";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 18F);
            label2.Location = new System.Drawing.Point(66, 244);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(165, 36);
            label2.TabIndex = 8;
            label2.Text = "Ürün İsmi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 18F);
            label3.Location = new System.Drawing.Point(36, 425);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(197, 36);
            label3.TabIndex = 9;
            label3.Text = "Mevcut Stok :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 18F);
            label4.Location = new System.Drawing.Point(51, 554);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(180, 36);
            label4.TabIndex = 10;
            label4.Text = "Ürün Fiyatı :";
            // 
            // txtUrunİsmi
            // 
            txtUrunİsmi.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtUrunİsmi.Location = new System.Drawing.Point(244, 244);
            txtUrunİsmi.Multiline = true;
            txtUrunİsmi.Name = "txtUrunİsmi";
            txtUrunİsmi.Size = new System.Drawing.Size(426, 154);
            txtUrunİsmi.TabIndex = 11;
            // 
            // txtMevcutStok
            // 
            txtMevcutStok.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtMevcutStok.Location = new System.Drawing.Point(244, 413);
            txtMevcutStok.Multiline = true;
            txtMevcutStok.Name = "txtMevcutStok";
            txtMevcutStok.Size = new System.Drawing.Size(308, 116);
            txtMevcutStok.TabIndex = 12;
            // 
            // txtUrunFiyatı
            // 
            txtUrunFiyatı.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtUrunFiyatı.Location = new System.Drawing.Point(244, 554);
            txtUrunFiyatı.Multiline = true;
            txtUrunFiyatı.Name = "txtUrunFiyatı";
            txtUrunFiyatı.Size = new System.Drawing.Size(308, 116);
            txtUrunFiyatı.TabIndex = 13;
            // 
            // btnVazgec
            // 
            btnVazgec.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnVazgec.ImageOptions.Image");
            btnVazgec.Location = new System.Drawing.Point(1182, 3);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnVazgec.Size = new System.Drawing.Size(39, 43);
            btnVazgec.TabIndex = 14;
            btnVazgec.Click += btnVazgec_Click;
            // 
            // FiyatGör
            // 
            Appearance.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1220, 829);
            Controls.Add(btnVazgec);
            Controls.Add(txtUrunFiyatı);
            Controls.Add(txtMevcutStok);
            Controls.Add(txtUrunİsmi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(simpleButton1);
            Controls.Add(txtBarkodNo);
            Controls.Add(label1);
            Name = "FiyatGör";
            Text = "FiyatGör";
            Load += FiyatGör_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtBarkodNo;
        public System.Windows.Forms.TextBox txtUrunİsmi;
        public System.Windows.Forms.TextBox txtMevcutStok;
        public System.Windows.Forms.TextBox txtUrunFiyatı;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
    }
}