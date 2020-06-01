<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FunerappMenuConductor.aspx.vb" Inherits="Funerapp.FunerappMenuConductor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Menu Principal Conductor</title>
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
                        <li><a href="FunerappValidacionVehiculo.aspx">Validacion vehiculo</a></li>
                    </ul>
                </li>
                <li class="dropdown"><a class="dropdown-toggle" data-toggle="dropdown" href="#">Servicios <span class="caret"></span></a>
                    <ul class="dropdown-menu">
                        <li><a href="#">Listar servicios</a></li>
                    </ul>
                </li>
                
            </ul>
            <ul class="nav navbar-nav navbar-right">
                <li><a href="FunerappInicio.aspx">
                    <asp:Label ID="LbUser" runat="server" ForeColor="#999999"></asp:Label>
                    <span class="glyphicon glyphicon-user"></span>Sign Up</a></li>
            </ul>
        </div>
    </nav>
    <div class="container">
        <h3>Bienvenido</h3>
        <p>Puede empezar a trabajar sobre la aplicacion.</p>
    </div>
    <div class="container">
        <div id="myCarousel" class="carousel slide" data-ride="carousel">
            <!-- Indicators -->
            <ol class="carousel-indicators">
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="1"></li>
                <li data-target="#myCarousel" data-slide-to="2"></li>
                <li data-target="#myCarousel" data-slide-to="3"></li>
            </ol>
            <!-- Wrapper for slides -->
            <div class="carousel-inner">
                <div class="item active">
                    <img src="imagenes/502774-funeraria-la-alpujarra-banner.jpg" alt="Los Angeles" style="width: 100%;" />
                </div>
                <div class="item">
                    <img src="imagenes/funergal.jpg" alt="Chicago" style="width: 100%;" />
                </div>
                <div class="item">
                    <img src="imagenes/Seguro-vehiculos-funsegur.jpg" alt="New york" style="width: 100%;" />
                </div>
                <div class="item">
                    <img src="imagenes/aplicación-web-y-de-escritorio-01.jpg" alt="Cansas" style="width: 100%;" />
                </div>
            </div>
            <!-- Left and right controls -->
            <a class="left carousel-control" href="#myCarousel" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#myCarousel" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
    </div>
</body>
</html>
