Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Public Class StudentGrade

    Private _EnrollmentID As Integer
    Public Overridable Property Course() As Course
    Public Overridable Property Person() As Person
    <Key>
    Public Property EnrollmentID As Integer
        Get
            Return _EnrollmentID
        End Get
        Set(value As Integer)
            _EnrollmentID = value
        End Set
    End Property

    Private _CourseID As Integer
    <ForeignKey("Course")>
    Public Property CourseID As Integer
        Get
            Return _CourseID
        End Get
        Set(value As Integer)
            _CourseID = value
        End Set
    End Property

    Private _StudentID As Integer
    <ForeignKey("Person")>
    Public Property StudentID As Integer
        Get
            Return _StudentID
        End Get
        Set(value As Integer)
            _StudentID = value
        End Set
    End Property

    Private _Grade As Integer
    Public Property Grade As Integer
        Get
            Return _Grade
        End Get
        Set(value As Integer)
            _Grade = value
        End Set
    End Property
End Class
