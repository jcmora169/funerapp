<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FunerappValidacionConductor.aspx.vb" Inherits="Funerapp.FunerappValidacionConductor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
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
                <li class="active"><a href="#">Home</a></li>
                <li class="dropdown"><a class="dropdown-toggle" data-toggle="dropdown" href="#">Validaciones <span class="caret"></span></a>
                    <ul class="dropdown-menu">
                        <li><a href="#">Validacion vehiculo</a></li>
                    </ul>
                </li>
            </ul>
            <ul class="nav navbar-nav navbar-right">
                <li><a href="FunerappInicio.aspx"><span class="glyphicon glyphicon-user"></span>Sign Up</a></li>
            </ul>

        </div>
    </nav>
    <br />
    <div class="container text-center">
        <h2>Validación Conductor</h2>
        <h1></h1>
    </div>
    <br />
    <br />
    <br />
    <form runat="server" class="form-horizontal">
        <div class=" col-sm-offset-1">
        <div class="col-sm-offset-4 col-sm-10">
            <asp:TextBox ID="TxtUsuario" runat="server" CssClass="form-control" Width="300px">Buscar Usuario</asp:TextBox>
        </div>
        <div class="form-group">
        </div>
        <div class="col-sm-offset-4 col-sm-12">
            <asp:Button ID="BtbBuscarUsuario" runat="server" Text="Buscar" CssClass="form-control btn-primary" Width="300px" />
        </div>
        <br />
        <br />
        <br />


        <div class="form-group">
            <label class="control-label col-sm-2" for="email">Nombres:</label>
            <div class="col-sm-3">
                <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <label class="control-label col-sm-2" for="pwd">Primer Apellido:</label>
            <div class="col-sm-3">
                <asp:TextBox ID="TxtPrimerApellido" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
        </div>
        <div class="form-group">
            <label class="control-label col-sm-2" for="pwd">Segundo Apellido:</label>
            <div class="col-sm-3">
                <asp:TextBox ID="TxtSegundoApellido" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <label class="control-label col-sm-2" for="pwd">Documento:</label>
            <div class="col-sm-3">
                <asp:TextBox ID="TxtDocumento" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
        </div>
        <div class="form-group">
            <label class="control-label col-sm-3" for="pwd">Alcoholemia</label>
            <div class="col-sm-1">
                <asp:CheckBox ID="ChkValidacionAlcoholemia" runat="server" CssClass="form-group-sm" />
            </div>

            <label class="control-label col-sm-4" for="pwd">Insomnio</label>
            <div class="col-sm-1">
                <asp:CheckBox ID="ChkValidacionInsomnio" runat="server" CssClass="form-group-sm" />
            </div>
        </div>

        <div class="form-group">
            <label class="control-label col-sm-3" for="pwd">Estado</label>
            <div class="col-sm-1">
                <asp:DropDownList ID="DplAprobadoAlcoholemia" runat="server">
                    <asp:ListItem>Aprobado</asp:ListItem>
                    <asp:ListItem>No Aprobado</asp:ListItem>
                </asp:DropDownList>
            </div>
            <label class="control-label col-sm-3" for="pwd">Estado</label>
            <div class="col-sm-1">
                <asp:DropDownList ID="DplAprobadoInsomnio" runat="server">
                    <asp:ListItem>Aprobado</asp:ListItem>
                    <asp:ListItem>No Aprobado</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>

        <div class="form-group">
            <div class="col-sm-offset-4 col-sm-10">
                <asp:Button ID="BtnCargarValidaciones" runat="server" Text="Cargar Validaciones" CssClass="form-control btn-primary" Width="300px" />
            </div>
        </div>
            </div>
    </form>

    <div>
        <asp:Label ID="Error" runat="server" Text=""></asp:Label></div>
</body>
</html>
