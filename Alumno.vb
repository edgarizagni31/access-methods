﻿Public Class Alumno
    Implements IArchivo

    <VBFixedString(8)> Private dni As String
    <VBFixedString(200)> Private nombre As String
    <VBFixedString(200)> Private apellido As String
    Private grado As Byte
    <VBFixedString(2)> Private seccion As String
    <VBFixedString(50)> Private nivel As String

    Public Sub grabar() Implements IArchivo.grabar
        Throw New NotImplementedException()
    End Sub

    Public Sub leer() Implements IArchivo.leer
        Throw New NotImplementedException()
    End Sub
End Class
