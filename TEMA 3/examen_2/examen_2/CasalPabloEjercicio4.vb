Module CasalPabloEjercicio4
    Sub Main()
        Dim opcion As Integer
        Console.WriteLine("Introduce una opción")
        opcion = Convert.ToInt32(Console.ReadLine)

        Select Case opcion
            Case 1, 2
                Console.WriteLine("Introdujiste un 1 o un 2")
            Case 3
                Console.WriteLine("Introdujiste un 3")
            Case 4
                Console.WriteLine("Introdujiste un 4")
            Case Else
                Console.WriteLine("Error en el número introducido")
        End Select
        Console.ReadLine()
    End Sub
End Module
