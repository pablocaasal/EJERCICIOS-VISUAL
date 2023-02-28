Imports System.IO
Module Module1

    Sub Main()
        Dim ejercicio As Integer
        Dim continuar As Char

        Do
            Console.WriteLine("Introduce el ejercicio que quieres ejecutar")
            ejercicio = Convert.ToInt32(Console.ReadLine)
            Console.WriteLine()

            Select Case ejercicio
                Case 1

                    Dim lista1 As ArrayList = New ArrayList(10)
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
                    Console.WriteLine("Posición del número 15 : " & lista1.IndexOf(15))
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

                    Dim lista4 As ArrayList = New ArrayList(10)
                    Dim matriz(9) As String

                    lista4.Add("Buenas")
                    lista4.Add("Tardes")
                    lista4.Add("Casa")
                    lista4.Add("Esternocleidomastoideo")

                    For i = 0 To lista4.Capacity - 1
                        matriz(i) = Convert.ToString(lista4(i))
                    Next



                Case 5

            End Select

            Console.WriteLine()
            Console.WriteLine("Quieres ejecutar otro ejercicio ? {S/N}")
            continuar = CChar(Console.ReadLine)

        Loop Until continuar = "N"c Or continuar = "n"c
    End Sub

End Module
