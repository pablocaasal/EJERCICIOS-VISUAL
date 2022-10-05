Module Module1

    Sub Main()
        'Ejercicio 8
        Dim contraseña1, contraseña2 As String
        Do
            Console.WriteLine("Introduzca la contraseña")
            contraseña1 = Console.ReadLine
            Console.WriteLine("Confirme la contraseña")
            contraseña2 = Console.ReadLine

            If contraseña1 = contraseña2 Then
                Console.WriteLine("La contraseña es correcta")
            Else
                Console.WriteLine("Las contraseñas no coinciden, vuelva a introducirlas ")
            End If
        Loop While contraseña1 <> contraseña2
        Console.ReadLine()

    End Sub

End Module
