Module Module11
    Sub Main()
        'ejercicio 11

        Dim ramdom As New Random
        Dim array(49) As Integer

        For i = 0 To array.Length - 1
            array(i) = ramdom.Next(-10, 50 + 1)
            If array(i) < 0 Then
                Console.WriteLine("El valor para la posición " & i & " es : " & array(i))
            End If
        Next

        Console.ReadLine()
    End Sub
End Module
