Public Class Form1
    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim SePresionaOperador As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox2.Text &= "3"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox2.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox2.Text &= "1"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox2.Text &= "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox2.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox2.Text &= "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox2.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox2.Text &= "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox2.Text &= "9"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox2.Text &= "0"
    End Sub

    Private Sub ButtonPunto_Click(sender As Object, e As EventArgs) Handles BtnDot.Click
        EvaluaRestriccionesParaConcatenar()
        If InStr(TextBox2.Text, ".", CompareMethod.Text) = 0 Then
            TextBox2.Text &= "."
        End If
    End Sub

    Private Sub ButtonSuma_Click(sender As Object, e As EventArgs) Handles BtnPlus.Click
        EvaluayHazOperacion()
        Operacion = "+"
    End Sub

    Private Sub ButtonResta_Click(sender As Object, e As EventArgs) Handles BtnMinus.Click
        EvaluayHazOperacion()
        Operacion = "-"
    End Sub

    Private Sub ButtonMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnBy.Click
        EvaluayHazOperacion()
        Operacion = "*"
    End Sub

    Private Sub ButtonDivison_Click(sender As Object, e As EventArgs) Handles BtnDiv.Click
        EvaluayHazOperacion()
        Operacion = "/"
    End Sub

    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles BtnRm.Click
        TextBox2.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    Private Sub ButtonIgual_Click(sender As Object, e As EventArgs) Handles BtnEqual.Click
        EvaluayHazOperacion()
        Operacion = ""
    End Sub
    Private Sub ButtonSqrRoot(sender As Object, e As EventArgs) Handles BtnSqrR.Click
        EvaluayHazOperacion()
        Operacion = "^(1/2)"
    End Sub
    Private Sub BtnElev2_Click(sender As Object, e As EventArgs) Handles BtnElev2.Click
        EvaluayHazOperacion()
        Operacion = "^2"
    End Sub
    Private Sub BtnElev_Click(sender As Object, e As EventArgs) Handles BtnElev.Click
        EvaluayHazOperacion()
        Operacion = "^n"
    End Sub
    Public Sub EvaluayHazOperacion()
        SePresionaOperador = True
        Valor2 = Val(TextBox2.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "*"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2
                Case "^(1/2)"
                    ValorResultado = ValorResultado ^ (1 / 2)
                Case "^2"
                    ValorResultado = ValorResultado ^ 2
                Case "^n"
                    ValorResultado = ValorResultado ^ Valor2
            End Select
            TextBox2.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub

    Public Sub EvaluaRestriccionesParaConcatenar()
        If SePresionaOperador = True Then
            TextBox2.Text = ""
            SePresionaOperador = False
        ElseIf TextBox2.Text = "0" Then
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
