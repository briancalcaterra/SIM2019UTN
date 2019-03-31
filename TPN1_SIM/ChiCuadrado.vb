Public Class ChiCuadrado

    Dim bandera, var As Boolean
    

    Private Sub ChiCuadrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_graficar_Click(sender As Object, e As EventArgs) Handles btn_graficar.Click
        Validar_campos()
        Dim cantidad As Double
        If var = False Then
            MsgBox("Ingrese todas las variables requeridas", MsgBoxStyle.OkOnly, "Error")
            Me.txt_cantidad_muestras.Focus()
        Else
            Validar_enteros(cantidad)
            cantidad = Convert.ToDouble(Me.txt_cantidad_muestras.Text)
            If bandera = True Then
                Generar_aleatorios(cantidad)
            End If
        End If
    End Sub

    Private Sub Generar_aleatorios(cant As Double)
        Dim lista(0 To cant - 1) As Double
        Dim aleatorio As Double
        Dim i As Integer
Randomize: Do While i <= (cant - 1)
            aleatorio = Rnd()
            lista(i) = FormatNumber(aleatorio, 4)
            i = i + 1
        Loop
        Dim j As Integer
        j = 0
        Me.grilla_chi_cuadrado.Rows.Clear()
        Do While (j <= cant - 1)
            grilla_chi_cuadrado.Rows.Add(j, lista(j))
            j = j + 1
        Loop
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
        Me.grilla_chi_cuadrado.Rows.Clear()
        Me.txt_cantidad_muestras.Focus()
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Limpiar()
    End Sub

    Private Function Validar_campos() As Boolean
        If (Me.txt_cantidad_muestras.Text = "" Or (rbtn_cinco.Checked = False And rbtn_diez.Checked = False And rbtn_veinte.Checked = False)) Then
            var = False
        Else
            var = True
        End If
        Return var
    End Function

    
   
End Class