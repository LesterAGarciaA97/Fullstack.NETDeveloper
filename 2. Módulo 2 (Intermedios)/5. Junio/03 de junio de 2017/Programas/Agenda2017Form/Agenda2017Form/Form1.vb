Imports System.Data.SqlClient
Public Class Form1
    Private Conexion As New SqlConnection("Server=HP-PAVILION14;Database=Agenda2017I013H;Trusted_Connection=True;")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarUsuarios()
        ToolStripButton1.Enabled = True
        ToolStripButton2.Enabled = False
        ToolStripButton3.Enabled = True
        ToolStripButton4.Enabled = True
        ToolStripButton5.Enabled = True
        ToolStripButton6.Enabled = True
    End Sub
    Public Sub ActualizarUsuarios()
        Dim Resultado As DataSet
        Resultado = Consultar_Usuarios()
        grdUsuarios.DataSource = Resultado
        grdUsuarios.DataMember = Resultado.Tables("Usuarios").TableName
        grdUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Public Sub ModificarUsuario()
        Try
            'Crear el objeto con el nombre del procedimiento almacenado
            Dim Procedimiento As New SqlCommand("sp_ModificarUsuario", Conexion)
            'Especificar el tipo de objeto, este será de tipo "StoreProcedure" (Procedimiento almacenado)
            Procedimiento.CommandType = CommandType.StoredProcedure
            'Crear los parametros con sus respectivos nombres y tipo de dato
            Dim CodigoUsuario As SqlParameter = Procedimiento.Parameters.Add("@CodigoUsuario", SqlDbType.Int)
            CodigoUsuario.Direction = ParameterDirection.Input
            Dim Nombre As SqlParameter = Procedimiento.Parameters.Add("@nombre", SqlDbType.VarChar)
            Nombre.Direction = ParameterDirection.Input
            Dim Login As SqlParameter = Procedimiento.Parameters.Add("@login", SqlDbType.VarChar)
            Login.Direction = ParameterDirection.Input
            Dim Password As SqlParameter = Procedimiento.Parameters.Add("@password", SqlDbType.VarChar)
            Password.Direction = ParameterDirection.Input
            Dim Email As SqlParameter = Procedimiento.Parameters.Add("@email", SqlDbType.VarChar)
            Email.Direction = ParameterDirection.Input
            Dim Rol As SqlParameter = Procedimiento.Parameters.Add("@rol", SqlDbType.Int)
            Rol.Direction = ParameterDirection.Input

            CodigoUsuario.Value = grdUsuarios.CurrentRow.Cells.Item(0).Value

            Nombre.Value = txtNombre.Text
            Login.Value = txtLogin.Text
            Password.Value = txtPassword.Text
            Email.Value = txtEmail.Text
            Rol.Value = 1

            Conexion.Open()
            Procedimiento.ExecuteNonQuery()
            Conexion.Close()
            ActualizarUsuarios()
        Catch ex As Exception
            MsgBox("Error " & ex.Message)
        End Try
    End Sub
    Public Sub EliminarUsuario()
        Try
            Dim Respuesta As MsgBoxResult = MsgBoxResult.No
            Respuesta = MsgBox("¿Está seguro de eliminar el registro?", 292, "Eliminar")
            If Respuesta = MsgBoxResult.Yes Then
                Dim Procedimiento As New SqlCommand("sp_EliminarUsuario", Conexion)
                Procedimiento.CommandType = CommandType.StoredProcedure
                Dim CodigoUsuario As SqlParameter = Procedimiento.Parameters.Add("@CodigoUsuario", SqlDbType.Int)
                CodigoUsuario.Direction = ParameterDirection.Input
                CodigoUsuario.Value = grdUsuarios.CurrentRow.Cells.Item(0).Value
                Conexion.Open()
                Procedimiento.ExecuteNonQuery()
                Conexion.Close()
                ActualizarUsuarios()
            End If
        Catch Ex As Exception
            MsgBox("Error " & Ex.Message)
        End Try
    End Sub
    Public Sub AgregarUsuario()
        'Crear el objeto con el nombre del procedimiento almacenado
        Dim Procedimiento As New SqlCommand("sp_AgregarUsuario", Conexion)
        'Especificar el tipo de objeto, este será de tipo StoredProcedure
        Procedimiento.CommandType = CommandType.StoredProcedure
        'Crear los parametros con sus respectivos nombres y tipo de dato
        Dim Nombre As SqlParameter = Procedimiento.Parameters.Add("@nombre", SqlDbType.VarChar)
        Dim Login As SqlParameter = Procedimiento.Parameters.Add("@login", SqlDbType.VarChar)
        Dim Password As SqlParameter = Procedimiento.Parameters.Add("@password", SqlDbType.VarChar)
        Dim Email As SqlParameter = Procedimiento.Parameters.Add("@email", SqlDbType.VarChar)
        Dim CodigoRol As SqlParameter = Procedimiento.Parameters.Add("@codigoRol", SqlDbType.Int)
        'Determinar el tipo de parametro si es de entrada ó salida
        Nombre.Direction = ParameterDirection.Input
        Login.Direction = ParameterDirection.Input
        Password.Direction = ParameterDirection.Input
        Email.Direction = ParameterDirection.Input
        CodigoRol.Direction = ParameterDirection.Input
        'Asignar valores a los parametros
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
            'DataAdapter permite colocar el procedimiento a ejecutar y la cadena de conexion
            Dim DataUsuarios As New SqlDataAdapter("execute sp_ConsultarUsuarios", Conexion)
            'Ejecutar el procedimiento y llenar el DataSet con los resultados de la base de datos
            DataUsuarios.Fill(Usuarios, "Usuarios")
        Catch ex As Exception
            MsgBox("Error:" & ex.Message, 16, "Usuarios")
        End Try
        Return Usuarios
    End Function

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        AgregarUsuario()
        ToolStripButton1.Enabled = True
        ToolStripButton2.Enabled = False
        ToolStripButton3.Enabled = True
        ToolStripButton4.Enabled = True
        ToolStripButton5.Enabled = True
        ToolStripButton6.Enabled = True
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        EliminarUsuario()
    End Sub
    Private Sub grdUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdUsuarios.CellClick
        If Me.grdUsuarios.SelectedRows.Count > 0 Then
            With Me.grdUsuarios.CurrentRow.Cells
                txtNombre.Text = .Item(1).Value
                txtLogin.Text = .Item(2).Value
                txtPassword.Text = .Item(3).Value
                txtEmail.Text = .Item(4).Value
            End With
            Consultar_Contactos_Por_Usuario()
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        txtNombre.ReadOnly = False
        txtLogin.ReadOnly = False
        txtPassword.ReadOnly = False
        txtEmail.ReadOnly = False
        ToolStripButton1.Enabled = False
        ToolStripButton2.Enabled = False
        ToolStripButton3.Enabled = False
        ToolStripButton4.Enabled = False
        ToolStripButton5.Enabled = True
        ToolStripButton6.Enabled = True
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        ModificarUsuario()
        ToolStripButton1.Enabled = True
        ToolStripButton2.Enabled = False
        ToolStripButton3.Enabled = False
        ToolStripButton4.Enabled = True
        ToolStripButton5.Enabled = False
        ToolStripButton6.Enabled = True
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Consultar_Contactos_Por_Usuario()
    End Sub
    Public Sub Consultar_Contactos_Por_Usuario()
        Try
            Dim Procedimiento As New SqlCommand("sp_ConsultarContactosPorUsuario", Conexion)
            Procedimiento.CommandType = CommandType.StoredProcedure
            Dim CodigoUsuario As SqlParameter = Procedimiento.Parameters.Add("@CodigoUsuario", SqlDbType.Int)
            CodigoUsuario.Direction = ParameterDirection.Input
            CodigoUsuario.Value = grdUsuarios.CurrentRow.Cells.Item(0).Value
            Conexion.Open()
            Dim Resultado As SqlClient.SqlDataReader
            Dim TablaContactos As New DataTable
            Resultado = Procedimiento.ExecuteReader()
            TablaContactos.Load(Resultado)
            Me.grdContactos.DataSource = TablaContactos
            Me.grdContactos.Refresh()
            Me.grdContactos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Conexion.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles BtnNuevoContacto.Click
        If Me.grdUsuarios.SelectedRows.Count > 0 Then
            'Desactivar los cuadros de texto
            Me.txtApellidos.ReadOnly = False
            Me.txtNombres.ReadOnly = False
            'Activar y desactivar los botones
            Me.BtnNuevoContacto.Enabled = False
            Me.BtnGuardarContacto.Enabled = True
            Me.BtnEliminarContacto.Enabled = False
        Else
            MsgBox("Debe seleccionar un usuario", 16, "Agregar contacto")
        End If
    End Sub

    Private Sub BtnGuardarContacto_Click(sender As Object, e As EventArgs) Handles BtnGuardarContacto.Click
        Try
            Dim Procedimiento As New SqlCommand("sp_AgregarContacto", Conexion)
            Procedimiento.CommandType = CommandType.StoredProcedure
            Dim CodigoUsuario As SqlParameter = Procedimiento.Parameters.Add("@CodigoUsuario", SqlDbType.Int)
            CodigoUsuario.Direction = ParameterDirection.Input
            CodigoUsuario.Value = grdUsuarios.CurrentRow.Cells.Item(0).Value
            Dim Nombres As SqlParameter = Procedimiento.Parameters.Add("@Nombres", SqlDbType.VarChar)
            Nombres.Direction = ParameterDirection.Input
            Nombres.Value = txtNombres.Text
            Dim Apellidos As SqlParameter = Procedimiento.Parameters.Add("@Apellidos", SqlDbType.VarChar)
            Apellidos.Direction = ParameterDirection.Input
            Apellidos.Value = txtApellidos.Text
            Conexion.Open()
            Procedimiento.ExecuteNonQuery()
            Conexion.Close()
            Consultar_Contactos_Por_Usuario()
            BtnGuardarContacto.Enabled = False
            BtnNuevoContacto.Enabled = True
            BtnEliminarContacto.Enabled = True
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, 16, "Agregar Contacto")
        Finally
            Conexion.Close()
        End Try
    End Sub
    Private Sub BtnEliminarContacto_Click(sender As Object, e As EventArgs) Handles BtnEliminarContacto.Click
        If Me.grdContactos.Rows.Count > 0 Then
            Try
                Dim Respuesta As MsgBoxResult = MsgBoxResult.No
                Respuesta = MsgBox("¿Está seguro de eliminar el registro?", 292, "Eliminar contacto")
                If Respuesta = MsgBoxResult.Yes Then
                    Dim Procedimiento As New SqlCommand("sp_EliminarContacto", Conexion)
                    Procedimiento.CommandType = CommandType.StoredProcedure
                    Dim CodigoContacto As SqlParameter = Procedimiento.Parameters.Add("@CodigoContacto", SqlDbType.Int)
                    CodigoContacto.Direction = ParameterDirection.Input
                    CodigoContacto.Value = Me.grdContactos.CurrentRow.Cells.Item(0).Value
                    Procedimiento.ExecuteNonQuery()
                    Conexion.Close()
                    Consultar_Contactos_Por_Usuario()
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, 16, "Eliminar contacto")
            Finally
                Conexion.Close()
            End Try
        Else
            MsgBox("Debe seleccionar un contacto", 16, "Eliminar contacto")
        End If
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        txtNombre.ReadOnly = False
        txtLogin.ReadOnly = False
        txtPassword.ReadOnly = False
        txtEmail.ReadOnly = False
        ToolStripButton1.Enabled = False
        ToolStripButton2.Enabled = True
        ToolStripButton3.Enabled = False
        ToolStripButton4.Enabled = False
        ToolStripButton5.Enabled = False
        ToolStripButton6.Enabled = True
    End Sub
End Class
