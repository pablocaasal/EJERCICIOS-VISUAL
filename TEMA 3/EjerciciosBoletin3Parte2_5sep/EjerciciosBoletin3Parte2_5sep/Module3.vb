﻿Module Module3
    Sub Main()
        'Ejercicio 10
        Dim presión, temperatura As Double
        Dim condición As Boolean

        Console.WriteLine("Introduzca la presión ")
        presión = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Introduzca la temperatura ")
        temperatura = Convert.ToDouble(Console.ReadLine)
        condición = presión > 2 And temperatura > 500

        If presión > 2 Then
            Console.WriteLine("Abrir válvula de seguridad")
        End If
        If temperatura > 500 Then
            Console.WriteLine("Reducir la temperatura")
        End If
        If condición Then
            Console.WriteLine("Abrir válvula de seguridad y reducir la temperatura")
        Else
            Console.WriteLine("Todo está en orden")
        End If
        Console.ReadLine()

    End Sub
End Module
