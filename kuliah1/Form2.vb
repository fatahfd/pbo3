Public Class FrmKalkulator
    Friend Hasil As Single = 0
    Dim operasi As String = ""
    Dim operasiHitung As Boolean = False
    Private Sub FrmKalkulator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        operasiHitung = False
        operasi = ""
        Hasil = 0
        txtlayar.Text = "0"
    End Sub

    Private Sub cmbbutton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbutton1.Click
        If operasiHitung = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "1"
            operasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + "1"
        End If
    End Sub

    Private Sub cmbtambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtambah.Click

        operasi = "tambah"
        Hasil = Val(txtlayar.Text)
        operasiHitung = True
    End Sub

    Private Sub cmbkurang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbkurang.Click
        operasi = "kurang"
        Hasil = Val(txtlayar.Text)
        operasiHitung = True
    End Sub

    Private Sub cmbsamadengan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsamadengan.Click
        Select Case operasi
            Case "tambah"
                Hasil = Hasil + Val(txtlayar.Text)
            Case "kurang"
                Hasil = Hasil - Val(txtlayar.Text)
            Case "bagi"
                Hasil = Hasil / Val(txtlayar.Text)
            Case "kali"
                Hasil = Hasil * Val(txtlayar.Text)
            Case "pangkat"
                Hasil = Hasil ^ Val(txtlayar.Text)
        End Select
        txtlayar.Text = Hasil
        operasiHitung = True
    End Sub

    Private Sub cmbhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbhapus.Click
        txtlayar.Text = "0"
        operasi = ""
    End Sub

    Private Sub cmbbutton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbutton2.Click
        setAngka(2)
    End Sub
    Sub setAngka(ByVal k As Integer)
        If operasiHitung = True Or txtlayar.Text = "0" Then
            txtlayar.Text = k.ToString

            operasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + k.ToString
        End If
        Console.WriteLine(k)
    End Sub

    Private Sub cmbbutton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbutton3.Click
        setAngka(3)
    End Sub

    Private Sub cmbbutton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbutton4.Click
        setAngka(4)
    End Sub

    Private Sub cmbbutton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbutton5.Click
        setAngka(5)
    End Sub

    Private Sub cmbbutton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbutton6.Click
        setAngka(6)
    End Sub

    Private Sub cmbbutton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbutton7.Click
        setAngka(7)
    End Sub

    Private Sub cmbbutton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbutton8.Click
        setAngka(8)
    End Sub

    Private Sub cmbbutton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbutton9.Click
        setAngka(9)
    End Sub

    Private Sub cmbkali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbkali.Click
        operasi = "kali"
        Hasil = Val(txtlayar.Text)
        operasiHitung = True
    End Sub

    Private Sub cmbbagi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbagi.Click
        operasi = "bagi"
        Hasil = Val(txtlayar.Text)
        operasiHitung = True
    End Sub

    Private Sub cmbpangkat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpangkat.Click
        operasi = "pangkat"
        Hasil = Val(txtlayar.Text)
        operasiHitung = True
    End Sub

    Private Sub cmbbutton0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbutton0.Click
        setAngka(0)
    End Sub
End Class