
namespace UserInterfaces.Musteriler
{
    partial class MusteriGor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_message = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_makGör = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.lbl_uyari = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ara_il = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ara_ad = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 324);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
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
            this.dataGridView1.Size = new System.Drawing.Size(665, 305);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.txt_ara_ad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_ara_il);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_message);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_makGör);
            this.panel1.Controls.Add(this.btn_guncelle);
            this.panel1.Controls.Add(this.btn_yenile);
            this.panel1.Controls.Add(this.btn_sil);
            this.panel1.Controls.Add(this.lbl_uyari);
            this.panel1.Location = new System.Drawing.Point(676, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 327);
            this.panel1.TabIndex = 2;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_message.ForeColor = System.Drawing.Color.Red;
            this.lbl_message.Location = new System.Drawing.Point(4, 209);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 15);
            this.lbl_message.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Sipariş Gir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_makGör
            // 
            this.btn_makGör.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_makGör.AutoSize = true;
            this.btn_makGör.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_makGör.Location = new System.Drawing.Point(1, 12);
            this.btn_makGör.Name = "btn_makGör";
            this.btn_makGör.Size = new System.Drawing.Size(117, 25);
            this.btn_makGör.TabIndex = 13;
            this.btn_makGör.Text = "Makinelerini Gör";
            this.btn_makGör.UseVisualStyleBackColor = true;
            this.btn_makGör.Click += new System.EventHandler(this.btn_makGör_Click_1);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_guncelle.Location = new System.Drawing.Point(1, 55);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(116, 23);
            this.btn_guncelle.TabIndex = 10;
            this.btn_guncelle.Text = "Müşteriyi Düzenle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click_1);
            // 
            // btn_yenile
            // 
            this.btn_yenile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_yenile.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yenile.Location = new System.Drawing.Point(1, 183);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(114, 23);
            this.btn_yenile.TabIndex = 11;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click_1);
            // 
            // btn_sil
            // 
            this.btn_sil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sil.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(1, 137);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(117, 23);
            this.btn_sil.TabIndex = 12;
            this.btn_sil.Text = "Müşteriyi Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click_1);
            // 
            // lbl_uyari
            // 
            this.lbl_uyari.AutoSize = true;
            this.lbl_uyari.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_uyari.ForeColor = System.Drawing.Color.Red;
            this.lbl_uyari.Location = new System.Drawing.Point(125, 9);
            this.lbl_uyari.Name = "lbl_uyari";
            this.lbl_uyari.Size = new System.Drawing.Size(0, 15);
            this.lbl_uyari.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "İl/Ülkeye Göre Ara";
            // 
            // txt_ara_il
            // 
            this.txt_ara_il.Location = new System.Drawing.Point(7, 295);
            this.txt_ara_il.Name = "txt_ara_il";
            this.txt_ara_il.Size = new System.Drawing.Size(100, 20);
            this.txt_ara_il.TabIndex = 16;
            this.txt_ara_il.TextChanged += new System.EventHandler(this.txt_ara_il_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ada Göre Ara";
            // 
            // txt_ara_ad
            // 
            this.txt_ara_ad.Location = new System.Drawing.Point(7, 255);
            this.txt_ara_ad.Name = "txt_ara_ad";
            this.txt_ara_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ara_ad.TabIndex = 16;
            this.txt_ara_ad.TextChanged += new System.EventHandler(this.txt_ara_ad_TextChanged);
            // 
            // MusteriGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 327);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MusteriGor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.MusteriGor_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Label lbl_uyari;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_makGör;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox txt_ara_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ara_il;
        private System.Windows.Forms.Label label1;
    }
}