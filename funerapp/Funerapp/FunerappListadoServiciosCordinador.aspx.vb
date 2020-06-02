Imports MySql.Data.MySqlClient

Public Class FunerappListadoServiciosCordinador
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("Conectar") = System.Web.Configuration.WebConfigurationManager.AppSettings("ConectarMySql").ToString
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

            Dim da As New MySqlDataAdapter("SELECT se.id_servicio AS ID_SERVICIO, fa.nombres AS NOMBRES, fa.apellidos AS APELLIDOS, dt.direccion_origen AS DIRECCION_ORIGEN, dt.direccion_destino AS DIRECCION_DESTINO FROM servicio AS se  INNER JOIN fallecido AS fa ON fa.id_fallecido = se.idfallecido INNER JOIN datos_traslado AS dt ON dt.id_datos_traslado = se.iddatos_traslado ", cnn)
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



    Public Sub estadoServicio(idServicio As Integer)
        Try
            Dim cnn As New MySqlConnection With {
                            .ConnectionString = Session("Conectar")
                        }
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim consulta As New MySqlCommand("SELECT es.descripcion AS nom_estado FROM servicio AS se INNER JOIN estado AS es ON se.idestado = es.id_estado WHERE se.id_servicio = @IDSERVICIO", cnn)
            consulta.Parameters.Add(New MySqlParameter("@IDSERVICIO", idServicio))
            Dim resultado As MySqlDataReader
            resultado = consulta.ExecuteReader
            If resultado.Read() Then
                Session("estado") = resultado.Item("nom_estado")
            End If
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

        Catch ex As Exception
            Me.Error.Text = ex.Message
        End Try
    End Sub


End Class