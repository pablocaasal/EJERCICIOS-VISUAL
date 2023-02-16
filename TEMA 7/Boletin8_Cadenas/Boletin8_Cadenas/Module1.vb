Imports System.IO
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

                    ElseIf contadorDigitos < 8 Then
                        Console.WriteLine("ERROR AL INTRODUCIR EL DNI. FALTAN DÍGITOS")
                    ElseIf contadorDigitos > 8 Then
                        Console.WriteLine("ERROR AL INTRODUCIR EL DNI. SOBRAN DIGITOS")

                    End If

                    Console.WriteLine()

                    If condicionLetra = True And condicionNum = True Then
                        numerosDni = CInt(dni.Substring(0, 8))
                        numerosDni = numerosDni Mod 23
                        letra = CChar(dni.Substring(8))

                        If letra = matrizLetras(numerosDni) Then
                            Console.WriteLine("DNI VALIDADO. EL CALCULO DE LA LETRA ES CORRECTO")
                            Dim escritor As StreamWriter = New StreamWriter(Directory.GetCurrentDirectory() + "\accesosDNI.txt", True)
                            escritor.WriteLine(dni & "*" & Date.Now.ToShortTimeString)
                            escritor.Close()
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
                    Dim ganar As Boolean = False

                    Do
                        Dim palabras() As String = {"PÁJARO", "BURBUJA", "COMUNIDAD", "AZUL", "LIMÓN", "MESA", "ESTERNOCLEIDOMASTOIDEO", "BRUJA", "MERMELADA", "PIZZA", "AGUCATE", "PIERNA", "ROSA", "CASA", "CERVEZA", "CAMISETA", "ZAPATO", "MINA", "ARGENTINA", "LOCOMOTORA", "ÓRGANO", "LIMONADA", "TAMBOR", "GUITARRA", "SALCHICHA", "AGUACATE", "HUEVO", "LIBRETA", "TABACO", "ALCOHOL"}
                        Dim random As New Random
                        Dim palabraRandom As Integer
                        Dim palabraIndividual As String
                        Dim matrizLetras(99) As Char
                        Dim letra As Char
                        Dim contador As Integer = -1
                        Dim contadorAciertos As Integer = 0
                        Dim contadorFallos As Integer = 0
                        Dim contadorLetrasRepetidas As Integer = 0
                        Dim modoJuego As Byte
                        Dim acierto As Boolean = False
                        Dim letraRepetida As Char
                        Dim condicionMayus As Boolean = False
                        ganar = False


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
                                Dim matrizLetrasAcertadas(palabraIndividual.Length - 1) As Char
                                Dim vidas1 As Integer = 10
                                contadorFallos = 0
                                contadorAciertos = 0
                                ganar = False

                                Do
                                    acierto = False
                                    contador += 1
                                    contadorLetrasRepetidas = 0
                                    Console.WriteLine()
                                    Console.WriteLine("ADIVINA LA LETRA")
                                    letra = CChar(Console.ReadLine)
                                    matrizLetras(contador) = letra
                                    Console.Clear()
                                    Console.WriteLine()

                                    Do
                                        If Char.IsLower(letra) Then
                                            Console.WriteLine("ERROR, NO PUEDES INTRODUCIR LETRAS MINÚSCULAS.")
                                            Console.WriteLine()
                                            Console.WriteLine("INTRODUCE UNA LETRA (MAYÚSCULA)")
                                            letra = CChar(Console.ReadLine)
                                            Console.WriteLine()
                                            condicionMayus = True
                                        Else
                                            condicionMayus = False
                                            matrizLetras(contador) = letra
                                        End If

                                        For h = 0 To contador - 1
                                            If letra = matrizLetras(h) Then
                                                letraRepetida = letra
                                                Console.WriteLine("ERROR, NO PUEDES REPETIR LAS LETRAS")
                                                Console.WriteLine()
                                                Console.WriteLine("ADIVINA LA LETRA")
                                                letra = CChar(Console.ReadLine)
                                                Console.WriteLine()
                                                matrizLetras(contador) = letra
                                            End If
                                        Next

                                        If Char.IsLower(letra) Then
                                            Console.WriteLine("ERROR, NO PUEDES INTRODUCIR LETRAS MINÚSCULAS.")
                                            Console.WriteLine()
                                            Console.WriteLine("INTRODUCE UNA LETRA (MAYÚSCULA)")
                                            letra = CChar(Console.ReadLine)
                                            Console.WriteLine()
                                            condicionMayus = True
                                        Else
                                            condicionMayus = False
                                            matrizLetras(contador) = letra
                                        End If

                                    Loop Until condicionMayus = False And letra <> letraRepetida

                                    For o = 0 To palabraIndividual.Length - 1

                                        If letra = palabraIndividual(o) Then
                                            acierto = True
                                            contadorAciertos += 1
                                            matrizLetrasAcertadas(o) = letra
                                            contadorLetrasRepetidas += 1

                                            If contadorLetrasRepetidas = 1 Then
                                                Console.WriteLine("HAS ACERTADO LA LETRA")
                                                Console.WriteLine("")
                                                Console.WriteLine("TE QUEDAN " & vidas1 & " INTENTOS")
                                            End If

                                        End If
                                    Next

                                    If acierto = False Then

                                        contadorFallos += 1
                                        vidas1 -= 1
                                        Console.WriteLine()
                                        Console.WriteLine("NO HAS ACERTADO LA LETRA")
                                        Console.WriteLine()
                                        Console.WriteLine("TE QUEDAN " & vidas1 & " INTENTOS")

                                        If contadorFallos = 1 Then
                                            Console.WriteLine("
 ________
 |/ 
 | 
 | 
 | 
 | 
 |
 |
 -------
 ")
                                        End If
                                        If contadorFallos = 2 Then
                                            Console.WriteLine("
 _________
 |/ 
 | 
 | 
 | 
 | 
 |
 |
 -------
 ")
                                        End If
                                        If contadorFallos = 3 Then
                                            Console.WriteLine("
 _________
 |/ | 
 | 
 | 
 | 
 | 
 |
 |
 -------
 ")
                                        End If
                                        If contadorFallos = 4 Then
                                            Console.WriteLine("
 _________
 |/ | 
 | |
 | 
 | 
 | 
 |
 |
 -------
 ")
                                        End If
                                        If contadorFallos = 5 Then
                                            Console.WriteLine("
 _________
 |/ | 
 | |
 | o
 | 
 | 
 |
 |
 -------
 ")
                                        End If
                                        If contadorFallos = 6 Then
                                            Console.WriteLine("
 _________
 |/ | 
 | |
 | o
 | |
 | 
 |
 |
 -------
 ")
                                        End If
                                        If contadorFallos = 7 Then
                                            Console.WriteLine("
 _________
 |/ | 
 | |
 | o
 | /|
 | 
 |
 |
 -------
 ")
                                        End If
                                        If contadorFallos = 8 Then
                                            Console.WriteLine("
 _________
 |/ | 
 | |
 | o
 | /|\
 | 
 |
 |
 -------
 ")
                                        End If
                                        If contadorFallos = 9 Then
                                            Console.WriteLine("
 _________
 |/ | 
 | |
 | o
 | /|\
 | / 
 |
 |
 -------
 ")
                                        End If
                                        If contadorFallos = 10 Then
                                            Console.WriteLine("
 _________
 |/ | 
 | |
 | o
 | /|\
 | / \
 |
 |
 -------
 ")
                                        End If
                                    End If

                                    Console.WriteLine()

                                    For j = 0 To matrizLetrasAcertadas.Length - 1
                                        If Char.IsLetter(matrizLetrasAcertadas(j)) Then
                                            Console.Write(matrizLetrasAcertadas(j))
                                        Else
                                            Console.Write("-")
                                        End If
                                    Next

                                    Console.WriteLine()

                                    If contadorAciertos = palabraIndividual.Length Then
                                        Console.WriteLine()
                                        Console.WriteLine("HAS ACERTADO ! LA PALABRA ERA " & palabraIndividual)
                                        ganar = True
                                    End If

                                    If vidas1 = 0 Then
                                        Console.WriteLine()
                                        Console.WriteLine("HAS PERDIDO :( LA PALABRA ERA " & palabraIndividual)
                                    End If

                                Loop Until ganar = True Or vidas1 = 0

                            Case 2

                                palabraRandom = random.Next(0, palabras.Length - 1)
                                palabraIndividual = palabras(palabraRandom)
                                Dim matrizLetrasAcertadas(palabraIndividual.Length - 1) As Char
                                Dim vidas1 As Integer = 5
                                contadorFallos = 0
                                contadorAciertos = 0
                                ganar = False

                                Do
                                    acierto = False
                                    contador += 1
                                    contadorLetrasRepetidas = 0
                                    Console.WriteLine()
                                    Console.WriteLine("ADIVINA LA LETRA")
                                    letra = CChar(Console.ReadLine)
                                    matrizLetras(contador) = letra
                                    Console.Clear()
                                    Console.WriteLine()

                                    Do
                                        If Char.IsLower(letra) Then
                                            Console.WriteLine("ERROR, NO PUEDES INTRODUCIR LETRAS MINÚSCULAS.")
                                            Console.WriteLine()
                                            Console.WriteLine("INTRODUCE UNA LETRA (MAYÚSCULA)")
                                            letra = CChar(Console.ReadLine)
                                            Console.WriteLine()
                                            condicionMayus = True
                                        Else
                                            condicionMayus = False
                                            matrizLetras(contador) = letra
                                        End If

                                        For h = 0 To contador - 1
                                            If letra = matrizLetras(h) Then
                                                letraRepetida = letra
                                                Console.WriteLine("ERROR, NO PUEDES REPETIR LAS LETRAS")
                                                Console.WriteLine()
                                                Console.WriteLine("ADIVINA LA LETRA")
                                                letra = CChar(Console.ReadLine)
                                                Console.WriteLine()
                                                matrizLetras(contador) = letra
                                            End If
                                        Next

                                        If Char.IsLower(letra) Then
                                            Console.WriteLine("ERROR, NO PUEDES INTRODUCIR LETRAS MINÚSCULAS.")
                                            Console.WriteLine()
                                            Console.WriteLine("INTRODUCE UNA LETRA (MAYÚSCULA)")
                                            letra = CChar(Console.ReadLine)
                                            Console.WriteLine()
                                            condicionMayus = True
                                        Else
                                            condicionMayus = False
                                            matrizLetras(contador) = letra
                                        End If

                                    Loop Until condicionMayus = False And letra <> letraRepetida

                                    For o = 0 To palabraIndividual.Length - 1

                                        If letra = palabraIndividual(o) Then
                                            acierto = True
                                            contadorAciertos += 1
                                            matrizLetrasAcertadas(o) = letra
                                            contadorLetrasRepetidas += 1

                                            If contadorLetrasRepetidas = 1 Then
                                                Console.WriteLine("HAS ACERTADO LA LETRA")
                                                Console.WriteLine("")
                                                Console.WriteLine("TE QUEDAN " & vidas1 & " INTENTOS")
                                            End If

                                        End If
                                    Next

                                    If acierto = False Then

                                        contadorFallos += 1
                                        vidas1 -= 1
                                        Console.WriteLine()
                                        Console.WriteLine("NO HAS ACERTADO LA LETRA")
                                        Console.WriteLine()
                                        Console.WriteLine("TE QUEDAN " & vidas1 & " INTENTOS")

                                        If contadorFallos = 1 Then
                                            Console.WriteLine("
 ________
 |/ | 
 | | 
 | o 
 | |
 | 
 |
 |
 -------
 ")
                                        End If
                                        If contadorFallos = 2 Then
                                            Console.WriteLine("
 _________
 |/ |
 | |
 | o
 | |\
 | 
 |
 |
 -------
 ")
                                        End If
                                        If contadorFallos = 3 Then
                                            Console.WriteLine("
 _________
 |/ | 
 | |
 | o
 | /|\
 | 
 |
 |
 -------
 ")
                                        End If
                                        If contadorFallos = 4 Then
                                            Console.WriteLine("
 _________
 |/ | 
 | |
 | o
 | /|\
 | / 
 |
 |
 -------
 ")
                                        End If
                                        If contadorFallos = 5 Then
                                            Console.WriteLine("
 _________
 |/ | 
 | |
 | o
 | /|\
 | / \
 |
 |
 -------
 ")
                                        End If

                                    End If

                                    Console.WriteLine()

                                    For j = 0 To matrizLetrasAcertadas.Length - 1
                                        If Char.IsLetter(matrizLetrasAcertadas(j)) Then
                                            Console.Write(matrizLetrasAcertadas(j))
                                        Else
                                            Console.Write("-")
                                        End If
                                    Next

                                    Console.WriteLine()

                                    If contadorAciertos = palabraIndividual.Length Then
                                        Console.WriteLine()
                                        Console.WriteLine("HAS ACERTADO ! LA PALABRA ERA " & palabraIndividual)
                                        ganar = True
                                    End If

                                    If vidas1 = 0 Then
                                        Console.WriteLine()
                                        Console.WriteLine("HAS PERDIDO :( LA PALABRA ERA " & palabraIndividual)
                                    End If

                                Loop Until ganar = True Or vidas1 = 0

                            Case 3

                                palabraRandom = random.Next(0, palabras.Length - 1)
                                palabraIndividual = palabras(palabraRandom)
                                Dim matrizLetrasAcertadas(palabraIndividual.Length - 1) As Char
                                Dim vidas1 As Integer = 3
                                contadorFallos = 0
                                contadorAciertos = 0
                                ganar = False

                                Do
                                    acierto = False
                                    contador += 1
                                    contadorLetrasRepetidas = 0
                                    Console.WriteLine()
                                    Console.WriteLine("ADIVINA LA LETRA")
                                    letra = CChar(Console.ReadLine)
                                    matrizLetras(contador) = letra
                                    Console.Clear()
                                    Console.WriteLine()

                                    Do
                                        If Char.IsLower(letra) Then
                                            Console.WriteLine("ERROR, NO PUEDES INTRODUCIR LETRAS MINÚSCULAS.")
                                            Console.WriteLine()
                                            Console.WriteLine("INTRODUCE UNA LETRA (MAYÚSCULA)")
                                            letra = CChar(Console.ReadLine)
                                            Console.WriteLine()
                                            condicionMayus = True
                                        Else
                                            condicionMayus = False
                                            matrizLetras(contador) = letra
                                        End If

                                        For h = 0 To contador - 1
                                            If letra = matrizLetras(h) Then
                                                letraRepetida = letra
                                                Console.WriteLine("ERROR, NO PUEDES REPETIR LAS LETRAS")
                                                Console.WriteLine()
                                                Console.WriteLine("ADIVINA LA LETRA")
                                                letra = CChar(Console.ReadLine)
                                                Console.WriteLine()
                                                matrizLetras(contador) = letra
                                            End If
                                        Next

                                        If Char.IsLower(letra) Then
                                            Console.WriteLine("ERROR, NO PUEDES INTRODUCIR LETRAS MINÚSCULAS.")
                                            Console.WriteLine()
                                            Console.WriteLine("INTRODUCE UNA LETRA (MAYÚSCULA)")
                                            letra = CChar(Console.ReadLine)
                                            Console.WriteLine()
                                            condicionMayus = True
                                        Else
                                            condicionMayus = False
                                            matrizLetras(contador) = letra
                                        End If

                                    Loop Until condicionMayus = False And letra <> letraRepetida

                                    For o = 0 To palabraIndividual.Length - 1

                                        If letra = palabraIndividual(o) Then
                                            acierto = True
                                            contadorAciertos += 1
                                            matrizLetrasAcertadas(o) = letra
                                            contadorLetrasRepetidas += 1

                                            If contadorLetrasRepetidas = 1 Then
                                                Console.WriteLine("HAS ACERTADO LA LETRA")
                                                Console.WriteLine("")
                                                Console.WriteLine("TE QUEDAN " & vidas1 & " INTENTOS")
                                            End If

                                        End If
                                    Next

                                    If acierto = False Then

                                        contadorFallos += 1
                                        vidas1 -= 1
                                        Console.WriteLine()
                                        Console.WriteLine("NO HAS ACERTADO LA LETRA")
                                        Console.WriteLine()
                                        Console.WriteLine("TE QUEDAN " & vidas1 & " INTENTOS")

                                        If contadorFallos = 1 Then
                                            Console.WriteLine("
 ________
 |/ | 
 | | 
 | o 
 | /|\
 | 
 |
 |
 -------
 ")
                                        End If
                                        If contadorFallos = 2 Then
                                            Console.WriteLine("
 _________
 |/ |
 | |
 | o
 | /|\
 | /
 |
 |
 -------
 ")
                                        End If
                                        If contadorFallos = 3 Then
                                            Console.WriteLine("
 _________
 |/ | 
 | |
 | o
 | /|\
 | / \
 |
 |
 -------
 ")

                                        End If

                                    End If

                                    Console.WriteLine()

                                    For j = 0 To matrizLetrasAcertadas.Length - 1
                                        If Char.IsLetter(matrizLetrasAcertadas(j)) Then
                                            Console.Write(matrizLetrasAcertadas(j))
                                        Else
                                            Console.Write("-")
                                        End If
                                    Next

                                    Console.WriteLine()

                                    If contadorAciertos = palabraIndividual.Length Then
                                        Console.WriteLine()
                                        Console.WriteLine("HAS ACERTADO ! LA PALABRA ERA " & palabraIndividual)
                                        ganar = True
                                    End If

                                    If vidas1 = 0 Then
                                        Console.WriteLine()
                                        Console.WriteLine("HAS PERDIDO :( LA PALABRA ERA " & palabraIndividual)
                                    End If

                                Loop Until ganar = True Or vidas1 = 0

                        End Select

                        Console.WriteLine()
                        Console.WriteLine("Quieres jugar otra vez? {S/N}")
                        repetir = CChar(Console.ReadLine)

                    Loop While repetir = "S"c Or repetir = "s"c

                Case 12

                    Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\alumno\Desktop\hola.txt")
                    Dim contenido As String = lector.ReadToEnd
                    Console.WriteLine(contenido)
                    lector.Close()

                Case 13

                    Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\alumno\Desktop\hola.txt")
                    Dim matriz(99) As String
                    Dim posicion As Integer = 0

                    While Not lector.EndOfStream
                        matriz(posicion) = lector.ReadLine
                        Console.WriteLine("Posición " & posicion & " : " & matriz(posicion))
                        posicion += 1
                    End While

                    lector.Close()

                Case 14

                    My.Computer.FileSystem.WriteAllText("C:\Users\alumno\Desktop\hola.txt", "le añado nuevo contenido al archivo para el ejercicio 14", True)

                    Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\alumno\Desktop\hola.txt")
                    Dim contenido As String = lector.ReadToEnd

                    Console.WriteLine(contenido)
                    lector.Close()

                Case 15

                    Dim rutaTotal, ruta1, ruta2 As String
                    Dim posicíonNombre1, posicionNombre2, posicionPunto1, posicionPunto2, resta1, resta2 As Integer
                    Dim nombre1, nombre2, nombreTotal As String

                    Console.WriteLine("Introduce la ruta del primer archivo")
                    ruta1 = Console.ReadLine
                    Console.WriteLine("Introduce la ruta del segundo archivo")
                    ruta2 = Console.ReadLine

                    'nombre

                    posicíonNombre1 = ruta1.LastIndexOf("\")
                    posicionPunto1 = ruta1.LastIndexOf(".")
                    resta1 = (posicionPunto1 - 1) - posicíonNombre1
                    nombre1 = ruta1.Substring(posicíonNombre1 + 1, resta1)

                    posicionNombre2 = ruta2.LastIndexOf("\")
                    posicionPunto2 = ruta2.LastIndexOf(".")
                    resta2 = (posicionPunto2 - 1) - posicionNombre2
                    nombre2 = ruta2.Substring(posicionNombre2 + 1, resta2)

                    nombreTotal = nombre1 & "-" & nombre2
                    Console.WriteLine()
                    Console.WriteLine("Contenido del archivo : " & nombreTotal)

                    'nuevo archivo

                    rutaTotal = Directory.GetCurrentDirectory() + nombreTotal

                    Dim lectorArchivo1 As StreamReader = My.Computer.FileSystem.OpenTextFileReader(ruta1)
                    Dim contenidoArchivo1 As String = lectorArchivo1.ReadToEnd
                    lectorArchivo1.Close()

                    Dim lectorArchivo2 As StreamReader = My.Computer.FileSystem.OpenTextFileReader(ruta2)
                    Dim contenidoArchivo2 As String = lectorArchivo2.ReadToEnd
                    lectorArchivo2.Close()

                    Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(rutaTotal, True)
                    escritor.WriteLine(contenidoArchivo1)
                    escritor.WriteLine(contenidoArchivo2)
                    escritor.Close()

                    Dim lectorArchivoTotal As StreamReader = My.Computer.FileSystem.OpenTextFileReader(rutaTotal)
                    Dim contenidoArchivoTotal As String = lectorArchivoTotal.ReadToEnd
                    Console.WriteLine(contenidoArchivoTotal)
                    lectorArchivoTotal.Close()

                Case 16

                    Dim opcion As Integer

                    Console.WriteLine("Introduce el apartado del ejercicio : ")
                    Console.WriteLine("1 - Mostrar registros")
                    Console.WriteLine("2 - Insertar nuevO registro")
                    Console.WriteLine("3 - Consultar DNI")
                    Console.WriteLine("4 - Mostrar registros con salario mayor a 2500$")
                    Console.WriteLine("5 - Modificar registro")
                    Console.WriteLine("6 - Eliminar registro")
                    Console.WriteLine("7 - Mostrar registros ordenados con salario de menor a mayor")
                    Console.WriteLine("8 - Historial con todos los cambios")
                    opcion = Convert.ToInt32(Console.ReadLine)

                    Select Case opcion

                        Case 1

                            Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\alumno\Desktop\Clases\Aplicaciones Ofimaticas\archivos visual\registros16.txt")
                            Dim contenido As String = lector.ReadToEnd
                            Console.WriteLine(contenido)
                            lector.Close()

                        Case 2

                            Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\alumno\Desktop\Clases\Aplicaciones Ofimaticas\archivos visual\registros16.txt", True)
                            Console.WriteLine("Introduce un nuevo registro")
                            escritor.WriteLine(Console.ReadLine)
                            escritor.Close()

                        Case 3

                            Dim dni As String
                            Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\alumno\Desktop\Clases\Aplicaciones Ofimaticas\archivos visual\registros16.txt")
                            Dim matrizContenido() As String
                            Dim matrizDni() As String
                            Dim contador As Integer = 0
                            Dim contador2 As Integer = 0
                            Dim condicionDni As Boolean = False

                            Console.WriteLine()
                            Console.WriteLine("Introduce tu DNI para ver si está en los registros")
                            dni = Console.ReadLine

                            While Not lector.EndOfStream
                                ReDim Preserve matrizContenido(contador + 1)
                                matrizContenido(contador) = lector.ReadLine
                                contador += 1
                            End While

                            For i = 0 To matrizContenido.Length - 1
                                ReDim Preserve matrizDni(contador)
                                contador2 += 1
                                matrizDni(i) = matrizContenido(i).Substring(1, 9)

                                If matrizDni(i) = dni Then
                                    condicionDni = True
                                End If

                            Next

                            Console.WriteLine()

                            If condicionDni = True Then
                                Console.WriteLine("Su DNI está almacenado en los registros")
                            Else
                                Console.WriteLine("Su DNI no está almacenado en los registros")
                            End If

                            lector.Close()

                        Case 4

                            Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\alumno\Desktop\Clases\Aplicaciones Ofimaticas\archivos visual\registros16.txt")
                            Dim matrizContenido() As String
                            Dim matrizSalario() As String
                            Dim contador As Integer = 0
                            Dim contador2 As Integer = 0
                            Dim posicion As Integer

                            Console.WriteLine()
                            Console.WriteLine("Registros con salario mayor que 2500$ : ")
                            Console.WriteLine()

                            While Not lector.EndOfStream
                                ReDim Preserve matrizContenido(contador)
                                matrizContenido(contador) = lector.ReadLine
                                contador += 1
                            End While

                            For i = 0 To matrizContenido.Length - 1
                                ReDim Preserve matrizSalario(contador2)
                                posicion = matrizContenido(i).LastIndexOf("?")
                                matrizSalario(i) = matrizContenido(i).Substring(posicion + 1, 4)
                                contador2 += 1

                                If Convert.ToInt32(matrizSalario(i)) > 2500 Then
                                    Console.WriteLine(matrizContenido(i))
                                End If

                            Next

                            lector.Close()

                        Case 5

                            Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\alumno\Desktop\Clases\Aplicaciones Ofimaticas\archivos visual\registros16.txt")
                            Dim matrizContenido(), matrizDni() As String
                            Dim contador As Integer = 0
                            Dim contador2 As Integer = 0
                            Dim dni As String
                            Dim posicion As Integer
                            Dim nuevoSalario As Integer
                            Dim nuevoSalarioString As String

                            Console.WriteLine()
                            Console.WriteLine("Introduce tu DNI")
                            dni = Console.ReadLine

                            While Not lector.EndOfStream
                                ReDim Preserve matrizContenido(contador)
                                matrizContenido(contador) = lector.ReadLine
                                contador += 1
                            End While
                            lector.Close()

                            Console.WriteLine()
                            Console.WriteLine("Registros antes de modificarlos : ")

                            For k = 0 To matrizContenido.Length - 1
                                Console.WriteLine(matrizContenido(k))
                            Next

                            Dim escritor1 As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\alumno\Desktop\Clases\Aplicaciones Ofimaticas\archivos visual\registros16.txt", False)

                            For i = 0 To matrizContenido.Length - 1
                                ReDim Preserve matrizDni(contador2)
                                contador2 += 1
                                matrizDni(i) = matrizContenido(i).Substring(1, 9)

                                If matrizDni(i) = dni Then
                                    Console.WriteLine()
                                    Console.WriteLine("Introduce el nuevo salario")
                                    nuevoSalario = Convert.ToInt32(Console.ReadLine)
                                    nuevoSalarioString = Convert.ToString(nuevoSalario)
                                    posicion = matrizContenido(i).LastIndexOf("?")
                                    matrizContenido(i) = matrizContenido(i).Remove(posicion + 1)
                                    matrizContenido(i) = matrizContenido(i).Insert(posicion + 1, nuevoSalarioString)
                                    escritor1.WriteLine(matrizContenido(i))
                                Else
                                    escritor1.WriteLine(matrizContenido(i))
                                End If

                            Next

                            escritor1.Close()
                            Console.WriteLine()
                            Console.WriteLine("Registros después de modificarlos")

                            For y = 0 To matrizContenido.Length - 1
                                Console.WriteLine(matrizContenido(y))
                            Next

                        Case 6

                            Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\alumno\Desktop\Clases\Aplicaciones Ofimaticas\archivos visual\registros16.txt")
                            Dim matrizContenido(), matrizDni() As String
                            Dim contador As Integer = 0
                            Dim contador2 As Integer = 0
                            Dim dni As String

                            Console.WriteLine()
                            Console.WriteLine("Introduce tu DNI")
                            dni = Console.ReadLine

                            While Not lector.EndOfStream
                                ReDim Preserve matrizContenido(contador)
                                matrizContenido(contador) = lector.ReadLine
                                contador += 1
                            End While

                            lector.Close()
                            Console.WriteLine()
                            Console.WriteLine("Registros antes de modificarlos : ")

                            For i = 0 To matrizContenido.Length - 1
                                Console.WriteLine(matrizContenido(i))
                            Next

                            Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\alumno\Desktop\Clases\Aplicaciones Ofimaticas\archivos visual\registros16.txt", False)

                            For o = 0 To matrizContenido.Length - 1

                                ReDim Preserve matrizDni(contador2 + 1)
                                matrizDni(o) = matrizContenido(o).Substring(1, 9)
                                contador2 += 1

                                If matrizDni(o) = dni Then
                                    matrizContenido(o) = ("")
                                    escritor.WriteLine(matrizContenido(o))
                                Else
                                    escritor.WriteLine(matrizContenido(o))
                                End If
                            Next

                            escritor.Close()
                            Console.WriteLine("")
                            Console.WriteLine("Registros después de la eliminación : ")

                            For n = 0 To matrizContenido.Length - 1
                                Console.WriteLine(matrizContenido(n))
                            Next

                        Case 7

                            Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\alumno\Desktop\Clases\Aplicaciones Ofimaticas\archivos visual\registros16.txt")
                            Dim matrizRegistros() As String
                            Dim matrizSalario() As Integer
                            Dim matrizSalarioOrdenado() As Integer
                            Dim matrizRegistrosOrdenados() As String
                            Dim contador As Integer = 0
                            Dim contador2 As Integer = 0
                            Dim contador3 As Integer = 0
                            Dim posicion As Integer
                            Dim mayor As Integer
                            Dim mayorString As String

                            While Not lector.EndOfStream
                                ReDim Preserve matrizRegistros(contador)
                                matrizRegistros(contador) = lector.ReadLine
                                contador += 1
                            End While

                            lector.Close()
                            Console.WriteLine()
                            Console.WriteLine("Registros sin ordenar : ")

                            For i = 0 To matrizRegistros.Length - 1
                                Console.WriteLine(matrizRegistros(i))
                            Next

                            For n = 0 To matrizRegistros.Length - 1
                                ReDim Preserve matrizSalario(contador2)
                                posicion = matrizRegistros(n).LastIndexOf("?")
                                matrizSalario(n) = CInt(matrizRegistros(n).Substring(posicion + 1, 4))
                                contador2 += 1
                            Next

                            For r = 0 To matrizSalario.Length - 1
                                ReDim Preserve matrizRegistrosOrdenados(contador3)
                                ReDim Preserve matrizSalarioOrdenado(contador3)
                                contador3 += 1
                            Next

                            For b = 0 To matrizSalario.Length - 1
                                For f = b + 1 To matrizSalario.Length - 1
                                    If matrizSalario(b) > matrizSalario(f) Then
                                        mayor = matrizSalario(b)
                                        matrizSalario(b) = matrizSalario(f)
                                        matrizSalario(f) = mayor

                                        mayorString = matrizRegistros(b)
                                        matrizRegistros(b) = matrizRegistros(f)
                                        matrizRegistros(f) = mayorString
                                    End If
                                Next
                            Next

                            Dim matrizSalarioString(matrizSalario.Length - 1) As String

                            For v = 0 To matrizSalario.Length - 1
                                matrizSalarioString(v) = Convert.ToString(matrizSalario(v))
                            Next

                            For y = 0 To matrizSalarioString.Length - 1
                                posicion = matrizRegistros(y).LastIndexOf("?")
                                matrizRegistros(y) = matrizRegistros(y).Remove(posicion + 1)
                                matrizRegistros(y) = matrizRegistros(y).Insert(posicion + 1, matrizSalarioString(y))
                            Next

                            Dim escritorr As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\alumno\Desktop\Clases\Aplicaciones Ofimaticas\archivos visual\registros16.txt", False)

                            For g = 0 To matrizRegistros.Length - 1
                                escritorr.WriteLine(matrizRegistros(g))
                            Next

                            escritorr.Close()
                            Console.WriteLine()
                            Console.WriteLine("Registros ordenados : ")
                            Dim lector2 As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\alumno\Desktop\Clases\Aplicaciones Ofimaticas\archivos visual\registros16.txt")

                            While Not lector2.EndOfStream
                                Console.WriteLine(lector2.ReadLine())
                            End While
                            lector2.Close()

                        Case 8

                            Dim opcionEscribir As Integer
                            Dim contenido As String
                            Dim numeroString As String
                            Dim numero As Integer
                            Dim repetir2 As Char

                            Do
                                Console.WriteLine("Como quieres escribir ?")
                                Console.WriteLine()
                                Console.WriteLine("1 - Sin sobrescritura")
                                Console.WriteLine("2 - Con sobrescritura")
                                opcionEscribir = CInt(Console.ReadLine)

                                Select Case opcionEscribir
                                    Case 1
                                        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\alumno\Documents\GitHub\EJERCICIOS-VISUAL\TEMA 7\Boletin8_Cadenas\Boletin8_Cadenas\bin\registrosOcho.txt")
                                        contenido = lector.ReadToEnd
                                        lector.Close()

                                        Dim lectorNumero As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\alumno\Documents\GitHub\EJERCICIOS-VISUAL\TEMA 7\Boletin8_Cadenas\Boletin8_Cadenas\bin\numeros.txt")
                                        numero = CInt(lectorNumero.ReadToEnd)
                                        lectorNumero.Close()
                                        numero = numero + 1
                                        Dim escritorNumero As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\alumno\Documents\GitHub\EJERCICIOS-VISUAL\TEMA 7\Boletin8_Cadenas\Boletin8_Cadenas\bin\numeros.txt", False)
                                        escritorNumero.WriteLine(numero)
                                        escritorNumero.Close()
                                        numeroString = Convert.ToString(numero)

                                        Dim rutaCopia As String = Directory.GetCurrentDirectory() + numeroString
                                        Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(rutaCopia, True)
                                        escritor.WriteLine(contenido)
                                        escritor.Close()

                                        Dim escritor1 As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\alumno\Documents\GitHub\EJERCICIOS-VISUAL\TEMA 7\Boletin8_Cadenas\Boletin8_Cadenas\bin\registrosOcho.txt", True)
                                        Console.WriteLine("Escribe lo que quieras")
                                        escritor1.WriteLine()
                                        escritor1.WriteLine(Console.ReadLine)
                                        escritor1.Close()

                                    Case 2

                                        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\alumno\Documents\GitHub\EJERCICIOS-VISUAL\TEMA 7\Boletin8_Cadenas\Boletin8_Cadenas\bin\registrosOcho.txt")
                                        contenido = lector.ReadToEnd
                                        lector.Close()

                                        Dim lectorNumero As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\alumno\Documents\GitHub\EJERCICIOS-VISUAL\TEMA 7\Boletin8_Cadenas\Boletin8_Cadenas\bin\numeros.txt")
                                        numero = CInt(lectorNumero.ReadToEnd)
                                        lectorNumero.Close()
                                        numero = numero + 1
                                        Dim escritorNumero As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\alumno\Documents\GitHub\EJERCICIOS-VISUAL\TEMA 7\Boletin8_Cadenas\Boletin8_Cadenas\bin\numeros.txt", False)
                                        escritorNumero.WriteLine(numero)
                                        escritorNumero.Close()
                                        numeroString = Convert.ToString(numero)

                                        Dim rutaCopia As String = Directory.GetCurrentDirectory() + numeroString
                                        Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(rutaCopia, False)
                                        escritor.WriteLine(contenido)
                                        escritor.Close()

                                        Dim escritor1 As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\alumno\Documents\GitHub\EJERCICIOS-VISUAL\TEMA 7\Boletin8_Cadenas\Boletin8_Cadenas\bin\registrosOcho.txt", False)
                                        Console.WriteLine("Escribe lo que quieras")
                                        escritor1.WriteLine(Console.ReadLine)
                                        escritor1.Close()

                                End Select

                                Console.WriteLine("Quieres volver a escribir ? {S/N}")
                                repetir2 = CChar(Console.ReadLine)

                            Loop While repetir2 = "S"c Or repetir2 = "s"c

                    End Select

            End Select

            Console.WriteLine()
            Console.WriteLine("Quieres ejecutar otro ejercicio ? {S/N]")
            continuar = CChar(Console.ReadLine)

        Loop While continuar = "s"c Or continuar = "S"c


    End Sub

End Module
