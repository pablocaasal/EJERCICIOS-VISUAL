Public Class Form1
    Dim variable As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Lo que quieres que haga la aplicaión cuando pulsas el formulario debe estar aquí



    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Lo que quieres que haga la aplicaión cuando pulsas el botón debe estar aquí

        Button1.Text = ("VOLVER")

        'Cambiar el fondo del formulario

        Me.BackColor = Color.Blue



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'ABRIR EL FORMULARIO 2


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dni As Integer = 123456

        If TextBox1.Text.Length = 9 Then
            TextBox2.Text = ("DNI CORRECTO")
            variable = True
        Else
            TextBox2.Text = ("DNI INCORRECTO")

        End If

        If variable = True Then

            Form2.Show(Me)
        End If
    End Sub

End Class
