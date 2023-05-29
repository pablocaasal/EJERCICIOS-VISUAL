Imports System.IO
Public Class Form1
    Public listaSeries As New List(Of String)
    Public ruta As String = Directory.GetCurrentDirectory() + "/series.txt"

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

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'guardar los datos en el fichero

        Dim respuesta As DialogResult = MessageBox.Show("Quieres actualizar el fichero ? ", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            'escribir en el fichero
            Dim escritor As StreamWriter = New StreamWriter(ruta, False)

            For Each elemento In listaSeries
                escritor.WriteLine(elemento)
            Next

            escritor.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'leer el fichero y volcar informacion a la lista

        Dim lector As StreamReader = New StreamReader(ruta)
        Dim registro As String = Nothing

        While Not lector.EndOfStream
            registro = lector.ReadLine
            listaSeries.Add(registro)
        End While
        lector.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        eventosTeclados.ShowDialog()
    End Sub
End Class
