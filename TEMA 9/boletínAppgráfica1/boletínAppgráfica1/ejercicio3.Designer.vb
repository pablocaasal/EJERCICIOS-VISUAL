<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio3
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtValorCuadrado = New System.Windows.Forms.TextBox()
        Me.txtValorRectanguloMayor = New System.Windows.Forms.TextBox()
        Me.txtValorTrianguloBase = New System.Windows.Forms.TextBox()
        Me.btnCuadrado = New System.Windows.Forms.Button()
        Me.btnRectangulo = New System.Windows.Forms.Button()
        Me.btnTriangulo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtValorRectanguloMenor = New System.Windows.Forms.TextBox()
        Me.txtValorTrianguloAlt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblValorResultado = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Salmon
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calcular área figuras geométricas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor del lado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Valor del lado mayor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Valor de la base"
        '
        'txtValorCuadrado
        '
        Me.txtValorCuadrado.Location = New System.Drawing.Point(165, 31)
        Me.txtValorCuadrado.Name = "txtValorCuadrado"
        Me.txtValorCuadrado.Size = New System.Drawing.Size(63, 22)
        Me.txtValorCuadrado.TabIndex = 4
        '
        'txtValorRectanguloMayor
        '
        Me.txtValorRectanguloMayor.Location = New System.Drawing.Point(198, 184)
        Me.txtValorRectanguloMayor.Name = "txtValorRectanguloMayor"
        Me.txtValorRectanguloMayor.Size = New System.Drawing.Size(63, 22)
        Me.txtValorRectanguloMayor.TabIndex = 5
        '
        'txtValorTrianguloBase
        '
        Me.txtValorTrianguloBase.Location = New System.Drawing.Point(198, 271)
        Me.txtValorTrianguloBase.Name = "txtValorTrianguloBase"
        Me.txtValorTrianguloBase.Size = New System.Drawing.Size(63, 22)
        Me.txtValorTrianguloBase.TabIndex = 6
        '
        'btnCuadrado
        '
        Me.btnCuadrado.BackColor = System.Drawing.Color.Salmon
        Me.btnCuadrado.Location = New System.Drawing.Point(595, 13)
        Me.btnCuadrado.Name = "btnCuadrado"
        Me.btnCuadrado.Size = New System.Drawing.Size(118, 53)
        Me.btnCuadrado.TabIndex = 7
        Me.btnCuadrado.Text = "Cuadrado"
        Me.btnCuadrado.UseVisualStyleBackColor = False
        '
        'btnRectangulo
        '
        Me.btnRectangulo.BackColor = System.Drawing.Color.Salmon
        Me.btnRectangulo.Location = New System.Drawing.Point(628, 169)
        Me.btnRectangulo.Name = "btnRectangulo"
        Me.btnRectangulo.Size = New System.Drawing.Size(118, 52)
        Me.btnRectangulo.TabIndex = 8
        Me.btnRectangulo.Text = "Rectángulo"
        Me.btnRectangulo.UseVisualStyleBackColor = False
        '
        'btnTriangulo
        '
        Me.btnTriangulo.BackColor = System.Drawing.Color.Salmon
        Me.btnTriangulo.Location = New System.Drawing.Point(628, 253)
        Me.btnTriangulo.Name = "btnTriangulo"
        Me.btnTriangulo.Size = New System.Drawing.Size(118, 53)
        Me.btnTriangulo.TabIndex = 9
        Me.btnTriangulo.Text = "Triángulo"
        Me.btnTriangulo.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(299, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Valor del lado menor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(299, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Valor de la altura"
        '
        'txtValorRectanguloMenor
        '
        Me.txtValorRectanguloMenor.Location = New System.Drawing.Point(486, 184)
        Me.txtValorRectanguloMenor.Name = "txtValorRectanguloMenor"
        Me.txtValorRectanguloMenor.Size = New System.Drawing.Size(64, 22)
        Me.txtValorRectanguloMenor.TabIndex = 12
        '
        'txtValorTrianguloAlt
        '
        Me.txtValorTrianguloAlt.Location = New System.Drawing.Point(486, 271)
        Me.txtValorTrianguloAlt.Name = "txtValorTrianguloAlt"
        Me.txtValorTrianguloAlt.Size = New System.Drawing.Size(64, 22)
        Me.txtValorTrianguloAlt.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(471, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 38)
        Me.Label8.TabIndex = 15
        '
        'lblValorResultado
        '
        Me.lblValorResultado.AutoSize = True
        Me.lblValorResultado.BackColor = System.Drawing.Color.Salmon
        Me.lblValorResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorResultado.Location = New System.Drawing.Point(35, 345)
        Me.lblValorResultado.Name = "lblValorResultado"
        Me.lblValorResultado.Size = New System.Drawing.Size(182, 38)
        Me.lblValorResultado.TabIndex = 16
        Me.lblValorResultado.Text = "Resultado :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCuadrado)
        Me.GroupBox1.Controls.Add(Me.txtValorCuadrado)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(721, 75)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'ejercicio3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblValorResultado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtValorTrianguloAlt)
        Me.Controls.Add(Me.txtValorRectanguloMenor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnTriangulo)
        Me.Controls.Add(Me.btnRectangulo)
        Me.Controls.Add(Me.txtValorTrianguloBase)
        Me.Controls.Add(Me.txtValorRectanguloMayor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ejercicio3"
        Me.Text = "ejercicio3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtValorCuadrado As TextBox
    Friend WithEvents txtValorRectanguloMayor As TextBox
    Friend WithEvents txtValorTrianguloBase As TextBox
    Friend WithEvents btnCuadrado As Button
    Friend WithEvents btnRectangulo As Button
    Friend WithEvents btnTriangulo As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtValorRectanguloMenor As TextBox
    Friend WithEvents txtValorTrianguloAlt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblValorResultado As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
