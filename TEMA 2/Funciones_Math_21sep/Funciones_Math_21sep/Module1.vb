Module Module1

    Sub Main()
        'Funciones Math
        'Sqrt(numero) --- raiz de ese numero
        Dim n As Integer = 10
        Dim raiz As Double = Math.Sqrt(n)
        Console.WriteLine("La raiz de: " & n & "es" & raiz)
        Console.ReadLine()

        'pow (base, potencia) --- base elvado a potencia
        Dim resultado As Integer = Convert.ToInt32(Math.Pow(5, 3))
        Dim raizCúbica As Double = Math.Pow(150, 1 / 3)
        Console.WriteLine()

        'Funciones de redondeo
        Dim valor As Double = 3.141516
        Dim enteromayor As Integer = Convert.ToInt32(Math.Ceiling(valor))
        Dim enteromenor As Integer = Convert.ToInt32(Math.Floor(valor))
        Dim enterocercano As Integer = Convert.ToInt32(Math.Round(valor))

        Console.WriteLine(valor & "REDONDEO HACIA ARRIBA = " & enteromayor)
        Console.WriteLine(valor & "REDONDEO HACIA ABAJO = " & enteromenor)
        Console.WriteLine(valor & "REDONDEO MÁS CERCANO = " & enterocercano)
        Console.ReadLine()

        'Redondear a un número de decimales
        Dim valorCon2Decimales As Double = Math.Round(valor, 2)
        Console.WriteLine(valor & "redondeo con 2 decimales " & valorCon2Decimales)
        Console.ReadLine()


    End Sub

End Module
