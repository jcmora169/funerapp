<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FunerappInformes.aspx.vb" Inherits="Funerapp.FunerappInformes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Informes</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script> 
</head>
<body>
    <form id="form1" runat="server">
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
                    <asp:Label ID="LbUser" runat="server" ForeColor="#999999"></asp:Label>  <span class="glyphicon glyphicon-user"></span> Sign Up</a></li>
            </ul>
        </div>
    </nav>
        <div class="container-xl contenedor">
            <div class="form-group">
                <div  class="col-sm-offset-2 col-sm-12">
                    <asp:Image ID="Image1" runat="server" Height="596px" ImageUrl="~/imagenes/ImagenesKNT/power-bi-marketing-sample-dashboard.png" Width="1000px" />
                </div>
            </div>
        </div>
        
    </form>
    
</body>
</html>
