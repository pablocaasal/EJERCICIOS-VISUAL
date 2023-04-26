Public Class ejercicio1
    Private Sub btnPulsar_Click(sender As Object, e As EventArgs) Handles btnPulsar.Click
        Dim nombre, correo As String

        nombre = txtNombre.Text
        correo = txtCorreo.Text

        MessageBox.Show("Nombre : " & nombre & " // Correo : " & correo)
    End Sub
End Class