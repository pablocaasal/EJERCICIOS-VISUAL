Module Module3
    Sub Main()
        'ejercicio 3
        Dim mediaExamenes, mediaAsignaturas As Double
        Dim contador As Integer
        For a = 1 To 40
            Console.WriteLine("")
            If mediaAsignaturas < 5 Then
                contador += 1
            End If
            mediaAsignaturas = 0
            For b = 1 To 5
                mediaAsignaturas += mediaExamenes
                Console.WriteLine("La media del examen del alumno " & a & " es " & mediaExamenes)
                mediaExamenes = 0
                Dim ramdom4 As New Random
                Dim r4 As Integer
                r4 = ramdom4.Next(0, 10)
                mediaExamenes += r4
            Next
            mediaAsignaturas /= 5
        Next
        Console.WriteLine("")
        Console.WriteLine("El número de alumnos que no tienen derecho a el examen de nivelación es " & contador)
        Console.ReadLine()
    End Sub
End Module
