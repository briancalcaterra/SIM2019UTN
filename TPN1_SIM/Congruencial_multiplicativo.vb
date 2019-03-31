Public Class Congruencial_multiplicativo
    Dim g, k, i_ultimo As Integer
    Dim xo, c, a, aleatorio, m, x_mas_1, x_ultimo As Double
    Dim var, bandera, bandera_enteros As Boolean


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
            n = Me.txt_cant_muestras.Text 'cantidad de muestras o numeros que se van a generar
            i = 0
            Validar_enteros(n, k, g, xo)
            Validar_semilla(xo)
            If bandera = True And bandera_enteros = True Then
                Dim numeros(0 To (n - 1)) As Double 'creacion del vector para guardar los numeros aleatorios
                m = 2 ^ g
                Me.txt_periodo_max.Text = m
                a = 3 + (8 * k) 'calculo de la constante a
                Me.txt_constante_a.Text = a
                Do While (i <= n - 1) 'ciclo para cargar el arreglo
                    x_mas_1 = (a * xo) Mod (m) 'aca se calcula el valor de (x + 1), como parametro se ingresa el valor semilla
                    aleatorio = x_mas_1 / (m)
                    numeros(i) = FormatNumber(aleatorio, 4)
                    i = i + 1
                    xo = x_mas_1 'el valor semilla se convierte en (x+1) y se utiliza para la siguiente iteracion
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
            aleatorio = FormatNumber((x_ultimo / m), 4)
            grilla_numeros.Rows.Add(i_ultimo, aleatorio)
            i_ultimo = i_ultimo + 1
        End If
    End Sub


    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Limpiar()
    End Sub

    Private Function Validar_semilla(c) As Boolean
        If c Mod 2 = 0 Then
            bandera = False
            MsgBox("Ingrese un numero impar", MsgBoxStyle.OkOnly, "Error")
            Me.txt_semilla.Text = ""
            Me.grilla_numeros.Rows.Clear()
            Me.txt_semilla.Focus()
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub Congruencial_multiplicativo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function Validar_enteros(x1, x2, x3, x4) As Boolean
        If x1 >= 0 And x2 >= 0 And x3 >= 0 And x4 >= 0 Then
            bandera_enteros = True
        Else
            bandera_enteros = False
            MsgBox("Ingrese numeros enteros positivos", MsgBoxStyle.OkOnly, "Error")
        End If
        Return bandera_enteros
    End Function

    Private Sub Limpiar()
        Me.txt_semilla.Text = ""
        Me.txt_exponente.Text = ""
        Me.txt_intervalos.Text = ""
        Me.txt_periodo_max.Text = ""
        Me.txt_constante_a.Text = ""
        Me.txt_cant_muestras.Text = ""
        Me.grilla_numeros.Rows.Clear()
        Me.txt_cant_muestras.Focus()
    End Sub

End Class