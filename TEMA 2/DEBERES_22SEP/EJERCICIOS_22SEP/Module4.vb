Module Module4
    Sub Main()
        'EJERCICIO 11 BOLÉTIN 2
        Dim espacio As Double
        Dim tiempo As Double
        Dim velocidad As Double

        espacio = Convert.ToDouble(InputBox("Introduzca el espacio en metros"))
        tiempo = Convert.ToDouble(InputBox("Introduzca el tiempo en segundos"))
        velocidad = espacio / tiempo

        Console.WriteLine("La velocidad es de " & velocidad & " metros/segundos")
        Console.ReadLine()
    End Sub
End Module
