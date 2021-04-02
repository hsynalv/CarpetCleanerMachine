using DatabaseLogicLayer.Absract;
using DatabaseLogicLayer.Context;
using Entites;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLogicLayer.Concrete
{
    public class YetkiliOperation : RepositoryBase<Yetkili, EFContext>, IPersonOperation<Yetkili>
    {

        public YetkiliOperation()
        {
            IlkKullanici();
        }

        public Yetkili Find(string kAdi, string sifre)
        {
            return SingleSearch(I => I.KullaniciAdi == kAdi && I.Sifre == sifre);
        }

        public Yetkili Find(Guid ID)
        {
            return SingleSearch(I => I.ID == ID);
        }

        public List<Yetkili> GetAll()
        {
            return base.GetAll().ToList();
        }

        public int Guncelle(Yetkili entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Modified);
            return SaveChange();
        }

        public int Kaydet(Yetkili entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Added);
            return SaveChange();
        }

        public int Sil(Yetkili entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Deleted);
            return SaveChange();
        }

        private void IlkKullanici()
        {
            Yetkili yetkili = Find(Guid.Parse("81B26A57-12C5-464D-87DC-287E50F10750"));
            if (yetkili == null)
            {
                yetkili = new Yetkili();
                yetkili.ID = Guid.Parse("81B26A57-12C5-464D-87DC-287E50F10750");
                yetkili.İsimSoyisim = "ADMİN ADMİN";
                yetkili.KullaniciAdi = "admin";
                yetkili.Sifre = "admin";
                yetkili.YoneticiYetki = true;
                yetkili.SiparisEkle = true;
                yetkili.Makineekle = true;
                yetkili.MakineGor = true;
                yetkili.MusteriGor = true;
                yetkili.Musteriekle = true;

                CUDOperation(yetkili, System.Data.Entity.EntityState.Added);
                SaveChange();
            }

            

        }
    }
}
