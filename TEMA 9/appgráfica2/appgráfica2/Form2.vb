Public Class Form2
    Private Sub ListBox1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Volcar las listas del form1 a la listbox de form2
        For Each serie In Form1.listaSeries
            ListBox1.Items.Add(serie.Split("*"c)(0))
        Next
    End Sub

    Private Sub btnVerHBO_Click(sender As Object, e As EventArgs) Handles btnVerHBO.Click
        'limpiar el listbox
        ListBox1.Items.Clear()

        For Each serie In Form1.listaSeries
            If serie.Split("*"c)(1) = "HBO" Then
                ListBox1.Items.Add(serie.Split("*"c)(0))
            End If
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'oBTENER EL TITULO DE LA SERIE SELECCIONADO

        Dim titulo As String = ListBox1.SelectedItem.ToString

        For Each serie In Form1.listaSeries
            If serie.Split("*"c)(0) = titulo Then
                'volcar datos a las cajas de texto  
                txtTitulo.Text = serie.Split("*"c)(0)
                txtPlataforma.Text = serie.Split("*"c)(1)
                txtValoracion.Text = serie.Split("*"c)(2)
            End If
        Next
    End Sub
End Class