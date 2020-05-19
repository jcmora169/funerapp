Imports System.Web.DynamicData
Imports Google.Protobuf.WellKnownTypes

Public Class FunerappMenuCordinador
    Inherits System.Web.UI.Page

    Public Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        LbUser.Text = Session("usuarioS")

    End Sub


End Class