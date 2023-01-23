Module Module1

    Sub Main()
        Dim ejercicio As Integer
        Dim continuar As Char

        Do

            Console.WriteLine("Introduce el ejericio que quieres ejecutar")
            ejercicio = Convert.ToInt32(Console.ReadLine)
            Console.WriteLine()

            Select Case ejercicio

                Case 1

                    Dim matriculas() As String = {"3421-ABC", "6783-BCZ", "3741-GYI", "2492-LOL", "5634-BYD", "6613-HOA", "7771-VEG", "3456-WIL", "7890-KNZ", "3767-EGO"}
                    Dim ultimaZ As Boolean
                    Dim empiezan34 As Boolean
                    Dim subfrase As String

                    Console.WriteLine("Matrículas que acaban en : Z")

                    For i = 0 To matriculas.Length - 1
                        ultimaZ = matriculas(i).EndsWith("Z"c)

                        If ultimaZ = True Then
                            Console.WriteLine(matriculas(i))
                            Console.WriteLine()
                        End If
                    Next

                    Console.WriteLine("Matrículas que contengan el número : 34 ")

                    For k = 0 To matriculas.Length - 1
                        empiezan34 = matriculas(k).Contains("34")

                        If empiezan34 = True Then
                            Console.WriteLine(matriculas(k))
                            Console.WriteLine()
                        End If
                    Next

                    Console.WriteLine("Parte númerica de las matrículas")

                    For p = 0 To matriculas.Length - 1
                        subfrase = matriculas(p).Substring(0, 4)
                        Console.WriteLine(subfrase)
                        Console.WriteLine()
                    Next

                    Console.WriteLine("Parte de las letras de las matrículas")

                    For p = 0 To matriculas.Length - 1
                        subfrase = matriculas(p).Substring(5, 3)
                        Console.WriteLine(subfrase)
                        Console.WriteLine()
                    Next

                Case 2

                    Dim caracter As Char
                    Dim cadena As String = "Herrero"
                    Dim contador As Integer

                    Console.WriteLine(cadena)
                    Console.WriteLine()

                    Console.WriteLine("Introduce el caracter que quieres contar")
                    caracter = CChar(Console.ReadLine)

                    For i = 0 To cadena.Length - 1
                        If cadena(i) = caracter Then
                            contador += 1
                        End If
                    Next

                    Console.WriteLine()
                    Console.WriteLine("El caracter " & caracter & " aparece " & contador & " veces en el string")

                Case 3

                    Dim dni As String
                    Dim contadorDigitos As Integer

                    Console.WriteLine("Introduce tu DNI")
                    dni = Console.ReadLine

                    For I = 0 To dni.Length - 1
                        If Char.IsDigit(dni(I)) Then
                            contadorDigitos += 1
                        End If
                    Next

                    Console.WriteLine()

                    If contadorDigitos = 8 Then
                        Console.WriteLine("LOS DIGITOS HAN SIDO INTRODUCIDOS CORRECTAMENTE")
                    ElseIf contadorDigitos < 8 Then
                        Console.WriteLine("ERROR AL INTRODUCIR EL DNI. FALTAN DÍGITOS")
                    ElseIf contadorDigitos > 8 Then
                        Console.WriteLine("ERROR AL INTRODUCIR EL DNI. SOBRAN DIGITOS")

                    End If

                    Console.WriteLine()

                    For r = 0 To dni.Length - 2
                        If Char.IsLetter(dni(r)) Then
                            Console.WriteLine("ERROR. LA LETRA HA SIDO INTRODUCIDA EN LOS 8 PRIMEROS DIGITOS")
                        End If
                    Next

                    Console.WriteLine()

                    If Char.IsLetter(dni(dni.Length - 1)) Then
                        Console.WriteLine("LA LETRA HA SIDO INTRODUCIDA CORRECTAMENTE")
                    Else
                        Console.WriteLine("ERROR. LA ÚLTIMA POSICIÓN NO ES UNA LETRA")
                    End If



            End Select

            Console.WriteLine()
            Console.WriteLine("Quieres ejecutar otro ejercicio ? {S/N]")
            continuar = CChar(Console.ReadLine)

        Loop While continuar = "s"c Or continuar = "S"c


    End Sub

End Module
