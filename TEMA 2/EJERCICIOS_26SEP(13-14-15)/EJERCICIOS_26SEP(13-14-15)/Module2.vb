Module Module2
    Sub Main()
        'EJERCICIO 14
        Dim precioInicial As Double
        Dim preciofinal As Double
        Dim rebaja As Double

        precioInicial = Convert.ToDouble(InputBox("Introduzca el precio inicial"))
        rebaja = Convert.ToDouble(InputBox("Introduzca el descuento "))

        preciofinal = precioInicial - (precioInicial * rebaja / 100)

        Console.WriteLine("El precio final es :" & preciofinal)
        Console.ReadLine()
    End Sub

End Module
