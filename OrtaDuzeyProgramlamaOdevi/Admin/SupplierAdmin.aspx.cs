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
    public partial class SupplierAdmin : System.Web.UI.Page
    {
        SupplierDal _supplierDal = new SupplierDal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            _supplierDal.Add(new Supplier
            {
                CompanyName = TextBox1.Text,
                ContactName= TextBox2.Text,
                City = TextBox3.Text,
                Phone = TextBox4.Text
            });
            Response.Write("OK");
            Response.Redirect("../Admin/ListSupplierAdmin.aspx");
        }
    }
}