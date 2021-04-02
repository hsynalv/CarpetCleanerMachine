using Entites.Machine;
using Repository;
using DatabaseLogicLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLogicLayer.Absract;

namespace DatabaseLogicLayer.Concrete
{
    public class DLLMecMakineOperation : RepositoryBase<MecMakine, EFContext>, IMachineOperation<MecMakine>
    {

        public DLLMecMakineOperation()
        {
        }
        public List<MecMakine> WhereMusteri(Guid ID)
        {
            return base.GetAll(I => I.MusteriID == ID).ToList(); ;
        }

        public MecMakine Find(Guid ID)
        {
            return SingleSearch(I => I.ID == ID);
        }

        public MecMakine FindUrunNo(int ara)
        {
            return SingleSearch(I => I.Te_UretimNo == ara);
        }

        public List<MecMakine> GetAll()
        {
            return base.GetAll().ToList();
        }

        public int Guncelle(MecMakine entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Modified);
            return SaveChange();
        }

        public int Kaydet(MecMakine entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Added);
            return SaveChange();
        }

        public int Sil(MecMakine entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Deleted);
            return SaveChange();
        }
        public List<MecMakine> WhereMachine(bool kontrol)
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

        public List<MecMakine> WhereMachineStock(bool kontrol)
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
