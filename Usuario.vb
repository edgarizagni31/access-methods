Public Class Usuario
    Enum Roles
        ADMINISTRADOR
        CONTADOR
    End Enum

    Private id_usuario As SByte
    <VBFixedString(200)> Private nombre_usuario As String
    <VBFixedString(100)> Private contrasenia As String
    Private rol As Roles
End Class
