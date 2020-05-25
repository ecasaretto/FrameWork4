using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrameWork4
{

    public partial class MiPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sessionID"] == null)
            {
                Response.Redirect("Login.aspx");  // Sin Logeo Dirigido a Login
            }
            else
            {              
            email.Text = Session["username"].ToString();
           var resultadoSql =FrameWork4.MiPerfil.miPerfil(email.Text);
            firstName.Text= resultadoSql.Item2.ToString();
            lastName.Text = resultadoSql.Item3.ToString();
            lastLogin.Text = resultadoSql.Item4.ToString();
            lastChangePassword.Text = resultadoSql.Item4.ToString();
            isAdmin.Text = resultadoSql.Item6.ToString();
             

            }
        }


    }
    }
