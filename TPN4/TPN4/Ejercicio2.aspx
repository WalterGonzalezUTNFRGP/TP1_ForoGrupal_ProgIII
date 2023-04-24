<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TPN4.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 37px;
        }
        .auto-style2 {
            margin-left: 41px;
        }
        .auto-style3 {
            margin-left: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblProducto" runat="server" Text="IdProducto:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlProductos" runat="server">
            <asp:ListItem Value="=">Igual a:</asp:ListItem>
            <asp:ListItem Value="&gt;">Mayor a:</asp:ListItem>
            <asp:ListItem Value="&lt;">Menor a:</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:TextBox ID="txtIdProducto" runat="server" CssClass="auto-style1" Width="304px" TextMode="Number" AutoPostBack="True" OnTextChanged="txtIdProducto_TextChanged1"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Label ID="lblValidacionIDProducto" runat="server" ForeColor="Red"></asp:Label>
&nbsp;<p>
            <asp:Label ID="lblCategoria" runat="server" Text="IdCategoria:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlCategoria" runat="server">
                <asp:ListItem Value="=">Igual a:</asp:ListItem>
                <asp:ListItem Value="&gt;">Mayor a:</asp:ListItem>
                <asp:ListItem Value="&lt;">Menor a:</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="TxtIdCategoria" runat="server" CssClass="auto-style2" Width="304px" TextMode="Number" AutoPostBack="True" OnTextChanged="TxtIdCategoria_TextChanged1"></asp:TextBox>
        &nbsp;&nbsp;
            <asp:Label ID="lblValidacionIDCategoria" runat="server" ForeColor="Red"></asp:Label>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFiltrar" runat="server" OnClick="btnFiltrar_Click" Text="Filtrar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnQuitarTodo" runat="server" OnClick="btnQuitarTodo_Click" Text="Quitar Todo" ViewStateMode="Enabled" />
        </p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
        <asp:GridView ID="grdProductos" runat="server" CssClass="auto-style3" Width="672px">
        </asp:GridView>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
    </form>
</body>
</html>
