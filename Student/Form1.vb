Public Class frmbirth


    Private Sub frmbirth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BIT2118DataSet.Birthdetails' table. You can move, or remove it, as needed.
        Me.BirthdetailsTableAdapter.Fill(Me.BIT2118DataSet.Birthdetails)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        BirthdetailsBindingSource.MovePrevious()
    End Sub


    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        BirthdetailsBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        BirthdetailsBindingSource.MoveNext()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter
        Dim rButton As RadioButton =
         GroupBox2.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        BirthdetailsBindingSource.RemoveCurrent()
        BirthdetailsTableAdapter.Update(BIT2118DataSet)
        MsgBox("Entry successfully deleted.")
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            BirthdetailsBindingSource.EndEdit()
            BirthdetailsTableAdapter.Update(BIT2118DataSet)
            MsgBox("Entry successfully added.")
        Catch ex As Exception
            MsgBox("An error has occurred" & ex.Message)
        End Try
    End Sub

    Private Sub rbmale_CheckedChanged(sender As Object, e As EventArgs) Handles rbmale.CheckedChanged
        txtgender.Text = "Male"
    End Sub

    Private Sub rbfemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbfemale.CheckedChanged
        txtgender.Text = "Female"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
