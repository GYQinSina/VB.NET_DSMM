Imports Microsoft.Office.Interop
Public Class MainForm
    Private Sub 文件FToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 文件FToolStripMenuItem.Click

    End Sub

    Private Sub 输出结果ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 输出结果ToolStripMenuItem.Click

    End Sub

    Private Sub 选项ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 选项ToolStripMenuItem.Click

    End Sub

    Private Sub 新建EXCEL数据文件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 导入EXCEL数据文件ToolStripMenuItem.Click
        Call IniPubVars()
        '初始化excel
        TemplatePath = My.Application.Info.DirectoryPath & "\Template.xlsx"
        objWorkbook = objExcel.Workbooks.Add(TemplatePath)
        Sheet1 = objWorkbook.Sheets(1)
        Sheet1.Cells(1, 1) = "Success!"
        objExcel.Visible = True
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim ObjPath As String
        OpenFileDialog1.ShowDialog()
        ObjPath = OpenFileDialog1.FileName
        'MsgBox("haha" & ObjPath)
        objWorkbook = objExcel.Workbooks.Add(ObjPath)
        Sheet1 = objWorkbook.Sheets(1)
        Sheet2 = objWorkbook.Sheets(2)
        Sheet3 = objWorkbook.Sheets(3)
        Sheet4 = objWorkbook.Sheets(4)
        Sheet5 = objWorkbook.Sheets(5)
        Sheet6 = objWorkbook.Sheets(6)
        Sheet7 = objWorkbook.Sheets(7)
        Sheet8 = objWorkbook.Sheets(8)
        Sheet9 = objWorkbook.Sheets(9)
        Sheet10 = objWorkbook.Sheets(10)

        Sheet1.Cells(41, 1) = 10
        Sheet1.Cells(41, 2) = 20
        R1 = Sheet1.Cells(41, 1).value + Sheet1.Cells(41, 2).value
        Sheet1.Cells(42, 1) = R1
        objExcel.Visible = True
        '导入成功提示
        'DaoRu_Dialog.Show()

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Call IniPubVars()
        Call D_GJC()
    End Sub

    Private Sub ToolStripProgressBar1_Click(sender As Object, e As EventArgs) Handles ToolStripProgressBar1.Click
        ToolStripProgressBar1.Value = 10
    End Sub
End Class
