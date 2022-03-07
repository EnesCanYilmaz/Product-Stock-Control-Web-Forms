using OrtaDuzeyProgramlamaOdevi.Contexts;
using OrtaDuzeyProgramlamaOdevi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrtaDuzeyProgramlamaOdevi.Admin.DataAccessLayer
{
    public class SupplierDal
    {
        Supplier supplier = new Supplier();
        public void Add(Supplier supplier)
        {
            using (EcyContext context = new EcyContext())
            {
                context.Suppliers.Add(supplier);
                context.SaveChanges();
            }
        }
    }
}