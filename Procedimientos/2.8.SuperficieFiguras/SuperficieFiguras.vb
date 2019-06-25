Imports System

Module SuperficieFiguras
    Sub Main()
        Console.WriteLine("--CALCULO DE SUPERFICIES")
        Console.WriteLine("Calculo superficie de cuadrado: Lado * Lado = " & calculoSuperficie(10.5))
        Console.WriteLine("Superficie de rectangulo: Base * Altura  = " & calculoSuperficie(6, 27))
        Console.WriteLine("Calculo superficie de trapecio: Base Mayor + Base Menor / 2 * Altura = " & calculoSuperficie(50, 35, 22))

    End Sub
    Private Function calculoSuperficie(lado As Double) As Double
        Return calculoSuperficie(lado, lado)
    End Function
    Private Function calculoSuperficie(base As Double, altura As Double) As Double
        Return calculoSuperficie(base, base, altura)
    End Function
    Private Function calculoSuperficie(baseMayor As Double, baseMenor As Double, altura As Double) As Double
        Return ((baseMayor + baseMenor) / 2) * altura
    End Function
End Module
