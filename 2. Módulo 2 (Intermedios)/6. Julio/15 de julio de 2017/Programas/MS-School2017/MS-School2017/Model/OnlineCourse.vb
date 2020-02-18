Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Public Class OnlineCourse
    Implements IDataErrorInfo
    Public Overridable Property Course() As Course

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

    Private _Url As String
    Public Property Url As String
        Get
            Return _Url
        End Get
        Set(value As String)
            _Url = value
        End Set
    End Property

    Default Public ReadOnly Property Item(columnName As String) As String Implements IDataErrorInfo.Item
        Get
            Throw New NotImplementedException()
        End Get
    End Property
    Public ReadOnly Property [Error] As String Implements IDataErrorInfo.Error
        Get
            Throw New NotImplementedException()
        End Get
    End Property
End Class
