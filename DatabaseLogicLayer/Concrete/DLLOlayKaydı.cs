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
    public static class DLLOlayKaydı
    {
        static RepositoryBase<OlayKayit, EFContext> Repo = new RepositoryBase<OlayKayit, EFContext>();

        public static int OlayEkle(OlayKayit kayit)
        {
            Repo.CUDOperation(kayit, System.Data.Entity.EntityState.Added);
            return Repo.SaveChange();
        }

        public static List<OlayKayit> OlayGetir()
        {
            return Repo.GetAll().OrderByDescending(I => I.dateTime).ToList();
        }

    }
}
