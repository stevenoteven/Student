Public Class frmexams
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub frmexams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BIT2118DataSet.Exams' table. You can move, or remove it, as needed.
        Me.ExamsTableAdapter.Fill(Me.BIT2118DataSet.Exams)

    End Sub

    Private Sub txtmarks_TextChanged(sender As Object, e As EventArgs) Handles txtmarks.TextChanged

    End Sub

    Private Sub txtgrade_TextChanged(sender As Object, e As EventArgs) Handles txtgrade.TextChanged

    End Sub

    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        Dim eng, swa, math, sci, his, geo, cre, total, avg As Double
        eng = txteng.Text
        swa = txtswa.Text
        math = txtmath.Text
        sci = txtsci.Text
        his = txthistory.Text
        geo = txtgeo.Text
        cre = txtcre.Text
        total = eng + swa + math + sci + his + geo + cre
        txtmarks.Text = total
        avg = total / 7
        If avg >= 100 & avg <= 80 Then
            txtgrade.Text = "A"
        ElseIf avg > 80 & avg <= 70 Then
            txtgrade.Text = "B"
        ElseIf avg > 70 & avg <= 60 Then
            txtgrade.Text = "C"
        ElseIf avg > 60 & avg <= 50 Then
            txtgrade.Text = "D"
        ElseIf avg > 50 & avg <= 40 Then
            txtgrade.Text = "E"
        ElseIf avg > 40 & avg <= 0 Then
            txtgrade.Text = "Fail"
        Else
            MsgBox("An error has occured.")
        End If
    End Sub
End Class
