using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLogicLayer.Absract
{
    public interface IMachineOperation<TEntity> where TEntity: class, new()
    {

        List<TEntity> GetAll();

        int Kaydet(TEntity entity);

        int Guncelle(TEntity entity);
        int Sil(TEntity entity);
        TEntity Find(Guid ID);

        List<TEntity> WhereMachine(bool kontrol);
       

    }
}
