Module Module5
    Sub Main()
        'ejercicio 24
        Dim numero, contador, contador2 As Integer

        Console.WriteLine("Introduce un número")
        numero = Convert.ToInt32(Console.ReadLine)

        For i = 1 To numero
            contador = 0
            For a = 1 To i
                If i Mod a = 0 Then
                    contador += 1
                End If
            Next
            If contador <> 2 Then

            Else
                Console.WriteLine(i & " es primo")
                contador2 += 1
            End If
        Next
        Console.WriteLine("Hay " & contador2 & " números primos por debajo de " & numero)
        Console.ReadLine()
    End Sub
End Module
