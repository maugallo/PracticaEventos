<%@ Page Title="GridView" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GridView.aspx.cs" Inherits="PracticaEventos.GridView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container my-3">
        <h1 class="text-center my-4">GridView con Todas las Columnas</h1>
        <asp:GridView CssClass="table table-bordered table-dark" ID="gridCliente" runat="server"></asp:GridView>
    </div>

    <div class="container my-3">
        <h1 class="text-center my-4">GridView con Columnas Seleccionadas</h1>
        <asp:GridView CssClass="table table-bordered table-dark" DataKeyNames="Id" OnSelectedIndexChanged="botonSeleccionar" OnRowEditing="botonEditar" OnRowDeleting="botonEliminar"  ID="gridCliente2" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                <asp:BoundField HeaderText="Edad" DataField="Edad" />
                <asp:CheckBoxField HeaderText="Vip" DataField="Vip" />
                <%-- Agregamos los botones para seleccionar, editar, eliminar: --%>
                <asp:CommandField ControlStyle-CssClass="text-white text-decoration-none" ShowSelectButton="true" SelectText="Seleccionar" ShowDeleteButton="true" DeleteText="Eliminar" ShowEditButton="true" EditText="Editar"
                    HeaderText="Acciones"/>
            </Columns>
        </asp:GridView>
        <a runat="server" href="~/FormCliente.aspx">Agregar Cliente</a>
    </div>

</asp:Content>
