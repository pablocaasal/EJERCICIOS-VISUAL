Module Module4
    Sub Main()
        Dim celsius As Double
        Dim farenheit As Double

        celsius = Convert.ToDouble(InputBox("Introduzca la temperatura en grados celcius"))
        farenheit = (9 / 5) * celsius + 32

        Console.WriteLine(celsius & " grados centigrados = " & farenheit & " grados farenheit")
        Console.ReadLine()
    End Sub
End Module
