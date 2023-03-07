Imports System.IO
Module Module1

    Sub Main()
        Dim ejercicio As Integer
        Dim continuar As Char
        Dim lista1 As ArrayList = New ArrayList(10)

        Do
            Console.WriteLine("Introduce el ejercicio que quieres ejecutar")
            ejercicio = Convert.ToInt32(Console.ReadLine)
            Console.WriteLine()

            Select Case ejercicio
                Case 1

                    Dim random As New Random

                    'a
                    Dim capacidad As Integer
                    capacidad = lista1.Capacity
                    Console.WriteLine("La capacidad de la lista es " & capacidad)

                    'b
                    Dim elementosAlmacenados As Integer
                    elementosAlmacenados = lista1.Count
                    Console.WriteLine("Número de elementos almacenados realmente : " & elementosAlmacenados)
                    Console.WriteLine()

                    'c
                    For i = 0 To lista1.Capacity - 1
                        lista1.Add(random.Next(0, 51))
                    Next

                    For Each numero In lista1
                        Console.WriteLine(numero)
                    Next

                    Console.WriteLine()
                    Console.WriteLine("La capacidad de la lista es " & lista1.Capacity)

                    'd
                    Console.WriteLine("Número de elementos almacenados realmente : " & lista1.Count)

                    'e
                    Dim number As Integer
                    Console.WriteLine("Introduce un valor para buscar su posición")
                    number = Convert.ToInt32(Console.ReadLine)
                    Console.WriteLine("Posición del número 15 : " & lista1.IndexOf(number))
                    Console.WriteLine()

                    'f
                    Dim numeroBuscado As Integer
                    Dim condicion As Boolean
                    Console.WriteLine("Introduce el valor que quieres buscar")
                    numeroBuscado = Convert.ToInt32(Console.ReadLine)
                    condicion = lista1.Contains(numeroBuscado)

                    If condicion = True Then
                        Console.WriteLine("El valor : " & numeroBuscado & " está almacenado en la lista")
                    Else
                        Console.WriteLine("El valor : " & numeroBuscado & " no está almacenado en la lista")
                    End If
                    Console.WriteLine()

                    'g
                    Dim numeroEliminado As Integer
                    Console.WriteLine("Introduce el valor que quieres eliminar")
                    numeroEliminado = Convert.ToInt32(Console.ReadLine)
                    lista1.Remove(numeroEliminado)
                    Console.WriteLine()

                    For Each numero In lista1
                        Console.WriteLine(numero)
                    Next

                    'h
                    Console.WriteLine()
                    Dim copiaLista As ArrayList = New ArrayList(lista1)
                    Console.WriteLine("Copia de la lista : ")

                    For Each valor In copiaLista
                        Console.WriteLine(valor)
                    Next

                    'i
                    lista1.Sort()
                    Console.WriteLine()
                    Console.WriteLine("Lista original ordenada")
                    For Each valor In lista1
                        Console.WriteLine(valor)
                    Next

                    'j
                    Dim ruta As String = Directory.GetCurrentDirectory() + "\valores.txt"
                    Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(ruta, False)

                    For Each valor In lista1
                        escritor.WriteLine(valor)
                    Next

                    escritor.Close()

                Case 2

                    Dim lista2 As ArrayList = New ArrayList(10)
                    Dim random As New Random()
                    Dim valorPosicion As Double
                    Dim posicion As Integer
                    Dim valorBuscado As Double
                    Dim condicion As Boolean
                    Dim valorEliminado As Double

                    For i = 0 To lista2.Capacity - 1
                        lista2.Add(random.NextDouble())
                    Next

                    For Each valor In lista2
                        Console.WriteLine(String.Format("{0:F20}", valor))
                    Next

                    'a
                    Console.WriteLine()
                    Console.WriteLine("Capacidad de la lista : " & lista2.Capacity)
                    Console.WriteLine("Nº de elementos almacenados realmente : " & lista2.Count)

                    'b
                    Console.WriteLine()
                    Console.WriteLine("Introduce un valor para obtener su posición")
                    valorPosicion = Convert.ToDouble(Console.ReadLine)
                    posicion = lista2.IndexOf(valorPosicion)
                    Console.WriteLine("El valor " & valorPosicion & " está en la posición " & posicion)

                    'c
                    Console.WriteLine()
                    Console.WriteLine("Introduce el valor que quieres buscar")
                    valorBuscado = Convert.ToDouble(Console.ReadLine)
                    condicion = lista2.Contains(valorBuscado)

                    If condicion = True Then
                        Console.WriteLine("El valor " & valorBuscado & " está en la lista")
                    Else
                        Console.WriteLine("El valor " & valorBuscado & " no está en la lista")
                    End If

                    'd
                    Console.WriteLine()
                    Console.WriteLine("Introduce el valor que quieres eliminar")
                    valorEliminado = Convert.ToDouble(Console.ReadLine)
                    lista2.Remove(valorEliminado)
                    Console.WriteLine()

                    For Each valor In lista2
                        Console.WriteLine(valor)
                    Next

                Case 3

                    Dim lista3 As ArrayList = New ArrayList(10)
                    Dim random As New Random
                    Dim mayor, menor As Integer
                    Dim matriz(9) As Integer

                    For i = 0 To lista3.Capacity - 1
                        lista3.Add(random.Next(0, 11))
                        matriz(i) = Convert.ToInt32(lista3(i))
                    Next

                    For Each valor In lista3
                        Console.WriteLine(valor)
                    Next

                    mayor = matriz(0)
                    menor = matriz(0)

                    For k = 0 To matriz.Length - 1
                        For j = 0 To matriz.Length - 1
                            mayor = Math.Max(mayor, matriz(j))
                            menor = Math.Min(menor, matriz(j))
                        Next
                    Next

                    Console.WriteLine()
                    Console.WriteLine("El mayor es " & mayor)
                    Console.WriteLine("El menor es " & menor)

                Case 4

                    Dim lista4 As ArrayList = New ArrayList()
                    Dim matrizContadores() As Integer
                    Dim mayor, menor As Integer
                    Dim contador As Integer = 0

                    lista4.Add("Buenas")
                    lista4.Add("Tardes")
                    lista4.Add("Casa")
                    lista4.Add("Esternocleidomastoideo")

                    For Each palabra In lista4
                        Console.WriteLine(palabra)
                        ReDim Preserve matrizContadores(contador)

                        For r = 0 To palabra.ToString.Length - 1
                            matrizContadores(contador) = matrizContadores(contador) + 1
                        Next
                        contador += 1
                    Next

                    mayor = matrizContadores(0)
                    menor = matrizContadores(0)

                    For f = 0 To matrizContadores.Length - 1
                        For j = 0 To matrizContadores.Length - 1
                            mayor = Math.Max(mayor, matrizContadores(j))
                            menor = Math.Min(menor, matrizContadores(j))
                        Next
                    Next

                    Console.WriteLine()

                    For k = 0 To matrizContadores.Length - 1
                        If mayor = matrizContadores(k) Then
                            Console.WriteLine("Palabra mas larga : ")
                            Console.WriteLine(lista4(k))
                        End If

                        If menor = matrizContadores(k) Then
                            Console.WriteLine("Palabra mas corta : ")
                            Console.WriteLine(lista4(k))
                        End If
                    Next

                Case 5

                    Dim lista5 As ArrayList = New ArrayList()
                    Dim edad1 As Integer
                    Dim sumaEdades As Integer
                    Dim media As Double
                    Dim otraEdad As Char

                    Do
                        Console.WriteLine("Introduce una edad")
                        edad1 = Convert.ToInt32(Console.ReadLine)
                        lista5.Add(edad1)
                        Console.WriteLine("Quieres introducir otra edad ? {S/N}")
                        otraEdad = CChar(Console.ReadLine)
                    Loop Until otraEdad = "n"c Or otraEdad = "N"c

                    For Each edad In lista5
                        Console.WriteLine(edad)
                        sumaEdades += Convert.ToInt32(edad)
                    Next

                    Console.WriteLine()
                    media = Convert.ToDouble(sumaEdades / lista5.Count)
                    Console.WriteLine("La media de edades es {0}", media)

                Case 6

                    Dim lista6 As ArrayList = New ArrayList
                    Dim suma, numero As Double
                    Dim otroNumero As Char

                    Do
                        Console.WriteLine("Introduce un número")
                        numero = Convert.ToDouble(Console.ReadLine)
                        lista6.Add(numero)
                        Console.WriteLine("Quieres introducir otro número ? {S/N}")
                        otroNumero = CChar(Console.ReadLine)
                    Loop Until otroNumero = "n"c Or otroNumero = "N"c

                    For Each num As Double In lista6
                        Console.WriteLine(num)
                        If num Mod 2 = 0 Then
                            suma += num
                        End If
                    Next

                    Console.WriteLine()
                    Console.WriteLine("La suma de los numeros pares es {0}", suma)

                Case 7

                    Dim lista7 As ArrayList = New ArrayList
                    Dim nombre As String
                    Dim otroNombre As Char

                    Do
                        Console.WriteLine("Introduce un nombre")
                        nombre = Convert.ToString(Console.ReadLine)
                        lista7.Add(nombre)
                        Console.WriteLine("Quieres introducir otro nombre ? {S/N}")
                        otroNombre = CChar(Console.ReadLine)
                    Loop Until otroNombre = "n"c Or otroNombre = "N"c

                    Console.WriteLine("Lista sin ordenadar alfabéticamente : ")

                    For Each nombres In lista7
                        Console.WriteLine(nombres)
                    Next

                    Console.WriteLine("")
                    Console.WriteLine("Lista ordenada alfabéticamente : ")
                    lista7.Sort()

                    For Each nombres2 In lista7
                        Console.WriteLine(nombres2)
                    Next

                Case 8

                    Dim lista8 As ArrayList = New ArrayList
                    Dim palabra As String
                    Dim otraPalabra As Char
                    Dim contadorLetras, contadorMasDe5 As Integer

                    Do
                        Console.WriteLine("Introduce un palabra")
                        palabra = Convert.ToString(Console.ReadLine)
                        lista8.Add(palabra)
                        Console.WriteLine("Quieres introducir otra palabra ? {S/N}")
                        otraPalabra = CChar(Console.ReadLine)
                    Loop Until otraPalabra = "n"c Or otraPalabra = "N"c

                    For Each palabras In lista8
                        Console.WriteLine(palabras)
                        contadorLetras = 0

                        For I = 0 To palabras.ToString.Length - 1
                            contadorLetras += 1
                        Next

                        If contadorLetras >= 5 Then
                            contadorMasDe5 += 1
                        End If
                    Next

                    Console.WriteLine()
                    Console.WriteLine("El número de palabras con {0}", contadorMasDe5)

                Case 9

                    Dim lista9 As ArrayList = New ArrayList()
                    Dim opcion As Integer
                    Dim rutaL As String = Directory.GetCurrentDirectory() + "\pelis.txt"
                    Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader(rutaL)

                    While Not lector.EndOfStream
                        lista9.Add(lector.ReadLine)
                    End While
                    lector.Close()

                    Console.WriteLine("Que quieres hacer ?")
                    Console.WriteLine("1 - Mostrar películas")
                    Console.WriteLine("2 - Buscar película")
                    Console.WriteLine("3 - Añadir película")
                    Console.WriteLine("4 - Eliminar película")
                    opcion = Convert.ToInt32(Console.ReadLine)

                    Select Case opcion
                        Case 1

                            For Each movies In lista9
                                Console.WriteLine(movies)
                            Next

                        Case 2

                            Dim peliBuscada As String

                            Console.WriteLine("Introduce la película que quieres buscar")
                            peliBuscada = Console.ReadLine

                            If lista9.Contains(peliBuscada) Then
                                Console.WriteLine("La película está en la lista")
                            Else
                                Console.WriteLine("La película no está en la lista")
                            End If

                        Case 3

                            Dim peliAñadida As String

                            Console.WriteLine("Introduce la película que quieres añadir")
                            peliAñadida = Console.ReadLine
                            lista9.Add(peliAñadida)

                        Case 4

                            Dim peliEliminada As String

                            Console.WriteLine("Introduce la película que quieres eliminar")
                            peliEliminada = Console.ReadLine
                            lista9.Remove(peliEliminada)

                    End Select

                    Dim ruta As String = Directory.GetCurrentDirectory() + "\pelis.txt"
                    Dim escritor1 As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(ruta, False)

                    For Each peli In lista9
                        escritor1.WriteLine(peli)
                    Next

                    escritor1.Close()

                Case 10

                    Dim lista10 As ArrayList = New ArrayList(lista1)
                    Dim random As New Random

                    For i = 0 To 4
                        lista10.Add(random.Next(100, 201))
                    Next

                    For Each aletorio In lista10
                        Console.WriteLine(aletorio)
                    Next

                Case 11

                    Dim lista11 As ArrayList = New ArrayList()
                    Dim listaCopias As ArrayList = New ArrayList()
                    Dim random As New Random
                    Dim suma As Integer
                    Dim media As Double
                    Dim contadorVeintes As Integer
                    Dim porcentaje As Double
                    Dim contadorRepetidos As Integer

                    For i = 0 To 9
                        lista11.Add(random.Next(1, 26))
                    Next

                    For Each num In lista11
                        Console.WriteLine(num)
                    Next
                    Console.WriteLine()

                    'a
                    If lista11.IndexOf(2) >= 0 Then
                        Console.WriteLine("Posición del valor 2 : " & lista11.IndexOf(2))
                    Else
                        Console.WriteLine("El valor 2 no se encuentra en la lista")
                    End If
                    Console.WriteLine()

                    'b
                    For Each number In lista11
                        suma += Convert.ToInt32(number)
                    Next
                    Console.WriteLine("Suma de los valores generados {0}", suma)
                    Console.WriteLine()

                    'c
                    media = Convert.ToDouble(suma / lista11.Count)
                    Console.WriteLine("La media de los valores generados es {0}", media)
                    Console.WriteLine()

                    'd
                    For Each number In lista11
                        If Convert.ToInt32(number) > 20 Then
                            contadorVeintes += 1
                        End If
                    Next
                    porcentaje = (contadorVeintes / lista11.Count) * 100
                    Console.WriteLine("El {0}% de los valores son superiores a 20", porcentaje)
                    Console.WriteLine()

                    'e
                    For i = 0 To lista11.Count - 1
                        contadorRepetidos = 0

                        If listaCopias.Contains(lista11(i)) Then
                            i += 1
                        End If

                        For n = 0 To lista11.Count - 1
                            If Convert.ToInt32(lista11(i)) = Convert.ToInt32(lista11(n)) Then
                                contadorRepetidos += 1
                            End If
                        Next

                        If contadorRepetidos = 1 Then
                            Console.WriteLine(lista11(i))
                        Else
                            listaCopias.Add(lista11(i))
                            Console.WriteLine(lista11(i))
                        End If
                    Next

                Case 12

                    Dim lista12 As ArrayList = New ArrayList()
                    Dim listaCompletadas As ArrayList = New ArrayList()
                    Dim tCompletada As String
                    Dim apartado As Integer
                    Dim otroApartado As Char

                    Do
                        Console.WriteLine("Introduce el apartado que quieres ejecutar [1-7]")
                        apartado = Convert.ToInt32(Console.ReadLine)

                        Select Case apartado
                            Case 1
                                Dim tarea As String
                                Dim contador As Integer = 0
                                Dim condicion As Boolean = False

                                Console.WriteLine("Introduce una tarea con formato Título*Proridad*mes-dia-año")
                                tarea = Console.ReadLine

                                Do
                                    contador = 0

                                    For i = 0 To tarea.Length - 1
                                        If tarea(i).ToString.Contains("*") Then
                                            contador += 1
                                        End If
                                    Next

                                    If contador <> 2 Then
                                        Console.WriteLine("ERROR AL INTRODUCIR LA TAREA. INTRODÚCELA DE OTRA VEZ")
                                        tarea = Console.ReadLine
                                    Else
                                        condicion = True
                                    End If

                                Loop Until condicion = True

                                lista12.Add(tarea)

                            Case 2
                                Console.WriteLine("Introduce la tarea que quieres completar")
                                tCompletada = Console.ReadLine

                                lista12.Remove(tCompletada)
                                listaCompletadas.Add(tCompletada)

                                Console.WriteLine()
                                Console.WriteLine("Operación realizada con éxito")

                            Case 3
                                Console.WriteLine()
                                Console.WriteLine("Número de tareas : {0}", lista12.Count)
                                Console.WriteLine()

                            Case 4
                                For Each tarea In lista12
                                    Console.WriteLine(tarea)
                                Next

                            Case 5
                                For Each completada In listaCompletadas
                                    Console.WriteLine(completada)
                                Next

                            Case 6
                                Dim fechaTarea As String
                                Dim posicion As Integer
                                Console.WriteLine("Tareas que vencen hoy : ")

                                For Each fecha In lista12
                                    posicion = fecha.ToString.LastIndexOf("*")
                                    fechaTarea = fecha.ToString.Substring(posicion + 1)

                                    If fechaTarea = DateString Then
                                        Console.WriteLine(fecha)
                                    End If
                                Next

                            Case 7

                                Dim prioridadString(lista12.Count - 1) As String
                                Dim contador As Integer = 0
                                Dim posicion As Integer

                                For Each tar In lista12
                                    prioridadString(contador) = Convert.ToString(tar)
                                    posicion = prioridadString(contador).IndexOf("*") + 1
                                    prioridadString(contador) = prioridadString(contador).Substring(posicion, 1)

                                    If Convert.ToInt32(prioridadString(contador)) > 7 Then
                                        Console.WriteLine(tar)
                                    End If

                                    contador += 1
                                Next

                        End Select

                        Console.WriteLine
                        Console.WriteLine("Quieres ejecutar otro apartado ? [s/n]")
                        otroApartado = CChar(Console.ReadLine)

                    Loop Until otroApartado = "N"c Or otroApartado = "n"c

                Case 13

                    Dim lista13 As ArrayList = New ArrayList()
                    Dim apartado As Integer
                    Console.WriteLine("Introduce el apartado que quieres ejecutar {1-4}")
                    apartado = Convert.ToInt32(Console.ReadLine)

                    Select Case apartado
                        Case 1
                            Dim dni As String
                            Console.WriteLine("Introduce un DNI")
                            dni = Console.ReadLine

                            If lista13.Contains(dni) Then
                                Console.WriteLine("El DNI no se va a guardar, ya está en la lista")
                            Else
                                lista13.Add(dni)
                            End If

                        Case 2
                            Dim dni As String
                            Console.WriteLine("Introduce un dni para eliminarlo")
                            dni = Console.ReadLine
                            lista13.Remove(dni)

                        Case 3
                            For Each dni In lista13
                                Console.WriteLine(dni)
                            Next

                        Case 4
                            Console.WriteLine("Numero de DNIs almacenados {0}", lista13.Count)

                    End Select

            End Select

            Console.WriteLine()
            Console.WriteLine("Quieres ejecutar otro ejercicio ? {S/N}")
            continuar = CChar(Console.ReadLine)

        Loop Until continuar = "N"c Or continuar = "n"c
    End Sub

End Module
