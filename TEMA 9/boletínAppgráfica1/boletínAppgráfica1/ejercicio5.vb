Public Class ejercicio5
    Private Sub ejercicio5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOperador1.Select()
        lblOperacion.Visible = False
    End Sub

    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        Dim suma As Double
        lblOperacion.Visible = True
        lblOperacion.Text = "+"
        txtOperador2.Select()

        Try
            If txtOperador1.Text = "" Or txtOperador2.Text = "" Then
                MessageBox.Show("Error al introducir los datos")
                txtOperador1.BackColor = Color.Red
                txtOperador2.BackColor = Color.Red
            Else
                suma = Convert.ToDouble(txtOperador1.Text) + Convert.ToDouble(txtOperador2.Text)
                txtResultado.Text = Convert.ToString(suma)
                txtOperador1.BackColor = Color.White
                txtOperador2.BackColor = Color.White
            End If

        Catch ex As Exception
            MessageBox.Show("El valor debe ser numérico")
            txtOperador1.BackColor = Color.Red
            txtOperador2.BackColor = Color.Red
        End Try

    End Sub

    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
        Dim resta As Double
        lblOperacion.Visible = True
        lblOperacion.Text = "-"
        txtOperador2.Select()

        Try
            If txtOperador1.Text = "" Or txtOperador2.Text = "" Then
                MessageBox.Show("Error al introducir los datos")
                txtOperador1.BackColor = Color.Red
                txtOperador2.BackColor = Color.Red
            Else
                resta = Convert.ToDouble(txtOperador1.Text) - Convert.ToDouble(txtOperador2.Text)
                txtResultado.Text = Convert.ToString(resta)
                txtOperador1.BackColor = Color.White
                txtOperador2.BackColor = Color.White
            End If

        Catch ex As Exception
            MessageBox.Show("El valor debe ser numérico")
            txtOperador1.BackColor = Color.Red
            txtOperador2.BackColor = Color.Red
        End Try

    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        Dim multiplicacion As Double
        lblOperacion.Visible = True
        lblOperacion.Text = "x"
        txtOperador2.Select()

        Try
            If txtOperador1.Text = "" Or txtOperador2.Text = "" Then
                MessageBox.Show("Error al introducir los datos")
                txtOperador1.BackColor = Color.Red
                txtOperador2.BackColor = Color.Red
            Else
                multiplicacion = Convert.ToDouble(txtOperador1.Text) * Convert.ToDouble(txtOperador2.Text)
                txtResultado.Text = Convert.ToString(multiplicacion)
                txtOperador1.BackColor = Color.White
                txtOperador2.BackColor = Color.White
            End If

        Catch ex As Exception
            MessageBox.Show("El valor debe ser numérico")
            txtOperador1.BackColor = Color.Red
            txtOperador2.BackColor = Color.Red
        End Try

    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        Dim division As Double
        lblOperacion.Visible = True
        lblOperacion.Text = "/"
        txtOperador2.Select()

        Try
            If txtOperador1.Text = "" Or txtOperador2.Text = "" Then
                MessageBox.Show("Error al introducir los datos")
                txtOperador1.BackColor = Color.Red
                txtOperador2.BackColor = Color.Red
            Else
                division = Convert.ToDouble(txtOperador1.Text) / Convert.ToDouble(txtOperador2.Text)
                txtResultado.Text = Convert.ToString(division)
                txtOperador1.BackColor = Color.White
                txtOperador2.BackColor = Color.White
            End If

        Catch ex As Exception
            MessageBox.Show("El valor debe ser numérico")
            txtOperador1.BackColor = Color.Red
            txtOperador2.BackColor = Color.Red
        End Try

    End Sub
End Class