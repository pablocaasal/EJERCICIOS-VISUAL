Module Module5
    Sub Main()
        'ejercicio 23 index of

        Dim array(4) As Integer

        For I = 0 To array.Length - 1
            Console.WriteLine("Introduce el valor de la posición " & I)
            array(I) = Convert.ToInt32(Console.ReadLine)
        Next

        Dim posicion As Integer = array.IndexOf(array, 5)

        If posicion < 0 Then
            Console.WriteLine("No se ha encontrado el valor en el array")
        Else
            Console.WriteLine("El valor está en la posición " & posicion)
        End If

        Console.ReadLine()
    End Sub
End Module
