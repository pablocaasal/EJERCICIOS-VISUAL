Module Operadoresmatemáticos

    Sub Main()
        'EJEMPLO OPERADORES
        'MOD , / , \
        Dim X As Integer = 14
        Dim y As Integer = 4

        Dim resto As Integer = X Mod y
        Dim divisionReal = X / y
        Dim divisiónEntera As Integer = X \ y
        Console.WriteLine("Restp " & resto)
        Console.WriteLine("Division real " & divisionReal)
        Console.WriteLine("Division entera " & divisiónEntera)
        Console.ReadLine()
    End Sub

End Module
