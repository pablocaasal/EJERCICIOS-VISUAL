Module Module10
    Sub Main()
        'ejercicio 28 copia array sin función 

        Dim array(4) As Integer
        Dim copiaArray(4) As Integer

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduce el valor de la posición " & i)
            array(i) = Convert.ToInt32(Console.ReadLine)
            copiaArray(i) = array(i)
        Next

        Console.WriteLine(" ")
        Console.WriteLine("---------------------------------")
        Console.WriteLine("ARRAY ORIGINAL")

        For m = 0 To array.Length - 1
            Console.WriteLine("El valor de la posición " & m & " es " & array(m))
        Next

        Console.WriteLine("---------------------------------")
        Console.WriteLine(" ")
        Console.WriteLine("---------------------------------")
        Console.WriteLine("COPIA ARRAY")

        For n = 0 To copiaArray.Length - 1
            Console.WriteLine("El valor de la posición " & n & " es " & copiaArray(n))
        Next

        Console.WriteLine("---------------------------------")

        Console.ReadLine()
    End Sub

End Module
