namespace GirisEkranı
{
    partial class TaksitYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaksitYap));
            comboBox1 = new System.Windows.Forms.ComboBox();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox1.Location = new System.Drawing.Point(26, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(252, 36);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Seç";
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new System.Drawing.Point(78, 85);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton1.Size = new System.Drawing.Size(162, 49);
            simpleButton1.TabIndex = 1;
            simpleButton1.Text = "Taksit Yap";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // TaksitYap
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(382, 146);
            Controls.Add(simpleButton1);
            Controls.Add(comboBox1);
            Name = "TaksitYap";
            Text = "TaksitYap";
            Load += TaksitYap_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}