<%@ Page Title="Form Cliente" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormCliente.aspx.cs" Inherits="PracticaEventos.FormCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-4"></div>
        <div class="col-4 border border-secondary rounded mt-3 text-center">
            <h2 class="mx-5 mt-2">Form Clientes</h2>
            <%-- Textbox para ID (No visible en la página de crear y modificar) --%>
            <div class="mb-2">
                <asp:Label ID="labelID" runat="server" Text="ID" CssClass="form-label" Visible="false"></asp:Label>
                <asp:TextBox required="true" runat="server" AutoPostBack="true" ID="txtID" Visible="false" CssClass="form-control border border-secondary rounded" Style="margin-left: 65px" />
            </div>
            <%-- Textbox para nombre --%>
            <div class="mb-2">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox required="true" runat="server" AutoPostBack="true" ID="txtNombre" CssClass="form-control border border-secondary rounded" Style="margin-left: 65px" />
            </div>
            <%-- textbox para apellido --%>
            <div class="mb-2">
                <label for="txtApellido" class="form-label">Apellido</label>
                <asp:TextBox required="true" runat="server" AutoPostBack="true" ID="txtApellido" CssClass="form-control border border-secondary rounded" Style="margin-left: 65px" />
            </div>
            <%-- Textbox numérico para edad --%>
            <div class="mb-2">
                <label for="txtEdad" class="form-label">Edad</label>
                <asp:TextBox required="true" runat="server" AutoPostBack="true" ID="txtEdad" TextMode="Number" CssClass="form-control border border-secondary rounded" Style="margin-left: 65px" />
            </div>
            <%-- DropdownList para país --%>
            <div class="mb-2">
                <label for="txtPais" class="form-label">País</label>
                <asp:DropDownList runat="server" AutoPostBack="true" ID="txtPais" CssClass="form-control border border-secondary rounded" Style="margin-left: 65px">
                </asp:DropDownList>
            </div>
            <%-- RadioButtons para el género (masculino/femenino) --%>
            <div class="mb-2">
                <label class="form-label container px-0">Género</label>
                <asp:RadioButton ID="txtMasculino" AutoPostBack="true" Text="Masculino" runat="server" GroupName="genero" Checked="true" CssClass="mx-2" />
                <asp:RadioButton ID="txtFemenino" AutoPostBack="true" Text="Femenino" runat="server" GroupName="genero" CssClass="mx-2" />
            </div>
            <%-- CheckBox para VIP --%>
            <div class="mb-2">
                <label for="txtVip" class="form-label">Cliente VIP</label>
                <asp:CheckBox Text="" runat="server" AutoPostBack="true" ID="txtVip" Checked="false" />
            </div>
            <%-- Button para enviar --%>
            <div class="mb-2 text">
                <asp:Button Text="Enviar" runat="server" OnClick="CargarDatos" ID="boton" CssClass="btn btn-dark" />
            </div>
        </div>
        <div class="col-4"></div>
    </div>
</asp:Content>
