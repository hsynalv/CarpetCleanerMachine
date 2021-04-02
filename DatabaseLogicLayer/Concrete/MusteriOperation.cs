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
    public class MusteriOperation: RepositoryBase<Musteri, EFContext>, IPersonOperation<Musteri>
    {

        public MusteriOperation()
        {
        }

        public  Musteri Find(string musteriNO)
        {
            return SingleSearch(I => I.MusteriNo == musteriNO);
        }

        public Musteri FindMusteriAdi(string MusteriAdı)
        {
            return SingleSearch(I => I.MusteriAdı == MusteriAdı);
        }

        public  Musteri Find(Guid ID)
        {
            return SingleSearch(I => I.ID == ID);
        }
        public List<Musteri> GetAllByMusteriAdi(string key)
        {
            return base.GetAll(I => I.MusteriAdı.Contains(key)).ToList();
        }
        public List<Musteri> GetAllByİl(string key)
        {
            List<Musteri> musteriler = base.GetAll(I => I.Il.Contains(key)).ToList();
            musteriler.AddRange(base.GetAll(I => I.Ulke.Contains(key)).ToList());

            return musteriler;
        }

        public List<Musteri> GetAll()
        {
            return base.GetAll().ToList();
        }

        public List<Musteri> Get_Ulke(string ulke)
        {
            return base.GetAll(I => I.Ulke == ulke).ToList(); ;
        }

        public List<Musteri> Get_Il(string il)
        {
            return base.GetAll(I => I.Il == il).ToList();
        }

        public int Guncelle(Musteri entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Modified);
            return SaveChange();
        }

        public int Kaydet(Musteri entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Added);
            return SaveChange();
        }

        public int Sil(Musteri entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Deleted);
            return SaveChange();
        }
    }
}
