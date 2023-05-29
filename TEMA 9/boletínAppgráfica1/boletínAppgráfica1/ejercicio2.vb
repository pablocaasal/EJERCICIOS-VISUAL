Public Class ejercicio2
    Dim dia, año, mesNum As Integer
    Dim mes As String
    Dim fechaCompleta As String
    Dim fecha As Date

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtDía.Clear()
        txtMes.Clear()
        txtAño.Clear()
        txtFecha.Clear()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        ejercicio2.ActiveForm.Close()
    End Sub
    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Try
            dia = Convert.ToInt32(txtDía.Text)
            mesNum = Convert.ToInt32(txtMes.Text)
            mes = Convert.ToString(MonthName(mesNum))
            año = Convert.ToInt32(txtAño.Text)
            fechaCompleta = dia & " de " & mes & " de " & año
            txtFecha.Text = fechaCompleta
        Catch ex As Exception
            MessageBox.Show("El valor debe ser numérico")
        End Try


    End Sub
End Class