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
            &nbsp;<asp:TextBox ID="txtNombre" runat="server" AutoPostBack="True" BorderStyle="Solid" BorderWidth="1px" Height="16px" style="margin-left: 29px" Width="139px" BorderColor="#999999" OnTextChanged="txtNombre_TextChanged" AutoCompleteType="Disabled"></asp:TextBox>
            <asp:Image ID="imgNombre" runat="server" Height="18px" Visible="False" Width="18px" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblValidacionNombre" runat="server" ForeColor="Black"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblApellido" runat="server" Font-Size="Large" Text="Apellido :"></asp:Label>
            <asp:TextBox ID="txtApellido" runat="server" AutoPostBack="True" BorderStyle="Solid" BorderWidth="1px" Height="16px" style="margin-left: 29px" Width="139px" BorderColor="#999999" OnTextChanged="txtApellido_TextChanged" AutoCompleteType="Disabled"></asp:TextBox>
            <asp:Image ID="imgApellido" runat="server" Height="18px" Visible="False" Width="18px" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblValidacionApellido" runat="server"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblCiudad" runat="server" Font-Size="Large" Text="Ciudad :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlCiudades" runat="server" Height="17px" Width="144px">
                <asp:ListItem Value="Norte">Gral. Pacheco</asp:ListItem>
                <asp:ListItem Value="Oeste">San Miguel</asp:ListItem>
                <asp:ListItem Value="Sur">Boedo</asp:ListItem>
            </asp:DropDownList>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblTema" runat="server" Font-Size="Large" Text="Temas :"></asp:Label>
            <br />
            <br />
&nbsp;<asp:Label ID="lblValidacionChBL" runat="server"></asp:Label>
            <asp:Image ID="imgValidacionChBL" runat="server" Height="18px" Visible="False" Width="18px" />
            &nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;
            <br />
            <br />
            <asp:CheckBoxList ID="cbTemas" runat="server" AutoPostBack="True" BorderStyle="None" CellSpacing="1" Height="99px" Width="114px" ViewStateMode="Enabled" EnableTheming="False" OnSelectedIndexChanged="cbTemas_SelectedIndexChanged">
               <asp:ListItem Text="Ciencias" Value="1" />
               <asp:ListItem Text="Literatura" Value="2" />
               <asp:ListItem Text="Historia" Value="3" />
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
