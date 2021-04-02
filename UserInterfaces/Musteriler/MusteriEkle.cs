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

namespace UserInterfaces.Musteriler
{
    public partial class MusteriEkle : Form
    {
        Yetkili yetkili;
        BLLMusteriOperation musteriOperation;
        Musteri musteri;
        string tutulan;
        int returnValue;
        public MusteriEkle(Yetkili _yetkili)
        {
            InitializeComponent();
            yetkili = _yetkili;
            musteriOperation = new BLLMusteriOperation();
            this.Text = "MÜŞTERİ EKLE";
        }
        public MusteriEkle(Yetkili _yetkili,Musteri Temp)
        {
            InitializeComponent();
            yetkili = _yetkili;
            musteriOperation = new BLLMusteriOperation();
            musteri = Temp;
            tutulan = Temp.MusteriNo;
            this.Text = "MÜŞTERİ GÜNCELLE";
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (musteri == null)
            {
                musteri = new Musteri();
                musteri.ID = Guid.NewGuid();
                musteri.MusteriNo = txt_musteriNo.Text;
                musteri.MusteriAdı = txt_musteri.Text;
                musteri.Ulke = txt_Ulke.Text.ToUpper();
                musteri.Il = txt_ıl.Text.ToUpper();
                musteri.TelefonNo = txt_tel.Text;
                musteri.Adres = txt_adres.Text;
                bool kontrol = musteriOperation.kontrol(musteri);
                if (kontrol)
                {
                    returnValue = musteriOperation.Kaydet(musteri, yetkili); ;

                    if (returnValue > 0)
                    {
                        label5.Text = $"{musteri.MusteriAdı} Eklendi";
                        foreach (Control item in this.Controls)
                        {
                            if (item is TextBox)
                            {
                                TextBox txt = (TextBox)item;
                                txt.Text = "";
                            }
                            else if(item is RichTextBox)
                            {
                                RichTextBox txt = (RichTextBox)item;
                                txt.Text = "";
                            }
                        }
                        musteri = null;
                        txt_ıl.Text = "";
                        txt_ıl.Enabled = false;
                    }
                    else
                    {
                        label5.Text = $"Müşteri Eklenmeye Çalışırken Bir Hata Oldu";
                    }
                }
                else
                {
                    MessageBox.Show("Girmiş Olduğunuz Müşteri No Zaten verilmiş Lütfen Tekrar Deneyiniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    musteri = null;
                }
                
            }
            else
            {
                musteri.Adres = txt_adres.Text;
                musteri.Ulke = txt_Ulke.Text;
                musteri.Il = txt_ıl.Text;
                musteri.MusteriAdı = txt_musteri.Text;
                musteri.MusteriNo = txt_musteriNo.Text;
                musteri.TelefonNo = txt_tel.Text;

                 returnValue = musteriOperation.Guncelle(tutulan,musteri, yetkili); ;

                if (returnValue > 0)
                {
                    this.Close();
                }
                else
                {
                    label5.Text = $"Müşteri Güncellenmeye Çalışırken Bir Hata Oldu";
                }
            }
           
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            if (musteri != null)
            {
                txt_adres.Text = musteri.Adres;
                txt_Ulke.Text = musteri.Ulke;
                txt_ıl.Text = musteri.Il;
                txt_musteri.Text = musteri.MusteriAdı;
                txt_musteriNo.Text = musteri.MusteriNo;
                txt_tel.Text = musteri.TelefonNo;
            }
        }

        private void txt_Ulke_TextChanged(object sender, EventArgs e)
        {
            if (txt_Ulke.Text == "türkiye" || txt_Ulke.Text == "TÜRKİYE" || txt_Ulke.Text == "TURKIYE" || txt_Ulke.Text == "turkıye" || txt_Ulke.Text == "Türkiye" || txt_Ulke.Text == "turkıye")
            {
                txt_ıl.Enabled = true;
            }
        }

        private void txt_ıl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var deger = (musteriOperation.Get_il(txt_ıl.Text).Max(I => I.MusteriNo));
                txt_musteriNo.Text = (int.Parse(deger) + 1).ToString();
            }
            catch (Exception)
            {
                txt_musteriNo.Text = "0";
            }
           
        }
    }
}
