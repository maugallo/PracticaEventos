using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Domain;
using Microsoft.AspNet.FriendlyUrls;

namespace PracticaEventos
{
    public partial class GridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Crear y cargar los datos del proyecto "Domain" en la GridView:
            if (Session["listaClientes"] == null)
            {
                ClienteNegocio listaClientes = new ClienteNegocio();
                Session.Add("listaClientes", listaClientes.MockUp());
            }
            //Cargo los datos en la grilla que va a mostrar todas las columnas:
            gridCliente.DataSource = Session["listaClientes"];
            //Cargo los datos en la grilla que va a mostrar columnas seleccionadas:
            gridCliente2.DataSource = Session["listaClientes"];
            //Finalmente, con este método "rendereo" los datos en las grillas:
            gridCliente.DataBind();
            gridCliente2.DataBind();
        }

        protected void botonSeleccionar(object sender, EventArgs e)
        {
            string id = gridCliente2.SelectedDataKey.Value.ToString();
            string accion = "seleccionar";
            //Enviamos ambos valores mediante url:
            Response.Redirect("FormCliente.aspx?id=" + id+ "&accion=" + accion);
        }

        protected void botonEditar(object sender, GridViewEditEventArgs e)
        {
            string id = gridCliente2.DataKeys[e.NewEditIndex].Value.ToString();
            string accion = "editar";
            //Enviamos ambos valores mediante url:
            Response.Redirect("FormCliente.aspx?id=" + id + "&accion=" + accion);
        }

        protected void botonEliminar(object sender, GridViewDeleteEventArgs e)
        {
            string id = gridCliente2.DataKeys[e.RowIndex].Value.ToString();
            string accion = "eliminar";
            //Enviamos ambos valores mediante url:
            Response.Redirect("FormCliente.aspx?id=" + id + "&accion=" + accion);
        }
    }
}