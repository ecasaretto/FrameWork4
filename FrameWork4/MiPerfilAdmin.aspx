<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MiPerfilAdmin.aspx.cs" Inherits="FrameWork4.MiPerfilAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            color: #3333CC;
            font-size: xx-large;
        }
        .auto-style2 {
            color: #3333CC;
            font-size: medium;
        }
        .auto-style3 {
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <span class="auto-style1"><strong>&nbsp;&nbsp; - - - - - - - - ADMINISTRADOR - - - - - - - &nbsp; </strong></span><br />
            <br />
            <span class="auto-style2"><strong>MI PERFIL</strong></span><br />
            <br />
            correo eleStronico&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="email" runat="server" Text="Label"></asp:Label>
            <br />
            firstName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="firstName" runat="server" Text="Label"></asp:Label>
            <br />
            lastName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lastName" runat="server" Text="Label"></asp:Label>
            <br />
            cambiar password: nueva password :
            <asp:TextBox ID="TextBoxCambiarContraseña" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="cambiarPass" runat="server" Text="Cambiar contraseña" />
            <br />
            <br />
            lastLogin&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lastLogin" runat="server" Text="Label"></asp:Label>
            <br />
            lastChangePassword&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lastChangePassword" runat="server" Text="Label"></asp:Label>
            <br />
            isAdmin&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="isAdmin" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            foto:&nbsp;&nbsp;
            <br />
            <asp:Image ID="ImagenPerfil" runat="server" />
            <br />
            <br />
            cambiar foto:
            <br />
            <h1><span class="auto-style3">Herramientas Administrador</span></h1>
            Alta de nuevo usuario
            <asp:Button ID="ButtonAltaUsuario" runat="server" OnClick="Button1_Click" Text="ButtonAltaUsuario" />
            <br />
            <br />
            <br />
            <asp:Button ID="ButtonToDefault" runat="server" OnClick="ButtonToDefault_Click" Text="ButtonToDefault" />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
