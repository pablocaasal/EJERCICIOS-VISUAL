Module Module1

    Sub Main()
        'Ejemplo 1
        Dim numero As Byte
        Try
            Console.WriteLine("Introduzca un número")
            numero = Console.ReadLine

            If numero <= 20 And numero >= 10 Then
                Console.WriteLine("Entre 10 y 20")
            Else
                Console.WriteLine("ERROR")
            End If

            'eJEMPLO 2 indicar si el número es multiplo de 3
            If numero Mod 3 = 0 Then
                Console.WriteLine("Es multiplo de 3")
            End If

            Console.ReadLine()
        Catch ex As Exception
            Console.WriteLine("Error en la entrada de datos")
        End Try
        Console.ReadLine()



    End Sub

End Module
