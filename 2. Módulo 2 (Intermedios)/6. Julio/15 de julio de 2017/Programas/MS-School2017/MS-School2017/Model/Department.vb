Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Public Class Department
    'Bloque de código se encuentra después de los campos y sus propiedades
    Implements IDataErrorInfo
    Public Overridable Property Courses() As ICollection(Of Course)

    Private _DepartmentID As Integer
    <Key>
    Public Property DepartmentID As Integer
        Get
            Return _DepartmentID
        End Get
        Set(value As Integer)
            _DepartmentID = value
        End Set
    End Property

    Private _Name As String
    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Private _Budget As Decimal
    Public Property Budget As Decimal
        Get
            Return _Budget
        End Get
        Set(value As Decimal)
            _Budget = value
        End Set
    End Property

    Private _StartDate As Date
    Public Property StartDate As Date
        Get
            Return _StartDate
        End Get
        Set(value As Date)
            _StartDate = value
        End Set
    End Property

    Private _Administrator As Integer
    Public Property Administrator As Integer
        Get
            Return _Administrator
        End Get
        Set(value As Integer)
            _Administrator = value
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
