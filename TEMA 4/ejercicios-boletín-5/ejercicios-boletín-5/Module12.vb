Module Module12
    Sub Main()
        'ejercicio furbo
        Dim r1 As New Random
        Dim r2 As New Random

        For i = 1 To 8
            Console.WriteLine(r1.Next(8))
            Console.WriteLine(r1.Next(8))
            Console.WriteLine("--------------------")
        Next
        Console.ReadLine()
    End Sub
End Module
