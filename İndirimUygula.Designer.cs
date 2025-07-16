namespace GirisEkranı
{
    partial class İndirimUygula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İndirimUygula));
            label1 = new System.Windows.Forms.Label();
            txtİndirim = new System.Windows.Forms.TextBox();
            btnUygula = new DevExpress.XtraEditors.SimpleButton();
            btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(12, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(256, 24);
            label1.TabIndex = 0;
            label1.Text = "İndirim Tutarını Giriniz :";
            // 
            // txtİndirim
            // 
            txtİndirim.Location = new System.Drawing.Point(274, 49);
            txtİndirim.Name = "txtİndirim";
            txtİndirim.Size = new System.Drawing.Size(227, 23);
            txtİndirim.TabIndex = 1;
            // 
            // btnUygula
            // 
            btnUygula.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            btnUygula.Appearance.ForeColor = System.Drawing.Color.Black;
            btnUygula.Appearance.Options.UseFont = true;
            btnUygula.Appearance.Options.UseForeColor = true;
            btnUygula.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnUygula.ImageOptions.Image");
            btnUygula.Location = new System.Drawing.Point(250, 136);
            btnUygula.Name = "btnUygula";
            btnUygula.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnUygula.Size = new System.Drawing.Size(135, 43);
            btnUygula.TabIndex = 2;
            btnUygula.Text = "Uygula";
            btnUygula.Click += btnUygula_Click;
            // 
            // btnVazgec
            // 
            btnVazgec.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            btnVazgec.Appearance.Options.UseFont = true;
            btnVazgec.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnVazgec.ImageOptions.Image");
            btnVazgec.Location = new System.Drawing.Point(401, 136);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnVazgec.Size = new System.Drawing.Size(127, 43);
            btnVazgec.TabIndex = 3;
            btnVazgec.Text = "Geri Dön";
            // 
            // İndirimUygula
            // 
            Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(555, 191);
            Controls.Add(btnVazgec);
            Controls.Add(btnUygula);
            Controls.Add(txtİndirim);
            Controls.Add(label1);
            Name = "İndirimUygula";
            Text = "İndirimUygula";
            Load += İndirimUygula_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtİndirim;
        private DevExpress.XtraEditors.SimpleButton btnUygula;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
    }
}