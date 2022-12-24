Module Module6
    Sub Main()
        'ejercicio 6 
        Dim n1 As Integer
        For n1 = 0 To 100
            If n1 Mod 5 = 0 Then
                Console.WriteLine(n1 & " es múltiplo de 5")
            End If

            If n1 Mod 7 = 0 Then
                Console.WriteLine(n1 & " es múltiplo de 7")
            End If
        Next
        Console.ReadLine()



    End Sub
End Module
