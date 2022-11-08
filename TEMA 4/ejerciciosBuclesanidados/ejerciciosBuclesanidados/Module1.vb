Module Module1

    Sub Main()

        For b = 1 To 10
            Console.WriteLine("-------------------------------")
            For i = 1 To 10
                Console.WriteLine(b & "x" & i & "=" & b * i)
            Next
        Next

        Console.ReadLine()
    End Sub

End Module
