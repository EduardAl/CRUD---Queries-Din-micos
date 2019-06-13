Public Class IngresarPersona
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim abc As New Class1
        Dim texto As String = "INSERT INTO Personas (Nombre, Apellido, Correo, Edad, Sexo) VALUES ('" &
            TxtNombre.Text & "','" & TxtApellido.Text & "','" & TxtCorreo.Text & "'," & TxtEdad.Text & ",'" & DDLSexo.SelectedValue.ToString() & "')"

        abc.ini()
        abc.envia(texto)
        abc.fin()
        Response.Redirect("MostrarPersonas.aspx")
    End Sub
End Class