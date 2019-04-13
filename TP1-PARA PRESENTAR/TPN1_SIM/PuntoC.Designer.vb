<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PuntoC
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PuntoC))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grilla_serie = New System.Windows.Forms.DataGridView()
        Me.col_numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grafico_chi_cuadrado = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.grilla_chi_cuadrado = New System.Windows.Forms.DataGridView()
        Me.Intervalos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Fo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_fe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_fomenosfe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Cuadrado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_EstadisticoCalculado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_EstadisticoAcum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_graficar = New System.Windows.Forms.Button()
        Me.lbl_GradosDeLibrtad = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_exponente = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_intervalos = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_constante_a = New System.Windows.Forms.TextBox()
        Me.txt_periodo_max = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_constante_c = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_semilla = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cant_muestras = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_chiCuadrado = New System.Windows.Forms.Label()
        CType(Me.grilla_serie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grafico_chi_cuadrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grilla_chi_cuadrado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(922, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 19)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Serie de Numeros:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(390, 479)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Grafico:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(28, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 19)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Grilla:"
        '
        'grilla_serie
        '
        Me.grilla_serie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_serie.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_numero, Me.col_num})
        Me.grilla_serie.Location = New System.Drawing.Point(926, 284)
        Me.grilla_serie.Name = "grilla_serie"
        Me.grilla_serie.RowTemplate.Height = 24
        Me.grilla_serie.Size = New System.Drawing.Size(240, 419)
        Me.grilla_serie.TabIndex = 31
        '
        'col_numero
        '
        Me.col_numero.HeaderText = "Posicion"
        Me.col_numero.Name = "col_numero"
        Me.col_numero.Width = 60
        '
        'col_num
        '
        Me.col_num.HeaderText = "Numero"
        Me.col_num.Name = "col_num"
        Me.col_num.Width = 60
        '
        'grafico_chi_cuadrado
        '
        ChartArea1.Name = "ChartArea1"
        Me.grafico_chi_cuadrado.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.grafico_chi_cuadrado.Legends.Add(Legend1)
        Me.grafico_chi_cuadrado.Location = New System.Drawing.Point(12, 509)
        Me.grafico_chi_cuadrado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grafico_chi_cuadrado.Name = "grafico_chi_cuadrado"
        Me.grafico_chi_cuadrado.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Observado"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Esperado"
        Me.grafico_chi_cuadrado.Series.Add(Series1)
        Me.grafico_chi_cuadrado.Series.Add(Series2)
        Me.grafico_chi_cuadrado.Size = New System.Drawing.Size(873, 349)
        Me.grafico_chi_cuadrado.TabIndex = 30
        Me.grafico_chi_cuadrado.Text = "Chart1"
        '
        'grilla_chi_cuadrado
        '
        Me.grilla_chi_cuadrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_chi_cuadrado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Intervalos, Me.Col_Fo, Me.Col_fe, Me.Col_fomenosfe, Me.Col_Cuadrado, Me.Col_EstadisticoCalculado, Me.Col_EstadisticoAcum})
        Me.grilla_chi_cuadrado.Location = New System.Drawing.Point(12, 162)
        Me.grilla_chi_cuadrado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grilla_chi_cuadrado.Name = "grilla_chi_cuadrado"
        Me.grilla_chi_cuadrado.RowTemplate.Height = 24
        Me.grilla_chi_cuadrado.Size = New System.Drawing.Size(873, 298)
        Me.grilla_chi_cuadrado.TabIndex = 29
        '
        'Intervalos
        '
        Me.Intervalos.HeaderText = "Intervalo"
        Me.Intervalos.Name = "Intervalos"
        Me.Intervalos.Width = 90
        '
        'Col_Fo
        '
        Me.Col_Fo.HeaderText = "fo"
        Me.Col_Fo.Name = "Col_Fo"
        Me.Col_Fo.Width = 85
        '
        'Col_fe
        '
        Me.Col_fe.HeaderText = "fe"
        Me.Col_fe.Name = "Col_fe"
        Me.Col_fe.Width = 85
        '
        'Col_fomenosfe
        '
        Me.Col_fomenosfe.HeaderText = "fo - fe"
        Me.Col_fomenosfe.Name = "Col_fomenosfe"
        Me.Col_fomenosfe.Width = 85
        '
        'Col_Cuadrado
        '
        Me.Col_Cuadrado.HeaderText = " (fo - fe) ^ 2"
        Me.Col_Cuadrado.Name = "Col_Cuadrado"
        Me.Col_Cuadrado.Width = 90
        '
        'Col_EstadisticoCalculado
        '
        Me.Col_EstadisticoCalculado.HeaderText = "((fo- fe))^2/fe"
        Me.Col_EstadisticoCalculado.Name = "Col_EstadisticoCalculado"
        '
        'Col_EstadisticoAcum
        '
        Me.Col_EstadisticoAcum.HeaderText = "Estadistico Acumulado"
        Me.Col_EstadisticoAcum.Name = "Col_EstadisticoAcum"
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.White
        Me.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpiar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_limpiar.Image = CType(resources.GetObject("btn_limpiar.Image"), System.Drawing.Image)
        Me.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar.Location = New System.Drawing.Point(1133, 725)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(159, 55)
        Me.btn_limpiar.TabIndex = 1
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'btn_graficar
        '
        Me.btn_graficar.BackColor = System.Drawing.Color.White
        Me.btn_graficar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_graficar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_graficar.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_graficar.Image = CType(resources.GetObject("btn_graficar.Image"), System.Drawing.Image)
        Me.btn_graficar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_graficar.Location = New System.Drawing.Point(916, 725)
        Me.btn_graficar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_graficar.Name = "btn_graficar"
        Me.btn_graficar.Size = New System.Drawing.Size(163, 55)
        Me.btn_graficar.TabIndex = 0
        Me.btn_graficar.Text = "Ver Grafico"
        Me.btn_graficar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_graficar.UseVisualStyleBackColor = False
        '
        'lbl_GradosDeLibrtad
        '
        Me.lbl_GradosDeLibrtad.AutoSize = True
        Me.lbl_GradosDeLibrtad.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GradosDeLibrtad.ForeColor = System.Drawing.Color.Magenta
        Me.lbl_GradosDeLibrtad.Location = New System.Drawing.Point(6, 34)
        Me.lbl_GradosDeLibrtad.Name = "lbl_GradosDeLibrtad"
        Me.lbl_GradosDeLibrtad.Size = New System.Drawing.Size(196, 22)
        Me.lbl_GradosDeLibrtad.TabIndex = 35
        Me.lbl_GradosDeLibrtad.Text = "Grados de Libertad:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.txt_exponente)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_intervalos)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_constante_a)
        Me.GroupBox1.Controls.Add(Me.txt_periodo_max)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_constante_c)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_semilla)
        Me.GroupBox1.Controls.Add(Me.txt_cant_muestras)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1311, 103)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos: "
        '
        'txt_exponente
        '
        Me.txt_exponente.Location = New System.Drawing.Point(493, 59)
        Me.txt_exponente.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_exponente.Mask = "999999"
        Me.txt_exponente.Name = "txt_exponente"
        Me.txt_exponente.Size = New System.Drawing.Size(160, 27)
        Me.txt_exponente.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(354, 68)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 19)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Exponente (g):"
        '
        'txt_intervalos
        '
        Me.txt_intervalos.Location = New System.Drawing.Point(493, 24)
        Me.txt_intervalos.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_intervalos.Mask = "999999"
        Me.txt_intervalos.Name = "txt_intervalos"
        Me.txt_intervalos.Size = New System.Drawing.Size(160, 27)
        Me.txt_intervalos.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(354, 33)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 19)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Intervalos (k):"
        '
        'txt_constante_a
        '
        Me.txt_constante_a.Enabled = False
        Me.txt_constante_a.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_constante_a.Location = New System.Drawing.Point(1010, 26)
        Me.txt_constante_a.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_constante_a.Name = "txt_constante_a"
        Me.txt_constante_a.Size = New System.Drawing.Size(160, 27)
        Me.txt_constante_a.TabIndex = 25
        '
        'txt_periodo_max
        '
        Me.txt_periodo_max.Enabled = False
        Me.txt_periodo_max.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_periodo_max.Location = New System.Drawing.Point(729, 57)
        Me.txt_periodo_max.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_periodo_max.Name = "txt_periodo_max"
        Me.txt_periodo_max.Size = New System.Drawing.Size(160, 27)
        Me.txt_periodo_max.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(967, 27)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 19)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "(a):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(677, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 19)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "(m):"
        '
        'txt_constante_c
        '
        Me.txt_constante_c.Location = New System.Drawing.Point(729, 25)
        Me.txt_constante_c.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_constante_c.Mask = "999999"
        Me.txt_constante_c.Name = "txt_constante_c"
        Me.txt_constante_c.Size = New System.Drawing.Size(160, 27)
        Me.txt_constante_c.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(677, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 19)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "(c):"
        '
        'txt_semilla
        '
        Me.txt_semilla.Location = New System.Drawing.Point(155, 65)
        Me.txt_semilla.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_semilla.Mask = "999999"
        Me.txt_semilla.Name = "txt_semilla"
        Me.txt_semilla.Size = New System.Drawing.Size(160, 27)
        Me.txt_semilla.TabIndex = 1
        '
        'txt_cant_muestras
        '
        Me.txt_cant_muestras.Location = New System.Drawing.Point(155, 30)
        Me.txt_cant_muestras.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cant_muestras.Mask = "999999"
        Me.txt_cant_muestras.Name = "txt_cant_muestras"
        Me.txt_cant_muestras.Size = New System.Drawing.Size(160, 27)
        Me.txt_cant_muestras.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(16, 38)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Muestras (n):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(16, 75)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 19)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Semilla(Xo):"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.lbl_chiCuadrado)
        Me.GroupBox2.Controls.Add(Me.lbl_GradosDeLibrtad)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox2.Location = New System.Drawing.Point(916, 118)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(383, 103)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Observados:  "
        '
        'lbl_chiCuadrado
        '
        Me.lbl_chiCuadrado.AutoSize = True
        Me.lbl_chiCuadrado.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_chiCuadrado.ForeColor = System.Drawing.Color.Magenta
        Me.lbl_chiCuadrado.Location = New System.Drawing.Point(6, 69)
        Me.lbl_chiCuadrado.Name = "lbl_chiCuadrado"
        Me.lbl_chiCuadrado.Size = New System.Drawing.Size(230, 22)
        Me.lbl_chiCuadrado.TabIndex = 36
        Me.lbl_chiCuadrado.Text = "Xi Cuadrado Calculado:"
        '
        'PuntoC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1361, 1040)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grilla_serie)
        Me.Controls.Add(Me.grafico_chi_cuadrado)
        Me.Controls.Add(Me.grilla_chi_cuadrado)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_graficar)
        Me.Name = "PuntoC"
        Me.Text = "PuntoC"
        CType(Me.grilla_serie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grafico_chi_cuadrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grilla_chi_cuadrado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grilla_serie As DataGridView
    Friend WithEvents col_numero As DataGridViewTextBoxColumn
    Friend WithEvents col_num As DataGridViewTextBoxColumn
    Friend WithEvents grafico_chi_cuadrado As DataVisualization.Charting.Chart
    Friend WithEvents grilla_chi_cuadrado As DataGridView
    Friend WithEvents Intervalos As DataGridViewTextBoxColumn
    Friend WithEvents Col_Fo As DataGridViewTextBoxColumn
    Friend WithEvents Col_fe As DataGridViewTextBoxColumn
    Friend WithEvents Col_fomenosfe As DataGridViewTextBoxColumn
    Friend WithEvents Col_Cuadrado As DataGridViewTextBoxColumn
    Friend WithEvents Col_EstadisticoCalculado As DataGridViewTextBoxColumn
    Friend WithEvents Col_EstadisticoAcum As DataGridViewTextBoxColumn
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_graficar As Button
    Friend WithEvents lbl_GradosDeLibrtad As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_constante_a As TextBox
    Friend WithEvents txt_periodo_max As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_constante_c As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_semilla As MaskedTextBox
    Friend WithEvents txt_cant_muestras As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_exponente As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_intervalos As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_chiCuadrado As Label
End Class
