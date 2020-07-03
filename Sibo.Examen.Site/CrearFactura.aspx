<%@ Page Title="" Language="C#" MasterPageFile="~/examen.Master" AutoEventWireup="true" CodeBehind="CrearFactura.aspx.cs" Inherits="Sibo.Examen.Site.CrearFactura" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="sm" runat="server"></asp:ScriptManager>
    <div id="container">

        <div id="left">
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
            <asp:Button ID="btnBuscarCliente" CssClass="btn" runat="server" Text="Buscar Cliente" OnClick="btnBuscarCliente_Click" />
            <asp:Button ID="btnCrearCliente" CssClass="btn" OnClick="btnCrearCliente_Click" Visible="false" runat="server" Text="Crear Cliente" />
        </div>
        <div id="middle">
            Random Content
            <asp:GridView ID="dgProducto" OnRowCommand="dgProducto_RowCommand" DataSourceID="odProductos" runat="server" DataKeyNames="ProductID" AllowPaging="True" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="ProductID" HeaderText="ProductID"
                        InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
                    <asp:BoundField DataField="Name" HeaderText="Name"
                        SortExpression="Name" />
                    <asp:BoundField DataField="Price" HeaderText="Price"
                        SortExpression="Price" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity"
                        SortExpression="Quantity" />
                    <asp:BoundField DataField="PercentDiscount" HeaderText="PercentDiscount"
                        SortExpression="PercentDiscount" />
                    <asp:TemplateField HeaderText="Agregar Cantidad">
                        <ItemTemplate>
                            <asp:Button ID="btnAgregar" runat="server" CommandName="agregarCantidad" />

                        </ItemTemplate>


                    </asp:TemplateField>

                </Columns>

            </asp:GridView>
            <asp:Panel ID="pnProductos" class="modalPopup" runat="server">
                <div id="headerDiv" class="header"></div>
                <div id="divDetails"></div>
                <div id="footerdiv" class="footer">
                    <asp:Button ID="btnGuardar" class="button" runat="server" Text="guardar" />
                    <asp:Button id="btnClose" class="button" runat="server" Text="X"/>
                </div>

            </asp:Panel>


        </div>
        <div id="right">Right Side Menu</div>
    </div>
    <ajaxToolkit:ModalPopupExtender ID="mpePopUp" runat="server" TargetControlID="dgProducto" PopupControlID="pnProductos" ></ajaxToolkit:ModalPopupExtender>

    <asp:ObjectDataSource ID="odProductos" runat="server" SelectMethod="Get" TypeName="Sibo.Examen.BLL.ProductBLL"></asp:ObjectDataSource>
</asp:Content>
