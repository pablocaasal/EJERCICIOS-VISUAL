Module CasalPabloEjercicio2

    Sub Main()
        Dim salarioNeto, salarioBruto, tasa, horasTrabajadas As Double
        Console.WriteLine("Introduce las horas trabajadas")
        horasTrabajadas = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Introduce la tasa por hora")
        tasa = Convert.ToDouble(Console.ReadLine)

        If horasTrabajadas < 26 Then
            salarioBruto = horasTrabajadas * tasa
        ElseIf horasTrabajadas < 36 Then
            salarioBruto = tasa * 25 + ((horasTrabajadas - 25) * (tasa + (tasa * 0.5)))
        ElseIf horasTrabajadas > 35 Then
            Dim horasExtra2 = horasTrabajadas - 35
            salarioBruto = tasa * 25 + ((horasTrabajadas - 25 - horasExtra2) * (tasa + (tasa * 0.5))) + ((horasTrabajadas - 35) * (tasa + (tasa * (75 / 100))))
        End If

        If salarioBruto < 1000 Then
            salarioNeto = salarioBruto - (salarioBruto * (10 / 100))
        ElseIf salarioBruto < 1500 Then
            salarioNeto = salarioBruto - (salarioBruto * (15 / 100))
        ElseIf salarioBruto < 1800 Then
            salarioNeto = salarioBruto - (salarioBruto * (25 / 100))
        ElseIf salarioBruto >= 1800 Then
            salarioNeto = salarioBruto - (salarioBruto * (30 / 100))
        End If

        Console.WriteLine("El salario bruto es " & salarioBruto)
        Console.WriteLine("El salario neto es " & salarioNeto)
        Console.ReadLine()
    End Sub

End Module
