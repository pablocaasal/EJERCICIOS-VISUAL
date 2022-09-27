Module Module3
    Sub Main()
        'EJERCICIO 6 BOLETÍN 2
        Dim n1 As Integer
        Dim n2 As Integer
        Dim suma As Double
        Dim resta As Double
        Dim multiplicación As Double

        n1 = Convert.ToInt32(InputBox("Ponga un número"))
        n2 = Convert.ToInt32(InputBox("Ponga un segundo número"))

        suma = n1 + n2
        resta = n1 - n2
        multiplicación = n1 * n2

        Console.WriteLine("El resultado de la suma es: " & suma)
        Console.WriteLine("El resultado de la resta es: " & resta)
        Console.WriteLine("El resultado de la multiplicación es: " & multiplicación)
        Console.ReadLine()


    End Sub
End Module
