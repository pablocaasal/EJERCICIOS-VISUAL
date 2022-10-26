Module Module1

    Sub Main()
        'ejercicio 1 (WHILE)
        Dim i As Integer
        i = -1
        While i <= 9
            i = i + 2
            Console.WriteLine(i)
        End While
        Console.ReadLine()

        i = 0
        While i <= 8
            i = i + 2
            Console.WriteLine(i)
        End While
        Console.ReadLine()

        i = 0
        While i <= 20
            i = i + 5
            Console.WriteLine(i)
        End While
        Console.ReadLine()

        i = 110
        While i >= 60
            i = i - 10
            Console.WriteLine(i)
        End While
        Console.ReadLine()

        i = -1
        While (i <= 5)
            i = i + 2
            Console.WriteLine(i * Math.PI)
        End While
        Console.ReadLine()

    End Sub

End Module
