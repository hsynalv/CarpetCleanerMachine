using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Machine
{
    public class OtomatikHaliYikama : MakineBase
    {
        [DisplayName("ID")]
        public Guid ID { get; set; }
        public Guid MusteriID { get; set; }
        [DisplayName("Ülke")]
        public string Ulke { get; set; }
        [DisplayName("İl")]
        public string Il { get; set; }
        [DisplayName("Müşteri Adı")]
        public string Te_MusteriAdi { get; set; }
        [DisplayName("Müşteri No")]
        public string Te_MusteriNo { get; set; }
        [DisplayName("Üretim No")]
        public int Te_UretimNo { get; set; }
        [DisplayName("İş Emri No")]
        public string Te_IsEmriNo { get; set; }
        [DisplayName("Sipariş No")]
        public string Te_SiparişNo { get; set; }
        [DisplayName("Stok Ürün")]
        public bool stok_mu { get; set; }
        [DisplayName("Sipariş Tarihi")]
        public DateTime Te_SiparisTarihi { get; set; }
        [DisplayName("Termin Tarihi")]
        public DateTime Te_TerminTarihi { get; set; }
        [DisplayName("Şase Tipi")]
        public string Oz_ŞaseTipi { get; set; }
        [DisplayName("Halı Giriş Ölçüsü")]
        public string Oz_HaliGiris { get; set; }
        [DisplayName("Ünite Sayısı")]
        public string Oz_UniteSayisi { get; set; }
        [DisplayName("Ekran Boyutu")]
        public string Oz_EkranBoyutu { get; set; }
        [DisplayName("Etiket Dili")]
        public string Oz_EtiketDili { get; set; }
        [DisplayName("Kaç Parça Gidecek")]
        public string Oz_KacParcaGidecek { get; set; }
        [DisplayName("Fırça Sayısı")]
        public string Oz_FircaSayisi { get; set; }
        [DisplayName("Üst Rulo")]
        public string Oz_UstRulo { get; set; }
        [DisplayName("Alt Rulo")]
        public string Oz_AltRulo { get; set; }
        [DisplayName("Çitileme")]
        public string Oz_Citileme { get; set; }
        [DisplayName("Gelberi")]
        public string Oz_Gelberi { get; set; }
        [DisplayName("Halı Katlama Sıstemi")]
        public string Oz_HaliKatlamaSistemi { get; set; }
        [DisplayName("Plastik Malzeme")]
        public string Sip_PlastikMalzeme { get; set; }
        [DisplayName("Rulman Grubu")]
        public string Sip_RulmanGrubu { get; set; }
        [DisplayName("Boru Profil Grubu")]
        public string Sip_Boru_ProfilGrubu { get; set; }
        [DisplayName("Fırça Grubu")]
        public string Sip_FircaGrubu { get; set; }
        [DisplayName("Motor Grubu")]
        public string Sip_MotorGrubu { get; set; }
        [DisplayName("Hırdavat Grubu")]
        public string Sip_HirdavatGrubu { get; set; }
        [DisplayName("Elektrik Siparişi")]
        public string Sip_ElektrikSiparisi { get; set; }
        [DisplayName("Buton Etiketi")]
        public string Sip_ButonEtiketi { get; set; }
        [DisplayName("CE Etiketi")]
        public string Sip_CE_Etiketi { get; set; }
        [DisplayName("Diğerleri")]
        public string Sip_Digerleri { get; set; }
        [DisplayName("Lazer Kesim")]
        public string Arge_LazerKesim { get; set; }
        [DisplayName("Büküm")]
        public string Arge_Bukum { get; set; }
        [DisplayName("Boru Profil Kaynak")]
        public string Arge_Boru_ProfilKaynak { get; set; }
        [DisplayName("Boru Dış Torna")]
        public string Arge_BoruDisTorna { get; set; }
        [DisplayName("İç Tornalık Malzemeleri")]
        public string Arge_icTornalikMalzeme { get; set; }
        [DisplayName("Kaynak İşlemi")]
        public string Arge_Kaynakİslem { get; set; }
        [DisplayName("Dış Kaplama Kaynak")]
        public string Arge_DisKaplamaKaynak { get; set; }
        [DisplayName("Dış Kaplama Boya")]
        public string Arge_DisKaplamaBoya { get; set; }
        [DisplayName("Şase Ünite Galvaniz")]
        public string Arge_Sase_UniteGalvaniz { get; set; }
        [DisplayName("Boru Galvaniz")]
        public string Arge_BoruGalvaniz { get; set; }
        [DisplayName("Şase KAldırma")]
        public string Arge_SaseKaldirmasi { get; set; }
        [DisplayName("Şase Montaj")]
        public string Arge_SaseMontaj { get; set; }
        [DisplayName("Ünite Montaj")]
        public string Arge_UniteMontaj { get; set; }
        [DisplayName("Şase Ünite Montaj")]
        public string Arge_UniteSaseMontaj { get; set; }
        [DisplayName("Elektrik Pano Döşemesi")]
        public string Arge_ElektrikPanoDösenmesi { get; set; }
        [DisplayName("Pano Şase Montajı")]
        public string Arge_PanoSaseMontaj { get; set; }
        [DisplayName("Kablolama")]
        public string Arge_Kablolama { get; set; }
        [DisplayName("Topların Montajı")]
        public string Arge_TopMontaj { get; set; }
        [DisplayName("Bant Ölçü")]
        public string Arge_BantOlcu { get; set; }
        [DisplayName("Bant Montaj")]
        public string Arge_BantMontaj { get; set; }
        [DisplayName("Otomasyon Yazılımı")]
        public string Arge_OtomasyonYazilim { get; set; }
        [DisplayName("Test Aşaması")]
        public string Dig_TestAsamasi { get; set; }
        [DisplayName("Sevk Durumu")]
        public string Dig_SevkDurum { get; set; }
        [DisplayName("Sevk Tarihi")]
        public string Dig_SevkTarih { get; set; }
        public string Acıklama { get; set; }
        public virtual Musteri Musteri { get; set; }
    }
}
