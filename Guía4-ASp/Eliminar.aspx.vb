Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim VarEli As String = Request.QueryString("eli")
        Dim PicEli As String = Request.QueryString("eli2")
        Dim abc As New Class1
        Dim texto As String = "DELETE FROM album WHERE id =" & VarEli
        abc.ini()
        abc.envia(texto)
        Dim borra As String = MapPath("~/capturas/" & PicEli)
        Try
            Kill(borra)
        Catch ex As Exception

        End Try
        Response.Redirect("default.aspx")
    End Sub

End Class