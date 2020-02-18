Imports System.ComponentModel
Imports System.Collections.ObjectModel
Public Class ModeloVistaVentanaCategoria
    Implements INotifyPropertyChanged, ICommand
    Private _BtnNuevoActivado As Boolean
    Private _BtnGuardarActivado As Boolean
    Private _Descripcion As String
    Private _Imagen As String
    Private _Modelo As ModeloVistaVentanaCategoria
    Private _ListaCategoria As New ObservableCollection(Of Categoria)
    Private _LecturaDescripcion As Boolean
    Private _LecturaImagen As Boolean
    Private _ElementoSeleccionado As Categoria
    Public Sub New()
        Me.Modelo = Me
        BtnNuevoActivado = True
        BtnGuardarActivado = False
        LecturaDescripcion = True
        LecturaImagen = True
    End Sub
    Public Property ElementoSeleccionado As Categoria
        Get
            Return _ElementoSeleccionado
        End Get
        Set(value As Categoria)
            _ElementoSeleccionado = value
            If value IsNot Nothing Then
                Descripcion = value.Descripcion
                Imagen = value.Imagen
            End If
            NotificarCambio("ElementoSeleccionado")
        End Set
    End Property
    Public Property LecturaDescripcion As Boolean
        Get
            Return _LecturaDescripcion
        End Get
        Set(value As Boolean)
            _LecturaDescripcion = value
            NotificarCambio("LecturaDescripcion")
        End Set
    End Property
    Public Property LecturaImagen As Boolean
        Get
            Return _LecturaImagen
        End Get
        Set(value As Boolean)
            _LecturaImagen = value
            NotificarCambio("LecturaImagen")
        End Set
    End Property
    Public Property ListaCategoria As ObservableCollection(Of Categoria)
        Get
            Return _ListaCategoria
        End Get
        Set(value As ObservableCollection(Of Categoria))
            _ListaCategoria = value
        End Set
    End Property
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
            ListaCategoria.Add(NuevaCategoria)
            BtnGuardarActivado = False
            BtnNuevoActivado = True
        ElseIf parametro.Equals("BtnAgregar") Then
            BtnGuardarActivado = True
            BtnNuevoActivado = False
            LecturaDescripcion = False
            LecturaImagen = False
            Descripcion = String.Empty
            Imagen = String.Empty
        ElseIf parametro.Equals("BtnEliminar") Then
            If ElementoSeleccionado IsNot Nothing Then
                Dim Respuesta As MsgBoxResult = MsgBoxResult.No
                Respuesta = MsgBox("¿Realmente está seguro de eliminar el registro", 292, "Eliminar categoría")
                If Respuesta = MsgBoxResult.Yes Then
                    ListaCategoria.Remove(ElementoSeleccionado)
                End If
            Else
                MsgBox("Debe Sleccionar un elemento", 16, "Eliminar categoría")
            End If
        End If
    End Sub
    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Return True
    End Function
    Public Sub NotificarCambio(ByVal Propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(Propiedad))
    End Sub
End Class
