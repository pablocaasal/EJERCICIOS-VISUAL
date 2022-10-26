Module Module4
    Sub Main()
        'ejercicio 4
        'apartado a
        Dim x As Integer = 0
        Dim i As Integer = 1
        While i < 20
            If i Mod 5 = 0 Then
                x += i
            End If
            i = i + 1
        End While
        Console.WriteLine(x)
        Console.ReadLine()
        'Faltaba el i=i+1 (fuera del if)

        'apartado b
        Dim x2 As Boolean = True
        While x2
            Console.WriteLine("!")
            x2 = False
        End While
        Console.ReadLine()
        'FALTA PONER x2=False dentro del bucle, sino seria un bucle infinito.

        'apartado c
        Dim x3 As Integer = 100
        Dim i2 As Integer = 0
        Dim s As Integer = 0
        While i2 < x3
            s += 1
            i2 *= 2
            Console.WriteLine(s)
        End While
        Console.WriteLine(s)
        Console.ReadLine()
        'El console Writeline tiene que estar dentro del bucle para que pinte s

    End Sub
End Module
