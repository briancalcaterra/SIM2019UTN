Imports System.Windows.Forms.DataVisualization.Charting
Public Class ChiCuadrado

    Dim bandera, var As Boolean


    Private Sub ChiCuadrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_graficar_Click(sender As Object, e As EventArgs) Handles btn_graficar.Click
        Validar_campos()

        Dim cant_muestras As Integer
        If var = False Then
            MsgBox("Ingrese todas las variables requeridas", MsgBoxStyle.OkOnly, "Error")
            Me.txt_cantidad_muestras.Focus()
        Else


            Dim aleatorio, intervalos, fe, fila, j, est_acumulado As Double
            Dim k, cont_frecuencia, fo As Integer
            cant_muestras = Me.txt_cantidad_muestras.Text
            Dim lista(0 To cant_muestras - 1) As Double
            k = Me.txt_intervalos.Text
            intervalos = Math.Round((1 / k), 4)
            fe = cant_muestras / k

            'aca comienza el generador de numeros aleatorios
            Me.grilla_serie.Rows.Clear()
            Me.grilla_chi_cuadrado.Rows.Clear()
            Me.grafico_chi_cuadrado.Series(0).Points.Clear()
            Me.grafico_chi_cuadrado.Series(1).Points.Clear()

            For i As Decimal = 0 To (cant_muestras - 1)
                aleatorio = Rnd()
                grilla_serie.Rows.Add(i, FormatNumber(aleatorio, 4))
                lista(i) = aleatorio
            Next

            fila = 0
            'frecuencia observada
            For j = 0 To (0.99) Step intervalos
                fo = 0
                For cont_frecuencia = 0 To (cant_muestras - 1) 'recorre la cantidad de muestras ingresadas por el usuario
                    If j <= lista(cont_frecuencia) Then
                        If lista(cont_frecuencia) < (j + intervalos) Then 'controla que el numero cargado en el vector este dentro de los limites de un intervalo
                            fo += 1 'cuenta la cantidad de valores que aparecen dentro de un intervalo
                        End If
                    End If
                Next cont_frecuencia
                grafico_chi_cuadrado.Series("Observado").Points.AddXY((j + intervalos), fo) ''graficamos el valor observado en el intervalo j
                grafico_chi_cuadrado.Series("Esperado").Points.AddXY((j + intervalos), fe) 'graficamos el valor del esperado en el intervalo j
                'ahora agregamos una fila en la grilla por cada uno de los intervalos generados
                grilla_chi_cuadrado.Rows.Add()
                grilla_chi_cuadrado.Rows((fila)).Cells(0).Value = j.ToString + "-" + (j + intervalos).ToString
                grilla_chi_cuadrado.Rows((fila)).Cells(1).Value = fo
                grilla_chi_cuadrado.Rows((fila)).Cells(2).Value = fe
                Dim resta As Double
                resta = fo - fe
                grilla_chi_cuadrado.Rows((fila)).Cells(3).Value = resta
                grilla_chi_cuadrado.Rows((fila)).Cells(4).Value = resta * resta
                Dim est_calculado As Double
                est_calculado = (resta * resta) / fe
                grilla_chi_cuadrado.Rows((fila)).Cells(5).Value = est_calculado
                est_acumulado += est_calculado
                grilla_chi_cuadrado.Rows((fila)).Cells(6).Value = est_acumulado
                fila += 1
            Next
            grilla_chi_cuadrado.Rows.Add()
            grilla_chi_cuadrado.Rows((fila)).Cells(5).Value = "Xi Cuadrado calculado"
            grilla_chi_cuadrado.Rows((fila)).Cells(6).Value = est_acumulado.ToString


            grafico_chi_cuadrado.Series("Observado").ChartType = SeriesChartType.Column
            grafico_chi_cuadrado.Series("Observado").XValueType = ChartValueType.Double
            grafico_chi_cuadrado.Series("Observado").YValueType = ChartValueType.Int32
            grafico_chi_cuadrado.ChartAreas(0).AxisX.Interval = intervalos
            grafico_chi_cuadrado.Series("Observado").IsVisibleInLegend = True

            lbl_GradosDeLibrtad.Text = "Los grados de libertad son: " + (k - 1).ToString



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
        Me.txt_cantidad_muestras.Text = ""
        Me.txt_intervalos.Text = ""
        Me.grilla_chi_cuadrado.Rows.Clear()
        Me.txt_cantidad_muestras.Focus()
        Me.grilla_serie.Rows.Clear()
        Me.grafico_chi_cuadrado.Series(0).Points.Clear()
        Me.grafico_chi_cuadrado.Series(1).Points.Clear()

    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Limpiar()
    End Sub



    Private Function Validar_campos() As Boolean
        If (Me.txt_cantidad_muestras.Text = "" Or Me.txt_intervalos.Text = "") Then
            var = False
        Else
            var = True
        End If
        Return var
    End Function



End Class