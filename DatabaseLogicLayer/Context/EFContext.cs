using Entites;
using Entites.Machine;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLogicLayer.Context
{
    public class EFContext:DbContext
    {
        public EFContext():base("SumakMusteriTakip")
        {

        }

        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<MecMakine> MecMakines { get; set; }
        public DbSet<OtomatikHaliYikama> OtomatikHaliYikamas { get; set; }
        public DbSet<SikmaMakine> SikmaMakines { get; set; }
        public DbSet<TozCırpmaMakine> TozCırpmaMakines { get; set; }
        public DbSet<PaketlemeMakine> PaketlemeMakines { get; set; }
        public DbSet<Yetkili> Yetkililer { get; set; }
        public DbSet<OlayKayit> OlayKayits { get; set; }



    }
}
