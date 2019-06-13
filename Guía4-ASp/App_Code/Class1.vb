Imports System.Data.SqlClient

Imports Microsoft.VisualBasic
Public Class Class1
    Public cnn As New SqlConnection
    Public reg As SqlDataReader
    'Creo un metodo donde agrego el atributo donde guardo la conexión, y creo la creo, además de
    'usar un Try para que Me envie un mensaje amigable por cualquier Error de conexión. 
    Public Sub ini()
        cnn.ConnectionString = ("Data Source=EDUARD\EDUARD;Initial Catalog=guia3;User ID=sa;Password=181912")
        Try
            cnn.Open()
        Catch ex As Exception
            MsgBox("Error de conexión")
        End Try
    End Sub
    'Creo un metodo para usarlo cuando quiera cerrar la conexión. 
    Public Sub fin()
        cnn.Close()
    End Sub
    'Creo un metodo que Me sirve para ejecutar las consultas del programa, para ser mas
    'específicos las de INSERT INTO, DELETE y UPDATE, las cuales no devuelven datos.
    Public Sub envia(ByVal texto As String)
        Dim con As New SqlCommand(texto, cnn)
        con.ExecuteNonQuery()
    End Sub
    'Creo un metodo que Me sirve para ejecutar las consultas del programa, para ser mas 
    'específicos las de Select, porque estas devuelven datos, aquí regreso la variable reg con el 
    'resultado de la consulta. 
    Public Function recibe(ByVal texto As String) As SqlDataReader
        Dim con As New SqlCommand(texto, cnn)
        con.ExecuteNonQuery()
        reg = con.ExecuteReader
        Return reg
    End Function
End Class
