Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub

    Private Sub ComboBox19_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxWaist.SelectedIndexChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles gbxCostumeItem.Enter

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ComboBox14_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxUse.SelectedIndexChanged

    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSource.SelectedIndexChanged

    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEra.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxColor.SelectedIndexChanged

    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxWeight.SelectedIndexChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub ComboBox33_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxFiber.SelectedIndexChanged

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmSearch.Show()
    End Sub

    Private Sub txtCostumeDescription_TextChanged(sender As Object, e As EventArgs) Handles txtCostumeDescription.TextChanged

    End Sub

    Private Sub BrowsePic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowsePic.Click
        'Browse Images

        Dim ImageDialogue As OpenFileDialog = New OpenFileDialog()

        ImageDialogue.Title = "Select your Image."
        ImageDialogue.InitialDirectory = "C:\"
        ImageDialogue.Filter = "Image Files|*.gif;*.jpg;*.png;*.bmp;"
        ImageDialogue.RestoreDirectory = False

        If ImageDialogue.ShowDialog() = DialogResult.OK Then
            PictureBox.Image = Image.FromFile(ImageDialogue.FileName)
        End If

        'Upload Images
        cmd = New SqlCommand("Insert Into Proposer Values(& @Picture )", con)
        If con.State = ConnectionState.Closed Then con.Open()

        Dim ms As New MemoryStream()
        PictureBox.Image.Save(ms, PictureBox.Image.RawFormat)
        Dim data As Byte() = ms.GetBuffer()
        Dim p As New SqlParameter("@Picture", SqlDbType.Image)
        p.Value = data
        cmd.Parameters.Add(p)
        cmd.ExecuteNonQuery()

        con.Close()

        'Retrieve Images
        Dim data As Byte() = DirectCast(dr("Picture"), Byte())
        Dim ms As New MemoryStream(data)
        Edt_PictureBox.Image = Image.FromStream(ms)

    End Sub

End Class
