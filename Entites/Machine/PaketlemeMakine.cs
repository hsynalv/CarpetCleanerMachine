using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Machine
{
    public class PaketlemeMakine : MakineBase
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
        public string Oz_SaseTipi { get; set; }
        [DisplayName("Halı Giriş Ölçüsü")]
        public string Oz_HaliGirisOlcu { get; set; }
        [DisplayName("Fan Sayısı")]
        public string Oz_FanSayisi { get; set; }
        [DisplayName("Parfümleme")]
        public string Oz_Parfumleme { get; set; }
        [DisplayName("Plastik Malzeme")]
        public string Sip_PlastikMalzeme { get; set; }
        [DisplayName("Rulman Grubu")]
        public string Sip_RulmanGrup { get; set; }
        [DisplayName("Boru Profil Grubu")]
        public string Sip_Boru_ProfilGrup { get; set; }
        [DisplayName("Fırça Grubu")]
        public string Sip_FircaGrup { get; set; }
        [DisplayName("Motor Grubu")]
        public string Sip_MotorGrup { get; set; }
        [DisplayName("Hırdavat Grubu")]
        public string Sip_HirdavatGrup { get; set; }
        [DisplayName("Elektrik Siparişi")]
        public string Sip_ElektrikSiparis { get; set; }
        [DisplayName("Buton Etiketi")]
        public string Sip_ButonEtiketi { get; set; }
        [DisplayName("CE Etiketi")]
        public string Sip_Ce_Etiketi { get; set; }
        [DisplayName("Diğerleri")]
        public string Sip_Digerleri { get; set; }
        [DisplayName("Lazer Kesim")]
        public string Arge_LazerKesim { get; set; }
        [DisplayName("Büküm")]
        public string Arge_Bukum { get; set; }
        [DisplayName("Boru Profil Kaynak")]
        public string Arge_BoruProfilKaynak { get; set; }
        [DisplayName("Boru Dış Torna")]
        public string Arge_BoruDisTorna { get; set; }
        [DisplayName("Fan-Torna-Kama Balans")]
        public string Arge_FanTorna_Kama_Balans { get; set; }
        [DisplayName("İç Tornalık Malzemeler")]
        public string Arge_IcTornaMalzeme { get; set; }
        [DisplayName("Kaynak İlem")]
        public string Arge_KaynakIslem { get; set; }
        [DisplayName("Dış Kaplama Kaynak")]
        public string Arge_DisKaplamaKaynak { get; set; }
        [DisplayName("Dış Kaplama Boya")]
        public string Arge_DisKaplamaBoya { get; set; }
        [DisplayName("Baskı Topu Galvaniz")]
        public string Arge_BaskiTopuGalvaniz { get; set; }
        [DisplayName("Boru Galvaniz")]
        public string Arge_BoruGalvaniz { get; set; }
        [DisplayName("Şase Kaldırma")]
        public string Arge_ŞaseKaldirma { get; set; }
        [DisplayName("Şase Montaj")]
        public string Arge_ŞaseMontaj { get; set; }
        [DisplayName("Ünite Şase Montaj")]
        public string Arge_UniteSaseMontaj { get; set; }
        [DisplayName("Elektrik Pano Döşeme")]
        public string Arge_ElektrikPanoDosenme { get; set; }
        [DisplayName("Pano Şase Montaj")]
        public string Arge_PanoSaseMontaj { get; set; }
        [DisplayName("Kablolama")]
        public string Arge_Kablolama { get; set; }
        [DisplayName("Topların Montajı")]
        public string Arge_TopMontaj { get; set; }
        [DisplayName("Bant Ölçü")]
        public string Arge_BantOlcu { get; set; }
        [DisplayName("Bant Montaj")]
        public string Arge_BantMontaj { get; set; }
        [DisplayName("Kumanda Pano Atama")]
        public string Arge_KumandaPanoAtama { get; set; }
        [DisplayName("Test Aşaması")]
        public string Dig_TestAsaması { get; set; }
        [DisplayName("Sevk Durumu")]
        public string Dig_SevkDurum { get; set; }
        [DisplayName("Sevk Tarihi")]
        public string Dig_SevkTarih { get; set; }
        public string Acıklama { get; set; }
        public virtual Musteri Musteri { get; set; }
    }
}
