Module Module5
    Sub Main()
        'ejercicio 5

        Dim array(3) As Short

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduce el valor para la posición " & i & " de la array")
            array(i) = Convert.ToInt16(Console.ReadLine)
            Console.WriteLine("El valor de la posición " & i & " de la array es " & array(i))
            Console.WriteLine(" ")
        Next
        Console.ReadLine()
    End Sub
End Module
