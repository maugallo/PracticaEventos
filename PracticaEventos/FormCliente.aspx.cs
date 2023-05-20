using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Domain;

namespace PracticaEventos
{
    public partial class FormCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Configurar DropDownList para cada vez que se cargue la página:
            if (!IsPostBack)
            {
                txtPais.Items.Add("Argentina");
                txtPais.Items.Add("Chile");
                txtPais.Items.Add("Perú");
                txtPais.Items.Add("Colombia");
                txtPais.Items.Add("Bolivia");
                txtPais.Items.Add("Ecuador");
                txtPais.Items.Add("México");
            }
            //Creo una session para las ID, así puedo sumar el ID en 1 cada vez que se agregue una nueva:
            if (Session["id"] == null)
            {
                Session.Add("id", 3);
            }
            //Capturo el valor que me envió la página GridView.aspx por url:
            if (Request.QueryString["id"] != null)
            {
                //Extraigo el id que pasé por url desde GridView.aspx:
                int id = int.Parse(Request.QueryString["id"].ToString());
                //Busco el objeto que quiero mediante Find(), donde se encuentra el elemento x.Id que tenga el mismo
                //valor que el id que guardé anteriormente en "int id":
                Cliente clienteSeleccionado = ((List<Cliente>)Session["listaClientes"]).Find(x => x.Id == id);
                //Una vez encontrado, ahora determino el segundo parámetro que pasé por url desde la página GridView.aspx:
                if (Request.QueryString["accion"] == "seleccionar")
                {
                    //Si es "seleccionar" muestro el form de esta manera, para que solo lo pueda ver en detalle:
                    txtNombre.Text = clienteSeleccionado.Nombre;
                    txtNombre.ReadOnly = true;
                    txtApellido.Text = clienteSeleccionado.Apellido;
                    txtApellido.ReadOnly = true;
                    txtEdad.Text = clienteSeleccionado.Edad.ToString();
                    txtEdad.ReadOnly = true;
                    txtPais.Text = clienteSeleccionado.Pais;
                    txtPais.Enabled = false;
                    _ = clienteSeleccionado.Genero == "Masculino" ? txtMasculino.Checked = true : txtFemenino.Checked = true;
                    txtMasculino.Enabled = false;
                    txtFemenino.Enabled = false;
                    _ = clienteSeleccionado.Vip == true ? txtVip.Checked = true : txtVip.Checked = false;
                    txtVip.Enabled = false;
                    labelID.Visible = true;
                    txtID.Visible = true;
                    txtID.Text = clienteSeleccionado.Id.ToString();
                    txtID.ReadOnly = true;
                    boton.Visible = false;
                }
                else if (Request.QueryString["accion"] == "editar")
                {
                    //Si es "editar" muestro el form de manera tal que se puedan editar los textbox,
                    //IMPORTANTE: Validar si hay o no postback, de esta manera puedo modificar los textbox, de lo
                    //contrario me van a volver a cambiar al valor predeterminado.
                    if (!IsPostBack)
                    {
                        txtNombre.Text = clienteSeleccionado.Nombre;
                        txtApellido.Text = clienteSeleccionado.Apellido;
                        txtEdad.Text = clienteSeleccionado.Edad.ToString();
                        txtPais.Text = clienteSeleccionado.Pais;
                        _ = clienteSeleccionado.Genero == "Masculino" ? txtMasculino.Checked = true : txtFemenino.Checked = true;
                        _ = clienteSeleccionado.Vip == true ? txtVip.Checked = true : txtVip.Checked = false;
                        boton.Text = "Modificar";
                    }

                }
                else if (Request.QueryString["accion"] == "eliminar")
                {
                    //Si es "eliminar" muestro el form de la misma manera que "seleccionar", con la diferencia de
                    //que está el botón "eliminar" al final del form.
                    //IMPORTANTE: Uso un try-catch por si el usuario quiere volver hacia atrás una vez que ya eliminó
                    //el form. En ese caso, para que no de null lo reenvío hacia la página de la GridView.
                    try
                    {
                        txtNombre.Text = clienteSeleccionado.Nombre;
                        txtNombre.ReadOnly = true;
                        txtApellido.Text = clienteSeleccionado.Apellido;
                        txtApellido.ReadOnly = true;
                        txtEdad.Text = clienteSeleccionado.Edad.ToString();
                        txtEdad.ReadOnly = true;
                        txtPais.Text = clienteSeleccionado.Pais;
                        txtPais.Enabled = false;
                        _ = clienteSeleccionado.Genero == "Masculino" ? txtMasculino.Checked = true : txtFemenino.Checked = true;
                        txtMasculino.Enabled = false;
                        txtFemenino.Enabled = false;
                        _ = clienteSeleccionado.Vip == true ? txtVip.Checked = true : txtVip.Checked = false;
                        txtVip.Enabled = false;
                        txtID.Visible = true;
                        labelID.Visible = true;
                        txtID.Text = clienteSeleccionado.Id.ToString();
                        txtID.ReadOnly = true;
                        boton.Text = "Eliminar";
                    }
                    catch (NullReferenceException)
                    {
                        Response.Redirect("GridView.aspx");
                    }
                }
            }
        }

        protected void CargarDatos(object sender, EventArgs e)
        {
            //Al presionar el botón del form, dependiendo el valor que tenga el botón en ese momento se van a cumplir
            //distintas funciones:
            if (boton.Text == "Enviar")
            {
                //Con "enviar", significa que se creará un form nuevo:
                // Al presionar en el boton aceptar, pasamos los valores del form a datos:
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                //Al ser el atributo edad de tipo int, hay que hacer castear el valor a int:
                int edad = int.Parse(txtEdad.Text);
                string pais = txtPais.SelectedValue;
                //Hacemos un IF acortado, si el RadioButton masculino está checked el valor es masculino, sino femenino:
                string genero = txtMasculino.Checked ? "Masculino" : "Femenino";
                //Si la ChekBox está checked el valor es true, sino es false:
                bool vip = txtVip.Checked;
                DateTime fecha = DateTime.Now;
                // Creamos y cargamos los valores en el objeto:
                Cliente cliente = new Cliente(int.Parse(Session["id"].ToString()), nombre, apellido, edad, pais, genero, vip, fecha);
                // Envío la información hacia la Session para que se muestre en las GridView:
                // Como la Session, ahora mismo es un objeto de tipo Session, voy a hacerle un casteo explícito,
                // Para que se transforme en el objeto que alberga: una lista de objetos de tipo "Cliente".
                ((List<Cliente>)Session["listaClientes"]).Add(cliente);
                //Antes de terminar, sumo un valor más al ID así no queda el mismo:
                Session["id"] = int.Parse(Session["id"].ToString()) + 1;
                // Finalmente, y después de agregar el objeto a la lista, redirecciono:
                Response.Redirect("GridView.aspx", false);
            }
            else if (boton.Text == "Modificar")
            {
                //Con "modificar",significa que se mostrará el form con los datos que pasé con la id por url: 
                //Para eso, como hice anteriormente capturo la id que envié por url desde GridView.aspx:
                int id = int.Parse(Request.QueryString["id"].ToString());
                //Busco el elemento que tenga la misma Id que el id que capturé en "int id":
                Cliente clienteSeleccionado = ((List<Cliente>)Session["listaClientes"]).Find(x => x.Id == id);
                //Averiguo el index del objeto así lo modifico:
                int index = ((List<Cliente>)Session["listaClientes"]).FindIndex(x => x.Id == id);
                // Pasamos los valores del form a datos:
                string nombre = txtNombre.Text;
                clienteSeleccionado.Nombre = nombre;
                string apellido = txtApellido.Text;
                clienteSeleccionado.Apellido = apellido;
                int edad = int.Parse(txtEdad.Text);
                clienteSeleccionado.Edad = edad;
                string pais = txtPais.SelectedValue;
                clienteSeleccionado.Pais = pais;
                string genero = txtMasculino.Checked ? "Masculino" : "Femenino";
                clienteSeleccionado.Genero = genero;
                bool vip = txtVip.Checked;
                clienteSeleccionado.Vip = vip;
                //Modifico el cliente de la Session mediante su index:
                ((List<Cliente>)Session["listaClientes"])[index] = clienteSeleccionado;
                Response.Redirect("GridView.aspx", false);

            }
            else if (boton.Text == "Eliminar")
            {
                //Con "eliminar", significa que se eliminará el cliente del id que pasé por url:
                //Capturo el id:
                int id = int.Parse(Request.QueryString["id"].ToString());
                //Encuentro al cliente:
                Cliente clienteSeleccionado = ((List<Cliente>)Session["listaClientes"]).Find(x => x.Id == id);
                //Al encontrarlo, lo elimino:
                ((List<Cliente>)Session["listaClientes"]).Remove(clienteSeleccionado);
                Response.Redirect("GridView.aspx", false);
            }
        }


    }
}