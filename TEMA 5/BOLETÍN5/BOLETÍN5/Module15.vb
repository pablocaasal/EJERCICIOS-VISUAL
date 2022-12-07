Module Module15
    Sub Main()
        'ejercicio 15

        Dim array(3) As Integer
        Dim suma As Integer

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduce el valor de la posición " & i)
            array(i) = Convert.ToInt32(Console.ReadLine)

            If array(i) >= 0 Then
                suma += array(i)
            End If

        Next

        Console.WriteLine(" ")
        Console.WriteLine("--------------------------------------------------")
        Console.WriteLine("La suma de los valores positivos es : " & suma)
        Console.WriteLine("--------------------------------------------------")
        Console.ReadLine()
    End Sub
End Module
