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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.关键层判断 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripProgressBar2 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripProgressBar3 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New Data_intensive_Grid.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件FToolStripMenuItem, Me.输出结果ToolStripMenuItem, Me.选项ToolStripMenuItem, Me.帮助ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(680, 25)
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
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripButton1, Me.ToolStripProgressBar1, Me.ToolStripSeparator2, Me.关键层判断, Me.ToolStripButton2, Me.ToolStripProgressBar2, Me.ToolStripSeparator3, Me.ToolStripLabel1, Me.ToolStripButton3, Me.ToolStripProgressBar3, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(692, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripLabel2.Text = "关键层判断"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(107, 22)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        '关键层判断
        '
        Me.关键层判断.Name = "关键层判断"
        Me.关键层判断.Size = New System.Drawing.Size(87, 22)
        Me.关键层判断.Text = "生成3DEC网格"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripProgressBar2
        '
        Me.ToolStripProgressBar2.Name = "ToolStripProgressBar2"
        Me.ToolStripProgressBar2.Size = New System.Drawing.Size(107, 22)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripLabel1.Text = "生成3DEC控制命令"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripProgressBar3
        '
        Me.ToolStripProgressBar3.Name = "ToolStripProgressBar3"
        Me.ToolStripProgressBar3.Size = New System.Drawing.Size(107, 22)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 579)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(680, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(44, 17)
        Me.ToolStripStatusLabel1.Text = "Ready"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.DataSet1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 147)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(656, 185)
        Me.DataGridView1.TabIndex = 3
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 601)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "DSMM：覆岩移动变形数据密集型结构生成器"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents 关键层判断 As ToolStripLabel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripProgressBar2 As ToolStripProgressBar
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripProgressBar3 As ToolStripProgressBar
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
End Class
