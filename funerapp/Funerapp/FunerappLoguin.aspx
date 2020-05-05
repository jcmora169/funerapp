<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FunerappLoguin.aspx.vb" Inherits="Funerapp.FunerappLoguin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Loguin Funerapp</title>
    
    <link href="CSS/estilos.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>
<body>
        <nav class="navbar navbar-inverse">
  <div class="container-fluid">
    <div class="navbar-header">
      <a class="navbar-brand" href="#">WebSiteName</a>
    </div>
    <ul class="nav navbar-nav">
      <li class="active"><a href="#">Home</a></li>
      <li class="dropdown"><a class="dropdown-toggle" data-toggle="dropdown" href="#">Page 1 <span class="caret"></span></a>
        <ul class="dropdown-menu">
          <li><a href="#">Page 1-1</a></li>
          <li><a href="#">Page 1-2</a></li>
          <li><a href="#">Page 1-3</a></li>
        </ul>
      </li>
      <li><a href="#">Page 2</a></li>
    </ul>
    <ul class="nav navbar-nav navbar-right">
      <li><a href="#"><span class="glyphicon glyphicon-user"></span> Sign Up</a></li>
      <li><a href="#"><span class="glyphicon glyphicon-log-in"></span> Login</a></li>
    </ul>
  </div>
</nav>

    <div class="container-xl contenedor" >

          <div class="form-group">
                    <div class="col-sm-10">
                        <asp:Image ID="ImgLogo" runat="server" ImageUrl="~/imagenes/LOGO.png" Height="174px" Width="324px" CssClass="rounded-circle" />
                    </div>
                </div>
        <div class="row">
            <div class="col-10">
                <h2>Iniciar sesión</h2>
            </div>
        </div>
       

            <form runat="server" class="form-horizontal">
                <div class="form-group">
                    <asp:Label ID="LbUsuario" runat="server" Text="Usuario" CssClass="Control-label col-sm-2"></asp:Label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="TxtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
               
                <div class="form-group">
                    <asp:Label ID="LbContraseña" runat="server" Text="Contraseña" CssClass="Control-label col-sm-2"></asp:Label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="TxtContraseña" TextMode="Password" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-12">
                        <asp:Button ID="BtnIniciar" runat="server" Text="Iniciar" CssClass="form-control btn-primary"  Width="328px"/>
                    </div>
                </div>
                <asp:Label ID="LbError" runat="server" Text=""></asp:Label>
        
        
    </form>

    </div>

</body>
</html>
