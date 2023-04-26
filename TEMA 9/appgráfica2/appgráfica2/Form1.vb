Public Class Form1
    Public listaSeries As List(Of String)

    Private Sub btnGuardarSerie_Click(sender As Object, e As EventArgs) Handles btnGuardarSerie.Click
        Dim plataforma As String
        Dim titulo As String = ""
        Dim valoracion As Double
        Dim fechaEstreno As Date
        Dim correctoT As Boolean = True
        Dim correctoV As Boolean = True

        'Comprobar que el textbox tiene texto

        If txtTítulo.Text <> "" Then
            titulo = txtTítulo.Text
        Else
            txtTítulo.BackColor = Color.Beige
            Me.ActiveControl = txtTítulo
            MessageBox.Show("El título es obligatorio")
            correctoT = False
        End If

        'Comprobar que la valoración son números

        Try
            valoracion = Convert.ToDouble(txtValoración.Text)

            If valoracion < 1 Or valoracion > 10 Then
                txtValoración.BackColor = Color.Firebrick
                txtValoración.SelectAll()
                Me.ActiveControl = txtValoración
                MessageBox.Show("La valoración debe ser entre 1 y 10")
                correctoV = False
            End If
        Catch ex As Exception
            txtValoración.BackColor = Color.Firebrick
            txtValoración.SelectAll()
            Me.ActiveControl = txtValoración
            MessageBox.Show("La valoración debe ser númerica")
            correctoV = False
        End Try

        'Guardar datos introducidos por el usuario

        plataforma = txtPlataforma.Text
        fechaEstreno = dtpFechaEsteno.Value

        If correctoT = True And correctoV = True Then
            Dim registro As String = titulo & "*" & plataforma & "*" & valoracion.ToString & "*" & fechaEstreno.ToString
            listaSeries.Add(registro)
            MessageBox.Show("Serie guardada con éxito")
        End If



    End Sub

    Private Sub btnConsultarSeries_Click(sender As Object, e As EventArgs) Handles btnConsultarSeries.Click
        Form2.ShowDialog()
    End Sub
End Class
