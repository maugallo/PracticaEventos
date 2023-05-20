<%@ Page Title="PostBack" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PostBack.aspx.cs" Inherits="PracticaEventos.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="text-center my-3">Práctica con postback:</h2>
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4">
            <div class="form-group my-2">
                <asp:TextBox CssClass="form-control" AutoPostBack="true" ID="inputNombre" runat="server" OnTextChanged="inputNombre_TextChanged"></asp:TextBox>
                <asp:Label CssClass="mx-2 text-secondary" ID="labelNombre" for="inputNombre" runat="server" Text=" "></asp:Label>
            </div>
            <div class="form-group my-2">
                <asp:TextBox CssClass="form-control" AutoPostBack="true" ID="inputApellido" runat="server" OnTextChanged="inputApellido_TextChanged"></asp:TextBox>
                <asp:Label CssClass="mx-2 text-secondary" ID="labelApellido" for="inputApellido" runat="server" Text=" "></asp:Label>
            </div>
            <div class="form-group my-2">
                <asp:TextBox CssClass="form-control" AutoPostBack="true" ID="inputEmail" runat="server" OnTextChanged="inputEmail_TextChanged"></asp:TextBox>
                <asp:Label CssClass="mx-2 text-secondary" ID="labelEmail" for="inputEmail" runat="server" Text=" "></asp:Label>
            </div>
            <div>
                <asp:Label ID="labelSaludo" runat="server" Text=""></asp:Label>
            </div>
            <div class="my-2">
                <asp:Button ID="input" runat="server" OnClick="Click" Text="Aceptar" />
            </div>
        </div>
        <div class="col-md-4"></div>
    </div>
</asp:Content>
