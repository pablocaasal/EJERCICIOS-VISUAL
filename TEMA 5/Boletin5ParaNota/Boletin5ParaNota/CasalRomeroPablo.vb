Module CasalRomeroPablo

    Sub Main()
        Dim continuar As Char

        Do

            Dim ejercicio As Integer

            Console.WriteLine("Introduce que ejercicio quieres ejecutar")
            ejercicio = Convert.ToInt32(Console.ReadLine)
            Console.WriteLine(" ")

            Select Case ejercicio
                Case 1
                    'Crear un array con capacidad para n valores. Llenarlo con valores aleatorios entre 0 y 10

                    Dim capacidad As Integer = 0
                    Dim contador As Integer = 0
                    Dim ramdom As New Random
                    Dim media As Double = 0
                    Dim porcentaje As Double = 0

                    Console.WriteLine("Introduce la capacidad de la array")
                    capacidad = Convert.ToInt32(Console.ReadLine)
                    Console.WriteLine(" ")

                    Dim array(capacidad - 1) As Integer

                    For i = 0 To array.Length - 1
                        array(i) = ramdom.Next(0, 11)

                        Console.WriteLine("El valor de la posición " & i & " es " & array(i))

                        media += array(i)
                    Next

                    media = media / capacidad
                    Console.WriteLine(" ")
                    Console.WriteLine("La media de la array es " & media)

                    For n = 0 To array.Length - 1
                        If array(n) >= media Then
                            contador += 1
                        End If
                    Next

                    porcentaje = (contador / capacidad) * 100
                    Console.WriteLine("")
                    Console.WriteLine("Hay " & contador & " valores por encima de la media")
                    Console.WriteLine("El " & porcentaje & "% de los valores están por encima de la media")

                    Console.WriteLine("")

                    If media < 5 Then
                        Console.WriteLine("Suspenso")
                    ElseIf media >= 5 And media < 7 Then
                        Console.WriteLine("Aprobado")
                    ElseIf media >= 7 And media < 9 Then
                        Console.WriteLine("Notable")
                    ElseIf media >= 9 And media <= 10 Then
                        Console.WriteLine("Sobresaliente")
                    Else
                        Console.WriteLine("Error System32")
                    End If

                Case 2
                    'Diseñar un programa que calcule y muestre la desviación con respecto a la media de cada elemento de un array de enteros de tamaño n.
                    'Ayuda: Para calcular la desviación de un elemento : Abs(valor elemento - media).
                    'Ahora modificarlo para que calcule la desviación media de un array. Es decir la media de todas las desviaciones.

                    Dim capacidad As Integer = 0
                    Dim media As Double = 0
                    Dim mediaDesviación As Double = 0
                    Dim ramdom As New Random

                    Console.WriteLine("Introduce la capacidad de la array")
                    capacidad = Convert.ToInt32(Console.ReadLine)
                    Console.WriteLine(" ")

                    Dim array(capacidad - 1) As Integer
                    Dim desviación(capacidad - 1) As Double

                    For I = 0 To array.Length - 1
                        array(I) = ramdom.Next(0, 11)

                        Console.WriteLine("El valor de la posición " & I & " es " & array(I))

                        media += array(I)
                    Next

                    media = media / capacidad
                    Console.WriteLine("")
                    Console.WriteLine("La media es " & media)
                    Console.WriteLine("")

                    For n = 0 To array.Length - 1
                        desviación(n) = array(n) - media

                        If desviación(n) < 0 Then
                            desviación(n) *= -1
                        End If

                        mediaDesviación += desviación(n)

                        Console.WriteLine("La desviación de la posición " & n & " es " & desviación(n))
                    Next

                    mediaDesviación = mediaDesviación / capacidad
                    Console.WriteLine(" ")
                    Console.WriteLine("La media de las desviaciones es " & mediaDesviación)

                Case 3
                    'Declarar dos arrays de 5 elementos, pedir los datos del primero por teclado al usuario.
                    'A continuación darle valores al segundo array de manera que cada posición almacenará el mismo valor que la misma posición del primer array más 10.

                    Dim array1(4) As Integer
                    Dim array2(4) As Integer

                    For i = 0 To array1.Length - 1
                        Console.WriteLine("Introduce el valor de la posición " & i)
                        array1(i) = Convert.ToInt32(Console.ReadLine)
                    Next

                    Console.WriteLine(" ")

                    For n = 0 To array1.Length - 1
                        array2(n) = array1(n)
                        array2(n) += 10
                    Next

                    For c = 0 To array1.Length - 1
                        Console.WriteLine("El valor de la posición " & c & " de la array 1 es " & array1(c))
                    Next

                    Console.WriteLine(" ")

                    For x = 0 To array2.Length - 1
                        Console.WriteLine("El valor de la posición " & x & " de la array 2 es " & array2(x))
                    Next

                Case 4
                    'Escribir un programa que calcule el módulo de un array de n valores.
                    'El módulo es la raíz cuadrada de la suma de los cuadrados de los elementos de un array.

                    Dim posiciones As Integer = 0
                    Dim sumaCuadrados As Double = 0
                    Dim modulo As Double = 0

                    Console.WriteLine("Introduce el número de posiciones del array")
                    posiciones = Convert.ToInt32(Console.ReadLine)
                    Console.WriteLine("")

                    Dim array(posiciones - 1) As Integer

                    For i = 0 To array.Length - 1
                        Console.WriteLine("Introduce el valor de la posición " & i)
                        array(i) = Convert.ToInt32(Console.ReadLine)

                        sumaCuadrados += Math.Pow(array(i), 2)
                    Next

                    modulo = Math.Sqrt(sumaCuadrados)
                    Console.WriteLine(" ")

                    For c = 0 To array.Length - 1
                        Console.WriteLine("El valor de la posción " & c & " es " & array(c))
                    Next

                    Console.WriteLine(" ")
                    Console.WriteLine("La raíz cuadrada de la suma de los cuadrados de los valores de la array es " & modulo)

                Case 5
                    'Diseñar un programa que detecte la posición del primer número negativo en un array. Mostrará por pantalla el valor y el índice.

                    Dim array(4) As Integer

                    For I = 0 To array.Length - 1
                        Console.WriteLine("Introduce el valor de la posición " & I)
                        array(I) = Convert.ToInt32(Console.ReadLine)
                    Next

                    Console.WriteLine(" ")

                    For z = 0 To array.Length - 1
                        Console.WriteLine("El valor de la posición " & z & " es " & array(z))
                    Next

                    Console.WriteLine("")

                    For n = 0 To array.Length - 1
                        If array(n) < 0 Then
                            Console.WriteLine("El primer valor negativo es " & array(n) & " y está en la posición " & n)
                            Exit For
                        End If
                    Next

                Case 6
                    'Diseñar un programa que busque un número introducido por el usuario.
                    'Es decir si el usuario introduce un 3 el programa buscará si en el array hay alguna posición que almacene ese valor, en cuyo caso muestra por pantalla el índice.
                    'Si hay más de una aparición las muestra todas, si no hay ninguna informa de dicha circunstancia.

                    Dim array(4) As Integer
                    Dim contador As Integer = 0

                    For i = 0 To array.Length - 1
                        Console.WriteLine("Introduce el valor de la posición " & i)
                        array(i) = Convert.ToInt32(Console.ReadLine)
                    Next

                    Console.WriteLine(" ")

                    For v = 0 To array.Length - 1
                        Console.WriteLine("El valor de la posición " & v & " es " & array(v))
                    Next

                    Console.WriteLine("")


                    For n = 0 To array.Length - 1
                        If array(n) = 3 Then
                            Console.WriteLine("El valor buscado (3) está en la posición " & n)
                        Else
                            contador += 1
                        End If
                    Next

                    If contador = array.Length Then
                        Console.WriteLine("No se ha encontrado el valor buscado (3) en ninguna posición")
                    End If

                Case 7
                    'Declarar una matriz con capacidad para 100 Strings y presentar un menú al usuario con las siguientes opciones:

                    Dim array(99) As String
                    Dim opcion As Integer
                    Dim ramdom As New Random

                    Console.WriteLine("Introduce una opción para el ejercicio")
                    Console.WriteLine("1-Introducir nombres")
                    Console.WriteLine("2-Mostrar nombres")
                    Console.WriteLine("3-Contar nombres")
                    Console.WriteLine("4-Mostrar espacio")
                    Console.WriteLine("5-Buscar nombre")
                    Console.WriteLine("6-Eliminar nombre")
                    Console.WriteLine("7-Salir")
                    opcion = Convert.ToInt32(Console.ReadLine)
                    Console.WriteLine("")

                    array(0) = "a"
                    array(1) = "b"
                    array(3) = "c"
                    array(99) = "posición 99"

                    Select Case opcion
                        Case 1

                            For i = 0 To array.Length - 1
                                If array(i) = Nothing Then
                                    Console.WriteLine("Introduce tu nombre")
                                    array(i) = Console.ReadLine

                                    Console.WriteLine("")
                                    Console.WriteLine("El nombre se ha guardado en la posición " & i)
                                    Exit For
                                End If
                            Next

                        Case 2

                            For i = 0 To array.Length - 1
                                Console.WriteLine(array(i))
                            Next

                        Case 3
                            Dim contador As Integer = 0

                            For i = 0 To array.Length - 1
                                If array(i) <> Nothing Then
                                    contador += 1
                                End If
                            Next

                            Console.WriteLine("Hay " & contador & " nombres almacenados en el array")

                        Case 4
                            Dim contador As Integer = 0

                            For i = 0 To array.Length - 1
                                If array(i) = Nothing Then
                                    contador += 1
                                End If
                            Next

                            Console.WriteLine("Hay " & contador & " posiciones vacías en el array")

                        Case 5
                            Dim nombre As String
                            Dim contador As Integer = 0

                            Console.WriteLine("Introduce el nombre que desea buscar")
                            nombre = Console.ReadLine
                            Console.WriteLine("")

                            For i = 0 To array.Length - 1
                                If array(i) = nombre Then
                                    Console.WriteLine(nombre & " se encuentra en la posición " & i)
                                Else
                                    contador += 1
                                End If
                            Next

                            If contador = array.Length Then
                                Console.WriteLine("No se ha encontrado el nombre que desea buscar en niguna posición")
                            End If

                        Case 6
                            Dim nombre As String

                            Console.WriteLine("Introduce el nombre que desea eliminar")
                            nombre = Console.ReadLine

                            For i = 0 To array.Length - 1
                                If nombre = array(i) Then
                                    Console.WriteLine("")
                                    Console.WriteLine(nombre & " está en la posición " & i)

                                    array(i) = Nothing
                                    Console.WriteLine("")
                                    Console.WriteLine("La posición " & i & " ahora está vacía")
                                End If
                            Next

                        Case 7

                            Exit Select

                    End Select

                Case 8
                    'Crear un programa que permita generar n valores enteros entre dos límites que son introducidos por el usuario.
                    'A continuación , el programa muestra la siguiente información:

                    Dim valores, limiteInferior, limiteSuperior As Integer
                    Dim contador As Integer = 0
                    Dim contador2 As Integer = 0
                    Dim mitad As Double
                    Dim ramdom As New Random

                    Console.WriteLine("Introduce el número de valores que quieres generar")
                    valores = Convert.ToInt32(Console.ReadLine)
                    Console.WriteLine("")

                    Console.WriteLine("Introduce el limite inferior")
                    limiteInferior = Convert.ToInt32(Console.ReadLine)
                    Console.WriteLine("")

                    Console.WriteLine("Introduce el limite superior")
                    limiteSuperior = Convert.ToInt32(Console.ReadLine)
                    Console.WriteLine("")

                    Dim array(valores - 1) As Integer

                    For i = 0 To array.Length - 1
                        array(i) = ramdom.Next(limiteInferior, limiteSuperior + 1)

                        Console.WriteLine("El valor de la posición " & i & " es " & array(i))
                    Next

                    mitad = (limiteInferior / 2) + (limiteSuperior / 2)

                    For n = 0 To array.Length - 1
                        If array(n) > mitad Then
                            contador += 1
                        End If

                        If array(n) = limiteInferior Then
                            contador += 1
                        End If
                    Next

                    Console.WriteLine("")
                    Console.WriteLine("La mitad es " & mitad)
                    Console.WriteLine("Hay " & contador & " valores por encima de " & mitad)

                    Console.WriteLine("")
                    Console.WriteLine("Hay " & contador2 & " valores iguales al límite inferior")

                    For x = 0 To array.Length - 1
                        If array(x) > mitad Then
                            Console.WriteLine("")
                            Console.WriteLine("La posición del primer valor generado superior a la mitad del rango es " & x)
                            Exit For
                        End If
                    Next

                Case 9
                    'Diseñar un programa que permita calcular el valor más alto de una matriz.(sin ordenarlo)

                    Dim array(4) As Integer
                    Dim mayor As Integer

                    For i = 0 To array.Length - 1
                        Console.WriteLine("Introduce el valor de la posición " & i)
                        array(i) = Convert.ToInt32(Console.ReadLine)
                    Next

                    mayor = array(0)

                    For n = 0 To array.Length - 2

                        If mayor > array(n + 1) Then
                            mayor = mayor
                        Else
                            mayor = array(n + 1)
                        End If

                    Next

                    Console.WriteLine(" ")
                    Console.WriteLine("El mayor valor es de la array es " & mayor)

                Case 10

                    'Utilizando la librería Array.
                    'Declara dos matrices de tipo Integer e inicializa la primera a unos valores cualesquiera
                    'Realiza una copia de los valores de la primera en la segunda.
                    'Ordena la matriz original.
                    'Utilizando un For Each recorre ambas matrices para mostrar los valores almacenados
                    'Solicitar al usuario un valor, buscarlo en la matriz ordenada y mostrar la posición por pantalla.

                    Dim array1(4) As Integer
                    Dim array2(4) As Integer
                    Dim valor As Integer

                    For i = 0 To array1.Length - 1
                        Console.WriteLine("Introduce el valor de la posición " & i & " del array 1")
                        array1(i) = Convert.ToInt32(Console.ReadLine)
                    Next

                    Array.Copy(array1, array2, array1.Length)

                    Array.Sort(array1)

                    Console.WriteLine("Array 1")

                    For Each valor In array1
                        Console.WriteLine(valor)
                    Next

                    Console.WriteLine(" ")

                    Console.WriteLine("Array 2")

                    For Each valor In array2
                        Console.WriteLine(valor)
                    Next

                    Console.WriteLine(" ")

                    Console.WriteLine("Introduce un valor para buscarlo en el array ordenado")
                    valor = Convert.ToInt32(Console.ReadLine)

                    Dim posicion As Integer = Array.IndexOf(array1, valor)

                    If posicion >= 0 Then
                        Console.WriteLine("El valor especificado está en la posición " & posicion)
                    Else
                        Console.WriteLine("No se ha encontrado el valor especificado")
                    End If

                Case 11
                    'Diseñar un programa que cuente la cantidad de números primos que hay en un determinado array.

                    Dim array(4) As Integer
                    Dim contador1 As Integer = 0
                    Dim contador2 As Integer = 0

                    For i = 0 To array.Length - 1
                        Console.WriteLine("Introduce el valor de la posición " & i)
                        array(i) = Convert.ToInt32(Console.ReadLine)
                    Next

                    For n = 0 To array.Length - 1

                        contador1 = 0

                        For b = 1 To 100

                            If array(n) Mod b = 0 Then
                                contador1 += 1
                            End If

                        Next

                        If contador1 = 2 Then
                            contador2 += 1
                        End If

                    Next

                    Console.WriteLine("")
                    Console.WriteLine("Hay " & contador2 & " números primos dentro de la array")

                Case 12

                    'Almacenar 25 números aleatorios  en un array .
                    'Mostrar por pantalla los valores de la matriz situando un * delante de aquellos valores que aparezcan repetidos más de una vez.

            End Select

            Console.WriteLine(" ")
            Console.WriteLine("Desea continuar? [s/n]")
            continuar = CChar(Console.ReadLine)

            Console.Clear()

        Loop While continuar = "s"c Or continuar = "S"c

        Console.ReadLine()
    End Sub

End Module
