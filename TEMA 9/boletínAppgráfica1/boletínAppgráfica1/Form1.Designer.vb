<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnEj1 = New System.Windows.Forms.Button()
        Me.btnEj2 = New System.Windows.Forms.Button()
        Me.btnEj3 = New System.Windows.Forms.Button()
        Me.btnEj4 = New System.Windows.Forms.Button()
        Me.btnEj5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEj1
        '
        Me.btnEj1.Location = New System.Drawing.Point(96, 135)
        Me.btnEj1.Name = "btnEj1"
        Me.btnEj1.Size = New System.Drawing.Size(122, 28)
        Me.btnEj1.TabIndex = 0
        Me.btnEj1.Text = "EJERCICIO 1"
        Me.btnEj1.UseVisualStyleBackColor = True
        '
        'btnEj2
        '
        Me.btnEj2.Location = New System.Drawing.Point(96, 169)
        Me.btnEj2.Name = "btnEj2"
        Me.btnEj2.Size = New System.Drawing.Size(122, 28)
        Me.btnEj2.TabIndex = 0
        Me.btnEj2.Text = "EJERCICIO 2"
        Me.btnEj2.UseVisualStyleBackColor = True
        '
        'btnEj3
        '
        Me.btnEj3.Location = New System.Drawing.Point(96, 203)
        Me.btnEj3.Name = "btnEj3"
        Me.btnEj3.Size = New System.Drawing.Size(122, 28)
        Me.btnEj3.TabIndex = 0
        Me.btnEj3.Text = "EJERCICIO 3"
        Me.btnEj3.UseVisualStyleBackColor = True
        '
        'btnEj4
        '
        Me.btnEj4.Location = New System.Drawing.Point(96, 237)
        Me.btnEj4.Name = "btnEj4"
        Me.btnEj4.Size = New System.Drawing.Size(122, 28)
        Me.btnEj4.TabIndex = 0
        Me.btnEj4.Text = "EJERCICIO 4"
        Me.btnEj4.UseVisualStyleBackColor = True
        '
        'btnEj5
        '
        Me.btnEj5.Location = New System.Drawing.Point(96, 271)
        Me.btnEj5.Name = "btnEj5"
        Me.btnEj5.Size = New System.Drawing.Size(122, 28)
        Me.btnEj5.TabIndex = 0
        Me.btnEj5.Text = "EJERCICIO 5"
        Me.btnEj5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(362, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BOLETÍN 1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEj5)
        Me.Controls.Add(Me.btnEj4)
        Me.Controls.Add(Me.btnEj3)
        Me.Controls.Add(Me.btnEj2)
        Me.Controls.Add(Me.btnEj1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEj1 As Button
    Friend WithEvents btnEj2 As Button
    Friend WithEvents btnEj3 As Button
    Friend WithEvents btnEj4 As Button
    Friend WithEvents btnEj5 As Button
    Friend WithEvents Label1 As Label
End Class
