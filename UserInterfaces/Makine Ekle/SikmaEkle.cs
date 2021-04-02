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
    public partial class SikmaEkle : Form
    {
        BLLSikmaOperation sikmaOperation;
        BLLMusteriOperation musteriOperation;
        SikmaMakine Temp;
        Musteri musteri;
        Yetkili yetkili;
        public SikmaEkle(Yetkili yetkili_, Musteri musteri_ = null)
        {
            InitializeComponent();
            sikmaOperation = new BLLSikmaOperation();
            musteriOperation = new BLLMusteriOperation();
            yetkili = yetkili_;
            musteri = musteri_;
            this.Text = "SIKMA MAKİNE EKLE";
            btn_sil.Visible = false;
        }
        public SikmaEkle(Yetkili yetkili_,SikmaMakine makine)
        {
            InitializeComponent();
            Temp = makine;
            sikmaOperation = new BLLSikmaOperation();
            musteriOperation = new BLLMusteriOperation();
            yetkili = yetkili_;
            this.Text = "SIKMA MAKİNE GÜNCELLE";
            doldur();
            cmb_musteriAdi.Enabled = false;
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

        private void SikmaEkle_Load(object sender, EventArgs e)
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

        #region TempDoldur
        private void TempDoldur()
        {
            Temp.Il = cmb_ıl.Text;
            Temp.Ulke = cmb_ulke.Text;
            Temp.Te_MusteriAdi = cmb_musteriAdi.Text;
            Temp.Te_MusteriNo = txt_müsteriNo.Text;
            Temp.Te_IsEmriNo = txt_isEmri.Text;
            Temp.Te_SiparişNo = txt_siparis.Text;
            Temp.stok_mu = check_stok.Checked;
            try
            {
                Temp.Te_SiparisTarihi = Convert.ToDateTime(txt_siparisTarih.Text);
                Temp.Te_TerminTarihi = Convert.ToDateTime(txt_terminTarih.Text);
                Temp.Te_UretimNo = sikmaOperation.GetAll().Max(I => I.Te_UretimNo) + 1;
            }
            catch (System.InvalidOperationException)
            {
                Temp.Te_UretimNo = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Geçerli Bir Tarih Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Temp.Oz_SaseUzunluğu = cmb_ŞaseUzunlugu.Text;
            Temp.Acıklama = txt_acıklama.Text;
            Temp.Oz_TamburCap = cmb_TamburCap.Text;
            Temp.Oz_FrenSistem = cmb_FrenSistem.Text;
            Temp.Oz_HaliTasımaArabaSayi = cmb_haliTasıma.Text;
            Temp.Sip__Mil_LamaMalzeme = cmb_milLama.Text;
            Temp.Sip_RulmanGrup = cmb_RulmanGrup.Text;
            Temp.Sip_Yatak_YaglamaGrup = cmb_YatakYaglama.Text;
            Temp.Sip_KapakkGrup = cmb_KapakGrup.Text;
            Temp.Sip_MotorGrup = cmb_motorGrup.Text;
            Temp.Sip_HirdavatGrup = cmb_hırdavatGrup.Text;
            Temp.Sip_ElektrikSiparis = cmb_elektrikSiparis.Text;
            Temp.Sip_ButonEtiketi = cmb_butonEtiket.Text;
            Temp.Sip_Ce_Etiketi = cmb_CE.Text;
            Temp.Sip_Digerleri = cmb_digerleri.Text;
            Temp.Arge_LazerKesim = cmb_lazer.Text;
            Temp.Arge_Bukum = cmb_bukum.Text;
            Temp.Arge_TamburDurum = cmb_TamburDurum.Text;
            Temp.Arge_IcTornaMalzeme = cmb_IcTorna.Text;
            Temp.Arge_KaynakIslem = cmb_kaynakIslem.Text;
            Temp.Arge_NikelajMalzeme = cmb_NikelajMalzeme.Text;
            Temp.Arge_BoyahaneDurum = cmb_boyahane.Text;
            Temp.Arge_MontajAsama = cmb_MontajAsama.Text;
            Temp.Arge_ElektrikPanoDosenme = cmb_ElektrikPanoDoseme.Text;
            Temp.Arge_PanoSaseMontaj = cmb_panoSaseMontaj.Text;
            Temp.Arge_Kablolama = cmb_Kablolama.Text;
            Temp.Dig_SevkDurum = cmb_sevk.Text;
            Temp.Dig_TestAsaması = cmb_test.Text;
        }
        #endregion
        private void doldur()
        {
            #region doldur
            cmb_ulke.Text = Temp.Ulke;
            cmb_ıl.Text = Temp.Il;
            txt_siparis.Text = Temp.Te_SiparişNo;
            txt_acıklama.Text = Temp.Acıklama;
            txt_isEmri.Text = Temp.Te_IsEmriNo;
            cmb_musteriAdi.Text = Temp.Te_MusteriAdi;
            txt_müsteriNo.Text = Temp.Te_MusteriNo;
            txt_üretimNo.Text = Temp.Te_UretimNo.ToString();
            check_stok.Checked = Temp.stok_mu;
            txt_siparisTarih.Text = Temp.Te_SiparisTarihi.ToString(); ;
            txt_terminTarih.Text = Temp.Te_TerminTarihi.ToString();
            cmb_ŞaseUzunlugu.Text = Temp.Oz_SaseUzunluğu;
            cmb_TamburCap.Text = Temp.Oz_TamburCap;
            cmb_FrenSistem.Text = Temp.Oz_FrenSistem;
            cmb_haliTasıma.Text = Temp.Oz_HaliTasımaArabaSayi;
            cmb_milLama.Text = Temp.Sip__Mil_LamaMalzeme;
            cmb_RulmanGrup.Text = Temp.Sip_RulmanGrup;
            cmb_YatakYaglama.Text = Temp.Sip_Yatak_YaglamaGrup;
            cmb_KapakGrup.Text = Temp.Sip_KapakkGrup;
            cmb_motorGrup.Text = Temp.Sip_MotorGrup;
            cmb_hırdavatGrup.Text = Temp.Sip_HirdavatGrup;
            cmb_elektrikSiparis.Text = Temp.Sip_ElektrikSiparis;
            cmb_butonEtiket.Text = Temp.Sip_ButonEtiketi;
            cmb_CE.Text = Temp.Sip_Ce_Etiketi;
            cmb_digerleri.Text = Temp.Sip_Digerleri;
            cmb_lazer.Text = Temp.Arge_LazerKesim;
            cmb_bukum.Text = Temp.Arge_Bukum;
            cmb_TamburDurum.Text = Temp.Arge_TamburDurum;
            cmb_IcTorna.Text = Temp.Arge_IcTornaMalzeme;
            cmb_kaynakIslem.Text = Temp.Arge_KaynakIslem;
            cmb_NikelajMalzeme.Text = Temp.Arge_NikelajMalzeme;
            cmb_boyahane.Text = Temp.Arge_BoyahaneDurum;
            cmb_MontajAsama.Text = Temp.Arge_MontajAsama;
            cmb_ElektrikPanoDoseme.Text = Temp.Arge_ElektrikPanoDosenme;
            cmb_panoSaseMontaj.Text = Temp.Arge_PanoSaseMontaj;
            cmb_Kablolama.Text = Temp.Arge_Kablolama;
            cmb_sevk.Text = Temp.Dig_SevkDurum;
            cmb_test.Text = Temp.Dig_TestAsaması;

            #endregion

            txt_üretimNo.Enabled = false;
            txt_müsteriNo.Enabled = false;
            cmb_ıl.Enabled = false;
            cmb_ulke.Enabled = false;
        }

        private void byn_kaydet_Click_1(object sender, EventArgs e)
        {
            int returnValue = 0;
            if (Temp != null)
            {
                TempDoldur();
                returnValue = sikmaOperation.Guncelle(Temp.ID, Temp, yetkili);
                if (returnValue > 0)
                {
                    MessageBox.Show($"{Temp.Te_MusteriAdi}' ye ait Sıkma Makinesi Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Güncelleme Sırasında Hata Oluştu Tekrar Deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Temp = new SikmaMakine();
                Temp.ID = Guid.NewGuid();
                Temp.MusteriID = musteri.ID;
                TempDoldur();
                returnValue = sikmaOperation.Kaydet(Temp, yetkili);
                if (returnValue > 0)
                {
                    MessageBox.Show($"{Temp.Te_MusteriAdi}' Firma/Kişisine ait '{Temp.Te_UretimNo}' 'Üretim Numaralı Sıkma Makinesi Başarıyla Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            
            int returnvalue = sikmaOperation.Sil(Temp.ID, yetkili);
            if (returnvalue > 0)
            {
                lbl_uyari.Text = $"{Temp.Te_MusteriAdi} Ait Makine Silindi. ";
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
            }
            catch (Exception ex)
            {

                string message = ex.Message;
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
                musteriOperation.Get_Ulke(cmb_ulke.Text).ForEach(I => cmb_musteriAdi.Items.Add(I.MusteriAdı));
              
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
            musteriOperation.Get_il(cmb_ıl.Text).ForEach(I => cmb_musteriAdi.Items.Add(I.MusteriAdı));

            foreach (Musteri item in musteriOperation.Get_il(cmb_ıl.Text))
            {
                if (!cmb_musteriAdi.Items.Contains(item.MusteriAdı))
                {
                    cmb_musteriAdi.Items.Add(item.MusteriAdı);
                }
            }
        }
    }
}
