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
    public class DLLCırpmaOperation: RepositoryBase<TozCırpmaMakine, EFContext>, IMachineOperation<TozCırpmaMakine> 
    {

        public DLLCırpmaOperation()
        {
            
        }

        public TozCırpmaMakine Find(Guid ID)
        {
            return SingleSearch(I => I.ID == ID);
        }

        public TozCırpmaMakine FindUretimNo(int ara)
        {
            return SingleSearch(I => I.Te_UretimNo == ara);
        }

        public List<TozCırpmaMakine> GetAll()
        {
            return base.GetAll().ToList();
        }

        public int Guncelle(TozCırpmaMakine entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Modified);
            return SaveChange();
        }

        public int Kaydet(TozCırpmaMakine entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Added);
            return SaveChange();
        }

        public int Sil(TozCırpmaMakine entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Deleted);
            return SaveChange();
        }

        public List<TozCırpmaMakine> WhereMusteri(Guid ID)
        {
            return base.GetAll(I => I.MusteriID == ID).ToList(); ;
        }

        public List<TozCırpmaMakine> WhereMachine(bool kontrol)
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

        public List<TozCırpmaMakine> WhereMachineStock(bool kontrol)
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
