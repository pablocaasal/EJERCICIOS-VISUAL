Module Module2
    Sub Main()
        'Declaramos dos matrices
        Dim nombres(4) As String
        Dim goles(4) As Integer

        For n = 0 To 4
            Console.WriteLine("Introduce el nombre del futbolista")
            nombres(n) = Console.ReadLine
            Console.WriteLine("Introduce el número de goles")
            goles(n) = Convert.ToInt32(Console.ReadLine)
        Next

        For i = 0 To 4
            Console.WriteLine("Nombre del futbolita : " & nombres(i) & " Número de goles : " & goles(i))
        Next

        'Llega el var

        goles(4) -= 1
        Console.WriteLine("Llega el VAR")
        For i = 0 To 4
            Console.WriteLine("Nombre del futbolita : " & nombres(i) & " Número de goles : " & goles(i))
        Next
        Console.ReadLine()

    End Sub
End Module
