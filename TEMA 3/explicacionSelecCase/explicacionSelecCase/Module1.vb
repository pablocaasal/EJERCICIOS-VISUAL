Module Module1

    Sub Main()
        'SElect case --> evaluar valores discretos de una variable(puntuales , no de rango)
        'ejemplo menú
        Dim opcion As Char

        Do
            Console.WriteLine("Elija una opción")
            Console.WriteLine("a. calcular la raíz de un numero")
            Console.WriteLine("b. obtener el menor de tres números")
            Console.WriteLine("c. decir si un numero es multiplo de 7")
            Console.WriteLine("d. si quieres salir")
            opcion = CChar(Console.ReadLine)

            'evaluar la variable opcion
            Select Case opcion
                Case "a"c, "A"c
                    Console.WriteLine("opcion a:")


                Case "b"c
                    Console.WriteLine("opcion b:")
                Case "c"c
                    Console.WriteLine("opcion c")
                    Dim numero As Integer
                    Console.WriteLine("intro num")
                    numero = Convert.ToInt32(Console.ReadLine)
                    If numero Mod 7 = 0 Then
                        Console.WriteLine("multiplo de 7")
                    End If
                Case "d"c
                    Console.WriteLine("Adios. Pulse enter para confirmar")
                Case Else
                    Console.WriteLine("error en la opción")


            End Select

            Console.ReadLine()
        Loop Until opcion = "d"c
    End Sub

End Module
