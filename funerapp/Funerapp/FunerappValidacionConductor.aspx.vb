Imports MySql.Data.MySqlClient

Public Class FunerappValidacionConductor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("Conectar") = System.Web.Configuration.WebConfigurationManager.AppSettings("ConectarMySql").ToString



    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles BtbBuscarUsuario.Click
        Dim usuario As String
        usuario = TxtUsuario.Text
        consultarUsuario(usuario)
    End Sub

    Private Sub consultarUsuario(usuario As String)
        Try
            Dim cnn As New MySqlConnection()
            cnn.ConnectionString = Session("Conectar")
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim consulta As New MySqlCommand("SELECT * FROM usuarios where usuario = @USUARIO", cnn)
            consulta.Parameters.Add(New MySqlParameter("@USUARIO", usuario))
            Dim resultado As MySqlDataReader
            resultado = consulta.ExecuteReader
            If resultado.Read() Then
                TxtNombre.Text = resultado.Item("nombres")
                TxtPrimerApellido.Text = resultado.Item("primer_apellido")
                TxtSegundoApellido.Text = resultado.Item("segundo_apellido")
                TxtDocumento.Text = resultado.Item("documento")
            End If


            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try
    End Sub


End Class