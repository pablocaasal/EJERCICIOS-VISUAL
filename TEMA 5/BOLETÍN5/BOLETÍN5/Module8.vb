Module Module8
    Sub Main()
        'ejercicio 8

        Dim ramdom As New Random
        Dim array(99) As Integer

        For i = 0 To array.Length - 1
            array(i) = ramdom.Next(0, 10)
            Console.WriteLine("El valor de la posición " & i & " es : " & array(i))
        Next

        Console.ReadLine()
    End Sub
End Module
