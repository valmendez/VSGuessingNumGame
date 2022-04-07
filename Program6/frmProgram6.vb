Public Class frmProgram6
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'code for generating a random number from 0-100
        Dim number As Integer = CInt(Int((100 * Rnd()) + 1))

        'variables
        Dim userNumber As Integer
        Dim prompt, title As String 'for InputBox

        Do
            prompt = "Enter a number until you guess the correct one"
            title = "Number"

            userNumber = CInt(InputBox(prompt, title)) 'ask user for input

            If userNumber < number Then
                txtOutput.Text = "Try Again. Your input is too low."
            ElseIf userNumber > number Then
                txtOutput.Text = "Try Again. Your input is too high."

            End If

        Loop While (userNumber < number) Or (userNumber > number) 'userNumber <> number

        MessageBox.Show("Correct! Your number matches the randomly generated number :) ")

    End Sub
End Class
