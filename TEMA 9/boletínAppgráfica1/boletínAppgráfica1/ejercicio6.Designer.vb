<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio6
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCentigrados = New System.Windows.Forms.TextBox()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.btnConvertirAF = New System.Windows.Forms.Button()
        Me.btnConvertirAC = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grados Centigrados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Grados Fahrenheit"
        '
        'txtCentigrados
        '
        Me.txtCentigrados.Location = New System.Drawing.Point(245, 120)
        Me.txtCentigrados.Name = "txtCentigrados"
        Me.txtCentigrados.Size = New System.Drawing.Size(100, 22)
        Me.txtCentigrados.TabIndex = 2
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Location = New System.Drawing.Point(245, 191)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(100, 22)
        Me.txtFahrenheit.TabIndex = 3
        '
        'btnConvertirAF
        '
        Me.btnConvertirAF.Location = New System.Drawing.Point(387, 120)
        Me.btnConvertirAF.Name = "btnConvertirAF"
        Me.btnConvertirAF.Size = New System.Drawing.Size(175, 23)
        Me.btnConvertirAF.TabIndex = 4
        Me.btnConvertirAF.Text = "Convertir a fahrenheit"
        Me.btnConvertirAF.UseVisualStyleBackColor = True
        '
        'btnConvertirAC
        '
        Me.btnConvertirAC.Location = New System.Drawing.Point(387, 188)
        Me.btnConvertirAC.Name = "btnConvertirAC"
        Me.btnConvertirAC.Size = New System.Drawing.Size(175, 25)
        Me.btnConvertirAC.TabIndex = 5
        Me.btnConvertirAC.Text = "Convertir a centígrados"
        Me.btnConvertirAC.UseVisualStyleBackColor = True
        '
        'ejercicio6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnConvertirAC)
        Me.Controls.Add(Me.btnConvertirAF)
        Me.Controls.Add(Me.txtFahrenheit)
        Me.Controls.Add(Me.txtCentigrados)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ejercicio6"
        Me.Text = "ejercicio6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCentigrados As TextBox
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents btnConvertirAF As Button
    Friend WithEvents btnConvertirAC As Button
End Class
