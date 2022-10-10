Module Module2
    Sub mAIN()
        'IF ELSEIF Y BUCLE
        'Elegir ejercicio que quieres ejecutar sin hacer diferentes modulos
        Dim ejercicio As Integer

        Do
            Console.WriteLine("--------------------------------------------------------------")
            Console.WriteLine("Elige un ejercicio del boletín 3 : 4 - 12")
            Console.WriteLine("Pulsa 1 si quieres salir del programa")
            ejercicio = Convert.ToInt32(Console.ReadLine)
            If ejercicio <> 1 Then

                If ejercicio = 4 Then
                    'Resolver ejercicio 4 
                ElseIf ejercicio = 5 Then
                    Dim numero As Double
                    Console.WriteLine("iNTRODUZCA UN NÚMERO")
                    numero = Convert.ToDouble(Console.ReadLine)

                    If numero Mod 2 = 0 Then
                        Console.WriteLine("EL NÚMERO ES PAR")
                    Else
                        Console.WriteLine("El NÚMERO ES IMPAR")
                    End If
                ElseIf ejercicio = 6 Then
                    Dim n1, n2, n3, media As Double
                    Console.WriteLine("Introduzca el primer número")
                    n1 = Convert.ToDouble(Console.ReadLine)
                    Console.WriteLine("Introduzca el segundo número")
                    n2 = Convert.ToDouble(Console.ReadLine)
                    Console.WriteLine("Introduzca el tercer número")
                    n3 = Convert.ToDouble(Console.ReadLine)
                    media = (n1 + n2 + n3) / 3

                    If media >= 5 Then
                        Console.WriteLine("EL ALUMNO ESTÁ APROBADO")
                    Else
                        Console.WriteLine("EL ALUMNO ESTÁ SUSPENSO")
                    End If
                ElseIf ejercicio = 7 Then
                    Dim n1, n2, suma, raiz As Double

                    Try
                        Console.WriteLine("INTRODUZCA EL PRIMER NÚMERO REAL")
                        n1 = Convert.ToDouble(Console.ReadLine)
                        Console.WriteLine("INTRODUZCA EL SEGUNDO NÚMERO REAL")
                        n2 = Convert.ToDouble(Console.ReadLine)
                    Catch ex As Exception
                    End Try
                    suma = n1 + n2
                    If suma > 0 Then
                        raiz = Math.Sqrt(suma)
                        Console.WriteLine("La raíz cuadrada de la suma es :" & raiz)
                    Else
                        Console.WriteLine("NO SE PUEDE REALIZAR LA RAÍZ")
                    End If
                ElseIf ejercicio = 8 Then
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
                ElseIf ejercicio = 9 Then
                    Dim number1, number2 As Integer
                    Dim elevado As Integer

                    Console.WriteLine("Introduca el primer número")
                    number1 = Convert.ToInt32(Console.ReadLine)
                    Console.WriteLine("Introduca el segundo número")
                    number2 = Convert.ToInt32(Console.ReadLine)

                    If number1 > number2 Then
                        elevado = number1 ^ number2
                    Else
                        elevado = number2 ^ number1
                    End If
                    Console.WriteLine("El valor del número más grande elevado al más pequeño es : " & elevado)
                ElseIf ejercicio = 10 Then
                    Dim presión, temperatura As Double
                    Dim condición As Boolean

                    Console.WriteLine("Introduzca la presión ")
                    presión = Convert.ToDouble(Console.ReadLine)

                    If presión > 2 Then
                        Console.WriteLine("Abrir válvula de seguridad")
                    End If

                    Console.WriteLine("Introduzca la temperatura ")
                    temperatura = Convert.ToDouble(Console.ReadLine)

                    If temperatura > 500 Then
                        Console.WriteLine("Reducir la temperatura")
                    End If

                    condición = presión > 2 And temperatura > 500

                    If condición = True Then
                        Console.WriteLine("Abrir válvula de seguridad y reducir la temperatura")
                    Else
                        Console.WriteLine("Todo está en orden")
                    End If
                ElseIf ejercicio = 11 Then
                    Dim número As Double
                    Dim condición As Boolean

                    Console.WriteLine("Introduzca el número")
                    número = Convert.ToInt32(Console.ReadLine)
                    condición = Convert.ToBoolean(número Mod 2 And número Mod 3)
                    If condición = False Then
                        Console.WriteLine("El número es múltiplo de 2 o 3")
                    End If
                ElseIf ejercicio = 12 Then
                    Dim precio, descuento1, descuento2, preciofinalMenor, precioFinalMayor As Double
                    Console.WriteLine("Introduzca el precio del producto")
                    precio = Convert.ToDouble(Console.ReadLine)
                    descuento1 = precio * (10 / 100)
                    descuento2 = precio * (15 / 100)

                    If precio < 100 Then
                        preciofinalMenor = (precio - descuento1)
                    End If
                    If precio > 100 Then
                        precioFinalMayor = (precio - descuento2)
                    End If

                    If precio < 100 Then
                        Console.WriteLine("El precio final es: " & preciofinalMenor)
                    End If
                    If precio > 100 Then
                        Console.WriteLine("El precio final es " & precioFinalMayor)
                    End If

                Else

                End If
            End If

        Loop While ejercicio <> 1

        Console.ReadLine()

        Console.ReadLine()
    End Sub
End Module
