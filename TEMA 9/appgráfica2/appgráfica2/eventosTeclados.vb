Public Class eventosTeclados
    Private Sub eventosTeclados_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim caraacter As String = e.KeyValue.ToString
        Label1.Text += " " & caraacter
        Label2.Text += " " & Convert.ToChar(e.KeyValue)


    End Sub

    Private Sub eventosTeclados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub
End Class