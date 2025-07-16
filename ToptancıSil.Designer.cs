namespace GirisEkranı
{
    partial class ToptancıSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToptancıSil));
            panel1 = new System.Windows.Forms.Panel();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            label1 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(918, 92);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnClose.Appearance.Options.UseFont = true;
            btnClose.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.Location = new System.Drawing.Point(1103, 0);
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnClose.Size = new System.Drawing.Size(37, 36);
            btnClose.TabIndex = 6;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(353, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(248, 45);
            label1.TabIndex = 0;
            label1.Text = "Toptancı Sil ";
            // 
            // comboBox1
            // 
            comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(160, 151);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(307, 33);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label2.Location = new System.Drawing.Point(21, 154);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(133, 25);
            label2.TabIndex = 2;
            label2.Text = "Toptancı Adı :";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView1.Location = new System.Drawing.Point(0, 241);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(918, 303);
            dataGridView1.TabIndex = 3;
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new System.Drawing.Point(494, 151);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton1.Size = new System.Drawing.Size(151, 36);
            simpleButton1.TabIndex = 4;
            simpleButton1.Text = "Sil";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // ToptancıSil
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(918, 544);
            Controls.Add(simpleButton1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Name = "ToptancıSil";
            Text = "ToptancıSil";
            Load += ToptancıSil_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}