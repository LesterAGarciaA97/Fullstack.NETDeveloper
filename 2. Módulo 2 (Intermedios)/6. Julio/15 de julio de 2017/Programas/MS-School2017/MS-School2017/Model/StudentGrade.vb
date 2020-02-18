Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Public Class StudentGrade
    Implements IDataErrorInfo
    Public Overridable Property course() As Course

    Private _EnrollmentID As Integer
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
    Public Property CourseID As Integer
        Get
            Return _CourseID
        End Get
        Set(value As Integer)
            _CourseID = value
        End Set
    End Property

    Private _StudentID As Integer
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
