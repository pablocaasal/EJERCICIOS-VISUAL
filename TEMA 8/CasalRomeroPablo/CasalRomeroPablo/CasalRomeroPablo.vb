Module CasalRomeroPablo

    Sub Main()
        Dim lista As ArrayList = New ArrayList(10)
        Dim apartado As Integer
        Dim continuar As Char

        Do
            Console.WriteLine("Introduce el apartado que quieres ejecutar")
            apartado = Convert.ToInt32(Console.ReadLine)
            Console.WriteLine()

            Select Case apartado
                Case 1

                    Dim random As New Random

                    For i = 0 To lista.Capacity - 1
                        lista.Add(random.Next(-10, 11))
                    Next

                    For Each num In lista
                        Console.WriteLine(num)
                    Next

                Case 2

                    Dim suma As Integer

                    For Each num In lista
                        suma += Convert.ToInt32(num)
                    Next

                    Console.WriteLine("La suma de los números es {0}", suma)

                Case 3

                    Dim media As Double = 0

                    For Each num In lista
                        media += Convert.ToDouble(num)
                    Next

                    media = media / lista.Count
                    Console.WriteLine("La media de los números es {0}", media)

                Case 4

                    Dim mayor, menor As Integer

                    mayor = Convert.ToInt32(lista(0))
                    menor = Convert.ToInt32(lista(0))

                    For i = 0 To lista.Count - 1
                        mayor = Math.Max(Convert.ToInt32(mayor), Convert.ToInt32(lista(i)))
                        menor = Math.Min(Convert.ToInt32(menor), Convert.ToInt32(lista(i)))
                    Next

                    Console.WriteLine("El mayor es {0}", mayor)
                    Console.WriteLine("El menor es {0}", menor)

                Case 5

                    Dim contador As Integer = 0
                    Dim contador2 As Integer = 0

                    For Each num In lista
                        contador = 0

                        For i = 1 To 100
                            If Convert.ToInt32(num) Mod i = 0 Then
                                contador += 1
                            End If
                        Next

                        If contador = 2 Then
                            contador2 += 1
                        End If
                    Next

                    Console.WriteLine("Cantidad de nº primos : {0}", contador2)

                Case 6

                    Dim media As Double = 0
                    Dim contador As Integer = 0

                    For Each num In lista
                        media += Convert.ToDouble(num)
                    Next
                    media = media / lista.Count

                    For Each num In lista
                        If Convert.ToInt32(num) > media Then
                            contador += 1
                        End If
                    Next

                    Console.WriteLine("Media : {0}", media)
                    Console.WriteLine("Numeros por encima de la media : {0}", contador)

                Case 7

                    For i = 0 To lista.Count - 1
                        If Convert.ToInt32(lista(i)) < 0 Then
                            lista.Insert(i, Convert.ToInt32(lista(i)) * -1)
                            lista.RemoveAt(i + 1)
                        End If
                    Next

                    For Each num In lista
                        Console.WriteLine(num)
                    Next

                Case 8

                    Dim contador As Integer = -1
                    Dim impar As Integer

                    For Each num In lista
                        If Convert.ToInt32(num) Mod 2 <> 0 Then
                            impar = Convert.ToInt32(num)
                        End If
                    Next

                    Console.WriteLine("Posición del último número impar : {0}", lista.LastIndexOf(impar))

                Case 9

                    Dim contador As Integer
                    Dim listaRpetidos As ArrayList = New ArrayList

                    lista.Sort()

                    For i = 0 To lista.Count - 1
                        contador = 0

                        If listaRpetidos.Contains(lista(i)) Then
                            i += 1
                        End If

                        'repito el mismo trozo de codigo por si el número se repite 3 veces y coincide que 2 estan en posiciones colindantes

                        If listaRpetidos.Contains(lista(i)) Then
                            i += 1
                        End If

                        For n = 0 To lista.Count - 1
                            If Convert.ToInt32(lista(i)) = Convert.ToInt32(lista(n)) Then
                                contador += 1
                            End If
                        Next

                        If contador > 1 Then
                            listaRpetidos.Add(lista(i))
                        End If

                        Console.WriteLine("Nº de repeticiones del número {0} : {1}", lista(i), contador)
                    Next

                Case 10

                    Exit Select

            End Select

            Console.WriteLine()
            Console.WriteLine("Quieres ejecutar otro apartado ? {S/N}")
            continuar = CChar(Console.ReadLine)

        Loop Until continuar = "n"c Or continuar = "N"c
    End Sub

End Module
