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
    public partial class PaketlemeEkle : Form
    {
        BLLPaketlemeOperation paketlemeOperation;
        PaketlemeMakine Temp;
        BLLMusteriOperation musteriOperation;
        Musteri musteri;
        Yetkili yetkili;

        public PaketlemeEkle(Yetkili yetkili_, Musteri _musteri = null)
        {
            InitializeComponent();
            paketlemeOperation = new BLLPaketlemeOperation();
            musteriOperation = new BLLMusteriOperation();
            yetkili = yetkili_;
            musteri = _musteri;
            this.Text = "PAKETLEME MAKİNE EKLE";
            btn_sil.Visible = false;
        }

        public PaketlemeEkle(Yetkili yetkili_, PaketlemeMakine makine)
        {
            InitializeComponent();
            Temp = makine;
            paketlemeOperation = new BLLPaketlemeOperation();
            musteriOperation = new BLLMusteriOperation();
            yetkili = yetkili_;
            this.Text = "PAKETLEME MAKİNE GÜNCELLE";


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

        #region Temp Doldur
        private void TempDoldur()
        {
            Temp.Ulke = cmb_ulke.Text;
            Temp.Il = cmb_ıl.Text;
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
                Temp.Te_UretimNo = paketlemeOperation.GetAll().Max(I => I.Te_UretimNo) + 1;
            }
            catch (System.InvalidOperationException)
            {
                Temp.Te_UretimNo = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Geçerli Bir Tarih Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Temp.Oz_SaseTipi = cmb_Şase.Text;
            Temp.Oz_HaliGirisOlcu = cmb_haliGiris.Text;
            Temp.Oz_FanSayisi = cmb_fanSayisi.Text;
            Temp.Oz_Parfumleme = cmb_fanSayisi.Text;
            Temp.Sip_PlastikMalzeme = cmb_PlastikMalzeme.Text;
            Temp.Sip_RulmanGrup = cmb_RulmanGrup.Text;
            Temp.Sip_Boru_ProfilGrup = cmb_boruGrup.Text;
            Temp.Sip_FircaGrup = cmb_fircaGrup.Text;
            Temp.Sip_MotorGrup = cmb_motorGrup.Text;
            Temp.Sip_HirdavatGrup = cmb_hırdavatGrup.Text;
            Temp.Sip_ElektrikSiparis = cmb_elektrikSiparis.Text;
            Temp.Sip_ButonEtiketi = cmb_butonEtiket.Text;
            Temp.Sip_Ce_Etiketi = cmb_CE.Text;
            Temp.Arge_LazerKesim = cmb_lazer.Text;
            Temp.Arge_Bukum = cmb_bukum.Text;
            Temp.Arge_BoruProfilKaynak = cmb_BoruProfilKaynak.Text;
            Temp.Arge_BoruDisTorna = cmb_BoruDısTorna.Text;
            Temp.Arge_FanTorna_Kama_Balans = FanTornaKamaBalans.Text;
            Temp.Arge_IcTornaMalzeme = cmb_IcTorna.Text;
            Temp.Arge_KaynakIslem = cmb_kaynakIslem.Text;
            Temp.Arge_DisKaplamaKaynak = cmb_DısKaplamaKaynak.Text;
            Temp.Arge_DisKaplamaBoya = cmb_DısKaplamaBoya.Text;
            Temp.Arge_BaskiTopuGalvaniz = cmb_baskiTopu.Text;
            Temp.Arge_BoruGalvaniz = cmb_boruGalvaniz.Text;
            Temp.Arge_ŞaseKaldirma = cmb_SaseKaldırma.Text;
            Temp.Arge_ŞaseMontaj = cmb_SaseMontaj.Text;
            Temp.Arge_UniteSaseMontaj = cmb_uniteSaseMontaj.Text;
            Temp.Arge_ElektrikPanoDosenme = cmb_ElektrikPanoDöseme.Text;
            Temp.Arge_PanoSaseMontaj = cmb_panoSaseMontaj.Text;
            Temp.Arge_Kablolama = cmb_kablolama.Text;
            Temp.Arge_TopMontaj = cmb_topMontaj.Text;
            Temp.Arge_BantOlcu = cmb_bantOlcu.Text;
            Temp.Arge_BantMontaj = cmb_bantMontaj.Text;
            Temp.Arge_KumandaPanoAtama = cmb_KumandaPanoAtama.Text;
            Temp.Dig_SevkDurum = cmb_sevk.Text;
            Temp.Dig_TestAsaması = cmb_test.Text;

        }
        #endregion
        private void PaketlemeEkle_Load(object sender, EventArgs e)
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

        private void doldur()
        {
            #region doldur
            cmb_musteriAdi.Text = Temp.Te_MusteriAdi;
            cmb_ıl.Text = Temp.Il;
            cmb_ulke.Text = Temp.Ulke;
            txt_siparis.Text = Temp.Te_SiparişNo;
            txt_isEmri.Text = Temp.Te_IsEmriNo;
            txt_acıklama.Text = Temp.Acıklama;
            cmb_musteriAdi.Text = Temp.Te_MusteriAdi;
            txt_müsteriNo.Text = Temp.Te_MusteriNo;
            txt_üretimNo.Text = Temp.Te_UretimNo.ToString();
            check_stok.Checked = Temp.stok_mu;
            txt_siparisTarih.Text = Temp.Te_SiparisTarihi.ToString();
            txt_terminTarih.Text = Temp.Te_TerminTarihi.ToString();
            cmb_Şase.Text = Temp.Oz_SaseTipi;
            cmb_haliGiris.Text = Temp.Oz_HaliGirisOlcu;
            cmb_fanSayisi.Text = Temp.Oz_FanSayisi;
            cmb_parfumleme.Text = Temp.Oz_Parfumleme;
            cmb_PlastikMalzeme.Text = Temp.Sip_PlastikMalzeme;
            cmb_RulmanGrup.Text = Temp.Sip_RulmanGrup;
            cmb_boruGrup.Text = Temp.Sip_Boru_ProfilGrup;
            cmb_fircaGrup.Text = Temp.Sip_FircaGrup;
            cmb_motorGrup.Text = Temp.Sip_MotorGrup;
            cmb_hırdavatGrup.Text = Temp.Sip_HirdavatGrup;
            cmb_elektrikSiparis.Text = Temp.Sip_ElektrikSiparis;
            cmb_butonEtiket.Text = Temp.Sip_ButonEtiketi;
            cmb_CE.Text = Temp.Sip_Ce_Etiketi;
            cmb_lazer.Text = Temp.Arge_LazerKesim;
            cmb_bukum.Text = Temp.Arge_Bukum;
            cmb_BoruProfilKaynak.Text = Temp.Arge_BoruProfilKaynak;
            cmb_BoruDısTorna.Text = Temp.Arge_BoruDisTorna;
            FanTornaKamaBalans.Text = Temp.Arge_FanTorna_Kama_Balans;
            cmb_IcTorna.Text = Temp.Arge_IcTornaMalzeme;
            cmb_kaynakIslem.Text = Temp.Arge_KaynakIslem;
            cmb_DısKaplamaKaynak.Text = Temp.Arge_DisKaplamaKaynak;
            cmb_DısKaplamaBoya.Text = Temp.Arge_DisKaplamaBoya;
            cmb_baskiTopu.Text = Temp.Arge_BaskiTopuGalvaniz;
            cmb_boruGalvaniz.Text = Temp.Arge_BoruGalvaniz;
            cmb_SaseKaldırma.Text = Temp.Arge_ŞaseKaldirma;
            cmb_SaseMontaj.Text = Temp.Arge_ŞaseMontaj;
            cmb_uniteSaseMontaj.Text = Temp.Arge_UniteSaseMontaj;
            cmb_ElektrikPanoDöseme.Text = Temp.Arge_ElektrikPanoDosenme;
            cmb_panoSaseMontaj.Text = Temp.Arge_PanoSaseMontaj;
            cmb_kablolama.Text = Temp.Arge_Kablolama;
            cmb_topMontaj.Text = Temp.Arge_TopMontaj;
            cmb_bantOlcu.Text = Temp.Arge_BantOlcu;
            cmb_bantMontaj.Text = Temp.Arge_BantMontaj;
            cmb_KumandaPanoAtama.Text = Temp.Arge_KumandaPanoAtama;
            cmb_sevk.Text = Temp.Dig_SevkDurum;
            cmb_test.Text = Temp.Dig_TestAsaması;

            #endregion

            cmb_ulke.Enabled = false;
            cmb_ıl.Enabled = false;
            txt_müsteriNo.Enabled = false;
            txt_üretimNo.Enabled = false;
        }

        private void byn_kaydet_Click_1(object sender, EventArgs e)
        {
            int ReturnValue = 0;
            if (Temp != null)
            {
                TempDoldur();
                ReturnValue = paketlemeOperation.Guncelle(Temp.ID, Temp, yetkili);
                if (ReturnValue > 0)
                {
                    MessageBox.Show($"{Temp.Te_MusteriAdi}' ye ait Paketleme Makinesi Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Güncelleme Sırasında Hata Oluştu Tekrar Deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Temp = new PaketlemeMakine();
                Temp.ID = Guid.NewGuid();
                Temp.MusteriID = musteri.ID;
                TempDoldur();
                ReturnValue = paketlemeOperation.Kaydet(Temp, yetkili);
                if (ReturnValue > 0)
                {
                    MessageBox.Show($"{Temp.Te_MusteriAdi}' Firma/Kişisine ait '{Temp.Te_UretimNo}' 'Üretim Numaralı Paketleme Makinesi Başarıyla Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtBosalt();
                }
                else
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int returnvalue = paketlemeOperation.Sil(Temp.ID, yetkili);
            if (returnvalue > 0)
            {
                lbl_uyari.Text = $"{Temp.Te_MusteriAdi} Ait Makine Silindi. ";
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
                cmb_ıl.Text = musteri.Il;
                cmb_ulke.Text = musteri.Ulke;
                txt_müsteriNo.Text = musteri.MusteriNo;
                cmb_ulke.Enabled = false;
                cmb_ıl.Enabled = false;
                txt_müsteriNo.Enabled = false;
                cmb_musteriAdi.Enabled = false;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
        }
    }
}
