<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP2Grupal_PROG3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="LBLproducto1" runat="server" Text="Ingrese nombre del Producto:"></asp:Label>
            <asp:TextBox ID="TXTproducto1" runat="server"></asp:TextBox>
            <asp:Label ID="LBLcantidad1" runat="server" Text="Cantidad:"></asp:Label>
            <asp:TextBox ID="TXTcantidad1" runat="server" AutoPostBack="True" OnTextChanged="TXTcantidad1_TextChanged" TextMode="Number" Width="162px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="LBLproducto2" runat="server" Text="Ingrese nombre del Producto:"></asp:Label>
            <asp:TextBox ID="TXTproducto2" runat="server"></asp:TextBox>
            <asp:Label ID="LBLcantidad2" runat="server" Text="Cantidad:"></asp:Label>
            <asp:TextBox ID="TXTcantidad2" runat="server" AutoPostBack="True" OnTextChanged="TXTcantidad2_TextChanged" TextMode="Number"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="BTNgenerar" runat="server" OnClick="BTNgenerar_Click" style="height: 26px" Text="Generar Tabla" />
        &nbsp;&nbsp;
            <asp:Label ID="lblVerificacion" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="LBLtabla" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
