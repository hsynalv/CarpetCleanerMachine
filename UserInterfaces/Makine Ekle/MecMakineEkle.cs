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
    public partial class MecMakineEkle : Form
    {
        BLLMecOperation mecOperation;
        BLLMusteriOperation musteriOperation;
        Yetkili yetkili;
        Musteri musteri;
        MecMakine Temp;
        public MecMakineEkle(Yetkili _yetkili, Musteri _musteri = null)
        {
            InitializeComponent();
            mecOperation = new BLLMecOperation();
            musteriOperation = new BLLMusteriOperation();
            yetkili = _yetkili;
            musteri = _musteri;
            this.Text = "MEÇ MAKİNE EKLE";
            btn_sil.Visible = false;
        }

        public MecMakineEkle(Yetkili _yetkili,  MecMakine makine)
        {
            InitializeComponent();
            Temp = makine;
            mecOperation = new BLLMecOperation();
            musteriOperation = new BLLMusteriOperation();
            yetkili = _yetkili;
            this.Text = "MEÇ MAKİNE GÜNCELLE";   
        }


        private void MecMakineEkle_Load(object sender, EventArgs e)
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

        private void byn_kaydet_Click(object sender, EventArgs e)
        {
            int ReturnValue = 0;
            if (Temp != null)
            {
                TempDoldur();
                ReturnValue = mecOperation.Guncelle(Temp.ID, Temp, yetkili);
                if (ReturnValue > 0)
                {
                    MessageBox.Show($"{Temp.Te_MusteriAdi}' ye ait Meç Makinesi Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Güncelleme Sırasında Hata Oluştu Tekrar Deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Temp = new MecMakine();
                Temp.ID = Guid.NewGuid();
                Temp.MusteriID = musteri.ID;
                TempDoldur();
                ReturnValue = mecOperation.Kaydet(Temp, yetkili);
                if (ReturnValue > 0)
                {
                    MessageBox.Show($"{Temp.Te_MusteriAdi}' Firma/Kişisine ait '{Temp.Te_UretimNo}' 'Üretim Numaralı Meç Makinesi Başarıyla Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtBosalt();
                }
                else
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
        }
        
#region tempDoldur
        private void TempDoldur()
        {
            Temp.Il =cmb_ıl.Text;
            Temp.Ulke = cmb_ulke.Text;
            Temp.Te_MusteriAdi = cmb_musteriAdi.Text;
            Temp.Te_MusteriNo = txt_müsteriNo.Text;
            Temp.Te_IsEmriNo = txt_isEmri.Text;
            Temp.Te_SiparişNo = txt_siparis.Text;
            Temp.Acıklama = txt_acıklama.Text;
            Temp.stok_mu = check_stok.Checked;
            try
            {
                Temp.Te_SiparisTarihi = Convert.ToDateTime(txt_siparisTarih.Text);
                Temp.Te_TerminTarihi = Convert.ToDateTime(txt_terminTarih.Text);
                Temp.Te_UretimNo = mecOperation.GetAll().Max(I => I.Te_UretimNo) + 1;
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
            Temp.Oz_KumandaSistem = cmb_kumanda.Text;
            Temp.Oz_FircaKalinlik = cmb_fircaKalinlik.Text;
            Temp.Oz_YedekFrica = cmb_yedekFirca.Text;
            Temp.Oz_CiftYonSistem = cmb_ciftYon.Text;
            Temp.Oz_KabloUzunluk = cmb_kablo.Text;
            Temp.Sip_BoruGrup = cmb_boruGrup.Text;
            Temp.Sip_MilGrup = cmb_milGrup.Text;
            Temp.Sip_PlastikGrup = cmb_PlasitkGrup.Text;
            Temp.Sip_FircaGrup = cmb_fircaGrup.Text;
            Temp.Sip_MotorGrup = cmb_motorGrup.Text;
            Temp.Sip_HirdavatGrup = cmb_hırdavatGrup.Text;
            Temp.Sip_ElektrikSiparis = cmb_hırdavatGrup.Text;
            Temp.Arge_LazerKEsim = cmb_lazer.Text;
            Temp.Arge_Bukum = cmb_bukum.Text;
            Temp.Arge_BombeDurum = cmb_bombeDurum.Text;
            Temp.Arge_IcTornaMalzeme = cmb_icTorna.Text;
            Temp.Arge_KaynakIslem = cmb_Kaynak.Text;
            Temp.Arge_GalvanizIslem = cmb_galvaniz.Text;
            Temp.Arge_MontajAsama = cmb_montaj.Text;
            Temp.Arge_ElektrikPanoDoseme = cmb_elektrikDoseme.Text;
            Temp.Dig_SevkDurum = cmb_sevk.Text;
            Temp.Dig_TestAsama = cmb_test.Text;
            
        }
        #endregion

        private void cmb_musteriAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                musteri = musteriOperation.FindMusteriAdi(cmb_musteriAdi.Text);
                cmb_ulke.Text = musteri.Ulke;
                cmb_ıl.Text = musteri.Il;
                txt_müsteriNo.Text = musteri.MusteriNo;
                cmb_ulke.Enabled = false;
                cmb_ıl.Enabled = false;
                txt_müsteriNo.Enabled = false;
                cmb_musteriAdi.Enabled = false;
            }
            catch (Exception)
            {
            }
        }

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
            txt_siparisTarih.Text = Temp.Te_SiparisTarihi.ToString();
            txt_terminTarih.Text = Temp.Te_TerminTarihi.ToString();
            cmb_Şase.Text = Temp.Oz_SaseTipi;
            cmb_kumanda.Text = Temp.Oz_KumandaSistem;
            cmb_fircaKalinlik.Text = Temp.Oz_FircaKalinlik;
            cmb_yedekFirca.Text = Temp.Oz_YedekFrica;
            cmb_ciftYon.Text = Temp.Oz_CiftYonSistem;
            cmb_kablo.Text = Temp.Oz_KabloUzunluk;
            cmb_boruGrup.Text = Temp.Sip_BoruGrup;
            cmb_milGrup.Text = Temp.Sip_MilGrup;
            cmb_milGrup.Text = Temp.Sip_PlastikGrup;
            cmb_fircaGrup.Text = Temp.Sip_FircaGrup;
            cmb_motorGrup.Text = Temp.Sip_MotorGrup;
            cmb_hırdavatGrup.Text = Temp.Sip_HirdavatGrup;
            cmb_hırdavatGrup.Text = Temp.Sip_ElektrikSiparis;
            cmb_lazer.Text = Temp.Arge_LazerKEsim;
            cmb_bukum.Text = Temp.Arge_Bukum;
            cmb_bombeDurum.Text = Temp.Arge_BombeDurum;
            cmb_icTorna.Text = Temp.Arge_IcTornaMalzeme;
            cmb_Kaynak.Text = Temp.Arge_KaynakIslem;
            cmb_galvaniz.Text = Temp.Arge_GalvanizIslem;
            cmb_montaj.Text = Temp.Arge_MontajAsama;
            cmb_elektrikDoseme.Text = Temp.Arge_ElektrikPanoDoseme;
            cmb_sevk.Text = Temp.Dig_SevkDurum;
            cmb_test.Text = Temp.Dig_TestAsama;

            #endregion

            txt_müsteriNo.Enabled = false;
            txt_üretimNo.Enabled = false;
            cmb_ulke.Enabled = false;
            cmb_ıl.Enabled = false;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int returnvalue = mecOperation.Sil(Temp.ID, yetkili);
            if (returnvalue > 0)
            {
                lbl_uyari.Text = $"{Temp.Te_MusteriAdi} Ait Makine Silindi. ";
            }
        }

        
        private void cmb_ulke_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cmb_ıl_SelectedIndexChanged(object sender, EventArgs e)
        {
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
