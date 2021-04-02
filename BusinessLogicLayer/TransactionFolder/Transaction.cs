using DatabaseLogicLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.TransactionFolder
{
    public  class Transaction
    {
  
       public void TransactionKullan(Action _action)
        { 
            using (EFContext context = new EFContext())
            {
                using (DbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        _action();
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
           
        }
	
	    

	    

    }
}
