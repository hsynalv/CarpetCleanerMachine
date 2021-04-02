using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface IMachineOperation<TEntity> where TEntity : class, new()
    {

        List<TEntity> GetAll();

        int Kaydet(TEntity entity, Yetkili yetkili);

        int Guncelle(Guid ID, TEntity entity,Yetkili yetkili,string Log = null);
        int Sil(Guid ID, Yetkili yetkili);

        TEntity Find(Guid ID);

        List<TEntity> whereMachine(bool kontrol);


    }
}
