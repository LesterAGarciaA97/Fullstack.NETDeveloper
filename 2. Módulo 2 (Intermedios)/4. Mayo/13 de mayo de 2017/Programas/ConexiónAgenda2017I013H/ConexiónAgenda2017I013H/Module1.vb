Module Module1

    Sub Main()
        'Cadena de conexión
        Dim Conexion As New SqlClient.SqlConnection("Server=HP-PAVILION14;Database=Agenda2017I013H;Trusted_Connection=True;")
        Try
            Conexion.Open()
            'Con esto podemos insertar datos en la tabla (decripcion) seleccionada de la base de datos trabajada
            'Dim Sentencia As New SqlClient.SqlCommand("insert into Roles (descripcion) values ('Admin')", Conexion)
            'Sentencia.ExecuteNonQuery()
            'Con esto podemos insertar datos en las tablas de Usuarios de la base de datos seleccionada (codigo, usuario, nombre, login, password, email, codigoRol)
            'Dim Sentencia As New SqlClient.SqlCommand("insert into usuarios (nombre,login,password,email,codigoRol) values ('Lester García','LesterG','123','lg@gmail.com',1)", Conexion)
            'Sentencia.ExecuteNonQuery()
            Dim Sentencia As New SqlClient.SqlCommand("execute sp_AgregarUsuario 'Raul López', 'RLopez', '123', 'rl@yahoo.com', 1", Conexion)
            Sentencia.ExecuteNonQuery()
            Conexion.Close()
            Console.WriteLine("Registro realizado")
        Catch ex As SqlClient.SqlException
            If ex.ErrorCode = -2146232060 Then
                Console.WriteLine("El rol no existe")
            End If
            Console.WriteLine(ex.ErrorCode)
            Console.WriteLine("Error {0}", ex.Message)
        Finally
            Conexion.Close()
        End Try
        Console.ReadLine()
    End Sub

End Module
