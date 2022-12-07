Module Module5
    Sub Main()
        'ejercicio 6
        Console.WriteLine("Apartado A")
        Console.WriteLine(" ")

        For i = 1 To 10
            For k = 1 To i
                Console.Write("*")
            Next
            Console.WriteLine(" ")
        Next

        Console.WriteLine(" ")

        'Apartado B
        Console.WriteLine("Apartado B")
        Console.WriteLine(" ")

        For b = 10 To 1 Step -1
            For y = 1 To b
                Console.Write("*")
            Next
            Console.WriteLine(" ")
        Next

        Console.WriteLine(" ")
        Console.WriteLine(" ")

        'Apartado C
        Console.WriteLine("Apartado C")
        Console.WriteLine(" ")

        Dim p As Integer
        Dim espacio As String
        espacio = ""
        p = 10

        For m = 1 To 10
            For y = 1 To p
                Console.Write("*")
            Next
            Console.WriteLine(" ")
            espacio = espacio + " "
            Console.Write(espacio)
            p = p - 1
        Next

        'Apartado D
        Console.WriteLine("Apartado D")
        Console.WriteLine(" ")

        Dim p2 As Integer
        Dim espacio2 As String
        espacio = ""
        p = 10
        For x = 1 To 10
            For y = 1 To x
                Console.Write("*")
            Next
            Console.WriteLine(" ")
            espacio2 = espacio2 + " "
            Console.Write(espacio2)
            p2 = p2 - 1
        Next

        Console.ReadLine()

    End Sub
End Module
