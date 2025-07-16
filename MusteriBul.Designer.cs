namespace GirisEkranı
{
    partial class MusteriBul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriBul));
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtMuster = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            btnMusteriAra = new DevExpress.XtraEditors.SimpleButton();
            btnMusteriSil = new DevExpress.XtraEditors.SimpleButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(767, 66);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(300, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(192, 48);
            label1.TabIndex = 0;
            label1.Text = "Müşteriler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 10.2F);
            label2.Location = new System.Drawing.Point(12, 117);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(107, 21);
            label2.TabIndex = 1;
            label2.Text = "Müşteri Ara :";
            // 
            // txtMuster
            // 
            txtMuster.Font = new System.Drawing.Font("Tahoma", 10.2F);
            txtMuster.Location = new System.Drawing.Point(134, 114);
            txtMuster.Name = "txtMuster";
            txtMuster.Size = new System.Drawing.Size(310, 28);
            txtMuster.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Navy;
            label3.Location = new System.Drawing.Point(218, 82);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(151, 21);
            label3.TabIndex = 3;
            label3.Text = "<<İsim Soyisim>>";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView1.Location = new System.Drawing.Point(0, 221);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(767, 248);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnMusteriAra
            // 
            btnMusteriAra.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            btnMusteriAra.Appearance.Options.UseFont = true;
            btnMusteriAra.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnMusteriAra.ImageOptions.Image");
            btnMusteriAra.Location = new System.Drawing.Point(577, 82);
            btnMusteriAra.Name = "btnMusteriAra";
            btnMusteriAra.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnMusteriAra.Size = new System.Drawing.Size(159, 42);
            btnMusteriAra.TabIndex = 5;
            btnMusteriAra.Text = "Müşteri Ara";
            btnMusteriAra.Click += btnMusteriAra_Click;
            // 
            // btnMusteriSil
            // 
            btnMusteriSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            btnMusteriSil.Appearance.Options.UseFont = true;
            btnMusteriSil.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnMusteriSil.ImageOptions.Image");
            btnMusteriSil.Location = new System.Drawing.Point(577, 151);
            btnMusteriSil.Name = "btnMusteriSil";
            btnMusteriSil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnMusteriSil.Size = new System.Drawing.Size(159, 42);
            btnMusteriSil.TabIndex = 6;
            btnMusteriSil.Text = "Müşteri Sil";
            btnMusteriSil.Click += btnMusteriSil_Click;
            // 
            // MusteriBul
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(767, 469);
            Controls.Add(btnMusteriSil);
            Controls.Add(btnMusteriAra);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(txtMuster);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "MusteriBul";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MusteriBul";
            Load += MusteriBul_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMuster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btnMusteriAra;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnMusteriSil;
    }
}