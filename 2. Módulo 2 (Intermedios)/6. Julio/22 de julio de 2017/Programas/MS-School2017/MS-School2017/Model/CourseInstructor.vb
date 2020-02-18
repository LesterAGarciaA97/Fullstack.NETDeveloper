Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Public Class CourseInstructor
    Public Overridable Property Course() As Course
    Public Overridable Property Person() As Person

    Private _CourseID As Integer
    <Key, Column(Order:=1)>
    Public Property CourseID As Integer
        Get
            Return _CourseID
        End Get
        Set(value As Integer)
            _CourseID = value
        End Set
    End Property

    Private _PersonID As Integer
    <Key, Column(Order:=0)>
    Public Property PersonID As Integer
        Get
            Return _PersonID
        End Get
        Set(value As Integer)
            _PersonID = value
        End Set
    End Property
End Class
