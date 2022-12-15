Module Module6
    Sub Main()
        'ejericico 24 función sort

        Dim array(4) As Integer

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduce el valor de la posición " & i)
            array(i) = Convert.ToInt32(Console.ReadLine)
        Next

        array.Sort(array)

        Console.WriteLine(" ")
        Console.WriteLine("Array ordenada de menor a mayor")

        For n = 0 To array.Length - 1
            Console.WriteLine(array(n))
        Next

        Console.ReadLine()
    End Sub
End Module
