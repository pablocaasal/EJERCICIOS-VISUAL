Module Module5
    Sub Main()
        'Ejercicio 7
        Dim n1, n2, suma As Double
        Console.WriteLine("INTRODUZCA EL PRIMER NÚMERO REAL")
        n1 = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("INTRODUZCA EL SEGUNDO NÚMERO REAL")
        n2 = Convert.ToDouble(Console.ReadLine)
        suma = n1 + n2
        If suma > 0 Then
            Math.Sqrt(suma)
        Else
            Console.WriteLine("NO SE PUEDE REALIZAR LA RAÍZ")
        End If
        Console.ReadLine()
    End Sub
End Module
