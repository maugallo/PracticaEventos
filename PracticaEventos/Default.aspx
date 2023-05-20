<%@ Page Title="Default" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PracticaEventos._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <% if (User != null)
        { %>

    <h1 class="text-center">¡Tienes nombre!</h1>
    <div class="m-2 text-center">
        <asp:Label CssClass="display-2" ID="LabelBienvenida" runat="server" Text=""></asp:Label>
    </div>
    <div class="text-center">
        <asp:Button ID="Button1" runat="server" OnClick="Salir" Text="Salir" />
    </div>
    <%}
        else
        { %>

    <div class="text-center">
        <h1>No tienes nombre</h1>
        <h2>Para tener nombre, ingrésalo <a runat="server" href="~/EnviarPorSession.aspx">aquí</a>.</h2>
    </div>
    <div class="m-2 text-center">
        <asp:Label CssClass="display-2" ID="Label1" runat="server" Text=""></asp:Label>
    </div>

    <%} %>

    
</asp:Content>
