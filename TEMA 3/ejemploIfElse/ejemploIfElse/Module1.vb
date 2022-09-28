Module Module1

    Sub Main()
        'Programa que lee la altura y la edad de un niño e indica si debe llevar protección. Los niños están obligados a llevar rotección 
        'si miden menos de 1,35 metros o si TIENEN menos de 8 años
        Dim edad As Byte
        Dim ALTURA As Single
        Console.WriteLine("iNTRO EDAD: ")
        edad = Convert.ToByte(Console.ReadLine())
        Console.WriteLine("iNDICA LA ALURA ")
        ALTURA = Convert.ToSingle(Console.ReadLine())

        If edad < 8 Or ALTURA < 1.35 Then
            Console.WriteLine("Debe llevar silla de proteccion.")
        Else Console.WriteLine("No debe llevar silla de proteccion.")
        End If
        Console.ReadLine()


    End Sub

End Module
