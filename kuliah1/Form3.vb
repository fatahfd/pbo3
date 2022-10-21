Public Class Formppn

    Private Sub Txtchoco_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtchoco.TextChanged
        Txtjumlah.Text = Val(txtnasi.Text) + Val(Txtayam.Text) + Val(TxtKentang.Text) + Val(Txtchoco.Text)

    End Sub

    Private Sub txtnasi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnasi.TextChanged
        Txtjumlah.Text = Val(txtnasi.Text) + Val(Txtayam.Text) + Val(TxtKentang.Text) + Val(Txtchoco.Text)
    End Sub

    Private Sub Txtayam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtayam.TextChanged
        Txtjumlah.Text = Val(txtnasi.Text) + Val(Txtayam.Text) + Val(TxtKentang.Text) + Val(Txtchoco.Text)
    End Sub

    Private Sub TxtKentang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtKentang.TextChanged
        Txtjumlah.Text = Val(txtnasi.Text) + Val(Txtayam.Text) + Val(TxtKentang.Text) + Val(Txtchoco.Text)
    End Sub

    Private Sub Cmdhasil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmdhasil.Click
        Const PPN As Single = 0.1
        Dim Harga As Single

        Harga = Txtjumlah.Text
        Txtppn.Text = Harga * PPN
        Txttotal.Text = Harga + Val(Txtppn.Text)
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgaji.TextChanged
        itung()
    End Sub
    Sub itung()
        txtgajibruto.Text = Val(txtgaji.Text) + Val(txtasu1.Text) + Val(txtasu3.Text) + Val(txtasu3.Text)
        Dim c = Val(txtgajibruto.Text) * (5 / 100)
        txttotal5.Text = txtgajibruto.Text + c
        txtppn5.Text = Val(c)
        txtpph1b.Text = txtppn5.Text
        txtpph1t.Text = Val(txtpph1b.Text) * 12
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtasu1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtasu1.TextChanged
        itung()
    End Sub

    Private Sub txtasu2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtasu2.TextChanged
        itung()
    End Sub

    Private Sub txtasu3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtasu3.TextChanged
        itung()
    End Sub
End Class