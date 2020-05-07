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
    Protected Sub BtnCargarValidaciones_Click(sender As Object, e As EventArgs) Handles BtnCargarValidaciones.Click
        CargarValidaciones()
    End Sub

    Private Sub CargarValidaciones()
        If Me.ChkValidacionAlcoholemia.Checked And Me.ChkValidacionInsomnio.Checked Then
            If Me.DplAprobadoAlcoholemia.SelectedValue = "Aprobado" And Me.DplAprobadoInsomnio.SelectedValue = "Aprobado" Then
                MsgBox("El usario aprobo todas las validaciones.", MsgBoxStyle.Information, "Confirmar")
            Else
                MsgBox("El usario no aprobo las validaciones.", MsgBoxStyle.Critical, "Confirmar")
            End If
        Else
            MsgBox("Debe chequear las validaciones activas.", MsgBoxStyle.Exclamation, "Confirmar")
        End If


    End Sub


End Class