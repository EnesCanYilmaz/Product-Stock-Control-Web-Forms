using OrtaDuzeyProgramlamaOdevi.Admin.DataAccessLayer;
using OrtaDuzeyProgramlamaOdevi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrtaDuzeyProgramlamaOdevi.Admin
{
    public partial class CategoryAdmin : System.Web.UI.Page
    {
        CategoryDal _categoryDal= new CategoryDal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            _categoryDal.Add(new Category
            {
                CategoryName = TextBox1.Text
            });
            Response.Redirect("../Admin/ListCategoryAdmin.aspx");
        }
    }
}