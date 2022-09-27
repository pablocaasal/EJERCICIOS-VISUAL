Module Module1

    Sub Main()
        'EJERCICIO 4 BOLETIN 2
        Dim radio As Double
        Dim area As Double
        Dim longitud As Double
        Dim volumen As Double
        Const pi As Double = 3.141516

        radio = Convert.ToDouble(InputBox("Introduzca el radio: "))
        'Longitud
        longitud = 2 * pi * radio
        'area
        area = pi * (radio * radio)
        'volumen
        volumen = (3 / 4) * pi * ((radio * radio) * radio)

        Console.WriteLine("La longitud es : " & longitud)
        Console.WriteLine("El area es : " & area)
        Console.WriteLine("El volumen es: " & volumen)
        Console.ReadLine()



    End Sub

End Module
