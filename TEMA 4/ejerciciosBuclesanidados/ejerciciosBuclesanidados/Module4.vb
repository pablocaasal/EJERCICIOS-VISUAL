Module Module4
    Sub Main()
        'ejercicio 23
        Dim numero, suma As Integer

        Console.WriteLine("Introduce un número")
        numero = Convert.ToInt32(Console.ReadLine)
        For B = 1 To numero
            For i = 1 To numero - 1
                If numero Mod i = 0 Then
                    suma += i
                    If suma = numero Then
                        Console.WriteLine(numero & " es un número perfecto")
                    End If
                End If
            Next
        Next
        Console.ReadLine()
    End Sub
End Module
