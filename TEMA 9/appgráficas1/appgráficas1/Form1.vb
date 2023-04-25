Public Class Form1
    'Zona declaracion variables globales (todas las funciones)
    Dim nombre As String

    Private Sub btnSaludarClick(sender As Object, e As EventArgs) Handles btnSaludar.Click
        'Recoger nombre que el usuario introdujo en la celda de texto y que se muestre al pulsar el botón
        nombre = txtNombre.Text
        MessageBox.Show(nombre)
    End Sub

    Private Sub btnContarLetras(sender As Object, e As EventArgs) Handles btnLContaretras.Click
        'Contar numero de letras del texto
        nombre = txtNombre.Text
        Dim numeroLetras As Integer = nombre.Length
        MessageBox.Show(nombre & " tiene " & numeroLetras & " letras")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub lblNombre_Click(sender As Object, e As EventArgs) Handles lblNombre.Click

    End Sub

    Private Sub txtTexto_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub
End Class
