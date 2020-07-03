<%@ Page Title="" Language="C#" MasterPageFile="~/examen.Master" AutoEventWireup="true" CodeBehind="CrearFactura.aspx.cs" Inherits="Sibo.Examen.Site.CrearFactura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>hola mundo</h1>
    <div style="width:30%">
        <h2>Consultar o crear cliente</h2>
        <asp:Label ID="lblCedula" runat="server">Cedula</asp:Label>
        <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
        <hr />
        <asp:Label ID="lblNombre" runat="server">Nombre</asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <hr />
        <asp:Label ID="lblApellido" runat="server">Apellido</asp:Label>
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        <hr />
        <asp:Button ID="btnBuscarCliente"  runat="server" Text="Buscar Cliente" OnClick="btnBuscarCliente_Click" />
        <asp:Button ID="btnCrearCliente" OnClick="btnCrearCliente_Click" Visible="false" runat="server" Text="Crear Cliente" />
    </div>
    <div>


    </div>
</asp:Content>
