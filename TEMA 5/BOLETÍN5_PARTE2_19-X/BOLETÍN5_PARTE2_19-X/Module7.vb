Module Module7
    Sub Main()
        'ejericio 25

        Dim array(4) As Integer

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduce la posición " & i)
            array(i) = Convert.ToInt32(Console.ReadLine)
        Next

        array.Sort(array)

        Console.WriteLine(" ")
        Console.WriteLine("El valor mas pequeño es " & array(0))

        Console.ReadLine()

    End Sub
End Module
