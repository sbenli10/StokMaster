namespace GirisEkranı
{
    partial class EskiSatıslar
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EskiSatıslar));
            schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(components);
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            btnTarihGit = new DevExpress.XtraEditors.SimpleButton();
            btnBarkodNumarası = new DevExpress.XtraEditors.SimpleButton();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            txtBarkodNo = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtSatısTarihi = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            lblToplamtutar = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)schedulerDataStorage1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            // 
            // 
            // 
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb(255, 194, 190));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb(168, 213, 255));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb(193, 244, 156));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb(243, 228, 199));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb(244, 206, 147));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb(199, 244, 255));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb(207, 219, 152));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb(224, 207, 233));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb(141, 233, 223));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb(255, 247, 165));
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(234, 26);
            dateTimePicker1.TabIndex = 0;
            // 
            // btnTarihGit
            // 
            btnTarihGit.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnTarihGit.Appearance.Options.UseFont = true;
            btnTarihGit.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnTarihGit.ImageOptions.Image");
            btnTarihGit.Location = new System.Drawing.Point(252, 12);
            btnTarihGit.Name = "btnTarihGit";
            btnTarihGit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnTarihGit.Size = new System.Drawing.Size(141, 26);
            btnTarihGit.TabIndex = 1;
            btnTarihGit.Text = "Tarihe Git";
            btnTarihGit.Click += btnTarihGit_Click;
            // 
            // btnBarkodNumarası
            // 
            btnBarkodNumarası.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnBarkodNumarası.Appearance.Options.UseFont = true;
            btnBarkodNumarası.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnBarkodNumarası.ImageOptions.Image");
            btnBarkodNumarası.Location = new System.Drawing.Point(531, 12);
            btnBarkodNumarası.Name = "btnBarkodNumarası";
            btnBarkodNumarası.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnBarkodNumarası.Size = new System.Drawing.Size(223, 65);
            btnBarkodNumarası.TabIndex = 2;
            btnBarkodNumarası.Text = "Fiş Numarası İle Ara";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(255, 128, 0);
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView1.Location = new System.Drawing.Point(0, 310);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(1250, 345);
            dataGridView1.TabIndex = 3;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtBarkodNo.Location = new System.Drawing.Point(134, 69);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new System.Drawing.Size(195, 28);
            txtBarkodNo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            label1.Location = new System.Drawing.Point(12, 69);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(111, 21);
            label1.TabIndex = 5;
            label1.Text = "Barkod No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            label2.Location = new System.Drawing.Point(12, 122);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(116, 21);
            label2.TabIndex = 7;
            label2.Text = "Satış Tarihi :";
            // 
            // txtSatısTarihi
            // 
            txtSatısTarihi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtSatısTarihi.Location = new System.Drawing.Point(134, 122);
            txtSatısTarihi.Name = "txtSatısTarihi";
            txtSatısTarihi.Size = new System.Drawing.Size(195, 28);
            txtSatısTarihi.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            label3.Location = new System.Drawing.Point(487, 104);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(286, 21);
            label3.TabIndex = 9;
            label3.Text = "BARKOD NUMARASI İLE ARAMA";
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox1.Location = new System.Drawing.Point(427, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(395, 28);
            textBox1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DarkCyan;
            panel1.Controls.Add(lblToplamtutar);
            panel1.Location = new System.Drawing.Point(895, 69);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(320, 124);
            panel1.TabIndex = 10;
            // 
            // lblToplamtutar
            // 
            lblToplamtutar.AutoSize = true;
            lblToplamtutar.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblToplamtutar.ForeColor = System.Drawing.Color.White;
            lblToplamtutar.Location = new System.Drawing.Point(68, 30);
            lblToplamtutar.Name = "lblToplamtutar";
            lblToplamtutar.Size = new System.Drawing.Size(98, 48);
            lblToplamtutar.TabIndex = 0;
            lblToplamtutar.Text = "0,00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 19.8000011F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(952, 19);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(221, 41);
            label4.TabIndex = 12;
            label4.Text = "Toplam Tutar";
            // 
            // EskiSatıslar
            // 
            Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1250, 655);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(txtSatısTarihi);
            Controls.Add(label1);
            Controls.Add(txtBarkodNo);
            Controls.Add(dataGridView1);
            Controls.Add(btnBarkodNumarası);
            Controls.Add(btnTarihGit);
            Controls.Add(dateTimePicker1);
            Name = "EskiSatıslar";
            Text = "EskiSatıslar";
            Load += EskiSatıslar_Load;
            ((System.ComponentModel.ISupportInitialize)schedulerDataStorage1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.SimpleButton btnTarihGit;
        private DevExpress.XtraEditors.SimpleButton btnBarkodNumarası;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSatısTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblToplamtutar;
        private System.Windows.Forms.Label label4;
    }
}