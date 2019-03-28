Public Class Congruencial_multiplicativo
    Dim g, k, i_ultimo As Integer
    Dim xo, c, a, aleatorio, m, x_mas_1, x_ultimo As Double
    Dim var, bandera As Boolean


    Private Sub btn_cargar_aleatorios_Click(sender As Object, e As EventArgs) Handles btn_cargar_aleatorios.Click
        'Subrutina que carga en la grilla los numeros pseudo-aleatorios almacenados en el arreglo
        Validar_campos()
        If var = False Then
            MsgBox("Ingrese todas las variables requeridas", MsgBoxStyle.OkOnly, "Error")
            Me.txt_cant_muestras.Focus()
        Else
            Dim i, n As Integer
            xo = Me.txt_semilla.Text
            g = Me.txt_exponente.Text
            k = Me.txt_intervalos.Text
            m = 2 ^ (g - 2)
            Me.txt_periodo_max.Text = m
            a = 3 + (8 * k)
            Me.txt_constante_a.Text = a
            n = txt_cant_muestras.Text
            'creacion del vector para guardar los numeros aleatorios 
            Dim numeros(0 To (n - 1)) As Double
            i = 0
            'ciclo para cargar el arreglo
            Do While (i <= n - 1)
                'aca se calcula el valor de (x + 1), como parametro se ingresa el valor semilla
                x_mas_1 = (a * xo) Mod (m)
                aleatorio = x_mas_1 / (m - 1)
                numeros(i) = FormatNumber(aleatorio, 4)
                i = i + 1
                'el valor semilla se convierte en (x+1) y se utiliza para la siguiente iteracion
                xo = x_mas_1
            Loop
            x_ultimo = x_mas_1
            i_ultimo = i
            Dim j As Integer
            j = 0
            Me.grilla_numeros.Rows.Clear()
            Do While (j <= n - 1)
                grilla_numeros.Rows.Add(j, numeros(j))
                j = j + 1
            Loop
        End If
    End Sub

    Private Function Validar_campos() As Boolean
        If (txt_semilla.Text = "" Or txt_intervalos.Text = "" Or txt_exponente.Text = "" Or txt_cant_muestras.Text = "") Then
            var = False
        Else
            var = True
        End If
        Return var
    End Function


    Private Sub btn_siguiente_Click(sender As Object, e As EventArgs) Handles btn_siguiente.Click
        Validar_campos()
        If var = False Then
            MsgBox("Ingrese todas las variables requeridas", MsgBoxStyle.OkOnly, "Error")
            Me.txt_cant_muestras.Focus()
        Else
            i_ultimo = i_ultimo
            x_ultimo = (a * x_ultimo) Mod (m)
            aleatorio = FormatNumber((x_ultimo / m - 1), 4)
            grilla_numeros.Rows.Add(i_ultimo, aleatorio)
            i_ultimo = i_ultimo + 1
        End If
    End Sub


    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Me.txt_semilla.Text = ""
        Me.txt_exponente.Text = ""
        Me.txt_intervalos.Text = ""
        Me.txt_periodo_max.Text = ""
        Me.txt_constante_a.Text = ""
        Me.txt_cant_muestras.Text = ""
        Me.grilla_numeros.Rows.Clear()
        Me.txt_cant_muestras.Focus()
    End Sub


   
    Private Function validar_semilla(c) As Boolean
        If c Mod 2 = 0 Then
            bandera = False
            MsgBox("Ingrese un numero impar", MsgBoxStyle.OkOnly, "Error")
        Else
            bandera = True
        End If
        Return bandera
    End Function

   
    Private Sub txt_semilla_TextChanged(sender As Object, e As EventArgs) Handles txt_semilla.TextChanged
        validar_semilla(xo)
    End Sub
End Class