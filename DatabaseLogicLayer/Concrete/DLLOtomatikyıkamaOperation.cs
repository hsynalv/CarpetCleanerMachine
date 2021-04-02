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
    public class DLLOtomatikyıkamaOperation : RepositoryBase<OtomatikHaliYikama, EFContext>, IMachineOperation<OtomatikHaliYikama>
    {


        public DLLOtomatikyıkamaOperation()
        {

        }
        public List<OtomatikHaliYikama> WhereMusteri(Guid ID)
        {
            return base.GetAll(I => I.MusteriID == ID).ToList(); ;
        }

        public OtomatikHaliYikama Find(Guid ID)
        {
            return SingleSearch(I => I.ID == ID);
        }

        public OtomatikHaliYikama FindUretimNo(int ara)
        {
            return SingleSearch(I => I.Te_UretimNo == ara);
        }

        public List<OtomatikHaliYikama> GetAll()
        {
            return base.GetAll().ToList();
        }

        public int Guncelle(OtomatikHaliYikama entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Modified);
            return SaveChange();
        }

        public int Kaydet(OtomatikHaliYikama entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Added);
            return SaveChange();
        }

        public int Sil(OtomatikHaliYikama entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Deleted);
            return SaveChange();
        }
        public List<OtomatikHaliYikama> WhereMachine(bool kontrol)
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

        public List<OtomatikHaliYikama> WhereMachineStock(bool kontrol)
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
