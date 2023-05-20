<%@ Page Title="Enviar Info" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EnviarPorURL.aspx.cs" Inherits="PracticaEventos.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="text-center my-3">Enviar información por URL al Default del sitio:</h2>
    <h2 class="text-center my-3">No disponible, utilizando la de sessions</h2>
    <h3 class="text-center my-3">Método 1:</h3>
    <div class="row">
        <div class="col-md-5"></div>
        <div class="col-md-3">
            <div class="form-group my-2">
                <asp:Label CssClass="mx-2" ID="labelNombre" for="inputNombre" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="inputNombre" runat="server" Placeholder="Ingrese su nombre"></asp:TextBox>
            </div>
            <div class="my-2">
                <asp:Button ID="input" runat="server" OnClick="Enviar" Text="Enviar" />
            </div>
        </div>
        <div class="col-md-3"></div>
    </div>
    <h3 class="text-center my-3">Método 2:</h3>
    <div class="text-center">
        <a class="fs-5" href="Default?nombre=Octavio">Link</a>
    </div>
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4 mt-2">
            <p class="lead">
                ¿Cuál es el problema de enviar información a través de la URL? Que no está protegida,
            y que cualquiera puede acceder a esta colocándola directamente en la url. Por eso hay
            otras formas de enviar información, como las sessions.
            </p>
        </div>
        <div class="col-md-4"></div>
    </div>


</asp:Content>
