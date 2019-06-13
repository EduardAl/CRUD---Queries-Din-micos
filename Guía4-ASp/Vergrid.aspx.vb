Public Class Contact
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim strcon As String = "SELECT * FROM album"
        Dim abc As New Class1
        abc.ini()
        abc.recibe(strcon)
        GridView1.DataSource = abc.reg
        GridView1.DataBind()
    End Sub
End Class