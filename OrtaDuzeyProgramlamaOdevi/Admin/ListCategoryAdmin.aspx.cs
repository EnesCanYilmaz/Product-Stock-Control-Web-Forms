using OrtaDuzeyProgramlamaOdevi.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrtaDuzeyProgramlamaOdevi.Admin
{
    public partial class ListCategoryAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCategories();
            if (IsPostBack)
            {
                string keyword = TextBox1.Text.Trim();
                string url = string.Format("../Admin/ListCategoryAdmin.aspx?keyword={0}", keyword);
                Response.Redirect(url);
            }
            else
            {

            };
            
            if (Request.QueryString["keyword"] != null)
            {
                string keyword = Request.QueryString["keyword"].ToString();
                SearchCategories(keyword);
            }
            else
            {

            };
        }
        public void SearchCategories(string keyword)
        {
            using (EcyContext context = new EcyContext())
            {
                var categories = (from x in context.Categories
                                where x.CategoryName.Contains(keyword)
                                select x).ToList();
                CategoryListView.DataSource = categories;
                CategoryListView.DataBind();
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