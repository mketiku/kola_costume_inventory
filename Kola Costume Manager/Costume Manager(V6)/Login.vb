Public Class frmLogin

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LogonDataSet.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.LogonDataSet.Login)
        'TODO: This line of code loads data into the 'LogonDataSet.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.LogonDataSet.Login)

    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If txtUsername.Text = "mketiku" And txtPassword.Text = "school" Then
            frmMain.ShowDialog()
        Else
            MessageBox.Show("WRONG", "Try AGAIN")
        End If

        'If txtUsername.Text = Me.LoginBindingSource.Then Then
        '    Me.Validate()
        '    Me.LoginBindingSource.EndEdit()
        '    Me.TableAdapterManager.UpdateAll(Me.LogonDataSet)
        ' End If
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

    End Sub

    Private Sub LoginBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LoginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LogonDataSet)

    End Sub

    Private Sub LoginBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LoginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LogonDataSet)

    End Sub

    Private Sub LoginBindingNavigator_RefreshItems(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtUsername_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.LoginTableAdapter.FillBy(Me.LogonDataSet.Login)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class