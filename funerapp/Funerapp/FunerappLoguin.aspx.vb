Imports Google.Protobuf.WellKnownTypes
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
        Session("usuarioS") = usuario
        Dim idUsuario As Integer
        If usuario = "jamartin" Then
            idUsuario = 2
            comprobarValidacionesConductor(idUsuario)
            If Session("APIS") Then
                iniciarSesion(usuario, contraseña)
            End If
        Else
            iniciarSesion(usuario, contraseña)
        End If






    End Sub

    Public Sub iniciarSesion(usuario As String, contraseña As String)
        Try
            Dim cnn As New MySqlConnection()
            cnn.ConnectionString = Session("Conectar")
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim consulta As New MySqlCommand("SELECT id_usuario,usuario, contrasena, id_perfil FROM usuarios where usuario = @USUARIO", cnn)
            consulta.Parameters.Add(New MySqlParameter("@USUARIO", usuario))
            Dim resultado As MySqlDataReader
            resultado = consulta.ExecuteReader

            If resultado.Read() Then


                If resultado.Item("usuario").ToString = usuario And resultado.Item("contrasena").ToString = contraseña Then
                    MsgBox("Ingreso exitoso.", MsgBoxStyle.Information, "Confirmar")
                    If resultado.Item("id_perfil") = 2 Then
                        Response.Redirect("FunerappMenuCordinador.aspx")
                    Else
                        Response.Redirect("FunerappMenuConductor.aspx")
                    End If

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






    Public Sub comprobarValidacionesConductor(idUsuario As Integer)
        Try
            Dim fechaActual As Date = Date.Now
            Dim aprobadoParaIniciarSesion As Boolean = False
            Dim cnn As New MySqlConnection()
            cnn.ConnectionString = Session("Conectar")
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim consulta1 As New MySqlCommand("SELECT  calificacion  FROM validaciones_us where id_usuario = @IDUSUARIO and fecha_validacion = curdate() and id_validacion = 1 ", cnn)
            consulta1.Parameters.Add(New MySqlParameter("@IDUSUARIO", idUsuario))

            Dim resultado1 As MySqlDataReader
            resultado1 = consulta1.ExecuteReader
            If resultado1.Read() Then
                If resultado1.Item("calificacion") = "Aprobado" Then
                    aprobadoParaIniciarSesion = True
                Else
                    aprobadoParaIniciarSesion = False
                    MsgBox("No se puede iniciar sesión por que el usuario no ha realizado las validaciones o no aprobó las validaciones realizadas, por favor comunicarse con su coordinador.", MsgBoxStyle.Critical, "Confirmar")
                End If
            Else
                aprobadoParaIniciarSesion = False
                MsgBox("No se puede iniciar sesión por que el usuario no ha realizado las validaciones o no aprobó las validaciones realizadas, por favor comunicarse con su coordinador.", MsgBoxStyle.Critical, "Confirmar")
            End If

            Session("APIS") = aprobadoParaIniciarSesion

            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

        Catch ex As Exception
            Me.LbError.Text = ex.Message
        End Try
    End Sub


End Class