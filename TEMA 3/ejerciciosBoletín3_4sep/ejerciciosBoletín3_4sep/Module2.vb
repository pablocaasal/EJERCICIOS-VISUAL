Module Module2
    Sub Main()
        Dim a, b, c, d, menor As Integer
        Console.WriteLine("INTRODUZACA A")
        a = Convert.ToInt32(Console.ReadLine)
        Console.WriteLine("INTRODUZACA B")
        b = Convert.ToInt32(Console.ReadLine)
        Console.WriteLine("INTRODUZACA C")
        c = Convert.ToInt32(Console.ReadLine)
        Console.WriteLine("INTRODUZACA D")
        d = Convert.ToInt32(Console.ReadLine)
        If a > b Then
            menor = b
        Else
            menor = a
        End If
        If menor > c Then
            menor = c
        End If
        If menor > d Then
            menor = d
        End If

        Console.WriteLine("El menor es " & menor)
        Console.ReadLine()
    End Sub
End Module
