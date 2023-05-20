<%@ Page Title="Enviar Info" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EnviarPorSession.aspx.cs" Inherits="PracticaEventos.EnviarInfo2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="text-center my-3">Enviar información por Sessions al Default del sitio:</h2>
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4">
            <div class="form-group my-2">
                <asp:Label CssClass="mx-2" ID="labelNombre" for="inputNombre" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="inputNombre" runat="server" Placeholder="Ingrese su nombre"></asp:TextBox>
            </div>
            <div class="my-2">
                <asp:Button ID="input" runat="server" OnClick="Enviar" Text="Enviar" />
            </div>
        </div>
        <div class="col-md-4"></div>
    </div>
        <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4 mt-2">
            <p class="lead">
                En este caso, la información no se verá comprometida a través de la URL. 
            </p>
            <p class="lead">
                A diferencia del envío de información por URL, en este caso las sesiones duran hasta
                que la página se cierre, si simplemente se reinicia la página, la información seguirá almacenada.</p>
        </div>
        <div class="col-md-4"></div>
    </div>
</asp:Content>
