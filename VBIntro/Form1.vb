Public Class Form1

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If CheckBox1.Checked = True Then
            My.Settings.User = username.Text
            My.Settings.Pass = password.Text
        Else
            My.Settings.User = ""
            My.Settings.Pass = ""
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        username.Text = My.Settings.User
        password.Text = My.Settings.Pass
    End Sub
End Class
