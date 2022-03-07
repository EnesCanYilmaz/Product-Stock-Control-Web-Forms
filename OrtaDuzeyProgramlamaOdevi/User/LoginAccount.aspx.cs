using OrtaDuzeyProgramlamaOdevi.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrtaDuzeyProgramlamaOdevi.User
{
    public partial class LoginAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            using (EcyContext context = new EcyContext())
            {
                var query = from x in context.Logins where x.UserName == TextBox1.Text && x.Password == TextBox2.Text select x;
                if (query.Any())
                {
                    Response.Redirect("../Sup/ListSup.aspx");
                }
                else
                {
                    Response.Write("Kullanıcı adı veya şifre yanlış.");
                }
            }
        }
    }
}