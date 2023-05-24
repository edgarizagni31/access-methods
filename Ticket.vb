Public Class Ticket
    <VBFixedString(20)> Private codigo_pago As String
    Private fecha_creacion As Date
    Private creado_por As SByte ' REFERENCIA A USUARIO
    Private id_concepto As SByte ' REFERENCIA A CONCEPTO
    <VBFixedString(8)> Private dni_estudiante As String ' REFERENCIA A ESTUDIANTE
End Class
