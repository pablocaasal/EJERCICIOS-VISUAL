Module Module16
    Sub Main()
        'ejercicio 16

        Dim array(3) As Integer
        Dim contador As Integer

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduce el valor de la posición " & i)
            array(i) = Convert.ToInt32(Console.ReadLine)

            If array(i) < 0 Then
                contador += 1
            End If

        Next

        Console.WriteLine(" ")
        Console.WriteLine("--------------------------------------------------")
        Console.WriteLine("Hay " & contador & " valores negativos en la array")
        Console.WriteLine("--------------------------------------------------")
        Console.ReadLine()

    End Sub
End Module
