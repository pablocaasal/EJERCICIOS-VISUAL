Imports System

Module Program
    Sub Main(args As String())

        Dim lista As ArrayList = New ArrayList()
        Dim apartado As Integer
        Dim continuar As Char

        Do
            Console.Write("Introduce el apartado que quieres ejecutar")
            apartado = Convert.ToInt32(Console.ReadLine)

            Select Case apartado
                Case 1

                    Dim random As New Random

                    For i = 0 To lista.Capacity - 1
                        lista.Add(random.Next(-10, 11))
                    Next

                    For Each num In lista
                        Console.WriteLine(num)
                    Next

            End Select

            Console.WriteLine("Quieres ejecutar otro apartado ? {S/N}")
            continuar = CChar(Console.ReadLine)

        Loop Until continuar = "n"c Or continuar = "N"c
    End Sub
End Module
