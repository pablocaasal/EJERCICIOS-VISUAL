Module Module1

    Sub Main()
        'EJERCICIO 13 BOLETÍN 2
        Dim c1 As Double

        Dim c2 As Double

        Dim hipotenusa As Double

        c1 = Convert.ToDouble(InputBox("Introduzca el primer cateto"))
        c2 = Convert.ToDouble(InputBox("Introduzca el segundo cateto"))

        c1 = Convert.ToDouble(Math.Pow(c1, 2))
        c2 = Convert.ToDouble(Math.Pow(c2, 2))

        hipotenusa = Math.Sqrt(c1 + c2)

        Console.WriteLine("La hipotenusa es " & hipotenusa)
        Console.ReadLine()


    End Sub

End Module
