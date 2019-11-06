Imports System.Windows.Forms

Public Class DaoRu_Dialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DaoRu_Dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 10
        ProgressBar1.Value = 30
        ProgressBar1.Value = 60
        ProgressBar1.Value = 100


    End Sub


End Class
