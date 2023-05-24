Public Class Ticket
    Implements IArchivo

    <VBFixedString(20)> Private codigo_pago As String
    Private fecha_creacion As Date
    Private creado_por As SByte ' REFERENCIA A USUARIO
    Private id_concepto As SByte ' REFERENCIA A CONCEPTO
    <VBFixedString(8)> Private dni_estudiante As String ' REFERENCIA A ESTUDIANTE

    Public Sub grabar() Implements IArchivo.grabar
        Throw New NotImplementedException()
    End Sub

    Public Sub leer() Implements IArchivo.leer
        Throw New NotImplementedException()
    End Sub
End Class
