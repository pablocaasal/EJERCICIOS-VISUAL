Module CasalPabloEjercicio3
    Sub Main()
        Dim n, m, contador As Integer
        Console.WriteLine("Introduce n")
        n = Convert.ToInt32(Console.ReadLine)
        Console.WriteLine("Introduce m")
        m = Convert.ToInt32(Console.ReadLine)

        For i = n To m
            contador = 0
            For n = 1 To i
                If i Mod n = 0 Then
                    contador += 1
                End If
            Next
            If contador <= 2 Then
                Console.WriteLine(i)
            End If
        Next
        Console.ReadLine()
    End Sub
End Module
