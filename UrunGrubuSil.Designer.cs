namespace GirisEkranı
{
    partial class UrunGrubuSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunGrubuSil));
            label1 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(13, 94);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(151, 24);
            label1.TabIndex = 0;
            label1.Text = "Ürün Grubu Sil :";
            // 
            // comboBox1
            // 
            comboBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(170, 94);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(249, 29);
            comboBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView1.Location = new System.Drawing.Point(0, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(650, 261);
            dataGridView1.TabIndex = 2;
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new System.Drawing.Point(453, 94);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton1.Size = new System.Drawing.Size(137, 39);
            simpleButton1.TabIndex = 3;
            simpleButton1.Text = "Sil";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // UrunGrubuSil
            // 
            Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(650, 415);
            Controls.Add(simpleButton1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "UrunGrubuSil";
            Text = "UrunGrubuSil";
            Load += UrunGrubuSil_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}