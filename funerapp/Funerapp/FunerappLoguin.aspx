<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FunerappLoguin.aspx.vb" Inherits="Funerapp.FunerappLoguin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="CSS/estilos.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
</head>
<body>

    <div class="container well contenedor" >
        <div class="row">
            <div class="col-xs-12">
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
                        <asp:TextBox ID="TxtContraseña" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                     <asp:Button ID="BtnIniciar" runat="server" Text="Iniciar" CssClass="form-control btn-primary" Width="295px"/>

                </div>
        
        
    </form>

    </div>

</body>
</html>
