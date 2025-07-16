namespace GirisEkranı
{
    partial class MusterİadeAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusterİadeAl));
            xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnMusteriyeNakitOde = new DevExpress.XtraEditors.SimpleButton();
            panel1 = new System.Windows.Forms.Panel();
            lblToplamTutar = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnİskontoUygula = new DevExpress.XtraEditors.SimpleButton();
            btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            btnAra = new DevExpress.XtraEditors.SimpleButton();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            txtBarkodNo = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            textBox1 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btnUrunAra = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).BeginInit();
            xtraTabControl1.SuspendLayout();
            xtraTabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // xtraTabControl1
            // 
            xtraTabControl1.Appearance.BackColor = System.Drawing.Color.White;
            xtraTabControl1.Appearance.BorderColor = System.Drawing.Color.White;
            xtraTabControl1.Appearance.Options.UseBackColor = true;
            xtraTabControl1.Appearance.Options.UseBorderColor = true;
            xtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.True;
            xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            xtraTabControl1.Name = "xtraTabControl1";
            xtraTabControl1.SelectedTabPage = xtraTabPage1;
            xtraTabControl1.Size = new System.Drawing.Size(1104, 786);
            xtraTabControl1.TabIndex = 0;
            xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            xtraTabPage1.Appearance.Header.Options.UseFont = true;
            xtraTabPage1.Controls.Add(groupBox1);
            xtraTabPage1.Controls.Add(panel1);
            xtraTabPage1.Controls.Add(label2);
            xtraTabPage1.Controls.Add(btnİskontoUygula);
            xtraTabPage1.Controls.Add(btnVazgec);
            xtraTabPage1.Controls.Add(btnAra);
            xtraTabPage1.Controls.Add(dataGridView1);
            xtraTabPage1.Controls.Add(txtBarkodNo);
            xtraTabPage1.Controls.Add(label1);
            xtraTabPage1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("xtraTabPage1.ImageOptions.Image");
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new System.Drawing.Size(1102, 740);
            xtraTabPage1.Text = "Barkod No İle Ara";
            xtraTabPage1.Paint += xtraTabPage1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMusteriyeNakitOde);
            groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            groupBox1.Location = new System.Drawing.Point(517, 575);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(432, 114);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vade Onaylama";
            // 
            // btnMusteriyeNakitOde
            // 
            btnMusteriyeNakitOde.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnMusteriyeNakitOde.Appearance.ForeColor = System.Drawing.Color.Black;
            btnMusteriyeNakitOde.Appearance.Options.UseFont = true;
            btnMusteriyeNakitOde.Appearance.Options.UseForeColor = true;
            btnMusteriyeNakitOde.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnMusteriyeNakitOde.ImageOptions.Image");
            btnMusteriyeNakitOde.Location = new System.Drawing.Point(38, 41);
            btnMusteriyeNakitOde.Name = "btnMusteriyeNakitOde";
            btnMusteriyeNakitOde.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnMusteriyeNakitOde.Size = new System.Drawing.Size(246, 51);
            btnMusteriyeNakitOde.TabIndex = 9;
            btnMusteriyeNakitOde.Text = "Müşteriye Ödeme Yap";
            btnMusteriyeNakitOde.Click += btnMusteriyeNakitOde_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            panel1.Controls.Add(lblToplamTutar);
            panel1.Location = new System.Drawing.Point(142, 563);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(357, 166);
            panel1.TabIndex = 7;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblToplamTutar.Location = new System.Drawing.Point(76, 42);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new System.Drawing.Size(0, 72);
            lblToplamTutar.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 19.8000011F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(6, 597);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(130, 41);
            label2.TabIndex = 6;
            label2.Text = "Toplam";
            // 
            // btnİskontoUygula
            // 
            btnİskontoUygula.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnİskontoUygula.Appearance.Options.UseFont = true;
            btnİskontoUygula.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnİskontoUygula.ImageOptions.Image");
            btnİskontoUygula.Location = new System.Drawing.Point(777, 40);
            btnİskontoUygula.Name = "btnİskontoUygula";
            btnİskontoUygula.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnİskontoUygula.Size = new System.Drawing.Size(191, 48);
            btnİskontoUygula.TabIndex = 5;
            btnİskontoUygula.Text = "İskonto Uygula";
            btnİskontoUygula.Click += btnİskontoUygula_Click;
            // 
            // btnVazgec
            // 
            btnVazgec.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnVazgec.Appearance.Options.UseFont = true;
            btnVazgec.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnVazgec.ImageOptions.Image");
            btnVazgec.Location = new System.Drawing.Point(602, 40);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnVazgec.Size = new System.Drawing.Size(135, 48);
            btnVazgec.TabIndex = 4;
            btnVazgec.Text = "Vazgeç";
            btnVazgec.Click += btnVazgec_Click;
            // 
            // btnAra
            // 
            btnAra.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAra.Appearance.Options.UseFont = true;
            btnAra.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnAra.ImageOptions.Image");
            btnAra.Location = new System.Drawing.Point(407, 40);
            btnAra.Name = "btnAra";
            btnAra.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnAra.Size = new System.Drawing.Size(159, 48);
            btnAra.TabIndex = 3;
            btnAra.Text = "Ara";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(255, 128, 0);
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(-1, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(1100, 451);
            dataGridView1.TabIndex = 2;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtBarkodNo.Location = new System.Drawing.Point(30, 59);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new System.Drawing.Size(305, 29);
            txtBarkodNo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(83, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(167, 24);
            label1.TabIndex = 0;
            label1.Text = "Barkod No İle Ara";
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            xtraTabPage2.Appearance.Header.Options.UseFont = true;
            xtraTabPage2.Appearance.PageClient.BackColor = System.Drawing.SystemColors.HotTrack;
            xtraTabPage2.Appearance.PageClient.Options.UseBackColor = true;
            xtraTabPage2.Controls.Add(btnUrunAra);
            xtraTabPage2.Controls.Add(dataGridView2);
            xtraTabPage2.Controls.Add(textBox1);
            xtraTabPage2.Controls.Add(label3);
            xtraTabPage2.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("xtraTabPage2.ImageOptions.Image");
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new System.Drawing.Size(1102, 740);
            xtraTabPage2.Text = "Ürün Adı İle Ara";
            xtraTabPage2.Paint += xtraTabPage2_Paint;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new System.Drawing.Point(3, 149);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new System.Drawing.Size(1096, 338);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox1.Location = new System.Drawing.Point(347, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(334, 29);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(215, 102);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(126, 28);
            label3.TabIndex = 0;
            label3.Text = "Ürünün Adı";
            // 
            // btnUrunAra
            // 
            btnUrunAra.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnUrunAra.Appearance.Options.UseFont = true;
            btnUrunAra.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            btnUrunAra.Location = new System.Drawing.Point(700, 94);
            btnUrunAra.Name = "btnUrunAra";
            btnUrunAra.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnUrunAra.Size = new System.Drawing.Size(134, 39);
            btnUrunAra.TabIndex = 3;
            btnUrunAra.Text = "Ara";
            btnUrunAra.Click += btnUrunAra_Click;
            // 
            // MusterİadeAl
            // 
            Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1128, 798);
            Controls.Add(xtraTabControl1);
            Name = "MusterİadeAl";
            Text = "MusterİadeAl";
            Load += MusterİadeAl_Load;
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).EndInit();
            xtraTabControl1.ResumeLayout(false);
            xtraTabPage1.ResumeLayout(false);
            xtraTabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            xtraTabPage2.ResumeLayout(false);
            xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton btnİskontoUygula;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnMusteriyeNakitOde;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnUrunAra;
    }
}