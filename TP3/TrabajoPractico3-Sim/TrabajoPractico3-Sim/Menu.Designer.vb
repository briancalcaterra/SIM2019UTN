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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bnt_punto_a = New System.Windows.Forms.Button()
        Me.bnt_punto_b = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label3.Location = New System.Drawing.Point(12, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(386, 91)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SIM 2019"
        '
        'bnt_punto_a
        '
        Me.bnt_punto_a.BackColor = System.Drawing.Color.White
        Me.bnt_punto_a.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnt_punto_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_punto_a.ForeColor = System.Drawing.Color.DarkViolet
        Me.bnt_punto_a.Location = New System.Drawing.Point(451, 12)
        Me.bnt_punto_a.Name = "bnt_punto_a"
        Me.bnt_punto_a.Size = New System.Drawing.Size(201, 73)
        Me.bnt_punto_a.TabIndex = 3
        Me.bnt_punto_a.Text = "Normal"
        Me.bnt_punto_a.UseVisualStyleBackColor = False
        '
        'bnt_punto_b
        '
        Me.bnt_punto_b.BackColor = System.Drawing.Color.White
        Me.bnt_punto_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnt_punto_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_punto_b.ForeColor = System.Drawing.Color.DarkViolet
        Me.bnt_punto_b.Location = New System.Drawing.Point(451, 170)
        Me.bnt_punto_b.Name = "bnt_punto_b"
        Me.bnt_punto_b.Size = New System.Drawing.Size(201, 73)
        Me.bnt_punto_b.TabIndex = 4
        Me.bnt_punto_b.Text = "Uniforme"
        Me.bnt_punto_b.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkViolet
        Me.Button1.Location = New System.Drawing.Point(451, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 73)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Exponencial"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkViolet
        Me.Button2.Location = New System.Drawing.Point(451, 426)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(201, 73)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Poisson"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(876, 551)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bnt_punto_b)
        Me.Controls.Add(Me.bnt_punto_a)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Menu"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents bnt_punto_a As Button
    Friend WithEvents bnt_punto_b As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
