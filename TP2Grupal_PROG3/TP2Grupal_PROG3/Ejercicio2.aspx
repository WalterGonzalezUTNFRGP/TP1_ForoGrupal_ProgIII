<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP2Grupal_PROG3.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblNombre" runat="server" Font-Size="Large" Text="Nombre :"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" AutoPostBack="True" BorderStyle="Solid" BorderWidth="1px" Height="16px" style="margin-left: 29px" Width="139px" BorderColor="#999999" OnTextChanged="txtNombre_TextChanged"></asp:TextBox>
            <asp:Image ID="imgNombre" runat="server" Height="18px" Visible="False" Width="18px" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblValidacionNombre" runat="server"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblApellido" runat="server" Font-Size="Large" Text="Apellido :"></asp:Label>
            <asp:TextBox ID="txtApellido" runat="server" AutoPostBack="True" BorderStyle="Solid" BorderWidth="1px" Height="16px" style="margin-left: 29px" Width="139px" BorderColor="#999999" OnTextChanged="txtApellido_TextChanged"></asp:TextBox>
            <asp:Image ID="imgApellido" runat="server" Height="18px" Visible="False" Width="18px" />
            <br />
            <asp:Label ID="lblValidacionApellido" runat="server"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblCiudad" runat="server" Font-Size="Large" Text="Ciudad :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlCiudades" runat="server" Height="17px" Width="144px">
                <asp:ListItem Value="Zona Norte">Gral. Pacheco</asp:ListItem>
                <asp:ListItem Value="Zona Oeste">San Miguel</asp:ListItem>
                <asp:ListItem Value="Zona Sur">Boedo</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblTema" runat="server" Font-Size="Large" Text="Temas :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;
            <br />
            <br />
            <asp:CheckBoxList ID="cbCiudades" runat="server" AppendDataBoundItems="True" AutoPostBack="True" BorderStyle="None" CellSpacing="1" EnableViewState="False" Height="99px" Width="114px" CausesValidation="True">
                <asp:ListItem>Ciencias</asp:ListItem>
                <asp:ListItem>Literatura</asp:ListItem>
                <asp:ListItem>Historia</asp:ListItem>
            </asp:CheckBoxList>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <div style="margin-left: 120px">
            <asp:Button ID="btnResumen" runat="server" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" style="margin-bottom: 0px" Text="Ver Resumen" Width="157px" OnClick="btnResumen_Click" />
        </div>
        <br />
    </form>
</body>
</html>
