Module Module17
    Sub Main()
        'ejercicio 17

        Dim array(9) As Integer
        Dim contador As Integer
        Dim porcentaje As Double

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduce el valor de la posición " & i)
            array(i) = Convert.ToInt32(Console.ReadLine)

            If array(i) Mod 2 <> 0 Then
                contador += 1
            End If
        Next

        porcentaje = (contador / array.Length) * 100

        Console.WriteLine(" ")
        Console.WriteLine("-----------------------------------------------------------")
        Console.WriteLine("El porcentaje de valores impares es : " & porcentaje & "%")
        Console.WriteLine("-----------------------------------------------------------")
        Console.ReadLine()
    End Sub
End Module
