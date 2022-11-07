Module Module10
    Sub Main()
        'ejercicio 10
        Dim m, suma As Integer

        Console.WriteLine("Introduzca m")
        m = Convert.ToInt32(Console.ReadLine)

        While m < 0
            Console.WriteLine("Introduzca m")
            m = Convert.ToInt32(Console.ReadLine)
        End While

        For i = m To 1 Step -1
            suma = suma + i
        Next

        Console.WriteLine(suma)
        Console.ReadLine()
    End Sub
End Module
