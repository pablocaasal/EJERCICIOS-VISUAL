Module Module3
    Sub Main()
        'Ejercicio 10
        Dim presión, temperatura As Double
        Dim condición As Boolean

        Console.WriteLine("Introduzca la presión ")
        presión = Convert.ToDouble(Console.ReadLine)

        If presión > 2 Then
            Console.WriteLine("Abrir válvula de seguridad")
        End If

<<<<<<< HEAD
=======
        Console.WriteLine("-----------------------------------------------------")
>>>>>>> cc10482ca354a14dfe8e65e35e2bc49bd3bc34c1
        Console.WriteLine("Introduzca la temperatura ")
        temperatura = Convert.ToDouble(Console.ReadLine)

        If temperatura > 500 Then
            Console.WriteLine("Reducir la temperatura")
        End If

        condición = presión > 2 And temperatura > 500

        If condición Then
            Console.WriteLine("-----------------------------------------------------")
            Console.WriteLine("Abrir válvula de seguridad y reducir la temperatura")
        Else
            Console.WriteLine("-----------------------------------------------------")
            Console.WriteLine("Todo está en orden")
        End If
        Console.ReadLine()

    End Sub
End Module
