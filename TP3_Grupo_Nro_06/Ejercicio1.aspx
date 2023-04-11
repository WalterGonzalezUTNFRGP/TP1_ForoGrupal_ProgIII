<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP3_Grupo_Nro_06.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 551px;
            width: 612px;
        }
        .auto-style4 {
            width: 96%;
            height: 185px;
        }
        .auto-style7 {
            width: 96%;
            height: 90px;
        }
        .auto-style8 {
            width: 209px;
            height: 64px;
        }
        .auto-style10 {
            height: 64px;
        }
        .auto-style11 {
            width: 211px;
        }
        .auto-style12 {
            width: 206px;
        }
        .auto-style13 {
            width: 212px;
        }
        .auto-style14 {
            width: 96%;
            height: 104px;
        }
        .auto-style16 {
            width: 206px;
            height: 60px;
        }
        .auto-style19 {
            width: 96%;
            height: 131px;
            margin-top: 0px;
        }
        .auto-style20 {
            width: 207px;
        }
        .auto-style21 {
            width: 207px;
            height: 56px;
        }
        .auto-style22 {
            width: 211px;
            height: 56px;
        }
        .auto-style23 {
            height: 56px;
        }
        .auto-style24 {
            width: 207px;
            height: 34px;
        }
        .auto-style25 {
            width: 211px;
            height: 34px;
        }
        .auto-style26 {
            height: 34px;
        }
        .auto-style27 {
            width: 211px;
            height: 60px;
        }
        .auto-style28 {
            height: 60px;
        }
        .auto-style29 {
            width: 206px;
            height: 33px;
        }
        .auto-style30 {
            width: 211px;
            height: 33px;
        }
        .auto-style31 {
            height: 33px;
        }
        .auto-style32 {
            width: 209px;
            height: 62px;
        }
        .auto-style34 {
            height: 62px;
        }
        .auto-style35 {
            width: 209px;
            height: 39px;
        }
        .auto-style37 {
            height: 39px;
        }
        .auto-style38 {
            width: 167px;
            height: 39px;
        }
        .auto-style39 {
            width: 167px;
            height: 62px;
        }
        .auto-style40 {
            width: 167px;
            height: 64px;
        }
        .auto-style41 {
            width: 206px;
            height: 34px;
        }
        .auto-style42 {
            width: 212px;
            height: 34px;
        }
    </style>
</head>
<body style="height: 619px; width: 634px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <table class="auto-style4">
                <tr>
                    <td class="auto-style35"></td>
                    <td class="auto-style38">
                        <asp:Label ID="lblLocalidades" runat="server" Font-Bold="True" Text="Localidades"></asp:Label>
                    </td>
                    <td class="auto-style37"></td>
                </tr>
                <tr>
                    <td class="auto-style32">
                        <asp:Label ID="lblNomLoc" runat="server" Text="Nombre de la Localidad:"></asp:Label>
                    </td>
                    <td class="auto-style39">
                        <asp:TextBox ID="txtNombreLocalidad" runat="server" Width="140px"></asp:TextBox>
                    </td>
                    <td class="auto-style34"></td>
                </tr>
                <tr>
                    <td class="auto-style8"></td>
                    <td class="auto-style40">
                        <asp:Button ID="btnCuardarLocalidad" runat="server" Text="Guardar Localidad" Width="123px" OnClick="btnCuardarLocalidad_Click" />
                    </td>
                    <td class="auto-style10"></td>
                </tr>
            </table>
            <table class="auto-style7">
                <tr>
                    <td class="auto-style16"></td>
                    <td class="auto-style27">
                        <asp:Label ID="lblUsuarios" runat="server" Font-Bold="True" Text="Usuarios"></asp:Label>
                    </td>
                    <td class="auto-style28"></td>
                </tr>
                <tr>
                    <td class="auto-style29">
                        <asp:Label ID="lblNomUs" runat="server" Text="Nombre de usuario:"></asp:Label>
                    </td>
                    <td class="auto-style30">
                        <asp:TextBox ID="txtUsuario" runat="server" Width="140px"></asp:TextBox>
                    </td>
                    <td class="auto-style31"></td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="lblCon" runat="server" Text="Contraseña:"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtContraseña1" runat="server" Width="140px" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <table class="auto-style14">
                <tr>
                    <td class="auto-style41">
                        <asp:Label ID="lblRepCon" runat="server" Text="Repetir Contraseña:"></asp:Label>
                    </td>
                    <td class="auto-style42">
                        <asp:TextBox ID="txtContraseña2" runat="server" Width="140px" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style26"></td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="lblCorreo" runat="server" Text="Correo electrónico:"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtCorreo" runat="server" Width="140px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="lblCP" runat="server" Text="CP:"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtCP" runat="server" Width="140px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <table class="auto-style19">
                <tr>
                    <td class="auto-style24">
                        <asp:Label ID="lblLocalidades2" runat="server" Text="Localidades:"></asp:Label>
                    </td>
                    <td class="auto-style25">
                        <asp:DropDownList ID="ddlLocalidades" runat="server" Width="147px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style26"></td>
                </tr>
                <tr>
                    <td class="auto-style21"></td>
                    <td class="auto-style22">
                        <asp:Button ID="btnGuardarUsuario" runat="server" Text="Guardar Usuario" Width="123px" />
                    </td>
                    <td class="auto-style23"></td>
                </tr>
                <tr>
                    <td class="auto-style20">
                        <asp:Button ID="btnInicio" runat="server" Text="Ir al Inicio.aspx" Width="123px" />
                    </td>
                    <td class="auto-style11">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
