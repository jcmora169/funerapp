<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FunerappValidacionVehiculo.aspx.vb" Inherits="Funerapp.FunerappValidacionVehiculo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />
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

<div class="jumbotron text-center">
  <h1>Validacion vehicular</h1>
  <p>Escoge tu equipo de trabajo</p> 
</div>
  
<div class="container">
  <div class="row">

    <div class="col-sm-3"></div>
    <div class="col-sm-6">
        <div class="jumbotron text-center" >
        
           
        <asp:DropDownList ID="Listado" runat="server">
        </asp:DropDownList>
        <br />
        <br />
            <input id="Button1" type="button" value="button" /><br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnRealizarChek" runat="server" Text="Realizar checkList" />

        </div>
      </div>
      </div>
      <div class="col-sm-3"></div>

    
  </div>

    

        



     </form>

</body>
</html>
