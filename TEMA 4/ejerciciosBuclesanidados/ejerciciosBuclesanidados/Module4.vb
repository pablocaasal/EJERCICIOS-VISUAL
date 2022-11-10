Module Module4
    Sub Main()
        'ejercicio 23
        Dim numero, suma As Integer

        Console.WriteLine("Introduce un número")
        numero = Convert.ToInt32(Console.ReadLine)

        For I = 1 To numero - 1
            If numero Mod I = 0 Then
                suma += I
            End If
            For B = 1 To I
                While suma = 6
                    Console.WriteLine(suma)
                End While
            Next
        Next

        Console.ReadLine()
    End Sub
End Module
