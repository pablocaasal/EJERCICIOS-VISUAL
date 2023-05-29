<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio7
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
        Me.txtEuros = New System.Windows.Forms.TextBox()
        Me.txtDollars = New System.Windows.Forms.TextBox()
        Me.btnConvertirDollar = New System.Windows.Forms.Button()
        Me.btnConvertirEuros = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(57, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Conversor "
        '
        'txtEuros
        '
        Me.txtEuros.Location = New System.Drawing.Point(74, 150)
        Me.txtEuros.Name = "txtEuros"
        Me.txtEuros.Size = New System.Drawing.Size(100, 22)
        Me.txtEuros.TabIndex = 1
        '
        'txtDollars
        '
        Me.txtDollars.Location = New System.Drawing.Point(74, 208)
        Me.txtDollars.Name = "txtDollars"
        Me.txtDollars.Size = New System.Drawing.Size(100, 22)
        Me.txtDollars.TabIndex = 2
        '
        'btnConvertirDollar
        '
        Me.btnConvertirDollar.Location = New System.Drawing.Point(74, 273)
        Me.btnConvertirDollar.Name = "btnConvertirDollar"
        Me.btnConvertirDollar.Size = New System.Drawing.Size(79, 43)
        Me.btnConvertirDollar.TabIndex = 3
        Me.btnConvertirDollar.Text = "Convertir a dolares"
        Me.btnConvertirDollar.UseVisualStyleBackColor = True
        '
        'btnConvertirEuros
        '
        Me.btnConvertirEuros.Location = New System.Drawing.Point(180, 273)
        Me.btnConvertirEuros.Name = "btnConvertirEuros"
        Me.btnConvertirEuros.Size = New System.Drawing.Size(79, 43)
        Me.btnConvertirEuros.TabIndex = 3
        Me.btnConvertirEuros.Text = "Convertir a Euros"
        Me.btnConvertirEuros.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(208, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "€"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(208, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "$"
        '
        'ejercicio7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnConvertirEuros)
        Me.Controls.Add(Me.btnConvertirDollar)
        Me.Controls.Add(Me.txtDollars)
        Me.Controls.Add(Me.txtEuros)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ejercicio7"
        Me.Text = "ejercicio7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtEuros As TextBox
    Friend WithEvents txtDollars As TextBox
    Friend WithEvents btnConvertirDollar As Button
    Friend WithEvents btnConvertirEuros As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
