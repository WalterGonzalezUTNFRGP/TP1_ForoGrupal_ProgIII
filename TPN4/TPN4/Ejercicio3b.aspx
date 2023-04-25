<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3b.aspx.cs" Inherits="TPN4.Ejercicio3b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTexto" runat="server" Font-Bold="True" Font-Size="Large" Text="Listado de Libros:"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="grdVConsultaLibros" runat="server">
            </asp:GridView>
            <br />
            <br />
            <br />
            <asp:LinkButton ID="lnkBOtraConsulta" runat="server">Consuitar otro tema</asp:LinkButton>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
