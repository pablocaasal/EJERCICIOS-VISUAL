Module Module6
    Sub Main()
        'ejercicio 25

        Dim ramdom As New Random
        Dim contadorNegativo, contadorPositivo, contadorRango, n As Integer
        For B = 1 To 10
            contadorNegativo = 0
            contadorPositivo = 0
            contadorRango = 0
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            For i = 1 To 10
                n = ramdom.Next(-5, 5)
                Console.WriteLine(n)
                Console.WriteLine("--------------------")

                If n < 0 Then
                    contadorNegativo += 1
                Else
                    contadorPositivo += 1
                End If

                If n >= -2 And n <= 2 Then
                    contadorRango += 1
                End If

            Next
            Console.WriteLine(contadorNegativo & " números negativos")
            Console.WriteLine(contadorPositivo & " números positivos")
            Console.WriteLine(contadorRango * 10 & "%")
        Next

        Console.ReadLine()

    End Sub
End Module
