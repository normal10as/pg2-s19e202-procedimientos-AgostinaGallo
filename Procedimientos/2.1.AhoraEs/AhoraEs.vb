Imports System

Module AhoraEs
    Private Sub muestroFechaActual()
        Console.WriteLine("Fecha Actual: " & Date.Today)
    End Sub

    Private Function getHoraActual(hora)
        Return hora.Date.Now.TimeOfDay
    End Function


    Sub Main()
        Dim hora As Date
        muestroFechaActual()
        Console.WriteLine("La hora actual es: {0} ", getHoraActual(hora))
        Console.Read()
    End Sub
End Module
