Module Module4
    Sub Main()
        'Ejercicio 6
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
        Console.ReadLine()


    End Sub
End Module
