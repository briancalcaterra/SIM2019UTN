<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CongruencialMultiplicativo
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
        Me.btn_cargar_vector_Mult = New System.Windows.Forms.Button()
        Me.btn_cargar_aleatorios_Mult = New System.Windows.Forms.Button()
        Me.grilla_numeros_Mult = New System.Windows.Forms.DataGridView()
        Me.posicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_constante_a_Mult = New System.Windows.Forms.TextBox()
        Me.txt_periodo_max_Mult = New System.Windows.Forms.TextBox()
        Me.txt_constante_c_Mult = New System.Windows.Forms.TextBox()
        Me.txt_exponente_Mult = New System.Windows.Forms.TextBox()
        Me.txt_intervalos_Mult = New System.Windows.Forms.TextBox()
        Me.txt_semilla_Mult = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grilla_numeros_Mult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cargar_vector_Mult
        '
        Me.btn_cargar_vector_Mult.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cargar_vector_Mult.Location = New System.Drawing.Point(22, 413)
        Me.btn_cargar_vector_Mult.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cargar_vector_Mult.Name = "btn_cargar_vector_Mult"
        Me.btn_cargar_vector_Mult.Size = New System.Drawing.Size(187, 28)
        Me.btn_cargar_vector_Mult.TabIndex = 19
        Me.btn_cargar_vector_Mult.Text = "Cargar Vector"
        Me.btn_cargar_vector_Mult.UseVisualStyleBackColor = True
        '
        'btn_cargar_aleatorios_Mult
        '
        Me.btn_cargar_aleatorios_Mult.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cargar_aleatorios_Mult.Location = New System.Drawing.Point(217, 427)
        Me.btn_cargar_aleatorios_Mult.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cargar_aleatorios_Mult.Name = "btn_cargar_aleatorios_Mult"
        Me.btn_cargar_aleatorios_Mult.Size = New System.Drawing.Size(187, 32)
        Me.btn_cargar_aleatorios_Mult.TabIndex = 18
        Me.btn_cargar_aleatorios_Mult.Text = "Mostrar Grilla"
        Me.btn_cargar_aleatorios_Mult.UseVisualStyleBackColor = True
        '
        'grilla_numeros_Mult
        '
        Me.grilla_numeros_Mult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_numeros_Mult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.posicion, Me.rnd})
        Me.grilla_numeros_Mult.Location = New System.Drawing.Point(422, 32)
        Me.grilla_numeros_Mult.Margin = New System.Windows.Forms.Padding(4)
        Me.grilla_numeros_Mult.Name = "grilla_numeros_Mult"
        Me.grilla_numeros_Mult.Size = New System.Drawing.Size(358, 320)
        Me.grilla_numeros_Mult.TabIndex = 20
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_constante_a_Mult)
        Me.GroupBox1.Controls.Add(Me.txt_periodo_max_Mult)
        Me.GroupBox1.Controls.Add(Me.txt_constante_c_Mult)
        Me.GroupBox1.Controls.Add(Me.txt_exponente_Mult)
        Me.GroupBox1.Controls.Add(Me.txt_intervalos_Mult)
        Me.GroupBox1.Controls.Add(Me.txt_semilla_Mult)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 320)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txt_constante_a_Mult
        '
        Me.txt_constante_a_Mult.Enabled = False
        Me.txt_constante_a_Mult.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_constante_a_Mult.Location = New System.Drawing.Point(147, 248)
        Me.txt_constante_a_Mult.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_constante_a_Mult.Name = "txt_constante_a_Mult"
        Me.txt_constante_a_Mult.Size = New System.Drawing.Size(160, 27)
        Me.txt_constante_a_Mult.TabIndex = 29
        '
        'txt_periodo_max_Mult
        '
        Me.txt_periodo_max_Mult.Enabled = False
        Me.txt_periodo_max_Mult.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_periodo_max_Mult.Location = New System.Drawing.Point(147, 218)
        Me.txt_periodo_max_Mult.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_periodo_max_Mult.Name = "txt_periodo_max_Mult"
        Me.txt_periodo_max_Mult.Size = New System.Drawing.Size(160, 27)
        Me.txt_periodo_max_Mult.TabIndex = 28
        '
        'txt_constante_c_Mult
        '
        Me.txt_constante_c_Mult.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_constante_c_Mult.Location = New System.Drawing.Point(147, 186)
        Me.txt_constante_c_Mult.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_constante_c_Mult.Name = "txt_constante_c_Mult"
        Me.txt_constante_c_Mult.Size = New System.Drawing.Size(160, 27)
        Me.txt_constante_c_Mult.TabIndex = 23
        '
        'txt_exponente_Mult
        '
        Me.txt_exponente_Mult.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_exponente_Mult.Location = New System.Drawing.Point(147, 152)
        Me.txt_exponente_Mult.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_exponente_Mult.Name = "txt_exponente_Mult"
        Me.txt_exponente_Mult.Size = New System.Drawing.Size(160, 27)
        Me.txt_exponente_Mult.TabIndex = 21
        '
        'txt_intervalos_Mult
        '
        Me.txt_intervalos_Mult.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_intervalos_Mult.Location = New System.Drawing.Point(147, 120)
        Me.txt_intervalos_Mult.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_intervalos_Mult.Name = "txt_intervalos_Mult"
        Me.txt_intervalos_Mult.Size = New System.Drawing.Size(160, 27)
        Me.txt_intervalos_Mult.TabIndex = 19
        '
        'txt_semilla_Mult
        '
        Me.txt_semilla_Mult.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_semilla_Mult.Location = New System.Drawing.Point(147, 88)
        Me.txt_semilla_Mult.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_semilla_Mult.Name = "txt_semilla_Mult"
        Me.txt_semilla_Mult.Size = New System.Drawing.Size(160, 27)
        Me.txt_semilla_Mult.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 256)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 19)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "(a)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 225)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 19)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "(m)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 195)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 19)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "(c)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 164)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 19)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "exponente (g)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 128)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 19)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "intervalos (k)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "semilla(Xo)"
        '
        'CongruencialMultiplicativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(887, 515)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grilla_numeros_Mult)
        Me.Controls.Add(Me.btn_cargar_vector_Mult)
        Me.Controls.Add(Me.btn_cargar_aleatorios_Mult)
        Me.Name = "CongruencialMultiplicativo"
        Me.Text = "CongruencialMultiplicativo"
        CType(Me.grilla_numeros_Mult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_cargar_vector_Mult As Button
    Friend WithEvents btn_cargar_aleatorios_Mult As Button
    Friend WithEvents grilla_numeros_Mult As DataGridView
    Friend WithEvents posicion As DataGridViewTextBoxColumn
    Friend WithEvents rnd As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_constante_a_Mult As TextBox
    Friend WithEvents txt_periodo_max_Mult As TextBox
    Friend WithEvents txt_constante_c_Mult As TextBox
    Friend WithEvents txt_exponente_Mult As TextBox
    Friend WithEvents txt_intervalos_Mult As TextBox
    Friend WithEvents txt_semilla_Mult As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
