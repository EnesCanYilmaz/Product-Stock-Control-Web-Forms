using OrtaDuzeyProgramlamaOdevi.Contexts;
using OrtaDuzeyProgramlamaOdevi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrtaDuzeyProgramlamaOdevi.Admin
{
    public class ProductDal
    {
        Product product = new Product();
        public void Add(Product product)
        {
            using (EcyContext context = new EcyContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}