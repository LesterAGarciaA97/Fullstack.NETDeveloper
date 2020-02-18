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
    Public Sub New()
        Me.Modelo = Me
        Me.Title = ""
        Me.Credits = 0
    End Sub
    Private _Modelo As CourseViewModel
    Public Property Modelo As CourseViewModel
        Get
            Return _Modelo
        End Get
        Set(value As CourseViewModel)
            _Modelo = value
        End Set
    End Property

    Private _ListaDepartamentos As New List(Of Department)
    Public Property ListaDepartamentos As List(Of Department)
        Get
            If _ListaDepartamentos.Count = 0 Then
                _ListaDepartamentos = (From D In DBContext.Departments Select D).ToList
            End If
            Return _ListaDepartamentos
        End Get
        Set(value As List(Of Department))
            _ListaDepartamentos = value
            NotificarCambio("ListaDepartamentos")
        End Set
    End Property

    Private _Departamento As Department
    Public Property Departamento As Department
        Get
            Return _Departamento
        End Get
        Set(value As Department)
            _Departamento = value
            NotificarCambio("Departamento")
        End Set
    End Property

    Private _ListaCursos As New List(Of Course)
    Public Property ListaCursos As List(Of Course)
        Get
            If _ListaCursos.Count = 0 Then
                _ListaCursos = (From C In DBContext.Courses Select C).ToList
            End If
            Return _ListaCursos
        End Get
        Set(value As List(Of Course))
            _ListaCursos = value
            NotificarCambio("ListaCursos")
        End Set
    End Property

    Private _Curso As Course
    Public Property Curso As Course
        Get
            Return _Curso
        End Get
        Set(value As Course)
            _Curso = value
            NotificarCambio("Curso")
            If value IsNot Nothing Then
                Me.Title = value.Title
                Me.Credits = value.Credits
                Me.Departamento = value.Department
            End If
        End Set
    End Property
    Public Property DBContext As New SchoolDataContext()

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

    Private Errores As New Dictionary(Of String, String)

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged
    Public Sub NotificarCambio(ByVal Propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(Propiedad))
    End Sub
    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Return True
    End Function
    Public Sub Execute(Parametro As Object) Implements ICommand.Execute
        If Parametro.Equals("Guardar") Then
            'Creación del objeto Course
            Dim NuevoCurso As New Course()
            'Asigna´ción de las propiedades
            NuevoCurso.Title = Me.Title
            NuevoCurso.Credits = Me.Credits
            NuevoCurso.Department = Departamento
            'Almacenar la información
            DBContext.Courses.Add(NuevoCurso)
            DBContext.SaveChanges()
            MsgBox("Datos almacenados")
            ListaCursos = (From C In DBContext.Courses Select C).ToList
        ElseIf Parametro.Equals("Eliminar") Then
            If Me.Curso IsNot Nothing Then
                Dim Respuesta As MessageBoxResult = MsgBoxResult.No
                Respuesta = MsgBox("¿Realmente está seguro de eliminar el registro?", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Eliminar")
                If Respuesta = MsgBoxResult.Yes Then
                    DBContext.Courses.Remove(Me.Curso)
                    DBContext.SaveChanges()
                    ListaCursos = (From C In DBContext.Courses Select C).ToList
                End If
            Else
                MsgBox("Debe seleccionar un elemento", MsgBoxStyle.Critical, "Eliminar")
            End If
        ElseIf Parametro.Equals("Actualizar") Then
            If Me.Curso IsNot Nothing Then
                Me.Curso.Title = Me.Title
                Me.Curso.Credits = Me.Credits
                Me.Curso.Department = Me.Departamento
                Me.DBContext.Entry(Me.Curso).State = System.Data.Entity.EntityState.Modified
                Me.DBContext.SaveChanges()
                ListaCursos = (From C In DBContext.Courses Select C).ToList
            Else
                MsgBox("Debe seleccionar un elemento", MsgBoxStyle.Critical, "Eliminar")
            End If
        End If
    End Sub

End Class
