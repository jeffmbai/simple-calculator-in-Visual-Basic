Public Class Form1
    Dim int1 As Integer
    Dim int2 As Integer
    Dim answer As Integer
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub int1_TextChanged(sender As Object, e As EventArgs) Handles txtInt1.TextChanged

    End Sub

    Private Sub int2_TextChanged(sender As Object, e As EventArgs) Handles txtint2.TextChanged

    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
       
        int1 = txtInt1.Text
        int2 = txtint2.Text

        answer = int1 + int2
        txtAnswer.Text = answer

    End Sub

    Private Sub subtract_Click(sender As Object, e As EventArgs) Handles subtract.Click
       
        int1 = txtInt1.Text
        int2 = txtint2.Text

        answer = int1 - int2
        txtAnswer.Text = answer
    End Sub

    Private Sub multiply_Click(sender As Object, e As EventArgs) Handles multiply.Click
        
        int1 = txtInt1.Text
        int2 = txtint2.Text

        answer = int1 * int2
        txtAnswer.Text = answer
    End Sub

    Private Sub divide_Click(sender As Object, e As EventArgs) Handles divide.Click
        Dim int1 As Double
        Dim int2 As Double
        Dim answer As Double
        int1 = txtInt1.Text
        int2 = txtint2.Text

        answer = int1 / int2
        txtAnswer.Text = answer
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        txtInt1.Clear()
        txtint2.Clear()
        txtAnswer.Clear()
    End Sub
End Class
