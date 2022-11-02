Module Module9
    Sub Main()
        'ejercicio 9
        Dim raiz As Double
        Console.WriteLine("n     raiz")
        For I = 16 To 1 Step -2.5
            raiz = Math.Sqrt(I)
            Console.WriteLine(I & "----" & raiz)
        Next
        Console.ReadLine()
    End Sub
End Module
