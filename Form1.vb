Public Class Form1

    Dim Current As Integer

   
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Current = txtWaktu.Text
        lblHitungMundur.Text = Current
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Current = Current - 1
        If Current <= 0 Then
            Timer1.Enabled = False
        End If
        lblHitungMundur.Text = Current
    End Sub
End Class
