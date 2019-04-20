<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Normal
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
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_veinte = New System.Windows.Forms.RadioButton()
        Me.rb_diez = New System.Windows.Forms.RadioButton()
        Me.rb_cinco = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_desviacion = New System.Windows.Forms.MaskedTextBox()
        Me.txt_media = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cant_numeros = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grafico_normal = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.grilla_numeros_aleatorios = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_grados_libertad = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_chi_cuadrado_calculado = New System.Windows.Forms.Label()
        Me.dgvXiCuadradoNormal = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xiCuadradoNormal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvNormal = New System.Windows.Forms.DataGridView()
        Me.intervalos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.z = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.probabilidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frecEsp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grafico_normal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grilla_numeros_aleatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvXiCuadradoNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.rb_veinte)
        Me.GroupBox1.Controls.Add(Me.rb_diez)
        Me.GroupBox1.Controls.Add(Me.rb_cinco)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_desviacion)
        Me.GroupBox1.Controls.Add(Me.txt_media)
        Me.GroupBox1.Controls.Add(Me.txt_cant_numeros)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkViolet
        Me.GroupBox1.Location = New System.Drawing.Point(22, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(869, 81)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos:"
        '
        'rb_veinte
        '
        Me.rb_veinte.AutoSize = True
        Me.rb_veinte.Location = New System.Drawing.Point(624, 38)
        Me.rb_veinte.Margin = New System.Windows.Forms.Padding(2)
        Me.rb_veinte.Name = "rb_veinte"
        Me.rb_veinte.Size = New System.Drawing.Size(44, 21)
        Me.rb_veinte.TabIndex = 8
        Me.rb_veinte.TabStop = True
        Me.rb_veinte.Text = "20"
        Me.rb_veinte.UseVisualStyleBackColor = True
        '
        'rb_diez
        '
        Me.rb_diez.AutoSize = True
        Me.rb_diez.Location = New System.Drawing.Point(497, 38)
        Me.rb_diez.Margin = New System.Windows.Forms.Padding(2)
        Me.rb_diez.Name = "rb_diez"
        Me.rb_diez.Size = New System.Drawing.Size(44, 21)
        Me.rb_diez.TabIndex = 8
        Me.rb_diez.TabStop = True
        Me.rb_diez.Text = "10"
        Me.rb_diez.UseVisualStyleBackColor = True
        '
        'rb_cinco
        '
        Me.rb_cinco.AutoSize = True
        Me.rb_cinco.Location = New System.Drawing.Point(374, 38)
        Me.rb_cinco.Margin = New System.Windows.Forms.Padding(2)
        Me.rb_cinco.Name = "rb_cinco"
        Me.rb_cinco.Size = New System.Drawing.Size(35, 21)
        Me.rb_cinco.TabIndex = 3
        Me.rb_cinco.TabStop = True
        Me.rb_cinco.Text = "5"
        Me.rb_cinco.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(140, 58)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Desviacion: "
        '
        'txt_desviacion
        '
        Me.txt_desviacion.Location = New System.Drawing.Point(247, 52)
        Me.txt_desviacion.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_desviacion.Name = "txt_desviacion"
        Me.txt_desviacion.Size = New System.Drawing.Size(56, 23)
        Me.txt_desviacion.TabIndex = 2
        '
        'txt_media
        '
        Me.txt_media.Location = New System.Drawing.Point(62, 52)
        Me.txt_media.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_media.Name = "txt_media"
        Me.txt_media.Size = New System.Drawing.Size(56, 23)
        Me.txt_media.TabIndex = 1
        '
        'txt_cant_numeros
        '
        Me.txt_cant_numeros.Location = New System.Drawing.Point(181, 21)
        Me.txt_cant_numeros.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cant_numeros.Mask = "999999"
        Me.txt_cant_numeros.Name = "txt_cant_numeros"
        Me.txt_cant_numeros.Size = New System.Drawing.Size(56, 23)
        Me.txt_cant_numeros.TabIndex = 0
        Me.txt_cant_numeros.ValidatingType = GetType(Integer)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Media:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tamaño de muestra:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(464, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Cantidad de intervalos :"
        '
        'grafico_normal
        '
        ChartArea2.Name = "ChartArea1"
        Me.grafico_normal.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.grafico_normal.Legends.Add(Legend2)
        Me.grafico_normal.Location = New System.Drawing.Point(34, 288)
        Me.grafico_normal.Margin = New System.Windows.Forms.Padding(2)
        Me.grafico_normal.Name = "grafico_normal"
        Me.grafico_normal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Frecuencia Observada"
        Me.grafico_normal.Series.Add(Series2)
        Me.grafico_normal.Size = New System.Drawing.Size(917, 405)
        Me.grafico_normal.TabIndex = 84
        Me.grafico_normal.Text = "Chart1"
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.LavenderBlush
        Me.btn_limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.ForeColor = System.Drawing.Color.MediumOrchid
        Me.btn_limpiar.Location = New System.Drawing.Point(975, 445)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(109, 54)
        Me.btn_limpiar.TabIndex = 1
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'btn_generar
        '
        Me.btn_generar.BackColor = System.Drawing.Color.LavenderBlush
        Me.btn_generar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generar.ForeColor = System.Drawing.Color.MediumOrchid
        Me.btn_generar.Location = New System.Drawing.Point(975, 370)
        Me.btn_generar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(109, 54)
        Me.btn_generar.TabIndex = 0
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = False
        '
        'grilla_numeros_aleatorios
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla_numeros_aleatorios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grilla_numeros_aleatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_numeros_aleatorios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column2})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grilla_numeros_aleatorios.DefaultCellStyle = DataGridViewCellStyle4
        Me.grilla_numeros_aleatorios.Location = New System.Drawing.Point(1107, 119)
        Me.grilla_numeros_aleatorios.Margin = New System.Windows.Forms.Padding(2)
        Me.grilla_numeros_aleatorios.Name = "grilla_numeros_aleatorios"
        Me.grilla_numeros_aleatorios.RowTemplate.Height = 24
        Me.grilla_numeros_aleatorios.Size = New System.Drawing.Size(181, 479)
        Me.grilla_numeros_aleatorios.TabIndex = 89
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "N°"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Valor"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label3.Location = New System.Drawing.Point(744, 506)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 17)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Grados de libertad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(827, 506)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 90
        '
        'lbl_grados_libertad
        '
        Me.lbl_grados_libertad.AutoSize = True
        Me.lbl_grados_libertad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lbl_grados_libertad.Location = New System.Drawing.Point(878, 506)
        Me.lbl_grados_libertad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_grados_libertad.Name = "lbl_grados_libertad"
        Me.lbl_grados_libertad.Size = New System.Drawing.Size(24, 17)
        Me.lbl_grados_libertad.TabIndex = 90
        Me.lbl_grados_libertad.Text = "00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label6.Location = New System.Drawing.Point(742, 557)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 17)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Chi cuadrado calculado:"
        '
        'lbl_chi_cuadrado_calculado
        '
        Me.lbl_chi_cuadrado_calculado.AutoSize = True
        Me.lbl_chi_cuadrado_calculado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lbl_chi_cuadrado_calculado.Location = New System.Drawing.Point(899, 557)
        Me.lbl_chi_cuadrado_calculado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_chi_cuadrado_calculado.Name = "lbl_chi_cuadrado_calculado"
        Me.lbl_chi_cuadrado_calculado.Size = New System.Drawing.Size(24, 17)
        Me.lbl_chi_cuadrado_calculado.TabIndex = 90
        Me.lbl_chi_cuadrado_calculado.Text = "00"
        '
        'dgvXiCuadradoNormal
        '
        Me.dgvXiCuadradoNormal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXiCuadradoNormal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.xiCuadradoNormal})
        Me.dgvXiCuadradoNormal.Location = New System.Drawing.Point(608, 119)
        Me.dgvXiCuadradoNormal.Name = "dgvXiCuadradoNormal"
        Me.dgvXiCuadradoNormal.ReadOnly = True
        Me.dgvXiCuadradoNormal.Size = New System.Drawing.Size(462, 153)
        Me.dgvXiCuadradoNormal.TabIndex = 59
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Intervalos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 110
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Frecuencia Observada"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Frecuencia Esperada"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'xiCuadradoNormal
        '
        Me.xiCuadradoNormal.HeaderText = "((fo-fe)^2)/fe"
        Me.xiCuadradoNormal.Name = "xiCuadradoNormal"
        Me.xiCuadradoNormal.ReadOnly = True
        '
        'dgvNormal
        '
        Me.dgvNormal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNormal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.intervalos, Me.z, Me.fo, Me.probabilidad, Me.frecEsp})
        Me.dgvNormal.Location = New System.Drawing.Point(22, 119)
        Me.dgvNormal.Name = "dgvNormal"
        Me.dgvNormal.ReadOnly = True
        Me.dgvNormal.Size = New System.Drawing.Size(493, 154)
        Me.dgvNormal.TabIndex = 58
        '
        'intervalos
        '
        Me.intervalos.HeaderText = "Intervalos"
        Me.intervalos.Name = "intervalos"
        Me.intervalos.ReadOnly = True
        Me.intervalos.Width = 110
        '
        'z
        '
        Me.z.HeaderText = "marca de clase"
        Me.z.Name = "z"
        Me.z.ReadOnly = True
        Me.z.Width = 70
        '
        'fo
        '
        Me.fo.HeaderText = "fo"
        Me.fo.Name = "fo"
        Me.fo.ReadOnly = True
        '
        'probabilidad
        '
        Me.probabilidad.HeaderText = "P()"
        Me.probabilidad.Name = "probabilidad"
        Me.probabilidad.ReadOnly = True
        Me.probabilidad.Width = 80
        '
        'frecEsp
        '
        Me.frecEsp.HeaderText = "fe"
        Me.frecEsp.Name = "frecEsp"
        Me.frecEsp.ReadOnly = True
        Me.frecEsp.Width = 70
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label7.Location = New System.Drawing.Point(252, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(279, 26)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Gráfico Distribución Normal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label9.Location = New System.Drawing.Point(180, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(186, 20)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "Tabla de probabilidades"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label10.Location = New System.Drawing.Point(761, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 20)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Test Chi-Cuadrado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label11.Location = New System.Drawing.Point(1127, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 20)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "Valores generados"
        '
        'Normal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1299, 609)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_chi_cuadrado_calculado)
        Me.Controls.Add(Me.lbl_grados_libertad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grilla_numeros_aleatorios)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_generar)
        Me.Controls.Add(Me.grafico_normal)
        Me.Controls.Add(Me.dgvXiCuadradoNormal)
        Me.Controls.Add(Me.dgvNormal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Normal"
        Me.Text = "Normal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grafico_normal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grilla_numeros_aleatorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvXiCuadradoNormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNormal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_desviacion As MaskedTextBox
    Friend WithEvents txt_media As MaskedTextBox
    Friend WithEvents txt_cant_numeros As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents grafico_normal As DataVisualization.Charting.Chart
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_generar As Button
    Friend WithEvents grilla_numeros_aleatorios As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_grados_libertad As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_chi_cuadrado_calculado As Label
    Friend WithEvents rb_veinte As RadioButton
    Friend WithEvents rb_diez As RadioButton
    Friend WithEvents rb_cinco As RadioButton
    Friend WithEvents dgvXiCuadradoNormal As DataGridView
    Friend WithEvents dgvNormal As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents xiCuadradoNormal As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents intervalos As DataGridViewTextBoxColumn
    Friend WithEvents z As DataGridViewTextBoxColumn
    Friend WithEvents fo As DataGridViewTextBoxColumn
    Friend WithEvents probabilidad As DataGridViewTextBoxColumn
    Friend WithEvents frecEsp As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
