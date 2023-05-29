Public Class ejercicio4
    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim hora As Double

        Try
            If txtHoras.Text = "" Then
                MessageBox.Show("Error al introducir los datos")
                txtHoras.BackColor = Color.Red
            Else
                hora = Convert.ToDouble(txtHoras.Text)
                txtMin.Text = Convert.ToString(hora * 60)
                txtSec.Text = Convert.ToString(hora * 3600)
                txtHoras.BackColor = Color.White
            End If
        Catch ex As Exception
            MessageBox.Show("El valor debe ser numérico")
            txtHoras.BackColor = Color.Red
        End Try

    End Sub


End Class