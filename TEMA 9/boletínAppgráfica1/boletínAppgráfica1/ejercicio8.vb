Imports System.IO
Public Class ejercicio8
    Dim usuario As String
    Dim ruta As String = Directory.GetCurrentDirectory + "\fichero.txt"
    Dim lista As New ArrayList
    Dim contador As Integer
    Private Sub ejercicio8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lector As StreamReader = New StreamReader(ruta)
        Dim registro As String
        lista.Clear()

        While Not lector.EndOfStream
            registro = lector.ReadLine
            lista.Add(registro)
        End While
        lector.Close()

        Try
            txtVisualizarNombre.Text = Convert.ToString(lista(0).ToString.Split("*"c)(0))
            txtVisualizarApellidos.Text = Convert.ToString(lista(0).ToString.Split("*"c)(1))
            txtVisualizarEdad.Text = Convert.ToString(lista(0).ToString.Split("*"c)(2))
            txtVisualizarEmail.Text = Convert.ToString(lista(0).ToString.Split("*"c)(3))
            txtVisualizarDNI.Text = Convert.ToString(lista(0).ToString.Split("*"c)(4))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnGuardarUsuario_Click(sender As Object, e As EventArgs) Handles btnGuardarUsuario.Click
        Dim condicion As Boolean = True
        Dim numsDNI As Integer = 0
        Dim restoDivisionDNI As Double = 0
        Dim letrasDNI() As String = {"T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E"}
        Dim letra As String
        Dim contadorNums As Integer = 0

        txtApellidos.BackColor = Color.White
        txtNombre.BackColor = Color.White
        txtEdad.BackColor = Color.White
        txtEmail.BackColor = Color.White
        txtDNI.BackColor = Color.White

        If txtNombre.Text = "" Then
            txtNombre.BackColor = Color.Red
            txtNombre.SelectAll()
            condicion = False
        End If

        If txtApellidos.Text = "" Then
            txtApellidos.BackColor = Color.Red
            txtApellidos.SelectAll()
            condicion = False
        End If

        If txtEdad.Text = "" Then
            txtEdad.BackColor = Color.Red
            txtEdad.SelectAll()
            condicion = False
        End If

        If txtEmail.Text = "" Then
            txtEmail.BackColor = Color.Red
            txtEmail.SelectAll()
            condicion = False
        End If

        If txtDNI.Text = "" Then
            txtDNI.BackColor = Color.Red
            txtEmail.SelectAll()
            condicion = False
        Else
            numsDNI = Convert.ToInt32(txtDNI.Text.Substring(0, txtDNI.Text.Length - 1))
            restoDivisionDNI = numsDNI Mod 23
            letra = txtDNI.Text.ToString.Substring(8)
        End If

        For i = 0 To txtDNI.Text.Length - 1
            If Char.IsDigit(txtDNI.Text(i)) Then
                contador += 1
            End If
        Next

        If contadorNums <> 8 Then
            MessageBox.Show("Error, el DNI debe tener 8 numeros.")
            txtDNI.BackColor = Color.Red
            condicion = False
        End If

        If letra <> letrasDNI(Convert.ToInt32(restoDivisionDNI)) Then
            MessageBox.Show("Error al introducir la letra del DNI.", "Error en DNI")
            txtDNI.BackColor = Color.Red
            condicion = False
        End If

        For i = 0 To lista.Count - 1
            If lista(i).ToString.Contains(txtDNI.Text) Then
                MessageBox.Show("El DNI introducido ya está registrado", "Error en DNI")
                txtDNI.BackColor = Color.Red
                condicion = False
                Exit For
            End If
        Next

        Try
            If Convert.ToInt32(txtEdad.Text) < 18 Then
                MessageBox.Show("No se admiten menores de edad")
                txtEdad.BackColor = Color.Red
                condicion = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al introducir la edad", "Error en edad")
            txtEdad.BackColor = Color.Red
            condicion = False
        End Try

        If Not txtEmail.Text.ToString.Contains("@") Then
            MessageBox.Show("Error, el email no contiene @", "Error en el email")
            txtEmail.BackColor = Color.Red
            condicion = False
        End If

        If txtEmail.Text.ToString.Contains(".com") Or txtEmail.Text.ToString.Contains(".es") Or txtEmail.Text.ToString.Contains(".org") Or txtEmail.Text.ToString.Contains(".io") Then
        Else
            MessageBox.Show("Error, el email no contiene un dominio", "Error en el email")
            txtEmail.BackColor = Color.Red
            condicion = False
        End If

        If condicion = True Then
            usuario = txtNombre.Text & "*" & txtApellidos.Text & "*" & txtEdad.Text & "*" & txtEmail.Text & "*" & txtDNI.Text & "*" & Convert.ToString(fecha.Value)

            Dim escritor As StreamWriter = New StreamWriter(ruta, True)

            escritor.WriteLine(usuario)
            escritor.Close()

            Dim lector As StreamReader = New StreamReader(ruta)
            Dim registro As String
            lista.Clear()

            While Not lector.EndOfStream
                registro = lector.ReadLine
                lista.Add(registro)
            End While
            lector.Close()
        Else
            MessageBox.Show("Error al introducir los datos", "Error")
        End If


    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        contador = 0
        Try
            txtVisualizarNombre.Text = Convert.ToString(lista(0).ToString.Split("*"c)(0))
            txtVisualizarApellidos.Text = Convert.ToString(lista(0).ToString.Split("*"c)(1))
            txtVisualizarEdad.Text = Convert.ToString(lista(0).ToString.Split("*"c)(2))
            txtVisualizarEmail.Text = Convert.ToString(lista(0).ToString.Split("*"c)(3))
            txtVisualizarDNI.Text = Convert.ToString(lista(0).ToString.Split("*"c)(4))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        contador = lista.Count - 1
        Try
            txtVisualizarNombre.Text = Convert.ToString(lista(lista.Count - 1).ToString.Split("*"c)(0))
            txtVisualizarApellidos.Text = Convert.ToString(lista(lista.Count - 1).ToString.Split("*"c)(1))
            txtVisualizarEdad.Text = Convert.ToString(lista(lista.Count - 1).ToString.Split("*"c)(2))
            txtVisualizarEmail.Text = Convert.ToString(lista(lista.Count - 1).ToString.Split("*"c)(3))
            txtVisualizarDNI.Text = Convert.ToString(lista(lista.Count - 1).ToString.Split("*"c)(4))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If contador < lista.Count - 1 Then
            contador += 1
        End If

        Try
            txtVisualizarNombre.Text = Convert.ToString(lista(contador).ToString.Split("*"c)(0))
            txtVisualizarApellidos.Text = Convert.ToString(lista(contador).ToString.Split("*"c)(1))
            txtVisualizarEdad.Text = Convert.ToString(lista(contador).ToString.Split("*"c)(2))
            txtVisualizarEmail.Text = Convert.ToString(lista(contador).ToString.Split("*"c)(3))
            txtVisualizarDNI.Text = Convert.ToString(lista(contador).ToString.Split("*"c)(4))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAnteriorr_Click(sender As Object, e As EventArgs) Handles btnAnteriorr.Click
        If contador > 0 Then
            contador -= 1
        End If

        Try
            txtVisualizarNombre.Text = Convert.ToString(lista(contador).ToString.Split("*"c)(0))
            txtVisualizarApellidos.Text = Convert.ToString(lista(contador).ToString.Split("*"c)(1))
            txtVisualizarEdad.Text = Convert.ToString(lista(contador).ToString.Split("*"c)(2))
            txtVisualizarEmail.Text = Convert.ToString(lista(contador).ToString.Split("*"c)(3))
            txtVisualizarDNI.Text = Convert.ToString(lista(contador).ToString.Split("*"c)(4))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscarUsuario_Click(sender As Object, e As EventArgs) Handles btnBuscarUsuario.Click
        Dim condicion As Boolean = True

        For i = 0 To lista.Count - 1
            If lista(i).ToString.Contains(txtBuscarDNI.Text) Then
                MessageBox.Show(lista(i).ToString, "Datos del usuario")
                condicion = False
            End If
        Next

        If condicion = True Then
            MessageBox.Show("El DNI no está registrado", "Error")
        End If
    End Sub

    Private Sub btnEliminarUsuario_Click(sender As Object, e As EventArgs) Handles btnEliminarUsuario.Click
        Dim condicion1 As Boolean = True
        Dim respuesta As DialogResult
        Dim posicion As Integer

        For i = 0 To lista.Count - 1
            If (lista(i).ToString.Split("*"c)(4)) = txtEliminarDNI.Text Then
                condicion1 = False
                respuesta = MessageBox.Show("Estas seguro de que quieres eliminar este usuario ?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                posicion = i
            End If
        Next

        If respuesta = DialogResult.Yes Then
            lista.RemoveAt(posicion)
            Dim escritor As StreamWriter = New StreamWriter(ruta, False)
            escritor.Write("")
            escritor.Close()
        End If

        If condicion1 = True Then
            MessageBox.Show("El DNI no está registrado", "Error")
        End If

        Dim escritor1 As StreamWriter = New StreamWriter(ruta, True)
        For i = 0 To lista.Count - 1
            escritor1.WriteLine(lista(i).ToString)
        Next
        escritor1.Close()
    End Sub
End Class