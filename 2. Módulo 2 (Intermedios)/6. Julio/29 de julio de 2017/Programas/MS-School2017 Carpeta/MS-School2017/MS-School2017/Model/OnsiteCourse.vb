Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Public Class OnsiteCourse

    Private _CourseID As Integer
    Public Overridable Property Course() As Course
    <Key>
    <ForeignKey("Course")>
    Public Property CourseID As Integer
        Get
            Return _CourseID
        End Get
        Set(value As Integer)
            _CourseID = value
        End Set
    End Property

    Private _Location As String
    Public Property Location As String
        Get
            Return _Location
        End Get
        Set(value As String)
            _Location = value
        End Set
    End Property

    Private _Days As String
    Public Property Days As String
        Get
            Return _Days
        End Get
        Set(value As String)
            _Days = value
        End Set
    End Property

    Private _Time As Date
    Public Property Time As String
        Get
            Return _Time
        End Get
        Set(value As String)
            _Time = value
        End Set
    End Property
End Class
