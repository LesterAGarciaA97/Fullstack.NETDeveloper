Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Public Class StudentGrade
    Implements INotifyDataErrorInfo
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
