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
                    Dim numerosDni As Integer
                    Dim condicionLetra As Boolean = False
                    Dim condicionNum As Boolean = False
                    Dim letra As Char
                    Dim matrizLetras() As Char = {"T"c, "R"c, "W"c, "A"c, "G"c, "M"c, "Y"c, "F"c, "P"c, "D"c, "X"c, "B"c, "N"c, "J"c, "Z"c, "S"c, "Q"c, "V"c, "H"c, "L"c, "C"c, "K"c, "E"c}


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
                        condicionNum = True
                    ElseIf contadorDigitos < 8 Then
                        Console.WriteLine("ERROR AL INTRODUCIR EL DNI. FALTAN DÍGITOS")
                    ElseIf contadorDigitos > 8 Then
                        Console.WriteLine("ERROR AL INTRODUCIR EL DNI. SOBRAN DIGITOS")

                    End If

                    Console.WriteLine()

                    For r = 0 To dni.Length - 2
                        If Char.IsLetter(dni(r)) Then
                            Console.WriteLine("ERROR AL INTRODUCIR EL DNI. LA LETRA HA SIDO INTRODUCIDA EN LOS 8 PRIMEROS DIGITOS")
                            Console.WriteLine()
                        End If
                    Next

                    If Char.IsLetter(dni(dni.Length - 1)) Then
                        Console.WriteLine("LA LETRA HA SIDO INTRODUCIDA CORRECTAMENTE")
                        condicionLetra = True
                    Else
                        Console.WriteLine("ERROR AL INTRODUCIR EL DNI. LA ÚLTIMA POSICIÓN NO ES UNA LETRA")
                    End If

                    Console.WriteLine()

                    If condicionLetra = True And condicionNum = True Then
                        numerosDni = CInt(dni.Substring(0, 8))
                        numerosDni = numerosDni Mod 23
                        letra = dni.Substring(8)

                        If letra = matrizLetras(numerosDni) Then
                            Console.WriteLine("DNI VALIDADO. EL CALCULO DE LA LETRA ES CORRECTO")
                        Else
                            Console.WriteLine("ERROR AL INTRODUCIR EL DNI. LA LETRA INDICADA NO ES CORRECTA")
                        End If

                    End If

                Case 4

                    Dim cadena As String = "Buenas buen samaritano me gustan las burbujas pero no las brujas."
                    Dim palabrasConB As String() = cadena.Split(" "c, "."c)
                    Dim condicionPalabras As Boolean = False

                    Console.WriteLine(cadena)
                    Console.WriteLine()
                    Console.WriteLine("Palabras que empiezan por b : ")

                    For i = 0 To palabrasConB.Length - 1
                        condicionPalabras = False
                        condicionPalabras = palabrasConB(i).StartsWith("b"c)

                        If condicionPalabras = True Then
                            Console.WriteLine(palabrasConB(i))
                        End If
                    Next

                Case 5

                    Dim cadena As String = "Mi correo es pablo.casal.romero@ciclosmontecastelo.com"
                    Dim arroba As Boolean = False

                    Console.WriteLine(cadena)
                    Console.WriteLine()

                    arroba = cadena.Contains("@"c)

                    If arroba = True Then
                        Console.WriteLine("El String contiene un : @")
                    Else
                        Console.WriteLine("El String no contiene un : @")
                    End If

                Case 6

                    Dim cadena As String = "Pensaba que ella cantaba y bailaba"
                    Dim palabras() As String = cadena.Split(" "c, "."c)
                    Dim condicion As Boolean = False
                    Dim contador As Integer
                    Dim substring As String

                    Console.WriteLine("Introduce el substring que quieres buscar")
                    substring = Console.ReadLine
                    Console.WriteLine()

                    For i = 0 To palabras.Length - 1
                        condicion = False
                        condicion = palabras(i).Contains(substring)

                        If condicion = True Then
                            contador += 1
                            Console.WriteLine(palabras(i))
                        End If
                    Next

                    Console.WriteLine()

                    Console.WriteLine("Hay " & contador & " palabras que contienen el substring " & substring)

                Case 7

                    Dim correo As String = "pablocasalromerogmail.com"
                    Dim posicionArroba As Integer = correo.LastIndexOf("@"c)
                    Dim dominio As String = correo.Substring(posicionArroba + 1)

                    Console.WriteLine("Correo : " & correo)
                    Console.WriteLine()
                    Console.WriteLine("Dominio : " & dominio)

                Case 8

                    Dim codigo As String = "AB89"
                    Dim contadorLetras As Integer = 0
                    Dim contadorNums As Integer = 0
                    Dim subString1 As String = codigo.Substring(0, 2)
                    Dim subString2 As String = codigo.Substring(2, 2)

                    Console.WriteLine(codigo)
                    Console.WriteLine()

                    For i = 0 To subString1.Length - 1
                        If Char.IsLetter(subString1(i)) Then
                            contadorLetras += 1
                        End If
                    Next

                    For o = 0 To subString2.Length - 1
                        If Char.IsDigit(subString2(o)) Then
                            contadorNums += 1
                        End If
                    Next

                    If contadorLetras = 2 And contadorNums = 2 Then
                        Console.WriteLine("El código tiene el formato : AA99")
                    Else
                        Console.WriteLine("El código no tiene el formato : AA99")
                    End If

                Case 9

                    Dim cadena As String = "Tengo un coeficiente intelectual más alto que Rajoy"
                    Dim cadena2() As String = cadena.Split(" "c)

                    Console.WriteLine(cadena)

                    For i = 0 To cadena2.Length - 1
                        Console.Write(cadena2(i) & "*")
                    Next

                Case 10

                    Dim cadena1 As String = "Pedro Jimenez*14Julio1990?2500"
                    Dim subcadena1 As String = cadena1.Substring(26)
                    Dim cadena2 As String = "María Benitez*9070!06Agosto1998"
                    Dim subcadena2 As String = cadena2.Substring(14, 4)

                    Console.WriteLine(cadena1)
                    Console.WriteLine()
                    Console.WriteLine("Sueldo : " & subcadena1)
                    Console.WriteLine()
                    Console.WriteLine(cadena2)
                    Console.WriteLine()
                    Console.WriteLine("Sueldo : " & subcadena2)

                Case 11

                    Dim repetir As Char
                    Dim perder As Boolean = False

                    Do
                        Dim palabras() As String = {"PÁJARO", "BURBUJA", "COMUNIDAD", "AZUL", "LIMÓN", "MESA", "ESTERNOCLEIDOMASTOIDEO", "BRUJA", "MERMELADA", "PIZZA", "AGUCATE", "PIERNA", "ROSA", "CASA", "CERVEZA"}
                        Dim random As New Random
                        Dim palabraRandom As Integer
                        Dim palabraIndividual As String
                        Dim letra As Char
                        Dim contador As Integer = 0
                        Dim modoJuego As Byte

                        Console.WriteLine("Bienvenido al juego del AHORCADO")
                        Console.WriteLine("")
                        Console.WriteLine("Elige una difultad : ")
                        Console.WriteLine("1 : Modo Fácil, 10 vidas")
                        Console.WriteLine("2 : Modo Normal, 5 vidas")
                        Console.WriteLine("3 : Modo Dificil, 3 vidas")
                        modoJuego = Convert.ToByte(Console.ReadLine)

                        Select Case modoJuego
                            Case 1

                                palabraRandom = random.Next(0, palabras.Length - 1)
                                palabraIndividual = palabras(palabraRandom)

                                Console.WriteLine("La palabra tiene " & palabraIndividual.Length & " letras")
                                Console.WriteLine()

                                For o = 1 To 10

                                    Console.WriteLine("Adivina la letra ")
                                    letra = CChar(Console.ReadLine)
                                    Console.WriteLine()

                                    For i = 0 To palabraIndividual.Length - 1

                                        If letra = palabraIndividual(i) Then
                                            Console.WriteLine("Has acertado la letra")
                                            Console.WriteLine()
                                            contador += 1
                                            o -= 1
                                        End If

                                    Next

                                    If contador = palabraIndividual.Length Then
                                        Console.WriteLine("Has acertado, la palabra era : " & palabraIndividual)
                                        perder = True
                                        Exit For
                                    End If

                                Next

                                If perder = False Then
                                    Console.WriteLine("Has perdido, nunca sabrás cual era la palabra :(")
                                End If

                            Case 2

                                palabraRandom = random.Next(0, palabras.Length - 1)
                                palabraIndividual = palabras(palabraRandom)

                                Console.WriteLine("La palabra tiene " & palabraIndividual.Length & " letras")
                                Console.WriteLine()

                                For o = 1 To 5

                                    Console.WriteLine("Adivina la letra ")
                                    letra = CChar(Console.ReadLine)
                                    Console.WriteLine()

                                    For i = 0 To palabraIndividual.Length - 1

                                        If letra = palabraIndividual(i) Then
                                            Console.WriteLine("Has acertado la letra")
                                            Console.WriteLine()
                                            contador += 1
                                            o -= 1
                                        End If

                                    Next

                                    If contador = palabraIndividual.Length Then
                                        Console.WriteLine("Has acertado, la palabra era : " & palabraIndividual)
                                        perder = True
                                        Exit For
                                    End If

                                Next

                                If perder = False Then
                                    Console.WriteLine("Has perdido, nunca sabrás cual era la palabra :(")
                                End If

                            Case 3

                                palabraRandom = random.Next(0, palabras.Length - 1)
                                palabraIndividual = palabras(palabraRandom)

                                Console.WriteLine("La palabra tiene " & palabraIndividual.Length & " letras")
                                Console.WriteLine()

                                For o = 1 To 3

                                    Console.WriteLine("Adivina la letra ")
                                    letra = CChar(Console.ReadLine)
                                    Console.WriteLine()

                                    For i = 0 To palabraIndividual.Length - 1

                                        If letra = palabraIndividual(i) Then
                                            Console.WriteLine("Has acertado la letra")
                                            Console.WriteLine()
                                            contador += 1
                                            o -= 1
                                        End If

                                    Next

                                    If contador = palabraIndividual.Length Then
                                        Console.WriteLine("Has acertado, la palabra era : " & palabraIndividual)
                                        perder = True
                                        Exit For
                                    End If

                                Next

                                If perder = False Then
                                    Console.WriteLine("Has perdido, nunca sabrás cual era la palabra :(")
                                End If

                        End Select

                        Console.WriteLine()
                        Console.WriteLine("Quieres jugar otra vez? {S/N}")
                        repetir = CChar(Console.ReadLine)

                    Loop Until repetir = "N"c Or repetir = "n"c

            End Select

            Console.WriteLine()
            Console.WriteLine("Quieres ejecutar otro ejercicio ? {S/N]")
            continuar = CChar(Console.ReadLine)

        Loop While continuar = "s"c Or continuar = "S"c


    End Sub

End Module
