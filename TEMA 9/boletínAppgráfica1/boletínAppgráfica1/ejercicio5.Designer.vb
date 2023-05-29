<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio5
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
        Me.txtOperador1 = New System.Windows.Forms.TextBox()
        Me.txtOperador2 = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.btnRestar = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.lblOperacion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtOperador1
        '
        Me.txtOperador1.Location = New System.Drawing.Point(169, 111)
        Me.txtOperador1.Name = "txtOperador1"
        Me.txtOperador1.Size = New System.Drawing.Size(106, 22)
        Me.txtOperador1.TabIndex = 0
        '
        'txtOperador2
        '
        Me.txtOperador2.Location = New System.Drawing.Point(343, 111)
        Me.txtOperador2.Name = "txtOperador2"
        Me.txtOperador2.Size = New System.Drawing.Size(127, 22)
        Me.txtOperador2.TabIndex = 1
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(533, 111)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(99, 22)
        Me.txtResultado.TabIndex = 6
        '
        'btnSumar
        '
        Me.btnSumar.Location = New System.Drawing.Point(220, 174)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(73, 76)
        Me.btnSumar.TabIndex = 2
        Me.btnSumar.Text = "+"
        Me.btnSumar.UseVisualStyleBackColor = True
        '
        'btnRestar
        '
        Me.btnRestar.Location = New System.Drawing.Point(311, 174)
        Me.btnRestar.Name = "btnRestar"
        Me.btnRestar.Size = New System.Drawing.Size(75, 76)
        Me.btnRestar.TabIndex = 3
        Me.btnRestar.Text = "-"
        Me.btnRestar.UseVisualStyleBackColor = True
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.Location = New System.Drawing.Point(404, 174)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(74, 76)
        Me.btnMultiplicar.TabIndex = 4
        Me.btnMultiplicar.Text = "*"
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'btnDividir
        '
        Me.btnDividir.Location = New System.Drawing.Point(493, 174)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(76, 76)
        Me.btnDividir.TabIndex = 5
        Me.btnDividir.Text = "/"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'lblOperacion
        '
        Me.lblOperacion.AutoSize = True
        Me.lblOperacion.Location = New System.Drawing.Point(299, 114)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(12, 17)
        Me.lblOperacion.TabIndex = 8
        Me.lblOperacion.Text = " "
        Me.lblOperacion.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(488, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 29)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "="
        '
        'ejercicio5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblOperacion)
        Me.Controls.Add(Me.btnDividir)
        Me.Controls.Add(Me.btnMultiplicar)
        Me.Controls.Add(Me.btnRestar)
        Me.Controls.Add(Me.btnSumar)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtOperador2)
        Me.Controls.Add(Me.txtOperador1)
        Me.Name = "ejercicio5"
        Me.Text = "ejercicio5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOperador1 As TextBox
    Friend WithEvents txtOperador2 As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnSumar As Button
    Friend WithEvents btnRestar As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents btnDividir As Button
    Friend WithEvents lblOperacion As Label
    Friend WithEvents Label2 As Label
End Class
