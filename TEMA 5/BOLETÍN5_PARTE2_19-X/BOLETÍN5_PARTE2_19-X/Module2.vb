Module Module2
    Sub Main()
        'ejericicio 20

        Dim matriz(4) As Double

        For i = 0 To matriz.Length - 1
            Console.WriteLine("Introduce la " & i & " opción")
            matriz(i) = Console.ReadLine()
        Next

        For n = 1000.0 To 999999.0

            Dim posicion As Double = Array.BinarySearch(matriz, n)

            If posicion < 0 Then
                Console.WriteLine("No se ha encontrado ningún número mayor que 1000")
                Exit For
            Else
                Console.WriteLine("")
                Console.WriteLine(n & " es el primer número mayor que 1000 y está en la posición " & posicion)
                Exit For

            End If

        Next

        Console.ReadLine()

    End Sub
End Module
