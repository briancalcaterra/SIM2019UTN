<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Congruencial_mixto
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
        Me.btn_cargar_aleatorios = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_semilla = New System.Windows.Forms.TextBox()
        Me.txt_exponente = New System.Windows.Forms.TextBox()
        Me.grilla_numeros = New System.Windows.Forms.DataGridView()
        Me.posicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_constante_c = New System.Windows.Forms.TextBox()
        Me.txt_periodo_max = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_constante_a = New System.Windows.Forms.TextBox()
        Me.txt_intervalos = New System.Windows.Forms.TextBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.txt_cant_muestras = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_siguiente = New System.Windows.Forms.Button()
        CType(Me.grilla_numeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cargar_aleatorios
        '
        Me.btn_cargar_aleatorios.Location = New System.Drawing.Point(103, 178)
        Me.btn_cargar_aleatorios.Name = "btn_cargar_aleatorios"
        Me.btn_cargar_aleatorios.Size = New System.Drawing.Size(121, 26)
        Me.btn_cargar_aleatorios.TabIndex = 7
        Me.btn_cargar_aleatorios.Text = "Mostrar_grilla"
        Me.btn_cargar_aleatorios.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "semilla(Xo)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "intervalos (k)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "exponente (g)"
        '
        'txt_semilla
        '
        Me.txt_semilla.Location = New System.Drawing.Point(103, 11)
        Me.txt_semilla.Name = "txt_semilla"
        Me.txt_semilla.Size = New System.Drawing.Size(121, 20)
        Me.txt_semilla.TabIndex = 1
        '
        'txt_exponente
        '
        Me.txt_exponente.Location = New System.Drawing.Point(103, 63)
        Me.txt_exponente.Name = "txt_exponente"
        Me.txt_exponente.Size = New System.Drawing.Size(121, 20)
        Me.txt_exponente.TabIndex = 3
        '
        'grilla_numeros
        '
        Me.grilla_numeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_numeros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.posicion, Me.rnd})
        Me.grilla_numeros.Location = New System.Drawing.Point(484, 11)
        Me.grilla_numeros.Name = "grilla_numeros"
        Me.grilla_numeros.Size = New System.Drawing.Size(241, 350)
        Me.grilla_numeros.TabIndex = 10
        '
        'posicion
        '
        Me.posicion.HeaderText = "Posicion"
        Me.posicion.Name = "posicion"
        '
        'rnd
        '
        Me.rnd.HeaderText = "rnd"
        Me.rnd.Name = "rnd"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "(c)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "(m)"
        '
        'txt_constante_c
        '
        Me.txt_constante_c.Location = New System.Drawing.Point(103, 91)
        Me.txt_constante_c.Name = "txt_constante_c"
        Me.txt_constante_c.Size = New System.Drawing.Size(121, 20)
        Me.txt_constante_c.TabIndex = 4
        '
        'txt_periodo_max
        '
        Me.txt_periodo_max.Enabled = False
        Me.txt_periodo_max.Location = New System.Drawing.Point(103, 117)
        Me.txt_periodo_max.Name = "txt_periodo_max"
        Me.txt_periodo_max.Size = New System.Drawing.Size(121, 20)
        Me.txt_periodo_max.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "(a)"
        '
        'txt_constante_a
        '
        Me.txt_constante_a.Enabled = False
        Me.txt_constante_a.Location = New System.Drawing.Point(103, 141)
        Me.txt_constante_a.Name = "txt_constante_a"
        Me.txt_constante_a.Size = New System.Drawing.Size(121, 20)
        Me.txt_constante_a.TabIndex = 6
        '
        'txt_intervalos
        '
        Me.txt_intervalos.Location = New System.Drawing.Point(103, 37)
        Me.txt_intervalos.Name = "txt_intervalos"
        Me.txt_intervalos.Size = New System.Drawing.Size(121, 20)
        Me.txt_intervalos.TabIndex = 2
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(103, 261)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(121, 23)
        Me.btn_limpiar.TabIndex = 9
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'txt_cant_muestras
        '
        Me.txt_cant_muestras.Location = New System.Drawing.Point(262, 11)
        Me.txt_cant_muestras.Name = "txt_cant_muestras"
        Me.txt_cant_muestras.Size = New System.Drawing.Size(61, 20)
        Me.txt_cant_muestras.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(240, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "n:"
        '
        'btn_siguiente
        '
        Me.btn_siguiente.Location = New System.Drawing.Point(103, 220)
        Me.btn_siguiente.Name = "btn_siguiente"
        Me.btn_siguiente.Size = New System.Drawing.Size(121, 24)
        Me.btn_siguiente.TabIndex = 8
        Me.btn_siguiente.Text = "Siguiente"
        Me.btn_siguiente.UseVisualStyleBackColor = True
        '
        'Congruencial_mixto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 404)
        Me.Controls.Add(Me.btn_siguiente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_cant_muestras)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.grilla_numeros)
        Me.Controls.Add(Me.txt_constante_a)
        Me.Controls.Add(Me.txt_periodo_max)
        Me.Controls.Add(Me.txt_constante_c)
        Me.Controls.Add(Me.txt_exponente)
        Me.Controls.Add(Me.txt_intervalos)
        Me.Controls.Add(Me.txt_semilla)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cargar_aleatorios)
        Me.Name = "Congruencial_mixto"
        Me.Text = "Form1"
        CType(Me.grilla_numeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cargar_aleatorios As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_semilla As System.Windows.Forms.TextBox
    Friend WithEvents txt_exponente As System.Windows.Forms.TextBox
    Friend WithEvents grilla_numeros As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_constante_c As System.Windows.Forms.TextBox
    Friend WithEvents txt_periodo_max As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_constante_a As System.Windows.Forms.TextBox
    Friend WithEvents txt_intervalos As System.Windows.Forms.TextBox
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents posicion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rnd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_cant_muestras As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_siguiente As System.Windows.Forms.Button

End Class
