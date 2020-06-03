Imports MySql.Data.MySqlClient

Public Class FunerappListadoServiciosConductor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("Conectar") = System.Web.Configuration.WebConfigurationManager.AppSettings("ConectarMySql").ToString
        LbUser.Text = Session("usuarioS")
        If Not Page.IsPostBack Then
            llenarGridView()
        End If
    End Sub

    Public Sub llenarGridView()
        Try
            Dim cnn As New MySqlConnection With {
                .ConnectionString = Session("Conectar")
            }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            Dim da As New MySqlDataAdapter("SELECT se.id_servicio AS ID_SERVICIO, es.descripcion AS ESTADO_SERVICIO, fa.nombres AS NOMBRES, fa.apellidos AS APELLIDOS, dt.direccion_origen AS DIRECCION_ORIGEN, dt.direccion_destino AS DIRECCION_DESTINO FROM servicio AS se  INNER JOIN fallecido AS fa ON fa.id_fallecido = se.idfallecido INNER JOIN datos_traslado AS dt ON dt.id_datos_traslado = se.iddatos_traslado INNER JOIN estado AS es ON se.idestado = es.id_estado WHERE se.idestado = 1 ", cnn)
            Dim dt As DataTable = New DataTable("ServiciosFallecidos")
            da.Fill(dt)
            Me.GvServicios.DataSource = dt
            Me.GvServicios.DataBind()
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try

    End Sub

    Protected Sub GvServicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GvServicios.SelectedIndexChanged

        Session("id_servicio") = Me.GvServicios.SelectedRow.Cells.Item(0).Text
        consultarIdAsginacionVehiculo()
        insertarAsignacionServicio()
        actualizarEstadoServicio()
        Dim usu As String
        usu = Session("usuarioS")
        MsgBox("El servicio fue asignado al usuario: " & usu, MsgBoxStyle.Information, "Confirmar")
        Response.Redirect("FunerappMenuConductor.aspx")

    End Sub
    Public Sub consultarIdAsginacionVehiculo()
        Try
            Dim cnn As New MySqlConnection With {
                              .ConnectionString = Session("Conectar")
                          }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim id_usuario As Integer = 2

            Dim consulta As New MySqlCommand("SELECT id_asignacion_vehiculo FROM asignacion_vehiculo where id_usuario = @ID_USUARIO", cnn)
            consulta.Parameters.Add(New MySqlParameter("@ID_USUARIO", id_usuario))
            Dim resultado As MySqlDataReader
            resultado = consulta.ExecuteReader
            If resultado.Read() Then
                Session("idAsginacionVehiculo") = resultado.Item("id_asignacion_vehiculo")
            End If
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try
    End Sub

    Public Sub insertarAsignacionServicio()
        Try
            Dim fechaRegistro As Date = Date.Now
            Dim cnn As New MySqlConnection With {
                       .ConnectionString = Session("Conectar")
                   }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim cmd As New MySqlCommand("INSERT INTO asignacion_servicio (id_servicio, id_asignacion_vehiculo, id_estado, fecha_asginacion) VALUES( @ID_SERVICIO, @ID_ASIGNACION_VEHICULO, @ESTADO, @FECHA_ASIGNACION)", cnn)
            cmd.Parameters.Add(New MySqlParameter("@ID_SERVICIO", Session("id_servicio")))
            cmd.Parameters.Add(New MySqlParameter("@ID_ASIGNACION_VEHICULO", Session("idAsginacionVehiculo")))
            cmd.Parameters.Add(New MySqlParameter("@ESTADO", 2))
            cmd.Parameters.Add(New MySqlParameter("@FECHA_ASIGNACION", fechaRegistro))
            cmd.ExecuteNonQuery()
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try
    End Sub

    Public Sub actualizarEstadoServicio()
        Try
            Dim fechaRegistro As Date = Date.Now
            Dim cnn As New MySqlConnection With {
                       .ConnectionString = Session("Conectar")
                   }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim cmd As New MySqlCommand("UPDATE servicio SET idestado = 2 WHERE id_servicio = @ID_SERVICIO", cnn)
            cmd.Parameters.Add(New MySqlParameter("@ID_SERVICIO", Session("id_servicio")))
            cmd.ExecuteNonQuery()
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try
    End Sub
End Class