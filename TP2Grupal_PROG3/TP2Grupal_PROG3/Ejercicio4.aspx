<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio4.aspx.cs" Inherits="TP2Grupal_PROG3.Ejercicio4" %>

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
            <asp:Label ID="lblUsuario" runat="server" Text="Usuario: "></asp:Label>
&nbsp;<asp:TextBox ID="txtUsuario" runat="server" AutoCompleteType="Disabled" Width="164px"></asp:TextBox>
            <asp:Label ID="lblPrueba" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblClave" runat="server" Text="Clave: "></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtClave" runat="server" Width="165px" TextMode="Password"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnValidar" runat="server" Text="Validar" OnClick="btnValidar_Click" style="height: 26px" />
        </div>
    </form>
</body>
</html>
