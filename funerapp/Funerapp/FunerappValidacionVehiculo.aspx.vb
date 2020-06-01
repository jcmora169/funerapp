Imports MySql.Data.MySqlClient
Public Class FunerappValidacionVehiculo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("Conectar") = System.Web.Configuration.WebConfigurationManager.AppSettings("ConectarMySql").ToString
        LbUser.Text = Session("usuarioS")

        If Not Page.IsPostBack Then
            iniciarllenadoDropDown()
        End If


    End Sub

    Private Sub iniciarllenadoDropDown()
        Try
            Dim con As New MySqlConnection()
            con.ConnectionString = Session("conectar")

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim ds As New DataSet()
            Dim da As New MySqlDataAdapter("SELECT id_vehiculo,placa FROM vehiculos", con)
            da.Fill(ds, "vehiculos")
            Me.Listado.DataSource = ds.Tables("vehiculos")
            Me.Listado.DataValueField = "id_vehiculo" 'Valor Oculto
            Me.Listado.DataTextField = "placa" 'Valor a Mostrar
            Me.Listado.DataBind()
            Me.Listado.Items.Insert(0, New ListItem("Seleccione...", String.Empty))
            Me.Label1.Text = "la consulta se realizo"

            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            Me.Label1.Text = ex.Message
        End Try
    End Sub



    Protected Sub btnRealizarChek_Click(sender As Object, e As EventArgs) Handles btnRealizarChek.Click
        cargarChecklist()
    End Sub

    Private Sub cargarChecklist()
        If Me.ChkSoat.Checked And Me.ChkTecno.Checked And Me.ChkAntifluido.Checked And Me.ChkCamilla.Checked And Me.ChkFugas.Checked And Me.ChkGuantes.Checked And Me.ChkLlantas.Checked And Me.ChkLucesDel.Checked And Me.ChkLucesTra.Checked Then
            If Me.CalificacionAntifluido.SelectedValue = "Aprobado" And Me.CalificacionCamilla.SelectedValue = "Aprobado" And Me.CalificacionFugas.SelectedValue = "Aprobado" And Me.CalificacionGuantes.SelectedValue = "Aprobado" And Me.CalificacionLlantas.SelectedValue = "Aprobado" And Me.CalificacionLucesDel.SelectedValue = "Aprobado" And Me.CalificacionLucesTras.SelectedValue = "Aprobado" And Me.CalificacionSoat.SelectedValue = "Aprobado" And Me.CalificacionTecno.SelectedValue = "Aprobado" Then
                Dim placa As String
                placa = Listado.SelectedValue

                Try
                    Dim cnn As New MySqlConnection With {
                        .ConnectionString = Session("Conectar")
                    }
                    If cnn.State = ConnectionState.Closed Then
                        cnn.Open()
                    End If
                    Dim consultaVeh As New MySqlCommand("SELECT * FROM vehiculos where id_vehiculo = @PLACA", cnn)
                    consultaVeh.Parameters.Add(New MySqlParameter("@PLACA", placa))
                    Dim resultadoVehiculo As MySqlDataReader
                    resultadoVehiculo = consultaVeh.ExecuteReader
                    If resultadoVehiculo.Read() Then
                        inserValidacionAntifluido(resultadoVehiculo.Item("id_vehiculo"))
                        inserValidacionSoat(resultadoVehiculo.Item("id_vehiculo"))
                        inserValidacionTecnot(resultadoVehiculo.Item("id_vehiculo"))
                        inserValidacionLucesDel(resultadoVehiculo.Item("id_vehiculo"))
                        inserValidacionLucesTras(resultadoVehiculo.Item("id_vehiculo"))
                        inserValidacionLlantas(resultadoVehiculo.Item("id_vehiculo"))
                        inserValidacionFugas(resultadoVehiculo.Item("id_vehiculo"))
                        inserValidacionGuantes(resultadoVehiculo.Item("id_vehiculo"))
                        inserValidacionCamilla(resultadoVehiculo.Item("id_vehiculo"))

                    End If
                    If cnn.State = ConnectionState.Open Then
                        cnn.Close()
                    End If
                Catch ex As Exception
                    Me.Error.Text = ex.Message
                End Try

                MsgBox("El Vehiculo aprobo todas las validaciones.", MsgBoxStyle.Information, "Confirmar")
            Else
                MsgBox("El Vehiculo NO aprobo todas las validaciones.", MsgBoxStyle.Critical, "Confirmar")
            End If

        Else
            MsgBox("Debe Seleccionar Todas las validaciones ", MsgBoxStyle.Exclamation, "Confirmar")

        End If

        Limpiar()



    End Sub

    Private Sub inserValidacionAntifluido(vehiculo As String)
        Dim fechaActual As Date = Date.Now
        Try
            Dim cnn As New MySqlConnection With {
                        .ConnectionString = Session("Conectar")
                    }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim cmd As New MySqlCommand("INSERT INTO validaciones_vh (vehiculo, validacion, calificacion, fecha_validacion) VALUES( @VEHICULO, @VALIDACION, @CALIFICACION, @FECHA_VALIDACION)", cnn)
            cmd.Parameters.Add(New MySqlParameter("@VEHICULO", vehiculo))
            cmd.Parameters.Add(New MySqlParameter("@VALIDACION", 11))
            cmd.Parameters.Add(New MySqlParameter("@CALIFICACION", Me.CalificacionAntifluido.SelectedValue))
            cmd.Parameters.Add(New MySqlParameter("@FECHA_VALIDACION", fechaActual))
            cmd.ExecuteNonQuery()

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try

    End Sub

    Private Sub inserValidacionSoat(vehiculo As String)
        Dim fechaActual As Date = Date.Now
        Try
            Dim cnn As New MySqlConnection With {
                        .ConnectionString = Session("Conectar")
                    }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim cmd As New MySqlCommand("INSERT INTO validaciones_vh (vehiculo, validacion, calificacion, fecha_validacion) VALUES( @VEHICULO, @VALIDACION, @CALIFICACION, @FECHA_VALIDACION)", cnn)
            cmd.Parameters.Add(New MySqlParameter("@VEHICULO", vehiculo))
            cmd.Parameters.Add(New MySqlParameter("@VALIDACION", 4))
            cmd.Parameters.Add(New MySqlParameter("@CALIFICACION", Me.CalificacionSoat.SelectedValue))
            cmd.Parameters.Add(New MySqlParameter("@FECHA_VALIDACION", fechaActual))
            cmd.ExecuteNonQuery()

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try

    End Sub

    Private Sub inserValidacionTecnot(vehiculo As String)
        Dim fechaActual As Date = Date.Now
        Try
            Dim cnn As New MySqlConnection With {
                        .ConnectionString = Session("Conectar")
                    }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim cmd As New MySqlCommand("INSERT INTO validaciones_vh (vehiculo, validacion, calificacion, fecha_validacion) VALUES( @VEHICULO, @VALIDACION, @CALIFICACION, @FECHA_VALIDACION)", cnn)
            cmd.Parameters.Add(New MySqlParameter("@VEHICULO", vehiculo))
            cmd.Parameters.Add(New MySqlParameter("@VALIDACION", 5))
            cmd.Parameters.Add(New MySqlParameter("@CALIFICACION", Me.CalificacionTecno.SelectedValue))
            cmd.Parameters.Add(New MySqlParameter("@FECHA_VALIDACION", fechaActual))
            cmd.ExecuteNonQuery()

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try

    End Sub

    Private Sub inserValidacionLucesDel(vehiculo As String)
        Dim fechaActual As Date = Date.Now
        Try
            Dim cnn As New MySqlConnection With {
                        .ConnectionString = Session("Conectar")
                    }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim cmd As New MySqlCommand("INSERT INTO validaciones_vh (vehiculo, validacion, calificacion, fecha_validacion) VALUES( @VEHICULO, @VALIDACION, @CALIFICACION, @FECHA_VALIDACION)", cnn)
            cmd.Parameters.Add(New MySqlParameter("@VEHICULO", vehiculo))
            cmd.Parameters.Add(New MySqlParameter("@VALIDACION", 3))
            cmd.Parameters.Add(New MySqlParameter("@CALIFICACION", Me.CalificacionLucesDel.SelectedValue))
            cmd.Parameters.Add(New MySqlParameter("@FECHA_VALIDACION", fechaActual))
            cmd.ExecuteNonQuery()

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try

    End Sub

    Private Sub inserValidacionLucesTras(vehiculo As String)
        Dim fechaActual As Date = Date.Now
        Try
            Dim cnn As New MySqlConnection With {
                        .ConnectionString = Session("Conectar")
                    }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim cmd As New MySqlCommand("INSERT INTO validaciones_vh (vehiculo, validacion, calificacion, fecha_validacion) VALUES( @VEHICULO, @VALIDACION, @CALIFICACION, @FECHA_VALIDACION)", cnn)
            cmd.Parameters.Add(New MySqlParameter("@VEHICULO", vehiculo))
            cmd.Parameters.Add(New MySqlParameter("@VALIDACION", 6))
            cmd.Parameters.Add(New MySqlParameter("@CALIFICACION", Me.CalificacionLucesTras.SelectedValue))
            cmd.Parameters.Add(New MySqlParameter("@FECHA_VALIDACION", fechaActual))
            cmd.ExecuteNonQuery()

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try

    End Sub

    Private Sub inserValidacionFugas(vehiculo As String)
        Dim fechaActual As Date = Date.Now
        Try
            Dim cnn As New MySqlConnection With {
                        .ConnectionString = Session("Conectar")
                    }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim cmd As New MySqlCommand("INSERT INTO validaciones_vh (vehiculo, validacion, calificacion, fecha_validacion) VALUES( @VEHICULO, @VALIDACION, @CALIFICACION, @FECHA_VALIDACION)", cnn)
            cmd.Parameters.Add(New MySqlParameter("@VEHICULO", vehiculo))
            cmd.Parameters.Add(New MySqlParameter("@VALIDACION", 7))
            cmd.Parameters.Add(New MySqlParameter("@CALIFICACION", Me.CalificacionFugas.SelectedValue))
            cmd.Parameters.Add(New MySqlParameter("@FECHA_VALIDACION", fechaActual))
            cmd.ExecuteNonQuery()

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try

    End Sub

    Private Sub inserValidacionLlantas(vehiculo As String)
        Dim fechaActual As Date = Date.Now
        Try
            Dim cnn As New MySqlConnection With {
                        .ConnectionString = Session("Conectar")
                    }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim cmd As New MySqlCommand("INSERT INTO validaciones_vh (vehiculo, validacion, calificacion, fecha_validacion) VALUES( @VEHICULO, @VALIDACION, @CALIFICACION, @FECHA_VALIDACION)", cnn)
            cmd.Parameters.Add(New MySqlParameter("@VEHICULO", vehiculo))
            cmd.Parameters.Add(New MySqlParameter("@VALIDACION", 8))
            cmd.Parameters.Add(New MySqlParameter("@CALIFICACION", Me.CalificacionLlantas.SelectedValue))
            cmd.Parameters.Add(New MySqlParameter("@FECHA_VALIDACION", fechaActual))
            cmd.ExecuteNonQuery()

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try

    End Sub

    Private Sub inserValidacionCamilla(vehiculo As String)
        Dim fechaActual As Date = Date.Now
        Try
            Dim cnn As New MySqlConnection With {
                        .ConnectionString = Session("Conectar")
                    }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim cmd As New MySqlCommand("INSERT INTO validaciones_vh (vehiculo, validacion, calificacion, fecha_validacion) VALUES( @VEHICULO, @VALIDACION, @CALIFICACION, @FECHA_VALIDACION)", cnn)
            cmd.Parameters.Add(New MySqlParameter("@VEHICULO", vehiculo))
            cmd.Parameters.Add(New MySqlParameter("@VALIDACION", 9))
            cmd.Parameters.Add(New MySqlParameter("@CALIFICACION", Me.CalificacionCamilla.SelectedValue))
            cmd.Parameters.Add(New MySqlParameter("@FECHA_VALIDACION", fechaActual))
            cmd.ExecuteNonQuery()

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try

    End Sub

    Private Sub inserValidacionGuantes(vehiculo As String)
        Dim fechaActual As Date = Date.Now
        Try
            Dim cnn As New MySqlConnection With {
                        .ConnectionString = Session("Conectar")
                    }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim cmd As New MySqlCommand("INSERT INTO validaciones_vh (vehiculo, validacion, calificacion, fecha_validacion) VALUES( @VEHICULO, @VALIDACION, @CALIFICACION, @FECHA_VALIDACION)", cnn)
            cmd.Parameters.Add(New MySqlParameter("@VEHICULO", vehiculo))
            cmd.Parameters.Add(New MySqlParameter("@VALIDACION", 10))
            cmd.Parameters.Add(New MySqlParameter("@CALIFICACION", Me.CalificacionGuantes.SelectedValue))
            cmd.Parameters.Add(New MySqlParameter("@FECHA_VALIDACION", fechaActual))
            cmd.ExecuteNonQuery()

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try

    End Sub


   

    Private Sub consultarfechas(id As String)
        Try
            Dim cnn As New MySqlConnection With {
                .ConnectionString = Session("Conectar")
            }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim consulta As New MySqlCommand("SELECT * FROM vehiculos WHERE id_vehiculo =@ID", cnn)
            consulta.Parameters.Add(New MySqlParameter("@ID", id))
            Dim resultado As MySqlDataReader
            resultado = consulta.ExecuteReader
            If resultado.Read() Then
                TxtSoat.Text = resultado.Item("fecha_vencimiento_soat")
                TxtTecno.Text = resultado.Item("fecha_vencimiento_tecnomecanica")

            End If


            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If

        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try
    End Sub



    Protected Sub BtnFechas_Click(sender As Object, e As EventArgs) Handles BtnFechas.Click
        Dim idVehiculo As String
        idVehiculo = Listado.SelectedValue
        consultarfechas(idVehiculo)
    End Sub

    Private Sub Limpiar()
        TxtSoat.Text = ""
        TxtTecno.Text = ""

    End Sub
End Class