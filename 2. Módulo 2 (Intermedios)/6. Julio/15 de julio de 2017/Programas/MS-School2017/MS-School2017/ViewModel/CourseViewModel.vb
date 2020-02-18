Imports System.ComponentModel
Public Class CourseViewModel
    Implements INotifyPropertyChanged, ICommand, IDataErrorInfo

    Private _Title As String
    Public Property Title As String
        Get
            Return _Title
        End Get
        Set(value As String)
            If String.IsNullOrEmpty(value) Then
                If Not Errores.ContainsKey("Title") Then
                    Errores.Add("Title", "El título del curso no debe de estar vacío")
                End If
            Else
                Errores.Remove("Title")
            End If
            _Title = value
            NotificarCambio("Title")
        End Set
    End Property

    Private _Credits As String
    Public Property Credits As String
        Get
            Return _Credits
        End Get
        Set(value As String)
            If value < 1 Then
                If Not Errores.ContainsKey("Credits") Then
                    Errores.Add("Credits", "Los créditos deben ser mayor que 0")
                End If
            Else
                Errores.Remove("Credits")
            End If
            _Credits = value
            NotificarCambio("Credits")
        End Set
    End Property

    Private _Modelo As New CourseViewModel()
    Public Property Modelo As CourseViewModel
        Get
            Return _Modelo
        End Get
        Set(value As CourseViewModel)
            _Modelo = value
        End Set
    End Property
    Public Sub New()
        Me.Modelo = Me
        Me.Title = ""
        Me.Credits = 0
    End Sub

    Private _ListaDepartamentos As IObservable(Of Department)
    Public Property ListaDepartamentos As IObservable(Of Department)
        Get
            Return _ListaDepartamentos
        End Get
        Set(value As IObservable(Of Department))
            _ListaDepartamentos = value
        End Set
    End Property
    Public Property DBContext As New SchoolDataContext()
    Private Errores As New Dictionary(Of String, String)

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged
    Public Sub NotificarCambio(ByVal Propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(Propiedad))
    End Sub
    Default Public ReadOnly Property Item(columnName As String) As String Implements IDataErrorInfo.Item
        Get
            If Errores.ContainsKey(columnName) Then
                Return Errores(columnName)
            End If
            Return String.Empty
        End Get
    End Property
    Public ReadOnly Property [Error] As String Implements IDataErrorInfo.Error
        Get
            Return String.Empty
        End Get
    End Property
    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Return True
    End Function
    Public Sub Execute(Parametro As Object) Implements ICommand.Execute
        If Parametro.Equals("Guardar") Then
            'Creación del objeto Course
            Dim NuevoCurso As New Course()
            'Asigna´ción de las propiedades
            NuevoCurso.Title = "Programación orientada a objetos con Visual Basic"
            NuevoCurso.Credits = 100
            'Creación del objeto Department
            Dim NuevoDepartamento As New Department
            NuevoDepartamento.Name = "Desarrollo de software"
            NuevoDepartamento.Budget = 0
            NuevoDepartamento.Administrator = 1
            NuevoDepartamento.StartDate = New Date()
            'Asignar el objeto Department al objeto NuevoCurso
            NuevoCurso.Department = NuevoDepartamento
            'Almacenar la información
            DBContext.Courses.Add(NuevoCurso)
            DBContext.SaveChanges()
        End If
    End Sub
End Class
