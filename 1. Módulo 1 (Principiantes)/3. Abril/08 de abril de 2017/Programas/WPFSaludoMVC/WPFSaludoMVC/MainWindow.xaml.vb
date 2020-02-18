Class MainWindow
    'Public Sub Saludar()
    '    MsgBox("Hola" & TxtNombre.Text & "Bienvenido a WPF", 64, "WPF")
    'End Sub
    'Public Sub EvaluarEdad()
    '    If Convert.ToInt16(TxtEdad) >= 18 Then
    '        MsgBox("Es mayor de edad", 64, "WPF")
    '    Else
    '        MsgBox("Eres menor de edad", 64, "WPF")
    '    End If
    'End Sub

    'Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

    'End Sub
    Public Sub AbrirVentana()
        Dim Ventana As New SegundaVentana()
        Ventana.Show()
    End Sub
    Public Sub CerrarVentana()
        Me.Close()
    End Sub

    Private Sub MenuItem_Click(sender As Object, e As RoutedEventArgs)

    End Sub
End Class
