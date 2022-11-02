Module Module7
    Sub MAIN()
        'EJERCICIO 7
        Dim numero, contador, resultado As Integer

        Console.WriteLine("Introduzca un número")
        numero = Convert.ToInt32(Console.ReadLine)
        Console.WriteLine("---------------------------------")
        contador = 0

        While contador <= 10
            resultado = numero * contador
            Console.WriteLine(resultado)
            contador += 1
        End While
        Console.ReadLine()

    End Sub
End Module
