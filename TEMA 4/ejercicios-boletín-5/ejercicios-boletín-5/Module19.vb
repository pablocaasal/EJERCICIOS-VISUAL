Module Module19
    Sub Main()
        'ejercicio 18
        Dim n As Integer

        Console.WriteLine("Introduce un número")
        n = Convert.ToInt32(Console.ReadLine)

        While n <= 0
            Console.WriteLine("Introduce un número")
            n = Convert.ToInt32(Console.ReadLine)
        End While

        For n = n To n

        Next
        Console.ReadLine()
    End Sub
End Module
