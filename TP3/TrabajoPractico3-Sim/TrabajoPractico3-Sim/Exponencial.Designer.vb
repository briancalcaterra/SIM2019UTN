<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exponencial
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.dgv_exponencial = New System.Windows.Forms.DataGridView()
        Me.bnt_Limpiar = New System.Windows.Forms.Button()
        Me.bnt_Generar = New System.Windows.Forms.Button()
        Me.dgv_numerosAleatorios = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Chart_exponencial = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_20intervalos = New System.Windows.Forms.RadioButton()
        Me.rb_10intervalos = New System.Windows.Forms.RadioButton()
        Me.rb_5intervalos = New System.Windows.Forms.RadioButton()
        Me.txt_media = New System.Windows.Forms.MaskedTextBox()
        Me.txt_numeroMuestras = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_minimo_de_la_lista = New System.Windows.Forms.Label()
        Me.lbl_maximis_de_la_lista = New System.Windows.Forms.Label()
        Me.lbl_ancho_intervalo = New System.Windows.Forms.Label()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca_clase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prbabilida_observada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Po_acumulada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pe_acumulada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.po_menos_pe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Max = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.dgv_exponencial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_numerosAleatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_exponencial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_exponencial
        '
        Me.dgv_exponencial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_exponencial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero, Me.DataGridViewTextBoxColumn14, Me.marca_clase, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.Prbabilida_observada, Me.Po_acumulada, Me.Pe_acumulada, Me.po_menos_pe, Me.Max})
        Me.dgv_exponencial.Location = New System.Drawing.Point(61, 154)
        Me.dgv_exponencial.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_exponencial.Name = "dgv_exponencial"
        Me.dgv_exponencial.ReadOnly = True
        Me.dgv_exponencial.Size = New System.Drawing.Size(1419, 233)
        Me.dgv_exponencial.TabIndex = 83
        '
        'bnt_Limpiar
        '
        Me.bnt_Limpiar.BackColor = System.Drawing.Color.LavenderBlush
        Me.bnt_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_Limpiar.ForeColor = System.Drawing.Color.MediumOrchid
        Me.bnt_Limpiar.Location = New System.Drawing.Point(1743, 773)
        Me.bnt_Limpiar.Name = "bnt_Limpiar"
        Me.bnt_Limpiar.Size = New System.Drawing.Size(116, 67)
        Me.bnt_Limpiar.TabIndex = 90
        Me.bnt_Limpiar.Text = "Limpiar"
        Me.bnt_Limpiar.UseVisualStyleBackColor = False
        '
        'bnt_Generar
        '
        Me.bnt_Generar.BackColor = System.Drawing.Color.LavenderBlush
        Me.bnt_Generar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_Generar.ForeColor = System.Drawing.Color.MediumOrchid
        Me.bnt_Generar.Location = New System.Drawing.Point(1743, 700)
        Me.bnt_Generar.Name = "bnt_Generar"
        Me.bnt_Generar.Size = New System.Drawing.Size(116, 67)
        Me.bnt_Generar.TabIndex = 89
        Me.bnt_Generar.Text = "Generar"
        Me.bnt_Generar.UseVisualStyleBackColor = False
        '
        'dgv_numerosAleatorios
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_numerosAleatorios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_numerosAleatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_numerosAleatorios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_numerosAleatorios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_numerosAleatorios.Location = New System.Drawing.Point(1628, 79)
        Me.dgv_numerosAleatorios.Name = "dgv_numerosAleatorios"
        Me.dgv_numerosAleatorios.RowTemplate.Height = 24
        Me.dgv_numerosAleatorios.Size = New System.Drawing.Size(231, 578)
        Me.dgv_numerosAleatorios.TabIndex = 88
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
        'Chart_exponencial
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart_exponencial.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart_exponencial.Legends.Add(Legend1)
        Me.Chart_exponencial.Location = New System.Drawing.Point(43, 410)
        Me.Chart_exponencial.Name = "Chart_exponencial"
        Me.Chart_exponencial.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Frecuencia Observada"
        Me.Chart_exponencial.Series.Add(Series1)
        Me.Chart_exponencial.Size = New System.Drawing.Size(1504, 533)
        Me.Chart_exponencial.TabIndex = 87
        Me.Chart_exponencial.Text = "Chart1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.rb_20intervalos)
        Me.GroupBox1.Controls.Add(Me.rb_10intervalos)
        Me.GroupBox1.Controls.Add(Me.rb_5intervalos)
        Me.GroupBox1.Controls.Add(Me.txt_media)
        Me.GroupBox1.Controls.Add(Me.txt_numeroMuestras)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkViolet
        Me.GroupBox1.Location = New System.Drawing.Point(61, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(668, 100)
        Me.GroupBox1.TabIndex = 91
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos:"
        '
        'rb_20intervalos
        '
        Me.rb_20intervalos.AutoSize = True
        Me.rb_20intervalos.Location = New System.Drawing.Point(374, 66)
        Me.rb_20intervalos.Name = "rb_20intervalos"
        Me.rb_20intervalos.Size = New System.Drawing.Size(50, 24)
        Me.rb_20intervalos.TabIndex = 11
        Me.rb_20intervalos.TabStop = True
        Me.rb_20intervalos.Text = "20"
        Me.rb_20intervalos.UseVisualStyleBackColor = True
        '
        'rb_10intervalos
        '
        Me.rb_10intervalos.AutoSize = True
        Me.rb_10intervalos.Location = New System.Drawing.Point(299, 66)
        Me.rb_10intervalos.Name = "rb_10intervalos"
        Me.rb_10intervalos.Size = New System.Drawing.Size(50, 24)
        Me.rb_10intervalos.TabIndex = 10
        Me.rb_10intervalos.TabStop = True
        Me.rb_10intervalos.Text = "10"
        Me.rb_10intervalos.UseVisualStyleBackColor = True
        '
        'rb_5intervalos
        '
        Me.rb_5intervalos.AutoSize = True
        Me.rb_5intervalos.Location = New System.Drawing.Point(239, 66)
        Me.rb_5intervalos.Name = "rb_5intervalos"
        Me.rb_5intervalos.Size = New System.Drawing.Size(40, 24)
        Me.rb_5intervalos.TabIndex = 9
        Me.rb_5intervalos.TabStop = True
        Me.rb_5intervalos.Text = "5"
        Me.rb_5intervalos.UseVisualStyleBackColor = True
        '
        'txt_media
        '
        Me.txt_media.Location = New System.Drawing.Point(351, 30)
        Me.txt_media.Name = "txt_media"
        Me.txt_media.Size = New System.Drawing.Size(73, 27)
        Me.txt_media.TabIndex = 5
        '
        'txt_numeroMuestras
        '
        Me.txt_numeroMuestras.Location = New System.Drawing.Point(158, 26)
        Me.txt_numeroMuestras.Name = "txt_numeroMuestras"
        Me.txt_numeroMuestras.Size = New System.Drawing.Size(73, 27)
        Me.txt_numeroMuestras.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(259, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Media:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "N° muestras:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Cantidad de intervalos :"
        '
        'lbl_minimo_de_la_lista
        '
        Me.lbl_minimo_de_la_lista.AutoSize = True
        Me.lbl_minimo_de_la_lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_minimo_de_la_lista.Location = New System.Drawing.Point(7, 27)
        Me.lbl_minimo_de_la_lista.Name = "lbl_minimo_de_la_lista"
        Me.lbl_minimo_de_la_lista.Size = New System.Drawing.Size(78, 18)
        Me.lbl_minimo_de_la_lista.TabIndex = 92
        Me.lbl_minimo_de_la_lista.Text = "Minimo ="
        '
        'lbl_maximis_de_la_lista
        '
        Me.lbl_maximis_de_la_lista.AutoSize = True
        Me.lbl_maximis_de_la_lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_maximis_de_la_lista.Location = New System.Drawing.Point(8, 67)
        Me.lbl_maximis_de_la_lista.Name = "lbl_maximis_de_la_lista"
        Me.lbl_maximis_de_la_lista.Size = New System.Drawing.Size(77, 18)
        Me.lbl_maximis_de_la_lista.TabIndex = 93
        Me.lbl_maximis_de_la_lista.Text = "Maximo="
        '
        'lbl_ancho_intervalo
        '
        Me.lbl_ancho_intervalo.AutoSize = True
        Me.lbl_ancho_intervalo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ancho_intervalo.Location = New System.Drawing.Point(180, 51)
        Me.lbl_ancho_intervalo.Name = "lbl_ancho_intervalo"
        Me.lbl_ancho_intervalo.Size = New System.Drawing.Size(148, 18)
        Me.lbl_ancho_intervalo.TabIndex = 94
        Me.lbl_ancho_intervalo.Text = "Ancho Intervalos : "
        '
        'numero
        '
        Me.numero.HeaderText = "N°"
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        Me.numero.Width = 50
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Intervalo"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'marca_clase
        '
        Me.marca_clase.HeaderText = "Marca de clase"
        Me.marca_clase.Name = "marca_clase"
        Me.marca_clase.ReadOnly = True
        Me.marca_clase.Width = 80
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Frecuencia Observada"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 80
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Pe()"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 80
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Fe"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'Prbabilida_observada
        '
        Me.Prbabilida_observada.HeaderText = "Po()"
        Me.Prbabilida_observada.Name = "Prbabilida_observada"
        Me.Prbabilida_observada.ReadOnly = True
        '
        'Po_acumulada
        '
        Me.Po_acumulada.HeaderText = "Po()Ac"
        Me.Po_acumulada.Name = "Po_acumulada"
        Me.Po_acumulada.ReadOnly = True
        '
        'Pe_acumulada
        '
        Me.Pe_acumulada.HeaderText = "Pe()Ac"
        Me.Pe_acumulada.Name = "Pe_acumulada"
        Me.Pe_acumulada.ReadOnly = True
        '
        'po_menos_pe
        '
        Me.po_menos_pe.HeaderText = "|Po(Ac)-Pe(Ac)|"
        Me.po_menos_pe.Name = "po_menos_pe"
        Me.po_menos_pe.ReadOnly = True
        Me.po_menos_pe.Width = 110
        '
        'Max
        '
        Me.Max.HeaderText = "Max"
        Me.Max.Name = "Max"
        Me.Max.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label3.Location = New System.Drawing.Point(687, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(281, 32)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Grafico y Pueba KS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label4.Location = New System.Drawing.Point(1623, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 25)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Numeros Generados:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.lbl_minimo_de_la_lista)
        Me.GroupBox2.Controls.Add(Me.lbl_maximis_de_la_lista)
        Me.GroupBox2.Controls.Add(Me.lbl_ancho_intervalo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkViolet
        Me.GroupBox2.Location = New System.Drawing.Point(1070, 13)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(410, 100)
        Me.GroupBox2.TabIndex = 97
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Obtenidos:"
        '
        'Exponencial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1882, 982)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bnt_Limpiar)
        Me.Controls.Add(Me.bnt_Generar)
        Me.Controls.Add(Me.dgv_numerosAleatorios)
        Me.Controls.Add(Me.Chart_exponencial)
        Me.Controls.Add(Me.dgv_exponencial)
        Me.Name = "Exponencial"
        Me.Text = "Exponencial"
        CType(Me.dgv_exponencial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_numerosAleatorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_exponencial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_exponencial As DataGridView
    Friend WithEvents bnt_Limpiar As Button
    Friend WithEvents bnt_Generar As Button
    Friend WithEvents dgv_numerosAleatorios As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Chart_exponencial As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_media As MaskedTextBox
    Friend WithEvents txt_numeroMuestras As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rb_5intervalos As RadioButton
    Friend WithEvents rb_20intervalos As RadioButton
    Friend WithEvents rb_10intervalos As RadioButton
    Friend WithEvents lbl_minimo_de_la_lista As Label
    Friend WithEvents lbl_maximis_de_la_lista As Label
    Friend WithEvents lbl_ancho_intervalo As Label
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents marca_clase As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents Prbabilida_observada As DataGridViewTextBoxColumn
    Friend WithEvents Po_acumulada As DataGridViewTextBoxColumn
    Friend WithEvents Pe_acumulada As DataGridViewTextBoxColumn
    Friend WithEvents po_menos_pe As DataGridViewTextBoxColumn
    Friend WithEvents Max As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
