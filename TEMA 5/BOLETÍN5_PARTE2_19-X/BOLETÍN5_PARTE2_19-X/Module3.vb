Module Module3
    Sub Main()
        'ejercicio 21

        Dim array(4) As String
        Dim contador As Integer

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduce la posición " & i)
            array(i) = Console.ReadLine
        Next

        For i = 0 To array.Length - 1

            If array(i) = Nothing Then
                Console.WriteLine(" ")
                Console.WriteLine("La posición " & i & " está vacía")
                Exit For
            Else
                contador += 1
            End If

        Next

        If contador = array.Length Then
            Console.WriteLine("No hay ninguna posición vacía en el array")
        End If

        Console.ReadLine()
    End Sub
End Module
