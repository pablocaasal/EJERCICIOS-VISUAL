Module Module3
    Sub Main()
        'Ejercicio 5 Boletin 3
        Dim numero As Double
        Console.WriteLine("iNTRODUZCA UN NÚMERO")
        numero = Convert.ToDouble(Console.ReadLine)

        If numero Mod 2 = 0 Then
            Console.WriteLine("EL NÚMERO ES PAR")
        Else
            Console.WriteLine("El NÚMERO ES IMPAR")
        End If
        Console.ReadLine()

    End Sub
End Module
