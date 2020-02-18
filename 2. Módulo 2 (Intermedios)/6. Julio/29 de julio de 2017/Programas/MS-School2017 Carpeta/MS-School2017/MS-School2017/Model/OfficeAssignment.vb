Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Public Class OfficeAssignment

    Private _InstructorID As Integer
    Public Overridable Property Person() As Person
    <Key>
    <ForeignKey("Person")>
    Public Property InstructorID As Integer
        Get
            Return _InstructorID
        End Get
        Set(value As Integer)
            _InstructorID = value
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

    Private _TimeStamp As Byte
    Public Property TimeStamp As Byte
        Get
            Return _TimeStamp
        End Get
        Set(value As Byte)
            _TimeStamp = value
        End Set
    End Property
End Class
