namespace GirisEkranı
{
    partial class İskontoUygula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İskontoUygula));
            label1 = new System.Windows.Forms.Label();
            txtİskontoTutarı = new System.Windows.Forms.TextBox();
            btnUygula = new DevExpress.XtraEditors.SimpleButton();
            btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(24, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(287, 24);
            label1.TabIndex = 0;
            label1.Text = "Lütfen İskonto Tutarını Giriniz :";
            // 
            // txtİskontoTutarı
            // 
            txtİskontoTutarı.Location = new System.Drawing.Point(328, 36);
            txtİskontoTutarı.Name = "txtİskontoTutarı";
            txtİskontoTutarı.Size = new System.Drawing.Size(200, 23);
            txtİskontoTutarı.TabIndex = 1;
            txtİskontoTutarı.KeyPress += txtİskontoTutarı_KeyPress;
            // 
            // btnUygula
            // 
            btnUygula.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnUygula.Appearance.Options.UseFont = true;
            btnUygula.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnUygula.ImageOptions.Image");
            btnUygula.Location = new System.Drawing.Point(109, 116);
            btnUygula.Name = "btnUygula";
            btnUygula.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnUygula.Size = new System.Drawing.Size(139, 46);
            btnUygula.TabIndex = 2;
            btnUygula.Text = "Uygula";
            btnUygula.Click += btnUygula_Click;
            // 
            // btnVazgec
            // 
            btnVazgec.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnVazgec.Appearance.Options.UseFont = true;
            btnVazgec.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnVazgec.ImageOptions.Image");
            btnVazgec.Location = new System.Drawing.Point(319, 116);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnVazgec.Size = new System.Drawing.Size(139, 46);
            btnVazgec.TabIndex = 3;
            btnVazgec.Text = "Vazgeç";
            btnVazgec.Click += btnVazgec_Click;
            // 
            // İskontoUygula
            // 
            Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(613, 228);
            Controls.Add(btnVazgec);
            Controls.Add(btnUygula);
            Controls.Add(txtİskontoTutarı);
            Controls.Add(label1);
            Name = "İskontoUygula";
            Text = "İskontoUygula";
            Load += İskontoUygula_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtİskontoTutarı;
        private DevExpress.XtraEditors.SimpleButton btnUygula;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
    }
}