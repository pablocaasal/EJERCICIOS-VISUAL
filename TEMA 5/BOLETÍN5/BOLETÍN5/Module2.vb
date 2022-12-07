Module Module2
    Sub Main()
        'ejercicio 2
        Dim array(19) As Single
        For n = 0 To array.Length - 1
            Console.WriteLine("Introduce el valor")
            array(n) = Convert.ToInt32(Console.ReadLine)
        Next
        Console.WriteLine(" ")
        For i = 0 To array.Length - 1
            Console.WriteLine(array(i))
        Next
        Console.ReadLine()
    End Sub
End Module
