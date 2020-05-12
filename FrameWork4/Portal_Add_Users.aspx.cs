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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            var resultadoEjecucionSQL = FrameWork4
                { 
            
            }


            var resultado = FrameWork4.AltaEmpleado.altaEmpleado(TxtNombre.Text.Trim(), TxtApellido.Text.Trim(), TxtCategoriaEmpleado.Text.Trim(),
                   TxtEmpleadoEstado.Text.Trim(), CalendarFechaIngreso.SelectedDate, CalendarFechaNacimiento.SelectedDate,
                   TxtCorreoElectronico.Text.Trim(), TxtTelefono.Text.Trim(), TxtNroCuil.Text.Trim(), TxtEmpleadoDomicilio.Text.Trim());
            if (resultado.Item1 > 0)
            {
                Msg_AltaEmpleado.Text = "No se dio de alta al forro del usuario";
                Msg_AltaEmpleado.Visible = true;


                Response.Redirect("ReporteConsultoria.aspx");  // Acceso Concedido
            }
            else
            {
                Msg_AltaEmpleado.Text = "Usuario dado de alta correctamente ";
                Msg_AltaEmpleado.Visible = true;

            }
        }
    }
}