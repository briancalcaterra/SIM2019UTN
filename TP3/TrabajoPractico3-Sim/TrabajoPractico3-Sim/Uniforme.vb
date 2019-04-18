Imports System.Windows.Forms.DataVisualization.Charting
Public Class Uniforme
    Dim bandera, var As Boolean


    Private Sub btn_graficar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        Validar_campos()

        Dim cant_muestras As Integer
        Dim minimo, maximo As Double
        If var = False Then
            MsgBox("Ingrese todas las variables requeridas", MsgBoxStyle.OkOnly, "Error")
            Me.txt_cant_aleatorios.Focus()
        Else
            cant_muestras = Me.txt_cant_aleatorios.Text
            minimo = Me.txt_min.Text
            maximo = Me.txt_max.Text
            If minimo > maximo Then
                MsgBox("El limite superior debe ser mayor al limite inferior")
            Else
                Dim aleatorio, intervalos, fe, fila, j, est_acumulado As Double
                Dim k, cont_frecuencia, fo As Integer

                Dim lista(0 To cant_muestras - 1) As Double
                If rb_cinco.Checked Then
                    k = 5
                ElseIf rb_diez.Checked Then
                    k = 10
                Else
                    k = 20
                End If
                intervalos = Math.Round(((maximo - minimo) / k), 4)
                fe = cant_muestras / k
                Dim i As Double = 0
                'aca comienza el generador de numeros aleatorios
                Me.grilla_aleatorios.Rows.Clear()
                Me.dgvChiCuadrado.Rows.Clear()
                Me.grafico_uniforme.Series(0).Points.Clear()
                Me.grafico_uniforme.Series(1).Points.Clear()

                Do While i <= (cant_muestras - 1)
                    aleatorio = (maximo - minimo) * Rnd() + minimo
                    grilla_aleatorios.Rows.Add(i, FormatNumber(aleatorio, 4))
                    lista(i) = aleatorio
                    i += 1
                Loop

                fila = 0
                'frecuencia observada
                For j = minimo To maximo - 1 Step intervalos
                    fo = 0
                    For cont_frecuencia = 0 To (cant_muestras - 1) 'recorre la cantidad de muestras ingresadas por el usuario
                        If j <= lista(cont_frecuencia) Then
                            If lista(cont_frecuencia) < (j + intervalos) Then 'controla que el numero cargado en el vector este dentro de los limites de un intervalo
                                fo += 1 'cuenta la cantidad de valores que aparecen dentro de un intervalo
                            End If
                        End If
                    Next cont_frecuencia
                    grafico_uniforme.Series("Frecuencia Observada").Points.AddXY((j + intervalos), fo) '' aca graficamos el valor observado en el intervalo j
                    grafico_uniforme.Series("Frecuencia Esperada").Points.AddXY((j + intervalos), fe) ' aca graficamos el valor del esperado en el intervalo j
                    'ahora agregamos una fila en la grilla por cada uno de los intervalos generados
                    dgvChiCuadrado.Rows.Add()
                    dgvChiCuadrado.Rows((fila)).Cells(0).Value = j.ToString + " - " + (j + intervalos).ToString
                    dgvChiCuadrado.Rows((fila)).Cells(1).Value = fo
                    dgvChiCuadrado.Rows((fila)).Cells(2).Value = fe
                    Dim resta As Double
                    resta = fo - fe
                    dgvChiCuadrado.Rows((fila)).Cells(3).Value = resta
                    dgvChiCuadrado.Rows((fila)).Cells(4).Value = resta * resta
                    Dim est_calculado As Double
                    est_calculado = (resta * resta) / fe
                    dgvChiCuadrado.Rows((fila)).Cells(5).Value = FormatNumber(est_calculado, 4)
                    est_acumulado += est_calculado
                    dgvChiCuadrado.Rows((fila)).Cells(6).Value = FormatNumber(est_acumulado, 4)
                    fila += 1
                Next
                dgvChiCuadrado.Rows.Add()
                dgvChiCuadrado.Rows((fila)).Cells(5).Value = "Chi Cuadrado calculado:"
                dgvChiCuadrado.Rows((fila)).Cells(6).Style.BackColor = Color.LightBlue
                dgvChiCuadrado.Rows((fila)).Cells(6).Value = est_acumulado.ToString


                grafico_uniforme.Series("Frecuencia Observada").ChartType = SeriesChartType.Column
                grafico_uniforme.Series("Frecuencia Observada").XValueType = ChartValueType.Double
                grafico_uniforme.Series("Frecuencia Observada").YValueType = ChartValueType.Int32
                grafico_uniforme.ChartAreas(0).AxisX.Interval = intervalos
                grafico_uniforme.Series("Frecuencia Observada").IsVisibleInLegend = True

                ''Cambioamos el valor de los datos observados 
                lbl_grados.Text = "Los Grados de Libertad son: " + (k - 1).ToString
                lbl_chi_calculado.Text = "El Chi cuadrado calculado es: " + est_acumulado.ToString


            End If
        End If
    End Sub



    Private Function Validar_enteros(x1) As Boolean
        If x1 >= 0 Then
            bandera = True
        Else
            bandera = False
            MsgBox("Ingrese numeros enteros positivos", MsgBoxStyle.OkOnly, "Error")
        End If
        Return bandera
    End Function



    Private Sub Limpiar()
        Me.txt_cant_aleatorios.Text = ""
        Me.txt_max.Text = ""
        Me.txt_min.Text = ""
        Me.grilla_aleatorios.Rows.Clear()
        Me.txt_cant_aleatorios.Focus()
        Me.dgvChiCuadrado.Rows.Clear()
        Me.grafico_uniforme.Series(0).Points.Clear()
        Me.grafico_uniforme.Series(1).Points.Clear()
        Me.lbl_chi_calculado.Text = ""
        Me.lbl_grados.Text = ""

    End Sub



    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Limpiar()
    End Sub



    Private Sub Uniforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
    End Sub



    Private Function Validar_campos() As Boolean
        If (Me.txt_cant_aleatorios.Text = "" Or Me.txt_min.Text = "" Or Me.txt_max.Text = "") Then
            var = False
        Else
            var = True
        End If
        Return var
    End Function



End Class