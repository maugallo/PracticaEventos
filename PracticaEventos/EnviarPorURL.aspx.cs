using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaEventos
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enviar(object sender, EventArgs e)
        {
            // Envio el valor de la textbox inputNombre hacia la página "default".
            string nombre = inputNombre.Text;
            Response.Redirect("Default.aspx?nombre=" + nombre, false);
        }
    }
}