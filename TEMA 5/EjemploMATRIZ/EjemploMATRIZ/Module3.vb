Module Module3
    Sub Main()
        Dim nombresProfes() As String = {"Ramon", "Alberto", "Enrique", "Andrés", "Igor"}

        For i = 0 To nombresProfes.Length - 1
            Console.WriteLine("Nombres : " & nombresProfes(i))
        Next
        Console.ReadLine()
    End Sub
End Module
