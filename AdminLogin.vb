Public Class AdminLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "admin" AndAlso password = "admin123" Then

            MessageBox.Show("Login Successful!", "Admin Login",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            Me.Hide()
            Form1.Show()

        Else

            MessageBox.Show("Invalid Username or Password!",
                            "Login Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

            txtPassword.Clear()
            txtPassword.Focus()

        End If

    End Sub


    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtPassword.UseSystemPasswordChar = True

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub

End Class