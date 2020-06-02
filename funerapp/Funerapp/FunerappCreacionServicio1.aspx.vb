Imports MySql.Data.MySqlClient

Public Class FunerappCreacionServicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("Conectar") = System.Web.Configuration.WebConfigurationManager.AppSettings("ConectarMySql").ToString
        LbUser.Text = Session("usuarioS")
    End Sub

    Protected Sub BtnContinuar_Click(sender As Object, e As EventArgs) Handles BtnContinuar.Click
        Dim nombresFallecido As String
        nombresFallecido = TxtNombres.Text
        Dim apellidosFallecido As String
        apellidosFallecido = TxtApellidos.Text
        Dim documentoFallecido As String
        documentoFallecido = TxtDocumento.Text
        Dim edadFallecido As Integer
        edadFallecido = TxtEdad.Text
        Dim generoFallecido As String
        generoFallecido = DropDownListGenero.SelectedValue
        Dim tipoMuerteFallecido As Integer
        tipoMuerteFallecido = DropDownListTipoMuerte.SelectedValue
        insertarFallecido(nombresFallecido, apellidosFallecido, documentoFallecido, edadFallecido, generoFallecido, tipoMuerteFallecido)
        consultarIdFallecido(documentoFallecido)
        Response.Redirect("FunerappCreacionServicio2.aspx")
    End Sub

    Public Sub insertarFallecido(nomFallecido As String, apeFallecido As String, docuFallecido As String, edaFallecido As Integer, geneFallecido As String, tipoMuerFallecido As Integer)
        Try
            Dim cnn As New MySqlConnection With {
                       .ConnectionString = Session("Conectar")
                   }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim cmd As New MySqlCommand("INSERT INTO fallecido (documento, nombres, apellidos, edad,genero,id_tipo_muerte) VALUES( @DOCUMENTO, @NOMBRES, @APELLIDOS, @EDAD, @GENERO, @TIPO_MUERTE)", cnn)
            cmd.Parameters.Add(New MySqlParameter("@DOCUMENTO", docuFallecido))
            cmd.Parameters.Add(New MySqlParameter("@NOMBRES", nomFallecido))
            cmd.Parameters.Add(New MySqlParameter("@APELLIDOS", apeFallecido))
            cmd.Parameters.Add(New MySqlParameter("@EDAD", edaFallecido))
            cmd.Parameters.Add(New MySqlParameter("@GENERO", geneFallecido))
            cmd.Parameters.Add(New MySqlParameter("@TIPO_MUERTE", tipoMuerFallecido))
            cmd.ExecuteNonQuery()

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try
    End Sub

    Public Sub consultarIdFallecido(docuFallecido As String)
        Try
            Dim cnn As New MySqlConnection With {
               .ConnectionString = Session("Conectar")
           }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim consulta As New MySqlCommand("SELECT id_fallecido FROM fallecido where documento = @DOCUMENTO", cnn)
            consulta.Parameters.Add(New MySqlParameter("@DOCUMENTO", docuFallecido))
            Dim resultado As MySqlDataReader
            resultado = consulta.ExecuteReader
            If resultado.Read() Then
                Session("idFallecido") = resultado.Item("id_fallecido")
            End If

            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try
    End Sub
End Class