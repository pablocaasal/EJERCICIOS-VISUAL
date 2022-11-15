Module Module1

    Sub Main()
        Dim nivel, contador As Integer
        Dim continuar, acertar As Char

        Do
            Console.WriteLine("")
            Console.WriteLine("Elige el nivel que quiers jugar : 1/2/3")
            nivel = Console.ReadLine

            Select Case nivel
                Case 1
                    Dim ramdom1 As New Random
                    Dim r1, adivinar As Integer
                    r1 = ramdom1.Next(1, 15)
                    contador = 0

                    Do
                        Console.WriteLine("")
                        Console.WriteLine("Adivina el número")
                        adivinar = Console.ReadLine
                        If adivinar = r1 Then
                            Console.WriteLine("Felicidades has acertado!")
                            acertar = "s"c
                        Else
                            Console.WriteLine("Has fallado, más suerte a la próxima")
                        End If
                        contador += 1
                    Loop Until acertar = "s"c Or contador = 3

                    Console.WriteLine("")
                    Console.WriteLine("Quieres volver a intentarlo? s/n")
                    continuar = CChar(Console.ReadLine)

                Case 2
                    Dim ramdom1 As New Random
                    Dim r1, adivinar As Integer
                    r1 = ramdom1.Next(1, 30)
                    contador = 0

                    Do
                        Console.WriteLine("")
                        Console.WriteLine("Adivina el número")
                        adivinar = Console.ReadLine
                        If adivinar = r1 Then
                            Console.WriteLine("Felicidades has acertado!")
                            acertar = "s"c
                        Else
                            Console.WriteLine("Has fallado, más suerte a la próxima")
                        End If
                        contador += 1
                    Loop Until acertar = "s"c Or contador = 4

                    Console.WriteLine("")
                    Console.WriteLine("Quieres volver a intentarlo? s/n")
                    continuar = CChar(Console.ReadLine)

                Case 3
                    Dim ramdom1 As New Random
                    Dim r1, adivinar As Integer
                    r1 = ramdom1.Next(1, 50)
                    contador = 0

                    Do
                        Console.WriteLine("")
                        Console.WriteLine("Adivina el número")
                        adivinar = Console.ReadLine
                        If adivinar = r1 Then
                            Console.WriteLine("Felicidades has acertado!")
                            acertar = "s"c
                        Else
                            Console.WriteLine("Has fallado, más suerte a la próxima")
                        End If
                        contador += 1
                    Loop Until acertar = "s"c Or contador = 6

                    Console.WriteLine("")
                    Console.WriteLine("Quieres volver a intentarlo? s/n")
                    continuar = CChar(Console.ReadLine)

            End Select
        Loop While continuar = "s"c

        Console.ReadLine()
    End Sub

End Module
