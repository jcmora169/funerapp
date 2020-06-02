<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FunerappCreacionServicio2.aspx.vb" Inherits="Funerapp.FunerappCreacionServicio2" %>

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
            
            <ul class="nav navbar-nav navbar-right">
                <li><a href="FunerappInicio.aspx">
                    <asp:Label ID="LbUser" runat="server" ForeColor="#999999"></asp:Label>
                    <span class="glyphicon glyphicon-user"></span>Sign Up</a></li>
            </ul>
        </div>
    </nav>

    <div class="container text-center">
        <h2>Datos Para El Traslado</h2>
        <h1></h1>
    </div>
    <br />
    <div class="container-xl contenedor">
        <form runat="server" class="form-horizontal">

          <div class="container text-center alert-success">
                <h3>Datos Origen</h3>
            </div>
            <br />
            <div class="form-group">
                <label class="control-label col-sm-2" for="email">Ciudad Origen:</label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="DropDownListCiudadOrigen" runat="server">
                        <asp:ListItem Value="Bogotá DC">Bogotá DC</asp:ListItem>
                        <asp:ListItem Value="Medellin">Medellin</asp:ListItem>
                        <asp:ListItem Value="Cali">Cali</asp:ListItem>
                        <asp:ListItem Value="Bucaramanga">Bucaramanga</asp:ListItem>
                        <asp:ListItem Value="Pasto">Pasto</asp:ListItem>
                        <asp:ListItem Value="Cartagena">Cartagena</asp:ListItem>
                        <asp:ListItem Value="Santa Marta">Santa Marta</asp:ListItem>
                        <asp:ListItem Value="Barranquilla">Barranquilla</asp:ListItem>
                        <asp:ListItem Value="Tunja">Tunja</asp:ListItem>
                        <asp:ListItem Value="Villavicencio">Villavicencio</asp:ListItem>
                        <asp:ListItem Value="Pereira">Pereira</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <label class="control-label col-sm-2" for="pwd">Barrio Origen:</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="TxtBarrioOrigen" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <br />

            <div class="form-group">
                <label class="control-label col-sm-2" for="email">Direccion Origen:</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="TxtDireccionOrigen" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <label class="control-label col-sm-2" for="pwd">Detalles Ubicación:</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="TxtDetalleUbicacionOrgen" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="container text-center alert-success">
                <h3>Datos Destino</h3>
            </div>
            <br />
            <div class="form-group">
                <label class="control-label col-sm-2" for="email">Ciudad Destino:</label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="DropDownListCiudadDestino" runat="server">
                        <asp:ListItem Value="Bogotá DC">Bogotá DC</asp:ListItem>
                        <asp:ListItem Value="Medellin">Medellin</asp:ListItem>
                        <asp:ListItem Value="Cali">Cali</asp:ListItem>
                        <asp:ListItem Value="Bucaramanga">Bucaramanga</asp:ListItem>
                        <asp:ListItem Value="Pasto">Pasto</asp:ListItem>
                        <asp:ListItem Value="Cartagena">Cartagena</asp:ListItem>
                        <asp:ListItem Value="Santa Marta">Santa Marta</asp:ListItem>
                        <asp:ListItem Value="Barranquilla">Barranquilla</asp:ListItem>
                        <asp:ListItem Value="Tunja">Tunja</asp:ListItem>
                        <asp:ListItem Value="Villavicencio">Villavicencio</asp:ListItem>
                        <asp:ListItem Value="Pereira">Pereira</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <label class="control-label col-sm-2" for="pwd">Barrio Destino:</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="TxtBarrioDestino" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <br />

            <div class="form-group">
                <label class="control-label col-sm-2" for="email">Direccion Destino:</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="TxtDireccionDestino" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <label class="control-label col-sm-2" for="pwd">Detalles Ubicación:</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="TxtDetalleUbicacionDestino" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <br />
            <br />

            <div class="col-sm-offset-5 col-sm-12">
                <asp:Button ID="BtnContinuar" runat="server" Text="Crear Servicio" CssClass="form-control btn-primary" Width="200px" />
            </div>

        </form>

    </div>

    <div>
        <asp:Label ID="Error" runat="server" Text=""></asp:Label>
    </div>
</body>
</html>
