Public Class ejercicio6
    Private Sub btnConvertirAF_Click(sender As Object, e As EventArgs) Handles btnConvertirAF.Click
        Dim centigrados, fahrenheit As Double

        Try
            If txtCentigrados.Text = "" Then
                MessageBox.Show("Error al introducir los datos")
                txtCentigrados.BackColor = Color.Red
                txtCentigrados.Focus()
            Else
                centigrados = Convert.ToDouble(txtCentigrados.Text)
                fahrenheit = (centigrados * 1.8) + 32
                txtFahrenheit.Text = Convert.ToString(fahrenheit)
                txtCentigrados.BackColor = Color.White
            End If
        Catch ex As Exception
            MessageBox.Show("El valor debe ser numérico")
            txtCentigrados.BackColor = Color.Red
            txtCentigrados.Focus()
        End Try
    End Sub

    Private Sub btnConvertirAC_Click(sender As Object, e As EventArgs) Handles btnConvertirAC.Click
        Dim centigrados, fahrenheit As Double

        Try
            If txtFahrenheit.Text = "" Then
                MessageBox.Show("Error al introducir los datos")
                txtFahrenheit.BackColor = Color.Red
                txtFahrenheit.Focus()
            Else
                fahrenheit = Convert.ToDouble(txtFahrenheit.Text)
                centigrados = (fahrenheit - 32) / 1.8
                txtCentigrados.Text = Convert.ToString(centigrados)
                txtFahrenheit.BackColor = Color.White
            End If
        Catch ex As Exception
            MessageBox.Show("El valor debe ser numérico")
            txtFahrenheit.BackColor = Color.Red
            txtFahrenheit.Focus()
        End Try
    End Sub

    Private Sub txtFahrenheit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFahrenheit.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnConvertirAC.PerformClick()
        End If

    End Sub

    Private Sub txtCentigrados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCentigrados.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnConvertirAF.PerformClick()
        End If
    End Sub


End Class