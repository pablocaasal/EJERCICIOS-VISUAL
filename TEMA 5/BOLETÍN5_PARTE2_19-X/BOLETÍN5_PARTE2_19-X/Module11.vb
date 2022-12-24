Module Module11
    Sub Main()
        'ejericico 28 copia arrary con funcion copy

        Dim arrayOriginal(4) As Integer
        Dim copiaArray(4) As Integer

        For i = 0 To arrayOriginal.Length - 1
            Console.WriteLine("Introduce el valor de la posición " & i)
            arrayOriginal(i) = Convert.ToInt32(Console.ReadLine)
        Next

        Array.Copy(arrayOriginal, copiaArray, arrayOriginal.Length)

        Console.WriteLine(" ")
        Console.WriteLine("ARRAY ORIGINAL")

        For n = 0 To arrayOriginal.Length - 1
            Console.WriteLine("El valor de la posición " & n & " es " & arrayOriginal(n))
        Next

        Console.WriteLine(" ")
        Console.WriteLine("COPIA ARRAY")

        For n = 0 To copiaArray.Length - 1
            Console.WriteLine("El valor de la posición " & n & " es " & copiaArray(n))
        Next

        Console.ReadLine()
    End Sub
End Module
