Module Module4
    Sub Main()
        'Crea 3 matrices y guarda la info de los alumnos
        'Queremos guardar la siguiente información : Nombre, edad , Videojuego favorito
        'Elige el tipo de dato que necesites

        'Primera forma de crear y rellenar las arrays
        Dim nombres() As String = {"Anxo", "Sergio", "Martín", "Hugo", "Boris", "Pablo"}
        Dim edades() As Integer = {16, 17, 17, 16, 18, 18}
        Dim juegoFav() As String = {"Rust", "Zelda : Ocarina of Time", "ARK", "Stray", "Dragon Ball", "RDR 2"}

        'Otra forma de crar y rellenar las arrays
        Dim deporteFav(nombres.Length - 1) As String
        deporteFav(0) = "Fútbol"
        deporteFav(1) = "Pádel"
        deporteFav(2) = "Boxeo"
        deporteFav(3) = "Danza"
        deporteFav(4) = "Golf"
        deporteFav(5) = "Furbo"

        For i = 0 To nombres.Length - 1
            Console.WriteLine(nombres(i) & ", " & edades(i) & ", " & juegoFav(i) & ", " & deporteFav(i))
        Next
        Console.ReadLine()
    End Sub
End Module
