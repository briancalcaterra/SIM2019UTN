Imports System.Windows.Forms.DataVisualization.Charting
Public Class PuntoC
    Dim var, bandera As Boolean
    Dim g, k, i_ultimo As Integer
    Dim xo, c, a, aleatorio, m, x_mas_1, x_ultimo As Double


    Private Sub btn_graficar_Click(sender As Object, e As EventArgs) Handles btn_graficar.Click
        Validar_campos()

        Dim cant_muestras As Integer
        If var = False Then
            MsgBox("Ingrese todas las variables requeridas", MsgBoxStyle.OkOnly, "Error")
            Me.txt_cant_muestras.Focus()
        Else
            xo = Me.txt_semilla.Text
            g = Me.txt_exponente.Text
            k = Me.txt_intervalos.Text
            c = Me.txt_constante_c.Text
            m = 2 ^ g
            Me.txt_periodo_max.Text = m
            a = 1 + (4 * k)
            Me.txt_constante_a.Text = a

            Dim aleatorio, intervalos, fe, fila, j, est_acumulado As Double
            Dim cont_frecuencia, fo As Integer
            cant_muestras = Me.txt_cant_muestras.Text
            Dim lista(0 To cant_muestras - 1) As Double

            intervalos = Math.Round((1 / k), 4)
            fe = cant_muestras / k

            'aca comienza el generador de numeros aleatorios
            Me.grilla_serie.Rows.Clear()
            Me.grilla_chi_cuadrado.Rows.Clear()
            Me.grafico_chi_cuadrado.Series(0).Points.Clear()
            Me.grafico_chi_cuadrado.Series(1).Points.Clear()

            'For i As Decimal = 0 To (cant_muestras - 1)
            '    aleatorio = Rnd()
            '    grilla_serie.Rows.Add(i, FormatNumber(aleatorio, 4))
            '    lista(i) = aleatorio
            'Next

            ''Aca comienza el generador de numeros con el metodo congruencial mixto
            Dim i_mixto As Integer = 0
            Do While (i_mixto <= cant_muestras - 1) 'ciclo para cargar el arreglo
                x_mas_1 = (a * xo + c) Mod (m) 'aca se calcula el valor de (x + 1), como parametro se ingresa el valor semilla
                aleatorio = x_mas_1 / m
                lista(i_mixto) = FormatNumber(aleatorio, 4)
                i_mixto = i_mixto + 1
                xo = x_mas_1 'el valor semilla se convierte en (x+1) y se utiliza para la siguiente iteracion
            Loop
            x_ultimo = x_mas_1
            'i_ultimo = i_mixto
            Dim j_mixto As Integer
            j_mixto = 0
            Me.grilla_serie.Rows.Clear()
            Do While (j_mixto <= cant_muestras - 1)
                grilla_serie.Rows.Add(j_mixto, lista(j_mixto))
                j_mixto = j_mixto + 1
            Loop
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
                grilla_chi_cuadrado.Rows((fila)).Cells(0).Value = j.ToString + " - " + (j + intervalos).ToString
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
            'grilla_chi_cuadrado.Rows.Add()
            'grilla_chi_cuadrado.Rows((fila)).Cells(5).Value = "Xi Cuadrado calculado"
            'grilla_chi_cuadrado.Rows((fila)).Cells(6).Value = est_acumulado.ToString

            grafico_chi_cuadrado.Series("Observado").ChartType = SeriesChartType.Column
            grafico_chi_cuadrado.Series("Observado").XValueType = ChartValueType.Double
            grafico_chi_cuadrado.Series("Observado").YValueType = ChartValueType.Int32
            grafico_chi_cuadrado.ChartAreas(0).AxisX.Interval = intervalos
            grafico_chi_cuadrado.Series("Observado").IsVisibleInLegend = True

            lbl_GradosDeLibrtad.Text = "Los grados de libertad son: " + (k - 1).ToString
            lbl_chiCuadrado.Text = "El Xi Cuadrado Calculado es: " + FormatNumber(est_acumulado.ToString, 5)
        End If
    End Sub




    Private Function Validar_campos() As Boolean
        If (txt_semilla.Text = "" Or txt_intervalos.Text = "" Or txt_exponente.Text = "" Or txt_constante_c.Text = "" Or txt_cant_muestras.Text = "") Then
            var = False
        Else
            var = True
        End If
        Return var
    End Function

    Private Sub Limpiar()
        Me.txt_semilla.Text = ""
        Me.txt_exponente.Text = ""
        Me.txt_intervalos.Text = ""
        Me.txt_constante_c.Text = ""
        Me.txt_periodo_max.Text = ""
        Me.txt_constante_a.Text = ""
        Me.txt_cant_muestras.Text = ""
        Me.grilla_chi_cuadrado.Rows.Clear()
        Me.grilla_serie.Rows.Clear()
        Me.txt_cant_muestras.Focus()
        Me.grafico_chi_cuadrado.Series(0).Points.Clear()
        Me.grafico_chi_cuadrado.Series(1).Points.Clear()
        Me.lbl_GradosDeLibrtad.Text = ""
        Me.lbl_chiCuadrado.Text = ""
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Limpiar()

    End Sub

End Class