Public Class FrmNilai

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        hasil()
    End Sub

    Sub hasil()

        If (Val(txtp.Text) < 75%) Then
            lblket.Text = "Presensi < 75%, tidak dapat mengikuti UAS"
        Else
            lblket.Text = "Presensi ok"
        End If
        ruts.Text = Val(Val(txtuts.Text) * (20 / 100))
        ruas.Text = Val(Val(txtuas.Text) * (20 / 100))
        rtp.Text = Val(Val(txttp.Text) * (25 / 100))
        rpp.Text = Val(Val(txtpp.Text) * (15 / 100))
        rk.Text = Val(Val(txtk.Text) * (10 / 100))
        rp.Text = Val(Val(txtp.Text) * (10 / 100))
        txtrata.Text = Val(ruts.Text) + Val(ruas.Text) + Val(rtp.Text) + Val(rpp.Text) + Val(rk.Text) + Val(rp.Text)
        Select Case Val(txtrata.Text)
            Case 0 To 50
                txtratah.Text = "E"
            Case 50 To 59
                txtratah.Text = "D"
            Case 60 To 74
                txtratah.Text = "C"
            Case 75 To 84
                txtratah.Text = "B"
            Case 85 To 100
                txtratah.Text = "A"
            Case Else
                Debug.WriteLine("Not between 1 and 10, inclusive")
        End Select
    End Sub

    Private Sub txtuts_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuts.TextChanged
        hasil()
    End Sub

    Private Sub txtuas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuas.TextChanged
        hasil()
    End Sub

    Private Sub txttp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttp.TextChanged
        hasil()
    End Sub

    Private Sub txtpp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpp.TextChanged
        hasil()
    End Sub

    Private Sub txtk_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtk.TextChanged
        hasil()
    End Sub

    Private Sub txtp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtp.TextChanged
        hasil()
    End Sub
End Class