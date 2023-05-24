Imports System.IO

Module Program
    Sub Main(args As String())
        Crear_Archivo()
    End Sub

    Sub Crear_Archivo()
        Dim ruta_principal = "D:\unp\metodos-acceso\files_example\"
        Dim nombre_archivo = "alumnos.dat"
        Dim ruta_archivo = ruta_principal + nombre_archivo

        ' crear archivo
        Dim archivo = New FileStream(ruta_archivo, FileMode.Create, FileAccess.Write)

        archivo.Close()

        Console.WriteLine("ARCHIVO CREADO CON EXITO -> " + ruta_archivo)
    End Sub
End Module
