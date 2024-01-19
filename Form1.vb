Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if the input is not empty
        If TextBox1.Text.Trim() <> "" Then
            ' Add the word to the ListBox
            ListBox1.Items.Add(TextBox1.Text)

            ' Clear the TextBox
            TextBox1.Clear()
        Else
            MessageBox.Show("Please enter a word.")
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            ' Get the selected word
            Dim selectedWord As String = ListBox1.SelectedItem.ToString()

            ' Get the selected color from the ComboBox
            Dim selectedColor As Color
            Select Case ComboBox1.SelectedIndex
                Case 0 ' Red
                    selectedColor = Color.Red
                Case 1 ' Green
                    selectedColor = Color.Green
                Case 2 ' Blue
                    selectedColor = Color.Blue
                Case Else
                    selectedColor = Color.Black
            End Select

            ' Display the selected word in the chosen color
            Label1.Text = selectedWord
            Label1.ForeColor = selectedColor
        End If
    End Sub
End Class
