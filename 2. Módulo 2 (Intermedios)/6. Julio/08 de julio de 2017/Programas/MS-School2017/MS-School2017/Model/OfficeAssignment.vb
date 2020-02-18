Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Public Class OfficeAssignment
    Implements INotifyDataErrorInfo

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
