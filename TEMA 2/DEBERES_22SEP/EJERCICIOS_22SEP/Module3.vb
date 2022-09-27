Module Module3
    Sub Main()
        'EJERCICIO 10 BOLETIN 2
        Dim horasTrabajadas As Double
        Dim tasaxhora As Double
        Dim irpf As Double
        Dim salarioBruto As Double
        Dim salarioNeto As Double


        horasTrabajadas = Convert.ToDouble(InputBox("Introduzca las horas trabajadas en un mes"))
        tasaxhora = Convert.ToDouble(InputBox("Indtroduzca la tasa que se paga por hora"))
        irpf = Convert.ToDouble(InputBox("Introduzca el IRPF"))

        salarioBruto = horasTrabajadas * tasaxhora

        salarioNeto = salarioBruto - (salarioBruto * (irpf / 100))

        Console.WriteLine("El salario bruto es: " & salarioBruto & " y el salario neto es: " & salarioNeto)
        Console.ReadLine()

    End Sub
End Module
