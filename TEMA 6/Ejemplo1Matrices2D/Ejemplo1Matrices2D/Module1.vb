Module Module1

    Sub Main()
        'crear matriz 2d tipo integer

        Dim matriz(2, 2) As Integer

        'Pedrir los valores por pantalla

        For n = 0 To 2
            Console.WriteLine()
            For k = 0 To 2
                Console.WriteLine("Introduce el valor de la posición " & n & "," & k)
                matriz(n, k) = Convert.ToInt32(Console.ReadLine)
            Next
        Next

        Console.WriteLine("")

        'Mostrarla por pantalla

        For f = 0 To 2
                Console.WriteLine()
                For c = 0 To 2
                Console.Write(matriz(f, c) & " ")
            Next
            Next

        Console.ReadLine()

        'GetUpperBound (introducir dimension) -- Devuelve el ultimo indice accesible de la dimension especificada (0 filas) (1 columnas)

        Dim matriz2(2, 1) As Integer
        Dim filas As Integer = matriz2.GetUpperBound(0)
        Dim columnas As Integer = matriz2.GetUpperBound(1)
        Console.WriteLine("Ultimo indice de fila " & filas)
        Console.WriteLine("Ultimo indice de columna " & columnas)

        'GetUpperBound se puede usar para recorrer matrices 2D

        For g = 0 To matriz2.GetUpperBound(0)
            Console.WriteLine("")
            For v = 0 To matriz2.GetUpperBound(1)
                Console.Write(matriz2(g, v) & " ")
            Next
        Next

        Console.ReadLine()

    End Sub

End Module
