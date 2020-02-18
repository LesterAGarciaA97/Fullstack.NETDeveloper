Imports System.Data.SqlClient
Public Class Form1
    Private Conexion As New SqlConnection("Server=HP-PAVILION14;Database=Agenda2017I013H;Trusted_Connection=True;")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Resultado As DataSet
    End Sub
    Public Sub ActualizarUsuarios()
        Dim Resultado As DataSet
        Resultado = Consultar_Usuarios()
        grdUsuarios.DataSource = Resultado
        grdUsuarios.DataMember = Resultado.Tables("Usuarios").TableName
    End Sub
    Public Sub Agregar_Usuarios()
        'Crear el objeto con el nombre del procedimiento almacenado
        Dim Procedimiento As New SqlCommand("sp_AgregarUsuario", Conexion)
        'Especificar el tipo de objeto, este será de tipo "StoreProcedure" (Procedimiento almacenado)
        Procedimiento.CommandType = CommandType.StoredProcedure
        'Crear los parametros con sus respectivos nombres y tipo de dato
        Dim Nombre As SqlParameter = Procedimiento.Parameters.Add("@nombre", SqlDbType.VarChar)
        Dim Login As SqlParameter = Procedimiento.Parameters.Add("@login", SqlDbType.VarChar)
        Dim Password As SqlParameter = Procedimiento.Parameters.Add("@password", SqlDbType.VarChar)
        Dim Email As SqlParameter = Procedimiento.Parameters.Add("@email", SqlDbType.VarChar)
        Dim CodigoRol As SqlParameter = Procedimiento.Parameters.Add("@codigoRol", SqlDbType.Int)
        'Determinar el tipo de parámetro si es de entrada o de salida
        Nombre.Direction = ParameterDirection.Input
        Login.Direction = ParameterDirection.Input
        Password.Direction = ParameterDirection.Input
        Email.Direction = ParameterDirection.Input
        CodigoRol.Direction = ParameterDirection.Input
        'Asignar valores a los parámteros
        Nombre.Value = txtNombre.Text
        Login.Value = txtLogin.Text
        Password.Value = txtPassword.Text
        Email.Value = txtEmail.Text
        CodigoRol.Value = 1
        'Ejecutar el procedimiento
        Conexion.Open()
        Procedimiento.ExecuteNonQuery()
        Conexion.Close()
        ActualizarUsuarios()
    End Sub
    Public Function Consultar_Usuarios() As DataSet
        'Dataset para obtener los datos que retorna el procedimiento almacenado
        Dim Usuarios As New DataSet
        Try
            'DataAdapter permite colocar el procedimiento a ejecutar y la cadena de conexión
            Dim DataUsuarios As New SqlDataAdapter("execute sp_ConsultarUsuarios", Conexion)
            'Ejecutar el procedimiento y llenar el DataSet con los resultados de la base de datos
            DataUsuarios.Fill(Usuarios, "Usuarios")
        Catch ex As Exception
            MsgBox("Usurios", "Error:" & ex.Message)
        End Try
        Return Usuarios
    End Function

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Agregar_Usuarios()
    End Sub
End Class
