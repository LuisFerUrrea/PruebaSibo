<%@ Page Title="" Language="C#" MasterPageFile="~/examen.Master" AutoEventWireup="true" CodeBehind="CrearFactura.aspx.cs" Inherits="Sibo.Examen.Site.CrearFactura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>hola mundo</h1>
    <div>
        <h2>Consultar o crear cliente</h2>
        <asp:Label ID="lblCedula" runat="server">Cedula</asp:Label>
        <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
        <asp:Label ID="lblNombre" runat="server">Nombre</asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <asp:Label ID="lblApellido" runat="server">Apellido</asp:Label>
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        <asp:Button ID="IdCrearCliente" runat="server" />
    </div>
    <div>


    </div>
</asp:Content>
