Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Public Class OnsiteCourse
    Implements INotifyDataErrorInfo
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

    Public Event ErrorsChanged As EventHandler(Of DataErrorsChangedEventArgs) Implements INotifyDataErrorInfo.ErrorsChanged
    Public ReadOnly Property HasErrors As Boolean Implements INotifyDataErrorInfo.HasErrors
        Get
            Throw New NotImplementedException()
        End Get
    End Property
    Public Function GetErrors(propertyName As String) As IEnumerable Implements INotifyDataErrorInfo.GetErrors
        Throw New NotImplementedException()
    End Function
End Class
