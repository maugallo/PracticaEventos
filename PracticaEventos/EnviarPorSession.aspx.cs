using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaEventos
{
    public partial class EnviarInfo2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enviar(object sender, EventArgs e)
        {
            string nombre = inputNombre.Text;

            Session.Add("nombre", nombre);

            Response.Redirect("Default.aspx", false);
        }
    }
}