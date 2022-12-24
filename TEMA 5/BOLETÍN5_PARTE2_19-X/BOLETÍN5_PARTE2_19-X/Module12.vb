Module Module12
    Sub Main()
        'ejericicio 29 redimensionar un array / aumentar su tamaño si se queda sin espacio

        Dim m_Original() As Integer = {4, 6, 4, 8, 2}

        For Each numero In m_Original
            Console.WriteLine(numero)
        Next

        ReDim m_Original(9)  'Aumentamos capacidad matriz pero perdemos los datos
        ReDim Preserve m_Original(9) 'Mantenemos los datos originales

        'Solo se puede poner uno de los dos de arriba


        Console.WriteLine("La array tiene ahora " & m_Original.Length & " posiciones")

        For i As Integer = 0 To m_Original.Length - 1 Step 1
            Console.WriteLine(m_Original(i))
        Next

        Console.ReadLine()
    End Sub
End Module
