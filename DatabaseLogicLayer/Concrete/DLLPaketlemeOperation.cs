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
    public class DLLPaketlemeOperation : RepositoryBase<PaketlemeMakine, EFContext>, IMachineOperation<PaketlemeMakine>
    {

        public DLLPaketlemeOperation()
        {
        }

        public PaketlemeMakine Find(Guid ID)
        {
            return SingleSearch(I => I.ID == ID);
        }

        public List<PaketlemeMakine> WhereMusteri(Guid ID)
        {
            return base.GetAll(I => I.MusteriID == ID).ToList(); ;
        }
        public PaketlemeMakine FindUrunNo(int ara)
        {
            return SingleSearch(I => I.Te_UretimNo == ara);
        }

        public List<PaketlemeMakine> GetAll()
        {
            return base.GetAll().ToList();
        }

        public int Guncelle(PaketlemeMakine entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Modified);
            return SaveChange();
        }

        public int Kaydet(PaketlemeMakine entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Added);
            return SaveChange();
        }
        public int Sil(PaketlemeMakine entity)
        {
            CUDOperation(entity, System.Data.Entity.EntityState.Deleted);
            return SaveChange();
        }
        public List<PaketlemeMakine> WhereMachine(bool kontrol)
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

        public List<PaketlemeMakine> WhereMachineStock(bool kontrol)
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
