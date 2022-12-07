Module Module1

    Sub Main()
        'ejercicio 1
        For i = 1 To 4
            Console.WriteLine("")
            For b = 1 To i
                Console.Write(b)
            Next
        Next
        For i = 3 To 1 Step -1
            Console.WriteLine("")
            For b = 1 To i
                Console.Write(b)
            Next
        Next

        Console.ReadLine()
    End Sub

End Module
