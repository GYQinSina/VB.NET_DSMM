Imports Microsoft.Office.Interop
Module PublicVriables
    'integer
    Public end_no, GroupName_no, Mat_no, Con_no, N_no As Integer
    Public FaceID_Front_no, FaceID_Back_no, FaceID_Left_no, FaceID_Right_no As Integer
    Public FaceID_Top_no, FaceID_Bottom_no, StartLine_no As Integer
    Public CodeStartLine_no, G_i, Data_no As Integer
    Public Mining_L, Disco_L, Spec_ID As Integer
    Public start_no, ii As Integer
    Public ZCS, D1C, h_no, r_no, E_no, GJC_no, R1_no As Integer

    'double
    Public delt_h As Double
    Public R1, R2 As Double
    'excel workbook worksheet
    Public objExcel As New Excel.Application
    Public objWorkbook As Excel.Workbook
    Public Sheet1, Sheet2, Sheet3, Sheet4, Sheet5, Sheet6, Sheet7, Sheet8, Sheet9, Sheet10 As Excel.Worksheet
    'String
    Public TemplatePath As String
    '------------------------------初始化---------------------------------------
    Public Sub IniPubVars()

        Data_no = 38 '原始数据总行数
        end_no = 727 '生成的Blocks总计数目

        '-----------------------------系统参数---------------------------------------
        GroupName_no = 8
        Mat_no = 9
        Con_no = 10
        N_no = 11 '每一层划分块段数目
        FaceID_Front_no = 12
        FaceID_Back_no = 13
        FaceID_Left_no = 14
        FaceID_Right_no = 15
        FaceID_Top_no = 16
        FaceID_Bottom_no = 17
        StartLine_no = 3 '数据开始行号
        CodeStartLine_no = 3 '代码 Block 1 开始行号
        G_i = 1
        '------------------------------关键层初始化--------------------------------------
        R1 = R2 = 1
    End Sub

End Module
