Public Class Usuario
    Implements IArchivo

    Enum Roles
        ADMINISTRADOR
        CONTADOR
    End Enum

    Private id_usuario As SByte
    <VBFixedString(200)> Private nombre_usuario As String
    <VBFixedString(100)> Private contrasenia As String
    Private rol As Roles

    Public Sub grabar() Implements IArchivo.grabar
        Throw New NotImplementedException()
    End Sub

    Public Sub leer() Implements IArchivo.leer
        Throw New NotImplementedException()
    End Sub
End Class
