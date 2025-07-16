using System;
using System.Windows.Forms;

namespace GirisEkranı
{
    partial class ÜrünAraSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÜrünAraSil));
            panel1 = new Panel();
            btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label2 = new Label();
            btnUrunSil = new DevExpress.XtraEditors.SimpleButton();
            btnUrunAra = new DevExpress.XtraEditors.SimpleButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            panel1.Controls.Add(btnVazgec);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(755, 125);
            panel1.TabIndex = 0;
            // 
            // btnVazgec
            // 
            btnVazgec.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnVazgec.Appearance.Options.UseFont = true;
            btnVazgec.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnVazgec.ImageOptions.Image");
            btnVazgec.Location = new System.Drawing.Point(722, 3);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnVazgec.Size = new System.Drawing.Size(41, 41);
            btnVazgec.TabIndex = 6;
            btnVazgec.Click += btnVazgec_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(269, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(227, 41);
            label1.TabIndex = 0;
            label1.Text = "Ürün Ara-Sil";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new System.Drawing.Point(0, 327);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(755, 270);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBox1.Location = new System.Drawing.Point(117, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(336, 28);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(12, 156);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 21);
            label2.TabIndex = 3;
            label2.Text = "Ürün Adı :";
            // 
            // btnUrunSil
            // 
            btnUrunSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnUrunSil.Appearance.Options.UseFont = true;
            btnUrunSil.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnUrunSil.ImageOptions.Image");
            btnUrunSil.Location = new System.Drawing.Point(474, 212);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnUrunSil.Size = new System.Drawing.Size(173, 51);
            btnUrunSil.TabIndex = 4;
            btnUrunSil.Text = "Ürün Sil";
            btnUrunSil.Click += btnUrunSil_Click;
            // 
            // btnUrunAra
            // 
            btnUrunAra.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnUrunAra.Appearance.Options.UseFont = true;
            btnUrunAra.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnUrunAra.ImageOptions.Image");
            btnUrunAra.Location = new System.Drawing.Point(474, 156);
            btnUrunAra.Name = "btnUrunAra";
            btnUrunAra.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnUrunAra.Size = new System.Drawing.Size(162, 37);
            btnUrunAra.TabIndex = 5;
            btnUrunAra.Text = "Ürün Ara";
            btnUrunAra.Click += btnUrunAra_Click;
            // 
            // ÜrünAraSil
            // 
            Appearance.BackColor = System.Drawing.SystemColors.InactiveBorder;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(755, 597);
            Controls.Add(btnUrunAra);
            Controls.Add(btnUrunSil);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.LargeImage = (System.Drawing.Image)resources.GetObject("ÜrünAraSil.IconOptions.LargeImage");
            Name = "ÜrünAraSil";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ÜrünAraSil";
            Load += ÜrünAraSil_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnUrunSil;
        private DevExpress.XtraEditors.SimpleButton btnUrunAra;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
    }
}