Public Class Form2

    Private Sub btnhitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhitung.Click
        Dim a, b, c, sum As Double
        a = n1.Text
        b = n2.Text
        c = n3.Text
        sum = CDec(a + b + c) / 3
        rata.Text = sum

        If rata.Text > 80 Then
            gift.Text = "Rp.10 juta"
        ElseIf rata.Text > 70 Then
            gift.Text = "Rp.7.5 Juta"
        Else
            gift.Text = "Hanya Dapat Sertifikat"
        End If
    End Sub

    Private Sub btnulang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnulang.Click
        nama.ResetText()
        n1.ResetText()
        n2.ResetText()
        n3.ResetText()
        rata.Text = "...................................................."
        gift.Text = "...................................................."
    End Sub
End Class