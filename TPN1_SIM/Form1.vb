
Public Class Form1
    Dim numeros(20) As Decimal
    Dim i As Integer
    '    a)	Realizar un programa de genere una serie de 20 números aleatorios entre 0 y 0,9999 (4 dígitos decimales) a partir de un valor numérico indicado como raíz, 
    'utilizando los métodos congruenciales mixto y multiplicativo. Las constantes a utilizar por los métodos deben ser ingresadas por  el usuario. 
    '      Una vez que se listan los 20 números, debe permitir seguir la serie de a un valor por vez. 
    'b)	Realizar un programa que efectúe la prueba de frecuencia (Test de Chi Cuadrado) sobre una serie generada a través del mecanismo provisto por el lenguaje utilizado
    ' para generar números pseudo-aleatorios. La cantidad de números a generar y de subintervalos debe ser recibida como parámetro y la salida generada deberá incluir una gráfica 
    'que represente las frecuencias observadas y esperadas (la gráfica se aceptará que se genere en base a un archivo de salida del programa, en Excel).
    '    'La serie generada debe por ser vista (bajar a archivo o visualizar en pantalla).
    'c)	Lo mismo que el punto anterior, pero utilizando el método congruencial mixto.


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_cargar_vector_Click(sender As Object, e As EventArgs) Handles btn_cargar_vector.Click
        Dim tabla As New DataTable
        Me.txt_periodo_max.Text = 2 ^ (Me.txt_exponente.Text)
        Me.txt_constante_a.Text = 1 + (4 * Me.txt_intervalos.Text)
        i = Me.txt_semilla.Text
        If (i > 0 And i <= 20) Then

            Dim x_mas_1 As Integer
            x_mas_1 = ((Me.txt_constante_a.Text * Me.txt_semilla.Text) + Me.txt_constante_c.Text) Mod (Me.txt_periodo_max.Text)
            Dim rnd As Double
            rnd = x_mas_1 / (Me.txt_periodo_max.Text - 1)

        Else
            MsgBox("-")
        End If
    End Sub
    Private Sub btn_cargar_aleatorios_Click(sender As Object, e As EventArgs) Handles btn_cargar_aleatorios.Click
        i = 1
        Me.grilla_numeros.Rows.Clear()
        Do While (i <= 20)
            grilla_numeros.Rows.Add(i, numeros(i))
            i = i + 1
        Loop
       
    End Sub



   

   
End Class
