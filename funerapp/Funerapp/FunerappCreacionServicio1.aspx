<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FunerappCreacionServicio1.aspx.vb" Inherits="Funerapp.FunerappCreacionServicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Formulario creacion servicio</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>
<body>
    <nav class="navbar navbar-inverse">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand" href="#">Funerapp</a>
            </div>
            <ul class="nav navbar-nav">
                <li class="active"><a href="FunerappMenuCordinador.aspx">Home</a></li>
            </ul>
            <ul class="nav navbar-nav navbar-right">
                <li><a href="FunerappInicio.aspx">
                    <asp:Label ID="LbUser" runat="server" ForeColor="#999999"></asp:Label>
                    <span class="glyphicon glyphicon-user"></span>Sign Up</a></li>
            </ul>
        </div>
    </nav>

    <div class="container text-center">
        <h2>Datos del Fallecido</h2>
        <h1></h1>
    </div>
    <br />
    <br />

    <div class="container-xl contenedor">
        <form runat="server" class="form-horizontal">

            <div class="form-group">
                <label class="control-label col-sm-2" for="email">Nombres:</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="TxtNombres" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <label class="control-label col-sm-2" for="pwd">Apellidos:</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="TxtApellidos" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <br />
            <br />
            <br />

            <div class="form-group">
                <label class="control-label col-sm-2" for="email">Documento:</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="TxtDocumento" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <label class="control-label col-sm-2" for="pwd">Edad</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="TxtEdad" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <br />
            <br />
            <br />

            <div class="form-group">
                <label class="control-label col-sm-2" for="email">Genero:</label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="DropDownListGenero" runat="server">
                        <asp:ListItem Value="Masculino">Masculino</asp:ListItem>
                        <asp:ListItem Value="Femenino">Femenino</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <label class="control-label col-sm-2" for="pwd">Tipo de muerte</label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="DropDownListTipoMuerte" runat="server">
                        <asp:ListItem Value="1">Natural</asp:ListItem>
                        <asp:ListItem Value="2">Accidente de transito</asp:ListItem>
                        <asp:ListItem Value="3">Asesinato</asp:ListItem>
                        <asp:ListItem Value="4">Suicidio</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <br />
            <br />
            <br />
            <br />
            <br />

            <div class="col-sm-offset-5 col-sm-12">
                <asp:Button ID="BtnContinuar" runat="server" Text="Continuar" CssClass="form-control btn-primary" Width="200px" />
            </div>

        </form>

    </div>

    <div>
        <asp:Label ID="Error" runat="server" Text=""></asp:Label>
    </div>
</body>
</html>
