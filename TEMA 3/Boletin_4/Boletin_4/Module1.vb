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
                'ejercicio 6
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
                'ejercicio 8
                Dim opcion As Char
                Dim num1, num2 As Integer
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
                        Dim suma As Double
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
                Dim litros As Integer
                Dim pago As Double

                Console.WriteLine("Introduzca los litros gastados en un mes")
                litros = Convert.ToInt32(Console.ReadLine)

                If litros >= 50 And litros <= 200 Then
                    pago = (litros - 50) * 10
                ElseIf litros > 200 Then
                    pago = (litros - 200) * 20 + 150 * 10
                ElseIf pago < 150 Then
                    pago = 150
                End If

                Console.WriteLine("El pago final es : " & pago & " euros")

            ElseIf numero = 10 Then
                Dim art1, art2, art3, suma As Double

                Console.WriteLine("Introduzca el precio del primer artículo")
                art1 = Convert.ToDouble(Console.ReadLine)
                Console.WriteLine("Introduzca el precio del segundo artículo")
                art2 = Convert.ToDouble(Console.ReadLine)
                Console.WriteLine("Introduzca el precio del tercer artículo")
                art3 = Convert.ToDouble(Console.ReadLine)
                suma = art1 + art2 + art3

                If suma < 500000 Then
                    suma = suma
                ElseIf suma >= 500000 And suma < 1000000 Then
                    Dim descuento1 As Double = suma * 0.03
                    suma = suma - descuento1
                ElseIf suma >= 1000000 And suma < 2000000 Then
                    Dim descuento2 As Double = suma * 0.05
                    suma = suma - descuento2
                ElseIf suma >= 2000000 And suma <= 3000000 Then
                    Dim descuento3 As Double = suma * 0.07
                    suma = suma - descuento3
                ElseIf suma > 3000000 Then
                    Dim descuento4 As Double = suma * 0.1
                    suma = suma - descuento4
                End If

                Console.WriteLine("El precio de los tres artículos, con descuento incluido, es : " & suma)
            ElseIf numero = 14 Then
                Dim numero14 As Integer
                Console.WriteLine("Introduzca un número positivo")
                numero14 = Convert.ToInt32(Console.ReadLine)
                If numero14 > 0 And numero14 < 10 Then
                    Console.WriteLine("El número tiene 1 cifra")
                ElseIf numero14 < 100 Then
                    Console.WriteLine("El número tiene 2 cifras")
                ElseIf numero14 < 1000 Then
                    Console.WriteLine("El número tiene 3 cifras")
                ElseIf numero14 < 10000 Then
                    Console.WriteLine("El número tiene 4 cifras")
                ElseIf numero14 < 100000 Then
                    Console.WriteLine("El número tiene 5 cifras")
                ElseIf numero14 < 1000000 Then
                    Console.WriteLine("El número tiene 6 cifras")
                ElseIf numero14 >= 1000000 Then
                    Console.WriteLine("El número tiene más de 6 cifras")
                End If
            ElseIf numero = 15 Then
                Dim a, b, c, x1, x2 As Double
                Console.WriteLine("Introduce el primer coeficiente (a)")
                a = Convert.ToDouble(Console.ReadLine)
                Console.WriteLine("Introduce el segundo coeficiente (b)")
                b = Convert.ToDouble(Console.ReadLine)
                Console.WriteLine("Introduce el tercer coeficiente (c)")
                c = Convert.ToDouble(Console.ReadLine)
                If a = 0 Then
                    x1 = -(c / b)
                    Console.WriteLine("x= " & x1)
                End If
                If b = 0 Then
                    x1 = Math.Sqrt(-c / a)
                    Console.WriteLine("x1 = +" & x1)
                    x2 = Math.Sqrt(-c / a)
                    Console.WriteLine("x2 = -" & x2)

                End If
            End If


        Loop While numero <> 1


    End Sub

End Module
