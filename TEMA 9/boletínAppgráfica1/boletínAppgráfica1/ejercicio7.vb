Public Class ejercicio7
    Private Sub btnConvertirDollar_Click(sender As Object, e As EventArgs) Handles btnConvertirDollar.Click
        Dim euros, dolares As Double

        Try
            If txtEuros.Text = "" Then
                MessageBox.Show("Error al introducir los datos", "Error")
                txtEuros.BackColor = Color.Red
                txtEuros.Select()
            Else
                euros = Convert.ToDouble(txtEuros.Text)
                dolares = euros * 1.1
                txtDollars.Text = Convert.ToString(dolares)
                txtEuros.BackColor = Color.White
            End If

        Catch ex As Exception
            MessageBox.Show("El valor debe ser numérico")
            txtEuros.BackColor = Color.White
            txtEuros.Select()
        End Try
    End Sub

    Private Sub btnConvertirEuros_Click(sender As Object, e As EventArgs) Handles btnConvertirEuros.Click
        Dim euros, dolares As Double

        Try
            If txtDollars.Text = "" Then
                MessageBox.Show("Error al introducir los datos", "Error")
                txtDollars.BackColor = Color.Red
                txtDollars.Select()
            Else
                dolares = Convert.ToDouble(txtDollars.Text)
                euros = dolares / 1.1
                txtEuros.Text = Convert.ToString(euros)
                txtDollars.BackColor = Color.White
            End If

        Catch ex As Exception
            MessageBox.Show("El valor debe ser numérico")
            txtDollars.BackColor = Color.White
            txtDollars.Select()
        End Try
    End Sub

    Private Sub txtEuros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEuros.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnConvertirDollar.PerformClick()
        End If
    End Sub

    Private Sub txtDollars_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDollars.KeyPress
        If Convert.ToChar(e.KeyChar) = Convert.ToChar(Keys.Enter) Then
            btnConvertirEuros.PerformClick()
        End If
    End Sub
End Class