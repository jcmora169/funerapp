Imports MySql.Data.MySqlClient

Public Class FunerappValidacionConductor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("Conectar") = System.Web.Configuration.WebConfigurationManager.AppSettings("ConectarMySql").ToString
        LbUser.Text = Session("usuarioS")

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles BtbBuscarUsuario.Click
        Dim usuario As String
        usuario = TxtUsuario.Text
        consultarUsuario(usuario)
    End Sub

    Private Sub consultarUsuario(usuario As String)
        Try
            Dim cnn As New MySqlConnection With {
                .ConnectionString = Session("Conectar")
            }
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
                Dim usuarioCv As String
                usuarioCv = TxtUsuario.Text
                Try
                    Dim cnn As New MySqlConnection With {
                        .ConnectionString = Session("Conectar")
                    }
                    If cnn.State = ConnectionState.Closed Then
                        cnn.Open()
                    End If
                    Dim consultaUsu As New MySqlCommand("SELECT * FROM usuarios where usuario = @USUARIO", cnn)
                    consultaUsu.Parameters.Add(New MySqlParameter("@USUARIO", usuarioCv))
                    Dim resultadoUsuario As MySqlDataReader
                    resultadoUsuario = consultaUsu.ExecuteReader
                    If resultadoUsuario.Read() Then
                        insertarPrimeraValidacion(resultadoUsuario.Item("id_usuario"))
                        insertarSegundaValidacion(resultadoUsuario.Item("id_usuario"))
                    End If
                    If cnn.State = ConnectionState.Open Then
                        cnn.Close()
                    End If
                Catch ex As Exception
                    Me.Error.Text = ex.Message
                End Try
                MsgBox("El usario aprobo todas las validaciones.", MsgBoxStyle.Information, "Confirmar")
            Else
                MsgBox("El usario no aprobo las validaciones.", MsgBoxStyle.Critical, "Confirmar")
            End If
        Else
            MsgBox("Debe chequear las validaciones activas.", MsgBoxStyle.Exclamation, "Confirmar")
        End If
    End Sub

    Private Sub insertarPrimeraValidacion(usuario As String)
        Dim fechaActual As Date = Date.Now
        Try
            Dim cnn As New MySqlConnection With {
                        .ConnectionString = Session("Conectar")
                    }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim cmd As New MySqlCommand("INSERT INTO validaciones_us (id_usuario, id_validacion, calificacion, fecha_validacion) VALUES( @Id_USUARIO, @ID_VALIDACION, @CALIFICACION, @FECHA_VALIDACION)", cnn)
            cmd.Parameters.Add(New MySqlParameter("@Id_USUARIO", usuario))
            cmd.Parameters.Add(New MySqlParameter("@ID_VALIDACION", 1))
            cmd.Parameters.Add(New MySqlParameter("@CALIFICACION", Me.DplAprobadoAlcoholemia.SelectedValue))
            cmd.Parameters.Add(New MySqlParameter("@FECHA_VALIDACION", fechaActual))
            cmd.ExecuteNonQuery()

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try
    End Sub

    Private Sub insertarSegundaValidacion(usuario As String)
        Dim fechaActual As Date = Date.Now
        Try
            Dim cnn As New MySqlConnection With {
                        .ConnectionString = Session("Conectar")
                    }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim cmd2 As New MySqlCommand("INSERT INTO validaciones_us ( id_usuario, id_validacion, calificacion, fecha_validacion) VALUES( @Id_USUARIO, @ID_VALIDACION, @CALIFICACION, @FECHA_VALIDACION)", cnn)
            cmd2.Parameters.Add(New MySqlParameter("@Id_USUARIO", usuario))
            cmd2.Parameters.Add(New MySqlParameter("@ID_VALIDACION", 2))
            cmd2.Parameters.Add(New MySqlParameter("@CALIFICACION", Me.DplAprobadoInsomnio.SelectedValue))
            cmd2.Parameters.Add(New MySqlParameter("@FECHA_VALIDACION", fechaActual))
            cmd2.ExecuteNonQuery()

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try
    End Sub


End Class