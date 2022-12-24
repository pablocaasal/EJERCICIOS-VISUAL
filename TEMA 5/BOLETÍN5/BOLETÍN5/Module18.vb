Module Module18
    Sub Main()

        'ejericicio 18

        Dim array(4) As String
        Dim contador As Integer

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduce la posición " & i)
            array(i) = Console.ReadLine

            If array(i) = Nothing Then
                contador += 1
            End If
        Next

        Console.WriteLine(" ")
        Console.WriteLine("--------------------------------------------------------")
        Console.WriteLine("Hay " & contador & " posiciones vacias dentro del array.")
        Console.WriteLine("--------------------------------------------------------")
        Console.ReadLine()
    End Sub
End Module
