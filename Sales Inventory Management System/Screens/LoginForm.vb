Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (IsFormValid()) Then
            qr = "Select * from UserLogin where UserName='" & TextBox1.Text & "'and Password='" & TextBox2.Text & "'and UserType='" & ComboBox1.Text & "'"
            ds = SearchData(qr)
            If (ds.Tables(0).Rows.Count > 0) Then
                DashboardForm.Show()
                Me.Close()
            Else
                MsgBox("Username and Password Incorrect!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Function IsFormValid() As Boolean
        If (TextBox1.Text.Trim() = String.Empty) Then
            MsgBox("Username  is Required", MsgBoxStyle.Critical)
            TextBox1.Clear()
            TextBox2.Clear()
            Return False
        End If

        If (TextBox2.Text.Trim() = String.Empty) Then
            MsgBox("Password  is Required", MsgBoxStyle.Critical)
            TextBox1.Clear()
            TextBox2.Clear()
            Return False
        End If

        If (ComboBox1.SelectedIndex = -1) Then
            MsgBox("UserType  is Required", MsgBoxStyle.Critical)
            TextBox1.Clear()
            TextBox2.Clear()
            Return False
        End If
        Return True
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        btnLogin.Enabled = True

    End Sub
End Class