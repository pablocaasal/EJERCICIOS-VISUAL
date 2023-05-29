Public Class ejercicio3
    Private Sub btnCuadrado_Click(sender As Object, e As EventArgs) Handles btnCuadrado.Click

        Try
            If txtValorCuadrado.Text = "" Then
                MessageBox.Show("Error cubriendo los datos")
                txtValorCuadrado.BackColor = Color.Red
            Else
                Dim areaCaudrado As Integer = Convert.ToInt32(txtValorCuadrado.Text) * Convert.ToInt32(txtValorCuadrado.Text)
                lblValorResultado.Text = "Resultado : " & areaCaudrado.ToString
                txtValorCuadrado.BackColor = Color.White
            End If

        Catch ex As Exception
            MessageBox.Show("El valor debe ser numérico")
            txtValorCuadrado.BackColor = Color.Red
        End Try

    End Sub

    Private Sub btnRectangulo_Click(sender As Object, e As EventArgs) Handles btnRectangulo.Click

        Try
            If txtValorRectanguloMayor.Text = "" Or txtValorRectanguloMenor.Text = "" Then
                MessageBox.Show("Error cubriendo los datos")
                txtValorRectanguloMayor.BackColor = Color.Red
                txtValorRectanguloMenor.BackColor = Color.Red
            Else
                Dim areaRectangulo As Integer = Convert.ToInt32(txtValorRectanguloMayor.Text) * Convert.ToInt32(txtValorRectanguloMenor.Text)
                lblValorResultado.Text = "Resultado : " & areaRectangulo.ToString
                txtValorRectanguloMayor.BackColor = Color.White
                txtValorRectanguloMenor.BackColor = Color.White
            End If

        Catch ex As Exception
            MessageBox.Show("El valor debe ser numérico")
            txtValorRectanguloMayor.BackColor = Color.Red
            txtValorRectanguloMenor.BackColor = Color.Red
        End Try


    End Sub

    Private Sub btnTriangulo_Click(sender As Object, e As EventArgs) Handles btnTriangulo.Click

        Try
            If txtValorTrianguloBase.Text = "" Or txtValorTrianguloAlt.Text = "" Then
                MessageBox.Show("Error cubriendo los datos")
                txtValorTrianguloBase.BackColor = Color.Red
                txtValorTrianguloAlt.BackColor = Color.Red
            Else
                Dim areaTriangulo As Double = (Convert.ToDouble(txtValorTrianguloBase.Text) * Convert.ToDouble(txtValorTrianguloAlt.Text)) / 2
                lblValorResultado.Text = "Resultado : " & areaTriangulo.ToString
                txtValorTrianguloBase.BackColor = Color.White
                txtValorTrianguloAlt.BackColor = Color.White
            End If

        Catch ex As Exception
            MessageBox.Show("El valor debe ser numérico")
            txtValorTrianguloBase.BackColor = Color.Red
            txtValorTrianguloAlt.BackColor = Color.Red
        End Try

    End Sub
End Class