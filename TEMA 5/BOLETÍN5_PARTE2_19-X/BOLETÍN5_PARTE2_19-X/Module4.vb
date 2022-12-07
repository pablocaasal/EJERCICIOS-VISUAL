Module Module4
    Sub Main()
        'ejercicio 22
        Dim array(4) As Integer

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduce la posición " & i)
            array(i) = Convert.ToInt32(Console.ReadLine)
        Next

        For i = 0 To array.Length - 1
            If array(i) Mod 2 = 0 Then
                Console.WriteLine(" ")
                Console.WriteLine(array(i) & " Es el primer número par y está en la posición " & i)
                Exit For

            End If
        Next

        Console.ReadLine()
    End Sub
End Module
