Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userInput As String = TextBox1.Text

        On Error GoTo ErrorHandler
        Dim number As Integer = Integer.Parse(userInput)
        MessageBox.Show("You entered: " & number)

        Exit Sub

ErrorHandler:
        MessageBox.Show("Error: Please enter a valid number.")
    End Sub
End Class