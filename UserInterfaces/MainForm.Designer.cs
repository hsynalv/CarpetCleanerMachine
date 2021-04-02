
namespace UserInterfaces
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterileriGörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makineİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makineleriGörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makineGirdisiYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otomatikYıkamaMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paketlemeMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meçMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tozÇırpmaMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sıkmaMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sevkEdilenMakinelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokMakinelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilAyarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiTool = new System.Windows.Forms.ToolStripMenuItem();
            this.logkayitlariTool = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_kullanıcı = new System.Windows.Forms.TextBox();
            this.lst_siparis = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AnaPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriİşlemleriToolStripMenuItem,
            this.makineİşlemleriToolStripMenuItem,
            this.profilAyarıToolStripMenuItem,
            this.yöneticiTool,
            this.logkayitlariTool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriİşlemleriToolStripMenuItem
            // 
            this.müşteriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşterileriGörToolStripMenuItem,
            this.müşteriEkleToolStripMenuItem});
            this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
            this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.müşteriİşlemleriToolStripMenuItem.Text = "Müşteri İşlemleri";
            // 
            // müşterileriGörToolStripMenuItem
            // 
            this.müşterileriGörToolStripMenuItem.Name = "müşterileriGörToolStripMenuItem";
            this.müşterileriGörToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.müşterileriGörToolStripMenuItem.Text = "Müşterileri Gör";
            this.müşterileriGörToolStripMenuItem.Click += new System.EventHandler(this.müşterileriGörToolStripMenuItem_Click);
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem_Click);
            // 
            // makineİşlemleriToolStripMenuItem
            // 
            this.makineİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makineleriGörToolStripMenuItem,
            this.makineGirdisiYapToolStripMenuItem,
            this.sevkEdilenMakinelerToolStripMenuItem,
            this.stokMakinelerToolStripMenuItem});
            this.makineİşlemleriToolStripMenuItem.Name = "makineİşlemleriToolStripMenuItem";
            this.makineİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.makineİşlemleriToolStripMenuItem.Text = "Makine İşlemleri";
            // 
            // makineleriGörToolStripMenuItem
            // 
            this.makineleriGörToolStripMenuItem.Name = "makineleriGörToolStripMenuItem";
            this.makineleriGörToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.makineleriGörToolStripMenuItem.Text = "Makineleri Gör";
            this.makineleriGörToolStripMenuItem.Click += new System.EventHandler(this.makineleriGörToolStripMenuItem_Click);
            // 
            // makineGirdisiYapToolStripMenuItem
            // 
            this.makineGirdisiYapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otomatikYıkamaMakinesiToolStripMenuItem,
            this.paketlemeMakinesiToolStripMenuItem,
            this.meçMakinesiToolStripMenuItem,
            this.tozÇırpmaMakinesiToolStripMenuItem,
            this.sıkmaMakinesiToolStripMenuItem});
            this.makineGirdisiYapToolStripMenuItem.Name = "makineGirdisiYapToolStripMenuItem";
            this.makineGirdisiYapToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.makineGirdisiYapToolStripMenuItem.Text = "Makine Girdisi Yap";
            // 
            // otomatikYıkamaMakinesiToolStripMenuItem
            // 
            this.otomatikYıkamaMakinesiToolStripMenuItem.Name = "otomatikYıkamaMakinesiToolStripMenuItem";
            this.otomatikYıkamaMakinesiToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.otomatikYıkamaMakinesiToolStripMenuItem.Text = "Otomatik Yıkama Makinesi";
            this.otomatikYıkamaMakinesiToolStripMenuItem.Click += new System.EventHandler(this.otomatikYıkamaMakinesiToolStripMenuItem_Click);
            // 
            // paketlemeMakinesiToolStripMenuItem
            // 
            this.paketlemeMakinesiToolStripMenuItem.Name = "paketlemeMakinesiToolStripMenuItem";
            this.paketlemeMakinesiToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.paketlemeMakinesiToolStripMenuItem.Text = "Paketleme Makinesi";
            this.paketlemeMakinesiToolStripMenuItem.Click += new System.EventHandler(this.paketlemeMakinesiToolStripMenuItem_Click);
            // 
            // meçMakinesiToolStripMenuItem
            // 
            this.meçMakinesiToolStripMenuItem.Name = "meçMakinesiToolStripMenuItem";
            this.meçMakinesiToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.meçMakinesiToolStripMenuItem.Text = "Meç Makinesi";
            this.meçMakinesiToolStripMenuItem.Click += new System.EventHandler(this.meçMakinesiToolStripMenuItem_Click);
            // 
            // tozÇırpmaMakinesiToolStripMenuItem
            // 
            this.tozÇırpmaMakinesiToolStripMenuItem.Name = "tozÇırpmaMakinesiToolStripMenuItem";
            this.tozÇırpmaMakinesiToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.tozÇırpmaMakinesiToolStripMenuItem.Text = "Toz Çırpma Makinesi";
            this.tozÇırpmaMakinesiToolStripMenuItem.Click += new System.EventHandler(this.tozÇırpmaMakinesiToolStripMenuItem_Click);
            // 
            // sıkmaMakinesiToolStripMenuItem
            // 
            this.sıkmaMakinesiToolStripMenuItem.Name = "sıkmaMakinesiToolStripMenuItem";
            this.sıkmaMakinesiToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.sıkmaMakinesiToolStripMenuItem.Text = "Sıkma Makinesi";
            this.sıkmaMakinesiToolStripMenuItem.Click += new System.EventHandler(this.sıkmaMakinesiToolStripMenuItem_Click);
            // 
            // sevkEdilenMakinelerToolStripMenuItem
            // 
            this.sevkEdilenMakinelerToolStripMenuItem.Name = "sevkEdilenMakinelerToolStripMenuItem";
            this.sevkEdilenMakinelerToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.sevkEdilenMakinelerToolStripMenuItem.Text = "Sevk Edilen Makineler";
            this.sevkEdilenMakinelerToolStripMenuItem.Click += new System.EventHandler(this.sevkEdilenMakinelerToolStripMenuItem_Click);
            // 
            // stokMakinelerToolStripMenuItem
            // 
            this.stokMakinelerToolStripMenuItem.Name = "stokMakinelerToolStripMenuItem";
            this.stokMakinelerToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.stokMakinelerToolStripMenuItem.Text = "Stok Makineler";
            this.stokMakinelerToolStripMenuItem.Click += new System.EventHandler(this.stokMakinelerToolStripMenuItem_Click);
            // 
            // profilAyarıToolStripMenuItem
            // 
            this.profilAyarıToolStripMenuItem.Name = "profilAyarıToolStripMenuItem";
            this.profilAyarıToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.profilAyarıToolStripMenuItem.Text = "Profil Ayarı";
            this.profilAyarıToolStripMenuItem.Click += new System.EventHandler(this.profilAyarıToolStripMenuItem_Click);
            // 
            // yöneticiTool
            // 
            this.yöneticiTool.Name = "yöneticiTool";
            this.yöneticiTool.Size = new System.Drawing.Size(61, 20);
            this.yöneticiTool.Text = "Yönetici";
            this.yöneticiTool.Click += new System.EventHandler(this.yöneticiToolStripMenuItem_Click);
            // 
            // logkayitlariTool
            // 
            this.logkayitlariTool.Name = "logkayitlariTool";
            this.logkayitlariTool.Size = new System.Drawing.Size(84, 20);
            this.logkayitlariTool.Text = "Log Kayıtları";
            this.logkayitlariTool.Click += new System.EventHandler(this.logkayitlariTool_Click);
            // 
            // txt_kullanıcı
            // 
            this.txt_kullanıcı.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_kullanıcı.Enabled = false;
            this.txt_kullanıcı.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullanıcı.Location = new System.Drawing.Point(894, 0);
            this.txt_kullanıcı.Multiline = true;
            this.txt_kullanıcı.Name = "txt_kullanıcı";
            this.txt_kullanıcı.Size = new System.Drawing.Size(150, 24);
            this.txt_kullanıcı.TabIndex = 2;
            // 
            // lst_siparis
            // 
            this.lst_siparis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_siparis.Font = new System.Drawing.Font("Georgia", 9F);
            this.lst_siparis.FormattingEnabled = true;
            this.lst_siparis.ItemHeight = 15;
            this.lst_siparis.Location = new System.Drawing.Point(0, 0);
            this.lst_siparis.Name = "lst_siparis";
            this.lst_siparis.Size = new System.Drawing.Size(150, 574);
            this.lst_siparis.TabIndex = 4;
            this.lst_siparis.DoubleClick += new System.EventHandler(this.lst_siparis_DoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(0, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Liste Yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnaPanel
            // 
            this.AnaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnaPanel.Location = new System.Drawing.Point(0, 23);
            this.AnaPanel.Name = "AnaPanel";
            this.AnaPanel.Size = new System.Drawing.Size(898, 574);
            this.AnaPanel.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lst_siparis);
            this.panel2.Location = new System.Drawing.Point(894, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 574);
            this.panel2.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AnaPanel);
            this.Controls.Add(this.txt_kullanıcı);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sumak Metal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterileriGörToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makineİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makineleriGörToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makineGirdisiYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otomatikYıkamaMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paketlemeMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meçMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tozÇırpmaMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sıkmaMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiTool;
        private System.Windows.Forms.ToolStripMenuItem profilAyarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logkayitlariTool;
        private System.Windows.Forms.TextBox txt_kullanıcı;
        private System.Windows.Forms.ToolStripMenuItem sevkEdilenMakinelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokMakinelerToolStripMenuItem;
        private System.Windows.Forms.ListBox lst_siparis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel AnaPanel;
        private System.Windows.Forms.Panel panel2;
    }
}

