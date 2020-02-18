Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Public Class Department
    'Bloque de código se encuentra después de los campos y sus propiedades
    Implements INotifyDataErrorInfo
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
    Public Property Buget As Decimal
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
