
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class FunerappInsercionVehiculo
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            CalendarSoat.Visible = False
            CalendarTecno.Visible = False
            Session("Conectar") = System.Web.Configuration.WebConfigurationManager.AppSettings("ConectarMySql").ToString

        End If
    End Sub

    Protected Sub BtnSoat_Click(sender As Object, e As ImageClickEventArgs) Handles BtnSoat.Click
        If CalendarSoat.Visible Then
            CalendarSoat.Visible = False
        End If
        CalendarSoat.Visible = True
    End Sub

    Protected Sub ImageButton3_Click(sender As Object, e As ImageClickEventArgs) Handles btnTecno.Click
        If CalendarTecno.Visible Then
            CalendarTecno.Visible = False
        End If
        CalendarTecno.Visible = True
    End Sub

    Protected Sub CalendarTecno_SelectionChanged(sender As Object, e As EventArgs) Handles CalendarTecno.SelectionChanged
        Dim fechaTecno As Date
        TxtTecnomecanica.Text = CalendarTecno.SelectedDate.ToShortDateString
        fechaTecno = TxtTecnomecanica.Text
        TxtTecnomecanica.Text = Format(fechaTecno, "yyyy-MM-dd")


        CalendarTecno.Visible = False
    End Sub

    Protected Sub CalendarSoat_SelectionChanged(sender As Object, e As EventArgs) Handles CalendarSoat.SelectionChanged
        Dim fechasoat As Date
        TxtSoat.Text = CalendarSoat.SelectedDate.ToShortDateString
        fechasoat = TxtSoat.Text
        TxtSoat.Text = Format(fechasoat, "yyyy-MM-dd")
        CalendarSoat.Visible = False
    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim marca As String
        Dim referencia As String
        Dim modelo As String
        Dim fechaTecno As Date
        Dim fechaSoat As Date
        Dim placa As String







    End Sub

    Public Sub guardarCarroza(usuario As String, contraseña As String)

    End Sub


    Private Function ValidaExtension(ByVal sExtension As String) As Boolean

        Select Case sExtension
            Case ".jpg", ".jpeg", ".png"
                Return True
            Case Else
                Return False
        End Select
    End Function

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        Dim sExt As String = String.Empty
        Dim sName As String = String.Empty
        foto.Width = 0
        foto.Width = 0
        foto.ImageUrl = ""
        If fuploadCarroza.HasFile Then
            sName = fuploadCarroza.PostedFile.FileName
            sExt = Path.GetExtension(sName)



            If ValidaExtension(sExt) Then
                fuploadCarroza.SaveAs(MapPath("~/imagenes/" & sName))
                foto.Width = 300
                foto.Width = 300
                foto.ImageUrl = "~/imagenes/" & sName

                LblFoto.Text = "Se Cargó la Foto"

            Else
                LblFoto.Text = "El archivo no es de tipo imagen"
            End If
        Else
            LblFoto.Text = "Seleccione el archivo que desea subir."
        End If

    End Sub

    Protected Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim sExt As String = String.Empty
        Dim sName As String = String.Empty
        check.Width = 0
        check.Width = 0
        check.ImageUrl = ""
        If fuploadChek.HasFile Then
            sName = fuploadChek.PostedFile.FileName
            sExt = Path.GetExtension(sName)



            If ValidaExtension(sExt) Then
                'fuploadChek.SaveAs(MapPath("~/imagenes/" & sName))
                check.Width = 300
                check.Width = 300
                check.ImageUrl = "~/imagenes/" & sName

                LblCheck.Text = "Se Cargó la Foto"

            Else
                LblCheck.Text = "El archivo no es de tipo imagen"
            End If
        Else
            LblCheck.Text = "Seleccione el archivo que desea subir."
        End If
    End Sub
End Class