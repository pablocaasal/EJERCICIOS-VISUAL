Module Module11
    Sub Main()
        'ejercicio 11
        Dim n As Integer
        Dim c, suma As Double

        Console.WriteLine("Introduce n")
        n = Convert.ToInt32(Console.ReadLine)

        For i = 1 To n Step 1
            c = 1 / (i ^ 3)
            suma += c
        Next
        Console.WriteLine(suma)
        Console.ReadLine()
    End Sub
End Module
