Module OpLógicos
    Sub Main()
        'operadores logicos---- AND, OR, NOT
        'AND ---- y LOGICO--- DEVUELVE TRUE SI LAS DOS CONDICIONES SON TRUE
        Dim X As Boolean = True
        Dim Y As Boolean = False

        Dim condicionAND As Boolean = X And Y
        Dim condicionand2 As Boolean = True And False
        Dim CONDICIONand3 As Boolean = False And True
        Dim condicionAND4 As Boolean = False And False

        'OR--- DEVUELVE TRUE SI una de las condiciones es true
        'Los niños deben llevar silla si son son menores de 8 años o miden menos de 1.35m
        Dim altura As Single = 1.2
        Dim edad As Byte = 8
        Dim silla As Boolean = altura < 1.35 Or edad < 8
        Console.WriteLine("SILLA: " & silla)
        Console.ReadLine()

        'oPERADOR nOT --- DEVUELVE LO CONTRARIO DE LO QUE TIENE A SU DERECHA 
        'pROGRAMA QUE LEE UN NUMERO Y LA CONDICIÓN ES TRUE SI NO ES PAR
        Dim NUMERo As Integer
        Dim imPAR As Boolean
        Console.WriteLine("iNTRODUZCA UN NÚMERO PAR")
        NUMERo = Convert.ToInt32(Console.ReadLine())

        imPAR = Not NUMERo Mod 2 = 0
        'IMPAR = NUMERO IMPAR Mod 2 <> 0
        Console.WriteLine(NUMERo & "impar?" & imPAR)
        Console.ReadLine()





    End Sub
End Module
