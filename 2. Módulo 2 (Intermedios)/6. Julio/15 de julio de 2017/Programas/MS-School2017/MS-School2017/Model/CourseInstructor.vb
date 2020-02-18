Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Public Class CourseInstructor
    Implements INotifyDataErrorInfo

    Public Overridable Property Course() As Course
    Public Overridable Property Person() As Person

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

    Public ReadOnly Property HasErrors As Boolean Implements INotifyDataErrorInfo.HasErrors
        Get
            Throw New NotImplementedException()
        End Get
    End Property
    Public Event ErrorsChanged As EventHandler(Of DataErrorsChangedEventArgs) Implements INotifyDataErrorInfo.ErrorsChanged
    Public Function GetErrors(propertyName As String) As IEnumerable Implements INotifyDataErrorInfo.GetErrors
        Throw New NotImplementedException()
    End Function
End Class
