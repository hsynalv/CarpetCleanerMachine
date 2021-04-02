using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Machine
{
    public class MecMakine : MakineBase
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
        [DisplayName("Kumanda Sistem")]
        public string Oz_KumandaSistem { get; set; }
        [DisplayName("Fırça Kalınlık")]
        public string Oz_FircaKalinlik { get; set; }
        [DisplayName("Yedek Fırça")]
        public string Oz_YedekFrica { get; set; }
        [DisplayName("Çift Yön Sistem")]
        public string Oz_CiftYonSistem { get; set; }
        [DisplayName("Kablo Uzunluk")]
        public string Oz_KabloUzunluk { get; set; }
        [DisplayName("Boru Grup")]
        public string Sip_BoruGrup { get; set; }
        [DisplayName("Mil Grup")]
        public string Sip_MilGrup { get; set; }
        [DisplayName("Plastik Grup")]
        public string Sip_PlastikGrup { get; set; }
        [DisplayName("Fırça Grup")]
        public string Sip_FircaGrup { get; set; }
        [DisplayName("Motor Grup")]
        public string Sip_MotorGrup { get; set; }
        [DisplayName("Hırdavat Grup")]
        public string Sip_HirdavatGrup { get; set; }
        [DisplayName("Elektrik Sipariş")]
        public string Sip_ElektrikSiparis { get; set; }
        [DisplayName("Lazer Kesimi")]
        public string Arge_LazerKEsim { get; set; }
        [DisplayName("Büküm")]
        public string Arge_Bukum { get; set; }
        [DisplayName("Bombe Durumu")]
        public string Arge_BombeDurum { get; set; }
        [DisplayName("İç Tornalık Malzemeleri")]
        public string Arge_IcTornaMalzeme { get; set; }
        [DisplayName("Kaynak İşlemleri")]
        public string Arge_KaynakIslem { get; set; }
        [DisplayName("Galvaniz İşlemleri")]
        public string Arge_GalvanizIslem { get; set; }
        [DisplayName("Montaj Aşaması")]
        public string Arge_MontajAsama { get; set; }
        [DisplayName("Elektrik Pano Döşemesi")]
        public string Arge_ElektrikPanoDoseme { get; set; }
        [DisplayName("Test Aşaması")]
        public string Dig_TestAsama { get; set; }
        [DisplayName("Sevk Durumu")]
        public string Dig_SevkDurum { get; set; }
        [DisplayName("Sevk Tarihi")]
        public string Dig_SevkTarih { get; set; }
        public string Acıklama { get; set; }
        public virtual Musteri Musteri { get; set; }
    }
}
