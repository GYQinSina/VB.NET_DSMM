Module GenNewData
    Public Sub GenData()
        Dim var1, var2, var3, i, X_inc, n, sum_L As Integer


        For i = 1 To Data_no
            If Sheet4.Cells(StartLine_no + i - 1, N_no) = 1 Then   '不需要块体等分的岩层
                '复制数据
                For j = 2 To 17
                    Sheet7.Cells(StartLine_no + end_no, j) = Sheet4.Cells(StartLine_no + i - 1, j) 'StartLine_no指示第1个block的行号；
                Next j
                end_no = end_no + 1 '生成的总blocks +1

            Else '岩层等分块体|N_no不等于1，按照目标数目生成新数据
                n = Sheet4.Cells(StartLine_no + i - 1, N_no) '获取等分要求
                sum_L = Sheet4.Cells(StartLine_no + i - 1, 5) - Sheet4.Cells(StartLine_no + i - 1, 2)

                '-------------------------普通岩体划分（0）----------------------------------------------------------------------------
                If Sheet4.Cells(StartLine_no + i - 1, 18) = 0 Then
                    var1 = StartLine_no + end_no '指示起始block对应的行号
                    end_no = end_no + n + 2
                    var2 = StartLine_no + end_no - 1 '指示本次生成Blocks的最终行号
                    var3 = (sum_L - Mining_L - 2 * Disco_L) / 2
                    X_inc = (Mining_L + 2 * Disco_L) / n 'X增量

                    '左侧大块------------------------------------------
                    For j = 2 To 17
                        Sheet7.Cells(var1, j) = Sheet4.Cells(StartLine_no + i - 1, j) '先全部复制
                    Next j
                    Sheet7.Cells(var1, 5) = Sheet4.Cells(StartLine_no + i - 1, 2) + var3 '修改右上角点的X
                    Sheet7.Cells(var1, N_no) = 1 '修改N_no
                    Sheet7.Cells(var1, FaceID_Right_no) = Spec_ID '修改右面接触面为spec
                    '左侧第1/n块---------------------------------------
                    For j = 2 To 17
                        Sheet7.Cells(var1 + 1, j) = Sheet4.Cells(StartLine_no + i - 1, j) '先全部复制
                    Next j
                    Sheet7.Cells(var1 + 1, 2) = Sheet4.Cells(StartLine_no + i - 1, 2) + var3 '修改左下角点的X
                    Sheet7.Cells(var1 + 1, 5) = Sheet4.Cells(StartLine_no + i - 1, 2) + var3 + X_inc '修改右上角点的X
                    Sheet7.Cells(var1 + 1, N_no) = 1 '修改N_no
                    Sheet7.Cells(var1 + 1, FaceID_Left_no) = Spec_ID '修改左面接触面为spec
                    Sheet7.Cells(var1 + 1, FaceID_Right_no) = 2 '修改左面接触面为2
                    '右侧大块-----------------------------------
                    For m = 2 To 17
                        Sheet7.Cells(var2, m) = Sheet4.Cells(StartLine_no + i - 1, m) '先全部复制
                    Next m
                    Sheet7.Cells(var2, 2) = Sheet4.Cells(StartLine_no + i - 1, 5) - var3 '修改左下角点的X
                    Sheet7.Cells(var2, N_no) = 1 '修改N_no
                    Sheet7.Cells(var2, FaceID_Left_no) = Spec_ID '修改左面接触面为spec
                    '右侧n/n块----------------------------
                    For m = 2 To 17
                        Sheet7.Cells(var2 - 1, m) = Sheet4.Cells(StartLine_no + i - 1, m) '先全部复制
                    Next m
                    Sheet7.Cells(var2 - 1, 2) = Sheet4.Cells(StartLine_no + i - 1, 5) - var3 - X_inc '修改左下角点的X
                    Sheet7.Cells(var2 - 1, 5) = Sheet4.Cells(StartLine_no + i - 1, 5) - var3 '修改右上角点的X
                    Sheet7.Cells(var2 - 1, N_no) = 1 '修改N_no
                    Sheet7.Cells(var2 - 1, FaceID_Left_no) = 2 '修改右面接触面为2
                    Sheet7.Cells(var2 - 1, FaceID_Right_no) = Spec_ID '修改右面接触面为spec
                    '如果n>2，则执行下面if条件，否则略过该部分
                    If n > 2 Then
                        For k = 2 To n - 1
                            For l = 2 To 17 '先全部复制
                                Sheet7.Cells(var1 + k, l) = Sheet4.Cells(StartLine_no + i - 1, l)
                            Next l

                            Sheet7.Cells(var1 + k, 2) = Sheet4.Cells(StartLine_no + i - 1, 2) + var3 + (k - 1) * X_inc '改2 X1
                            Sheet7.Cells(var1 + k, 5) = Sheet4.Cells(StartLine_no + i - 1, 2) + var3 + k * X_inc '改5 X2
                            Sheet7.Cells(var1 + k, N_no) = 1 '改N_no=1
                            Sheet7.Cells(var1 + k, FaceID_Left_no) = 2 '改L 2
                            Sheet7.Cells(var1 + k, FaceID_Right_no) = 2 '改R 2
                        Next k
                    End If
                End If
                '---------------------------煤层划分（1）----------------------------------------------------------------------------------
                If Sheet4.Cells(StartLine_no + i - 1, 18) = 1 Then
                    var1 = StartLine_no + end_no '指示起始block对应的行号
                    end_no = end_no + n + 2
                    var2 = StartLine_no + end_no - 1 '指示本次生成Blocks的最终行号
                    var3 = (sum_L - Mining_L) / 2
                    X_inc = Mining_L / n 'X增量

                    '左侧大块------------------------------------------
                    For j = 2 To 17
                        Sheet7.Cells(var1, j) = Sheet4.Cells(StartLine_no + i - 1, j) '先全部复制
                    Next j
                    Sheet7.Cells(var1, 5) = Sheet4.Cells(StartLine_no + i - 1, 2) + var3 '修改右上角点的X
                    Sheet7.Cells(var1, N_no) = 1 '修改N_no
                    Sheet7.Cells(var1, FaceID_Right_no) = 2 '修改右面接触面为2
                    '左侧第1/n块---------------------------------------
                    For j = 2 To 17
                        Sheet7.Cells(var1 + 1, j) = Sheet4.Cells(StartLine_no + i - 1, j) '先全部复制
                    Next j
                    Sheet7.Cells(var1 + 1, 2) = Sheet4.Cells(StartLine_no + i - 1, 2) + var3 '修改左下角点的X
                    Sheet7.Cells(var1 + 1, 5) = Sheet4.Cells(StartLine_no + i - 1, 2) + var3 + X_inc '修改右上角点的X
                    Sheet7.Cells(var1 + 1, N_no) = 1 '修改N_no
                    Sheet7.Cells(var1 + 1, FaceID_Left_no) = 2 '修改左面接触面为2
                    Sheet7.Cells(var1 + 1, FaceID_Right_no) = 2 '修改左面接触面为2
                    '右侧大块-----------------------------------
                    For m = 2 To 17
                        Sheet7.Cells(var2, m) = Sheet4.Cells(StartLine_no + i - 1, m) '先全部复制
                    Next m
                    Sheet7.Cells(var2, 2) = Sheet4.Cells(StartLine_no + i - 1, 5) - var3 '修改左下角点的X
                    Sheet7.Cells(var2, N_no) = 1 '修改N_no
                    Sheet7.Cells(var2, FaceID_Left_no) = 2 '修改左面接触面为2
                    '右侧n/n块----------------------------
                    For m = 2 To 17
                        Sheet7.Cells(var2 - 1, m) = Sheet4.Cells(StartLine_no + i - 1, m) '先全部复制
                    Next m
                    Sheet7.Cells(var2 - 1, 2) = Sheet4.Cells(StartLine_no + i - 1, 5) - var3 - X_inc '修改左下角点的X
                    Sheet7.Cells(var2 - 1, 5) = Sheet4.Cells(StartLine_no + i - 1, 5) - var3 '修改右上角点的X
                    Sheet7.Cells(var2 - 1, N_no) = 1 '修改N_no
                    Sheet7.Cells(var2 - 1, FaceID_Left_no) = 2 '修改左面接触面为2
                    Sheet7.Cells(var2 - 1, FaceID_Right_no) = 2 '修改右面接触面为2
                    '如果n>2，则执行下面if条件，否则略过该部分
                    If n > 2 Then
                        For k = 2 To n - 1
                            For l = 2 To 17 '先全部复制
                                Sheet7.Cells(var1 + k, l) = Sheet4.Cells(StartLine_no + i - 1, l)
                            Next l

                            Sheet7.Cells(var1 + k, 2) = Sheet4.Cells(StartLine_no + i - 1, 2) + var3 + (k - 1) * X_inc '改2 X1
                            Sheet7.Cells(var1 + k, 5) = Sheet4.Cells(StartLine_no + i - 1, 2) + var3 + k * X_inc '改5 X2
                            Sheet7.Cells(var1 + k, N_no) = 1 '改N_no=1
                            Sheet7.Cells(var1 + k, FaceID_Left_no) = 2 '改L 2
                            Sheet7.Cells(var1 + k, FaceID_Right_no) = 2 '改R 2
                        Next k
                    End If
                End If
                '---------------------底板、第四系 划分（2）----------------------------------------------------------------------------------
                If Sheet4.Cells(StartLine_no + i - 1, 18) = 2 Then
                    var1 = StartLine_no + end_no '指示起始block对应的行号
                    end_no = end_no + n
                    var2 = StartLine_no + end_no - 1 '指示本次生成Blocks的最终行号
                    X_inc = sum_L / n 'X增量
                    '第1块 第1个L为1
                    For j = 2 To 17
                        Sheet7.Cells(var1, j) = Sheet4.Cells(StartLine_no + i - 1, j) '先全部复制
                    Next j
                    Sheet7.Cells(var1, 5) = Sheet7.Cells(var1, 2) + X_inc '修改右上角点的X
                    Sheet7.Cells(var1, N_no) = 1 '修改N_no
                    Sheet7.Cells(var1, FaceID_Right_no) = 2 '修改右面接触面为2
                    '第2到n-1块
                    If n > 2 Then '判断n是否大于2,中间L R都为2
                        For k = 2 To n - 1 '把原来1个x数据分成n个x，Y、Z不变化。变换X,N_no,FaceID L R都为2
                            For l = 2 To 17 '先全部复制
                                Sheet7.Cells(var1 + k - 1, l) = Sheet4.Cells(StartLine_no + i - 1, l)
                            Next l
                            Sheet7.Cells(var1 + k - 1, 2) = Sheet4.Cells(StartLine_no + i - 1, 2) + (k - 1) * X_inc '改2 X1
                            Sheet7.Cells(var1 + k - 1, 5) = Sheet4.Cells(StartLine_no + i - 1, 2) + k * X_inc '改5 X2
                            Sheet7.Cells(var1 + k - 1, N_no) = 1 '改N_no=1
                            Sheet7.Cells(var1 + k - 1, FaceID_Left_no) = 2 '改L 2
                            Sheet7.Cells(var1 + k - 1, FaceID_Right_no) = 2 '改R 2
                        Next k
                    End If
                    '第n块 最后一个R为1
                    For m = 2 To 17
                        Sheet7.Cells(var2, m) = Sheet4.Cells(StartLine_no + i - 1, m) '先全部复制
                    Next m
                    Sheet7.Cells(var2, 2) = Sheet4.Cells(StartLine_no + i - 1, 2) + (n - 1) * X_inc '修改左下角点的X
                    Sheet7.Cells(var2, N_no) = 1 '修改N_no
                    Sheet7.Cells(var2, FaceID_Left_no) = 2 '修改右面接触面为2
                End If
            End If
        Next i

        Sheet7.Cells(2, 1) = end_no

        Sheet7.Cells(2, 2) = "x1"
        Sheet7.Cells(2, 3) = "y1"
        Sheet7.Cells(2, 4) = "z1"
        Sheet7.Cells(2, 5) = "x2"
        Sheet7.Cells(2, 6) = "y2"
        Sheet7.Cells(2, 7) = "z2"

        Sheet7.Cells(2, 8) = "Group Name"
        Sheet7.Cells(2, 9) = "Mat."
        Sheet7.Cells(2, 10) = "Con."
        Sheet7.Cells(2, 11) = "分组数"

        Sheet7.Cells(2, 12) = "FaceID Front"
        Sheet7.Cells(2, 13) = "FaceID Back"
        Sheet7.Cells(2, 14) = "FaceID Left"
        Sheet7.Cells(2, 15) = "FaceID Right"
        Sheet7.Cells(2, 16) = "FaceID Top"
        Sheet7.Cells(2, 17) = "FaceID Bottom"

        For i = 1 To end_no
            Sheet7.Cells(i + 2, 1) = i
        Next i

        For i = 1 To 18
            Sheet7.Cells(1, i) = i
        Next i


    End Sub
End Module
