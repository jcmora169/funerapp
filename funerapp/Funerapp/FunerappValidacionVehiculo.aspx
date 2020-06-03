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


</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-inverse">
            <div class="container-fluid">
                <div class="navbar-header">
                    <a class="navbar-brand" href="#">Funerapp</a>
                </div>
                <ul class="nav navbar-nav">
                    <li class="active"><a href="FunerappMenuConductor.aspx">Home</a></li>
                    
                </ul>
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="FunerappInicio.aspx">
                        <asp:Label ID="LbUser" runat="server" ForeColor="#999999"></asp:Label>
                        <span class="glyphicon glyphicon-user"></span>Sign Up</a></li>
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
                    <div class="jumbotron text-center">


                        <asp:DropDownList ID="Listado" runat="server">
                        </asp:DropDownList>
                        <br />
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="Fecha Vencimiento SOAT"></asp:Label>
                        <br />
                        <asp:TextBox ID="TxtSoat" runat="server" BackColor="#FF0066" Enabled="False"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="Label3" runat="server" Text="Fecha Vencimiento Tecnomecanica"></asp:Label>
                        <br />
                        <asp:TextBox ID="TxtTecno" runat="server" BackColor="#66CCFF" Enabled="False"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Button ID="BtnFechas" runat="server" Text="Validar Documentación" />
                        <br />
                        <br />
                        
                        <asp:CheckBox ID="ChkSoat" runat="server" Text="SOAT" Enabled="False" />
                        &nbsp;
            <asp:DropDownList ID="CalificacionSoat" runat="server" Enabled="False">
                <asp:ListItem Value="Aprobado">Aprobado</asp:ListItem>
                <asp:ListItem>No Aprobado</asp:ListItem>
            </asp:DropDownList>
                        <br />
                        <asp:CheckBox ID="ChkTecno" runat="server" Text="Tecnomecanica" Enabled="False" />
                        &nbsp;
            <asp:DropDownList ID="CalificacionTecno" runat="server" Enabled="False">
                <asp:ListItem Value="Aprobado">Aprobado</asp:ListItem>
                <asp:ListItem>No Aprobado</asp:ListItem>
            </asp:DropDownList>
                        <br />
                        <asp:CheckBox ID="ChkLucesDel" runat="server" Text="Luces Delanteras" Enabled="False" />
                        &nbsp;<asp:DropDownList ID="CalificacionLucesDel" runat="server" Enabled="False">
                            <asp:ListItem>Aprobado</asp:ListItem>
                            <asp:ListItem>No Aprobado</asp:ListItem>
                        </asp:DropDownList>

                        <br />
                        <asp:CheckBox ID="ChkLucesTra" runat="server" Text="Luces Traseras" Enabled="False" />
                        &nbsp;
            <asp:DropDownList ID="CalificacionLucesTras" runat="server" Enabled="False">
                <asp:ListItem Value="Aprobado">Aprobado</asp:ListItem>
                <asp:ListItem>No Aprobado</asp:ListItem>
            </asp:DropDownList>
                        <br />
                        <asp:CheckBox ID="ChkFugas" runat="server" Text="Sin Fugas de aceite " Enabled="False" />
                        &nbsp;<asp:DropDownList ID="CalificacionFugas" runat="server" Enabled="False">
                            <asp:ListItem Value="Aprobado">Aprobado</asp:ListItem>
                            <asp:ListItem>No Aprobado</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <asp:CheckBox ID="ChkLlantas" runat="server" Text="Llantas" Enabled="False" />
                        &nbsp;
            <asp:DropDownList ID="CalificacionLlantas" runat="server" Enabled="False">
                <asp:ListItem Value="Aprobado">Aprobado</asp:ListItem>
                <asp:ListItem>No Aprobado</asp:ListItem>
            </asp:DropDownList>
                        <br />
                        <asp:CheckBox ID="ChkCamilla" runat="server" Text="Camilla" Enabled="False" />
                        &nbsp;
            <asp:DropDownList ID="CalificacionCamilla" runat="server" Enabled="False">
                <asp:ListItem Value="Aprobado">Aprobado</asp:ListItem>
                <asp:ListItem>No Aprobado</asp:ListItem>
            </asp:DropDownList>
                        <br />
                        <asp:CheckBox ID="ChkGuantes" runat="server" Text="Guantes " Enabled="False" />
                        &nbsp;<asp:DropDownList ID="CalificacionGuantes" runat="server" Enabled="False">
                            <asp:ListItem Value="Aprobado">Aprobado</asp:ListItem>
                            <asp:ListItem>No Aprobado</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <asp:CheckBox ID="ChkAntifluido" runat="server" Text="Traje antifluidos" Enabled="False" />
                        &nbsp;<asp:DropDownList ID="CalificacionAntifluido" runat="server" Enabled="False">
                            <asp:ListItem Value="Aprobado">Aprobado</asp:ListItem>
                            <asp:ListItem>No Aprobado</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        &nbsp;
            <br />
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                        <br />
                        <asp:Label ID="Error" runat="server" Text="Label"></asp:Label>
                        <br />
                        <asp:Image ID="foto" runat="server" />
                        <br />
                        <br />
                        <asp:FileUpload ID="cargaFoto" runat="server" CssClass="form-control" onchange="showimagepreview(this)" Enabled="False" />
                        <br />
                        <br />
                        <asp:Button ID="btnRealizarChek" runat="server" Text="Cargar CheckList" Enabled="False" />


                    </div>
                </div>
            </div>

        </div>

        <div class="col-sm-3">
        </div>










    </form>

</body>
</html>
