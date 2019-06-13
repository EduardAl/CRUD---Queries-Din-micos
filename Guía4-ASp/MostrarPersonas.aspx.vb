Public Class MostrarPersonas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim texto As String = "SELECT * FROM Personas"
        Dim abc As New Class1
        abc.ini()
        abc.recibe(texto)
        Response.Write("<table class=""table table-striped"">")
        Response.Write("<thead class=""thead-dark"">")
        Response.Write("<tr>")
        Response.Write("<th scope="" col"">Id</th>")
        Response.Write("<th scope="" col"">Nombre</th>")
        Response.Write("<th scope="" col"">Apellido</th>")
        Response.Write("<th scope="" col"">Correo</th>")
        Response.Write("<th scope="" col"">Edad</th>")
        Response.Write("<th scope="" col"">Sexo</th>")
        Response.Write("<th scope="" col"">Acciones</th>")
        Response.Write("</tr>")
        Response.Write("</thead>")
        Response.Write("<tbody>")
        While abc.reg.Read
            Dim Sexo As String
            If abc.reg("Sexo").Equals("M") Then
                Sexo = "Masculino"
            Else
                Sexo = "Femenino"
            End If
            Response.Write("<tr>")
            Response.Write("<th scope=""row"">" & abc.reg("Id") & "</th>")
            Response.Write("<td>" & abc.reg("Nombre") & "</td>")
            Response.Write("<td>" & abc.reg("Apellido") & "</td>")
            Response.Write("<td>" & abc.reg("Correo") & "</td>")
            Response.Write("<td>" & abc.reg("Edad") & "</td>")
            Response.Write("<td>" & Sexo & "</td>")
            Response.Write("<td><a href=EliminarPersona.aspx?eli=" & abc.reg("Id") & ">Eliminar</a><a href=EditarPersona.aspx?edit=" & abc.reg("Id") & ">   Editar</a></td>")
            Response.Write("</tr>")
        End While
        Response.Write("</tbody></table>")
    End Sub

End Class