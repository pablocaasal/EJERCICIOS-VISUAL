Module Module5
    Sub Main()
        'Introducimos info para jugadores del Mundial
        '-Cantidad de jugadores (Tamaño de las arrays)
        '-Para cada jugador(Dentro del bucle)
        '-Nombres, nacionalidad, goles, asistencias

        Dim cantidadJugadores As Integer

        Console.WriteLine("Introduce la cantidad de jugadores")
        cantidadJugadores = Convert.ToInt32(Console.ReadLine)

        Dim nombres(cantidadJugadores - 1) As String
        Dim nacionalidad(cantidadJugadores - 1) As String
        Dim goles(cantidadJugadores - 1) As Integer
        Dim asistencias(cantidadJugadores - 1) As Integer


        For i = 0 To cantidadJugadores - 1
            Console.WriteLine("Introduce el nombre del jugador")
            nombres(i) = Console.ReadLine
            Console.WriteLine("Introduce la nacionalidad del jugador")
            nacionalidad(i) = Console.ReadLine
            Console.WriteLine("Introduce los goles del jugador")
            goles(i) = Convert.ToInt32(Console.ReadLine)
            Console.WriteLine("Introduce las asistencias del jugador")
            asistencias(i) = Convert.ToInt32(Console.ReadLine)

            Console.WriteLine(nombres(i) & ", " & nacionalidad(i) & ", " & goles(i) & ", " & asistencias(i))
            Console.WriteLine("----------------------------------------------------")
        Next
        Console.ReadLine()

    End Sub
End Module
