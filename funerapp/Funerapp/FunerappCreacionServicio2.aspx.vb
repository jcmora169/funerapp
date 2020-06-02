Imports MySql.Data.MySqlClient

Public Class FunerappCreacionServicio2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("Conectar") = System.Web.Configuration.WebConfigurationManager.AppSettings("ConectarMySql").ToString
        LbUser.Text = Session("usuarioS")
    End Sub

    Protected Sub BtnContinuar_Click(sender As Object, e As EventArgs) Handles BtnContinuar.Click
        Dim ciudadOrigen As String
        ciudadOrigen = DropDownListCiudadOrigen.SelectedValue
        Dim barrioOrigen As String
        barrioOrigen = TxtBarrioOrigen.Text
        Dim direccionOrigen As String
        direccionOrigen = TxtDireccionOrigen.Text
        Dim detalleUbicacionOrigen As String
        detalleUbicacionOrigen = TxtDetalleUbicacionOrgen.Text
        Dim fechaRegistro As Date = Date.Now
        Dim ciudadDestino As String
        ciudadDestino = DropDownListCiudadDestino.SelectedValue
        Dim barrioDestino As String
        barrioDestino = TxtBarrioDestino.Text
        Dim direccionDestino As String
        direccionDestino = TxtDireccionDestino.Text
        Dim detalleUbicacionDestino As String
        detalleUbicacionDestino = TxtDetalleUbicacionDestino.Text

    End Sub

    Public Sub insertarDatosTraslado(cOrigen As String, bOrigen As String, dOrigen As String, deOrigen As String, fRegistro As Date,
                                     cDestino As String, bDestino As String, dDestino As String, deDestino As String)



    End Sub
End Class