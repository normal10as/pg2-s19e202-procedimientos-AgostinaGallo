Imports System.DateTime

Module Nueva_fecha
    Private Function sumarDias(fechaIngresada As Date, cantdiass As UShort)
        Return fechaIngresada.AddDays(cantdiass)
    End Function
    Sub Main()
        Dim ingresoFecha As Date
        Dim cantDias As UShort
        Console.WriteLine("Ingrese una fecha (dd/mm/aaaa): ")
        ingresoFecha = Console.ReadLine()
        Console.WriteLine("Ingrese dias a sumar: ")
        cantDias = Console.ReadLine()
        Console.WriteLine("Resultado de la suma de dias a la fecha: " & sumarDias(ingresoFecha, cantDias))
    End Sub
End Module
