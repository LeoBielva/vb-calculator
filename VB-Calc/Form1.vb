Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "9"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "0"
    End Sub

    Private Sub ButtonPunto_Click(sender As Object, e As EventArgs) Handles ButtonPunto.Click
        EvaluaRestriccionesParaConcatenar()
        If InStr(TxtResultado.Text, ".", CompareMethod.Text) = 0 Then
            TxtResultado.Text &= "."
        End If
    End Sub

    Private Sub ButtonSuma_Click(sender As Object, e As EventArgs) Handles ButtonSuma.Click
        EvaluayHazOperacion()
        Operacion = "+"
    End Sub

    Private Sub ButtonResta_Click(sender As Object, e As EventArgs) Handles ButtonResta.Click
        EvaluayHazOperacion()
        Operacion = "-"
    End Sub

    Private Sub ButtonMultiplicacion_Click(sender As Object, e As EventArgs) Handles ButtonMultiplicacion.Click
        EvaluayHazOperacion()
        Operacion = "*"
    End Sub

    Private Sub ButtonDivison_Click(sender As Object, e As EventArgs) Handles ButtonDivison.Click
        EvaluayHazOperacion()
        Operacion = "/"
    End Sub

    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        TxtResultado.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    Private Sub ButtonIgual_Click(sender As Object, e As EventArgs) Handles ButtonIgual.Click
        EvaluayHazOperacion()
        Operacion = ""
    End Sub

    Public Sub EvaluayHazOperacion()
        SePresionaOperador = True
        Valor2 = Val(TxtResultado.Text)
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
            End Select
            TxtResultado.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub

    Public Sub EvaluaRestriccionesParaConcatenar()
        If SePresionaOperador = True Then
            TxtResultado.Text = ""
            SePresionaOperador = False
        ElseIf TxtResultado.Text = "0" Then
            TxtResultado.Text = ""
        End If
    End Sub
End Class
