using DatabaseLogicLayer.Absract;
using DatabaseLogicLayer.Context;
using Entites.Machine;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLogicLayer.Concrete
{
    public class DLLSikmaOperation : RepositoryBase<SikmaMakine, EFContext>,IMachineOperation<SikmaMakine>
    {

        public DLLSikmaOperation()
        {
        }

        public SikmaMakine Find(Guid ID)
        {
            return SingleSearch(I => I.ID == ID);
        }

        public List<SikmaMakine> WhereMusteri(Guid ID)
        {
            return base.GetAll(I => I.MusteriID == ID).ToList(); ;
        }

        public SikmaMakine FindUrunNo(int ara)
        {
            return SingleSearch(I => I.Te_UretimNo == ara);
        }

        public List<SikmaMakine> GetAll()
        {
            return base.GetAll().ToList();
        }

        public int Guncelle(SikmaMakine entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Modified);
            return SaveChange();
        }

        public int Kaydet(SikmaMakine entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Added);
            return SaveChange();
        }

        public int Sil(SikmaMakine entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Deleted);
            return SaveChange();
        }
        public List<SikmaMakine> WhereMachine(bool kontrol)
        {
            if (kontrol)
            {
                return base.GetAll(I => I.Dig_SevkDurum.Equals("Sevk Edildi")).ToList(); ;
            }
            else
            {
                return base.GetAll(I => I.Dig_SevkDurum != "Sevk Edildi").ToList(); ;
            }

        }

        public List<SikmaMakine> WhereMachineStock(bool kontrol)
        {
            if (kontrol)
            {
                return base.GetAll(I => I.stok_mu == true).ToList(); ;
            }
            else
            {
                return base.GetAll(I => I.stok_mu == false).ToList(); ;
            }
        }


    }
}
