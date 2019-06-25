Imports System

Module VolumenCilindro
    Sub Main()
        Dim radioCil, alturaCil, PI As Double
        PI = Math.PI
        Console.WriteLine("--Volumen de un Cilindro")
        Console.WriteLine("Ingrese valor de la radio de la base: ")
        radioCil = Console.ReadLine()
        Console.WriteLine("Ingrese valor de la altura:")
        alturaCil = Console.ReadLine
        Console.WriteLine("La formula aplicada: PI * radio^2 * altura")
        Console.WriteLine("EL VOLUMEN DEL CILINDRO ES= " & CalculoVolumenCil(PI, radioCil, alturaCil))
    End Sub

    Private Function CalculoVolumenCil(pi, r, h) As Double
        Return pi * (r ^ 2) * h
    End Function
End Module
