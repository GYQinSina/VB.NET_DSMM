Module GenBlocks
    Public Sub OutPutTxt()

    End Sub
    '生成标准6面体单元
    Public Sub Gen_6sided_block(a, b, c, d, e, f)
        Sheet6.Cells(CodeStartLine_no + 32 * (G_i - 1), 1) = "; Block " & G_i
        Sheet6.Cells(CodeStartLine_no + 1 + 32 * (G_i - 1), 1) = "poly group " & Sheet7.Cells(StartLine_no + G_i - 1, GroupName_no) & " mat " & Sheet7.Cells(StartLine_no + G_i - 1, Mat_no) & " con " & Sheet7.Cells(StartLine_no + G_i - 1, Con_no) & " &"
        '第1个面，前面
        Sheet6.Cells(CodeStartLine_no + 2 + 32 * (G_i - 1), 1) = "face id " & Sheet7.Cells(StartLine_no + G_i - 1, FaceID_Front_no) & " &"
        Sheet6.Cells(CodeStartLine_no - 1 + 4 + 32 * (G_i - 1), 1) = " " & a & " " & b & " " & c & " & " '1
        Sheet6.Cells(CodeStartLine_no - 1 + 5 + 32 * (G_i - 1), 1) = " " & a & " " & b & " " & f & " & " '2
        Sheet6.Cells(CodeStartLine_no - 1 + 6 + 32 * (G_i - 1), 1) = " " & d & " " & b & " " & f & " & " '3
        Sheet6.Cells(CodeStartLine_no - 1 + 7 + 32 * (G_i - 1), 1) = " " & d & " " & b & " " & c & " & " '4
        '第2个面，后面
        Sheet6.Cells(CodeStartLine_no - 1 + 8 + 32 * (G_i - 1), 1) = "face id " & Sheet7.Cells(StartLine_no + G_i - 1, FaceID_Back_no) & " &"
        Sheet6.Cells(CodeStartLine_no - 1 + 9 + 32 * (G_i - 1), 1) = " " & a & " " & e & " " & c & " & " '1o
        Sheet6.Cells(CodeStartLine_no - 1 + 10 + 32 * (G_i - 1), 1) = " " & d & " " & e & " " & c & " & " '4o
        Sheet6.Cells(CodeStartLine_no - 1 + 11 + 32 * (G_i - 1), 1) = " " & d & " " & e & " " & f & " & " '3o
        Sheet6.Cells(CodeStartLine_no - 1 + 12 + 32 * (G_i - 1), 1) = " " & a & " " & e & " " & f & " & " '2o
        '第3个面，左面
        Sheet6.Cells(CodeStartLine_no - 1 + 13 + 32 * (G_i - 1), 1) = "face id " & Sheet7.Cells(StartLine_no + G_i - 1, FaceID_Left_no) & " &"
        Sheet6.Cells(CodeStartLine_no - 1 + 14 + 32 * (G_i - 1), 1) = " " & a & " " & b & " " & c & " & " '1
        Sheet6.Cells(CodeStartLine_no - 1 + 15 + 32 * (G_i - 1), 1) = " " & a & " " & e & " " & c & " & " '1o
        Sheet6.Cells(CodeStartLine_no - 1 + 16 + 32 * (G_i - 1), 1) = " " & a & " " & e & " " & f & " & " '2o
        Sheet6.Cells(CodeStartLine_no - 1 + 17 + 32 * (G_i - 1), 1) = " " & a & " " & b & " " & f & " & " '2
        '第4个面，右面
        Sheet6.Cells(CodeStartLine_no - 1 + 18 + 32 * (G_i - 1), 1) = "face id " & Sheet7.Cells(StartLine_no + G_i - 1, FaceID_Right_no) & " &"
        Sheet6.Cells(CodeStartLine_no - 1 + 19 + 32 * (G_i - 1), 1) = " " & d & " " & b & " " & f & " & " '3
        Sheet6.Cells(CodeStartLine_no - 1 + 20 + 32 * (G_i - 1), 1) = " " & d & " " & e & " " & f & " & " '3o
        Sheet6.Cells(CodeStartLine_no - 1 + 21 + 32 * (G_i - 1), 1) = " " & d & " " & e & " " & c & " & " '4o
        Sheet6.Cells(CodeStartLine_no - 1 + 22 + 32 * (G_i - 1), 1) = " " & d & " " & b & " " & c & " & " '4
        '第5个面，上面
        Sheet6.Cells(CodeStartLine_no - 1 + 23 + 32 * (G_i - 1), 1) = "face id " & Sheet7.Cells(StartLine_no + G_i - 1, FaceID_Top_no) & " &"
        Sheet6.Cells(CodeStartLine_no - 1 + 24 + 32 * (G_i - 1), 1) = " " & a & " " & b & " " & f & " & " '2
        Sheet6.Cells(CodeStartLine_no - 1 + 25 + 32 * (G_i - 1), 1) = " " & a & " " & e & " " & f & " & " '2o
        Sheet6.Cells(CodeStartLine_no - 1 + 26 + 32 * (G_i - 1), 1) = " " & d & " " & e & " " & f & " & " '3o
        Sheet6.Cells(CodeStartLine_no - 1 + 27 + 32 * (G_i - 1), 1) = " " & d & " " & b & " " & f & " & " '3
        '第6个面，下面
        Sheet6.Cells(CodeStartLine_no - 1 + 28 + 32 * (G_i - 1), 1) = "face id " & Sheet7.Cells(StartLine_no + G_i - 1, FaceID_Bottom_no) & " &"
        Sheet6.Cells(CodeStartLine_no - 1 + 29 + 32 * (G_i - 1), 1) = " " & a & " " & b & " " & c & " & " '1
        Sheet6.Cells(CodeStartLine_no - 1 + 30 + 32 * (G_i - 1), 1) = " " & d & " " & b & " " & c & " & " '4
        Sheet6.Cells(CodeStartLine_no - 1 + 31 + 32 * (G_i - 1), 1) = " " & d & " " & e & " " & c & " & " '4o
        Sheet6.Cells(CodeStartLine_no - 1 + 32 + 32 * (G_i - 1), 1) = " " & a & " " & e & " " & c '1o
        '计数
        G_i = G_i + 1
    End Sub
    '生成 '1个六棱柱 or 四棱柱 +4个三棱柱单元
    Sub Gen5Parts(a, b, c, d, e, f, i)
        '1个六棱柱 or 四棱柱 +4个三棱柱
        Sheet6.Cells(CodeStartLine_no + 0 + 146 * (i - 1), 2) = ";1号三棱柱 Block " & G_i
        Sheet6.Cells(CodeStartLine_no + 1 + 146 * (i - 1), 2) = "poly group " & Sheet7.Cells(StartLine_no + i - 1, GroupName_no) & " mat " & Sheet7.Cells(StartLine_no + i - 1, Mat_no) & " con " & Sheet7.Cells(StartLine_no + i - 1, Con_no) & " &"
        '前面
        Sheet6.Cells(CodeStartLine_no + 2 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Front_no) & " &"
        Sheet6.Cells(CodeStartLine_no + 3 + 146 * (i - 1), 2) = " " & a & " " & b & " " & c & " & " '1                                     1
        Sheet6.Cells(CodeStartLine_no + 4 + 146 * (i - 1), 2) = " " & a & " " & b & " " & c + delt_h & " & " '10                           10
        Sheet6.Cells(CodeStartLine_no + 5 + 146 * (i - 1), 2) = " " & a + delt_h & " " & b & " " & c & " & " '5                            5
        '后面
        Sheet6.Cells(CodeStartLine_no + 6 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Back_no) & " &"
        Sheet6.Cells(CodeStartLine_no + 7 + 146 * (i - 1), 2) = " " & a & " " & e & " " & c & " & " '1o                                    1
        Sheet6.Cells(CodeStartLine_no + 8 + 146 * (i - 1), 2) = " " & a + delt_h & " " & e & " " & c & " & " '5o                           5
        Sheet6.Cells(CodeStartLine_no + 9 + 146 * (i - 1), 2) = " " & a & " " & e & " " & c + delt_h & " & " '10o                          10
        '左面
        Sheet6.Cells(CodeStartLine_no + 10 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Left_no) & " &"
        Sheet6.Cells(CodeStartLine_no + 11 + 146 * (i - 1), 2) = " " & a & " " & b & " " & c & " & " '1
        Sheet6.Cells(CodeStartLine_no + 12 + 146 * (i - 1), 2) = " " & a & " " & e & " " & c & " & " '1o
        Sheet6.Cells(CodeStartLine_no + 13 + 146 * (i - 1), 2) = " " & a & " " & e & " " & c + delt_h & " & " '10o
        Sheet6.Cells(CodeStartLine_no + 14 + 146 * (i - 1), 2) = " " & a & " " & b & " " & c + delt_h & " & " '10
        '下面
        Sheet6.Cells(CodeStartLine_no + 15 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Bottom_no) & " &"
        Sheet6.Cells(CodeStartLine_no + 16 + 146 * (i - 1), 2) = " " & a & " " & b & " " & c & " & " '1
        Sheet6.Cells(CodeStartLine_no + 17 + 146 * (i - 1), 2) = " " & a + delt_h & " " & b & " " & c & " & " '5
        Sheet6.Cells(CodeStartLine_no + 18 + 146 * (i - 1), 2) = " " & a + delt_h & " " & e & " " & c & " & " '5o
        Sheet6.Cells(CodeStartLine_no + 19 + 146 * (i - 1), 2) = " " & a & " " & e & " " & c & " & " '1o
        '侧面 借用第10列 表示内部joint号
        Sheet6.Cells(CodeStartLine_no + 20 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, 10) & " &"
        Sheet6.Cells(CodeStartLine_no + 21 + 146 * (i - 1), 2) = " " & a + delt_h & " " & b & " " & c & " & " '5
        Sheet6.Cells(CodeStartLine_no + 22 + 146 * (i - 1), 2) = " " & a & " " & b & " " & c + delt_h & " & " '10
        Sheet6.Cells(CodeStartLine_no + 23 + 146 * (i - 1), 2) = " " & a & " " & e & " " & c + delt_h & " & " '10o
        Sheet6.Cells(CodeStartLine_no + 24 + 146 * (i - 1), 2) = " " & a + delt_h & " " & e & " " & c '5o
        '下一个block
        G_i = G_i + 1
        Sheet6.Cells(CodeStartLine_no + 25 + 146 * (i - 1), 2) = ";2号三棱柱 Block " & G_i
        Sheet6.Cells(CodeStartLine_no + 26 + 146 * (i - 1), 2) = "poly group " & Sheet7.Cells(StartLine_no + i - 1, GroupName_no) & " mat " & Sheet7.Cells(StartLine_no + i - 1, Mat_no) & " con " & Sheet7.Cells(StartLine_no + i - 1, Con_no) & " &"
        '前面
        Sheet6.Cells(CodeStartLine_no + 27 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Front_no) & " &"
        Sheet6.Cells(CodeStartLine_no + 28 + 146 * (i - 1), 2) = " " & a & " " & b & " " & f & " & " '2                                  2
        Sheet6.Cells(CodeStartLine_no + 29 + 146 * (i - 1), 2) = " " & a + delt_h & " " & b & " " & f & " & " '9                                  9
        Sheet6.Cells(CodeStartLine_no + 30 + 146 * (i - 1), 2) = " " & a & " " & b & " " & c + delt_h & " & " '10
        '后面
        Sheet6.Cells(CodeStartLine_no + 31 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Back_no) & " &"
        Sheet6.Cells(CodeStartLine_no + 32 + 146 * (i - 1), 2) = " " & a & " " & e & " " & f & " & " '2o                                 2；
        Sheet6.Cells(CodeStartLine_no + 33 + 146 * (i - 1), 2) = " " & a & " " & e & " " & c + delt_h & " & " '10o
        Sheet6.Cells(CodeStartLine_no + 34 + 146 * (i - 1), 2) = " " & a + delt_h & " " & e & " " & f & " & " '9o                                 9；
        '左面
        Sheet6.Cells(CodeStartLine_no + 35 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Left_no) & " &"
        Sheet6.Cells(CodeStartLine_no + 36 + 146 * (i - 1), 2) = " " & a & " " & b & " " & f & " & " '2
        Sheet6.Cells(CodeStartLine_no + 37 + 146 * (i - 1), 2) = " " & a & " " & b & " " & c + delt_h & " & " '10
        Sheet6.Cells(CodeStartLine_no + 38 + 146 * (i - 1), 2) = " " & a & " " & e & " " & c + delt_h & " & " '10o
        Sheet6.Cells(CodeStartLine_no + 39 + 146 * (i - 1), 2) = " " & a & " " & e & " " & f & " & " '2o
        '下面
        Sheet6.Cells(CodeStartLine_no + 40 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Bottom_no) & " &"
        Sheet6.Cells(CodeStartLine_no + 41 + 146 * (i - 1), 2) = " " & a & " " & b & " " & f & " & " '2
        Sheet6.Cells(CodeStartLine_no + 42 + 146 * (i - 1), 2) = " " & a & " " & e & " " & f & " & " '2o
        Sheet6.Cells(CodeStartLine_no + 43 + 146 * (i - 1), 2) = " " & a + delt_h & " " & e & " " & f & " & " '9o
        Sheet6.Cells(CodeStartLine_no + 44 + 146 * (i - 1), 2) = " " & a + delt_h & " " & b & " " & f & " & " '9
        '侧面
        Sheet6.Cells(CodeStartLine_no + 45 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, 10) & " &"
        Sheet6.Cells(CodeStartLine_no + 46 + 146 * (i - 1), 2) = " " & a + delt_h & " " & b & " " & f & " & " '9
        Sheet6.Cells(CodeStartLine_no + 47 + 146 * (i - 1), 2) = " " & a + delt_h & " " & e & " " & f & " & " '9o
        Sheet6.Cells(CodeStartLine_no + 48 + 146 * (i - 1), 2) = " " & a & " " & e & " " & c + delt_h & " & " '10o
        Sheet6.Cells(CodeStartLine_no + 49 + 146 * (i - 1), 2) = " " & a & " " & b & " " & c + delt_h '10
        '下一个block
        G_i = G_i + 1
        Sheet6.Cells(CodeStartLine_no + 50 + 146 * (i - 1), 2) = ";4号三棱柱  Block " & G_i
        Sheet6.Cells(CodeStartLine_no + 51 + 146 * (i - 1), 2) = "poly group " & Sheet7.Cells(StartLine_no + i - 1, GroupName_no) & " mat " & Sheet7.Cells(StartLine_no + i - 1, Mat_no) & " con " & Sheet7.Cells(StartLine_no + i - 1, Con_no) & " &"
        '前面
        Sheet6.Cells(CodeStartLine_no + 52 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Front_no) & " &"
        Sheet6.Cells(CodeStartLine_no + 53 + 146 * (i - 1), 2) = " " & d & " " & b & " " & f & " & " '3                                  3
        Sheet6.Cells(CodeStartLine_no + 54 + 146 * (i - 1), 2) = " " & d & " " & b & " " & c + delt_h & " & " '7                                  7
        Sheet6.Cells(CodeStartLine_no + 55 + 146 * (i - 1), 2) = " " & d - delt_h & " " & b & " " & f & " & " '8                                  8
        '后面
        Sheet6.Cells(CodeStartLine_no + 56 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Back_no) & " &"
        Sheet6.Cells(CodeStartLine_no + 57 + 146 * (i - 1), 2) = " " & d & " " & e & " " & f & " & " '3o                                 3；
        Sheet6.Cells(CodeStartLine_no + 58 + 146 * (i - 1), 2) = " " & d - delt_h & " " & e & " " & f & " & " '8o                                 8；
        Sheet6.Cells(CodeStartLine_no + 59 + 146 * (i - 1), 2) = " " & d & " " & e & " " & c + delt_h & " & " '7o                                 7；
        '左面
        Sheet6.Cells(CodeStartLine_no + 60 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Left_no) & " &"
        Sheet6.Cells(CodeStartLine_no + 61 + 146 * (i - 1), 2) = " " & d & " " & b & " " & f & " & " '3
        Sheet6.Cells(CodeStartLine_no + 62 + 146 * (i - 1), 2) = " " & d & " " & e & " " & f & " & " '3o
        Sheet6.Cells(CodeStartLine_no + 63 + 146 * (i - 1), 2) = " " & d & " " & e & " " & c + delt_h & " & " '7o
        Sheet6.Cells(CodeStartLine_no + 64 + 146 * (i - 1), 2) = " " & d & " " & b & " " & c + delt_h & " & " '7
        '下面
        Sheet6.Cells(CodeStartLine_no + 65 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Bottom_no) & " &"
        Sheet6.Cells(CodeStartLine_no + 66 + 146 * (i - 1), 2) = " " & d & " " & b & " " & f & " & " '3
        Sheet6.Cells(CodeStartLine_no + 67 + 146 * (i - 1), 2) = " " & d - delt_h & " " & b & " " & f & " & " '8
        Sheet6.Cells(CodeStartLine_no + 68 + 146 * (i - 1), 2) = " " & d - delt_h & " " & e & " " & f & " & " '8o
        Sheet6.Cells(CodeStartLine_no + 69 + 146 * (i - 1), 2) = " " & d & " " & e & " " & f & " & " '3o
        '侧面
        Sheet6.Cells(CodeStartLine_no + 70 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, 10) & " &"
        Sheet6.Cells(CodeStartLine_no + 71 + 146 * (i - 1), 2) = " " & d & " " & b & " " & c + delt_h & " & " '7
        Sheet6.Cells(CodeStartLine_no + 72 + 146 * (i - 1), 2) = " " & d & " " & e & " " & c + delt_h & " & " '7o
        Sheet6.Cells(CodeStartLine_no + 73 + 146 * (i - 1), 2) = " " & d - delt_h & " " & e & " " & f & " & " '8o
        Sheet6.Cells(CodeStartLine_no + 74 + 146 * (i - 1), 2) = " " & d - delt_h & " " & b & " " & f '8
        '下一个block
        G_i = G_i + 1
        Sheet6.Cells(CodeStartLine_no + 75 + 146 * (i - 1), 2) = ";5号三棱柱 Block " & G_i
        Sheet6.Cells(CodeStartLine_no + 76 + 146 * (i - 1), 2) = "poly group " & Sheet7.Cells(StartLine_no + i - 1, GroupName_no) & " mat " & Sheet7.Cells(StartLine_no + i - 1, Mat_no) & " con " & Sheet7.Cells(StartLine_no + i - 1, Con_no) & " &"
        '前面
        Sheet6.Cells(CodeStartLine_no + 77 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Front_no) & " &"
        Sheet6.Cells(CodeStartLine_no + 78 + 146 * (i - 1), 2) = " " & d & " " & b & " " & c & " & " '4                                 4
        Sheet6.Cells(CodeStartLine_no + 79 + 146 * (i - 1), 2) = " " & d - delt_h & " " & b & " " & c & " & " '6                                 6
        Sheet6.Cells(CodeStartLine_no + 80 + 146 * (i - 1), 2) = " " & d & " " & b & " " & c + delt_h & " & " '7
        '后面
        Sheet6.Cells(CodeStartLine_no + 81 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Back_no) & " &"
        Sheet6.Cells(CodeStartLine_no + 82 + 146 * (i - 1), 2) = " " & d & " " & e & " " & c & " & " '4o                                4；
        Sheet6.Cells(CodeStartLine_no + 83 + 146 * (i - 1), 2) = " " & d & " " & e & " " & c + delt_h & " & " '7o
        Sheet6.Cells(CodeStartLine_no + 84 + 146 * (i - 1), 2) = " " & d - delt_h & " " & e & " " & c & " & " '6o                                6；
        '左面
        Sheet6.Cells(CodeStartLine_no + 85 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Left_no) & " &"
        Sheet6.Cells(CodeStartLine_no + 86 + 146 * (i - 1), 2) = " " & d & " " & b & " " & c & " & " '4
        Sheet6.Cells(CodeStartLine_no + 87 + 146 * (i - 1), 2) = " " & d & " " & b & " " & c + delt_h & " & " '7
        Sheet6.Cells(CodeStartLine_no + 88 + 146 * (i - 1), 2) = " " & d & " " & e & " " & c + delt_h & " & " '7o
        Sheet6.Cells(CodeStartLine_no + 89 + 146 * (i - 1), 2) = " " & d & " " & e & " " & c & " & " '4o
        '下面
        Sheet6.Cells(CodeStartLine_no + 90 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Bottom_no) & " &"
        Sheet6.Cells(CodeStartLine_no + 91 + 146 * (i - 1), 2) = " " & d & " " & b & " " & c & " & " '4
        Sheet6.Cells(CodeStartLine_no + 92 + 146 * (i - 1), 2) = " " & d & " " & e & " " & c & " & " '4o
        Sheet6.Cells(CodeStartLine_no + 93 + 146 * (i - 1), 2) = " " & d - delt_h & " " & e & " " & c & " & " '6o
        Sheet6.Cells(CodeStartLine_no + 94 + 146 * (i - 1), 2) = " " & d - delt_h & " " & b & " " & c & " & " '6
        '侧面
        Sheet6.Cells(CodeStartLine_no + 95 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, 10) & " &"
        Sheet6.Cells(CodeStartLine_no + 96 + 146 * (i - 1), 2) = " " & d - delt_h & " " & b & " " & c & " & " '6
        Sheet6.Cells(CodeStartLine_no + 97 + 146 * (i - 1), 2) = " " & d - delt_h & " " & e & " " & c & " & " '6o
        Sheet6.Cells(CodeStartLine_no + 98 + 146 * (i - 1), 2) = " " & d & " " & e & " " & c + delt_h & " & " '7o
        Sheet6.Cells(CodeStartLine_no + 99 + 146 * (i - 1), 2) = " " & d & " " & b & " " & c + delt_h '7
        '下一个block
        G_i = G_i + 1
        Sheet6.Cells(CodeStartLine_no + 100 + 146 * (i - 1), 2) = ";3号六棱柱 or 四棱柱 Block " & G_i
        Sheet6.Cells(CodeStartLine_no + 101 + 146 * (i - 1), 2) = "poly group " & Sheet7.Cells(StartLine_no + i - 1, GroupName_no) & " mat " & Sheet7.Cells(StartLine_no + i - 1, Mat_no) & " con " & Sheet7.Cells(StartLine_no + i - 1, Con_no) & " &"
        '左上面
        Sheet6.Cells(CodeStartLine_no + 102 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, 10) & " &"
        Sheet6.Cells(CodeStartLine_no + 103 + 146 * (i - 1), 2) = " " & a + delt_h & " " & b & " " & f & " & " '9
        Sheet6.Cells(CodeStartLine_no + 104 + 146 * (i - 1), 2) = " " & a & " " & b & " " & c + delt_h & " & " '10
        Sheet6.Cells(CodeStartLine_no + 105 + 146 * (i - 1), 2) = " " & a & " " & e & " " & c + delt_h & " & " '10o
        Sheet6.Cells(CodeStartLine_no + 106 + 146 * (i - 1), 2) = " " & a + delt_h & " " & e & " " & f & " & " '9o
        '左下面
        Sheet6.Cells(CodeStartLine_no + 107 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, 10) & " &"
        Sheet6.Cells(CodeStartLine_no + 108 + 146 * (i - 1), 2) = " " & a + delt_h & " " & b & " " & c & " & " '5
        Sheet6.Cells(CodeStartLine_no + 109 + 146 * (i - 1), 2) = " " & a + delt_h & " " & e & " " & c & " & " '5o
        Sheet6.Cells(CodeStartLine_no + 110 + 146 * (i - 1), 2) = " " & a & " " & e & " " & c + delt_h & " & " '10o
        Sheet6.Cells(CodeStartLine_no + 111 + 146 * (i - 1), 2) = " " & a & " " & b & " " & c + delt_h & " & " '10
        '右上面
        Sheet6.Cells(CodeStartLine_no + 112 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, 10) & " &"
        Sheet6.Cells(CodeStartLine_no + 113 + 146 * (i - 1), 2) = " " & d & " " & b & " " & c + delt_h & " & " '7
        Sheet6.Cells(CodeStartLine_no + 114 + 146 * (i - 1), 2) = " " & d - delt_h & " " & b & " " & f & " & " '8
        Sheet6.Cells(CodeStartLine_no + 115 + 146 * (i - 1), 2) = " " & d - delt_h & " " & e & " " & f & " & " '8o
        Sheet6.Cells(CodeStartLine_no + 116 + 146 * (i - 1), 2) = " " & d & " " & e & " " & c + delt_h & " & " '7o
        '右下面
        Sheet6.Cells(CodeStartLine_no + 117 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, 10) & " &"
        Sheet6.Cells(CodeStartLine_no + 118 + 146 * (i - 1), 2) = " " & d - delt_h & " " & b & " " & c & " & " '6
        Sheet6.Cells(CodeStartLine_no + 119 + 146 * (i - 1), 2) = " " & d & " " & b & " " & c + delt_h & " & " '7
        Sheet6.Cells(CodeStartLine_no + 120 + 146 * (i - 1), 2) = " " & d & " " & e & " " & c + delt_h & " & " '7o
        Sheet6.Cells(CodeStartLine_no + 121 + 146 * (i - 1), 2) = " " & d - delt_h & " " & e & " " & c & " & " '6o
        If (d - a) <> (f - c) Then
            '前面
            Sheet6.Cells(CodeStartLine_no + 122 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Front_no) & " &"
            Sheet6.Cells(CodeStartLine_no + 123 + 146 * (i - 1), 2) = " " & a + delt_h & " " & b & " " & c & " & " '5
            Sheet6.Cells(CodeStartLine_no + 124 + 146 * (i - 1), 2) = " " & a & " " & b & " " & c + delt_h & " & " '10
            Sheet6.Cells(CodeStartLine_no + 125 + 146 * (i - 1), 2) = " " & a + delt_h & " " & b & " " & f & " & " '9
            Sheet6.Cells(CodeStartLine_no + 126 + 146 * (i - 1), 2) = " " & d - delt_h & " " & b & " " & f & " & " '8
            Sheet6.Cells(CodeStartLine_no + 127 + 146 * (i - 1), 2) = " " & d & " " & b & " " & c + delt_h & " & " '7
            Sheet6.Cells(CodeStartLine_no + 128 + 146 * (i - 1), 2) = " " & d - delt_h & " " & b & " " & c & " & " '6
            '后面
            Sheet6.Cells(CodeStartLine_no + 129 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Back_no) & " &"
            Sheet6.Cells(CodeStartLine_no + 130 + 146 * (i - 1), 2) = " " & a + delt_h & " " & e & " " & c & " & " '5o
            Sheet6.Cells(CodeStartLine_no + 131 + 146 * (i - 1), 2) = " " & d - delt_h & " " & e & " " & c & " & " '6o
            Sheet6.Cells(CodeStartLine_no + 132 + 146 * (i - 1), 2) = " " & d & " " & e & " " & c + delt_h & " & " '7o
            Sheet6.Cells(CodeStartLine_no + 133 + 146 * (i - 1), 2) = " " & d - delt_h & " " & e & " " & f & " & " '8o
            Sheet6.Cells(CodeStartLine_no + 134 + 146 * (i - 1), 2) = " " & a + delt_h & " " & e & " " & f & " & " '9o
            Sheet6.Cells(CodeStartLine_no + 135 + 146 * (i - 1), 2) = " " & a & " " & e & " " & c + delt_h & " & " '10o
            '上面
            Sheet6.Cells(CodeStartLine_no + 136 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Top_no) & " &"
            Sheet6.Cells(CodeStartLine_no + 137 + 146 * (i - 1), 2) = " " & d - delt_h & " " & b & " " & f & " & " '8
            Sheet6.Cells(CodeStartLine_no + 138 + 146 * (i - 1), 2) = " " & a + delt_h & " " & b & " " & f & " & " '9
            Sheet6.Cells(CodeStartLine_no + 139 + 146 * (i - 1), 2) = " " & a + delt_h & " " & e & " " & f & " & " '9o
            Sheet6.Cells(CodeStartLine_no + 140 + 146 * (i - 1), 2) = " " & d - delt_h & " " & e & " " & f & " & " '8o
            '下面
            Sheet6.Cells(CodeStartLine_no + 141 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Bottom_no) & " &"
            Sheet6.Cells(CodeStartLine_no + 142 + 146 * (i - 1), 2) = " " & a + delt_h & " " & b & " " & c & " & " '5
            Sheet6.Cells(CodeStartLine_no + 143 + 146 * (i - 1), 2) = " " & d - delt_h & " " & b & " " & c & " & " '6
            Sheet6.Cells(CodeStartLine_no + 144 + 146 * (i - 1), 2) = " " & d - delt_h & " " & e & " " & c & " & " '6o
            Sheet6.Cells(CodeStartLine_no + 145 + 146 * (i - 1), 2) = " " & a + delt_h & " " & e & " " & c '5o
        Else
            '前面
            Sheet6.Cells(CodeStartLine_no + 122 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Front_no) & " &"
            Sheet6.Cells(CodeStartLine_no + 123 + 146 * (i - 1), 2) = " " & a & " " & b & " " & c + delt_h & " & " '10
            Sheet6.Cells(CodeStartLine_no + 124 + 146 * (i - 1), 2) = " " & d - delt_h & " " & b & " " & f & " & " '8
            Sheet6.Cells(CodeStartLine_no + 125 + 146 * (i - 1), 2) = " " & d & " " & b & " " & c + delt_h & " & " '7
            Sheet6.Cells(CodeStartLine_no + 126 + 146 * (i - 1), 2) = " " & d - delt_h & " " & b & " " & c & " & " '6
            '后面
            Sheet6.Cells(CodeStartLine_no + 127 + 146 * (i - 1), 2) = "face id " & Sheet7.Cells(StartLine_no + i - 1, FaceID_Back_no) & " &"
            Sheet6.Cells(CodeStartLine_no + 128 + 146 * (i - 1), 2) = " " & d - delt_h & " " & e & " " & c & " & " '6o
            Sheet6.Cells(CodeStartLine_no + 129 + 146 * (i - 1), 2) = " " & d - delt_h & " " & e & " " & f & " & " '8o
            Sheet6.Cells(CodeStartLine_no + 130 + 146 * (i - 1), 2) = " " & d & " " & e & " " & c + delt_h & " & " '7o
            Sheet6.Cells(CodeStartLine_no + 131 + 146 * (i - 1), 2) = " " & a & " " & e & " " & c + delt_h '10o
        End If
        '计数
        G_i = G_i + 1
    End Sub

End Module
