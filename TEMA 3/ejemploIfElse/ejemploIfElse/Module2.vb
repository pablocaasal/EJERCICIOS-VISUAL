Module Module2
    Sub mAIN()
        'IF ELSEIF Y BUCLE
        'Elegir ejercicio que quieres ejecutar sin hacer diferentes modulos
        Dim ejercicio As Integer

        Do
            Console.WriteLine("Escogemel ejercicio del boletín 3 : 4 - 12")
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
                    Dim n1, n2, suma As Double
                    Console.WriteLine("INTRODUZCA EL PRIMER NÚMERO REAL")
                    n1 = Convert.ToDouble(Console.ReadLine)
                    Console.WriteLine("INTRODUZCA EL SEGUNDO NÚMERO REAL")
                    n2 = Convert.ToDouble(Console.ReadLine)
                    suma = n1 + n2
                    If suma > 0 Then
                        Console.WriteLine(Math.Sqrt(suma))
                    Else
                        Console.WriteLine("NO SE PUEDE REALIZAR LA RAÍZ")
                    End If
                Else

                End If
            End If

        Loop While ejercicio <> 1

        Console.ReadLine()
    End Sub
End Module
