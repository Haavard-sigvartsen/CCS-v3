<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    Private Const V As String = "MainMenu"

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.tbxWeightSelector = New System.Windows.Forms.TextBox()
        Me.btnSubmitCalc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxNameSelector = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxBrandSelector = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnToolStrip1 = New System.Windows.Forms.ToolStripButton()
        Me.TbxCalSelector = New System.Windows.Forms.TextBox()
        Me.TbxProSelector = New System.Windows.Forms.TextBox()
        Me.TbxCarbSelector = New System.Windows.Forms.TextBox()
        Me.TbxFatSelector = New System.Windows.Forms.TextBox()
        Me.TbxSugSelector = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnButter1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblSumFat = New System.Windows.Forms.Label()
        Me.LblSumSug = New System.Windows.Forms.Label()
        Me.LblSumCarb = New System.Windows.Forms.Label()
        Me.LblSumProt = New System.Windows.Forms.Label()
        Me.LblSumCal = New System.Windows.Forms.Label()
        Me.StatisticBox = New System.Windows.Forms.GroupBox()
        Me.AvarageBox = New System.Windows.Forms.GroupBox()
        Me.dtpStatistic = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCurrentCalcFat = New System.Windows.Forms.Label()
        Me.lblCurrentCalcSug = New System.Windows.Forms.Label()
        Me.lblCurrentCalcCarbs = New System.Windows.Forms.Label()
        Me.lblCurrentCalcProt = New System.Windows.Forms.Label()
        Me.lblCurrentCalcCal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnClearTbx = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CCS_V3DataSet = New CCS_v3.CCS_V3DataSet()
        Me.FoodHistorytableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Food_History_tableTableAdapter = New CCS_v3.CCS_V3DataSetTableAdapters.Food_History_tableTableAdapter()
        Me.FoodHistorytableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DgvTemp = New System.Windows.Forms.DataGridView()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatisticBox.SuspendLayout()
        Me.AvarageBox.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.CCS_V3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodHistorytableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodHistorytableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbxWeightSelector
        '
        Me.tbxWeightSelector.Location = New System.Drawing.Point(11, 70)
        Me.tbxWeightSelector.Name = "tbxWeightSelector"
        Me.tbxWeightSelector.Size = New System.Drawing.Size(100, 20)
        Me.tbxWeightSelector.TabIndex = 9
        Me.tbxWeightSelector.Text = "0"
        '
        'btnSubmitCalc
        '
        Me.btnSubmitCalc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSubmitCalc.Location = New System.Drawing.Point(11, 113)
        Me.btnSubmitCalc.Name = "btnSubmitCalc"
        Me.btnSubmitCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmitCalc.TabIndex = 10
        Me.btnSubmitCalc.Text = "Submit"
        Me.btnSubmitCalc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(8, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'tbxNameSelector
        '
        Me.tbxNameSelector.Location = New System.Drawing.Point(11, 44)
        Me.tbxNameSelector.Name = "tbxNameSelector"
        Me.tbxNameSelector.Size = New System.Drawing.Size(161, 20)
        Me.tbxNameSelector.TabIndex = 1
        Me.tbxNameSelector.Text = "N/A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(11, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Weight"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(175, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Brand"
        '
        'tbxBrandSelector
        '
        Me.tbxBrandSelector.Location = New System.Drawing.Point(178, 44)
        Me.tbxBrandSelector.Name = "tbxBrandSelector"
        Me.tbxBrandSelector.Size = New System.Drawing.Size(115, 20)
        Me.tbxBrandSelector.TabIndex = 2
        Me.tbxBrandSelector.Text = "N/A"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(299, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Calories"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(383, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Proteins"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(461, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Carbs"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Location = New System.Drawing.Point(542, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Sugar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Location = New System.Drawing.Point(623, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Fat"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnToolStrip1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1227, 25)
        Me.ToolStrip1.TabIndex = 17
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnToolStrip1
        '
        Me.btnToolStrip1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStrip1.Image = CType(resources.GetObject("btnToolStrip1.Image"), System.Drawing.Image)
        Me.btnToolStrip1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStrip1.Name = "btnToolStrip1"
        Me.btnToolStrip1.Size = New System.Drawing.Size(23, 22)
        Me.btnToolStrip1.Text = "ToolStripButton1"
        '
        'TbxCalSelector
        '
        Me.TbxCalSelector.Location = New System.Drawing.Point(302, 44)
        Me.TbxCalSelector.Name = "TbxCalSelector"
        Me.TbxCalSelector.Size = New System.Drawing.Size(75, 20)
        Me.TbxCalSelector.TabIndex = 3
        Me.TbxCalSelector.Text = "0"
        '
        'TbxProSelector
        '
        Me.TbxProSelector.Location = New System.Drawing.Point(383, 44)
        Me.TbxProSelector.Name = "TbxProSelector"
        Me.TbxProSelector.Size = New System.Drawing.Size(75, 20)
        Me.TbxProSelector.TabIndex = 5
        Me.TbxProSelector.Text = "0"
        '
        'TbxCarbSelector
        '
        Me.TbxCarbSelector.Location = New System.Drawing.Point(464, 44)
        Me.TbxCarbSelector.Name = "TbxCarbSelector"
        Me.TbxCarbSelector.Size = New System.Drawing.Size(75, 20)
        Me.TbxCarbSelector.TabIndex = 6
        Me.TbxCarbSelector.Text = "0"
        '
        'TbxFatSelector
        '
        Me.TbxFatSelector.Location = New System.Drawing.Point(626, 44)
        Me.TbxFatSelector.Name = "TbxFatSelector"
        Me.TbxFatSelector.Size = New System.Drawing.Size(75, 20)
        Me.TbxFatSelector.TabIndex = 8
        Me.TbxFatSelector.Text = "0"
        '
        'TbxSugSelector
        '
        Me.TbxSugSelector.Location = New System.Drawing.Point(545, 44)
        Me.TbxSugSelector.Name = "TbxSugSelector"
        Me.TbxSugSelector.Size = New System.Drawing.Size(75, 20)
        Me.TbxSugSelector.TabIndex = 7
        Me.TbxSugSelector.Text = "0"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AButtonToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(151, 26)
        '
        'AButtonToolStripMenuItem
        '
        Me.AButtonToolStripMenuItem.Name = "AButtonToolStripMenuItem"
        Me.AButtonToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AButtonToolStripMenuItem.Text = "Edit Properties"
        '
        'btnButter1
        '
        Me.btnButter1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.btnButter1.Location = New System.Drawing.Point(11, 162)
        Me.btnButter1.Name = "btnButter1"
        Me.btnButter1.Size = New System.Drawing.Size(75, 23)
        Me.btnButter1.TabIndex = 10
        Me.btnButter1.Text = "Add Butter"
        Me.btnButter1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Location = New System.Drawing.Point(14, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Fixed portion buttons"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(6, 469)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Current total of today"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblSumFat)
        Me.Panel1.Controls.Add(Me.LblSumSug)
        Me.Panel1.Controls.Add(Me.LblSumCarb)
        Me.Panel1.Controls.Add(Me.LblSumProt)
        Me.Panel1.Controls.Add(Me.LblSumCal)
        Me.Panel1.Location = New System.Drawing.Point(0, 459)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(701, 38)
        Me.Panel1.TabIndex = 29
        '
        'LblSumFat
        '
        Me.LblSumFat.AutoSize = True
        Me.LblSumFat.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblSumFat.Location = New System.Drawing.Point(623, 10)
        Me.LblSumFat.Name = "LblSumFat"
        Me.LblSumFat.Size = New System.Drawing.Size(27, 13)
        Me.LblSumFat.TabIndex = 4
        Me.LblSumFat.Text = "N/A"
        '
        'LblSumSug
        '
        Me.LblSumSug.AutoSize = True
        Me.LblSumSug.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblSumSug.Location = New System.Drawing.Point(542, 10)
        Me.LblSumSug.Name = "LblSumSug"
        Me.LblSumSug.Size = New System.Drawing.Size(27, 13)
        Me.LblSumSug.TabIndex = 3
        Me.LblSumSug.Text = "N/A"
        '
        'LblSumCarb
        '
        Me.LblSumCarb.AutoSize = True
        Me.LblSumCarb.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblSumCarb.Location = New System.Drawing.Point(461, 10)
        Me.LblSumCarb.Name = "LblSumCarb"
        Me.LblSumCarb.Size = New System.Drawing.Size(27, 13)
        Me.LblSumCarb.TabIndex = 2
        Me.LblSumCarb.Text = "N/A"
        '
        'LblSumProt
        '
        Me.LblSumProt.AutoSize = True
        Me.LblSumProt.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblSumProt.Location = New System.Drawing.Point(380, 10)
        Me.LblSumProt.Name = "LblSumProt"
        Me.LblSumProt.Size = New System.Drawing.Size(27, 13)
        Me.LblSumProt.TabIndex = 1
        Me.LblSumProt.Text = "N/A"
        '
        'LblSumCal
        '
        Me.LblSumCal.AutoSize = True
        Me.LblSumCal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblSumCal.Location = New System.Drawing.Point(299, 10)
        Me.LblSumCal.Name = "LblSumCal"
        Me.LblSumCal.Size = New System.Drawing.Size(27, 13)
        Me.LblSumCal.TabIndex = 0
        Me.LblSumCal.Text = "N/A"
        '
        'StatisticBox
        '
        Me.StatisticBox.Controls.Add(Me.AvarageBox)
        Me.StatisticBox.Location = New System.Drawing.Point(707, 12)
        Me.StatisticBox.Name = "StatisticBox"
        Me.StatisticBox.Size = New System.Drawing.Size(331, 485)
        Me.StatisticBox.TabIndex = 31
        Me.StatisticBox.TabStop = False
        Me.StatisticBox.Text = "Statistic"
        '
        'AvarageBox
        '
        Me.AvarageBox.Controls.Add(Me.dtpStatistic)
        Me.AvarageBox.Location = New System.Drawing.Point(15, 16)
        Me.AvarageBox.Name = "AvarageBox"
        Me.AvarageBox.Size = New System.Drawing.Size(310, 141)
        Me.AvarageBox.TabIndex = 0
        Me.AvarageBox.TabStop = False
        Me.AvarageBox.Text = "1 Week avarage"
        '
        'dtpStatistic
        '
        Me.dtpStatistic.CustomFormat = "yyyy-MM-dd"
        Me.dtpStatistic.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStatistic.Location = New System.Drawing.Point(6, 19)
        Me.dtpStatistic.Name = "dtpStatistic"
        Me.dtpStatistic.Size = New System.Drawing.Size(81, 20)
        Me.dtpStatistic.TabIndex = 1
        Me.dtpStatistic.Value = New Date(2022, 3, 29, 20, 31, 18, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(-3, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Current Calculation"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.lblCurrentCalcFat)
        Me.Panel2.Controls.Add(Me.lblCurrentCalcSug)
        Me.Panel2.Controls.Add(Me.lblCurrentCalcCarbs)
        Me.Panel2.Controls.Add(Me.lblCurrentCalcProt)
        Me.Panel2.Controls.Add(Me.lblCurrentCalcCal)
        Me.Panel2.Location = New System.Drawing.Point(178, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(523, 28)
        Me.Panel2.TabIndex = 33
        '
        'lblCurrentCalcFat
        '
        Me.lblCurrentCalcFat.AutoSize = True
        Me.lblCurrentCalcFat.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCurrentCalcFat.Location = New System.Drawing.Point(445, 8)
        Me.lblCurrentCalcFat.Name = "lblCurrentCalcFat"
        Me.lblCurrentCalcFat.Size = New System.Drawing.Size(27, 13)
        Me.lblCurrentCalcFat.TabIndex = 4
        Me.lblCurrentCalcFat.Text = "N/A"
        '
        'lblCurrentCalcSug
        '
        Me.lblCurrentCalcSug.AutoSize = True
        Me.lblCurrentCalcSug.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCurrentCalcSug.Location = New System.Drawing.Point(364, 8)
        Me.lblCurrentCalcSug.Name = "lblCurrentCalcSug"
        Me.lblCurrentCalcSug.Size = New System.Drawing.Size(27, 13)
        Me.lblCurrentCalcSug.TabIndex = 3
        Me.lblCurrentCalcSug.Text = "N/A"
        '
        'lblCurrentCalcCarbs
        '
        Me.lblCurrentCalcCarbs.AutoSize = True
        Me.lblCurrentCalcCarbs.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCurrentCalcCarbs.Location = New System.Drawing.Point(283, 8)
        Me.lblCurrentCalcCarbs.Name = "lblCurrentCalcCarbs"
        Me.lblCurrentCalcCarbs.Size = New System.Drawing.Size(27, 13)
        Me.lblCurrentCalcCarbs.TabIndex = 2
        Me.lblCurrentCalcCarbs.Text = "N/A"
        '
        'lblCurrentCalcProt
        '
        Me.lblCurrentCalcProt.AutoSize = True
        Me.lblCurrentCalcProt.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCurrentCalcProt.Location = New System.Drawing.Point(202, 8)
        Me.lblCurrentCalcProt.Name = "lblCurrentCalcProt"
        Me.lblCurrentCalcProt.Size = New System.Drawing.Size(27, 13)
        Me.lblCurrentCalcProt.TabIndex = 1
        Me.lblCurrentCalcProt.Text = "N/A"
        '
        'lblCurrentCalcCal
        '
        Me.lblCurrentCalcCal.AutoSize = True
        Me.lblCurrentCalcCal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCurrentCalcCal.Location = New System.Drawing.Point(121, 8)
        Me.lblCurrentCalcCal.Name = "lblCurrentCalcCal"
        Me.lblCurrentCalcCal.Size = New System.Drawing.Size(27, 13)
        Me.lblCurrentCalcCal.TabIndex = 0
        Me.lblCurrentCalcCal.Text = "N/A"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label12.Location = New System.Drawing.Point(51, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 13)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Double click to view list"
        '
        'BtnClearTbx
        '
        Me.BtnClearTbx.Location = New System.Drawing.Point(626, 113)
        Me.BtnClearTbx.Name = "BtnClearTbx"
        Me.BtnClearTbx.Size = New System.Drawing.Size(75, 23)
        Me.BtnClearTbx.TabIndex = 45
        Me.BtnClearTbx.Text = "Clear"
        Me.BtnClearTbx.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(210, 167)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(267, 13)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "TODO: List will show based on Date showed in statistic"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(92, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CCS_V3DataSet
        '
        Me.CCS_V3DataSet.CaseSensitive = True
        Me.CCS_V3DataSet.DataSetName = "CCS_V3DataSet"
        Me.CCS_V3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FoodHistorytableBindingSource
        '
        Me.FoodHistorytableBindingSource.DataMember = "Food_History_table"
        Me.FoodHistorytableBindingSource.DataSource = Me.CCS_V3DataSet
        '
        'Food_History_tableTableAdapter
        '
        Me.Food_History_tableTableAdapter.ClearBeforeFill = True
        '
        'FoodHistorytableBindingSource1
        '
        Me.FoodHistorytableBindingSource1.DataMember = "Food_History_table"
        Me.FoodHistorytableBindingSource1.DataSource = Me.CCS_V3DataSet
        '
        'DgvTemp
        '
        Me.DgvTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTemp.Location = New System.Drawing.Point(0, 191)
        Me.DgvTemp.Name = "DgvTemp"
        Me.DgvTemp.Size = New System.Drawing.Size(701, 262)
        Me.DgvTemp.TabIndex = 48
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(175, 113)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(37, 13)
        Me.LblStatus.TabIndex = 49
        Me.LblStatus.Text = "Status"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1227, 791)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.DgvTemp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BtnClearTbx)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatisticBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnButter1)
        Me.Controls.Add(Me.TbxSugSelector)
        Me.Controls.Add(Me.TbxFatSelector)
        Me.Controls.Add(Me.TbxCarbSelector)
        Me.Controls.Add(Me.TbxProSelector)
        Me.Controls.Add(Me.TbxCalSelector)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbxBrandSelector)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxNameSelector)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSubmitCalc)
        Me.Controls.Add(Me.tbxWeightSelector)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatisticBox.ResumeLayout(False)
        Me.AvarageBox.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.CCS_V3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodHistorytableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodHistorytableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvTemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxWeightSelector As TextBox
    Friend WithEvents btnSubmitCalc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxNameSelector As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxBrandSelector As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnToolStrip1 As ToolStripButton
    Friend WithEvents TbxCalSelector As TextBox
    Friend WithEvents TbxProSelector As TextBox
    Friend WithEvents TbxCarbSelector As TextBox
    Friend WithEvents TbxFatSelector As TextBox
    Friend WithEvents TbxSugSelector As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AButtonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnButter1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblSumFat As Label
    Friend WithEvents LblSumSug As Label
    Friend WithEvents LblSumCarb As Label
    Friend WithEvents LblSumProt As Label
    Friend WithEvents LblSumCal As Label
    Friend WithEvents StatisticBox As GroupBox
    Friend WithEvents AvarageBox As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblCurrentCalcFat As Label
    Friend WithEvents lblCurrentCalcSug As Label
    Friend WithEvents lblCurrentCalcCarbs As Label
    Friend WithEvents lblCurrentCalcProt As Label
    Friend WithEvents lblCurrentCalcCal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnClearTbx As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpStatistic As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents FoodHistorytableBindingSource As BindingSource
    Friend WithEvents FoodHistorytableBindingSource1 As BindingSource
    Friend WithEvents DgvTemp As DataGridView
    Friend WithEvents LblStatus As Label
    Friend WithEvents CCS_V3DataSet As CCS_V3DataSet
    Friend WithEvents Food_History_tableTableAdapter As CCS_V3DataSetTableAdapters.Food_History_tableTableAdapter
End Class
