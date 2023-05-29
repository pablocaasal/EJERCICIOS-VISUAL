<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblSeriesGuardadas = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnVerHBO = New System.Windows.Forms.Button()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtPlataforma = New System.Windows.Forms.TextBox()
        Me.txtValoracion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblSeriesGuardadas
        '
        Me.lblSeriesGuardadas.AutoSize = True
        Me.lblSeriesGuardadas.Location = New System.Drawing.Point(105, 42)
        Me.lblSeriesGuardadas.Name = "lblSeriesGuardadas"
        Me.lblSeriesGuardadas.Size = New System.Drawing.Size(123, 17)
        Me.lblSeriesGuardadas.TabIndex = 1
        Me.lblSeriesGuardadas.Text = "Series Guardadas"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(108, 95)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 84)
        Me.ListBox1.TabIndex = 2
        '
        'btnVerHBO
        '
        Me.btnVerHBO.Location = New System.Drawing.Point(272, 135)
        Me.btnVerHBO.Name = "btnVerHBO"
        Me.btnVerHBO.Size = New System.Drawing.Size(75, 23)
        Me.btnVerHBO.TabIndex = 3
        Me.btnVerHBO.Text = "HBO"
        Me.btnVerHBO.UseVisualStyleBackColor = True
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(272, 188)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(68, 22)
        Me.txtTitulo.TabIndex = 4
        '
        'txtPlataforma
        '
        Me.txtPlataforma.Location = New System.Drawing.Point(272, 242)
        Me.txtPlataforma.Name = "txtPlataforma"
        Me.txtPlataforma.Size = New System.Drawing.Size(67, 22)
        Me.txtPlataforma.TabIndex = 5
        '
        'txtValoracion
        '
        Me.txtValoracion.Location = New System.Drawing.Point(271, 298)
        Me.txtValoracion.Name = "txtValoracion"
        Me.txtValoracion.Size = New System.Drawing.Size(68, 22)
        Me.txtValoracion.TabIndex = 6
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtValoracion)
        Me.Controls.Add(Me.txtPlataforma)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.btnVerHBO)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblSeriesGuardadas)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSeriesGuardadas As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnVerHBO As Button
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtPlataforma As TextBox
    Friend WithEvents txtValoracion As TextBox
End Class
