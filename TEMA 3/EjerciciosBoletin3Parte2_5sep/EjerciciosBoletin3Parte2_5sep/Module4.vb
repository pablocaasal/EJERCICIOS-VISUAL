Module Module4
    Sub Main()
        'Ejercicio 11
        Dim número As Double
        Dim condición As Boolean

        Console.WriteLine("Introduzca el número")
        número = Convert.ToInt32(Console.ReadLine)
        condición = Convert.ToBoolean(número Mod 2 And número Mod 3)
        If condición = False Then
            Console.WriteLine("El número es múltiplo de 2 o 3")
        End If
        Console.ReadLine()
    End Sub
End Module
