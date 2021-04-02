using BusinessLogicLayer.Concrete;
using Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaces.Yönetici
{
    public partial class PersonelEkle : Form
    {
        Yetkili yetkili;
        BLLYetkiliOperation yetkiliOperation;
        public PersonelEkle(Yetkili yetkili_)
        {
            InitializeComponent();
            yetkiliOperation = new BLLYetkiliOperation();
            yetkili = yetkili_;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int returnValue = yetkiliOperation.Kaydet(new Entites.Yetkili()
            {
                ID = Guid.NewGuid(),
                SiparisEkle = check_siparis.Checked,
                MusteriGor = check_musteriGor.Checked,
                Musteriekle = check_musteriEkle.Checked,
                MakineGor = check_makineGor.Checked,
                Makineekle = checkMakEkle.Checked,
                KullaniciAdi = txt_kAdi.Text,
                Sifre = "admin",
                YoneticiYetki = check_yönetici.Checked,
                İsimSoyisim = txt_ad.Text + " " + txt_soyad.Text

            }, yetkili);

            if (returnValue > 0)
            {
                MessageBox.Show("Personel Başarıyla Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Personel Eklenirken Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
