<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.文件FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.导入EXCEL数据文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.设置文件输出位置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.输出结果ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.输出3DEC网格文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.输出3DEC控制命令ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.输出关键层判断结果ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.选项ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查看帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.技术支持ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.注册产品ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.检查更新ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于我们ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件FToolStripMenuItem, Me.输出结果ToolStripMenuItem, Me.选项ToolStripMenuItem, Me.帮助ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1194, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '文件FToolStripMenuItem
        '
        Me.文件FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.导入EXCEL数据文件ToolStripMenuItem, Me.ToolStripMenuItem1, Me.设置文件输出位置ToolStripMenuItem, Me.ToolStripSeparator1, Me.退出XToolStripMenuItem})
        Me.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem"
        Me.文件FToolStripMenuItem.Size = New System.Drawing.Size(74, 21)
        Me.文件FToolStripMenuItem.Text = "文件（F）"
        '
        '导入EXCEL数据文件ToolStripMenuItem
        '
        Me.导入EXCEL数据文件ToolStripMenuItem.Name = "导入EXCEL数据文件ToolStripMenuItem"
        Me.导入EXCEL数据文件ToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.导入EXCEL数据文件ToolStripMenuItem.Text = "新建EXCEL数据文件（N）"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(218, 22)
        Me.ToolStripMenuItem1.Text = "导入EXCEL数据文件（D）"
        '
        '设置文件输出位置ToolStripMenuItem
        '
        Me.设置文件输出位置ToolStripMenuItem.Name = "设置文件输出位置ToolStripMenuItem"
        Me.设置文件输出位置ToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.设置文件输出位置ToolStripMenuItem.Text = "设置文件输出位置（S）"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(215, 6)
        '
        '退出XToolStripMenuItem
        '
        Me.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem"
        Me.退出XToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.退出XToolStripMenuItem.Text = "退出（X）"
        '
        '输出结果ToolStripMenuItem
        '
        Me.输出结果ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.输出3DEC网格文件ToolStripMenuItem, Me.输出3DEC控制命令ToolStripMenuItem, Me.输出关键层判断结果ToolStripMenuItem})
        Me.输出结果ToolStripMenuItem.Name = "输出结果ToolStripMenuItem"
        Me.输出结果ToolStripMenuItem.Size = New System.Drawing.Size(75, 21)
        Me.输出结果ToolStripMenuItem.Text = "输出（E）"
        '
        '输出3DEC网格文件ToolStripMenuItem
        '
        Me.输出3DEC网格文件ToolStripMenuItem.Name = "输出3DEC网格文件ToolStripMenuItem"
        Me.输出3DEC网格文件ToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.输出3DEC网格文件ToolStripMenuItem.Text = "输出3DEC网格文件（GRID）"
        '
        '输出3DEC控制命令ToolStripMenuItem
        '
        Me.输出3DEC控制命令ToolStripMenuItem.Name = "输出3DEC控制命令ToolStripMenuItem"
        Me.输出3DEC控制命令ToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.输出3DEC控制命令ToolStripMenuItem.Text = "输出3DEC控制命令（COM）"
        '
        '输出关键层判断结果ToolStripMenuItem
        '
        Me.输出关键层判断结果ToolStripMenuItem.Name = "输出关键层判断结果ToolStripMenuItem"
        Me.输出关键层判断结果ToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.输出关键层判断结果ToolStripMenuItem.Text = "输出关键层判断结果（GJC）"
        '
        '选项ToolStripMenuItem
        '
        Me.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem"
        Me.选项ToolStripMenuItem.Size = New System.Drawing.Size(78, 21)
        Me.选项ToolStripMenuItem.Text = "选项（O）"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.查看帮助ToolStripMenuItem, Me.技术支持ToolStripMenuItem, Me.注册产品ToolStripMenuItem, Me.检查更新ToolStripMenuItem, Me.关于我们ToolStripMenuItem})
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(77, 21)
        Me.帮助ToolStripMenuItem.Text = "帮助（H）"
        '
        '查看帮助ToolStripMenuItem
        '
        Me.查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem"
        Me.查看帮助ToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.查看帮助ToolStripMenuItem.Text = "查看帮助（V）"
        '
        '技术支持ToolStripMenuItem
        '
        Me.技术支持ToolStripMenuItem.Name = "技术支持ToolStripMenuItem"
        Me.技术支持ToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.技术支持ToolStripMenuItem.Text = "技术支持（S）"
        '
        '注册产品ToolStripMenuItem
        '
        Me.注册产品ToolStripMenuItem.Name = "注册产品ToolStripMenuItem"
        Me.注册产品ToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.注册产品ToolStripMenuItem.Text = "注册产品（R）"
        '
        '检查更新ToolStripMenuItem
        '
        Me.检查更新ToolStripMenuItem.Name = "检查更新ToolStripMenuItem"
        Me.检查更新ToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.检查更新ToolStripMenuItem.Text = "检查更新（C）"
        '
        '关于我们ToolStripMenuItem
        '
        Me.关于我们ToolStripMenuItem.Name = "关于我们ToolStripMenuItem"
        Me.关于我们ToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.关于我们ToolStripMenuItem.Text = "关于我们（A）"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1194, 629)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "DSMM：覆岩移动变形数据密集型结构生成器"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 文件FToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 输出结果ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 选项ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 导入EXCEL数据文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 设置文件输出位置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 输出3DEC网格文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 输出3DEC控制命令ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 输出关键层判断结果ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 查看帮助ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 技术支持ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 注册产品ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 检查更新ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于我们ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 退出XToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
