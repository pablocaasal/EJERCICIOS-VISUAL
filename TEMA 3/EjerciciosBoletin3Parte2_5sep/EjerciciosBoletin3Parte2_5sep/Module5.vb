Module Module5
    Sub Main()
        'Ejercicio12
        Dim precio, descuento1, descuento2, preciofinalMenor, precioFinalMayor As Double
        Console.WriteLine("Introduzca el precio del producto")
        precio = Convert.ToDouble(Console.ReadLine)
        descuento1 = precio * (10 / 100)
        descuento2 = precio * (15 / 100)

        If precio < 100 Then
            preciofinalMenor = (precio - descuento1)
        End If
        If precio > 100 Then
            precioFinalMayor = (precio - descuento2)
        End If

        If precio < 100 Then
            Console.WriteLine("El precio final es: " & preciofinalMenor)
        End If
        If precio > 100 Then
            Console.WriteLine("El precio final es " & precioFinalMayor)
        End If
        Console.ReadLine()
    End Sub
End Module
