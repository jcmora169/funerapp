Public Class FunerappInsercionVehiculo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            CalendarSoat.Visible = False
            CalendarTecno.Visible = False


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
        Dim Tamaniofoto As Integer
        Dim TamanioCheck As Integer
        Tamaniofoto = fuploadimagen.PostedFile.ContentLength
        TamanioCheck = fuploadChek.PostedFile.ContentLength

    End Sub
End Class