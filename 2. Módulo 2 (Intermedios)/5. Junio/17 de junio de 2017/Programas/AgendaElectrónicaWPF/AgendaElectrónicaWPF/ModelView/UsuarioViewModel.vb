Imports System.ComponentModel
Imports System.Collections.ObjectModel
Public Class UsuarioViewModel
    Implements INotifyPropertyChanged, ICommand
    'Objeto que permite administrar las entidades a la base de datos
    Private db As New Agenda2017I013HEntities()
    Private _ListaUsuarios As New ObservableCollection(Of Usuarios)
    Private _ListaRoles As New ObservableCollection(Of Roles)
    Private _Modelo As UsuarioViewModel
    Private _Elemento As Roles
    Private _Nombre As String
    Private _Login As String
    Private _Password As String
    Private _Repassword As String
    Private _Email As String
    Private _Rol As Integer
    Public Property ListaRoles As ObservableCollection(Of Roles)
        Get
            Return _ListaRoles
        End Get
        Set(value As ObservableCollection(Of Roles))
            _ListaRoles = value
        End Set
    End Property
    Public Property ListaUsuarios As ObservableCollection(Of Usuarios)
        Get
            Return _ListaUsuarios
        End Get
        Set(value As ObservableCollection(Of Usuarios))
            _ListaUsuarios = value
        End Set
    End Property
    Public Property Elemento As Roles
        Get
            Return _Elemento
        End Get
        Set(value As Roles)
            _Elemento = value
        End Set
    End Property
    Public Property Modelo As UsuarioViewModel
        Get
            Return _Modelo
        End Get
        Set(value As UsuarioViewModel)
            _Modelo = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
            NotificarCambio("Nombre")
        End Set
    End Property
    Public Property Login As String
        Get
            Return _Login
        End Get
        Set(value As String)
            _Login = value
            NotificarCambio("Login")
        End Set
    End Property
    Public Property Password As String
        Get
            Return _Password
        End Get
        Set(value As String)
            _Password = value
            NotificarCambio("Password")
        End Set
    End Property
    Public Property Repassword As String
        Get
            Return _Repassword
        End Get
        Set(value As String)
            _Repassword = value
            NotificarCambio("Repassword")
        End Set
    End Property
    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
            NotificarCambio("Email")
        End Set
    End Property
    Public Property Rol As Integer
        Get
            Return _Rol
        End Get
        Set(value As Integer)
            _Rol = value
            NotificarCambio("Rol")
        End Set
    End Property

    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Public Sub New()
        Me.Modelo = Me
        ConsultarDatos()
        ConsultarRoles()
    End Sub
    Public Sub ConsultarDatos()
        'Consulta a la base de datos
        Dim Usuarios = From U In db.Usuarios Order By U.nombre
        'Agregar los elementos a la lista
        For Each Elemento As Usuarios In Usuarios
            ListaUsuarios.Add(Elemento)
        Next
    End Sub
    Public Sub ConsultarRoles()
        Dim roles = From R In db.Roles
        For Each Elemento As Roles In roles
            ListaRoles.Add(Elemento)
        Next
    End Sub

    Public Sub Execute(Parametro As Object) Implements ICommand.Execute
        If Parametro.Equals("Nuevo") Then
            MsgBox("Nuevo")
        ElseIf Parametro.Equals("Guardar") Then
            Try
                Dim Registro As New Usuarios
                Registro.nombre = Nombre
                Registro.login = Login
                Registro.password = Password
                Registro.email = Email
                Registro.Roles = Elemento
                db.Usuarios.Add(Registro)
                db.SaveChanges()
                MsgBox("Registro almacenado")
                ConsultarDatos()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Public Sub NotificarCambio(ByVal Propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(Propiedad))
    End Sub
    Public Function CanExecute(Parametro As Object) As Boolean Implements ICommand.CanExecute
        Return True
    End Function
End Class
