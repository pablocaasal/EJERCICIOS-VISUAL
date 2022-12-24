Module Module1

    Sub Main()
        Dim numJugadores As Integer
        Console.WriteLine("1 - Modo 1 jugador")
        Console.WriteLine("2 - Modo 2 jugadores")
        numJugadores = Convert.ToInt32(Console.ReadLine)
        Console.Clear()

        Select Case numJugadores
            Case 1
            Case 2
                Dim nombreJugador1, nombreJugador2 As String
                Console.WriteLine("Jugador 1 : Introduce el nombre de tu personaje")
                nombreJugador1 = Console.ReadLine
                Console.WriteLine("Jugador 2 : Introduce el nombre de tu personaje")
                nombreJugador2 = Console.ReadLine
                Console.Clear()

                'salud, ataque, velocidad, resistencia y sanación (sanadora)
                Dim estadistícasTanque() As Integer = {50, 15, 5, 15}
                Dim estadistícasCaballero() As Integer = {40, 10, 10, 30}
                Dim estadistícasEspadachin() As Integer = {30, 10, 20, 40}
                Dim estadistícasMago() As Integer = {25, 15, 15, 30}
                Dim estadistícasSanadora() As Integer = {20, 5, 15, 35, 5}

                Dim claseJugador1 As Integer

                Console.WriteLine("                          ---------------------------------------------------------------")
                Console.WriteLine("                          |                     Escoge una clase                        |")
                Console.WriteLine("                          ---------------------------------------------------------------")
                Console.WriteLine("")
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------")
                Console.WriteLine("1 - TANQUE :")
                Console.WriteLine("")
                Console.WriteLine("-El clásico tanque, salud y ataque elevados, baja velocidad y resistencia. Cuenta con una espada larga y escudo grande. ")
                Console.WriteLine("")
                Console.WriteLine("-Baja probabilidad de generar un escudo protector que hace al tanque invulnerable al siguiente ataque.")
                Console.WriteLine("")
                Console.WriteLine("-Habilidad Especial : Terremoto --> El tanque golpea el suelo con su escudo y genera un terremoto a sus alrededores. ")
                Console.WriteLine("                                    que desestabiliza a los enemigos y les quita 10 de resistencia.")
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------")
                Console.WriteLine("2 - CABALLERO :      ")
                Console.WriteLine("     ")
                Console.WriteLine("-Clase equilibrada, perfecta para noobs. Cuenta con una espada mediana y escudo mediano.    ")
                Console.WriteLine("     ")
                Console.WriteLine("-Probabilidad moderada de que la espada del caballero se impregne de fuego espectral")
                Console.WriteLine(" y le robe al enemigo un punto de salud que se añadirá a la barra de salud")
                Console.WriteLine("")
                Console.WriteLine("-Habilidad Especial : Danza de Espadas --> Invoca un grupo de espadas mágicas que giran alrededor del caballero")
                Console.WriteLine("                                           y lo protegen de los enemigos. ")
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------")
                Console.WriteLine("3 - ESPADACHÍN :                      ")
                Console.WriteLine("")
                Console.WriteLine("-Clase perfecta para aquellos que quieren un estilo de juego rápido. Salud y ataque moderado. Resistencia alta.")
                Console.WriteLine("")
                Console.WriteLine("-Lucha con espadas dobles pequeñas")
                Console.WriteLine("")
                Console.WriteLine("-Probabilidad moderada de que cuando el espadachín ataque le de tiempo a esquivar y asestar otro ataque.")
                Console.WriteLine("")
                Console.WriteLine("-Habilidad Especial : Esquiva Rápida --> Permite al espadachín realizar una esquiva rápida")
                Console.WriteLine("                                         y situarse en la espalda del enemigo para matarlo.")
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------")
                Console.WriteLine("4 - MAGO")
                Console.WriteLine("")
                Console.WriteLine("")




                Select Case claseJugador1



                End Select






                Console.WriteLine("")
                Console.WriteLine("*                 *            *             *")
                Console.WriteLine("      *                                                  *")
                Console.WriteLine("                        *             *                              *")
                Console.WriteLine("  *           *                                  *")
                Console.WriteLine("                             _                     *                        *")
                Console.WriteLine("       *           *        / \       *                        *")
                Console.WriteLine("                           /   \       ")
                Console.WriteLine("                *         /     \            *            *             *")
                Console.WriteLine("         *               /       \   ")
                Console.WriteLine(" *                      /    _    \                  *              * ")
                Console.WriteLine("             *         /    (_)    \          *               *  ")
                Console.WriteLine("                      /             \   ")
                Console.WriteLine("                     /               \  ")
                Console.WriteLine("                    /                 \  ")
                Console.WriteLine("                   /___________________\")
                Console.WriteLine("                  /                     \ ")
                Console.WriteLine("                  \_____________________/ ")
                Console.WriteLine("                   |    |         |    | ")
                Console.WriteLine("                   |    |  _____  |    | ")
                Console.WriteLine("                   |____| /     \ |____|")
                Console.WriteLine("                   |    | |     | |    | ")
                Console.WriteLine("                   |    | |     | |    | ")
                Console.WriteLine("                   |____| |     | |____| ")
                Console.WriteLine("                   |    | \_____/ |    |                                              ")
                Console.WriteLine("                   |    |         |    |                                              ")
                Console.WriteLine("                   |____|  _____  |____|                                              ")
                Console.WriteLine("                   |    | /     \ |    |                                              ")
                Console.WriteLine("                   |    | |     | |    |                                              ")
                Console.WriteLine("                   |____| |     | |____|                                              ")
                Console.WriteLine("                   |    | |     | |    |                                              ")
                Console.WriteLine("                   |    | | | | | |    |                                              ")
                Console.WriteLine("___________________|____| |_____| |____|__________________________________________________________________________")
                Console.WriteLine("")
                Console.WriteLine("                         !DIOS MIO!")
                Console.WriteLine("")
                Console.WriteLine("Parece que de camino a tu objetivo has encontrado La Gran Torre.")
                Console.WriteLine("")
                Console.WriteLine("Las leyendas no se equivocaban al decir que llegaba hasta los mismísimos cielos.                                                                 ")
                Console.WriteLine("")
                Console.WriteLine("Hasta da pena dejar de mirarla, es un gusto para la vista.")
                Console.WriteLine("")
                Console.WriteLine("Basta de perder el tiempo, ha llegado la hora de tomar una decisión.")
                Console.WriteLine("")
                Console.WriteLine("(Para entrar en el tutorial de |TOMA DE DECISIONES| escriba <S>")

                Dim tutorialDecisiones As Char
                tutorialDecisiones = Console.ReadLine

                If tutorialDecisiones = "S"c Or tutorialDecisiones = "s"c Then
                    Console.WriteLine("")
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------")
                    Console.WriteLine("TURORIAL : TOMA DE DECISIONES")
                    Console.WriteLine("")
                    Console.WriteLine("Tomar decisiones es una parte importante de este juego")
                    Console.WriteLine("")
                    Console.WriteLine("A lo largo de tu aventura en El Reino del Horror tendrás que tomar decisiones que afectaran al rumbo de tu partida")
                    Console.WriteLine("")
                    Console.WriteLine("Escoge con cabeza, solo Dios sabe que algunas veces el camino facil resulta ser el más complicado ")
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------")
                    Console.ReadLine()
                End If

                Console.WriteLine("Queridos aventureros, teneis 3 opciones")
                Console.WriteLine("")
                Dim opcionTorre1 As Integer
                Console.WriteLine("1 - Entrar por la puerta de La Torre")
                Console.WriteLine("2 - Escalar y entrar por la ventana de La Torre")
                Console.WriteLine("3 - No entrar en la torre y seguir tu camino")
                Console.WriteLine("")
                opcionTorre1 = Convert.ToInt32(Console.ReadLine)

                Select Case opcionTorre1
                    Case 1
                        Console.WriteLine(nombreJugador1 & " y " & nombreJugador2 & " se detienen delante de la puerta.")
                        Console.ReadLine()
                        Console.WriteLine("Acto seguido arrastran la enorme puerta con todas sus fuerzas hasta conseguir abrirla del todo.")
                        Console.ReadLine()
                        Console.WriteLine("El ruido de las visagras chirriando ha alertado a los magos de La Gran Torre, que se dirigen hacía " & nombreJugador1 & " y " & nombreJugador2 & " furiosos.")
                        Console.ReadLine()
                        Console.WriteLine("En un instante tendrán a todos los enemigos encima suya. Que decidirán hacer?")
                        Console.WriteLine("")
                        Dim opcionTorre2 As Integer
                        Console.WriteLine("1 - Quedarse y luchar")
                        Console.WriteLine("2 - Huir y cerrar la puerta")
                        opcionTorre2 = Convert.ToInt32(Console.ReadLine)

                        Select Case opcionTorre2
                            Case 1
                            Case 2

                        End Select

                    Case 2
                        Console.WriteLine("              /\\")
                        Console.WriteLine("             /  \\")
                        Console.WriteLine("            /    \\                                 ")
                        Console.WriteLine("           /      \\              "" ""                          ")
                        Console.WriteLine("         _/________\\_                                      ")
                        Console.WriteLine("          | \   /  |                 ""                      ")
                        Console.WriteLine("          |   O    |                    ""                        ")
                        Console.WriteLine("          |  <     |                   ""                 ")
                        Console.WriteLine("           \ /-\  /                                            ")
                        Console.WriteLine("            |----|                   ""         ")
                        Console.WriteLine("  _________/      \_________        __            ")
                        Console.WriteLine("  |   __    ______    __   |       /_/                    ")
                        Console.WriteLine("  |  |  |   \    /   |  |  |      / /                                 ")
                        Console.WriteLine("  |  |  |    \  /    |  |  |     / /                                  ")
                        Console.WriteLine("  |  |  |     \/     |  |  |    / /                                 ")
                        Console.WriteLine("  |  |  |            |  |  |   / /                                  ")
                        Console.WriteLine(" _|  |_ |            | _|  |_ / /                                    ")
                        Console.WriteLine("| | | | |            | | | ||/ /          ")
                        Console.WriteLine("|_|_|/  |            | |_|_|/_/          ")
                        Console.WriteLine("        |____________|                                         ")
                        Console.WriteLine("        |     _      |               ")
                        Console.WriteLine("        |     ||     |               ")
                        Console.WriteLine("        |     ||     |               ")
                        Console.WriteLine("        |     ||     |               ")
                        Console.WriteLine("        |     ||     |               ")
                        Console.WriteLine("        |     ||     |               ")
                        Console.WriteLine("        |     ||     |               ")
                        Console.WriteLine("        |\/\/\||/\/\/|               ")
                        Console.WriteLine("        |_____||_____|               ")

                    Case 3

                End Select

                Console.ReadLine()
        End Select

    End Sub

End Module
