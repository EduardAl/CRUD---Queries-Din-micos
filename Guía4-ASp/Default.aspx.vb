Public Class About
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim texto As String = "SELECT * FROM album"
        Dim abc As New Class1
        abc.ini()
        abc.recibe(texto)
        Response.Write("<table class=""table table-striped"">")
        Response.Write("<thead class=""thead-dark"">")
        Response.Write("<tr>")
        Response.Write("<th scope="" col"">Imagen</th>")
        Response.Write("<th scope="" col"">Nombre</th>")
        Response.Write("<th scope="" col"">Descripción</th>")
        Response.Write("<th scope="" col"">Acciones</th>")
        Response.Write("</tr>")
        Response.Write("</thead>")
        Response.Write("<tbody>")
        While abc.reg.Read
            Response.Write("<tr>")
            Response.Write("<th scope=""row""><img class=""style1"" height=""100"" width=""100"" src=""capturas/" & abc.reg("Foto") & """/></th>")
            Response.Write("<td>" & abc.reg("Titulo") & "</td>")
            Response.Write("<td>" & abc.reg("Descripcion") & "</td>")
            Response.Write("<td><a href=eliminar.aspx?eli=" & abc.reg("id") & "&eli2=" & abc.reg("foto") & ">Eliminar</a><a href=Editar.aspx?edit=" & abc.reg("id") & "&edit2=" & abc.reg("foto") & ">   Editar</a></td>")
            Response.Write("</tr>")
        End While
        Response.Write("</tbody></table>")
    End Sub
End Class