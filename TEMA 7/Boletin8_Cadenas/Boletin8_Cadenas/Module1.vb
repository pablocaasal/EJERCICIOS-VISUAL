Module Module1

    Sub Main()
        Dim ejercicio As Integer
        Dim continuar As Char

        Do

            Console.WriteLine("Introduce el ejericio que quieres ejecutar")
            ejercicio = Convert.ToInt32(Console.ReadLine)

            Select Case ejercicio

                Case 1
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

                Case 2

                    Dim dni As String

                    Console.WriteLine("Introduce tu DNI")
                    dni = Console.ReadLine




            End Select

            Console.WriteLine("Quieres ejecutar otro ejercicio ? {S/N]")
            continuar = CChar(Console.ReadLine)

        Loop While continuar = "s"c Or continuar = "S"c


    End Sub

End Module
