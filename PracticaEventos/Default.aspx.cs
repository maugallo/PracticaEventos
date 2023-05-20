using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaEventos
{
    public partial class _Default : Page
    {
        private string user;
        
        public string User
        {
            get { return user; } set { user = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            // Cada vez que la página se cargue, capturo la información que la página
            // "EnviarInfo" me mandó. (Verifico que la información no sea nula):
            if (Session["nombre"] != null)
            {
                User = Session["nombre"].ToString();
                LabelBienvenida.Text = $"¡Bienvenido al inicio, {user}!";
            }
            else
            {
                LabelBienvenida.Text = "¡Bienvenido al inicio, anónimo!";
            }
        }

        protected void Salir(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Default.aspx", false);
        }
    }
}