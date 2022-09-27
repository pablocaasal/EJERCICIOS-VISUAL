Module Module1

    Sub Main()
        Dim c1 As Single
        Dim c1al2 As Single
        Dim c2 As Single
        Dim c2al2 As Single
        Dim hipotenusa As Single

        c1 = Convert.ToSingle(InputBox("Introduzca el primer cateto"))
        c2 = Convert.ToSingle(InputBox("Introduzca el segundo cateto"))

        c1al2 = Convert.ToSingle(Math.Pow(c1, 2))
        c2al2 = Convert.ToSingle(Math.Pow(c2, 2))
        hipotenusa = Convert.ToSingle(Math.Pow(c1al2 + c1al2, 2))

        Console.WriteLine("La hipotenusa es " & hipotenusa)
        Console.ReadLine()


    End Sub

End Module
