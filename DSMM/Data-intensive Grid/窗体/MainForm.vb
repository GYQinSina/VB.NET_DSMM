Imports Microsoft.Office.Interop
Public Class MainForm
    Private Sub 文件FToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 文件FToolStripMenuItem.Click

    End Sub

    Private Sub 输出结果ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 输出结果ToolStripMenuItem.Click

    End Sub

    Private Sub 选项ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 选项ToolStripMenuItem.Click

    End Sub

    Private Sub 导入EXCEL数据文件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 导入EXCEL数据文件ToolStripMenuItem.Click
        Call IniPubVars()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim ObjPath As String
        OpenFileDialog1.ShowDialog()
        ObjPath = OpenFileDialog1.FileName
        'MsgBox("haha" & ObjPath)
        objWorkbook = objExcel.Workbooks.Add(ObjPath)
        Sheet1 = objWorkbook.Sheets("Sheet1")
        Sheet1.Cells(1, 1) = "Success!"
        objExcel.Visible = False

        DaoRu_Dialog.Show()

    End Sub
End Class
