<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Descuentos
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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txtbx1 = New System.Windows.Forms.TextBox()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.txtbx2 = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txtbx3 = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.txtbx4 = New System.Windows.Forms.TextBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(236, 52)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Calcular"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(12, 50)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(62, 13)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Valor Venta"
        '
        'txtbx1
        '
        Me.txtbx1.Location = New System.Drawing.Point(93, 47)
        Me.txtbx1.Name = "txtbx1"
        Me.txtbx1.Size = New System.Drawing.Size(100, 20)
        Me.txtbx1.TabIndex = 2
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(236, 90)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 23)
        Me.btn2.TabIndex = 3
        Me.btn2.Text = "Limpiar"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(236, 129)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 23)
        Me.btn3.TabIndex = 4
        Me.btn3.Text = "Salir"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'txtbx2
        '
        Me.txtbx2.Location = New System.Drawing.Point(93, 87)
        Me.txtbx2.Name = "txtbx2"
        Me.txtbx2.Size = New System.Drawing.Size(100, 20)
        Me.txtbx2.TabIndex = 6
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(12, 90)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(68, 13)
        Me.lbl2.TabIndex = 5
        Me.lbl2.Text = "Descuento $"
        '
        'txtbx3
        '
        Me.txtbx3.Location = New System.Drawing.Point(93, 136)
        Me.txtbx3.Name = "txtbx3"
        Me.txtbx3.Size = New System.Drawing.Size(100, 20)
        Me.txtbx3.TabIndex = 8
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(12, 139)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(70, 13)
        Me.lbl3.TabIndex = 7
        Me.lbl3.Text = "Descuento %"
        '
        'txtbx4
        '
        Me.txtbx4.Location = New System.Drawing.Point(93, 176)
        Me.txtbx4.Name = "txtbx4"
        Me.txtbx4.Size = New System.Drawing.Size(100, 20)
        Me.txtbx4.TabIndex = 10
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(12, 179)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(56, 13)
        Me.lbl4.TabIndex = 9
        Me.lbl4.Text = "Valor Final"
        '
        'Descuentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 262)
        Me.Controls.Add(Me.txtbx4)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.txtbx3)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.txtbx2)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.txtbx1)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btn1)
        Me.Name = "Descuentos"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txtbx1 As System.Windows.Forms.TextBox
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents txtbx2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents txtbx3 As System.Windows.Forms.TextBox
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents txtbx4 As System.Windows.Forms.TextBox
    Friend WithEvents lbl4 As System.Windows.Forms.Label

End Class
