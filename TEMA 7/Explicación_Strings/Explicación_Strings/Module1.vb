Option Strict On
Module Module1
    Sub Main()

        Dim frase As String = "Hola buenas tardes"
        Dim letra As Char = frase(0)
        Dim contador As Integer = 0

        Console.WriteLine("La primera letra es " & letra)
        Console.WriteLine("Codigo ASCII de la letra " & letra & " : " & Convert.ToInt32(letra))

        'Recorrer un String (array de caracteres)

        For i = 0 To frase.Length - 1
            If frase(i) = "a"c Then
                contador += 1
            End If
        Next

        Console.WriteLine("Hay " & contador & " a")

        'Funciones de la variable char
        'Char.isDigit(), Char.isLetter()

        Dim c1 As Boolean = Char.IsDigit(letra)
        Dim c2 As Boolean = Char.IsLetter(letra)
        Dim c3 As Boolean = Char.IsLower(letra)
        Dim c4 As Boolean = Char.IsUpper(letra)
        Dim letraMiniscula As Char = Char.ToLower(letra)

        'Funciones de la variable String
        '.lenght --> Devuelve el número total de caracteres
        Dim numeorCaracteres As Integer = frase.Length

        'cadena.startsWhit() y cadena.endsWith() Devuelve true si el string empieza o termina con los caracteres q pongas
        Dim c5 As Boolean = frase.StartsWith("Ho")
        Console.WriteLine(c5)

        '.contains.(cadena) --> Busca los caracteres indicados en la cadena y deuvuelve true si aparece

        ' .indexOf(cadena) --> Devuele la primera posición de los caracteres especificados dentro de la cadena

        Dim posicion As Integer = frase.IndexOf("ta")
        Console.WriteLine(posicion)

        ' lastindexOf(cadena) --> Devuelve la última posición de los caracteres espcificados dentro la cadena

        ' indexOfAny(char1, char2) --> Busca la primera POSICION de cualquiera de los caracteres que se le pasa como array (devuele número negativo si no encuentra)

        Dim caracteress() As Char = {"c"c, "f"c, "g"c}
        Dim posicion2 As Integer = frase.IndexOfAny(caracteress)
        Console.WriteLine(posicion2)

        ' substring(indice) --> Devuelve el string formado por los caracteres que hay a partir del indice (sin contarlo)

        Dim frase2 As String = "Hola que tal"
        Dim frase3 As String = frase2.Substring(5)
        Console.WriteLine(frase3)

        'desde el primer número indicado muestra los siguientes x caracteres indicados (segundo número) 

        Dim subfrase As String = frase2.Substring(0, 5)
        Console.WriteLine(subfrase)

        'split(string) -->Trocea el string original utilizando como separador el string pasado como argumento. Devuelve una matriz con los substrings generados.

        Dim palabras() As String = frase.Split(" "c)

        ' cuantas palabras a¡hay en un steing?

        Dim frase4 As String = "Ey buenas a todos"

        Dim numeroPalabras() As String = frase4.Split(" "c, "."c)
        Dim palabras1 As Integer = frase4.Split(" "c).Length

        For i = 0 To numeroPalabras.Length - 1
            Console.Write(numeroPalabras(i) & " / ")
        Next

        Console.WriteLine("Numero de palabras : " & palabras1)

        Console.ReadLine()
    End Sub

End Module
