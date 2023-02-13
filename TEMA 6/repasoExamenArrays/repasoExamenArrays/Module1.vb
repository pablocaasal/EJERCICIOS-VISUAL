Module Module1

    Sub Main()

        Dim matriz(4) As Integer
        Dim random As New Random

        'sort y reverse, BinarySearch, Copy, IndexOf y LastIndexOf, ReDim

        For i = 0 To matriz.Length - 1
            matriz(i) = random.Next(3, 5)
            Console.WriteLine("")
            Console.WriteLine(matriz(i))
        Next

        Console.WriteLine("Ordenada menor a mayor:")

        'sort ordenar menor a mayor, reverse para mayor a menor

        Array.Sort(matriz)

        For u = 0 To matriz.Length - 1
            Console.WriteLine("")
            Console.WriteLine(matriz(u))
        Next

        'buscar cn BinarySearch

        Dim posicion As Integer = Array.BinarySearch(matriz, 4)

        If posicion >= 0 Then

            Console.WriteLine("El númeró está en la posición" & posicion)
        Else
            Console.WriteLine("El número no está en la matriz")
        End If

        Console.WriteLine("copia")

        Dim matrizCopia(matriz.Length - 1) As Integer

        Array.Copy(matriz, matrizCopia, matriz.Length)

        For f = 0 To matrizCopia.Length - 1

            Console.WriteLine()
            Console.WriteLine(matrizCopia(f))
        Next

        Console.WriteLine("buscar la primera aparicion de un número")

        Dim indice As Integer = Array.IndexOf(matrizCopia, 3)

        If indice < 0 Then
            Console.WriteLine("No se ha encontrado el número")
        Else
            Console.WriteLine("El número está en la posición " & indice)
        End If

        Console.WriteLine("buscar la última aparición de un número")

        Dim indice2 As Integer = Array.LastIndexOf(matrizCopia, 3)

        If indice < 0 Then
            Console.WriteLine("No se ha encontrado el número")
        Else
            Console.WriteLine("El número está en la posición " & indice2)
        End If

        Console.WriteLine("Redimensionar el tamaño de una matriz preservnado sus datos (quitar el preverse para borrar los datos)")

        ReDim Preserve matriz(9)

        For o = 0 To matriz.Length - 1
            matriz(o) = random.Next(3, 6)
            Console.WriteLine()
            Console.WriteLine(matriz(o))
        Next

        Console.ReadLine()

    End Sub

End Module
