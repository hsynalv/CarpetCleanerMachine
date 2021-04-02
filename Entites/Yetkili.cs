using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Yetkili
    {
        [DisplayName("ID")]
        public Guid ID { get; set; }
       
        [DisplayName("Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [DisplayName("Sifre")]
        public string Sifre { get; set; }
        [DisplayName("Ad Soyad")]
        public string İsimSoyisim { get; set; }
        [DisplayName("Yönetici Yetki")]
        public bool YoneticiYetki { get; set; }
        [DisplayName("Sipariş Ekle")]
        public bool SiparisEkle { get; set; }
        [DisplayName("Makine Gör")]
        public bool MakineGor { get; set; }
        [DisplayName("Müşteri Gör")]
        public bool MusteriGor { get; set; }
        [DisplayName("Makine Ekle")]
        public bool Makineekle { get; set; }
        [DisplayName("Müşteri Ekle")]
        public bool Musteriekle { get; set; }

    }
}
