Module Module12
    Sub Main()
        'ejercicio furbo
        Dim r1 As New Random
        Dim n As Integer

        Console.WriteLine("Introduce un número de posiciones ")
        n = Convert.ToInt32(Console.ReadLine)

        For i = 1 To n
            Console.WriteLine(r1.Next(n))
            Console.WriteLine(r1.Next(n))
            Console.WriteLine("--------------------")
        Next
        Console.ReadLine()
    End Sub
End Module
