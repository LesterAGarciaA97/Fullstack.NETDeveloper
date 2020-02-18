Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Public Class OfficeAssignment
    Implements IDataErrorInfo

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
