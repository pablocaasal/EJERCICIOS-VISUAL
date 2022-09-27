Module Module4
    Sub mAIN()
        'EJERCICIO 16
        Dim n1, n2, n3 As Double
        Dim resultado, resultado2, resultado3, resultado4 As Double

        n1 = Convert.ToDouble(InputBox("Introduzca el primero numero "))
        n2 = Convert.ToDouble(InputBox("Introduzca el segundo numero "))
        n2 = Convert.ToDouble(InputBox("Introduzca el tercer numero "))

        Dim mayor As Double = Math.Max(n1, n2)
        mayor = Math.Max(mayor, n3)
        Dim menor As Double = Math.Min(n1, n2)
        menor = Math.Min(menor, n3)


        resultado = Math.Sqrt(mayor ^ menor) + Math.Pow(n1, 5)
        resultado2 = Math.Floor(resultado)
        resultado3 = Math.Ceiling(resultado)
        resultado4 = Math.Round(resultado, 2)

        Console.WriteLine("El resultado 1 es :" & resultado)
        Console.WriteLine("El resultado 2 es: " & resultado2)
        Console.WriteLine("El resultado 3 es " & resultado3)
        Console.WriteLine("El resultado 4 es " & resultado4)
        Console.ReadLine()








    End Sub
End Module
