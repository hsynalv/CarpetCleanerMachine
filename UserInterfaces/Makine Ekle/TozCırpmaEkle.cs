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
    public partial class TozCırpmaEkle : Form
    {
        BLLCırpmaOperation cırpmaOperation;
        BLLMusteriOperation musteriOperation;
        Yetkili yetkili;
        Musteri musteri;
        TozCırpmaMakine Temp;

        public TozCırpmaEkle(Yetkili yetkili_, Musteri _musteri = null)
        {
            InitializeComponent();
            cırpmaOperation = new BLLCırpmaOperation();
            yetkili = yetkili_;
            musteriOperation = new BLLMusteriOperation();
            musteri = _musteri;
            this.Text = "ÇIRPMA MAKİNE EKLE";
            btn_sil.Visible = false;

        }
        public TozCırpmaEkle(Yetkili yetkili_, TozCırpmaMakine makine)
        {
            InitializeComponent();
            Temp = makine;
            cırpmaOperation = new BLLCırpmaOperation();
            yetkili = yetkili_;
            musteriOperation = new BLLMusteriOperation();
            this.Text = "ÇIRPMA MAKİNE GÜNCELLE";
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


        #region tempDoldur
        private void TempDoldur()
        {
            Temp.Il = cmb_ıl.Text;
            Temp.Ulke = cmb_ulke.Text;
            Temp.Te_MusteriAdi = cmb_musteriAdi.Text;
            Temp.Te_MusteriNo = txt_müsteriNo.Text;
            Temp.Te_IsEmriNo = txt_isEmri.Text;
            Temp.Acıklama = txt_acıklama.Text;
            Temp.Te_SiparişNo = txt_siparis.Text;
            Temp.stok_mu = check_stok.Checked;
            try
            {
                Temp.Te_SiparisTarihi = Convert.ToDateTime(txt_siparisTarih.Text);
                Temp.Te_TerminTarihi = Convert.ToDateTime(txt_terminTarih.Text);
                Temp.Te_UretimNo = cırpmaOperation.GetAll().Max(I => I.Te_UretimNo) + 1;
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
            Temp.Oz_DovucuSayi = cmb_DovucuSayi.Text;
            Temp.Oz_FanSayi = cmb_FanSayisi.Text;
            Temp.Oz_Helezon = cmb_FanSayisi.Text;
            Temp.Sip_PlasitkMalzeme = cmb_PlastikMalzeme.Text;
            Temp.Sip_RulmanGrup = cmb_RulmanGrup.Text;
            Temp.Sip_Boru_ProfilGrup = cmb_boruGrup.Text;
            Temp.Sip_FircaGrup = cmb_fircaGrup.Text;
            Temp.Sip_MotorGrup = cmb_motorGrup.Text;
            Temp.Sip_HirdavatGrup = cmb_hırdavatGrup.Text;
            Temp.Sip_ElektrikSiparis = cmb_elektrikSiparis.Text;
            Temp.Sip_ButonEtiketi = cmb_butonEtiket.Text;
            Temp.Sip_Ce_Etiketi = cmb_CE.Text;
            Temp.Sip_Digerleri = cmb_digerleri.Text;
            Temp.Arge_LazerKesim = cmb_lazer.Text;
            Temp.Arge_Bukum = cmb_bukum.Text;
            Temp.Arge_BoruProfilKaynak = cmb_BoruProfilKaynak.Text;
            Temp.Arge_BoruDisTorna = cmb_BoruDısTorna.Text;
            Temp.Arge_FanTorna_Kama_Balans = cmb_fanTornaKamaBalans.Text;
            Temp.Arge_IcTornaMalzeme = cmb_IcTorna.Text;
            Temp.Arge_KaynakIslem = cmb_kaynakIslem.Text;
            Temp.Arge_DovucuGalvaniz = cmb_DovucuGalvaniz.Text;
            Temp.Arge_BoyahaneDurum = cmb_BoyahaneDurum.Text;
            Temp.Arge_BoruGalvaniz = cmb_boruGalvaniz.Text;
            Temp.Arge_ŞaseKaldirma = cmb_SaseKaldırma.Text;
            Temp.Arge_ŞaseMontaj = cmb_SaseMontaj.Text;
            Temp.Arge_ElektrikPanoDosenme = cmb_ElektrikPanoDöseme.Text;
            Temp.Arge_PanoSaseMontaj = cmb_panoSaseMontaj.Text;
            Temp.Arge_Kablolama = cmb_kablolama.Text;
            Temp.Arge_MontajDurumu = cmb_montajDurum.Text;
            Temp.Arge_BantOlcu = cmb_BantOlcu.Text;
            Temp.Arge_BantMontaj = cmb_bantMontaj.Text;
            Temp.Arge_KumandaPanoAtama = cmb_kumandaPanoAtama.Text;
            Temp.Dig_TestAsaması = cmb_test.Text;
            Temp.Dig_SevkDurum = cmb_sevk.Text;

        }
        #endregion

        private void TozCırpmaEkle_Load(object sender, EventArgs e)
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
            #region Txt Doldur
            cmb_musteriAdi.Text = Temp.Te_MusteriAdi;
            cmb_ulke.Text = Temp.Ulke;
            cmb_ıl.Text = Temp.Il;

            txt_siparis.Text = Temp.Te_SiparişNo;
            txt_acıklama.Text = Temp.Acıklama;
            txt_isEmri.Text = Temp.Te_IsEmriNo;
            cmb_musteriAdi.Text = Temp.Te_MusteriAdi;
            txt_müsteriNo.Text = Temp.Te_MusteriNo;
            txt_üretimNo.Text = Temp.Te_UretimNo.ToString();
            check_stok.Checked = Temp.stok_mu = check_stok.Checked;
            txt_siparisTarih.Text = Temp.Te_SiparisTarihi.ToString();
            txt_terminTarih.Text = Temp.Te_TerminTarihi.ToString();
            cmb_Şase.Text = Temp.Oz_SaseTipi;
            cmb_haliGiris.Text = Temp.Oz_HaliGirisOlcu;
            cmb_DovucuSayi.Text = Temp.Oz_DovucuSayi;
            cmb_FanSayisi.Text = Temp.Oz_FanSayi;
            cmb_FanSayisi.Text = Temp.Oz_Helezon;
            cmb_PlastikMalzeme.Text = Temp.Sip_PlasitkMalzeme;
            cmb_RulmanGrup.Text = Temp.Sip_RulmanGrup;
            cmb_boruGrup.Text = Temp.Sip_Boru_ProfilGrup;
            cmb_fircaGrup.Text = Temp.Sip_FircaGrup;
            cmb_motorGrup.Text = Temp.Sip_MotorGrup;
            cmb_hırdavatGrup.Text = Temp.Sip_HirdavatGrup;
            cmb_elektrikSiparis.Text = Temp.Sip_ElektrikSiparis;
            cmb_butonEtiket.Text = Temp.Sip_ButonEtiketi;
            cmb_CE.Text = Temp.Sip_Ce_Etiketi;
            cmb_digerleri.Text = Temp.Sip_Digerleri;
            cmb_lazer.Text = Temp.Arge_LazerKesim;
            cmb_bukum.Text = Temp.Arge_Bukum;
            cmb_BoruProfilKaynak.Text = Temp.Arge_BoruProfilKaynak;
            cmb_BoruDısTorna.Text = Temp.Arge_BoruDisTorna;
            cmb_fanTornaKamaBalans.Text = Temp.Arge_FanTorna_Kama_Balans;
            cmb_IcTorna.Text = Temp.Arge_IcTornaMalzeme;
            cmb_kaynakIslem.Text = Temp.Arge_KaynakIslem;
            cmb_DovucuGalvaniz.Text = Temp.Arge_DovucuGalvaniz;
            cmb_BoyahaneDurum.Text = Temp.Arge_BoyahaneDurum;
            cmb_boruGalvaniz.Text = Temp.Arge_BoruGalvaniz;
            cmb_SaseKaldırma.Text = Temp.Arge_ŞaseKaldirma;
            cmb_SaseMontaj.Text = Temp.Arge_ŞaseMontaj;
            cmb_ElektrikPanoDöseme.Text = Temp.Arge_ElektrikPanoDosenme;
            cmb_panoSaseMontaj.Text = Temp.Arge_PanoSaseMontaj;
            cmb_kablolama.Text = Temp.Arge_Kablolama;
            cmb_montajDurum.Text = Temp.Arge_MontajDurumu;
            cmb_BantOlcu.Text = Temp.Arge_BantOlcu;
            cmb_bantMontaj.Text = Temp.Arge_BantMontaj;
            cmb_kumandaPanoAtama.Text = Temp.Arge_KumandaPanoAtama;
            cmb_test.Text = Temp.Dig_TestAsaması;
            cmb_sevk.Text = Temp.Dig_SevkDurum;
            #endregion

            cmb_ulke.Enabled = false;
            cmb_ıl.Enabled = false;
            txt_müsteriNo.Enabled = false;
            txt_üretimNo.Enabled = false;
        }

        private void byn_kaydet_Click_1(object sender, EventArgs e)
        {
            int returnValue = 0;
            if (Temp != null)
            {
                TempDoldur();
                returnValue = cırpmaOperation.Guncelle(Temp.ID, Temp, yetkili);

                if (returnValue > 0)
                {
                    MessageBox.Show($"{Temp.Te_MusteriAdi}' ye ait Çırpma Makinesi Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Güncelleme Sırasında Hata Oluştu Tekrar Deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Temp = new TozCırpmaMakine();
                Temp.ID = Guid.NewGuid();
                Temp.MusteriID = musteri.ID;
                TempDoldur();
                returnValue = cırpmaOperation.Kaydet(Temp, yetkili);
                if (returnValue > 0)
                {
                    MessageBox.Show($"{Temp.Te_MusteriAdi}' Firma/Kişisine ait '{Temp.Te_UretimNo}' 'Üretim Numaralı Çırpma Makinesi Başarıyla Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            int returnvalue = cırpmaOperation.Sil(Temp.ID, yetkili);
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

