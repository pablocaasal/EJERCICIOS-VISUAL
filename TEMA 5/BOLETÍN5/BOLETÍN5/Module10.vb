Module Module10
    Sub Main()
        'ejericicio 10
        Dim ramdom As New Random
        Dim array(99) As Integer

        For i = 0 To array.Length - 1

            If i Mod 2 = 0 Then

            Else
                array(i) = ramdom.Next(10, 35 + 1)
                Console.WriteLine("El valor para la posición " & i & " es : " & array(i))
            End If

        Next

        Console.ReadLine()
    End Sub
End Module
