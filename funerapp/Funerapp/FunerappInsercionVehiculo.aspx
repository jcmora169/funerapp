<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FunerappInsercionVehiculo.aspx.vb" Inherits="Funerapp.FunerappInsercionVehiculo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
   
    <script type="text/javascript">

        function showimagepreview(input) {

            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {

                    document.getElementsByTagName("img")[0].setAttribute("src", e.target.result);
                }
                reader.readAsDataURL(input.files[0]);
            }

        }
        

    </script>

    <script type="text/javascript">

        function showimagepreview1(input) {

            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {

                    document.getElementsByTagName("img")[0].setAttribute("src", e.target.result);
                }
                reader.readAsDataURL(input.files[0]);
            }
            
        }
        

    </script>
    
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
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
        
        <div class="container">
           <div class="row">
                <div class="col-sm-12">
                    <h1>Registro de Carrozas</h1>
                </div>
             </div>

            <div class="row">
              
            <div class="col-sm-6">
                    
                    
                Marca<br />
                <asp:TextBox ID="TxtMarca" runat="server"></asp:TextBox>
                <br />
                <br />
                Referencia<br />
                <asp:TextBox ID="TxtRefrencia" runat="server"></asp:TextBox>
                <br />
                <br />
                Modelo<br />
                <asp:TextBox ID="TxtModelo" runat="server"></asp:TextBox>
                <br />
                <br />
                Placa<br />
                <asp:TextBox ID="TxtPlaca" runat="server"></asp:TextBox>
                <br />
                    
                    
             </div>

            <div class="col-sm-6">
                
                    
                Fecha Vencimiento SOAT<br />
                <asp:TextBox ID="TxtSoat" runat="server"></asp:TextBox>
                <asp:ImageButton ID="BtnSoat" runat="server" Width="21px" ImageUrl="~/imagenes/Calendario.png" />
                    
                    
                <br />
                <asp:Calendar ID="CalendarSoat" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                    <DayStyle BackColor="#CCCCCC" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                    <TodayDayStyle BackColor="#999999" ForeColor="White" />
                </asp:Calendar>
                <br />
                <asp:Label ID="Label1" runat="server" Text="Fecha Vencimeinto Tecnomecanica"></asp:Label>
                <br />
                <asp:TextBox ID="TxtTecnomecanica" runat="server"></asp:TextBox>
                <asp:ImageButton ID="btnTecno" runat="server" Height="21px" ImageUrl="~/imagenes/Calendario.png" Width="21px" />
                    
                  
                    <br />
                <asp:Calendar ID="CalendarTecno" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                    <DayStyle BackColor="#CCCCCC" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                    <TodayDayStyle BackColor="#999999" ForeColor="White" />
                </asp:Calendar>
                <br />
                <br />
                <br />
                
                
                <asp:Image ID="check"  runat="server" ImageUrl="~/imagenes/adjuntar.png" Width="300px" />
                    <br />
                      <br />
                Archivo:
                <asp:FileUpload ID="fuploadChek" accept=".jpg" runat="server" CssClass="form-control" onchange="showimagepreview1(this)" />
               
                <asp:Button ID="btnCheck" runat="server" Text="Visualizar" />
                <br />
                <asp:Label ID="LblCheck" runat="server"></asp:Label>

                <br />
                <br />

                
             </div>

              <%--  <div class="col-sm-3">
                    Imagen Vehiculo
                <asp:Image ID="foto"  runat="server" ImageUrl="~/imagenes/adjuntar.png" />
                    <br />
                      <br />

                Archivo:
                <asp:FileUpload ID="fuploadCarroza" accept=".jpg" runat="server" CssClass="form-control" onchange="showimagepreview(this)" />
                  
                <asp:Button ID="btnFoto" runat="server" Text="Visualizar" />

                 <br />

                 <asp:Label ID="LblFoto" runat="server" Text="Label"></asp:Label>
                  
                 <br />
                <br />
                <br />

                    </div>--%>

               
                
            </div>

            <div class="row">
                <div class="auto-style1">
                      <asp:Button ID="btnGuardar" runat="server" Text="Guardar Datos" CssClass ="btn btn-success" />
                    </div>
            </div>
    </div>
      </form>


    



</body>
</html>
