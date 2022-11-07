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

        If n Mod 1 = 0 And n Mod n = 0 Then
            Console.WriteLine(n & " es primo")
        Else
            Console.WriteLine(n & "  no es primo")
        End If
        Console.ReadLine()
    End Sub
End Module
