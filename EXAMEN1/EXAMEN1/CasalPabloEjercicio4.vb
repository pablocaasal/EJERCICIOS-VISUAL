Module CasalPabloEjercicio4

    Sub Main()
        Dim a, b As Integer
        Dim x, y, z As Double

        a = Convert.ToInt32(InputBox("Introduzca el primer valor"))
        b = Convert.ToInt32(InputBox("Introduzca el segundo valor"))

        x = Math.Pow(a, 4) / Math.Pow(a, 3)
        y = Math.Sqrt(a + Math.Pow(b, 2))
        y = Math.Round(y, 1)
        z = Math.Sqrt(30 - a)
        z = Math.Round(z, 2)
        Dim menor As Double = Math.Min(x, y)
        menor = Math.Min(menor, z)

        Console.WriteLine("X= " & x)
        Console.WriteLine("Y= " & y)
        Console.WriteLine("Z= " & z)
        Console.WriteLine("El número más pequeño entre x,y z es " & menor)
        Console.ReadLine()

    End Sub

End Module
