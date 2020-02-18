Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Public Class OnlineCourse

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

    Private _Url As String
    Public Property Url As String
        Get
            Return _Url
        End Get
        Set(value As String)
            _Url = value
        End Set
    End Property
End Class
