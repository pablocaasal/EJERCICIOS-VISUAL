Module Module5
    Sub Main()
        'EJERCICIO 12 BOLETÍN 2
        Dim lado As Double
        Dim area As Double
        Dim diagonal As Double
        Dim perimetro As Double

        lado = Convert.ToDouble(InputBox("Introduzca el lado"))
        area = Math.Pow(lado, 2)
        diagonal = Math.Sqrt(lado)
        perimetro = 4 * lado

        Console.WriteLine("Area : " & area)
        Console.WriteLine("Diagonal :" & Math.Round(diagonal, 2))
        Console.WriteLine("Perímetro: " & perimetro)

        Console.ReadLine()





    End Sub
End Module
