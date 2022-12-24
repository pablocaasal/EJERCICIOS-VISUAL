Module Module7
    Sub Main()
        'ejericio 7
        Dim nPosiciones As Integer
        Dim array(nPosiciones - 1) As Integer

        Console.WriteLine("Introduce la capacidad máxima de la array")
        nPosiciones = Convert.ToInt32(Console.ReadLine)

        array(0) = 1
        array(array.Length - 1) = 2

        For i = 0 To array.Length - 1
            Console.WriteLine(array(i))
        Next

        Console.ReadLine()

    End Sub
End Module
