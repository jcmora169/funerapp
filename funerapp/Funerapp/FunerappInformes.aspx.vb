Public Class FunerappInformes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LbUser.Text = Session("usuarioS")
    End Sub

End Class