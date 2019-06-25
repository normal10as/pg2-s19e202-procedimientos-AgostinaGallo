Imports System

Module Hipotenusa
    Sub Main()
        Dim ladoA, ladoB, calcCuadrado As Integer
        Console.WriteLine("--Calculo de Hipotenusa" & vbCrLf & "Ingrese valor de lado A:")
        ladoA = Console.ReadLine()
        Console.WriteLine("Ingrese valor de lado B: ")
        ladoB = Console.ReadLine()
        Console.WriteLine("Formula aplicada: c^2 = a^2 + b^2")
        Console.WriteLine("Valor de la HIPOTENUSA = " & calculoHipotenusa(ladoA, ladoB, calcCuadrado))
        Console.Read()
    End Sub

    Private Function calculoHipotenusa(a, b, c) As Integer
        c = (a ^ 2) + (b ^ 2)
        Return c ^ 2
    End Function
End Module
