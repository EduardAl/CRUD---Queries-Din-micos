Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim abc As New Class1
        Dim texto As String = "INSERT INTO album (Titulo,Foto,Descripcion) VALUES ('" &
            TitulFoto.Text & "','" & ArchivoFoto.FileName & "','" & DescripFoto.Text & "')"

        Dim sName As String = ArchivoFoto.FileName()
        If ArchivoFoto.HasFile AndAlso Not DescripFoto.Text.Equals("") AndAlso Not DescripFoto Is Nothing AndAlso Not TitulFoto.Text.Equals("") AndAlso Not TitulFoto Is Nothing Then
            ArchivoFoto.SaveAs(MapPath("~/capturas/" & sName))
            abc.ini()
            abc.envia(texto)
            abc.fin()
            Response.Redirect("Default.aspx")
        Else
            span.InnerText = "Debe rellenar todos los datos"

        End If

    End Sub
End Class