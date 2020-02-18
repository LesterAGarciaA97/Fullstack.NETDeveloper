Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Public Class Course
    Public Overridable Property Department() As Department
    Public Overridable Property StudentGrades() As ICollection(Of StudentGrade)
    Public Overridable Property OnlineCourse() As OnlineCourse
    Public Overridable Property OnsiteCourse() As OnsiteCourse
    Public Overridable Property CourseInstructors() As ICollection(Of CourseInstructor)

    Private _CourseID As Integer
    <Key>
    Public Property CourseID As Integer
        Get
            Return _CourseID
        End Get
        Set(value As Integer)
            _CourseID = value
        End Set
    End Property

    Private _Title As String
    Public Property Title As String
        Get
            Return _Title
        End Get
        Set(value As String)
            _Title = value
        End Set
    End Property

    Private _Credits As String
    Public Property Credits As String
        Get
            Return _Credits
        End Get
        Set(value As String)
            _Credits = value
        End Set
    End Property

    Private _DepartmentID As Integer
    Public Property DepartmentID As Integer
        Get
            Return _DepartmentID
        End Get
        Set(value As Integer)
            _DepartmentID = value
        End Set
    End Property

    Private _Modelo As Course
    Public Property Modelo As Course
        Get
            Return _Modelo
        End Get
        Set(value As Course)
            _Modelo = value
        End Set
    End Property
End Class
