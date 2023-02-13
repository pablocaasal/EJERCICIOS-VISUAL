Imports System.IO
Module Module1

    Sub Main()

        'explicación leer y guardar contenido en archivos, primero importar : Imports Sytem.IO

        'LEER TODO EL CONTENIDO DE UN ARCHIVO : CREAR EL LECTOR CON LA RUTA DEL ARCHIVO

        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\alumno\Desktop\hola.txt")
        Dim contenido As String = lector.ReadToEnd
        Console.WriteLine(contenido)
        lector.Close() ' acordarse de cerrar el lector

        'LEER LINEA POR LINEA EL CONTENIDO DE UN ARCHIVO : CREAR OTRO LECTOR CN LA RUTA

        Dim lector2 As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\alumno\Desktop\hola.txt")

        While Not lector2.EndOfStream
            Dim linea As String = lector2.ReadLine
            Console.WriteLine(linea)
        End While

        lector2.Close()

        'ESCRIBIR EN UN ARCHIVO (sobrecarga true --> agrega contenido al fichero    sobrecarga false --> sobresescribe el contenido del fichero

        Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\alumno\Desktop\escribir.txt", True)
        escritor.WriteLine("Esto lo he escrito desde visual")
        escritor.WriteLine("goul")
        escritor.Close() ' acordarse de cerrar el escritor

        Dim lector3 As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\alumno\Desktop\escribir.txt")
        Dim contenido3 As String = lector3.ReadToEnd
        Console.WriteLine(contenido3)
        lector3.Close()

        'OTRA FORMA DE ESCRIBIR EN UN ARCHIVO, no hace falta cerrar el escritor, lo hace auto

        My.Computer.FileSystem.WriteAllText("C:\Users\alumno\Desktop\escribir.txt", "esto es el texto", True)

        Dim lector4 As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\alumno\Desktop\escribir.txt")
        Dim contenido4 As String = lector4.ReadToEnd
        Console.WriteLine(contenido4)

        'RUTA A LA CARPETA DEBUG, DONDE SE VA A GUARDAR LOS ARCHIVOS (busca el archivo, si no lo encuenta lo crea)

        Dim ruta As String = Directory.GetCurrentDirectory() + "\negocio.txt"
        Console.WriteLine(ruta)

        Dim escritor5 As New StreamWriter(ruta, True)
        escritor5.WriteLine("Esta línea está escrita por mi")
        escritor5.Close()

        Dim lector5 As StreamReader = My.Computer.FileSystem.OpenTextFileReader(ruta)
        Dim contenido5 As String = lector5.ReadToEnd
        Console.WriteLine(contenido5)



        Console.ReadLine()
    End Sub

End Module
