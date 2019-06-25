Imports System.Math

Module Potencias
    Sub Main()
        Dim numIngresado As Double
        Console.WriteLine("--Potencias")
        Console.WriteLine("Ingrese numero: ")
        numIngresado = Console.ReadLine()
        Console.WriteLine("Numero elevado a potencia 2= " & calculoPotencias(numIngresado, 2))
        Console.WriteLine("Numero elevado a potencia 3= " & calculoPotencias(numIngresado, 3))
        Console.WriteLine("Numero elevado a potencia 5= " & calculoPotencias(numIngresado, 5))
        Console.Read()
    End Sub

    Private Function calculoPotencias(ByVal n As Double, pot As Byte)
        Return n ^ pot
    End Function
End Module
