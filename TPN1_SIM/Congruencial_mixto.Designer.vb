﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Congruencial_mixto))
        Me.btn_cargar_aleatorios = New System.Windows.Forms.Button()
        Me.grilla_numeros = New System.Windows.Forms.DataGridView()
        Me.posicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.txt_cant_muestras = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_siguiente = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_constante_a = New System.Windows.Forms.TextBox()
        Me.txt_periodo_max = New System.Windows.Forms.TextBox()
        Me.txt_constante_c = New System.Windows.Forms.TextBox()
        Me.txt_exponente = New System.Windows.Forms.TextBox()
        Me.txt_intervalos = New System.Windows.Forms.TextBox()
        Me.txt_semilla = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.grilla_numeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cargar_aleatorios
        '
        Me.btn_cargar_aleatorios.BackColor = System.Drawing.Color.White
        Me.btn_cargar_aleatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cargar_aleatorios.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cargar_aleatorios.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_cargar_aleatorios.Image = CType(resources.GetObject("btn_cargar_aleatorios.Image"), System.Drawing.Image)
        Me.btn_cargar_aleatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cargar_aleatorios.Location = New System.Drawing.Point(28, 261)
        Me.btn_cargar_aleatorios.Name = "btn_cargar_aleatorios"
        Me.btn_cargar_aleatorios.Size = New System.Drawing.Size(131, 54)
        Me.btn_cargar_aleatorios.TabIndex = 7
        Me.btn_cargar_aleatorios.Text = "Mostrar Grilla"
        Me.btn_cargar_aleatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cargar_aleatorios.UseVisualStyleBackColor = False
        '
        'grilla_numeros
        '
        Me.grilla_numeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_numeros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.posicion, Me.rnd})
        Me.grilla_numeros.Location = New System.Drawing.Point(14, 22)
        Me.grilla_numeros.Name = "grilla_numeros"
        Me.grilla_numeros.Size = New System.Drawing.Size(345, 447)
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
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.White
        Me.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpiar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_limpiar.Image = CType(resources.GetObject("btn_limpiar.Image"), System.Drawing.Image)
        Me.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar.Location = New System.Drawing.Point(99, 321)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(120, 56)
        Me.btn_limpiar.TabIndex = 9
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'txt_cant_muestras
        '
        Me.txt_cant_muestras.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cant_muestras.Location = New System.Drawing.Point(116, 28)
        Me.txt_cant_muestras.Name = "txt_cant_muestras"
        Me.txt_cant_muestras.Size = New System.Drawing.Size(121, 23)
        Me.txt_cant_muestras.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(12, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Muestras (n):"
        '
        'btn_siguiente
        '
        Me.btn_siguiente.BackColor = System.Drawing.Color.White
        Me.btn_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_siguiente.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_siguiente.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_siguiente.Image = CType(resources.GetObject("btn_siguiente.Image"), System.Drawing.Image)
        Me.btn_siguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_siguiente.Location = New System.Drawing.Point(165, 261)
        Me.btn_siguiente.Name = "btn_siguiente"
        Me.btn_siguiente.Size = New System.Drawing.Size(130, 54)
        Me.btn_siguiente.TabIndex = 8
        Me.btn_siguiente.Text = "Siguiente"
        Me.btn_siguiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_siguiente.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.txt_constante_a)
        Me.GroupBox1.Controls.Add(Me.txt_periodo_max)
        Me.GroupBox1.Controls.Add(Me.txt_cant_muestras)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_constante_c)
        Me.GroupBox1.Controls.Add(Me.txt_exponente)
        Me.GroupBox1.Controls.Add(Me.txt_intervalos)
        Me.GroupBox1.Controls.Add(Me.txt_semilla)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox1.Location = New System.Drawing.Point(9, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(286, 239)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos: "
        '
        'txt_constante_a
        '
        Me.txt_constante_a.Enabled = False
        Me.txt_constante_a.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_constante_a.Location = New System.Drawing.Point(116, 187)
        Me.txt_constante_a.Name = "txt_constante_a"
        Me.txt_constante_a.Size = New System.Drawing.Size(121, 23)
        Me.txt_constante_a.TabIndex = 18
        '
        'txt_periodo_max
        '
        Me.txt_periodo_max.Enabled = False
        Me.txt_periodo_max.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_periodo_max.Location = New System.Drawing.Point(116, 162)
        Me.txt_periodo_max.Name = "txt_periodo_max"
        Me.txt_periodo_max.Size = New System.Drawing.Size(121, 23)
        Me.txt_periodo_max.TabIndex = 17
        '
        'txt_constante_c
        '
        Me.txt_constante_c.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_constante_c.Location = New System.Drawing.Point(116, 136)
        Me.txt_constante_c.Name = "txt_constante_c"
        Me.txt_constante_c.Size = New System.Drawing.Size(121, 23)
        Me.txt_constante_c.TabIndex = 16
        '
        'txt_exponente
        '
        Me.txt_exponente.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_exponente.Location = New System.Drawing.Point(116, 109)
        Me.txt_exponente.Name = "txt_exponente"
        Me.txt_exponente.Size = New System.Drawing.Size(121, 23)
        Me.txt_exponente.TabIndex = 11
        '
        'txt_intervalos
        '
        Me.txt_intervalos.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_intervalos.Location = New System.Drawing.Point(116, 83)
        Me.txt_intervalos.Name = "txt_intervalos"
        Me.txt_intervalos.Size = New System.Drawing.Size(121, 23)
        Me.txt_intervalos.TabIndex = 9
        '
        'txt_semilla
        '
        Me.txt_semilla.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_semilla.Location = New System.Drawing.Point(116, 57)
        Me.txt_semilla.Name = "txt_semilla"
        Me.txt_semilla.Size = New System.Drawing.Size(121, 23)
        Me.txt_semilla.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(12, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "(a):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(12, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "(m):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(12, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "(c):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Exponente (g):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Intervalos (k):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Semilla(Xo):"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grilla_numeros)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox2.Location = New System.Drawing.Point(327, 11)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(380, 438)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Numeros Aleatorios:"
        '
        'Congruencial_mixto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(729, 482)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_siguiente)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_cargar_aleatorios)
        Me.Name = "Congruencial_mixto"
        Me.Text = "Congruencial Mixto"
        CType(Me.grilla_numeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_cargar_aleatorios As System.Windows.Forms.Button
    Friend WithEvents grilla_numeros As System.Windows.Forms.DataGridView
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents posicion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rnd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_cant_muestras As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_siguiente As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_constante_a As TextBox
    Friend WithEvents txt_periodo_max As TextBox
    Friend WithEvents txt_constante_c As TextBox
    Friend WithEvents txt_exponente As TextBox
    Friend WithEvents txt_intervalos As TextBox
    Friend WithEvents txt_semilla As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
