using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaEventos
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                inputNombre.Text = "Ingrese su nombre";
                inputApellido.Text = "Ingrese su apellido";
                inputEmail.Text = "Ingrese su email";
            }
        }

        protected void Click(object sender, EventArgs e)
        {
            labelSaludo.Text = $"¡Hola {inputNombre.Text} {inputApellido.Text}, con el email {inputEmail.Text}!";
        }

        protected void inputNombre_TextChanged(object sender, EventArgs e)
        {
            labelNombre.Text = "Ingresaste: " + inputNombre.Text;
        }

        protected void inputApellido_TextChanged(object sender, EventArgs e)
        {
            labelApellido.Text = "Ingresaste: " + inputApellido.Text;
        }

        protected void inputEmail_TextChanged(object sender, EventArgs e)
        {
            labelEmail.Text = "Ingresaste: " + inputEmail.Text;
        }
    }
}