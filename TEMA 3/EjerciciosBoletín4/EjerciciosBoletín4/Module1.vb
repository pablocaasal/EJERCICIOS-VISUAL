Module Module1

    Sub Main()
        Dim numero As Byte



        Do
            Console.WriteLine("----------------------------------------------------------------")
            Console.WriteLine("Selecciona un ejercicio del boletín 4 : 3 - 17")
            Console.WriteLine("Pulse 1 si quiere salir del programa")
            numero = Convert.ToByte(Console.ReadLine)

            If numero = 3 Then
                Dim a, b, c, d, menor As Integer

                Console.WriteLine("Introduzca a")
                a = Convert.ToInt32(Console.ReadLine)
                Console.WriteLine("Introduzca b")
                b = Convert.ToInt32(Console.ReadLine)
                Console.WriteLine("Introduzca c")
                c = Convert.ToInt32(Console.ReadLine)
                Console.WriteLine("Introduzca d")
                d = Convert.ToInt32(Console.ReadLine)

                If a < b Then
                    If a < c Then
                        If a < d Then
                            menor = a
                        Else
                            menor = d
                        End If
                    Else
                        If c < d Then
                            menor = c
                        Else
                            menor = d
                        End If

                    End If
                Else
                    If b < c Then
                        If b < d Then
                            menor = b
                        Else
                            menor = d
                        End If
                    Else
                        If c < d Then
                            menor = c
                        Else
                            menor = d
                        End If
                    End If
                End If
                Console.WriteLine("El menor es : " & menor)
            ElseIf numero = 4 Then
            ElseIf numero = 5 Then
            ElseIf numero = 6 Then
                Dim numerox, resultadofinal As Integer
                Console.WriteLine("Introduzca un número")
                numerox = Convert.ToInt32(Console.ReadLine)
                If numerox Mod 4 = 0 Then
                    resultadofinal = numerox + 25
                Else
                    If numerox Mod 5 = 0 Then
                        resultadofinal = numerox + 100
                    Else
                        resultadofinal = numerox + 150
                    End If
                End If
                Console.WriteLine("El valor inicial era " & numerox & " y el valor final es " & resultadofinal)
            ElseIf numero = 7 Then
            ElseIf numero = 8 Then


            End If


        Loop While numero <> 1





    End Sub

End Module
