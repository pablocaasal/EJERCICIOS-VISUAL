Module Module14
    Sub Main()
        'ejercicio 14

        Dim array(3) As Integer
        Dim suma As Double
        Dim cuadrado As Double

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduce el valor del índice " & i)
            array(i) = Convert.ToInt32(Console.ReadLine)
            suma += Math.Pow(array(i), 2)

            cuadrado = 0
            cuadrado += Math.Pow(array(i), 2)
            Console.WriteLine("El cuadrado del valor del índice " & i & " es : " & cuadrado)
            Console.WriteLine(" ")
        Next

        Console.WriteLine("-------------------------------------------------------")
        Console.WriteLine("La suma de los cuadrados de los valores es : " & suma)
        Console.WriteLine("-------------------------------------------------------")
        Console.ReadLine()
    End Sub
End Module
