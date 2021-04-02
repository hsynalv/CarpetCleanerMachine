
namespace UserInterfaces.Yönetici
{
    partial class PersonelEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_kAdi = new System.Windows.Forms.TextBox();
            this.check_yönetici = new System.Windows.Forms.CheckBox();
            this.check_makineGor = new System.Windows.Forms.CheckBox();
            this.check_siparis = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkMakEkle = new System.Windows.Forms.CheckBox();
            this.check_musteriEkle = new System.Windows.Forms.CheckBox();
            this.check_musteriGor = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Adı: ";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(144, 27);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(170, 20);
            this.txt_ad.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Personel Soyadı:";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(144, 60);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(170, 20);
            this.txt_soyad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Personel Kullanıcı Adı: ";
            // 
            // txt_kAdi
            // 
            this.txt_kAdi.Location = new System.Drawing.Point(144, 98);
            this.txt_kAdi.Name = "txt_kAdi";
            this.txt_kAdi.Size = new System.Drawing.Size(170, 20);
            this.txt_kAdi.TabIndex = 2;
            // 
            // check_yönetici
            // 
            this.check_yönetici.AutoSize = true;
            this.check_yönetici.Location = new System.Drawing.Point(29, 138);
            this.check_yönetici.Name = "check_yönetici";
            this.check_yönetici.Size = new System.Drawing.Size(98, 17);
            this.check_yönetici.TabIndex = 3;
            this.check_yönetici.Text = "Yönetici Yetkisi";
            this.check_yönetici.UseVisualStyleBackColor = true;
            // 
            // check_makineGor
            // 
            this.check_makineGor.AutoSize = true;
            this.check_makineGor.Location = new System.Drawing.Point(29, 161);
            this.check_makineGor.Name = "check_makineGor";
            this.check_makineGor.Size = new System.Drawing.Size(81, 17);
            this.check_makineGor.TabIndex = 4;
            this.check_makineGor.Text = "Makine Gör";
            this.check_makineGor.UseVisualStyleBackColor = true;
            // 
            // check_siparis
            // 
            this.check_siparis.AutoSize = true;
            this.check_siparis.Location = new System.Drawing.Point(176, 138);
            this.check_siparis.Name = "check_siparis";
            this.check_siparis.Size = new System.Drawing.Size(81, 17);
            this.check_siparis.TabIndex = 5;
            this.check_siparis.Text = "Sipariş Ekle";
            this.check_siparis.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkMakEkle
            // 
            this.checkMakEkle.AutoSize = true;
            this.checkMakEkle.Location = new System.Drawing.Point(29, 184);
            this.checkMakEkle.Name = "checkMakEkle";
            this.checkMakEkle.Size = new System.Drawing.Size(85, 17);
            this.checkMakEkle.TabIndex = 3;
            this.checkMakEkle.Text = "Makine Ekle";
            this.checkMakEkle.UseVisualStyleBackColor = true;
            // 
            // check_musteriEkle
            // 
            this.check_musteriEkle.AutoSize = true;
            this.check_musteriEkle.Location = new System.Drawing.Point(176, 184);
            this.check_musteriEkle.Name = "check_musteriEkle";
            this.check_musteriEkle.Size = new System.Drawing.Size(84, 17);
            this.check_musteriEkle.TabIndex = 4;
            this.check_musteriEkle.Text = "Müşteri Ekle";
            this.check_musteriEkle.UseVisualStyleBackColor = true;
            // 
            // check_musteriGor
            // 
            this.check_musteriGor.AutoSize = true;
            this.check_musteriGor.Location = new System.Drawing.Point(176, 161);
            this.check_musteriGor.Name = "check_musteriGor";
            this.check_musteriGor.Size = new System.Drawing.Size(80, 17);
            this.check_musteriGor.TabIndex = 5;
            this.check_musteriGor.Text = "Müsteri Gör";
            this.check_musteriGor.UseVisualStyleBackColor = true;
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 268);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.check_musteriGor);
            this.Controls.Add(this.check_siparis);
            this.Controls.Add(this.check_musteriEkle);
            this.Controls.Add(this.check_makineGor);
            this.Controls.Add(this.checkMakEkle);
            this.Controls.Add(this.check_yönetici);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_kAdi);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PersonelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personel Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_kAdi;
        private System.Windows.Forms.CheckBox check_yönetici;
        private System.Windows.Forms.CheckBox check_makineGor;
        private System.Windows.Forms.CheckBox check_siparis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkMakEkle;
        private System.Windows.Forms.CheckBox check_musteriEkle;
        private System.Windows.Forms.CheckBox check_musteriGor;
    }
}