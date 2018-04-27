Public Class Form1

    Private Sub btnhitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhitung.Click
        Dim a, b, c, d, ee, f, g, h, hasill, bobot As Double
        a = tknilai.Text 'tugas kecil nilai
        b = tkbobot.Text 'tugas kecil bobot
        c = tbnilai.Text 'tugas besar nilai
        d = tbbobot.Text 'tugas besar bobot
        ee = utsnilai.Text 'uts nilai
        f = utsbobot.Text 'uts bobot
        g = uasnilai.Text 'uas nilai
        h = uasbobot.Text 'uas bobot

        hasill = ((a * b) / 100) + ((c * d) / 100) + ((ee * f) / 100) + ((g * h) / 100)
        total.Text = hasill
        bobot = (b + d + f + h)

        If bobot < "100" Then
            MsgBox("bobot kurang dari 100%!")
        ElseIf bobot > "100" Then
            MsgBox("bobot lebih dari 100%!")
            total.Text = ""
            grade.Text = ""
        Else
            If hasill > 80 Then
                grade.Text = "A"
            ElseIf hasill > 70 Then
                grade.Text = "B"
            ElseIf hasill > 60 Then
                grade.Text = "C"
            ElseIf hasill > 50 Then
                grade.Text = "D"
            Else
                grade.Text = "E"
            End If
        End If
    End Sub

    Private Sub btnbersih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbersih.Click
        tknilai.ResetText()
        tkbobot.ResetText()
        tbnilai.ResetText()
        tbbobot.ResetText()
        utsnilai.ResetText()
        utsbobot.ResetText()
        uasnilai.ResetText()
        uasbobot.ResetText()
        total.Text = "------"
        grade.Text = "------"

    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Close()
    End Sub
End Class
