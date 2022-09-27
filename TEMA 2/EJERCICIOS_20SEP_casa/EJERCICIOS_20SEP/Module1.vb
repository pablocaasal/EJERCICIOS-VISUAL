Module Module1

    Sub Main()
        'EJERCICIO 7 BOLETÍN 2
        Dim celcius As Double
        Dim farenheit As Double

        celcius = Convert.ToDouble(InputBox("Introduzca la temperatura en grados celcius"))



        farenheit = (9 / 5) * celcius + 32

        Console.WriteLine(celcius & " grados centigrados = " & farenheit & " grados farenheit")
        Console.ReadLine()




    End Sub

End Module
