Module Module6
    Sub Main()
        'ejercicio 25

        Dim ramdom As New Random
        For B = 1 To 10
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            For i = 1 To 10
                Console.WriteLine(ramdom.Next(-5, 5))
                Console.WriteLine("--------------------")
            Next
        Next

        Console.ReadLine()

    End Sub
End Module
