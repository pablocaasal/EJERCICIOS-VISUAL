Module CasalPabloEjercicio5
    Sub Main()
        Const impuestoReval As Double = 3.4
        Dim precioFinal, precioinicial As Double
        Dim cI, antiguedad, precioCatrastral As Double

        antiguedad = Convert.ToDouble(InputBox("Introduzca la antiguedad"))
        precioCatrastral = Convert.ToDouble(InputBox("Introduzca el precio catastral"))
        precioinicial = Convert.ToDouble(InputBox("Introduzca el precio inicial"))
        cI = precioinicial * (3 / 100)
        precioFinal = precioinicial + cI + (impuestoReval * antiguedad / 100) * precioCatrastral

        Console.WriteLine("El precio final de la venta es " & precioFinal)
        Console.ReadLine()

    End Sub
End Module
