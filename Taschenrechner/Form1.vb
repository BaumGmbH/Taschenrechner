Public Class Form1

    Public Property zahl As String = ""
    Public Property calc As String = ""

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles b1.Click
        tb.Text += "1"
    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles b5.Click
        tb.Text += "5"
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles b3.Click
        tb.Text += "3"
    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles b6.Click
        tb.Text += "6"
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles b2.Click
        tb.Text += "2"
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles b4.Click
        tb.Text += "4"
    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles b7.Click
        tb.Text += "7"
    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles b8.Click
        tb.Text += "8"
    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles b9.Click
        tb.Text += "9"
    End Sub

    Private Sub B0_Click(sender As Object, e As EventArgs) Handles b0.Click
        tb.Text += "0"
    End Sub

    Private Sub BDel_Click(sender As Object, e As EventArgs) Handles bDel.Click
        If (tb.Text.Length > 0) Then
            tb.Text = tb.Text.Substring(0, tb.Text.Length - 1)
        End If
    End Sub

    Private Sub BAC_Click(sender As Object, e As EventArgs) Handles bAC.Click
        calc = ""
        zahl = ""
        tb.Text = ""

        lbl1.Text = ""
        lbl2.Text = ""
    End Sub

    Private Sub BMulti_Click(sender As Object, e As EventArgs) Handles bMulti.Click
        zahl = tb.Text
        lbl2.Text = zahl
        tb.Text = ""

        calc = "x"
        lbl1.Text = calc
    End Sub

    Private Sub BDiv_Click(sender As Object, e As EventArgs) Handles bDiv.Click
        zahl = tb.Text
        lbl2.Text = zahl
        tb.Text = ""

        calc = "/"
        lbl1.Text = calc
    End Sub

    Private Sub BPlus_Click(sender As Object, e As EventArgs) Handles bPlus.Click
        zahl = tb.Text
        lbl2.Text = zahl
        tb.Text = ""

        calc = "+"
        lbl1.Text = calc
    End Sub

    Private Sub BMinus_Click(sender As Object, e As EventArgs) Handles bMinus.Click
        zahl = tb.Text
        lbl2.Text = zahl
        tb.Text = ""

        calc = "-"
        lbl1.Text = calc
    End Sub

    Private Sub BDot_Click(sender As Object, e As EventArgs) Handles bDot.Click
        tb.Text += ","
    End Sub

    Private Sub BEnter_Click(sender As Object, e As EventArgs) Handles bEnter.Click
        If (calc = "+") Then
            tb.Text = Val(zahl) + Val(tb.Text)
        End If
        If (calc = "-") Then
            tb.Text = Val(zahl) - Val(tb.Text)
        End If
        If (calc = "x") Then
            tb.Text = Val(zahl) * Val(tb.Text)
        End If
        If (calc = "/") Then
            tb.Text = Val(zahl) / Val(tb.Text)
        End If

        lbl1.Text = ""
        lbl2.Text = ""
    End Sub

    Private Sub BRound_Click(sender As Object, e As EventArgs) Handles bRound.Click
        tb.Text = Math.Round(Val(tb.Text))
    End Sub

    Private Sub B1x_Click(sender As Object, e As EventArgs) Handles b1x.Click
        tb.Text = 1.0 / Val(tb.Text)
    End Sub

    Private Sub BPI_Click(sender As Object, e As EventArgs) Handles bPI.Click
        tb.Text = Math.PI
    End Sub

    Private Sub BE_Click(sender As Object, e As EventArgs) Handles bE.Click
        tb.Text = Math.E
    End Sub
End Class
