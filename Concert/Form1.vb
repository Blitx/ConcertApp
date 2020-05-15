Public Class Form1
    Private Sub PicEminem_Click(sender As Object, e As EventArgs) Handles PicEminem.Click
        If PicEminem.BackColor = Color.FromKnownColor(KnownColor.Control) Then
            PicEminem.BackColor = Color.Gray
            LblEminemFact.Show()
            LblSheeranFact.Hide()
            LblGreendayFact.Hide()
        Else PicEminem.BackColor = Color.FromKnownColor(KnownColor.Control)
            LblEminemFact.Hide()
        End If 'now this, THIS, is bad code
    End Sub

    Private Sub PicSheeran_Click(sender As Object, e As EventArgs) Handles PicSheeran.Click
        If PicSheeran.BackColor = Color.FromKnownColor(KnownColor.Control) Then
            PicSheeran.BackColor = Color.Gray
            LblSheeranFact.Show()
            LblEminemFact.Hide()
            LblGreendayFact.Hide()
        Else PicSheeran.BackColor = Color.FromKnownColor(KnownColor.Control)
            LblSheeranFact.Hide()
        End If

    End Sub

    Private Sub PicGreenday_Click(sender As Object, e As EventArgs) Handles PicGreenday.Click
        If PicGreenday.BackColor = Color.FromKnownColor(KnownColor.Control) Then
            PicGreenday.BackColor = Color.Gray
            LblGreendayFact.Show()
            LblEminemFact.Hide()
            LblSheeranFact.Hide()
        Else PicGreenday.BackColor = Color.FromKnownColor(KnownColor.Control)
            LblGreendayFact.Hide()
        End If

    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Application.Exit()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Me.Hide()
    End Sub
End Class
