Module Module8
    Sub Main()
        'ejercicio 8
        Dim numero, cuadrado, cubo, contador As Integer
        Console.WriteLine("Introduzca el número")
        numero = Convert.ToInt32(Console.ReadLine)
        contador = 0

        While contador <= 5
            cuadrado = Math.Pow(numero, 2)
            cubo = Math.Pow(numero, 3)
            Console.WriteLine("Numero:" & numero & " Cuadrado:" & cuadrado & " Cubo:" & cubo)
            numero += 1
            contador += 1
        End While
        Console.ReadLine()

        For i = numero To numero + 5
            cuadrado = Math.Pow(i, 2)
            cubo = Math.Pow(i, 3)
            Console.WriteLine("Numero:" & i & " Cuadrado:" & cuadrado & " Cubo:" & cubo)
        Next
        Console.ReadLine()
    End Sub
End Module
