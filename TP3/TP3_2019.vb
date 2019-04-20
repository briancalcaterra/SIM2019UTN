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
        lbl_chi_cuadrado_calculado.Text = ""
        lbl_grados_libertad.Text = ""

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


    Private Function Validar_positivos() As Boolean
        If (txt_media.Text < 0 Or txt_desviacion.Text < 0) Then
            var = False
        Else
            var = True
        End If
        Return var
    End Function



    Public Function Normal(media As Double, n As Integer, desviacion As Double)

        Dim pi As Double = Math.PI
        Dim lista(0 To (n - 1)) As Double
        Dim yvalue As Double

        For num As Decimal = 0 To (n - 1)
            Dim aux1 As Double = Rnd()
            Dim aux2 As Double = Rnd()
            Dim z As Double
            z = Math.Sqrt(-2 * Math.Log(aux1)) * (Math.Sin(2 * pi * aux2))
            yvalue = media + desviacion * (z)
            lista(num) = Math.Round(yvalue, 4)
        Next
        Return lista

    End Function

    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click

        Validar_campos()
        grafico_normal.Series(0).Points.Clear()
        grilla_numeros_aleatorios.Rows.Clear()
        dgvNormal.Rows.Clear()
        dgvXiCuadradoNormal.Rows.Clear()
        Dim cant_aleatorios As Integer
        If var = False Then
            MsgBox("Ingrese todas las variables requeridas", MsgBoxStyle.OkOnly, "Error")
            Me.txt_cant_numeros.Focus()
        Else
            Validar_positivos()
            If var = False Then
                MsgBox("Ingrese un numero positivo", MsgBoxStyle.OkOnly, "Error")
            Else

                Dim media, desviacion, est_acumulado As Double
                Dim k As Integer
                cant_aleatorios = Me.txt_cant_numeros.Text
                media = Convert.ToDouble(Me.txt_media.Text.Trim)
                desviacion = Convert.ToDouble(Me.txt_desviacion.Text.Trim)
                Dim lista(0 To cant_aleatorios - 1) As Double
                Dim filaActual As Integer = 0
                If rb_cinco.Checked Then
                    k = 5
                ElseIf rb_diez.Checked Then
                    k = 10
                Else
                    k = 20
                End If

                lista = Normal(media, cant_aleatorios, desviacion)

                Dim marca_clase As Double = 0
                Dim max = lista(0)
                Dim min = lista(0)
                Dim fo As Integer = 0
                Dim fo_acum As Integer = 0
                Dim fe_acum As Double = 0
                Dim probabilidad As Double = 0
                Dim probabilidad_acum As Double = 0
                Dim fe As Double = 0
                Dim fe_chi_cuadrado As Double = 0
                Dim fo_chi_cuadrado As Integer = 0
                Dim fe_chi_cuadrado_acum As Double = 0
                Dim fo_chi_cuadrado_acum As Integer = 0
                Dim vectorUltimaFila(0 To (4)) As Double 'ultima fila de la grilla chi-cuadrado
                Dim xiCalculado As Double = 0
                Dim filaXiCuadrado As Integer = 0
                Dim acumuladorFila As Integer = 0
                Dim intervalo_min As Double = 0
                Dim intervalo_max As Double = 0
                Dim bandera As Boolean = False

                For count = 0 To (cant_aleatorios - 1) ''imprimimos la serie de numeros en la grilla de aleatorios
                    grilla_numeros_aleatorios.Rows.Add(count, Math.Round(lista(count), 4))
                    If lista(count) > max Then ''buscamos el maximo de la lista para determinar los intervalos y el largo del grafico
                        max = lista(count)
                    End If
                    If lista(count) < min Then ''buscamos el minimo de la lista para determinar los intervalos y el largo del grafico
                        min = lista(count)
                    End If
                Next count

                Dim i = min 'la variable iteradora i va a comenzar como el valor minimo que salio de la serie de numeros
                Dim ancho_intervalo As Double = Math.Round((max - min) / k, 4) 'aca determino el ancho que van a tener los intervalos
                ancho_intervalo = Math.Round(ancho_intervalo + 0.0001, 4) 'agrando el ancho del intervalo para que pueda ser contado el valor maximo en el ultimo intervalo

                While i < max
                    fo = 0

                    ' busco la frecuencia observada'
                    For count = 0 To (cant_aleatorios - 1)
                        If i <= lista(count) Then 'si el nro de la lista es mayor al lim inferior o igual

                            If lista(count) < (i + ancho_intervalo) Then 'si el nro de la lista es menor al lim superior'
                                fo += 1
                            End If
                        End If
                    Next count


                    Dim nro As Double = Math.Round(i + ((ancho_intervalo - 0.0001) / 2), 4)
                    grafico_normal.Series("Frecuencia Observada").Points.AddXY(nro, fo)
                    fo_acum += fo
                    Dim minIntervalo As Double = Math.Round(i, 4)
                    Dim maxIntervalo As Double = Math.Round((i + ancho_intervalo), 4)
                    marca_clase = Math.Round((maxIntervalo + minIntervalo) / 2, 4)
                    Dim fmc As Double = Math.Exp(-0.5 * ((marca_clase - media) / desviacion) ^ 2) / (desviacion * Math.Sqrt(2 * Math.PI))
                    fmc = Math.Round(fmc, 4)
                    probabilidad = Math.Round(fmc * (maxIntervalo - minIntervalo), 4)
                    probabilidad_acum += probabilidad
                    fe = Math.Round((probabilidad * cant_aleatorios), 4)
                    fe_acum += fe
                    acumuladorFila += 1
                    dgvNormal.Rows.Add()
                    dgvNormal.Rows(filaActual).Cells(0).Value = minIntervalo.ToString + " - " + maxIntervalo.ToString 'invervalos'
                    dgvNormal.Rows(filaActual).Cells(1).Value = marca_clase 'marca de clase'
                    dgvNormal.Rows(filaActual).Cells(2).Value = fo 'frecuencia observada'
                    dgvNormal.Rows(filaActual).Cells(3).Value = probabilidad  'probabilidad de ese intervalo
                    dgvNormal.Rows(filaActual).Cells(4).Value = fe 'frecuencia esperada'

                    fe_chi_cuadrado += fe
                    fo_chi_cuadrado += fo

                    xiCalculado = ((fo_chi_cuadrado - fe_chi_cuadrado) ^ 2) / fe_chi_cuadrado 'con los valores de las frecuencias que acumule  calculo el chiCalculado
                    xiCalculado = Math.Round(xiCalculado, 4)
                    est_acumulado += xiCalculado
                    dgvXiCuadradoNormal.Rows.Add()

                    dgvXiCuadradoNormal.Rows(filaXiCuadrado).Cells(0).Value = i.ToString + " - " + Math.Round((i + ancho_intervalo), 4).ToString

                    vectorUltimaFila(0) = Math.Round((i + ancho_intervalo), 4) 'guardo el intervalo superior
                    vectorUltimaFila(1) = fo_chi_cuadrado
                    vectorUltimaFila(2) = fe_chi_cuadrado
                    vectorUltimaFila(3) = Math.Round(xiCalculado, 4)
                    fo_chi_cuadrado_acum += fo_chi_cuadrado
                    fe_chi_cuadrado_acum += fe_chi_cuadrado
                    dgvXiCuadradoNormal.Rows(filaXiCuadrado).Cells(1).Value = fo_chi_cuadrado
                    dgvXiCuadradoNormal.Rows(filaXiCuadrado).Cells(2).Value = fe_chi_cuadrado
                    dgvXiCuadradoNormal.Rows(filaXiCuadrado).Cells(3).Value = Math.Round(xiCalculado, 4)
                    acumuladorFila = 0

                    fe = 0
                    filaXiCuadrado += 1
                    fe_chi_cuadrado = 0
                    fo_chi_cuadrado = 0

                    filaActual += 1
                    i = Math.Round(i + ancho_intervalo, 4)
                End While

                If ancho_intervalo = 0.0001 Then
                    grafico_normal.Series("Frecuencia Observada").Points.AddXY((min), cant_aleatorios)
                    dgvNormal.Rows(filaActual).Cells(0).Value = min.ToString + " - " + max.ToString 'invervalos'
                    dgvNormal.Rows(filaActual).Cells(1).Value = min 'marca de clase'
                    dgvNormal.Rows(filaActual).Cells(2).Value = cant_aleatorios  'frecuencia observada'
                Else
                    dgvNormal.Rows(filaActual).Cells(2).Value = fo_acum
                    dgvNormal.Rows(filaActual).Cells(4).Value = fe_acum
                    dgvNormal.Rows(filaActual).Cells(3).Value = probabilidad_acum


                    dgvXiCuadradoNormal.Rows.Add()
                    dgvXiCuadradoNormal.Rows(filaXiCuadrado).Cells(1).Value = fo_chi_cuadrado_acum
                    dgvXiCuadradoNormal.Rows(filaXiCuadrado).Cells(2).Value = fe_chi_cuadrado_acum


                End If
                dgvXiCuadradoNormal.Rows.Add()
                dgvXiCuadradoNormal.Rows(filaXiCuadrado).Cells(2).Value = "Chi-calculado:"
                dgvXiCuadradoNormal.Rows(filaXiCuadrado).Cells(3).Value = est_acumulado
                dgvXiCuadradoNormal.Rows(filaXiCuadrado).Cells(3).Style.BackColor = Color.LightBlue
                grafico_normal.Series("Frecuencia Observada").ChartType = SeriesChartType.Column
                grafico_normal.Series("Frecuencia Observada").XValueType = ChartValueType.Int32
                grafico_normal.Series("Frecuencia Observada").YValueType = ChartValueType.Int32
                grafico_normal.ChartAreas(0).AxisX.Interval = 0.5
                grafico_normal.Series("Frecuencia Observada").IsValueShownAsLabel = True
                lbl_chi_cuadrado_calculado.Text = est_acumulado
                lbl_grados_libertad.Text = (k - 3)
            End If
        End If

    End Sub


    Private Sub Normal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
    End Sub


End Class