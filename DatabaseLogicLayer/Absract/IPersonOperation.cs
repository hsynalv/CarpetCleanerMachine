using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLogicLayer.Absract
{
    interface IPersonOperation<TEntity> where TEntity:class, new()
    {

        int Kaydet(TEntity entity);
        int Guncelle(TEntity entity);
        int Sil(TEntity entity);
        List<TEntity> GetAll();

    }
}
