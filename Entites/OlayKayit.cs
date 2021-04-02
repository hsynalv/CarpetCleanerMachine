using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class OlayKayit
    {
        [DisplayName("ID")]
        public Guid ID { get; set; }
        [DisplayName("Yapılan İşlem")]
        public string Islem { get; set; }
        [DisplayName("İşlemi Yapan Kullanıcı")]
        public string Kullanici { get; set; }
        [DisplayName("İşlem Tarihi")]
        public DateTime dateTime { get; set; }
    }
}
