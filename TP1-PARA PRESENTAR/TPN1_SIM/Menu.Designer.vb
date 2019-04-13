<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.btn_multiplicativo = New System.Windows.Forms.Button()
        Me.bnt_mixto = New System.Windows.Forms.Button()
        Me.bnt_puntoB = New System.Windows.Forms.Button()
        Me.bnt_puntoC = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_multiplicativo
        '
        Me.btn_multiplicativo.BackColor = System.Drawing.Color.White
        Me.btn_multiplicativo.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_multiplicativo.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_multiplicativo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_multiplicativo.Location = New System.Drawing.Point(472, 196)
        Me.btn_multiplicativo.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_multiplicativo.Name = "btn_multiplicativo"
        Me.btn_multiplicativo.Size = New System.Drawing.Size(177, 66)
        Me.btn_multiplicativo.TabIndex = 1
        Me.btn_multiplicativo.Text = "Congruencial Multiplicativo"
        Me.btn_multiplicativo.UseVisualStyleBackColor = False
        '
        'bnt_mixto
        '
        Me.bnt_mixto.BackColor = System.Drawing.Color.White
        Me.bnt_mixto.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_mixto.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.bnt_mixto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bnt_mixto.Location = New System.Drawing.Point(476, 79)
        Me.bnt_mixto.Margin = New System.Windows.Forms.Padding(4)
        Me.bnt_mixto.Name = "bnt_mixto"
        Me.bnt_mixto.Size = New System.Drawing.Size(175, 66)
        Me.bnt_mixto.TabIndex = 0
        Me.bnt_mixto.Text = "Congruencial Mixto"
        Me.bnt_mixto.UseVisualStyleBackColor = False
        '
        'bnt_puntoB
        '
        Me.bnt_puntoB.BackColor = System.Drawing.Color.White
        Me.bnt_puntoB.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_puntoB.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.bnt_puntoB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bnt_puntoB.Location = New System.Drawing.Point(474, 324)
        Me.bnt_puntoB.Margin = New System.Windows.Forms.Padding(4)
        Me.bnt_puntoB.Name = "bnt_puntoB"
        Me.bnt_puntoB.Size = New System.Drawing.Size(175, 66)
        Me.bnt_puntoB.TabIndex = 2
        Me.bnt_puntoB.Text = "Punto B"
        Me.bnt_puntoB.UseVisualStyleBackColor = False
        '
        'bnt_puntoC
        '
        Me.bnt_puntoC.BackColor = System.Drawing.Color.White
        Me.bnt_puntoC.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_puntoC.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.bnt_puntoC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bnt_puntoC.Location = New System.Drawing.Point(476, 450)
        Me.bnt_puntoC.Margin = New System.Windows.Forms.Padding(4)
        Me.bnt_puntoC.Name = "bnt_puntoC"
        Me.bnt_puntoC.Size = New System.Drawing.Size(175, 66)
        Me.bnt_puntoC.TabIndex = 3
        Me.bnt_puntoC.Text = "Punto C"
        Me.bnt_puntoC.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(24, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(340, 85)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "SIM 2019"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(740, 724)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bnt_puntoC)
        Me.Controls.Add(Me.bnt_puntoB)
        Me.Controls.Add(Me.bnt_mixto)
        Me.Controls.Add(Me.btn_multiplicativo)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_multiplicativo As Button
    Friend WithEvents bnt_mixto As Button
    Friend WithEvents bnt_puntoB As Button
    Friend WithEvents bnt_puntoC As Button
    Friend WithEvents Label2 As Label
End Class
