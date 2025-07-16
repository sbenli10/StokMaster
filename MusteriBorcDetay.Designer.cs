namespace GirisEkranı
{
    partial class MusteriBorcDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriBorcDetay));
            label1 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            txtMusteriAdı = new System.Windows.Forms.TextBox();
            btnAra = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(275, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(354, 48);
            label1.TabIndex = 0;
            label1.Text = "Müşteri Borç Detay";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(255, 128, 0);
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView1.Location = new System.Drawing.Point(0, 295);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(859, 228);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(99, 128);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(132, 24);
            label2.TabIndex = 2;
            label2.Text = "Müşteri İsmi :";
            // 
            // txtMusteriAdı
            // 
            txtMusteriAdı.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtMusteriAdı.Location = new System.Drawing.Point(237, 125);
            txtMusteriAdı.Name = "txtMusteriAdı";
            txtMusteriAdı.Size = new System.Drawing.Size(263, 32);
            txtMusteriAdı.TabIndex = 3;
            // 
            // btnAra
            // 
            btnAra.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAra.Appearance.Options.UseFont = true;
            btnAra.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnAra.ImageOptions.Image");
            btnAra.Location = new System.Drawing.Point(536, 118);
            btnAra.Name = "btnAra";
            btnAra.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnAra.Size = new System.Drawing.Size(134, 44);
            btnAra.TabIndex = 4;
            btnAra.Text = "Ara";
            btnAra.Click += btnAra_Click;
            // 
            // MusteriBorcDetay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(859, 523);
            Controls.Add(label1);
            Controls.Add(btnAra);
            Controls.Add(txtMusteriAdı);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "MusteriBorcDetay";
            Text = "MusteriBorcDetay";
            Load += MusteriBorcDetay_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusteriAdı;
        private DevExpress.XtraEditors.SimpleButton btnAra;
    }
}