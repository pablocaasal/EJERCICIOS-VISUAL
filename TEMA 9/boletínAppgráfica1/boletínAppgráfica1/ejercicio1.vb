Public Class ejercicio1
    Private Sub btnPulsar_Click(sender As Object, e As EventArgs) Handles btnPulsar.Click
        Dim nombre, correo As String

        If txtNombre.Text = "" Or txtCorreo.Text = "" Then
            MessageBox.Show("Error al introducir los datos")
            txtCorreo.BackColor = Color.Red
            txtNombre.BackColor = Color.Red
        Else
            nombre = txtNombre.Text
            correo = txtCorreo.Text
            MessageBox.Show("Nombre : " & nombre & " // Correo : " & correo)
            txtCorreo.BackColor = Color.White
            txtNombre.BackColor = Color.White
        End If

    End Sub
End Class