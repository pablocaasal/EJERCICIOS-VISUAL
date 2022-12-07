Module Module12
    Sub Main()
        'ejercicio 12
        Dim array(3) As Integer
        Dim suma As Integer

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduce el valor de la posición " & i)
            array(i) = Convert.ToInt32(Console.ReadLine)
            suma += array(i)
        Next

        Console.WriteLine("La suma de las 4 posiciones es : " & suma)
        Console.ReadLine()
    End Sub
End Module
