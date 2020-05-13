Imports MySql.Data.MySqlClient
Public Class FunerappValidacionVehiculo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("Conectar") = System.Web.Configuration.WebConfigurationManager.AppSettings("ConectarMySql").ToString

        If Not Page.IsPostBack Then
            iniciarllenadoDropDown()
        End If


    End Sub

    Private Sub iniciarllenadoDropDown()
        Try
            Dim con As New MySqlConnection()
            con.ConnectionString = Session("conectar")

            Dim ds As New DataSet()
            Dim da As New MySqlDataAdapter("SELECT id_vehiculo,placa FROM vehiculos", con)
            da.Fill(ds, "vehiculos")
            Me.Listado.DataSource = ds.Tables("vehiculos")
            Me.Listado.DataValueField = "id_vehiculo" 'Valor Oculto
            Me.Listado.DataTextField = "placa" 'Valor a Mostrar
            Me.Listado.DataBind()
            Me.Listado.Items.Insert(0, New ListItem("Seleccione...", String.Empty))
            Me.Label1.Text = "la consulta se realizo"
        Catch ex As Exception
            Me.Label1.Text = ex.Message
        End Try
    End Sub

    Protected Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub




End Class