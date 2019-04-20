Imports System.Windows.Forms.DataVisualization.Charting


Public Class Exponencial
    Private Sub Exponencial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
    End Sub

    Private Sub bnt_Limpiar_Click(sender As Object, e As EventArgs) Handles bnt_Limpiar.Click

        limpiar()
    End Sub
    Private Sub limpiar()
        dgv_exponencial.Rows.Clear()
        'dgv_pruebaChi.Rows.Clear()
        dgv_numerosAleatorios.Rows.Clear()
        Chart_exponencial.Series(0).Points.Clear()
        txt_media.Clear()
        txt_numeroMuestras.Clear()
        lbl_ancho_intervalo.Text = "Ancho Intervalo : "
        lbl_maximis_de_la_lista.Text = "Maximo = "
        lbl_minimo_de_la_lista.Text = "Minimo = "
    End Sub
    Private Sub bnt_Generar_Click(sender As Object, e As EventArgs) Handles bnt_Generar.Click
        Chart_exponencial.Series(0).Points.Clear()
        dgv_exponencial.Rows.Clear()
        'dgv_pruebaChi.Rows.Clear()
        dgv_numerosAleatorios.Rows.Clear()
        'Creamos las variables:
        Dim cantidad_muestras As Integer = txt_numeroMuestras.Text 'N° Muestas
        Dim media As Double = Convert.ToDouble(txt_media.Text) 'Media
        Dim lamda As Double 'Lamda
        lamda = 1 / media 'Con el cálculo obtenemos el valor de lamda
        Dim lista_aleatorios = Exponencial(media, cantidad_muestras) 'Lista cargada con numeros aleatorios exponenciales

        Dim valor_maximo = lista_aleatorios(0)
        Dim valor_minimo = lista_aleatorios(0)

        Dim sum As Integer ' Con esta variable vamos a contar la cantidad de veces que aparece un valor en un intervalor --> Frecuencia observada
        Dim fila As Integer = 0

        Dim fe As Double = 0
        Dim fo As Double = 0

        Dim ChiCalculado As Double = 0
        Dim contadorLabel As Integer = 0
        Dim fila_chi As Integer = 0
        Dim acumulador_Fila As Integer = 0
        Dim vector_UltimaFila(0 To (4)) As Double
        Dim prob_obser_acumulada As Double = 0
        Dim prob_esperada_acumulada As Double = 0

        Dim i As Integer
        'Mostramos en la grilla los valores de la lista :

        While i <= cantidad_muestras - 1
            dgv_numerosAleatorios.Rows.Add(i, lista_aleatorios(i))
            'Buscamos el valor maximo de la lista
            If lista_aleatorios(i) > valor_maximo Then
                valor_maximo = lista_aleatorios(i)
                lbl_maximis_de_la_lista.Text = "Valor Maximo = " + valor_maximo.ToString
            End If
            'Buscamos el valor minimo de la lista
            If lista_aleatorios(i) < valor_minimo Then
                valor_minimo = lista_aleatorios(i)
                lbl_minimo_de_la_lista.Text = "Valor Minimo = " + valor_minimo.ToString
            End If
            i = i + 1
        End While

        'Para conocer el intervalo seleccionado:
        Dim intervalos As Integer
        If (rb_5intervalos.Checked) Then
            intervalos = 5

        ElseIf (rb_10intervalos.Checked) Then
            intervalos = 10

        Else
            intervalos = 20
        End If

        'Calculamos en ancho de los intervalos:
        Dim ancho_intervalo As Double = Math.Round(((valor_maximo - valor_minimo) / intervalos), 4)
        ancho_intervalo = Math.Round((ancho_intervalo + 0.0001), 4)

        lbl_ancho_intervalo.Text = "Ancho intervalos : " + ancho_intervalo.ToString
        Dim numero_intervalo As Integer = 1
        ''Empezamos a llenar la  grilla 
        ''j = es el intervalo minimo 
        Dim max_valor As Double = 0

        For j As Double = valor_minimo To (valor_maximo - 1) Step ancho_intervalo '' aca restar ancho
            sum = 0

            'sum = para encontrar la frecuencia observada
            For count = 0 To (cantidad_muestras - 1)
                If j <= lista_aleatorios(count) Then
                    If lista_aleatorios(count) < (j + ancho_intervalo) Then
                        sum = sum + 1
                    End If
                End If
            Next count

            Dim x = j + (ancho_intervalo / 2) ''para poder graficar en mitad del intervalo
            x = Math.Round(x, 3) ''se trunca el ancho del numero
            'Chart1.Series("Observado").Points.AddXY(x, sum)
            Chart_exponencial.Series("Frecuencia Observada").Points.AddXY((j + (ancho_intervalo - 0.0001 / 2)), sum)

            Chart_exponencial.Series("Frecuencia Observada").Points(Math.Round(contadorLabel, 1)).Label = sum.ToString '+ vbCrLf + "[ " + Math.Truncate(j, 2).ToString + " - " + Math.Rou(x, 2).ToString + " ]"
            contadorLabel += 1

            ''calculo de la probabilidad de cada intervalo
            Dim px As Double = (1 - Math.Exp(-(lamda * (j + ancho_intervalo)))) - (1 - Math.Exp(-(lamda * (j))))

            'Calculos para la grilla 
            Dim Pe As Double = Math.Round(px, 4) ' Calculamos la probabiliad esperada
            Dim Frec_esperada As Double = Math.Round((px * cantidad_muestras), 4) ' Calculamos la frecuencia observada 

            Dim prob_observada As Double = Math.Round((sum / cantidad_muestras), 4) ' Calculamos la probabilidad observada

            Dim abs As Double



            Dim resta_de_probab As Double
            prob_obser_acumulada += prob_observada
            prob_esperada_acumulada += Pe
            'Iniciamos la grilla'
            dgv_exponencial.Rows.Add()
            dgv_exponencial.Rows((fila)).Cells(0).Value = numero_intervalo
            Dim marca_de_clase = (j + j + ancho_intervalo) / 2
            dgv_exponencial.Rows((fila)).Cells(1).Value = Math.Round(j, 4).ToString + " - " + Math.Round((j + ancho_intervalo), 4).ToString 'Intervalo
            dgv_exponencial.Rows((fila)).Cells(2).Value = marca_de_clase ' Marca
            dgv_exponencial.Rows((fila)).Cells(3).Value = sum.ToString.Trim ' Frecuencia observada
            dgv_exponencial.Rows((fila)).Cells(4).Value = Pe 'Probabilidad esperada
            dgv_exponencial.Rows((fila)).Cells(5).Value = Frec_esperada ' Frecuencia esperada
            dgv_exponencial.Rows((fila)).Cells(6).Value = prob_observada ' Probabilidad Observada
            dgv_exponencial.Rows((fila)).Cells(7).Value = prob_obser_acumulada ' Probabilida observada Acumulada
            dgv_exponencial.Rows((fila)).Cells(8).Value = prob_esperada_acumulada  ' Probabilidad esperada Acumulada
            resta_de_probab = prob_obser_acumulada - prob_esperada_acumulada
            abs = Math.Round(Math.Abs(resta_de_probab), 4)
            dgv_exponencial.Rows((fila)).Cells(9).Value = abs 'Valor absoluto de la resta de Po acumulada -Pe acumulada

            If max_valor > abs Then
                max_valor = max_valor
            Else
                max_valor = abs
            End If


            dgv_exponencial.Rows((fila)).Cells(10).Value = max_valor

            fila += 1
            numero_intervalo += 1

        Next

    End Sub



    ''Funcion para generar numeros aleatorios con una distribucion exponencial
    Public Function Exponencial(med As Double, n As Integer)
        Dim lista(0 To (n - 1)) As Double
        Dim lambda As Double = 1 / med
        Dim yvalue As Double
        For num As Decimal = 0 To (n - 1)
            yvalue = ((-1) / lambda) * (Math.Log(1 - Rnd()))
            yvalue = Math.Round(yvalue, 3)
            lista(num) = yvalue
        Next
        Return lista
    End Function



    Private Sub dgv_pruebaChi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class