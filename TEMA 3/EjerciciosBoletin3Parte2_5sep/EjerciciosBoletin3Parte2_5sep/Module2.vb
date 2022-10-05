Module Module2
    Sub mAIN()
        'Ejercicio 9
        Dim number1, number2, menor, mayor As Integer
        Dim elevado As Integer

        Console.WriteLine("Introduca el primer número")
        number1 = Convert.ToInt32(Console.ReadLine)
        Console.WriteLine("Introduca el segundo número")
        number2 = Convert.ToInt32(Console.ReadLine)

        If number1 > number2 Then
            mayor = number1
        Else
            menor = number1
        End If
        If number1 > number2 Then
            menor = number2
        Else
            mayor = number2
        End If

        elevado = Math.Pow(mayor, menor)
        Console.WriteLine("El resultado del número mas grande elevado al más pequeño es " & elevado)
        Console.ReadLine()


    End Sub
End Module
