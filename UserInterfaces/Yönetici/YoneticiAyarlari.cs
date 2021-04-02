using BusinessLogicLayer.Concrete;
using DatabaseLogicLayer.Concrete;
using Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaces.Yönetici
{
    public partial class YoneticiAyarlari : Form
    {
        Yetkili yetkili;
        BLLYetkiliOperation yetkiliOperation;
        Yetkili Temp;
        public YoneticiAyarlari(Yetkili yetkili_)
        {
            InitializeComponent();
            yetkili = yetkili_;
            yetkiliOperation = new BLLYetkiliOperation();
        }

        private void YoneticiAyarlari_Load(object sender, EventArgs e)
        {
            dgvDoldur();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = Guid.Parse((dataGridView1.CurrentRow.Cells[0].Value).ToString());
            Temp = yetkiliOperation.Find(row);
            lbl_uyari.Text = Temp.İsimSoyisim + "\n   seçildi";
        }

        private void dgvDoldur()
        {
            dataGridView1.DataSource = yetkiliOperation.GetAll();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.AutoResizeColumns();
        }

        private void btn_personelEkle_Click(object sender, EventArgs e)
        {
            Form kontrol = Application.OpenForms["PersonelEkle"];
            if (kontrol == null)
            {
                PersonelEkle acılan = new PersonelEkle(yetkili);
                acılan.MdiParent = this.MdiParent;
                acılan.StartPosition = FormStartPosition.CenterParent;
                acılan.Show();
            }
            else
            {
                kontrol = Application.OpenForms["PersonelEkle"];
                kontrol.Focus();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (Temp != null)
            {
                if (Temp.ID != Guid.Parse("81B26A57-12C5-464D-87DC-287E50F10750"))
                {
                    string Log = $"{Temp.İsimSoyisim} isimli Personelin {yetkili.İsimSoyisim} Tarafından Müşteri Görme Yetkisi değiştirildi.";
                    Temp.MusteriGor = checkMustGor.Checked;
                    yetkiliOperation.Guncelle(Temp.ID, Temp, yetkili, Log);
                    lbl_uyari.Text = "İşlem Başarılı!";
                    dgvDoldur();
                    checkMustGor.Checked = false;
                }
                else
                {
                    lbl_uyari.Text = "Admin Yetkisi \n   Alınamaz!";
                }
            }
            else
            {
                lbl_uyari.Text = "Personel Seçiniz!";
            }
        }

        private void checkYonetici_CheckedChanged(object sender, EventArgs e)
        {
            if (Temp != null)
            {
                if (Temp.ID != Guid.Parse("81B26A57-12C5-464D-87DC-287E50F10750"))
                {
                     string Log = $"{Temp.İsimSoyisim} isimli Personelin {yetkili.İsimSoyisim} Tarafından Yönetici Yetkisi Değiştirildi.";
                     Temp.YoneticiYetki = checkYonetici.Checked;
                     yetkiliOperation.Guncelle(Temp.ID, Temp, yetkili, Log);
                     lbl_uyari.Text = "İşlem Başarılı!";
                     dgvDoldur(); 
                     checkYonetici.Checked = false;
                }
                else
                {
                    lbl_uyari.Text = "Admin Yetkisi \n   Alınamaz!";
                }
            }
            else
            {
                lbl_uyari.Text = "Personel Seçiniz!";
            }
        }

        private void checkMAkGor_CheckedChanged(object sender, EventArgs e)
        {
            if (Temp != null)
            {
                if (Temp.ID != Guid.Parse("81B26A57-12C5-464D-87DC-287E50F10750"))
                {
                string Log = $"{Temp.İsimSoyisim} isimli Personelin {yetkili.İsimSoyisim} Tarafından Makine Görme Yetkisi Değiştirildi.";
                Temp.MakineGor = checkMAkGor.Checked;
                yetkiliOperation.Guncelle(Temp.ID, Temp, yetkili, Log);
                lbl_uyari.Text = "İşlem Başarılı!";
                dgvDoldur();
                checkMAkGor.Checked = false;
                }
                else
                {
                    lbl_uyari.Text = "Admin Yetkisi \n   Alınamaz!";
                }
            }
            else
            {
                lbl_uyari.Text = "Personel Seçiniz!";
            }
        }

        private void checkMAkEkle_CheckedChanged(object sender, EventArgs e)
        {
            if (Temp != null)
            {
                if (Temp.ID != Guid.Parse("81B26A57-12C5-464D-87DC-287E50F10750"))
                {

                    string Log = $"{Temp.İsimSoyisim} isimli Personelin {yetkili.İsimSoyisim} Tarafından Makine Ekleme Yetkisi Değiştirildi.";
                    Temp.Makineekle = checkMAkEkle.Checked;
                    yetkiliOperation.Guncelle(Temp.ID, Temp, yetkili, Log);
                    lbl_uyari.Text = "İşlem Başarılı!";
                    dgvDoldur();
                    checkMAkEkle.Checked = false;
                }
                else
                {
                    lbl_uyari.Text = "Admin Yetkisi \n   Alınamaz!";
                }
            }
            else
            {
                lbl_uyari.Text = "Personel Seçiniz!";
            }
        }

        private void checkMustEkle_CheckedChanged(object sender, EventArgs e)
        {
            if (Temp != null)
            {
                if (Temp.ID != Guid.Parse("81B26A57-12C5-464D-87DC-287E50F10750"))
                {
                     string Log = $"{Temp.İsimSoyisim} isimli Personelin {yetkili.İsimSoyisim} Tarafından Makine Ekleme Yetkisi Değiştirildi.";
                     Temp.Musteriekle = checkMustEkle.Checked;
                     yetkiliOperation.Guncelle(Temp.ID, Temp, yetkili, Log);
                     lbl_uyari.Text = "İşlem Başarılı!";
                     dgvDoldur();
                    checkMustEkle.Checked = false;
                 }
                else
                {
                    lbl_uyari.Text = "Admin Yetkisi \n   Alınamaz!";
                }
            }
            else
            {
                lbl_uyari.Text = "Personel Seçiniz!";
            }
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dgvDoldur();
            lbl_uyari.Text = "";
        }

        private void check_siparis_CheckedChanged(object sender, EventArgs e)
        {
            if (Temp != null)
            {
                if (Temp.ID != Guid.Parse("81B26A57-12C5-464D-87DC-287E50F10750"))
                {
                    string Log = $"{Temp.İsimSoyisim} isimli Personelin {yetkili.İsimSoyisim} Tarafından Sipariş Ekleme Yetkisi Değiştirildi.";
                    Temp.SiparisEkle = check_siparis.Checked;
                    yetkiliOperation.Guncelle(Temp.ID, Temp, yetkili, Log);
                    lbl_uyari.Text = "İşlem Başarılı!";
                    dgvDoldur();
                    check_siparis.Checked = false;
                }
                else
                {
                    lbl_uyari.Text = "Admin Yetkisi \n   Alınamaz!";
                }
            }
            else
            {
                lbl_uyari.Text = "Personel Seçiniz!";
            }
        }

        private void btn_personelSİL_Click(object sender, EventArgs e)
        {
            if (Temp.ID != Guid.Parse("81B26A57-12C5-464D-87DC-287E50F10750"))
            {
                int returnValue = yetkiliOperation.Sil(Temp.ID, yetkili);
                if (returnValue > 0)
                {
                    lbl_uyari.Text = "İşlem Başarılı!";
                }
            }
            else
            {
                lbl_uyari.Text = "Admin Silinemez!";
            }
        }
    }
}