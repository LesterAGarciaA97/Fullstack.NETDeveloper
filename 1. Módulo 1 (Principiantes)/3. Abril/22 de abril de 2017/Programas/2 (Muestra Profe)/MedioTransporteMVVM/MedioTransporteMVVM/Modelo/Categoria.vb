Imports System.Guid
Public Class Categoria
    Private _Codigo As String
    Private _Descripcion As String
    Private _Imagen As String
    Public Property Codigo As String
        Get
            Return _Codigo
        End Get
        Set(value As String)
            _Codigo = value
        End Set
    End Property
    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property
    Public Property Imagen As String
        Get
            Return _Imagen
        End Get
        Set(value As String)
            _Imagen = value
        End Set
    End Property
    Public Sub New()
        Me.Codigo = Guid.NewGuid.ToString()
    End Sub
End Class