
Public Class Congruencial_mixto
    'a)	Realizar un programa que genere una serie de 20 números aleatorios entre 0 y 0,9999 (4 dígitos decimales) a partir de un valor numérico indicado como raíz, 
    'utilizando los métodos congruenciales mixto y multiplicativo. Las constantes a utilizar por los métodos deben ser ingresadas por  el usuario. 
    'Una vez que se listan los 20 números, debe permitir seguir la serie de a un valor por vez. 
    'b)	Realizar un programa que efectúe la prueba de frecuencia (Test de Chi Cuadrado) sobre una serie generada a través del mecanismo provisto por el lenguaje utilizado
    ' para generar números pseudo-aleatorios. La cantidad de números a generar y de subintervalos debe ser recibida como parámetro y la salida generada deberá incluir una gráfica 
    'que represente las frecuencias observadas y esperadas (la gráfica se aceptará que se genere en base a un archivo de salida del programa, en Excel).
    'La serie generada debe por ser vista (bajar a archivo o visualizar en pantalla).
    'c)	Lo mismo que el punto anterior, pero utilizando el método congruencial mixto.
    'Declaracion de variables que contendran a los valores ingresados por el usuario

    'xo: valor semilla
    'g: exponente para calcular m
    'k: cantidad de intervalos
    'c: constante aditiva
    'a: constante multiplicativa
    'x_ultimo: ultimo numero generado de la serie
    'i_ultimo: ultima posicion guardada en la grilla
    Dim g, k, i_ultimo As Integer
    Dim xo, c, a, aleatorio, m, x_mas_1, x_ultimo As Double
    Dim var, bandera As Boolean
   
    Private Function Validar_campos() As Boolean
        If (txt_semilla.Text = "" Or txt_intervalos.Text = "" Or txt_exponente.Text = "" Or txt_constante_c.Text = "" Or txt_cant_muestras.Text = "") Then
            var = False
        Else
            var = True
        End If
        Return var
    End Function
 
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
            c = Me.txt_constante_c.Text
            n = Me.txt_cant_muestras.Text
            m = 2 ^ g
            Me.txt_periodo_max.Text = m
            a = 1 + (4 * k)
            Me.txt_constante_a.Text = a
            Validar_enteros(n, xo, k, g, c)
            If bandera = True Then
                Dim numeros(0 To (n - 1)) As Double 'creacion del vector para guardar los numeros aleatorios
                i = 0
                Do While (i <= n - 1) 'ciclo para cargar el arreglo
                    x_mas_1 = (a * xo + c) Mod (m) 'aca se calcula el valor de (x + 1), como parametro se ingresa el valor semilla
                    aleatorio = x_mas_1 / m
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

    Private Sub btn_siguiente_Click(sender As Object, e As EventArgs) Handles btn_siguiente.Click
        Validar_campos()
        If var = False Then
            MsgBox("Ingrese todas las variables requeridas", MsgBoxStyle.OkOnly, "Error")
            Me.txt_cant_muestras.Focus()
        Else
            i_ultimo = i_ultimo
            x_ultimo = (a * x_ultimo + c) Mod (m)
            aleatorio = FormatNumber((x_ultimo / m), 4)
            grilla_numeros.Rows.Add(i_ultimo, aleatorio)
            i_ultimo = i_ultimo + 1
        End If
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Limpiar()
    End Sub

    Private Sub Limpiar()
        Me.txt_semilla.Text = ""
        Me.txt_exponente.Text = ""
        Me.txt_intervalos.Text = ""
        Me.txt_constante_c.Text = ""
        Me.txt_periodo_max.Text = ""
        Me.txt_constante_a.Text = ""
        Me.txt_cant_muestras.Text = ""
        Me.grilla_numeros.Rows.Clear()
        Me.txt_cant_muestras.Focus()
    End Sub

    Private Function Validar_enteros(x1, x2, x3, x4, x5) As Boolean
        If x1 >= 0 And x2 >= 0 And x3 >= 0 And x4 >= 0 And x5 >= 0 Then
            bandera = True
        Else
            bandera = False
            MsgBox("Ingrese numeros enteros positivos", MsgBoxStyle.OkOnly, "Error")
        End If
        Return bandera
    End Function

    Private Sub Congruencial_mixto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
