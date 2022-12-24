Module Module3
    Sub Main()
        'ejercicio 3
        Dim matriz(9) As Integer

        For i = 0 To matriz.Length - 1
            Console.WriteLine("Introduce el valor")
            matriz(i) = Convert.ToInt32(Console.ReadLine)
            Console.WriteLine(matriz(i))
        Next
        matriz(0) -= 10
        matriz(2) -= 20
        matriz(5) -= 30
        matriz(9) -= 40

        Console.WriteLine(" ")
        Console.WriteLine("matriz(0)=" & matriz(0))
        Console.WriteLine("matriz(2)=" & matriz(2))
        Console.WriteLine("matriz(5)=" & matriz(5))
        Console.WriteLine("matriz(9)=" & matriz(9))

        Console.ReadLine()
    End Sub
End Module
