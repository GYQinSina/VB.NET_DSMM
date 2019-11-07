Module Gjc
    Sub D_GJC()
        ZCS = 32 '总层数  煤层顶板到表土层32 38 38 17
        D1C = 34 '第一层顶板的行数34 79 123 146
        h_no = 3 '厚度列号
        r_no = 4 '容重列号
        E_no = 5 '弹性模量列号
        R1_no = 6 '抗拉强度列号
        GJC_no = 7 '关键层标记列号
        '------------------------------确定关键层-------------------------
        Dim k, i, zjr As Integer
        Dim BarMinVal, BarMaxVal, InterVal As Double
        k = 1
        i = 1
        zjr = 1 '中间人，中转变量
        BarMinVal = MainForm.ToolStripProgressBar1.Minimum
        BarMaxVal = MainForm.ToolStripProgressBar1.Maximum
        InterVal = (BarMaxVal - BarMinVal) / (ZCS - 1)
        Do While k < ZCS - 1
            If Qab(i, k) > Qab(i + 1, k) Then
                Sheet3.Cells(D1C - k + 1 - i, GJC_no) = "关键层"
                Sheet3.Cells(D1C - k + 1 - i, GJC_no + 1) = k + i
                Sheet3.Cells(D1C + 1 - zjr, GJC_no + 2) = Qab(i, zjr)
                Sheet3.Cells(D1C + 1 - zjr, GJC_no + 3) = Sheet3.Cells(D1C + 1 - zjr, h_no).value * Math.Sqrt(2 * Sheet3.Cells(D1C + 1 - zjr, R1_no).value / Qab(i, zjr))
                zjr = k + i
                k = k + i
                i = 1
            Else
                Sheet3.Cells(D1C - k + 1 - i, GJC_no) = "该层不是关键层"
                i = i + 1
            End If
            If i > ZCS - k Then
                Sheet3.Cells(D1C + 1 - k, GJC_no + 2) = Qab(i - 1, k)
                Sheet3.Cells(D1C + 1 - k, GJC_no + 3) = Sheet3.Cells(D1C + 1 - k, h_no).value * Math.Sqrt(2 * Sheet3.Cells(D1C + 1 - k, R1_no).value / Qab(i - 1, k))
                k = ZCS - 1
            End If
            'MsgBox("一个Loop")
            MainForm.ToolStripProgressBar1.Value = BarMinVal + k * InterVal
        Loop
    End Sub
    Function FZab(a, b) 'b层位之上第a层对第b层的荷载（分子计算）a=1指示第b层本身
        R2 = 0
        For i = 1 To a
            R1 = Sheet3.Cells(D1C + 1 - b + 1 - i, h_no).value * Sheet3.Cells(D1C + 1 - b + 1 - i, r_no).value
            R2 = R1 + R2
        Next i
        FZab = Sheet3.Cells(D1C + 1 - b, E_no).value * Sheet3.Cells(D1C + 1 - b, h_no).value ^ 3 * R2
    End Function
    Function FMab(a, b) 'b层位之上第a层对第b层的荷载（分母计算）a=1指示第b层本身
        R2 = 0
        For i = 1 To a
            R1 = Sheet3.Cells(D1C + 1 - b + 1 - i, E_no).value * Sheet3.Cells(D1C + 1 - b + 1 - i, h_no).value ^ 3
            R2 = R1 + R2
        Next i
        FMab = R2
    End Function
    Function Qab(a, b)
        Qab = FZab(a, b) / FMab(a, b)
    End Function

    Sub a()
        Dim A1, A2, A3 As Integer
        Dim ds As New DataSet1
        Dim dt As DataSet1.GYQDataTable

        dt = ds.Tables("GYQ")
        A1 = A2 = A3 = dt.Rows(1).Item(1) + dt.Rows(1).Item(1)

        Dim B1 As New ADOX.Column


    End Sub


End Module
