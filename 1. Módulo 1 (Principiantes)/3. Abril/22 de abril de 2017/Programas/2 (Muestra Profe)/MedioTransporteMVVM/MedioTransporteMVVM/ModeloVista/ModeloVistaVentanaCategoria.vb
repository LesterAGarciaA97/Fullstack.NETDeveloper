Imports System.ComponentModel
Public Class ModeloVistaVentanaCategoria
    Implements INotifyPropertyChanged, ICommand
    Private _BtnNuevoActivado As Boolean
    Private _BtnGuardarActivado As Boolean
    Private _Descripcion As String
    Private _Imagen As String
    Private _Modelo As ModeloVistaVentanaCategoria
    Public Sub New()
        Me.Modelo = Me
        BtnNuevoActivado = True
        BtnGuardarActivado = False
    End Sub
    Public Property Modelo As ModeloVistaVentanaCategoria
        Get
            Return _Modelo
        End Get
        Set(value As ModeloVistaVentanaCategoria)
            _Modelo = value
        End Set
    End Property
    Public Property BtnGuardarActivado As Boolean
        Get
            Return _BtnGuardarActivado
        End Get
        Set(value As Boolean)
            _BtnGuardarActivado = value
            NotificarCambio("BtnGuardarActivado")
        End Set
    End Property
    Public Property BtnNuevoActivado As Boolean
        Get
            Return _BtnNuevoActivado
        End Get
        Set(value As Boolean)
            _BtnNuevoActivado = value
            NotificarCambio("BtnNuevoActivado")
        End Set
    End Property
    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
            NotificarCambio("Descripcion")
        End Set
    End Property
    Public Property Imagen As String
        Get
            Return _Imagen
        End Get
        Set(value As String)
            _Imagen = value
            NotificarCambio("Imagen")
        End Set
    End Property

    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub Execute(parametro As Object) Implements ICommand.Execute
        If parametro.Equals("BtnGuardar") Then
            Dim NuevaCategoria As New Categoria()
            NuevaCategoria.Descripcion = Descripcion
            NuevaCategoria.Imagen = Imagen
            BtnGuardarActivado = False
            BtnNuevoActivado = True
        ElseIf parametro.Equals("BtnAgregar") Then
            BtnGuardarActivado = True
            BtnNuevoActivado = False
        End If
    End Sub

    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Return True
    End Function
    Public Sub NotificarCambio(ByVal Propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(Propiedad))
    End Sub
End Class
