using OrtaDuzeyProgramlamaOdevi.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrtaDuzeyProgramlamaOdevi.Admin
{
    public partial class ListSupplierAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            if (IsPostBack)
            {
                string keyword = TextBox1.Text.Trim();
                string url = string.Format("../Admin/ListSupplierAdmin.aspx?keyword={0}", keyword);
                Response.Redirect(url);
            }
            else
            {

            };
            if (Request.QueryString["keyword"] != null)
            {
                string keyword = Request.QueryString["keyword"].ToString();
                SearchSupplier(keyword);
            }
            else
            {

            };
        }
        private void LoadSuppliers()
        {
            using (EcyContext db = new EcyContext())
            {
                var suppliers = db.Suppliers.OrderBy(i => i.CompanyName).ToList();
                SupplierListView.DataSource = suppliers;
                SupplierListView.DataBind();
            }
        }
        public void SearchSupplier(string keyword)
        {
            using (EcyContext context = new EcyContext())
            {
                var suppliers = (from x in context.Suppliers
                                where x.CompanyName.Contains(keyword)
                                select x).ToList();
                SupplierListView.DataSource = suppliers;
                SupplierListView.DataBind();
            }
        }
    }
    
}