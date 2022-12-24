Module CasalPabloEJercicio2

    Sub Main()
        Dim opcion, número, factorial As Integer
        Dim continuar As Char
        Do
            Console.WriteLine("---------------------------")
            Console.WriteLine("Elige una opción")
            Console.WriteLine("1:Calcular el factorial de un número")
            Console.WriteLine("2:Comprobar si ese número es perfecto")
            Console.WriteLine("3:Comprobar si ese número es primo")
            Console.WriteLine("4:Comprobar si ese número es impar")
            opcion = Convert.ToInt32(Console.ReadLine)

            Console.WriteLine("Introduce un número")
            número = Convert.ToInt32(Console.ReadLine)
            Select Case opcion
                Case 1
                    factorial = 1
                    For i = 1 To número
                        factorial *= i
                    Next
                    Console.WriteLine(factorial)
                Case 2
                    Dim divisores As Integer
                    divisores = 0

                    For i = 1 To número - 1
                        If número Mod i = 0 Then
                            divisores += i
                        End If
                    Next

                    If divisores = número Then
                        Console.WriteLine(número & " es perfecto")
                    Else
                        Console.WriteLine(número & " no es perfecto")
                    End If
                Case 3
                    Dim contador As Integer
                    contador = 0

                    For i = 1 To número
                        If número Mod i = 0 Then
                            contador += 1
                        End If
                    Next
                    If contador <= 2 Then
                        Console.WriteLine(número & " es primo")
                    Else
                        Console.WriteLine(número & " no es primo")
                    End If
                Case 4
                    If número Mod 2 = 0 Then
                        Console.WriteLine(número & " es par")
                    Else
                        Console.WriteLine(número & " es impar")
                    End If
                Case Else
                    Console.WriteLine("Error en la opción introducida")

            End Select

            Console.WriteLine(" ")
            Console.WriteLine("Desea continuar ? s/n")
            continuar = CChar(Console.ReadLine)

        Loop Until continuar = "n"c

        Console.ReadLine()

    End Sub

End Module
