Module Module13
    Sub Main()
        'ejercicio 13

        Dim array(6) As Integer
        Dim suma As Integer

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduce el valor de la posición " & i)
            array(i) = Convert.ToInt32(Console.ReadLine)
            If i Mod 2 = 0 Then
                suma += array(i)
            End If
        Next

        Console.WriteLine("La suma de los valores de las posiciones pares es : " & suma)
        Console.ReadLine()
    End Sub
End Module
