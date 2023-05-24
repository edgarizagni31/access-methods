Public Class Concepto
    Implements IArchivo

    Private id_concepto As SByte
    <VBFixedString(200)> Private text As String
    Private monto As Double
    Private fecha_limite As Date

    Public Sub grabar() Implements IArchivo.grabar
        Throw New NotImplementedException()
    End Sub

    Public Sub leer() Implements IArchivo.leer
        Throw New NotImplementedException()
    End Sub
End Class
