<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FunerappListadoServiciosConductor.aspx.vb" Inherits="Funerapp.FunerappListadoServiciosConductor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Listado Servicios</title>
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
                <li class="active"><a href="FunerappMenuConductor.aspx">Home</a></li>
            </ul>
            <ul class="nav navbar-nav navbar-right">
                <li><a href="FunerappInicio.aspx">
                    <asp:Label ID="LbUser" runat="server" ForeColor="#999999"></asp:Label>
                    <span class="glyphicon glyphicon-user"></span>Sign Up</a></li>
            </ul>
        </div>
    </nav>
    <div class="container text-center">
        <h2>Listado de servicios</h2>
        <h1></h1>
    </div>
        <form id="form1" runat="server">    
    <asp:GridView ID="GvServicios" runat="server" AutoGenerateColumns="false" CssClass="table table-striped table-bordered table-condensed" Height="126px" Width="1490px" BorderStyle="Dashed" HorizontalAlign="Center">
    <Columns>
        <asp:BoundField DataField="id_servicio" HeaderText="ID_SERVICIO" SortExpression="id" ItemStyle-HorizontalAlign="Center"  >
<ItemStyle HorizontalAlign="Center"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="ESTADO_SERVICIO" HeaderText="ESTADO_SERVICIO" SortExpression="descripcion" ItemStyle-HorizontalAlign="Center">
<ItemStyle HorizontalAlign="Center"></ItemStyle>
        </asp:BoundField> 
        <asp:BoundField DataField="nombres" HeaderText="NOMBRES" SortExpression="nombres" ItemStyle-HorizontalAlign="Center">
<ItemStyle HorizontalAlign="Center"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="apellidos" HeaderText="APELLIDOS" SortExpression="apellidos" ItemStyle-HorizontalAlign="Center" >
<ItemStyle HorizontalAlign="Center"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="direccion_origen" HeaderText="DIRECCION_ORIGEN" SortExpression="direccion_origen" ItemStyle-HorizontalAlign="Center" >
<ItemStyle HorizontalAlign="Center"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="direccion_destino" HeaderText="DIRECCION_DESTINO" SortExpression="direccion_destino" ItemStyle-HorizontalAlign="Center">
<ItemStyle HorizontalAlign="Center"></ItemStyle>
        </asp:BoundField> 
        
        <asp:CommandField  ShowSelectButton="True" ButtonType="Button"  SelectText="Asignar" ItemStyle-HorizontalAlign ="Center" ControlStyle-CssClass="alert-info" />
            
    </Columns>
        <HeaderStyle HorizontalAlign="Center" />
</asp:GridView>
        <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title" id="myModalLabel">Detalle del servicio</h4>
      </div>
      <div class="modal-body">
          <asp:Label ID="LbEstadoServicio" runat="server" Text="Estado del servicio: "></asp:Label>
          <br />
          <asp:Label ID="Label1" runat="server" Text="Servicio asignado: "></asp:Label>
          <br />
          <asp:Label ID="Label2" runat="server" Text="Progreso del servicio: "></asp:Label>
          
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
       
      </div>
    </div>
  </div>
</div>
 </form>
    <div>
        <asp:Label ID="Error" runat="server" Text=""></asp:Label></div>
</body>


</html>
