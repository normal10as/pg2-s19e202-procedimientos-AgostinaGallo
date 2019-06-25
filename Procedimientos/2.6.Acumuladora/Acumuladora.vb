Imports System

Module Acumuladora
    Sub Main()
        Dim numIngresado As Double
        Console.WriteLine("Ingrese un valor: ")
        numIngresado = Console.ReadLine
        Acumulando(numIngresado)
        Console.WriteLine("El valor es: " & numIngresado)
        Acumulando(numIngresado)
        Console.WriteLine("El valor es: " & numIngresado)
        Acumulando(numIngresado)
        Console.WriteLine("El valor es: " & numIngresado)
    End Sub

    Sub Acumulando(ByRef valor As Double)
        valor += valor
    End Sub
End Module
