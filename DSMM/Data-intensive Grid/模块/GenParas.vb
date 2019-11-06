Module GenParas
    Public Sub GenParas()
        ii = 38 '原始数据条目数
        start_no = 4 '原始数据中第一个分组的起始行号
        '-------------------change mat range-------------------
        For i = 1 To ii
            Sheet10.Cells(i, 1) = "change mat " & i & " range group " & Sheet9.Cells(start_no + i - 1, 2)
        Next i
        '-------------------prop mat -------------------
        For j = 1 To ii
            Sheet10.Cells(ii + j, 1) = "prop mat " & j & " k " & Sheet9.Cells(start_no + j - 1, 4) & " g " & Sheet9.Cells(start_no + j - 1, 5) & " bcoh " & Sheet9.Cells(start_no + j - 1, 6) & " phi " & Sheet9.Cells(start_no + j - 1, 7) & " bten " & Sheet9.Cells(start_no + j - 1, 8) & " den " & Sheet9.Cells(start_no + j - 1, 3)
        Next j
    End Sub
End Module
