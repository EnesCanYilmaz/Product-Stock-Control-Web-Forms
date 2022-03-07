using OrtaDuzeyProgramlamaOdevi.Contexts;
using OrtaDuzeyProgramlamaOdevi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrtaDuzeyProgramlamaOdevi.Admin
{
    public partial class ProductAdmin : System.Web.UI.Page
    {
        ProductDal _productDal = new ProductDal();
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                ProductName = TextBox1.Text,
                UnitPrice = Convert.ToInt32(TextBox2.Text),
                UnitsInStock = Convert.ToInt32(TextBox3.Text),
            });
            Response.Redirect("../Admin/ListProductAdmin.aspx");
        }
    }
}