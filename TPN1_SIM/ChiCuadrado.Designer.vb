<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChiCuadrado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChiCuadrado))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_cantidad_muestras = New System.Windows.Forms.MaskedTextBox()
        Me.rbtn_veinte = New System.Windows.Forms.RadioButton()
        Me.rbtn_diez = New System.Windows.Forms.RadioButton()
        Me.rbtn_cinco = New System.Windows.Forms.RadioButton()
        Me.btn_graficar = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.grilla_chi_cuadrado = New System.Windows.Forms.DataGridView()
        Me.grafico_chi_cuadrado = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.grilla_serie = New System.Windows.Forms.DataGridView()
        Me.col_numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Intervalos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Fo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_fe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_fomenosfe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Cuadrado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_EstadisticoCalculado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_EstadisticoAcum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grilla_chi_cuadrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grafico_chi_cuadrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grilla_serie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(316, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Intervalos :"
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.txt_cantidad_muestras)
        Me.GroupBox1.Controls.Add(Me.rbtn_veinte)
        Me.GroupBox1.Controls.Add(Me.rbtn_diez)
        Me.GroupBox1.Controls.Add(Me.rbtn_cinco)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(697, 71)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos: "
        '
        'txt_cantidad_muestras
        '
        Me.txt_cantidad_muestras.Location = New System.Drawing.Point(147, 33)
        Me.txt_cantidad_muestras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_cantidad_muestras.Mask = "999999"
        Me.txt_cantidad_muestras.Name = "txt_cantidad_muestras"
        Me.txt_cantidad_muestras.Size = New System.Drawing.Size(144, 27)
        Me.txt_cantidad_muestras.TabIndex = 1
        '
        'rbtn_veinte
        '
        Me.rbtn_veinte.AutoSize = True
        Me.rbtn_veinte.Location = New System.Drawing.Point(597, 36)
        Me.rbtn_veinte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtn_veinte.Name = "rbtn_veinte"
        Me.rbtn_veinte.Size = New System.Drawing.Size(48, 23)
        Me.rbtn_veinte.TabIndex = 4
        Me.rbtn_veinte.TabStop = True
        Me.rbtn_veinte.Text = "20"
        Me.rbtn_veinte.UseVisualStyleBackColor = True
        '
        'rbtn_diez
        '
        Me.rbtn_diez.AutoSize = True
        Me.rbtn_diez.Location = New System.Drawing.Point(508, 36)
        Me.rbtn_diez.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtn_diez.Name = "rbtn_diez"
        Me.rbtn_diez.Size = New System.Drawing.Size(48, 23)
        Me.rbtn_diez.TabIndex = 3
        Me.rbtn_diez.TabStop = True
        Me.rbtn_diez.Text = "10"
        Me.rbtn_diez.UseVisualStyleBackColor = True
        '
        'rbtn_cinco
        '
        Me.rbtn_cinco.AutoSize = True
        Me.rbtn_cinco.Location = New System.Drawing.Point(427, 36)
        Me.rbtn_cinco.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtn_cinco.Name = "rbtn_cinco"
        Me.rbtn_cinco.Size = New System.Drawing.Size(39, 23)
        Me.rbtn_cinco.TabIndex = 2
        Me.rbtn_cinco.TabStop = True
        Me.rbtn_cinco.Text = "5"
        Me.rbtn_cinco.UseVisualStyleBackColor = True
        '
        'btn_graficar
        '
        Me.btn_graficar.BackColor = System.Drawing.Color.White
        Me.btn_graficar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_graficar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_graficar.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_graficar.Image = CType(resources.GetObject("btn_graficar.Image"), System.Drawing.Image)
        Me.btn_graficar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_graficar.Location = New System.Drawing.Point(739, 27)
        Me.btn_graficar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_graficar.Name = "btn_graficar"
        Me.btn_graficar.Size = New System.Drawing.Size(163, 55)
        Me.btn_graficar.TabIndex = 0
        Me.btn_graficar.Text = "Ver Grafico"
        Me.btn_graficar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_graficar.UseVisualStyleBackColor = False
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.White
        Me.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpiar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_limpiar.Image = CType(resources.GetObject("btn_limpiar.Image"), System.Drawing.Image)
        Me.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar.Location = New System.Drawing.Point(934, 27)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(159, 55)
        Me.btn_limpiar.TabIndex = 1
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'grilla_chi_cuadrado
        '
        Me.grilla_chi_cuadrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_chi_cuadrado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Intervalos, Me.Col_Fo, Me.Col_fe, Me.Col_fomenosfe, Me.Col_Cuadrado, Me.Col_EstadisticoCalculado, Me.Col_EstadisticoAcum})
        Me.grilla_chi_cuadrado.Location = New System.Drawing.Point(12, 133)
        Me.grilla_chi_cuadrado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grilla_chi_cuadrado.Name = "grilla_chi_cuadrado"
        Me.grilla_chi_cuadrado.RowTemplate.Height = 24
        Me.grilla_chi_cuadrado.Size = New System.Drawing.Size(873, 303)
        Me.grilla_chi_cuadrado.TabIndex = 20
        '
        'grafico_chi_cuadrado
        '
        ChartArea1.Name = "ChartArea1"
        Me.grafico_chi_cuadrado.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.grafico_chi_cuadrado.Legends.Add(Legend1)
        Me.grafico_chi_cuadrado.Location = New System.Drawing.Point(12, 512)
        Me.grafico_chi_cuadrado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grafico_chi_cuadrado.Name = "grafico_chi_cuadrado"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Observado"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Esperado"
        Me.grafico_chi_cuadrado.Series.Add(Series1)
        Me.grafico_chi_cuadrado.Series.Add(Series2)
        Me.grafico_chi_cuadrado.Size = New System.Drawing.Size(873, 309)
        Me.grafico_chi_cuadrado.TabIndex = 21
        Me.grafico_chi_cuadrado.Text = "Chart1"
        '
        'grilla_serie
        '
        Me.grilla_serie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_serie.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_numero, Me.col_num})
        Me.grilla_serie.Location = New System.Drawing.Point(952, 133)
        Me.grilla_serie.Name = "grilla_serie"
        Me.grilla_serie.RowTemplate.Height = 24
        Me.grilla_serie.Size = New System.Drawing.Size(240, 508)
        Me.grilla_serie.TabIndex = 22
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(28, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 19)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Grilla:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(28, 481)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Grafico:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(948, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 19)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Serie de Numeros:"
        '
        'ChiCuadrado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1237, 878)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grilla_serie)
        Me.Controls.Add(Me.grafico_chi_cuadrado)
        Me.Controls.Add(Me.grilla_chi_cuadrado)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_graficar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ChiCuadrado"
        Me.Text = "ChiCuadrado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grilla_chi_cuadrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grafico_chi_cuadrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grilla_serie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_graficar As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents grilla_chi_cuadrado As DataGridView
    Friend WithEvents grafico_chi_cuadrado As DataVisualization.Charting.Chart
    Friend WithEvents rbtn_veinte As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_diez As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_cinco As System.Windows.Forms.RadioButton
    Friend WithEvents txt_cantidad_muestras As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grilla_serie As DataGridView
    Friend WithEvents col_numero As DataGridViewTextBoxColumn
    Friend WithEvents col_num As DataGridViewTextBoxColumn
    Friend WithEvents Intervalos As DataGridViewTextBoxColumn
    Friend WithEvents Col_Fo As DataGridViewTextBoxColumn
    Friend WithEvents Col_fe As DataGridViewTextBoxColumn
    Friend WithEvents Col_fomenosfe As DataGridViewTextBoxColumn
    Friend WithEvents Col_Cuadrado As DataGridViewTextBoxColumn
    Friend WithEvents Col_EstadisticoCalculado As DataGridViewTextBoxColumn
    Friend WithEvents Col_EstadisticoAcum As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
