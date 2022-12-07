Module Module6
    Sub Main()
        'ejercicio 6
        Dim ramdom As New Random
        Dim array(49) As Double

        For i = 0 To array.Length - 1
            array(array.Length - 1) = -1
            Console.WriteLine(array(i))
        Next

        Console.ReadLine()
    End Sub
End Module
