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

        k = 1
        i = 1
        zjr = 1 '中间人，中转变量
        Do While k < ZCS - 1
            If Qab(i, k) > Qab(i + 1, k) Then
                Sheet3.Cells(D1C - k + 1 - i, GJC_no) = "关键层"
                Sheet3.Cells(D1C - k + 1 - i, GJC_no + 1) = k + i
                Sheet3.Cells(D1C + 1 - zjr, GJC_no + 2) = Qab(i, zjr)
                Sheet3.Cells(D1C + 1 - zjr, GJC_no + 3) = Sheet3.Cells(D1C + 1 - zjr, h_no) * Math.Sqrt(2 * Sheet3.Cells(D1C + 1 - zjr, R1_no) / Qab(i, zjr))
                zjr = k + i
                k = k + i
                i = 1
            Else
                Sheet3.Cells(D1C - k + 1 - i, GJC_no) = "该层不是关键层"
                i = i + 1
            End If
            If i > ZCS - k Then
                Sheet3.Cells(D1C + 1 - k, GJC_no + 2) = Qab(i - 1, k)
                Sheet3.Cells(D1C + 1 - k, GJC_no + 3) = Sheet3.Cells(D1C + 1 - k, h_no) * Math.Sqrt(2 * Sheet3.Cells(D1C + 1 - k, R1_no) / Qab(i - 1, k))
                k = ZCS - 1
            End If
        Loop
    End Sub
    Function FZab(a, b) 'b层位之上第a层对第b层的荷载（分子计算）a=1指示第b层本身
        R2 = 0
        For i = 1 To a
            R1 = Sheet3.Cells(D1C + 1 - b + 1 - i, h_no) * Sheet3.Cells(D1C + 1 - b + 1 - i, r_no)
            R2 = R1 + R2
        Next i
        FZab = Sheet3.Cells(D1C + 1 - b, E_no) * Sheet3.Cells(D1C + 1 - b, h_no) ^ 3 * R2
    End Function
    Function FMab(a, b) 'b层位之上第a层对第b层的荷载（分母计算）a=1指示第b层本身
        R2 = 0
        For i = 1 To a
            R1 = Sheet3.Cells(D1C + 1 - b + 1 - i, E_no) * Sheet3.Cells(D1C + 1 - b + 1 - i, h_no) ^ 3
            R2 = R1 + R2
        Next i
        FMab = R2
    End Function
    Function Qab(a, b)
        Qab = FZab(a, b) / FMab(a, b)
    End Function

End Module
