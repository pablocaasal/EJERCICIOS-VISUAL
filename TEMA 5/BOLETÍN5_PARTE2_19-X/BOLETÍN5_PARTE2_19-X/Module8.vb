Module Module8
    Sub Main()
        'ejercicio 26

        Dim array(4) As Integer
        Dim array2(4) As Integer
        Dim valoresDistintos

        Console.WriteLine("Cuidado! Tienes que introducir cada posición 2 veces, una vez para la primera array y otra para la segunda")
        Console.WriteLine(" ")

        For n = 0 To array.Length - 1

            Console.WriteLine("Introduce el valor de la posición " & n & " de la array 1")
            array(n) = Convert.ToInt32(Console.ReadLine)

            Console.WriteLine(" ")

            Console.WriteLine("Introduce el valor de la posición " & n & " de la array 2")
            array2(n) = Convert.ToInt32(Console.ReadLine)
            Console.WriteLine(" ")

        Next

        For I = 0 To array.Length - 1

            If array(I) <> array2(I) Then
                valoresDistintos += 1
            End If

        Next

        If valoresDistintos > 0 Then
            Console.WriteLine("Las arrays son distintas")
        Else
            Console.WriteLine("Las arrays son iguales")
        End If

        Console.ReadLine()
    End Sub
End Module
