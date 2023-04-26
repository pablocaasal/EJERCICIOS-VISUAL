Public Class Form2
    Private Sub ListBox1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Volcar las listas del form1 a la listbox de form2
        For Each serie In Form1.listaSeries
            ListBox1.Items.Add(serie.Split("*"c)(0))
        Next
    End Sub
End Class