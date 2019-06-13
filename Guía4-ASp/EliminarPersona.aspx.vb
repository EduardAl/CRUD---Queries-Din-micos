Public Class EliminarPersona
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim VarEli As String = Request.QueryString("eli")
        Dim abc As New Class1
        Dim texto As String = "DELETE FROM Personas WHERE id =" & VarEli
        abc.ini()
        abc.envia(texto)
        Response.Redirect("MostrarPersonas.aspx")
    End Sub

End Class