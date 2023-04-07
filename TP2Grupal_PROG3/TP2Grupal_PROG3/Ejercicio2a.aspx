<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2a.aspx.cs" Inherits="TP2Grupal_PROG3.Ejercicio2a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblResumen" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Overline="False" Font-Size="XX-Large" Font-Underline="False" ForeColor="Black" Text="Resumen"></asp:Label>
        </div>
        <p>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre :"></asp:Label>
            <asp:Label ID="lblNombreForm" runat="server" Font-Bold="True"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblApellido" runat="server" Text="Apellido : "></asp:Label>
            <asp:Label ID="lblApellidoForm" runat="server" Font-Bold="True"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblZona" runat="server" Text="Zona : "></asp:Label>
            <asp:Label ID="lblZonamostrar" runat="server" Font-Bold="True"></asp:Label>
        </p>
    </form>
</body>
</html>
