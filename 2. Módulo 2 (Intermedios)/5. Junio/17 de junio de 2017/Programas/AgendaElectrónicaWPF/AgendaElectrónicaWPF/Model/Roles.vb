'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Roles
    Public Property codigoRol As Integer
    Public Property descripcion As String

    Public Overridable Property Usuarios As ICollection(Of Usuarios) = New HashSet(Of Usuarios)
    Public Overrides Function ToString() As String
        Return descripcion
    End Function

End Class
