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
    public partial class PersonelAyarlari : Form
    {
        BLLYetkiliOperation yetkiliOperation;
        Yetkili yetkili;
        public PersonelAyarlari(Yetkili yetkili_)
        {
            InitializeComponent();
            yetkiliOperation = new BLLYetkiliOperation();
            yetkili = yetkili_;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_eskiSifre.UseSystemPasswordChar = false;
            txt_yeniSifre.UseSystemPasswordChar = false;
        }

        private void PersonelAyarlari_Load(object sender, EventArgs e)
        {
            txt_isimSoy.Text = yetkili.İsimSoyisim;
            txt_isimSoy.Enabled = false;
            txt_eskiSifre.UseSystemPasswordChar = true;
            txt_yeniSifre.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_yeniSifre.Text != yetkili.Sifre)
            {
                if (txt_eskiSifre.Text == txt_yeniSifre.Text)
                {
                    string Log = $"{yetkili.İsimSoyisim} Şifresini Değiştirdi.";
                    yetkili.KullaniciAdi = txt_kullaniciadi.Text;
                    yetkili.Sifre = txt_yeniSifre.Text;
                    int returnValue = yetkiliOperation.Guncelle(yetkili.ID, yetkili, yetkili,Log);
                    if (returnValue > 0)
                    {
                        MessageBox.Show("İşlem Başarıyla Gerçekleşti...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("İşlem Sırasında Hata Oldu...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler Birbiriyle Aynı Değil", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Eski Şifrenizden Farklı Bir Şifre Giriniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
