Public Class EditarPersona
    Inherits System.Web.UI.Page

    Dim VarEdit As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        VarEdit = Request.QueryString("edit")
        If Not IsPostBack Then
            Dim texto As String = "SELECT * FROM Personas where id =" & VarEdit
            Dim abc As New Class1
            abc.ini()
            abc.recibe(texto)
            Response.Write("<table border =0>")
            While abc.reg.Read
                Dim sexo As String
                If abc.reg("Sexo").Equals("M") Then
                    sexo = "Masculino"
                Else
                    sexo = "Femenino"
                End If
                TxtNombre.Text = abc.reg("Nombre")
                TxtApellido.Text = abc.reg("Apellido")
                TxtCorreo.Text = abc.reg("Correo")
                TxtEdad.Text = abc.reg("Edad")
                DDLSexo.SelectedValue = sexo
            End While
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim abc As New Class1
        Dim texto As String
        texto = "Update Personas  Set Nombre = '" & TxtNombre.Text & "',Apellido = '" & TxtApellido.Text & "', Correo = '" & TxtCorreo.Text & "', Edad = '" & TxtEdad.Text & "' , Sexo = '" & DDLSexo.SelectedValue.ToString() & "'where id =" & VarEdit
        abc.ini()
        abc.envia(texto)
        abc.fin()
        Response.Redirect("MostrarPersonas.aspx")
    End Sub
End Class