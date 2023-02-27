Module Module1

    Sub Main()

        'Crear ArrayList con los diferentes elementos que quermeos introducir

        Dim nombrePresidentes(4) As String
        nombrePresidentes(0) = "Piqué"
        nombrePresidentes(1) = "Spurs"
        nombrePresidentes(2) = "Ibei"
        nombrePresidentes(3) = "Casillas"
        nombrePresidentes(4) = "Juans"

        Dim jugadores As ArrayList = New ArrayList()
        Dim arbitros As ArrayList = New ArrayList(4)
        Dim presidentes As ArrayList = New ArrayList(nombrePresidentes)

        'Agregamos un jugador

        jugadores.Add("Dinho")
        jugadores.Add("Orellana")
        jugadores.Add("Aspas")

        'Borrar un jugador segun su indice

        jugadores.RemoveAt(2)

        'Borrar un jugador segun su valor

        presidentes.Remove("Spurs")

        'Comprobar si un valor esta contenido

        Dim estaContenido As Boolean
        estaContenido = presidentes.Contains("Dinho")

        'Comprobar la cantidad de presidentes que hay

        Console.WriteLine("Tenemos " & presidentes.Count & " presidentes")

        'Saber el indice de un elemento

        Console.WriteLine("El indice de Ibai es " & presidentes.IndexOf("Ibei"))

        'Añadir un jugador es una psicion determinada / añadir a cristiano antes de dinho y a messi despues

        Dim posicion As Integer
        posicion = jugadores.IndexOf("Dinho")
        jugadores.Insert(posicion, "Cristiano")
        jugadores.Insert(posicion + 2, "Messi")

        jugadores.Insert(0, "Vini")

        'Obtener el ultimo jugador de la lista ( Item te da el valor del indice

        Dim ultimo As String
        ultimo = Convert.ToString(jugadores.Item(jugadores.Count - 1))

        Console.WriteLine("El ultimo jugador es " & ultimo)

        'Ordenar una lista

        jugadores.Sort()

        'Mostramos por pantalla

        Console.WriteLine("Jugadores del equipo : ")
        For Each player In jugadores
            Console.WriteLine(player)
        Next

        Console.WriteLine("Arbitros : ")
        For Each arbis In arbitros
            Console.WriteLine(arbis)
        Next

        Console.WriteLine("Presidentes : ")
        For Each presis In presidentes

            Console.WriteLine(presis)
        Next

        Console.ReadLine()

    End Sub

End Module
