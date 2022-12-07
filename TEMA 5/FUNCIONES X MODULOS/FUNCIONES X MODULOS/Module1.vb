Module Module1

    Sub generararArray(ByRef matriz() As Integer, ByVal limiteNeg As Integer, ByVal limiteSup As Integer)
        'Función que llena un array con números aleatorios

        Dim ramdom As New Random

        For i = 0 To matriz.Length - 1
            matriz(i) = ramdom.Next(limiteNeg, limiteSup)
        Next

    End Sub
    Sub mostrarArray(ByRef matriz() As Integer)
        For Each valor As Integer In matriz
            Console.WriteLine(valor)
        Next
    End Sub

End Module
