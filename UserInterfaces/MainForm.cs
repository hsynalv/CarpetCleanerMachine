using BusinessLogicLayer;
using BusinessLogicLayer.Concrete;
using Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterfaces.DigerFormlar;
using UserInterfaces.Makine_Ekle;
using UserInterfaces.Musteriler;
using UserInterfaces.Yönetici;

namespace UserInterfaces
{
    public partial class MainForm : Form
    {
        Form Temp;
        Yetkili yetkili;
        public MainForm(Yetkili yetkili_)
        {
            InitializeComponent();
            yetkili = yetkili_;
            DosyaKontrol();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            YetkiliGiris giris = new YetkiliGiris();
            giris.ShowDialog();
            /* if (giris == false)
             {
                 Application.Exit();
             }*/

            if (!YetkiliGiris.kontrol)
            {
                Application.Exit();
            }
            else
            {
                yetkili = YetkiliGiris.yetkili;
                txt_kullanıcı.Text = yetkili.İsimSoyisim;
                YetkiKontrol();
            }
            if (yetkili != null)
            {
                if (yetkili.Sifre == "admin")
                {
                    MessageBox.Show("Şifreniz Varsayılan Olduğu İçin Lütfen Değiştiriniz...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PersonelAyarlari ayar = new PersonelAyarlari(yetkili);
                    ayar.MdiParent = this;
                    AnaPanel.Controls.Add(ayar);
                    ayar.Show();
                }
            }
            else
            {
                Application.Exit();
            }
            SiparisListele();
        }

        private void otomatikYıkamaMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form kontrol = Application.OpenForms["OtomatikYikamaEkle"];
            if (kontrol == null)
            {
                OtomatikYikamaEkle acılan = new OtomatikYikamaEkle(yetkili);
                acılan.MdiParent = this;
                acılan.StartPosition = FormStartPosition.CenterParent;
                AnaPanel.Controls.Add(acılan);
                acılan.Show();
            }
            else
            {
                Temp = Application.OpenForms["OtomatikYikamaEkle"];
                Temp.Focus();
            }
        }

        private void paketlemeMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kontrol = Application.OpenForms["PaketlemeEkle"];
            if (kontrol == null)
            {
                PaketlemeEkle acılan = new PaketlemeEkle(yetkili);
                acılan.MdiParent = this;
                acılan.StartPosition = FormStartPosition.CenterParent;
                AnaPanel.Controls.Add(acılan);
                acılan.Show();
            }
            else
            {
                Temp = Application.OpenForms["PaketlemeEkle"];
                Temp.Focus();
            }
        }

