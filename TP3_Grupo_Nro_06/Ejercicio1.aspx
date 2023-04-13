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
            width: 98%;
            height: 185px;
        }
        .auto-style7 {
            width: 96%;
            height: 90px;
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
        .auto-style30 {
            width: 211px;
            height: 33px;
        }
        .auto-style31 {
            height: 33px;
        }
        .auto-style41 {
            width: 206px;
            height: 34px;
        }
        .auto-style42 {
            width: 212px;
            height: 34px;
        }
        .auto-style43 {
            width: 303px;
            height: 50px;
        }
        .auto-style44 {
            width: 303px;
            height: 92px;
        }
        .auto-style45 {
            width: 303px;
            height: 64px;
        }
        .auto-style46 {
            width: 504px;
            height: 50px;
        }
        .auto-style47 {
            width: 504px;
            height: 92px;
        }
        .auto-style48 {
            width: 504px;
            height: 64px;
        }
        .auto-style49 {
            width: 396px;
            height: 50px;
        }
        .auto-style50 {
            width: 396px;
            height: 92px;
        }
        .auto-style51 {
            width: 396px;
            height: 64px;
        }
        .auto-style52 {
            width: 207px;
            height: 60px;
        }
        .auto-style53 {
            width: 207px;
            height: 33px;
        }
    </style>
</head>
<body style="height: 619px; width: 634px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <table class="auto-style4">
                <tr>
                    <td class="auto-style49">
                        <asp:HiddenField ID="hfLocalidadCorrecta" runat="server" />
                    </td>
                    <td class="auto-style46">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblLocalidades" runat="server" Font-Bold="True" Text="Localidades"></asp:Label>
                    </td>
                    <td class="auto-style43"></td>
                </tr>
                <tr>
                    <td class="auto-style50">
                        <br />
                        <br />
                        <asp:Label ID="lblNomLoc" runat="server" Text="Nombre de la Localidad:"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <br />
                    </td>
                    <td class="auto-style47">
                        <asp:RequiredFieldValidator ID="rfvValidacion" runat="server" ControlToValidate="txtNombreLocalidad" ErrorMessage="Ingrese Localidad" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <asp:TextBox ID="txtNombreLocalidad" runat="server" Width="140px" AutoCompleteType="Disabled"></asp:TextBox>
                        <br />
                        <asp:CustomValidator ID="cvLocalidadCorrecta" runat="server" ForeColor="Red" OnServerValidate="cvLocalidadCorrecta_ServerValidate">Debe ingresar una localidad válida</asp:CustomValidator>
                        <br />
                    </td>
                    <td class="auto-style44">
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtNombreLocalidad" ErrorMessage="CustomValidator" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate">Localidad ya registrada</asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style51">
                        <asp:HiddenField ID="hfRepeticionLocalidad" runat="server" />
                    </td>
                    <td class="auto-style48">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnCuardarLocalidad" runat="server" Text="Guardar Localidad" Width="123px" OnClick="btnCuardarLocalidad_Click" />
                    </td>
                    <td class="auto-style45">
                        <asp:Label ID="lblLocAgregada" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <table class="auto-style7">
                <tr>
                    <td class="auto-style52"></td>
                    <td class="auto-style27">
                        <asp:Label ID="lblUsuarios" runat="server" Font-Bold="True" Text="Usuarios"></asp:Label>
                    </td>
                    <td class="auto-style28"></td>
                </tr>
                <tr>
                    <td class="auto-style53">
                        <asp:Label ID="lblNomUs" runat="server" Text="Nombre de usuario:"></asp:Label>
                    </td>
                    <td class="auto-style30">
                        <asp:TextBox ID="txtUsuario" runat="server" Width="140px"></asp:TextBox>
                    </td>
                    <td class="auto-style31"></td>
                </tr>
                <tr>
                    <td class="auto-style20">
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
