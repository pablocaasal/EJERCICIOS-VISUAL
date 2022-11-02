Module Module10
    Sub Main()
        'ejercicio 10
        Dim m, resultado As Integer

        Console.WriteLine("Introduzca m")
        m = Convert.ToInt32(Console.ReadLine)

        While m < 0
            Console.WriteLine("Introduzca m")
            m = Convert.ToInt32(Console.ReadLine)
        End While

        For m = 1 To m Step 1
            m += m
        Next
        resultado = m - 1
        Console.WriteLine(resultado)
        Console.ReadLine()
    End Sub
End Module
