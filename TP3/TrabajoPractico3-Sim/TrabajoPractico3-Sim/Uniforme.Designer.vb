<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Uniforme
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_diez = New System.Windows.Forms.RadioButton()
        Me.rb_veinte = New System.Windows.Forms.RadioButton()
        Me.rb_cinco = New System.Windows.Forms.RadioButton()
        Me.txt_max = New System.Windows.Forms.MaskedTextBox()
        Me.txt_min = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cant_aleatorios = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_chi_calculado = New System.Windows.Forms.Label()
        Me.lbl_grados = New System.Windows.Forms.Label()
        Me.grafico_uniforme = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.grilla_aleatorios = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.dgvChiCuadrado = New System.Windows.Forms.DataGridView()
        Me.intervalo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frecuenciaObservada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frecuenciaEsperada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diferenciaDeFrecuencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diferenciaAlCuadrado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xCuadradoI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chi_acumulado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grafico_uniforme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grilla_aleatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvChiCuadrado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.rb_diez)
        Me.GroupBox1.Controls.Add(Me.rb_veinte)
        Me.GroupBox1.Controls.Add(Me.rb_cinco)
        Me.GroupBox1.Controls.Add(Me.txt_max)
        Me.GroupBox1.Controls.Add(Me.txt_min)
        Me.GroupBox1.Controls.Add(Me.txt_cant_aleatorios)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkViolet
        Me.GroupBox1.Location = New System.Drawing.Point(27, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(957, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos:"
        '
        'rb_diez
        '
        Me.rb_diez.AutoSize = True
        Me.rb_diez.Location = New System.Drawing.Point(585, 33)
        Me.rb_diez.Name = "rb_diez"
        Me.rb_diez.Size = New System.Drawing.Size(50, 24)
        Me.rb_diez.TabIndex = 7
        Me.rb_diez.TabStop = True
        Me.rb_diez.Text = "10"
        Me.rb_diez.UseVisualStyleBackColor = True
        '
        'rb_veinte
        '
        Me.rb_veinte.AutoSize = True
        Me.rb_veinte.Location = New System.Drawing.Point(734, 33)
        Me.rb_veinte.Name = "rb_veinte"
        Me.rb_veinte.Size = New System.Drawing.Size(50, 24)
        Me.rb_veinte.TabIndex = 7
        Me.rb_veinte.TabStop = True
        Me.rb_veinte.Text = "20"
        Me.rb_veinte.UseVisualStyleBackColor = True
        '
        'rb_cinco
        '
        Me.rb_cinco.AutoSize = True
        Me.rb_cinco.Location = New System.Drawing.Point(436, 33)
        Me.rb_cinco.Name = "rb_cinco"
        Me.rb_cinco.Size = New System.Drawing.Size(40, 24)
        Me.rb_cinco.TabIndex = 7
        Me.rb_cinco.TabStop = True
        Me.rb_cinco.Text = "5"
        Me.rb_cinco.UseVisualStyleBackColor = True
        '
        'txt_max
        '
        Me.txt_max.Location = New System.Drawing.Point(294, 64)
        Me.txt_max.Mask = "9999999"
        Me.txt_max.Name = "txt_max"
        Me.txt_max.Size = New System.Drawing.Size(78, 27)
        Me.txt_max.TabIndex = 6
        Me.txt_max.ValidatingType = GetType(Integer)
        '
        'txt_min
        '
        Me.txt_min.Location = New System.Drawing.Point(87, 64)
        Me.txt_min.Mask = "9999999"
        Me.txt_min.Name = "txt_min"
        Me.txt_min.Size = New System.Drawing.Size(73, 27)
        Me.txt_min.TabIndex = 4
        Me.txt_min.ValidatingType = GetType(Integer)
        '
        'txt_cant_aleatorios
        '
        Me.txt_cant_aleatorios.Location = New System.Drawing.Point(199, 30)
        Me.txt_cant_aleatorios.Mask = "9999999"
        Me.txt_cant_aleatorios.Name = "txt_cant_aleatorios"
        Me.txt_cant_aleatorios.Size = New System.Drawing.Size(101, 27)
        Me.txt_cant_aleatorios.TabIndex = 3
        Me.txt_cant_aleatorios.ValidatingType = GetType(Integer)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(306, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Intervalos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tamaño de muestra:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Desde:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hasta:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.lbl_chi_calculado)
        Me.GroupBox2.Controls.Add(Me.lbl_grados)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkViolet
        Me.GroupBox2.Location = New System.Drawing.Point(1029, 13)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(327, 100)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Obtenidos:"
        '
        'lbl_chi_calculado
        '
        Me.lbl_chi_calculado.AutoSize = True
        Me.lbl_chi_calculado.Location = New System.Drawing.Point(32, 66)
        Me.lbl_chi_calculado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_chi_calculado.Name = "lbl_chi_calculado"
        Me.lbl_chi_calculado.Size = New System.Drawing.Size(130, 20)
        Me.lbl_chi_calculado.TabIndex = 27
        Me.lbl_chi_calculado.Text = "Chi-calculado:"
        '
        'lbl_grados
        '
        Me.lbl_grados.AutoSize = True
        Me.lbl_grados.Location = New System.Drawing.Point(32, 40)
        Me.lbl_grados.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_grados.Name = "lbl_grados"
        Me.lbl_grados.Size = New System.Drawing.Size(165, 20)
        Me.lbl_grados.TabIndex = 27
        Me.lbl_grados.Text = "Grados de libertad"
        '
        'grafico_uniforme
        '
        ChartArea2.Name = "ChartArea1"
        Me.grafico_uniforme.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.grafico_uniforme.Legends.Add(Legend2)
        Me.grafico_uniforme.Location = New System.Drawing.Point(12, 326)
        Me.grafico_uniforme.Name = "grafico_uniforme"
        Me.grafico_uniforme.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Frecuencia Observada"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Frecuencia Esperada"
        Me.grafico_uniforme.Series.Add(Series3)
        Me.grafico_uniforme.Series.Add(Series4)
        Me.grafico_uniforme.Size = New System.Drawing.Size(1089, 464)
        Me.grafico_uniforme.TabIndex = 83
        Me.grafico_uniforme.Text = "Chart1"
        '
        'grilla_aleatorios
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla_aleatorios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grilla_aleatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_aleatorios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grilla_aleatorios.DefaultCellStyle = DataGridViewCellStyle7
        Me.grilla_aleatorios.Location = New System.Drawing.Point(1122, 132)
        Me.grilla_aleatorios.Name = "grilla_aleatorios"
        Me.grilla_aleatorios.RowTemplate.Height = 24
        Me.grilla_aleatorios.Size = New System.Drawing.Size(192, 468)
        Me.grilla_aleatorios.TabIndex = 84
        '
        'Column1
        '
        Me.Column1.HeaderText = "N°"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Valor"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 50
        '
        'btn_generar
        '
        Me.btn_generar.BackColor = System.Drawing.Color.LavenderBlush
        Me.btn_generar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generar.ForeColor = System.Drawing.Color.MediumOrchid
        Me.btn_generar.Location = New System.Drawing.Point(1158, 630)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(116, 67)
        Me.btn_generar.TabIndex = 85
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = False
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.LavenderBlush
        Me.btn_limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.ForeColor = System.Drawing.Color.MediumOrchid
        Me.btn_limpiar.Location = New System.Drawing.Point(1158, 703)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(116, 67)
        Me.btn_limpiar.TabIndex = 86
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'dgvChiCuadrado
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvChiCuadrado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvChiCuadrado.ColumnHeadersHeight = 25
        Me.dgvChiCuadrado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.intervalo, Me.frecuenciaObservada, Me.frecuenciaEsperada, Me.diferenciaDeFrecuencia, Me.diferenciaAlCuadrado, Me.xCuadradoI, Me.chi_acumulado})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvChiCuadrado.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvChiCuadrado.Location = New System.Drawing.Point(12, 132)
        Me.dgvChiCuadrado.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvChiCuadrado.Name = "dgvChiCuadrado"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvChiCuadrado.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvChiCuadrado.Size = New System.Drawing.Size(660, 187)
        Me.dgvChiCuadrado.TabIndex = 51
        '
        'intervalo
        '
        Me.intervalo.HeaderText = "Intervalo"
        Me.intervalo.Name = "intervalo"
        '
        'frecuenciaObservada
        '
        Me.frecuenciaObservada.HeaderText = "Fo"
        Me.frecuenciaObservada.Name = "frecuenciaObservada"
        Me.frecuenciaObservada.Width = 64
        '
        'frecuenciaEsperada
        '
        Me.frecuenciaEsperada.HeaderText = "Fe"
        Me.frecuenciaEsperada.Name = "frecuenciaEsperada"
        Me.frecuenciaEsperada.Width = 63
        '
        'diferenciaDeFrecuencia
        '
        Me.diferenciaDeFrecuencia.HeaderText = "(Fo-Fe)"
        Me.diferenciaDeFrecuencia.Name = "diferenciaDeFrecuencia"
        Me.diferenciaDeFrecuencia.Width = 64
        '
        'diferenciaAlCuadrado
        '
        Me.diferenciaAlCuadrado.HeaderText = "(Fo-Fe)^2"
        Me.diferenciaAlCuadrado.Name = "diferenciaAlCuadrado"
        Me.diferenciaAlCuadrado.Width = 80
        '
        'xCuadradoI
        '
        Me.xCuadradoI.HeaderText = "((Fo-Fe)^2)/Fe"
        Me.xCuadradoI.Name = "xCuadradoI"
        Me.xCuadradoI.Width = 120
        '
        'chi_acumulado
        '
        Me.chi_acumulado.HeaderText = "Chi-Acumulado"
        Me.chi_acumulado.Name = "chi_acumulado"
        Me.chi_acumulado.Width = 120
        '
        'Uniforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1389, 844)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_generar)
        Me.Controls.Add(Me.grilla_aleatorios)
        Me.Controls.Add(Me.grafico_uniforme)
        Me.Controls.Add(Me.dgvChiCuadrado)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Uniforme"
        Me.Text = "Uniforme"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grafico_uniforme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grilla_aleatorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvChiCuadrado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cant_aleatorios As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_max As MaskedTextBox
    Friend WithEvents txt_min As MaskedTextBox
    Friend WithEvents grafico_uniforme As DataVisualization.Charting.Chart
    Friend WithEvents grilla_aleatorios As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents btn_generar As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents lbl_grados As Label
    Friend WithEvents rb_diez As RadioButton
    Friend WithEvents rb_veinte As RadioButton
    Friend WithEvents rb_cinco As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvChiCuadrado As DataGridView
    Friend WithEvents lbl_chi_calculado As Label
    Friend WithEvents intervalo As DataGridViewTextBoxColumn
    Friend WithEvents frecuenciaObservada As DataGridViewTextBoxColumn
    Friend WithEvents frecuenciaEsperada As DataGridViewTextBoxColumn
    Friend WithEvents diferenciaDeFrecuencia As DataGridViewTextBoxColumn
    Friend WithEvents diferenciaAlCuadrado As DataGridViewTextBoxColumn
    Friend WithEvents xCuadradoI As DataGridViewTextBoxColumn
    Friend WithEvents chi_acumulado As DataGridViewTextBoxColumn
End Class
