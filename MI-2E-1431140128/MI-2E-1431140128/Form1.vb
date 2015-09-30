Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MyBase.BackColor = Color.SteelBlue Then
            MyBase.BackColor = Color.Coral
        Else : MyBase.BackColor = Color.SteelBlue
        End If
    End Sub
End Class
