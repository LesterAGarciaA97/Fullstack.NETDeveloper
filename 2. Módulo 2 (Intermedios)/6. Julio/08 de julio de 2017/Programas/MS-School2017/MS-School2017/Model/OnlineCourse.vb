Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Public Class OnlineCourse
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

    Private _Url As String
    Public Property Url As String
        Get
            Return _Url
        End Get
        Set(value As String)
            _Url = value
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
