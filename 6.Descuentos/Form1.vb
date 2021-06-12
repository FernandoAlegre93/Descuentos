Public Class Descuentos
    Dim ValorVenta As Double
    Dim Desc1, Desc2, Desc3 As Double
    Dim DescPorc As Double


    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        If ValorVenta >= 650 Then
            Desc1 = ValorVenta * 0.3
            txtbx3.Text = 30%
            txtbx2.Text = Desc1
            txtbx4.Text = ValorVenta - Desc1
        End If

        If ValorVenta >= 300 And ValorVenta <= 649 Then

            Desc2 = ValorVenta * 0.2
            txtbx3.Text = 20%
            txtbx2.Text = Desc2
            txtbx4.Text = ValorVenta - Desc2
        End If
        If ValorVenta > 100 And ValorVenta <= 299 Then
            Desc3 = ValorVenta * 0.1
            txtbx3.Text = 10%
            txtbx2.Text = Desc3
            txtbx4.Text = ValorVenta - Desc3
        End If
        If ValorVenta <= 100 Then
            txtbx4.Text = ValorVenta
        End If
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        txtbx1.Text = ""
        txtbx2.Text = ""
        txtbx3.Text = ""
        txtbx4.Text = ""
    End Sub

    Private Sub txtbx1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbx1.TextChanged
        ValorVenta = Val(txtbx1.Text)
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        Me.Close()

    End Sub
End Class
