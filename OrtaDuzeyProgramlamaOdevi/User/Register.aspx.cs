using OrtaDuzeyProgramlamaOdevi.Contexts;
using OrtaDuzeyProgramlamaOdevi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Login = OrtaDuzeyProgramlamaOdevi.Entities.Login;

namespace OrtaDuzeyProgramlamaOdevi.User
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EcyContext context = new EcyContext();
            Login table = new Login();
            table.UserName = TextBox1.Text;
            table.Password = TextBox2.Text;
            context.Logins.Add(table);
            context.SaveChanges();
            Response.Redirect("../Sup/ListSup.aspx");
        }
    }
}