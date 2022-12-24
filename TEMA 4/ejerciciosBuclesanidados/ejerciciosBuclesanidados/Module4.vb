Module Module4
    Sub Main()
        'ejercicio 23
        Dim numero, suma As Integer

        Console.WriteLine("Introduce un número")
        numero = Convert.ToInt32(Console.ReadLine)

        For i = 1 To numero
            suma = 0
            For b = 1 To i - 1
                If i Mod b = 0 Then
                    suma += b

                End If
            Next
            If suma = i Then
                Console.WriteLine(suma)
            End If
        Next


        Console.ReadLine()
    End Sub
End Module
