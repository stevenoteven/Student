Public Class Form1
    Private Sub RegistrationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RegistrationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RegistrationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BIT2118DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BIT2118DataSet.Registration' table. You can move, or remove it, as needed.
        Me.RegistrationTableAdapter.Fill(Me.BIT2118DataSet.Registration)

    End Sub

    Private Sub rbmale_CheckedChanged(sender As Object, e As EventArgs) Handles rbmale.CheckedChanged
        GenderTextBox.Text = "Male"
    End Sub

    Private Sub rbfemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbfemale.CheckedChanged
        GenderTextBox.Text = "Female"
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        RegistrationBindingSource.MoveNext()
    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        RegistrationBindingSource.MovePrevious()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        RegistrationBindingSource.RemoveCurrent()
        RegistrationTableAdapter.Update(BIT2118DataSet)
        MsgBox("Entry successfully deleted.")
    End Sub

    Private Sub txtregister_Click(sender As Object, e As EventArgs) Handles txtregister.Click
        Try
            RegistrationBindingSource.EndEdit()
            RegistrationTableAdapter.Update(BIT2118DataSet)
            MsgBox("Entry successfully added.")
        Catch ex As Exception
            MsgBox("An error has occurred" & ex.Message)
        End Try
    End Sub
End Class
