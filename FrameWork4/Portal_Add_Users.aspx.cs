using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrameWork4
{
    public partial class Portal_Add_Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sessionID"] == null)
            {
                Response.Redirect("Login.aspx");  // Sin Logeo Dirigido a Login
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            var resultadoSQL = FrameWork4.Portal_Add_User.PortalAddUser(TextBoxEmail.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text,isAdmin.Checked,isEnable.Checked);




            if (resultadoSQL > 0)
            {

                mensajederesultado.Text = "Usuario dado de alta correctamente ";
                mensajederesultado.Visible = true;

           
            }
            else
            {
                mensajederesultado.Text = "No se dio de alta al forro del usuario";
                mensajederesultado.Visible = true;


          //      Response.Redirect("Default.aspx");  // Acceso Concedido

            }
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("MiPerfilAdmin.aspx");
        }

        protected void ButtonToDefault_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}