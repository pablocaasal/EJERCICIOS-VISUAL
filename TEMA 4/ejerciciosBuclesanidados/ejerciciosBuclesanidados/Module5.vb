Module Module5
    Sub Main()
        'ejercicio 24
        Dim numero, contador, contador2 As Integer

        Console.WriteLine("Introduce un número")
        numero = Convert.ToInt32(Console.ReadLine)

        For i = 2 To numero
            contador = 0
            If i Mod 1 = 0 And i Mod i = 0 Then
                contador += 2
            End If
            If contador = 2 Then
                contador2 += 1
            End If
        Next
        Console.WriteLine(contador2)
        Console.ReadLine()
    End Sub
End Module
