Module Module1

    Sub Main()
        'Generar 1000 NUMEROS ramdom entre 0 y 10

        Dim i As Integer
        Dim ramdom As New Random
        i = 1001
        While (i > 0)
            i = i - 1
            Console.WriteLine(ramdom.Next(11))
        End While

        Console.ReadLine()

        'Mostrar 1000 números
        Dim i2 As Integer
        i2 = 0
        While (i2 < 1000)
            i2 = i2 + 1
            Console.WriteLine(i2)
        End While
        Console.ReadLine()

        Dim i3 As Integer
        While (i3 < 1000)
            i3 += 1
            Console.WriteLine(i3)
        End While
        Console.ReadLine()
    End Sub

End Module
