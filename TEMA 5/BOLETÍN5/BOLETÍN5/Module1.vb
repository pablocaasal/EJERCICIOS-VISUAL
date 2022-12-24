Module Module1

    Sub Main()
        'Ejercicio 1

        Dim array() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9}

        For i = 0 To array.Length - 1
            Console.WriteLine(array(i))
        Next
        Console.ReadLine()
    End Sub

End Module
