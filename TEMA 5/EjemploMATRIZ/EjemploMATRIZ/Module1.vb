Module Module1

    Sub Main()
        'EJEMPLO MATRIZ
        'Declarar la matriz

        Dim nombres(4) As String

        'Llenar la matríz
        nombres(0) = "Pablo"
        nombres(1) = "Hugo"
        nombres(2) = "Anxo"
        nombres(3) = "Manu"
        nombres(4) = "Guille"

        'Mostrar por pantalla la matriz
        For i = 0 To 4
            Console.WriteLine(nombres(i))
        Next
        Console.ReadLine()

    End Sub

End Module
