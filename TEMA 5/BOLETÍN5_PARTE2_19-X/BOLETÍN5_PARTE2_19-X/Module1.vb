Module Module1

    Sub Main()
        'ejercicio 19

        Dim array(3) As Integer

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduce el valor de la posición " & i)
            array(i) = Convert.ToInt32(Console.ReadLine)
        Next

        Console.WriteLine(" ")
        Console.WriteLine("Valores mayores de 1000 : ")

        For n = 0 To array.Length - 1
            If array(n) >= 1000 Then
                Console.WriteLine("")
                Console.WriteLine("Posición " & n & " : " & array(n))
            End If
        Next

        Console.ReadLine()
    End Sub

End Module
