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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cantidad_muestras = New System.Windows.Forms.TextBox()
        Me.txt_intervalos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_graficar = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Intervalos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Fo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_fe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_fomenosfe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Cuadrado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_EstadisticoCalculado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_EstadisticoAcum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label2.Location = New System.Drawing.Point(344, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Intervalos :"
        '
        'txt_cantidad_muestras
        '
        Me.txt_cantidad_muestras.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad_muestras.Location = New System.Drawing.Point(130, 38)
        Me.txt_cantidad_muestras.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cantidad_muestras.Name = "txt_cantidad_muestras"
        Me.txt_cantidad_muestras.Size = New System.Drawing.Size(160, 27)
        Me.txt_cantidad_muestras.TabIndex = 7
        '
        'txt_intervalos
        '
        Me.txt_intervalos.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_intervalos.Location = New System.Drawing.Point(473, 38)
        Me.txt_intervalos.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_intervalos.Name = "txt_intervalos"
        Me.txt_intervalos.Size = New System.Drawing.Size(160, 27)
        Me.txt_intervalos.TabIndex = 9
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
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_intervalos)
        Me.GroupBox1.Controls.Add(Me.txt_cantidad_muestras)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(693, 92)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos: "
        '
        'btn_graficar
        '
        Me.btn_graficar.BackColor = System.Drawing.Color.White
        Me.btn_graficar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_graficar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_graficar.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_graficar.Image = CType(resources.GetObject("btn_graficar.Image"), System.Drawing.Image)
        Me.btn_graficar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_graficar.Location = New System.Drawing.Point(738, 29)
        Me.btn_graficar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_graficar.Name = "btn_graficar"
        Me.btn_graficar.Size = New System.Drawing.Size(162, 67)
        Me.btn_graficar.TabIndex = 18
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
        Me.btn_limpiar.Location = New System.Drawing.Point(932, 27)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(141, 69)
        Me.btn_limpiar.TabIndex = 19
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Intervalos, Me.Col_Fo, Me.Col_fe, Me.Col_fomenosfe, Me.Col_Cuadrado, Me.Col_EstadisticoCalculado, Me.Col_EstadisticoAcum})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 135)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(858, 342)
        Me.DataGridView1.TabIndex = 20
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(961, 135)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(518, 342)
        Me.Chart1.TabIndex = 21
        Me.Chart1.Text = "Chart1"
        '
        'Intervalos
        '
        Me.Intervalos.HeaderText = "Intervalo"
        Me.Intervalos.Name = "Intervalos"
        '
        'Col_Fo
        '
        Me.Col_Fo.HeaderText = "fo"
        Me.Col_Fo.Name = "Col_Fo"
        '
        'Col_fe
        '
        Me.Col_fe.HeaderText = "fe"
        Me.Col_fe.Name = "Col_fe"
        '
        'Col_fomenosfe
        '
        Me.Col_fomenosfe.HeaderText = "fo - fe"
        Me.Col_fomenosfe.Name = "Col_fomenosfe"
        '
        'Col_Cuadrado
        '
        Me.Col_Cuadrado.HeaderText = " (fo - fe) ^ 2"
        Me.Col_Cuadrado.Name = "Col_Cuadrado"
        Me.Col_Cuadrado.Width = 150
        '
        'Col_EstadisticoCalculado
        '
        Me.Col_EstadisticoCalculado.HeaderText = "((fo- fe))^2/fe"
        Me.Col_EstadisticoCalculado.Name = "Col_EstadisticoCalculado"
        Me.Col_EstadisticoCalculado.Width = 150
        '
        'Col_EstadisticoAcum
        '
        Me.Col_EstadisticoAcum.HeaderText = "Estadistico Acumulado"
        Me.Col_EstadisticoAcum.Name = "Col_EstadisticoAcum"
        Me.Col_EstadisticoAcum.Width = 120
        '
        'ChiCuadrado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1533, 665)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_graficar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ChiCuadrado"
        Me.Text = "ChiCuadrado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cantidad_muestras As TextBox
    Friend WithEvents txt_intervalos As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_graficar As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Intervalos As DataGridViewTextBoxColumn
    Friend WithEvents Col_Fo As DataGridViewTextBoxColumn
    Friend WithEvents Col_fe As DataGridViewTextBoxColumn
    Friend WithEvents Col_fomenosfe As DataGridViewTextBoxColumn
    Friend WithEvents Col_Cuadrado As DataGridViewTextBoxColumn
    Friend WithEvents Col_EstadisticoCalculado As DataGridViewTextBoxColumn
    Friend WithEvents Col_EstadisticoAcum As DataGridViewTextBoxColumn
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
