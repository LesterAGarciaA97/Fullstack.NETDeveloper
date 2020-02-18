Public Class Vehiculo
#Region "Campos"
    Private _Tipo As String
    Private _Color As String
    Private _TipoDeTransmision As String
    Private _Marca As String
    Private _Modelo As String
    Private _CantidadDePuertas As String
    Private _TipoDeCombustible As String
    Private _Tamaño As String
#End Region
#Region "Propiedades"
    Public Property Tipo As String
        Get
            Return _Tipo
        End Get
        Set(value As String)
            _Tipo = value
        End Set
    End Property
    Public Property Color As String
        Get
            Return _Color
        End Get
        Set(value As String)
            _Color = value
        End Set
    End Property
    Public Property TipoDeTransmision As String
        Get
            Return _TipoDeTransmision
        End Get
        Set(value As String)
            _TipoDeTransmision = value
        End Set
    End Property
    Public Property Marca As String
        Get
            Return _Marca
        End Get
        Set(value As String)
            _Marca = value
        End Set
    End Property
    Public Property Modelo As String
        Get
            Return _Modelo
        End Get
        Set(value As String)
            _Modelo = value
        End Set
    End Property
    Public Property CantidadDePuertas As String
        Get
            Return _CantidadDePuertas
        End Get
        Set(value As String)
            _CantidadDePuertas = value
        End Set
    End Property
    Public Property TipoDeCombustible
        Get
            Return _TipoDeCombustible
        End Get
        Set(value)
            _TipoDeCombustible = value
        End Set
    End Property
    Public Property Tamaño As String
        Get
            Return _Tamaño
        End Get
        Set(value As String)
            _Tamaño = value
        End Set
    End Property
#End Region
End Class
