Public Class Editar
    Inherits System.Web.UI.Page
    Dim VarEdit As String
    Dim PicEli As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        VarEdit = Request.QueryString("edit")
        PicEli = Request.QueryString("edit2")
        If Not IsPostBack Then
            Dim texto As String = "SELECT * FROM album where id =" & VarEdit
            Dim abc As New Class1
            abc.ini()
            abc.recibe(texto)
            Response.Write("<table border =0>")
            While abc.reg.Read
                Image1.ImageUrl = "capturas/" & abc.reg("Foto")
                Image1.Width = 100
                Image1.Height = 100

                TitulFoto.Text = abc.reg("Titulo")
                DescripFoto.Text = abc.reg("Descripcion")
            End While
        End If

    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim abc As New Class1
        Dim sName As String = ArchivoFoto.FileName()
        Dim texto As String
        If ArchivoFoto.HasFile Then
            texto = "Update album  Set Titulo = '" & TitulFoto.Text & "',Foto = '" & ArchivoFoto.FileName & "', Descripcion = '" & DescripFoto.Text & "' where id =" & VarEdit
            Dim borra As String = MapPath("~/capturas/" & PicEli)
            Try
                Kill(borra)
            Catch ex As Exception
            End Try
            ArchivoFoto.SaveAs(MapPath("~/capturas/" & sName))
        Else
            texto = "Update album  set Titulo = '" & TitulFoto.Text & "',Foto = '" & PicEli & "', Descripcion = '" & DescripFoto.Text & "' where id =" & VarEdit
        End If

        abc.ini()
        abc.envia(texto)
        abc.fin()
        Response.Redirect("Default.aspx")
    End Sub
End Class