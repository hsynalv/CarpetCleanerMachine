using BusinessLogicLayer.Concrete;
using Entites;
using Entites.Machine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaces.Makine_Ekle
{
    public partial class OtomatikYikamaEkle : Form
    {
        BLLOtomatikYikamaOperation otomatikYikamaOperation;
        BLLMusteriOperation musteriOperation;
        OtomatikHaliYikama Temp;
        Musteri musteri;
        Yetkili yetkili_;
        public OtomatikYikamaEkle(Yetkili yetkili, Musteri _musteri = null)
        {
            InitializeComponent();
            otomatikYikamaOperation = new BLLOtomatikYikamaOperation();
            musteriOperation = new BLLMusteriOperation();
            yetkili_ = yetkili;
            musteri = _musteri;
            this.Text = "OTOMATİK YIKAMA EKLE";
            btn_sil.Visible = false;

        }
        public OtomatikYikamaEkle(Yetkili yetkili, OtomatikHaliYikama makine)
        {
            InitializeComponent();
            Temp = makine;
            otomatikYikamaOperation = new BLLOtomatikYikamaOperation();
            musteriOperation = new BLLMusteriOperation();
            yetkili_ = yetkili;
            this.Text = "OTOMATİK YIKAMA GÜNCELLE";


        }

        #region tempDoldur
        private void TempDoldur()
        {
            Temp.Il = cmb_ıl.Text;
            Temp.Ulke = cmb_ulke.Text;
            Temp.Te_MusteriAdi = cmb_musteriAdi.Text;
            Temp.Te_MusteriNo = txt_müsteriNo.Text;
            Temp.Acıklama = txt_acıklama.Text;
            Temp.Te_IsEmriNo = txt_isEmri.Text;
            Temp.Te_SiparişNo = txt_siparis.Text;
            Temp.stok_mu = check_stok.Checked;
            try
            {
                Temp.Te_SiparisTarihi = Convert.ToDateTime(txt_siparisTarih.Text);
                Temp.Te_TerminTarihi = Convert.ToDateTime(txt_terminTarih.Text);
                Temp.Te_UretimNo = otomatikYikamaOperation.GetAll().Max(I => I.Te_UretimNo) + 1;
            }
            catch (System.InvalidOperationException)
            {
                Temp.Te_UretimNo = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Geçerli Bir Tarih Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Temp.Oz_ŞaseTipi = cmb_Şase.Text;
            Temp.Oz_HaliGiris = cmb_HaliGirisOlcü.Text;
            Temp.Oz_UniteSayisi = cmb_unitesayisi.Text;
            Temp.Oz_EkranBoyutu = cmb_ekranBoyut.Text;
            Temp.Oz_EtiketDili = cmb_etiketDili.Text;
            Temp.Oz_KacParcaGidecek = cmb_kacParca.Text;
            Temp.Oz_FircaSayisi = cmb_fırcaSayisi.Text;
            Temp.Oz_UstRulo = cmb_ustRulo.Text;
            Temp.Oz_AltRulo = cmb_altRulo.Text;
            Temp.Oz_Citileme = cmb_citileme.Text;
            Temp.Oz_Gelberi = cmb_gelberi.Text;
            Temp.Oz_HaliKatlamaSistemi = cmb_haliKatlama.Text;
            Temp.Sip_PlastikMalzeme = cmb_PlastikMalzeme.Text;
            Temp.Sip_RulmanGrubu = cmb_RulmanGrup.Text;
            Temp.Sip_Boru_ProfilGrubu = cmb_boruGrup.Text;
            Temp.Sip_FircaGrubu = cmb_fircaGrup.Text;
            Temp.Sip_MotorGrubu = cmb_motorGrup.Text;
            Temp.Sip_HirdavatGrubu = cmb_hırdavatGrup.Text;
            Temp.Sip_ElektrikSiparisi = cmb_elektrikSiparis.Text;
            Temp.Sip_ButonEtiketi = cmb_butonEtiket.Text;
            Temp.Sip_CE_Etiketi = cmb_CE.Text;
            Temp.Sip_Digerleri = cmb_digerleri.Text;
            Temp.Arge_LazerKesim = cmb_lazer.Text;
            Temp.Arge_Bukum = cmb_bukum.Text;
            Temp.Arge_Boru_ProfilKaynak = cmb_BoruProfilKaynak.Text;
            Temp.Arge_BoruDisTorna = cmb_BoruDısTorna.Text;
            Temp.Arge_icTornalikMalzeme = cmb_IcTorna.Text;
            Temp.Arge_Kaynakİslem = cmb_kaynakIslem.Text;
            Temp.Arge_DisKaplamaKaynak = cmb_DısKaplamaKaynak.Text;
            Temp.Arge_DisKaplamaBoya = cmb_DısKaplamaBoya.Text;
            Temp.Arge_Sase_UniteGalvaniz = SaseUniteGalvaniz.Text;
            Temp.Arge_BoruGalvaniz = cmb_boruGalvaniz.Text;
            Temp.Arge_SaseKaldirmasi = cmb_SaseKaldırma.Text;
            Temp.Arge_SaseMontaj = cmb_SaseMontaj.Text;
            Temp.Arge_UniteMontaj = cmb_uniteMontaj.Text;
            Temp.Arge_UniteSaseMontaj = cmb_uniteŞaseMontaj.Text;
            Temp.Arge_ElektrikPanoDösenmesi = cmb_ElektrikPanoDöseme.Text;
            Temp.Arge_PanoSaseMontaj = cmb_panoSaseMontaj.Text;
            Temp.Arge_Kablolama = cmb_kablolama.Text;
            Temp.Arge_TopMontaj = cmb_topMontaj.Text;
            Temp.Arge_BantOlcu = cmb_bantOlcu.Text;
            Temp.Arge_BantMontaj = cmb_bantMontaj.Text;
            Temp.Arge_OtomasyonYazilim = cmb_OtomasyonYazılım.Text;
            Temp.Dig_SevkDurum = cmb_sevk.Text;
            Temp.Dig_TestAsamasi = cmb_test.Text;
        }

        #endregion


        private void OtomatikYikamaEkle_Load(object sender, EventArgs e)
        {
            txt_üretimNo.Enabled = false;
            if (Temp != null)
            {
                doldur();
                cmb_ulke.Enabled = true;
                cmb_ıl.Enabled = true;

            }
            foreach (Musteri item in musteriOperation.GetAll())
            {
               if (!cmb_ulke.Items.Contains(item.Ulke))
               {
                     cmb_ulke.Items.Add(item.Ulke);
               }
            }
            

        }


        private void TxtBosalt()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Text = "";
                }
                else if (item is ComboBox)
                {
                    ComboBox cmb = (ComboBox)item;
                    cmb.Text = "";
                }
            }
        }

        private void doldur()
        {
            #region Doldur
            cmb_ulke.Text = Temp.Ulke;
            cmb_ıl.Text = Temp.Il;
            txt_siparis.Text = Temp.Te_SiparişNo;
            txt_acıklama.Text = Temp.Acıklama;
            txt_isEmri.Text = Temp.Te_IsEmriNo;
            cmb_musteriAdi.Text = Temp.Te_MusteriAdi;
            txt_müsteriNo.Text = Temp.Te_MusteriNo;
            txt_üretimNo.Text = Temp.Te_UretimNo.ToString();
            txt_siparisTarih.Text = Temp.Te_SiparisTarihi.ToString();
            txt_terminTarih.Text = Temp.Te_TerminTarihi.ToString();
            cmb_Şase.Text = Temp.Oz_ŞaseTipi;
            cmb_HaliGirisOlcü.Text = Temp.Oz_HaliGiris;
            cmb_unitesayisi.Text = Temp.Oz_UniteSayisi;
            cmb_ekranBoyut.Text = Temp.Oz_EkranBoyutu;
            cmb_etiketDili.Text = Temp.Oz_EtiketDili;
            cmb_kacParca.Text = Temp.Oz_KacParcaGidecek;
            cmb_fırcaSayisi.Text = Temp.Oz_FircaSayisi;
            cmb_ustRulo.Text = Temp.Oz_UstRulo;
            cmb_altRulo.Text = Temp.Oz_AltRulo;
            cmb_citileme.Text = Temp.Oz_Citileme;
            cmb_gelberi.Text = Temp.Oz_Gelberi;
            cmb_haliKatlama.Text = Temp.Oz_HaliKatlamaSistemi;
            cmb_PlastikMalzeme.Text = Temp.Sip_PlastikMalzeme;
            cmb_RulmanGrup.Text = Temp.Sip_RulmanGrubu;
            cmb_boruGrup.Text = Temp.Sip_Boru_ProfilGrubu;
            cmb_fircaGrup.Text = Temp.Sip_FircaGrubu;
            cmb_motorGrup.Text = Temp.Sip_MotorGrubu;
            cmb_hırdavatGrup.Text = Temp.Sip_HirdavatGrubu;
            cmb_elektrikSiparis.Text = Temp.Sip_ElektrikSiparisi;
            cmb_butonEtiket.Text = Temp.Sip_ButonEtiketi;
            cmb_CE.Text = Temp.Sip_CE_Etiketi;
            cmb_digerleri.Text = Temp.Sip_Digerleri;
            cmb_lazer.Text = Temp.Arge_LazerKesim;
            cmb_bukum.Text = Temp.Arge_Bukum;
            cmb_BoruProfilKaynak.Text = Temp.Arge_Boru_ProfilKaynak;
            cmb_BoruDısTorna.Text = Temp.Arge_BoruDisTorna;
            cmb_IcTorna.Text = Temp.Arge_icTornalikMalzeme;
            cmb_kaynakIslem.Text = Temp.Arge_Kaynakİslem;
            cmb_DısKaplamaKaynak.Text = Temp.Arge_DisKaplamaKaynak;
            cmb_DısKaplamaBoya.Text = Temp.Arge_DisKaplamaBoya;
            SaseUniteGalvaniz.Text = Temp.Arge_Sase_UniteGalvaniz;
            cmb_boruGalvaniz.Text = Temp.Arge_BoruGalvaniz;
            cmb_SaseKaldırma.Text = Temp.Arge_SaseKaldirmasi;
            cmb_SaseMontaj.Text = Temp.Arge_SaseMontaj;
            cmb_uniteMontaj.Text = Temp.Arge_UniteMontaj;
            cmb_uniteŞaseMontaj.Text = Temp.Arge_UniteSaseMontaj;
            cmb_ElektrikPanoDöseme.Text = Temp.Arge_ElektrikPanoDösenmesi;
            cmb_panoSaseMontaj.Text = Temp.Arge_PanoSaseMontaj;
            cmb_OtomasyonYazılım.Text = Temp.Arge_OtomasyonYazilim;
            cmb_kablolama.Text = Temp.Arge_Kablolama;
            cmb_topMontaj.Text = Temp.Arge_TopMontaj;
            cmb_bantOlcu.Text = Temp.Arge_BantOlcu;
            cmb_bantMontaj.Text = Temp.Arge_BantMontaj;
            cmb_sevk.Text = Temp.Dig_SevkDurum;
            cmb_test.Text = Temp.Dig_TestAsamasi;
            #endregion
            txt_müsteriNo.Enabled = false;
            cmb_ıl.Enabled = false;
            cmb_ulke.Enabled = false;
            txt_üretimNo.Enabled = false;
        }

        private void byn_kaydet_Click_1(object sender, EventArgs e)
        {
            int returnValue = 0;
            if (Temp != null)
            {
                TempDoldur();
                returnValue = otomatikYikamaOperation.Guncelle(Temp.ID, Temp, yetkili_);
                if (returnValue > 0)
                {
                    MessageBox.Show($"{Temp.Te_MusteriAdi}' ye ait Otomatik Yıkama Makinesi Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Güncelleme Sırasında Hata Oluştu Tekrar Deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Temp = new OtomatikHaliYikama();
                Temp.ID = Guid.NewGuid();
                Temp.MusteriID = musteri.ID;
                TempDoldur();
                returnValue = otomatikYikamaOperation.Kaydet(Temp, yetkili_);
                if (returnValue > 0)
                {
                    MessageBox.Show($"{Temp.Te_MusteriAdi}' Firma/Kişisine ait '{Temp.Te_UretimNo}' 'Üretim Numaralı Otomatik Yıkama Makinesi Başarıyla Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information); TxtBosalt();
                }
                else
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int returnvalue = otomatikYikamaOperation.Sil(Temp.ID, yetkili_);
            if (returnvalue > 0)
            {
                lbl_uyari.Text = $"{Temp.Te_MusteriAdi} Ait Makine Silindi. ";
                this.Close();
            }
        }

        private void cmb_ulke_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_ulke.Text == "TÜRKİYE")
            {
                foreach (Musteri item in musteriOperation.Get_Ulke("TÜRKİYE"))
                {
                    if (!cmb_ıl.Items.Contains(item.Il))
                    {
                        cmb_ıl.Items.Add(item.Il);
                    }
                }
            }
            else
            {
                foreach (Musteri item in musteriOperation.Get_Ulke(cmb_ulke.Text))
                {
                    if (!cmb_musteriAdi.Items.Contains(item.MusteriAdı))
                    {
                        cmb_musteriAdi.Items.Add(item.MusteriAdı);
                    }
                }

            }
        }

        private void cmb_ıl_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            foreach (Musteri item in musteriOperation.Get_il(cmb_ıl.Text))
            {
                if (!cmb_musteriAdi.Items.Contains(item.MusteriAdı))
                {
                    cmb_musteriAdi.Items.Add(item.MusteriAdı);
                }
            }
        }

        private void cmb_musteriAdi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                musteri = musteriOperation.FindMusteriAdi(cmb_musteriAdi.Text);
                cmb_ulke.Text = musteri.Ulke;
                cmb_ıl.Text = musteri.Il;
                txt_müsteriNo.Text = musteri.MusteriNo;
                cmb_ıl.Enabled = false;
                cmb_ulke.Enabled = false;
                txt_müsteriNo.Enabled = false;
                cmb_musteriAdi.Enabled = false;
                cmb_musteriAdi.Text = musteri.MusteriAdı;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
        }
    }
}
