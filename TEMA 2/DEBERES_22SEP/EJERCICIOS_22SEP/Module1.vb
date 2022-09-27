Module Module1

    Sub Main()
        'EJERCICIO 8 BOLETÍN 2
        Dim presión As Double
        Dim volumen As Double
        Dim moles As Double
        Const r As Double = 0.082
        Dim temperatura As Double


        temperatura = Convert.ToDouble(InputBox("Introduza el volumen"))
        moles = Convert.ToDouble(InputBox("Introduzca el número de moles"))
        volumen = Convert.ToDouble(InputBox("Introduzca el volumen"))

        presión = (moles * r * temperatura) / volumen

        Console.WriteLine("Con un volumen de " & volumen & " litros, y una temperatura de " & temperatura & " kelvin, " & moles & " moles de un gas ideal tienen una presión de " & presión & " atmósferas")
        Console.ReadLine()

    End Sub

End Module
