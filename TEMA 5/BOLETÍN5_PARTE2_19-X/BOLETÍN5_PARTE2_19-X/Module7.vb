Module Module7
    Sub Main()
        'ejericio 25 busca el número más pequeño

        Dim forma As Integer

        Console.WriteLine("Elige una forma de hacer el ejercicio")
        Console.WriteLine("Forma 1 : Ordenando las posiciones con la función sort")
        Console.WriteLine("Forma 2 : Sin ordenar las posciones")
        Console.WriteLine("Forma 3 : Ordenar de menor a mayor sin la función sort")
        forma = Convert.ToInt32(Console.ReadLine)

        Select Case forma
            Case 1
                Dim array(4) As Integer

                For i = 0 To array.Length - 1
                    Console.WriteLine("Introduce la posición " & i)
                    array(i) = Convert.ToInt32(Console.ReadLine)
                Next

                array.Sort(array)

                Console.WriteLine(" ")
                Console.WriteLine("El valor mas pequeño es " & array(0))

                Console.ReadLine()
            Case 2
                Dim array(4) As Integer
                Dim menor, contador As Integer

                For i = 0 To array.Length - 1
                    Console.WriteLine("Introduce la posición " & i)
                    array(i) = Convert.ToInt32(Console.ReadLine)
                Next

                menor = array(0)

                For n = 0 To array.Length - 1

                    If contador = array.Length - 1 Then
                        Exit For
                    End If

                    If menor < array(n + 1) Then
                        menor = menor
                        contador += 1
                    Else
                        menor = array(n + 1)
                        contador += 1
                    End If
                Next

                Console.WriteLine("El menor es " & menor)

            Case 3
                Dim array() As Integer = {5, 4, 3, 2, 1}
                Dim listaNumeros As Integer() = New Integer(array.Length - 1) {}
                Dim salvarNum As Integer

                For i = 0 To array.Length - 1
                    listaNumeros(i) = array(i)
                Next

                For a = 0 To array.Length - 2
                    For b = 0 To array.Length - 2
                        If (listaNumeros(b) > listaNumeros(b * +1)) Then
                            salvarNum = listaNumeros(b)
                            listaNumeros(b) = listaNumeros(b + 1)
                            listaNumeros(b + 1) = salvarNum
                        End If
                    Next
                Next

                Console.WriteLine(listaNumeros)
                Console.WriteLine(salvarNum)
                Console.WriteLine(array)

        End Select

        Console.ReadLine()
    End Sub
End Module
