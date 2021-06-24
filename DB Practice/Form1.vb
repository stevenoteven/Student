Public Class tbltest
    Private Sub TblexamsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblexamsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblexamsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BIT2118DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BIT2118DataSet.tblexams' table. You can move, or remove it, as needed.
        Me.TblexamsTableAdapter.Fill(Me.BIT2118DataSet.tblexams)

    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        TblexamsBindingSource.MovePrevious()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        TblexamsBindingSource.MoveNext()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        TblexamsBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(BIT2118DataSet)
        MsgBox("Entry successfully deleted")
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            TblexamsBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(BIT2118DataSet)
            MsgBox("Entry successfully added.")
        Catch ex As Exception
            MsgBox("An error has occurred" & ex.Message)
        End Try
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        TblexamsBindingSource.AddNew()
    End Sub
End Class
