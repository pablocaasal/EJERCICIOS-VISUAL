Module Module2
    Sub Main()
        'EJERCICIO 5 BOLETÍN 2
        Dim precio As Double
        Dim cantidad As Short
        Dim precioFinal As Double

        precio = Convert.ToDouble(InputBox("Diga el precio del producto:"))

        cantidad = Convert.ToInt16(InputBox("Diga la cantidad del producto"))

        precioFinal = precio * cantidad
        Console.WriteLine("El precio del producto es " & precio & " euros y la cantidad que compra es " & cantidad & ",por lo tanto debe pagar " & precioFinal & " euros. Vuelva pronto!")
        Console.ReadLine()

    End Sub
End Module
