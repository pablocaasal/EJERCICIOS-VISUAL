Module Module9
    Sub Main()
        'ejercicio 9

        Dim array(99) As Integer

        For i = 0 To array.Length - 1

            If i Mod 2 = 0 Then
                array(i) = Convert.ToInt32(i / 2)
                Console.WriteLine("El valor para la posición " & i & " es : " & array(i))
            End If

        Next

        Console.ReadLine()
    End Sub
End Module
