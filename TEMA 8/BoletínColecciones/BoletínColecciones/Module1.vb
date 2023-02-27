Imports System.IO
Module Module1

    Sub Main()
        Dim ejercicio As Integer
        Dim continuar As Char

        Do
            Console.WriteLine("Introduce el ejercicio que quieres ejecutar")
            ejercicio = Convert.ToInt32(Console.ReadLine)

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
                    Dim capacidad2 As Integer
                    capacidad2 = lista1.Capacity
                    Console.WriteLine("La capacidad de la lista es " & capacidad2)

                    'd
                    Dim elementosAlmacenados2 As Integer
                    elementosAlmacenados2 = lista1.Count
                    Console.WriteLine("Número de elementos almacenados realmente : " & elementosAlmacenados2)

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
                Case 3
                Case 4
                Case 5

            End Select

            Console.WriteLine()
            Console.WriteLine("Quieres ejecutar otro ejercicio ? {S/N}")
            continuar = CChar(Console.ReadLine)

        Loop Until continuar = "N"c Or continuar = "n"c
    End Sub

End Module
