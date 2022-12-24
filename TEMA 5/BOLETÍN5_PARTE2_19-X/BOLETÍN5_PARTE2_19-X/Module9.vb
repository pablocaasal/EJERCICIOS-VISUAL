Module Module9
    Sub Main()
        'ejericicio 27 

        Dim array(4) As Integer
        Dim array2(4) As Integer
        Dim distintos As Boolean

        For I = 0 To array.Length - 1
            Console.WriteLine("Introduce el valor de la posición " & I & " de la array 1")
            array(I) = Convert.ToInt32(Console.ReadLine)

            Console.WriteLine("Introduce el valor de la posición " & I & " de la array 2")
            array2(I) = Convert.ToInt32(Console.ReadLine)
        Next

        distintos = array.Equals(array, array2)

        If distintos = False Then
            Console.WriteLine("Las arrays tienen las mismas posiciones")
        Else
            Console.WriteLine("Las arrays no tienen las mismas posiciones")
        End If

        Console.ReadLine()
    End Sub
End Module
