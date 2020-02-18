Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Public Class Person

    Public Overridable Property CourseInstructors As ICollection(Of CourseInstructor)
    Public Overridable Property OfficeAssignment() As OfficeAssignment
    Public Overridable Property StudentGrades() As ICollection(Of StudentGrade)

    Private _PersonID As Integer
    <Key>
    Public Property PersonID As Integer
        Get
            Return _PersonID
        End Get
        Set(value As Integer)
            _PersonID = value
        End Set
    End Property

    Private _LastName As String
    Public Property LastName As String
        Get
            Return _LastName
        End Get
        Set(value As String)
            _LastName = value
        End Set
    End Property

    Private _FirstName As String
    Public Property FirstName As String
        Get
            Return _FirstName
        End Get
        Set(value As String)
            _FirstName = value
        End Set
    End Property

    Private _HireDate As Date
    Public Property HireDate As Date
        Get
            Return _HireDate
        End Get
        Set(value As Date)
            _HireDate = value
        End Set
    End Property

    Private _EnrollmentDate As Date
    Public Property Enrollment As Date
        Get
            Return _EnrollmentDate
        End Get
        Set(value As Date)
            _EnrollmentDate = value
        End Set
    End Property
End Class
