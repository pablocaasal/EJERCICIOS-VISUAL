Module CasalPabloEjercicio4
    Sub Main()
        Dim factorial As Integer

        For i = 1 To 10
            factorial = 1
            For n = 1 To i
                factorial *= n
            Next
            Console.WriteLine("factorial de " & i & "=" & factorial)
        Next
        Console.ReadLine()
    End Sub
End Module
