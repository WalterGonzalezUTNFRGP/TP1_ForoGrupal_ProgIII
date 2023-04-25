<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3a.aspx.cs" Inherits="TPN4.Ejercicio3a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Label ID="lblSeleccionar" runat="server" Text="Seleccionar Tema:"></asp:Label>
&nbsp;
            <asp:DropDownList ID="ddlTemas" runat="server">
                <asp:ListItem>Tema 1</asp:ListItem>
                <asp:ListItem>Tema 2</asp:ListItem>
                <asp:ListItem>Tema 3</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:LinkButton ID="lbVerLibros" runat="server">Ver Libros</asp:LinkButton>
        </div>
    </form>
</body>
</html>
