Public Class FrmProcFu

    Private Sub cmdhitungP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdhitungP.Click
        hitungp(Txtnilai1.Text, Txtnilai2.Text)
    End Sub
    Private Sub TampilPesanProsudurParam(ByVal pesan As String)
        txthasil.Text = pesan
    End Sub

    Private Function TampilPesanFunctionParam(ByVal pesan As String)
        txthasil.Text = pesan
        Return pesan
    End Function

    Private Sub cmdprocedureDP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprocedureDP.Click
        TampilPesanProsudurParam("Procedure called by param")
    End Sub

    Private Sub cmdfunctionDP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfunctionDP.Click
        txthasil.Text = TampilPesanFunctionParam("Function Calle by Param")
    End Sub

    Private Sub proceduredirect()
        txthasil.Text = "Prosedure dipanggil tanpa param"
    End Sub

    Private Function functiondirect()
        Dim he As String
        he = "FUnction dipanggil tanpa param"
        Return he
    End Function

    Private Function hitungf(ByVal nilai1 As Integer, ByVal nilai2 As Integer)
        Dim hasil As Integer
        hasil = nilai1 - nilai2
        Return hasil
    End Function

    Private Sub hitungp(ByVal nilai1 As Integer, ByVal nilai2 As Integer)
        Dim hasil As Integer
        hasil = nilai1 + nilai2
        txthasil.Text = hasil
    End Sub

    Private Sub cmdprocedureTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprocedureTP.Click
        proceduredirect()
    End Sub

    Private Sub cmdfunctionTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfunctionTP.Click
        txthasil.Text = functiondirect()
    End Sub

    Private Sub cmdhitungF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdhitungF.Click
        txthasil.Text = hitungf(Txtnilai1.Text, Txtnilai2.Text)
    End Sub

    Private Sub getluas()
        txtluas.Text = (3.14 * Val(tbjari.Text) * Val(tbjari.Text))
    End Sub
    Private Function getkeliling()
        Dim kel As Integer
        kel = 3.14 * Val(tbdiam.Text)
        Return kel
    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtkeliling.Text = getkeliling()
        getluas()
    End Sub

    Private Sub tbjari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbjari.TextChanged

    End Sub

    Private Sub tbdiam_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbdiam.KeyUp
        tbjari.Text = Val(tbdiam.Text) / 2
    End Sub

    Private Sub tbjari_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbjari.KeyUp
        tbdiam.Text = Val(tbjari.Text) * 2
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tgjluas.Text = Val(tjpanjang.Text) * Val(tjtinggi.Text)
        tgjkeliling.Text = Val(tjpanjang.Text) + Val(tjpendek.Text) + Val(tjpanjang.Text) + Val(tjpendek.Text)


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        tlkel.Text = Val(tlypanjang.Text) + Val(tlypendek.Text) + Val(tlypanjang.Text) + Val(tlypendek.Text)
        tly1.Text = 2 * Val(tlkel.Text) / Val(tlypanjang.Text)
        ' tly2.Text = 2 * Val(tlkel.Text) / Val(tlypendek.Text)
        Dim d2 As Integer
        Dim d1 As Integer

        d2 = (Val(tlypanjang.Text) ^ 2) + (Val(tlypendek.Text) ^ 2)
        d2 = Math.Sqrt(d2)
        tly2.Text = d2


        tlluas.Text = (0.5 * Val(tly1.Text)) * Val(tly2.Text)

    End Sub
End Class