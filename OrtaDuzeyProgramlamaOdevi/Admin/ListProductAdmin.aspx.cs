using OrtaDuzeyProgramlamaOdevi.Contexts;
using OrtaDuzeyProgramlamaOdevi.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrtaDuzeyProgramlamaOdevi.Admin
{
    public partial class ListProductAdmin : System.Web.UI.Page
    {

        public void Page_Load(object sender, EventArgs e)
        {
            LoadProducts();
            if (IsPostBack)
            {
                string keyword = TextBox1.Text.Trim();
                string url = string.Format("../Admin/ListProductAdmin.aspx?keyword={0}", keyword);
                Response.Redirect(url);
            }
            else
            {

            };
            if (Request.QueryString["keyword"] != null)
            {
                string keyword = Request.QueryString["keyword"].ToString();
                SearchProducts(keyword);
            }
            else
            {

            };
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
        public void SearchProducts(string keyword)
        {
            using (EcyContext context = new EcyContext())
            {
                var products = (from x in context.Products
                                where x.ProductName.Contains(keyword)
                                select x).ToList();
                ProductListView.DataSource = products;
                ProductListView.DataBind();
            }
        }
    }
}