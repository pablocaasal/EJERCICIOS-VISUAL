Module Module1

    Sub Main()
        'Mostrar 1,3,5,7,9,11
        'EJERCICIO 1 (FOR)
        Dim i As Integer

        'APARTADO A
        For i = 1 To 11 Step 2
            Console.WriteLine(i)
        Next
        Console.ReadLine()

        'APARTADO B
        For i = 2 To 10 Step 2
            Console.WriteLine(i)
        Next
        Console.ReadLine()

        'APARTADO C
        For i = 5 To 25 Step 5
            Console.WriteLine(i)
        Next
        Console.ReadLine()

        'APARTADO D
        For i = 100 To 50 Step -10
            Console.WriteLine(i)
        Next
        Console.ReadLine()

        'EJERCICIO PI
        For i = 1 To 7 Step 2
            Console.WriteLine(i * Math.PI)
        Next
        Console.ReadLine()

    End Sub

End Module
