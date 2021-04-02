using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Machine
{
    public class SikmaMakine : MakineBase
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
        [DisplayName("Şase Uzunluğu")]
        public string Oz_SaseUzunluğu { get; set; }
        [DisplayName("Tambur Çap")]
        public string Oz_TamburCap { get; set; }
        [DisplayName("Fren Sistem")]
        public string Oz_FrenSistem { get; set; }
        [DisplayName("Halı Taşıma Araba Sayısı")]
        public string Oz_HaliTasımaArabaSayi { get; set; }
        [DisplayName("Mil-Lama Malzemeleri")]
        public string Sip__Mil_LamaMalzeme { get; set; }
        [DisplayName("Rulman Grubu")]
        public string Sip_RulmanGrup { get; set; }
        [DisplayName("Yatak Yağlama Grubu")]
        public string Sip_Yatak_YaglamaGrup { get; set; }
        [DisplayName("Kapak Grubu")]
        public string Sip_KapakkGrup { get; set; }
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
        [DisplayName("Lazer Kesimi")]
        public string Arge_LazerKesim { get; set; }
        [DisplayName("Büküm")]
        public string Arge_Bukum { get; set; }
        [DisplayName("Tambur Durumu")]
        public string Arge_TamburDurum { get; set; }
        [DisplayName("İç Tornalık Malzemeler")]
        public string Arge_IcTornaMalzeme { get; set; }
        [DisplayName("Kaynak İşlemi")]
        public string Arge_KaynakIslem { get; set; }
        [DisplayName("Nikelaj Malzemeleri")]
        public string Arge_NikelajMalzeme { get; set; }
        [DisplayName("Boyahane Durum")]
        public string Arge_BoyahaneDurum { get; set; }
        [DisplayName("Montaj Aşama")]
        public string Arge_MontajAsama { get; set; }
        [DisplayName("Elektrik Pano Döşemesi")]
        public string Arge_ElektrikPanoDosenme { get; set; }
        [DisplayName("Pano Şase Montajı")]
        public string Arge_PanoSaseMontaj { get; set; }
        [DisplayName("Kablolama")]
        public string Arge_Kablolama { get; set; }
        [DisplayName("Test Aşamsı")]
        public string Dig_TestAsaması { get; set; }
        [DisplayName("Sevk Durum")]
        public string Dig_SevkDurum { get; set; }
        [DisplayName("Sevk Tarihi")]
        public string Dig_SevkTarih { get; set; }
        public string Acıklama { get; set; }
        public virtual Musteri Musteri { get; set; }
    }

    
}
