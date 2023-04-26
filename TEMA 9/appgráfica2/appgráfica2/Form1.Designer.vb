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
        Me.txtTítulo = New System.Windows.Forms.TextBox()
        Me.txtPlataforma = New System.Windows.Forms.TextBox()
        Me.txtValoración = New System.Windows.Forms.TextBox()
        Me.lblTítulo = New System.Windows.Forms.Label()
        Me.lblPlataforma = New System.Windows.Forms.Label()
        Me.lblValoración = New System.Windows.Forms.Label()
        Me.btnGuardarSerie = New System.Windows.Forms.Button()
        Me.dtpFechaEsteno = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.btnConsultarSeries = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTítulo
        '
        Me.txtTítulo.Location = New System.Drawing.Point(215, 124)
        Me.txtTítulo.Name = "txtTítulo"
        Me.txtTítulo.Size = New System.Drawing.Size(100, 22)
        Me.txtTítulo.TabIndex = 0
        '
        'txtPlataforma
        '
        Me.txtPlataforma.Location = New System.Drawing.Point(215, 173)
        Me.txtPlataforma.Name = "txtPlataforma"
        Me.txtPlataforma.Size = New System.Drawing.Size(100, 22)
        Me.txtPlataforma.TabIndex = 1
        '
        'txtValoración
        '
        Me.txtValoración.Location = New System.Drawing.Point(215, 224)
        Me.txtValoración.Name = "txtValoración"
        Me.txtValoración.Size = New System.Drawing.Size(100, 22)
        Me.txtValoración.TabIndex = 2
        '
        'lblTítulo
        '
        Me.lblTítulo.AutoSize = True
        Me.lblTítulo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTítulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTítulo.Location = New System.Drawing.Point(70, 124)
        Me.lblTítulo.Name = "lblTítulo"
        Me.lblTítulo.Size = New System.Drawing.Size(111, 25)
        Me.lblTítulo.TabIndex = 3
        Me.lblTítulo.Text = "Título Serie"
        '
        'lblPlataforma
        '
        Me.lblPlataforma.AutoSize = True
        Me.lblPlataforma.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblPlataforma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlataforma.Location = New System.Drawing.Point(70, 172)
        Me.lblPlataforma.Name = "lblPlataforma"
        Me.lblPlataforma.Size = New System.Drawing.Size(105, 25)
        Me.lblPlataforma.TabIndex = 4
        Me.lblPlataforma.Text = "Plataforma"
        '
        'lblValoración
        '
        Me.lblValoración.AutoSize = True
        Me.lblValoración.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblValoración.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValoración.Location = New System.Drawing.Point(70, 220)
        Me.lblValoración.Name = "lblValoración"
        Me.lblValoración.Size = New System.Drawing.Size(105, 25)
        Me.lblValoración.TabIndex = 5
        Me.lblValoración.Text = "Valoración"
        '
        'btnGuardarSerie
        '
        Me.btnGuardarSerie.Location = New System.Drawing.Point(111, 349)
        Me.btnGuardarSerie.Name = "btnGuardarSerie"
        Me.btnGuardarSerie.Size = New System.Drawing.Size(117, 52)
        Me.btnGuardarSerie.TabIndex = 6
        Me.btnGuardarSerie.Text = "Guardar Serie"
        Me.btnGuardarSerie.UseVisualStyleBackColor = True
        '
        'dtpFechaEsteno
        '
        Me.dtpFechaEsteno.Location = New System.Drawing.Point(215, 270)
        Me.dtpFechaEsteno.Name = "dtpFechaEsteno"
        Me.dtpFechaEsteno.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaEsteno.TabIndex = 7
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(70, 267)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(139, 25)
        Me.lblFecha.TabIndex = 5
        Me.lblFecha.Text = "Fecha Estreno"
        '
        'btnConsultarSeries
        '
        Me.btnConsultarSeries.Location = New System.Drawing.Point(300, 349)
        Me.btnConsultarSeries.Name = "btnConsultarSeries"
        Me.btnConsultarSeries.Size = New System.Drawing.Size(115, 51)
        Me.btnConsultarSeries.TabIndex = 8
        Me.btnConsultarSeries.Text = "Consultar Series"
        Me.btnConsultarSeries.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnConsultarSeries)
        Me.Controls.Add(Me.dtpFechaEsteno)
        Me.Controls.Add(Me.btnGuardarSerie)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblValoración)
        Me.Controls.Add(Me.lblPlataforma)
        Me.Controls.Add(Me.lblTítulo)
        Me.Controls.Add(Me.txtValoración)
        Me.Controls.Add(Me.txtPlataforma)
        Me.Controls.Add(Me.txtTítulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTítulo As TextBox
    Friend WithEvents txtPlataforma As TextBox
    Friend WithEvents txtValoración As TextBox
    Friend WithEvents lblTítulo As Label
    Friend WithEvents lblPlataforma As Label
    Friend WithEvents lblValoración As Label
    Friend WithEvents btnGuardarSerie As Button
    Friend WithEvents dtpFechaEsteno As DateTimePicker
    Friend WithEvents lblFecha As Label
    Friend WithEvents btnConsultarSeries As Button
End Class
