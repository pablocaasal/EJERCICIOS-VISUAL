Module Module1

    Sub Main()
        Dim numero As Integer
        Dim continuar As Char
        Do
            Console.WriteLine("Introduce un número.")
            numero = Convert.ToInt32(Console.ReadLine())

            If numero Mod 6 = 0 Then
                    If numero > 100 Then
                        Console.WriteLine("Múltiplo de 6 y > 100")
                    Else
                        Console.WriteLine("Múltiplo de 6 y <= 100")

                    End If
                Else
                    If numero > 100 Then
                        Console.WriteLine("No multiplo de 6 y > 100")
                    Else
                        Console.WriteLine("No multiplo de 6 y =< 100")
                    End If
                End If
                Console.WriteLine("Quiere continuar en el programa? s/n")
                continuar = Console.ReadLine
        Loop While continuar = "s"c

        Console.ReadLine()
    End Sub

End Module
