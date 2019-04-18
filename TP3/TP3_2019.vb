Imports System.Windows.Forms.DataVisualization.Charting
Public Class Normal
    'a)	Realizar una librería que proporcione (mediante funciones o métodos) la funcionalidad necesaria para generar valores de variables 
    'aleatorias para las siguientes distribuciones: uniforme, exponencial, poisson y normal.
    'El usuario debe poder ingresar los parámetros de las distribuciones y la cantidad de valores a generar. Los valores generados deben 
    'poder ser visualizados.  
    'b)	Realizar un programa que grafique las distribuciones anteriores utilizando la librería pedida en el punto anterior. 
    '(La gráfica se aceptará que se genere en base a un archivo de salida del programa, en Excel).
    'La cantidad de intervalos de la gráfica debe ingresarse por parámetro. Y se deberá realizar pruebas de los generadores 
    '(Chi-Cuadrado o alguna otra)
    Dim var As Boolean


    Private Sub Limpiar()
        txt_cant_numeros.Text = ""
        txt_desviacion.Text = ""
        txt_media.Text = ""
        dgvNormal.Rows.Clear()
        dgvXiCuadradoNormal.Rows.Clear()
        grilla_numeros_aleatorios.Rows.Clear()
        grafico_normal.Series(0).Points.Clear()
        grafico_normal.Series(1).Points.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Limpiar()
    End Sub




    Private Function Validar_campos() As Boolean
        If (txt_cant_numeros.Text = "" Or txt_media.Text = "" Or txt_desviacion.Text = "") Then
            var = False
        Else
            var = True
        End If
        Return var
    End Function

    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        Validar_campos()

        Dim cant_aleatorios As Integer
        If var = False Then
            MsgBox("Ingrese todas las variables requeridas", MsgBoxStyle.OkOnly, "Error")
            Me.txt_cant_numeros.Focus()
        Else
            Dim media, desviacion, aleatorio, intervalos, fe, fila, j, est_acumulado As Double
            Dim k, cont_frecuencia, fo As Integer
            cant_aleatorios = Me.txt_cant_numeros.Text
            media = Me.txt_media.Text
            desviacion = Me.txt_desviacion.Text
            Dim lista(0 To cant_aleatorios - 1) As Double
            If rb_cinco.Checked Then
                k = 5
            ElseIf rb_diez.Checked Then
                k = 10
            Else
                k = 20
            End If

            intervalos = Math.Round((1 / k), 4)
            fe = cant_aleatorios / k
            Dim i As Decimal = 0
            'aca comienza el generador de numeros aleatorios
            Me.grilla_numeros_aleatorios.Rows.Clear()
            Me.dgvXiCuadradoNormal.Rows.Clear()
            Me.grafico_normal.Series(0).Points.Clear()
            Me.grafico_normal.Series(1).Points.Clear()

            Do While i <= (cant_aleatorios - 1)
                aleatorio = Rnd()
                grilla_numeros_aleatorios.Rows.Add(i, FormatNumber(aleatorio, 4))
                lista(i) = aleatorio
                i += 1
            Loop

            fila = 0
            'frecuencia observada
            For j = 0 To (0.99) Step intervalos
                fo = 0
                For cont_frecuencia = 0 To (cant_aleatorios - 1) 'recorre la cantidad de muestras ingresadas por el usuario
                    If j <= lista(cont_frecuencia) Then
                        If lista(cont_frecuencia) < (j + intervalos) Then 'controla que el numero cargado en el vector este dentro de los limites de un intervalo
                            fo += 1 'cuenta la cantidad de valores que aparecen dentro de un intervalo
                        End If
                    End If
                Next cont_frecuencia
                grafico_normal.Series("Frecuencia Observada").Points.AddXY((j + intervalos), fo) '' aca graficamos el valor observado en el intervalo j
                grafico_normal.Series("Frecuencia Esperada").Points.AddXY((j + intervalos), fe) ' aca graficamos el valor del esperado en el intervalo j
                'ahora agregamos una fila en la grilla por cada uno de los intervalos generados
                dgvXiCuadradoNormal.Rows.Add()
                dgvXiCuadradoNormal.Rows((fila)).Cells(0).Value = j.ToString + "-" + (j + intervalos).ToString
                dgvXiCuadradoNormal.Rows((fila)).Cells(1).Value = fo
                dgvXiCuadradoNormal.Rows((fila)).Cells(2).Value = fe
                Dim resta As Double
                resta = fo - fe
                dgvXiCuadradoNormal.Rows((fila)).Cells(3).Value = resta
                dgvXiCuadradoNormal.Rows((fila)).Cells(4).Value = resta * resta
                Dim est_calculado As Double
                est_calculado = (resta * resta) / fe
                dgvXiCuadradoNormal.Rows((fila)).Cells(5).Value = est_calculado
                est_acumulado += est_calculado
                dgvXiCuadradoNormal.Rows((fila)).Cells(6).Value = est_acumulado
                fila += 1
            Next
            'grilla_chi_cuadrado.Rows.Add()
            'grilla_chi_cuadrado.Rows((fila)).Cells(5).Value = "Xi Cuadrado calculado"
            'grilla_chi_cuadrado.Rows((fila)).Cells(6).Value = est_acumulado.ToString


            grafico_normal.Series("Frecuencia Observada").ChartType = SeriesChartType.Column
            grafico_normal.Series("Frecuencia Observada").XValueType = ChartValueType.Double
            grafico_normal.Series("Frecuencia Observada").YValueType = ChartValueType.Int32
            grafico_normal.ChartAreas(0).AxisX.Interval = intervalos
            grafico_normal.Series("Frecuencia Observada").IsVisibleInLegend = True

            ''Cambiamos el valor de los datos observados 
            lbl_grados_libertad.Text = (k - 1).ToString
            lbl_chi_cuadrado_calculado.Text = est_acumulado.ToString



        End If
    End Sub

    Private Sub Normal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
    End Sub
End Class