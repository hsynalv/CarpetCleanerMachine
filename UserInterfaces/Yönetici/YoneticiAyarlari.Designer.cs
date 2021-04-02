
namespace UserInterfaces.Yönetici
{
    partial class YoneticiAyarlari
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.lbl_uyari = new System.Windows.Forms.Label();
            this.checkMustGor = new System.Windows.Forms.CheckBox();
            this.check_siparis = new System.Windows.Forms.CheckBox();
            this.checkMustEkle = new System.Windows.Forms.CheckBox();
            this.checkMAkGor = new System.Windows.Forms.CheckBox();
            this.checkMAkEkle = new System.Windows.Forms.CheckBox();
            this.checkYonetici = new System.Windows.Forms.CheckBox();
            this.btn_personelSİL = new System.Windows.Forms.Button();
            this.btn_personelEkle = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_yenile);
            this.panel1.Controls.Add(this.lbl_uyari);
            this.panel1.Controls.Add(this.checkMustGor);
            this.panel1.Controls.Add(this.check_siparis);
            this.panel1.Controls.Add(this.checkMustEkle);
            this.panel1.Controls.Add(this.checkMAkGor);
            this.panel1.Controls.Add(this.checkMAkEkle);
            this.panel1.Controls.Add(this.checkYonetici);
            this.panel1.Controls.Add(this.btn_personelSİL);
            this.panel1.Controls.Add(this.btn_personelEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(529, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 362);
            this.panel1.TabIndex = 1;
            // 
            // btn_yenile
            // 
            this.btn_yenile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_yenile.Location = new System.Drawing.Point(12, 272);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(111, 23);
            this.btn_yenile.TabIndex = 3;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // lbl_uyari
            // 
            this.lbl_uyari.AutoSize = true;
            this.lbl_uyari.ForeColor = System.Drawing.Color.Red;
            this.lbl_uyari.Location = new System.Drawing.Point(16, 16);
            this.lbl_uyari.Name = "lbl_uyari";
            this.lbl_uyari.Size = new System.Drawing.Size(0, 13);
            this.lbl_uyari.TabIndex = 2;
            // 
            // checkMustGor
            // 
            this.checkMustGor.AutoSize = true;
            this.checkMustGor.Location = new System.Drawing.Point(15, 185);
            this.checkMustGor.Name = "checkMustGor";
            this.checkMustGor.Size = new System.Drawing.Size(109, 17);
            this.checkMustGor.TabIndex = 1;
            this.checkMustGor.Text = "Müşteri Görüntüle";
            this.checkMustGor.UseVisualStyleBackColor = true;
            this.checkMustGor.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // check_siparis
            // 
            this.check_siparis.AutoSize = true;
            this.check_siparis.Location = new System.Drawing.Point(16, 243);
            this.check_siparis.Name = "check_siparis";
            this.check_siparis.Size = new System.Drawing.Size(81, 17);
            this.check_siparis.TabIndex = 1;
            this.check_siparis.Text = "Sipariş Ekle";
            this.check_siparis.UseVisualStyleBackColor = true;
            this.check_siparis.CheckedChanged += new System.EventHandler(this.check_siparis_CheckedChanged);
            // 
            // checkMustEkle
            // 
            this.checkMustEkle.AutoSize = true;
            this.checkMustEkle.Location = new System.Drawing.Point(16, 220);
            this.checkMustEkle.Name = "checkMustEkle";
            this.checkMustEkle.Size = new System.Drawing.Size(84, 17);
            this.checkMustEkle.TabIndex = 1;
            this.checkMustEkle.Text = "Müşteri Ekle";
            this.checkMustEkle.UseVisualStyleBackColor = true;
            this.checkMustEkle.CheckedChanged += new System.EventHandler(this.checkMustEkle_CheckedChanged);
            // 
            // checkMAkGor
            // 
            this.checkMAkGor.AutoSize = true;
            this.checkMAkGor.Location = new System.Drawing.Point(16, 120);
            this.checkMAkGor.Name = "checkMAkGor";
            this.checkMAkGor.Size = new System.Drawing.Size(110, 17);
            this.checkMAkGor.TabIndex = 1;
            this.checkMAkGor.Text = "Makine Görüntüle";
            this.checkMAkGor.UseVisualStyleBackColor = true;
            this.checkMAkGor.CheckedChanged += new System.EventHandler(this.checkMAkGor_CheckedChanged);
            // 
            // checkMAkEkle
            // 
            this.checkMAkEkle.AutoSize = true;
            this.checkMAkEkle.Location = new System.Drawing.Point(15, 153);
            this.checkMAkEkle.Name = "checkMAkEkle";
            this.checkMAkEkle.Size = new System.Drawing.Size(85, 17);
            this.checkMAkEkle.TabIndex = 1;
            this.checkMAkEkle.Text = "Makine Ekle";
            this.checkMAkEkle.UseVisualStyleBackColor = true;
            this.checkMAkEkle.CheckedChanged += new System.EventHandler(this.checkMAkEkle_CheckedChanged);
            // 
            // checkYonetici
            // 
            this.checkYonetici.AutoSize = true;
            this.checkYonetici.Location = new System.Drawing.Point(16, 86);
            this.checkYonetici.Name = "checkYonetici";
            this.checkYonetici.Size = new System.Drawing.Size(98, 17);
            this.checkYonetici.TabIndex = 1;
            this.checkYonetici.Text = "Yönetici Yetkisi";
            this.checkYonetici.UseVisualStyleBackColor = true;
            this.checkYonetici.CheckedChanged += new System.EventHandler(this.checkYonetici_CheckedChanged);
            // 
            // btn_personelSİL
            // 
            this.btn_personelSİL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_personelSİL.Location = new System.Drawing.Point(10, 311);
            this.btn_personelSİL.Name = "btn_personelSİL";
            this.btn_personelSİL.Size = new System.Drawing.Size(111, 23);
            this.btn_personelSİL.TabIndex = 0;
            this.btn_personelSİL.Text = "Personel Sil";
            this.btn_personelSİL.UseVisualStyleBackColor = true;
            this.btn_personelSİL.Click += new System.EventHandler(this.btn_personelSİL_Click);
            // 
            // btn_personelEkle
            // 
            this.btn_personelEkle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_personelEkle.Location = new System.Drawing.Point(10, 47);
            this.btn_personelEkle.Name = "btn_personelEkle";
            this.btn_personelEkle.Size = new System.Drawing.Size(111, 23);
            this.btn_personelEkle.TabIndex = 0;
            this.btn_personelEkle.Text = "Personel Ekle";
            this.btn_personelEkle.UseVisualStyleBackColor = true;
            this.btn_personelEkle.Click += new System.EventHandler(this.btn_personelEkle_Click);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.dataGridView1);
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(538, 366);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(532, 347);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // YoneticiAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 362);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "YoneticiAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yönetici Ayarları";
            this.Load += new System.EventHandler(this.YoneticiAyarlari_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_personelEkle;
        private System.Windows.Forms.CheckBox checkMustEkle;
        private System.Windows.Forms.CheckBox checkMAkGor;
        private System.Windows.Forms.CheckBox checkMAkEkle;
        private System.Windows.Forms.CheckBox checkYonetici;
        private System.Windows.Forms.Button btn_personelSİL;
        private System.Windows.Forms.CheckBox checkMustGor;
        private System.Windows.Forms.Label lbl_uyari;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.CheckBox check_siparis;
    }
}