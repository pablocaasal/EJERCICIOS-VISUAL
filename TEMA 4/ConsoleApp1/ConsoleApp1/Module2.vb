Module Module2
    Sub Main()
        'ejercicio 2
        Dim mediaExamenes, mediaAsignaturas, mediaClases, media3Clases As Double
        For i = 1 To 4
            media3Clases += mediaClases
            Console.WriteLine("La media de la clase" & i & " es " & mediaClases)
            mediaClases = 0
            For a = 1 To 30
                Console.WriteLine("La media de las asignaturas del alumno " & a & " es " & mediaAsignaturas)
                Console.WriteLine("")
                mediaClases += mediaAsignaturas
                mediaAsignaturas = 0
                For b = 1 To 10
                    mediaAsignaturas += mediaExamenes
                    mediaExamenes = 0
                    For c = 1 To 3
                        Dim ramdom4 As New Random
                        Dim r4 As Integer
                        r4 = ramdom4.Next(0, 10)
                        mediaExamenes += r4
                    Next
                    mediaExamenes /= 3
                Next
                mediaAsignaturas /= 10
            Next
            mediaClases /= 30
        Next
        Console.WriteLine("La media de las tres clases es " & media3Clases / 3)
        Console.ReadLine()
    End Sub
End Module
