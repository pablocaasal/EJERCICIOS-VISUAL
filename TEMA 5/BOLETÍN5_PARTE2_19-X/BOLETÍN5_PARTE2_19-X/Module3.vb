Module Module3
    Sub Main()
        'ejercicio 21

        Dim array(4) As String

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduce la posición " & i)
            array(i) = Console.ReadLine
        Next

        For i = 0 To array.Length - 1

            If array(i) = Nothing Then

                Console.WriteLine(" ")
                Console.WriteLine("La posición " & i & " está vacía")

                Exit For
            End If

        Next

        Console.ReadLine()
    End Sub
End Module
