using OrtaDuzeyProgramlamaOdevi.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrtaDuzeyProgramlamaOdevi.Sup
{
    public partial class ListSup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSuppliers();
            }
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
    }
}