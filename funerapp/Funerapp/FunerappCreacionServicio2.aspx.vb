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
        insertarDatosTraslado(ciudadOrigen, barrioOrigen, direccionOrigen, detalleUbicacionOrigen, fechaRegistro, ciudadDestino, barrioDestino, direccionDestino, detalleUbicacionDestino)
        consultarIdTraslado()
        creacionServicio(fechaRegistro)
        consultarIdServicio()
        Dim id_servicio_final As Integer
        id_servicio_final = Session("idServicio")
        MsgBox("El servicio a sido creado." & vbCrLf & "Id del servicio: " & id_servicio_final, MsgBoxStyle.Information, "Confirmar")
        Response.Redirect("FunerappMenuCordinador.aspx")

    End Sub

    Public Sub insertarDatosTraslado(cOrigen As String, bOrigen As String, dOrigen As String, deOrigen As String, fRegistro As Date,
                                     cDestino As String, bDestino As String, dDestino As String, deDestino As String)
        Try
            Dim cnn As New MySqlConnection With {
                      .ConnectionString = Session("Conectar")
                  }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            Dim cmd As New MySqlCommand("INSERT INTO datos_traslado (ciudad_origen, barrio_origen, direccion_origen, detalle_ubicacion_origen,id_fallecido,fecha_registro, ciudad_destino, barrio_destino, direccion_destino, detalle_ubicacion_destino) VALUES( @CIUDAD_ORIGEN, @BARRIO_ORIGEN, @DIRECCION_ORIGEN, @DETALLE_UBICACION_ORIGEN, @ID_FALLECIDO, @FECHA_REGISTRO, @CIUDAD_DESTINO, @BARRIO_DESTINO, @DIRECCION_DESTINO, @DETALLE_UBICACION_DESTINO)", cnn)
            cmd.Parameters.Add(New MySqlParameter("@CIUDAD_ORIGEN", cOrigen))
            cmd.Parameters.Add(New MySqlParameter("@BARRIO_ORIGEN", bOrigen))
            cmd.Parameters.Add(New MySqlParameter("@DIRECCION_ORIGEN", dOrigen))
            cmd.Parameters.Add(New MySqlParameter("@DETALLE_UBICACION_ORIGEN", deOrigen))
            cmd.Parameters.Add(New MySqlParameter("@ID_FALLECIDO", Session("idFallecido")))
            cmd.Parameters.Add(New MySqlParameter("@FECHA_REGISTRO", fRegistro))
            cmd.Parameters.Add(New MySqlParameter("@CIUDAD_DESTINO", cDestino))
            cmd.Parameters.Add(New MySqlParameter("@BARRIO_DESTINO", bDestino))
            cmd.Parameters.Add(New MySqlParameter("@DIRECCION_DESTINO", dDestino))
            cmd.Parameters.Add(New MySqlParameter("@DETALLE_UBICACION_DESTINO", deDestino))
            cmd.ExecuteNonQuery()
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try
    End Sub

    Public Sub consultarIdTraslado()
        Try
            Dim cnn As New MySqlConnection With {
                                 .ConnectionString = Session("Conectar")
                             }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim consulta As New MySqlCommand("SELECT id_datos_traslado FROM datos_traslado where id_fallecido = @ID_FALLECIDO", cnn)
            consulta.Parameters.Add(New MySqlParameter("@ID_FALLECIDO", Session("idFallecido")))
            Dim resultado As MySqlDataReader
            resultado = consulta.ExecuteReader
            If resultado.Read() Then
                Session("idDatosTraslado") = resultado.Item("id_datos_traslado")
            End If
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try
    End Sub

    Public Sub creacionServicio(fechaRegistro As Date)
        Try
            Dim cnn As New MySqlConnection With {
                                .ConnectionString = Session("Conectar")
                            }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim cmd As New MySqlCommand("INSERT INTO servicio (idfallecido, iddatos_traslado, idestado, fecha_servicio) VALUES( @ID_FALLECIDO, @ID_DATOS_TRASLADO, @ID_ESTADO, @FECHA_SERVICIO)", cnn)
            cmd.Parameters.Add(New MySqlParameter("@ID_FALLECIDO", Session("idFallecido")))
            cmd.Parameters.Add(New MySqlParameter("@ID_DATOS_TRASLADO", Session("idDatosTraslado")))
            cmd.Parameters.Add(New MySqlParameter("@ID_ESTADO", 1))
            cmd.Parameters.Add(New MySqlParameter("@FECHA_SERVICIO", fechaRegistro))
            cmd.ExecuteNonQuery()
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If

        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try
    End Sub

    Public Sub consultarIdServicio()
        Try
            Dim cnn As New MySqlConnection With {
                                .ConnectionString = Session("Conectar")
                            }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim consulta As New MySqlCommand("SELECT id_servicio FROM servicio where idfallecido = @ID_FALLECIDO", cnn)
            consulta.Parameters.Add(New MySqlParameter("@ID_FALLECIDO", Session("idFallecido")))
            Dim resultado As MySqlDataReader
            resultado = consulta.ExecuteReader
            If resultado.Read() Then
                Session("idServicio") = resultado.Item("id_servicio")
            End If
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try
    End Sub
End Class