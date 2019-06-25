Imports System

Module Sumas
    Sub Main()
        Console.WriteLine("Suma de dos valores= " & Sumando(2, 3))
        Console.WriteLine("Suma de tres valores= " & Sumando(8.2, 5, 10.3))
        Console.WriteLine("Suma de cuatro valores= " & Sumando(7, 80, 50.55, 100.33))
    End Sub

    Private Function Sumando(num As Double, num2 As Double)
        Return num + num2
    End Function
    Private Function Sumando(num As Double, num2 As Double, num3 As Double)
        Return num + num2 + num3
    End Function
    Private Function Sumando(num As Double, num2 As Double, num3 As Double, num4 As Double)
        Return num + num2 + num3 + num4
    End Function
End Module
