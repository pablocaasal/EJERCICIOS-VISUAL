Public Class ejercicio2
    Dim dia, año As String
    Dim mes As Integer
    Dim fechaCompleta As String
    Dim fecha As Date


    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        dia = txtDía.Text
        mes = Convert.ToInt32(txtMes.Text)

        año = txtAño.Text
        fechaCompleta = dia & " de " & mes & " de " & año
        txtFecha.Text = fechaCompleta

    End Sub
End Class