Module CasalPabloEjercicio3
    Sub Main()
        Dim numero As Integer
        Console.WriteLine("Introduce el número")
        numero = Convert.ToInt32(Console.ReadLine)

        If numero Mod 2 = 0 Then
            Console.WriteLine("El número es múltiplo de 2")
        ElseIf numero Mod 3 = 0 Then
            Console.WriteLine("El número es múltiplo de 3")
        ElseIf numero Mod 5 = 0 Then
            Console.WriteLine("El número es múltiplo de 5")
        End If

        Console.ReadLine()
    End Sub
End Module
