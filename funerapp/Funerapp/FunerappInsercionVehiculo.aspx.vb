﻿
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
        marca = TxtMarca.Text

        Dim referencia As String
        referencia = TxtRefrencia.Text

        Dim modelo As String
        modelo = TxtModelo.Text



        Dim fechaTec As Date = TxtTecnomecanica.Text
        Dim fechaFormateadaTec As String
        fechaFormateadaTec = fechaTec.ToString("yy-MM-dd")



        Dim fechaSoat As Date = TxtSoat.Text
        Dim fechaFormateadaSoat As String
        fechaFormateadaSoat = fechaSoat.ToString("yy-MM-dd")


        Dim placa As String
        placa = TxtPlaca.Text

        Dim foto As String = Path.GetDirectoryName(fuploadChek.PostedFile.FileName)
        LblCheck.Text = foto





        guardarCarroza(marca, referencia, modelo, fechaFormateadaTec, fechaFormateadaSoat, placa, foto)



    End Sub

    Public Sub guardarCarroza(marca As String, referencia As String, modelo As String, fechaFormateadaTec As String, fechaFormateadaSoatt As String, placa As String, foto As String)
        Try
            Dim cnn As New MySqlConnection()
            cnn.ConnectionString = Session("Conectar")
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Dim consulta As New MySqlCommand("INSERT INTO vehiculos(marca,referencia,modelo,fecha_vencimiento_tecnomecanica,fecha_vencimiento_soat, Placa, rutaFoto)
                                             VALUES(@marca,@referencia, @modelo, @fechTec, @fechSoat, @Placa, @foto)", cnn)


            consulta.Parameters.Add(New MySqlParameter("@marca", marca))
            consulta.Parameters.Add(New MySqlParameter("@referencia", referencia))
            consulta.Parameters.Add(New MySqlParameter("@modelo", modelo))
            consulta.Parameters.Add(New MySqlParameter("@fechTec", fechaFormateadaTec))
            consulta.Parameters.Add(New MySqlParameter("@fechSoat", fechaFormateadaSoatt))
            consulta.Parameters.Add(New MySqlParameter("@Placa", placa))
            consulta.Parameters.Add(New MySqlParameter("@foto", foto))
            'consulta.Parameters.Add(New MySqlParameter("@byts", System.Data.SqlDbType.Bit).Value = byts)

            Dim resultado As MySqlDataReader
            resultado = consulta.ExecuteReader
            If resultado.Read() Then

                MsgBox("Regustri Exitoso.", MsgBoxStyle.Critical, "Confirmar")
            Else
                MsgBox("no Exitoso")
            End If



            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If

        Catch ex As Exception
            Me.Label1.Text = ex.Message
        End Try



        'Try
        '    Dim con As New MySqlConnection()
        '    con.ConnectionString = Session("conectar")

        '    Dim ds As New DataSet()
        '    Dim da As New MySqlDataAdapter("INSERT INTO vehiculos(marca,referencia,modelo,fecha_vencimiento_tecnomecanica,fecha_vencimiento_soat)
        '                                    VALUES('" & TxtMarca.Text & "','" & TxtRefrencia.Text & "','" & TxtModelo.Text & "',
        '                                            '" & TxtTecnomecanica.Text & "','" & TxtSoat.Text & "')", con)
        '    da.Fill(ds, "contactos")
        '    Me.Label1.Text = "insercion Correcta"



        'Catch ex As Exception
        '    Me.Label1.Text = ex.Message

        'End Try
    End Sub


    Private Function ValidaExtension(ByVal sExtension As String) As Boolean

        Select Case sExtension
            Case ".jpg", ".jpeg", ".png"
                Return True
            Case Else
                Return False
        End Select
    End Function

    'Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
    '    Dim sExt As String = String.Empty
    '    Dim sName As String = String.Empty
    '    foto.Width = 0
    '    foto.Width = 0
    '    foto.ImageUrl = ""
    '    If fuploadCarroza.HasFile Then
    '        sName = fuploadCarroza.PostedFile.FileName
    '        sExt = Path.GetExtension(sName)



    '        If ValidaExtension(sExt) Then
    '            fuploadCarroza.SaveAs(MapPath("~/imagenes/" & sName))
    '            foto.Width = 300
    '            foto.Width = 300
    '            foto.ImageUrl = "~/imagenes/" & sName

    '            LblFoto.Text = "Se Cargó la Foto"

    '        Else
    '            LblFoto.Text = "El archivo no es de tipo imagen"
    '        End If
    '    Else
    '        LblFoto.Text = "Seleccione el archivo que desea subir."
    '    End If

    'End Sub

    Protected Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'Dim sExt As String = String.Empty
        'Dim sName As String = String.Empty
        'check.Width = 0
        'check.Width = 0
        'check.ImageUrl = ""
        'If fuploadChek.HasFile Then
        '    sName = fuploadChek.PostedFile.FileName
        '    sExt = Path.GetExtension(sName)



        '    If ValidaExtension(sExt) Then
        '        'fuploadChek.SaveAs(MapPath("~/imagenes/" & sName))
        '        check.Width = 300
        '        check.Width = 300
        '        check.ImageUrl = "~/imagenes/" & sName

        '        LblCheck.Text = "Se Cargó la Foto"

        '    Else
        '        LblCheck.Text = "El archivo no es de tipo imagen"
        '    End If
        'Else
        '    LblCheck.Text = "Seleccione el archivo que desea subir."
        'End If

        Dim foto As String = Path.GetDirectoryName(fuploadChek.PostedFile.FileName)
        LblCheck.Text = foto
    End Sub
End Class