Module Module4
    Sub Main()
        'ejercicio 4
        Dim mejoresLibros() As String = {"RDR2", "Elden Ring", "The last of us", "AC 2", "Cyberpunk"}

        For i = 0 To mejoresLibros.Length - 1
            Console.WriteLine(mejoresLibros(i))
        Next
        Console.ReadLine()
    End Sub
End Module
