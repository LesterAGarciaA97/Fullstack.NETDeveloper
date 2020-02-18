Imports System.ComponentModel
Imports System.Collections.ObjectModel
Public Class UsuarioViewModel
    Implements INotifyPropertyChanged, ICommand
    'Objeto que permite administrar las entidades a la base de datos
    Private db As New Agenda2017I013HEntities()
    Private _ListaUsuarios As New ObservableCollection(Of Usuarios)
    Public Property ListaUsuarios As ObservableCollection(Of Usuarios)
        Get
            Return _ListaUsuarios
        End Get
        Set(value As ObservableCollection(Of Usuarios))
            _ListaUsuarios = value
        End Set
    End Property

    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Public Sub New()
        ConsultarDatos()
    End Sub
    Public Sub ConsultarDatos()
        'Consulta a la base de datos
        Dim Usuarios = From U In db.Usuarios Order By U.nombre
        'Agregar los elementos a la lista
        For Each Elemento As Usuarios In Usuarios
            ListaUsuarios.Add(Elemento)
        Next
    End Sub

    Public Sub Execute(Parametro As Object) Implements ICommand.Execute

    End Sub

    Public Function CanExecute(Parametro As Object) As Boolean Implements ICommand.CanExecute
        Return True
    End Function
End Class
