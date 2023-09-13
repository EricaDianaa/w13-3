using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace w13_3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nome = ConfigurationManager.AppSettings["nome"];
            string password = ConfigurationManager.AppSettings["password"];


            if (nome == Nome.Text && password == Password.Text)
            {
                FormsAuthentication.SetAuthCookie(Nome.Text, false);
                Response.Redirect(FormsAuthentication.DefaultUrl);
            }
        }
    }
}