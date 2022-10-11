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
                Console.WriteLine("No hay ejercicio 4, escoge otro")

            ElseIf numero = 5 Then
                'ejercicio 5
                Dim nota As Double

                Console.WriteLine("Introduzca la nota ")
                nota = Convert.ToDouble(Console.ReadLine)

                If nota < 0 Or nota > 10 Then
                    Console.WriteLine("Error al introducir la nota")

                ElseIf nota < 5 Then
                    Console.WriteLine("Suspenso")
                ElseIf nota >= 5 And nota < 6.5 Then
                    Console.WriteLine("Aprobado")
                ElseIf nota >= 6.5 And nota < 8.5 Then
                    Console.WriteLine("Notable")
                ElseIf nota >= 8.5 And nota <= 10 Then
                    Console.WriteLine("Sobresaliente")
                End If

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
                'ejercicio 7
                Dim temp As Double

                Console.WriteLine("Introduzca la temperatura")
                temp = Convert.ToDouble(Console.ReadLine)

                If temp < 0 Then
                    Console.WriteLine("SOLIDO")
                ElseIf temp >= 0 And temp <= 100 Then
                    Console.WriteLine("Líquido")
                ElseIf temp > 100 And temp <= 1000000 Then
                    Console.WriteLine("Vapor")
                ElseIf temp > 1000000 Then
                    Console.WriteLine("Plasma")
                End If

            ElseIf numero = 8 Then
                Dim opcion As Char
                Dim num1, num2 As Integer
                Dim suma As Integer
                Console.WriteLine("Eliga una opcion:")
                Console.WriteLine("Opcion a: Sumar")
                Console.WriteLine("Opción b: Restar")
                Console.WriteLine("Opcion c: Multiplicar")
                Console.WriteLine("Opción d: Dividir")
                Console.WriteLine("Opción e: Raíz de la suma")
                opcion = CChar(Console.ReadLine)

                Console.WriteLine("Introduzca el primer número")
                num1 = Convert.ToInt32(Console.ReadLine)
                Console.WriteLine("Introduzca el segundo número")
                num2 = Convert.ToInt32(Console.ReadLine)

                Select Case opcion
                    Case "a"c
                        suma = num1 + num2
                        Console.WriteLine("El resultado de la suma es " & suma)
                    Case "b"c
                        Dim resta As Integer
                        resta = num1 - num2
                        Console.WriteLine("El resultado de la resta es " & resta)
                    Case "c"c
                        Dim multiplicación As Integer
                        multiplicación = num1 * num2
                        Console.WriteLine("El resultado de la multiplicación es " & multiplicación)
                    Case "d"c
                        Dim division As Double
                        division = num1 / num2
                        Console.WriteLine("El resultado de la división es " & division)
                    Case "e"c
                        Dim raiz As Double
                        raiz = Math.Sqrt(num1 + num2)
                        Console.WriteLine("El resultado de la raiz de la suma es " & raiz)
                End Select

            ElseIf numero = 9 Then

            End If


        Loop While numero <> 1


    End Sub

End Module
