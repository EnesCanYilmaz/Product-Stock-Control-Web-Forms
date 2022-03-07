using OrtaDuzeyProgramlamaOdevi.Contexts;
using OrtaDuzeyProgramlamaOdevi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrtaDuzeyProgramlamaOdevi.Admin.DataAccessLayer
{
    public class CategoryDal
    {
        Category category = new Category();
        public void Add(Category category)
        {
            using (EcyContext context = new EcyContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }
    }
}