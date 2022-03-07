using OrtaDuzeyProgramlamaOdevi.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrtaDuzeyProgramlamaOdevi.Pro
{
    public partial class ListPro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProducts();
            }
        }

        private void LoadProducts()
        {
            using (EcyContext context = new EcyContext())
            {
                var products = context.Products.OrderBy(i => i.ProductId).ToList();
                ProductListView.DataSource = products;
                ProductListView.DataBind();
            }
        }
    }
}