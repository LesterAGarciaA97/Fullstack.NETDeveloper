Imports System.ComponentModel
'Implementación de las interfaces para la arquitectura en MVVM
'ICommand => Interfaz que permite invocar los métodos que se diseñen en la clase
'INotifyPropertyChanged => Permite notificar los cambios del Modelo a la Vista
Public Class ModeloVistaVentanaSaludo
    Implements INotifyPropertyChanged, ICommand
    Private _Nombre As String
    Private _Modelo As ModeloVistaVentanaSaludo
    'Constructor para capturar la instancia de la clase
    Public Sub New()
        Me.Modelo = Me
    End Sub
    'Propiedad que guarda la referencia de la clase instanciada
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
            NotificarCambios("Nombre")
        End Set
    End Property
    Public Property Modelo As ModeloVistaVentanaSaludo
        Get
            Return _Modelo
        End Get
        Set(value As ModeloVistaVentanaSaludo)
            _Modelo = value
        End Set
    End Property

    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    'Método para invocar los métodos de la clase a partir del botón que se presionó de la vista
    Public Sub Execute(Parametro As Object) Implements ICommand.Execute
        If Parametro.Equals("BtnSaludar") Then
            MsgBox("Hola " & Nombre)
        End If
    End Sub
    'Verifica si puede ejecutarse algún método de la clase
    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Return True
    End Function
    'Método que permite notificar los cambios del modelo hacia la vista
    Public Sub NotificarCambios(ByVal Propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(Propiedad))
    End Sub
End Class
