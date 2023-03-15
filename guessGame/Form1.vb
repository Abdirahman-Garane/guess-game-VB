Public Class Form1


    Private Sub textInput_KeyUp(sender As Object, e As KeyEventArgs) Handles textInput.KeyUp

        If e.KeyCode = Keys.Enter Then
            Dim input As String
            input = textInput.Text
            Select Case input
                Case "somalia", "Somalia", "SOMALIA"
                    lbloutput1.Text = textInput.Text
                Case "turkey", "Turkey", "TURKEY"
                    lbloutput2.Text = textInput.Text
                Case "france", "France", "FRANCE"
                    lbloutput3.Text = textInput.Text
                Case "brazil", "brasil", "Brazil", "Brasil", "BRAZIL", "BRASIL"
                    lbloutput4.Text = textInput.Text
                Case Else
                    MsgBox("try again libaax 💪", 148)
            End Select
            textInput.Text = ""
        End If

    End Sub

    Private Sub textInput_TextChanged(sender As Object, e As EventArgs) Handles textInput.TextChanged

    End Sub
End Class
