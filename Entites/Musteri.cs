using Entites.Machine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Musteri
    {
        [DisplayName("ID")]
        public Guid ID { get; set; }
        [DisplayName("Müşteri No")]
        public string MusteriNo { get; set; }
        [DisplayName("Müşteri Adı")]
        public string MusteriAdı { get; set; }
        [DisplayName("Ülke")]
        public string Ulke { get; set; }
        [DisplayName("İl")]
        public string Il { get; set; }

        [DisplayName("TelefonNo")]
        public string TelefonNo { get; set; }
        [DisplayName("Adres")]
        public string Adres { get; set; }
        



        public virtual List<OtomatikHaliYikama> OtomatikHaliYikama { get; set; }
        public virtual List<MecMakine> MecMakine { get; set; }
        public virtual List<PaketlemeMakine> PaketlemeMakine { get; set; }
        public virtual List<SikmaMakine> SikmaMakine { get; set; }
        public virtual List<TozCırpmaMakine> TozCırpmaMakine { get; set; }



    }
}
