Public Class Form1
    Private stopwatch As New Stopwatch

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = Me.stopwatch.Elapsed
        Label1.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", _
        Math.Floor(elapsed.TotalHours), _
        elapsed.Minutes, elapsed.Seconds, _
        elapsed.Milliseconds)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Start()
        Me.stopwatch.Start()
        Button4.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()
        Me.stopwatch.Stop()
        Button4.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.stopwatch.Reset()
        Label1.Text = "00:00:00:00"
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(ListBox1.Items.Count + 1 & " " & Label1.Text)
    End Sub
End Class
