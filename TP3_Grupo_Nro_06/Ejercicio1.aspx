﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP3_Grupo_Nro_06.WebForm1" %>

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
            width: 105%;
            height: 185px;
        }
        .auto-style7 {
            width: 105%;
            height: 90px;
            margin-right: 25px;
        }
        .auto-style11 {
            width: 211px;
        }
        .auto-style12 {
            width: 206px;
        }
        .auto-style13 {
            width: 213px;
        }
        .auto-style14 {
            width: 105%;
            height: 104px;
            margin-right: 30px;
        }
        .auto-style19 {
            width: 105%;
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
            width: 213px;
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
        .auto-style54 {
            width: 206px;
            height: 22px;
        }
        .auto-style55 {
            width: 213px;
            height: 22px;
        }
        .auto-style56 {
            height: 22px;
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
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="rfvValidacion" runat="server" ControlToValidate="txtNombreLocalidad" ErrorMessage="Ingrese Localidad" ForeColor="Red" ValidationGroup="GrupoLocalidad"></asp:RequiredFieldValidator>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtNombreLocalidad" runat="server" Width="140px" AutoCompleteType="Disabled" ValidationGroup="GrupoLocalidad"></asp:TextBox>
                        &nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:CustomValidator ID="cvLocalidadCorrecta" runat="server" ForeColor="Red" OnServerValidate="cvLocalidadCorrecta_ServerValidate" ControlToValidate="txtNombreLocalidad" SetFocusOnError="True" ValidationGroup="GrupoLocalidad">Debe ingresar una localidad válida</asp:CustomValidator>
                        <br />
                    </td>
                    <td class="auto-style44">
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtNombreLocalidad" ErrorMessage="CustomValidator" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" ValidationGroup="GrupoLocalidad">Localidad ya registrada</asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style51">
                        <asp:HiddenField ID="hfRepeticionLocalidad" runat="server" />
                    </td>
                    <td class="auto-style48">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnCuardarLocalidad" runat="server" Text="Guardar Localidad" Width="128px" OnClick="btnCuardarLocalidad_Click" ValidationGroup="GrupoLocalidad" />
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
                        <asp:TextBox ID="txtUsuario" runat="server" Width="140px" ValidationGroup="GrupoUsuarios" AutoCompleteType="Disabled"></asp:TextBox>
                    </td>
                    <td class="auto-style31">
                        <asp:RequiredFieldValidator ID="rfvNombreUsuario" runat="server" ControlToValidate="txtUsuario" ForeColor="Red" ValidationGroup="GrupoUsuarios">Debe ingresar un nombre</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style20">
                        <asp:Label ID="lblCon" runat="server" Text="Contraseña:"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtContraseña1" runat="server" Width="140px" TextMode="Password" ValidationGroup="GrupoUsuarios" AutoCompleteType="Disabled"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvContrasenia1" runat="server" ControlToValidate="txtContraseña1" ForeColor="Red" ValidationGroup="GrupoUsuarios">Debe ingresar una contraseña</asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
            <table class="auto-style14">
                <tr>
                    <td class="auto-style41">
                        <asp:Label ID="lblRepCon" runat="server" Text="Repetir Contraseña:"></asp:Label>
                    </td>
                    <td class="auto-style42">
                        <asp:TextBox ID="txtContraseña2" runat="server" Width="140px" TextMode="Password" ValidationGroup="GrupoUsuarios" AutoCompleteType="Disabled"></asp:TextBox>
                    </td>
                    <td class="auto-style26">
                        <asp:CompareValidator ID="cvContraseñaIncorrecta" runat="server" ControlToCompare="txtContraseña1" ControlToValidate="txtContraseña2" ErrorMessage="Contraseña Incorrecta" ForeColor="Red" ValidationGroup="GrupoUsuarios"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style54">
                        <asp:Label ID="lblCorreo" runat="server" Text="Correo electrónico:"></asp:Label>
                    </td>
                    <td class="auto-style55">
                        <asp:TextBox ID="txtCorreo" runat="server" Width="140px" ValidationGroup="GrupoUsuarios" AutoCompleteType="Disabled"></asp:TextBox>
                    </td>
                    <td class="auto-style56">
                        <asp:RegularExpressionValidator ID="revCorreo" runat="server" ControlToValidate="txtCorreo" ErrorMessage="*" ForeColor="Red" ValidationExpression="^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$" ValidationGroup="GrupoUsuarios"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ControlToValidate="txtCorreo" ErrorMessage="*" ForeColor="Red" ValidationGroup="GrupoUsuarios"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="lblCP" runat="server" Text="CP:"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtCP" runat="server" Width="140px" ValidationGroup="GrupoUsuarios" AutoCompleteType="Disabled"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RangeValidator ID="rvCodigoPostal" runat="server" ForeColor="Red" ControlToValidate="txtCP" MaximumValue="9999" MinimumValue="1000" Type="Integer" ValidationGroup="GrupoUsuarios">Código Postal Inválido</asp:RangeValidator>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvCP" runat="server" ControlToValidate="txtCP" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="GrupoUsuarios">Ingrese un código postal</asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
            <table class="auto-style19">
                <tr>
                    <td class="auto-style24">
                        <asp:Label ID="lblLocalidades2" runat="server" Text="Localidades:"></asp:Label>
                    </td>
                    <td class="auto-style25">
                        <asp:DropDownList ID="ddlLocalidades" runat="server" Width="147px" ValidationGroup="GrupoUsuarios">
                            <asp:ListItem>-- Elija Localidad --</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style26">
                        <asp:RequiredFieldValidator ID="rfvDdlLocalidades" runat="server" ControlToValidate="ddlLocalidades" ForeColor="Red" InitialValue="-- Elija Localidad --" ValidationGroup="GrupoUsuarios">Seleccione una localidad</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style21"></td>
                    <td class="auto-style22">
                        <asp:Button ID="btnGuardarUsuario" runat="server" Text="Guardar Usuario" Width="123px" ValidationGroup="GrupoUsuarios" OnClick="btnGuardarUsuario_Click" />
                    </td>
                    <td class="auto-style23">
                        <asp:Label ID="lblUsuarioIngresado" runat="server" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style20">
                        <asp:Button ID="btnInicio" runat="server" Text="Ir al Inicio.aspx" Width="123px" ValidationGroup="GrupoNuevaPagina" OnClick="btnInicio_Click" />
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
