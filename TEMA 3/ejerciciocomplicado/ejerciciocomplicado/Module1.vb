Module Module1

    Sub Main()
        Dim numero As Integer
        Dim c1 As Integer
        Dim c2 As String
        Do
            Do
                Console.WriteLine("Mete un número multiplo de 6 y mayor que 100")
                numero = Convert.ToInt32(Console.ReadLine)
                c1 += 1
            Loop Until (numero Mod 6 = 0 And numero > 100) Or c1 = 3
            
            If numero Mod 6 = 0 And numero > 100 Then
                Console.WriteLine("!HAS ACERTADO!")
                Console.WriteLine("Quieres jugar de nuevo?")
                c2 = Convert.ToString(Console.ReadLine)

            End If

            If c1 = 3 Then
                Console.WriteLine("Has fallado, no te quedan más intentos :( ")
                Console.WriteLine("Quieres jugar de nuevo?")
                c2 = Convert.ToString(Console.ReadLine)

                End If
            c1 = 0
        Loop While c2 = "si"

        Console.ReadLine
    End Sub

End Module
