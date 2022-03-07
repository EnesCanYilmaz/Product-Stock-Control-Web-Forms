using OrtaDuzeyProgramlamaOdevi.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrtaDuzeyProgramlamaOdevi.Categ
{
    public partial class ListCateg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCategories();
            }
        }

        private void LoadCategories()
        {
            using (EcyContext context = new EcyContext())
            {
                var categories = context.Categories.ToList();
                CategoryListView.DataSource = categories;
                CategoryListView.DataBind();
            }
        }
    }
}