        private void meçMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kontrol = Application.OpenForms["MecMakineEkle"];
            if (kontrol == null)
            {
                MecMakineEkle acılan = new MecMakineEkle(yetkili);
                acılan.MdiParent = this;
                acılan.StartPosition = FormStartPosition.CenterParent;
                AnaPanel.Controls.Add(acılan);
                acılan.Show();
            }
            else
            {
                Temp = Application.OpenForms["MecMakineEkle"];
                Temp.Focus();
            }
        }

        private void tozÇırpmaMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kontrol = Application.OpenForms["TozCırpmaEkle"];
            if (kontrol == null)
            {
                TozCırpmaEkle acılan = new TozCırpmaEkle(yetkili);
                acılan.MdiParent = this;
                acılan.StartPosition = FormStartPosition.CenterParent;
                AnaPanel.Controls.Add(acılan);
                acılan.Show();
            }
            else
            {
                Temp = Application.OpenForms["TozCırpmaEkle"];
                Temp.Focus();
            }
        }

        private void sıkmaMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kontrol = Application.OpenForms["SikmaEkle"];
            if (kontrol == null)
            {
                SikmaEkle acılan = new SikmaEkle(yetkili);
                acılan.MdiParent = this;
                acılan.StartPosition = FormStartPosition.CenterParent;
                AnaPanel.Controls.Add(acılan);
                acılan.Show();
            }
            else
            {
                Temp = Application.OpenForms["SikmaEkle"];
                Temp.Focus();
            }
        }

        private void makineleriGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kontrol = Application.OpenForms["MakineGor"];
            if (kontrol == null)
            {
                MakineGor acılan = new MakineGor(yetkili);
                acılan.MdiParent = this;
                acılan.StartPosition = FormStartPosition.CenterParent;
                AnaPanel.Controls.Add(acılan);
                acılan.Show();
            }
            else
            {
                Temp = Application.OpenForms["MakineGor"];
                Temp.Focus();
            }
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kontrol = Application.OpenForms["MusteriEkle"];
            if (kontrol == null)
            {
                MusteriEkle acılan = new MusteriEkle(yetkili);
                acılan.MdiParent = this;
                acılan.StartPosition = FormStartPosition.CenterParent;
                AnaPanel.Controls.Add(acılan);
                acılan.Show();
            }
            else
            {
                Temp = Application.OpenForms["MusteriEkle"];
                Temp.Focus();
            }
        }

        private void müşterileriGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kontrol = Application.OpenForms["MusteriGor"];
            if (kontrol == null)
            {
                MusteriGor acılan = new MusteriGor(yetkili);
                acılan.MdiParent = this;
                acılan.StartPosition = FormStartPosition.CenterParent;
                AnaPanel.Controls.Add(acılan);
                acılan.Show();
            }
            else
            {
                Temp = Application.OpenForms["MusteriGor"];
                Temp.Focus();
            }
        }

        private void yöneticiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kontrol = Application.OpenForms["YoneticiAyarlari"];
            if (kontrol == null)
            {
                YoneticiAyarlari acılan = new YoneticiAyarlari(yetkili);
                acılan.MdiParent = this;
                acılan.StartPosition = FormStartPosition.CenterParent;
                AnaPanel.Controls.Add(acılan);
                acılan.Show();
            }
            else
            {
                Temp = Application.OpenForms["YoneticiAyarlari"];
                Temp.Focus();
            }
        }

        private void logkayitlariTool_Click(object sender, EventArgs e)
        {
            Form kontrol = Application.OpenForms["LogKayitlari"];
            if (kontrol == null)
            {
                LogKayitlari acılan = new LogKayitlari();
                acılan.MdiParent = this;
                acılan.StartPosition = FormStartPosition.CenterParent;
                AnaPanel.Controls.Add(acılan);
                acılan.Show();
            }
            else
            {
                Temp = Application.OpenForms["LogKayitlari"];
                Temp.Focus();
            }
        }

        private void profilAyarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kontrol = Application.OpenForms["PersonelAyarlari"];
            if (kontrol == null)
            {
                PersonelAyarlari acılan = new PersonelAyarlari(yetkili);
                acılan.MdiParent = this;
                acılan.StartPosition = FormStartPosition.CenterParent;
                AnaPanel.Controls.Add(acılan);
                acılan.Show();
            }
            else
            {
                Temp = Application.OpenForms["PersonelAyarlari"];
                Temp.Focus();
            }
        }

        private void sevkEdilenMakinelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kontrol = Application.OpenForms["SevkMakineler"];
            if (kontrol == null)
            {
                SevkMakineler acılan = new SevkMakineler(yetkili);
                acılan.MdiParent = this;
                acılan.StartPosition = FormStartPosition.CenterParent;
                AnaPanel.Controls.Add(acılan);
                acılan.Show();
            }
            else
            {
                Temp = Application.OpenForms["SevkMakineler"];
                Temp.Focus();
            }
        }

        private void stokMakinelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kontrol = Application.OpenForms["StokMakineler"];
            if (kontrol == null)
            {
                StokMakineler acılan = new StokMakineler(yetkili);
                acılan.MdiParent = this;
                acılan.StartPosition = FormStartPosition.CenterParent;
                AnaPanel.Controls.Add(acılan);
                acılan.Show();
            }
            else
            {
                Temp = Application.OpenForms["StokMakineler"];
                Temp.Focus();
            }
        }

        private void YetkiKontrol()
        {
            if (yetkili.YoneticiYetki == false)
            {
                logkayitlariTool.Visible = false;
                yöneticiTool.Visible = false;
            }
            if (yetkili.Makineekle == false)
            {
                makineGirdisiYapToolStripMenuItem.Visible = false;
            }
            if (yetkili.MakineGor == false)
            {
                makineleriGörToolStripMenuItem.Visible = false;
            }
            if (yetkili.Musteriekle == false)
            {
                müşteriEkleToolStripMenuItem.Visible = false;
            }
            if (yetkili.MusteriGor == false)
            {
                müşterileriGörToolStripMenuItem.Visible = false;
            }
        }

        static string path = @"C:\Siparişler";

        private void DosyaKontrol()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                File.SetAttributes(path, FileAttributes.Hidden);
            }
            File.SetAttributes(path, FileAttributes.Hidden);
        }

        private void SiparisListele()
        {
            FileInfo[] dosyalar;
            DirectoryInfo di = new DirectoryInfo(path);
            dosyalar = di.GetFiles("*.txt");

            foreach (FileInfo file in dosyalar)
            {
                string FileName = file.Name;
                FileName = FileName.Substring(0, FileName.Length-4);
                lst_siparis.Items.Add(FileName);
            }
        }

        private void lst_siparis_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                SiparisGir Siparis = new SiparisGir(lst_siparis.SelectedItem.ToString());
                Siparis.MdiParent = this;
                Siparis.Show();
            }
            catch (Exception)
            {
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SiparisListele();
        }
    }
}
