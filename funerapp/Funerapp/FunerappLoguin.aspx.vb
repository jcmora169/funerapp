Imports MySql.Data.MySqlClient

Public Class FunerappLoguin
    Inherits System.Web.UI.Page

    Public Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("Conectar") = System.Web.Configuration.WebConfigurationManager.AppSettings("ConectarMySql").ToString
    End Sub

    Public Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click

        Dim usuario As String
        usuario = TxtUsuario.Text
        Dim contraseña As String
        contraseña = TxtContraseña.Text
        iniciarSesion(usuario, contraseña)




    End Sub

    Public Sub iniciarSesion(usuario As String, contraseña As String)
        Try
            Dim cnn As New MySqlConnection()
            cnn.ConnectionString = Session("Conectar")
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim consulta As New MySqlCommand("SELECT usuario, contrasena FROM usuarios where usuario = @USUARIO", cnn)
            consulta.Parameters.Add(New MySqlParameter("@USUARIO", usuario))
            Dim resultado As MySqlDataReader
            resultado = consulta.ExecuteReader
            If resultado.Read() Then
                If resultado.Item("usuario").ToString = usuario And resultado.Item("contrasena").ToString = contraseña Then
                    MsgBox("Ingreso exitoso.", MsgBoxStyle.Information, "Confirmar")
                    Response.Redirect("FunerappMenuCordinador.aspx?parametro=" + TxtUsuario.Text)
                    Response.("FunerappValidacionConductor.aspx?parametro=" + TxtUsuario.Text)
                Else
                    MsgBox("La contraseña es incorrecta.", MsgBoxStyle.Critical, "Confirmar")
                End If
            Else
                MsgBox("El usuario no existe.")
            End If


            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

        Catch ex As Exception
            Me.LbError.Text = ex.Message
        End Try
    End Sub


End Class