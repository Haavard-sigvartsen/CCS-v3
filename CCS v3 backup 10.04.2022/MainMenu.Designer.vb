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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxBrandSelector = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbxCalSelector = New System.Windows.Forms.TextBox()
        Me.TbxProSelector = New System.Windows.Forms.TextBox()
        Me.TbxCarbSelector = New System.Windows.Forms.TextBox()
        Me.TbxFatSelector = New System.Windows.Forms.TextBox()
        Me.TbxSugSelector = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LblSumFat = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LblSumSug = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LblSumCarb = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
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
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.CCS_V3DataSet = New CCS_v3.CCS_V3DataSet()
        Me.FoodHistorytableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Food_History_tableTableAdapter = New CCS_v3.CCS_V3DataSetTableAdapters.Food_History_tableTableAdapter()
        Me.FoodHistorytableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvTempList = New System.Windows.Forms.DataGridView()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButterButtonSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShortcutsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbxNameSelector = New System.Windows.Forms.ComboBox()
        Me.ButtonFill = New System.Windows.Forms.Button()
        Me.btnButter1 = New System.Windows.Forms.Button()
        Me.btnButter2 = New System.Windows.Forms.Button()
        Me.btnButter3 = New System.Windows.Forms.Button()
        Me.btnButter4 = New System.Windows.Forms.Button()
        Me.btnButter5 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.StatisticBox.SuspendLayout()
        Me.AvarageBox.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.CCS_V3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodHistorytableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodHistorytableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTempList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbxWeightSelector
        '
        Me.tbxWeightSelector.Location = New System.Drawing.Point(15, 86)
        Me.tbxWeightSelector.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxWeightSelector.Name = "tbxWeightSelector"
        Me.tbxWeightSelector.Size = New System.Drawing.Size(132, 22)
        Me.tbxWeightSelector.TabIndex = 9
        Me.tbxWeightSelector.Text = "0"
        '
        'btnSubmitCalc
        '
        Me.btnSubmitCalc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSubmitCalc.Location = New System.Drawing.Point(15, 139)
        Me.btnSubmitCalc.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmitCalc.Name = "btnSubmitCalc"
        Me.btnSubmitCalc.Size = New System.Drawing.Size(100, 28)
        Me.btnSubmitCalc.TabIndex = 10
        Me.btnSubmitCalc.Text = "Submit"
        Me.btnSubmitCalc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(11, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(15, 119)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Weight"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(233, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Brand"
        '
        'tbxBrandSelector
        '
        Me.tbxBrandSelector.Location = New System.Drawing.Point(237, 54)
        Me.tbxBrandSelector.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxBrandSelector.Name = "tbxBrandSelector"
        Me.tbxBrandSelector.Size = New System.Drawing.Size(152, 22)
        Me.tbxBrandSelector.TabIndex = 3
        Me.tbxBrandSelector.Text = "N/A"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(399, 34)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Calories"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(511, 34)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Proteins"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(615, 34)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Carbs"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Location = New System.Drawing.Point(723, 34)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Sugar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Location = New System.Drawing.Point(831, 34)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Fat"
        '
        'TbxCalSelector
        '
        Me.TbxCalSelector.Location = New System.Drawing.Point(403, 54)
        Me.TbxCalSelector.Margin = New System.Windows.Forms.Padding(4)
        Me.TbxCalSelector.Name = "TbxCalSelector"
        Me.TbxCalSelector.Size = New System.Drawing.Size(99, 22)
        Me.TbxCalSelector.TabIndex = 4
        Me.TbxCalSelector.Text = "0"
        '
        'TbxProSelector
        '
        Me.TbxProSelector.Location = New System.Drawing.Point(511, 54)
        Me.TbxProSelector.Margin = New System.Windows.Forms.Padding(4)
        Me.TbxProSelector.Name = "TbxProSelector"
        Me.TbxProSelector.Size = New System.Drawing.Size(99, 22)
        Me.TbxProSelector.TabIndex = 5
        Me.TbxProSelector.Text = "0"
        '
        'TbxCarbSelector
        '
        Me.TbxCarbSelector.Location = New System.Drawing.Point(619, 54)
        Me.TbxCarbSelector.Margin = New System.Windows.Forms.Padding(4)
        Me.TbxCarbSelector.Name = "TbxCarbSelector"
        Me.TbxCarbSelector.Size = New System.Drawing.Size(99, 22)
        Me.TbxCarbSelector.TabIndex = 6
        Me.TbxCarbSelector.Text = "0"
        '
        'TbxFatSelector
        '
        Me.TbxFatSelector.Location = New System.Drawing.Point(835, 54)
        Me.TbxFatSelector.Margin = New System.Windows.Forms.Padding(4)
        Me.TbxFatSelector.Name = "TbxFatSelector"
        Me.TbxFatSelector.Size = New System.Drawing.Size(99, 22)
        Me.TbxFatSelector.TabIndex = 8
        Me.TbxFatSelector.Text = "0"
        '
        'TbxSugSelector
        '
        Me.TbxSugSelector.Location = New System.Drawing.Point(727, 54)
        Me.TbxSugSelector.Margin = New System.Windows.Forms.Padding(4)
        Me.TbxSugSelector.Name = "TbxSugSelector"
        Me.TbxSugSelector.Size = New System.Drawing.Size(99, 22)
        Me.TbxSugSelector.TabIndex = 7
        Me.TbxSugSelector.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Location = New System.Drawing.Point(19, 176)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 16)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Presets"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(8, 577)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 16)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Current total of the Day"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.LblSumFat)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.LblSumSug)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.LblSumCarb)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.LblSumProt)
        Me.Panel1.Controls.Add(Me.LblSumCal)
        Me.Panel1.Location = New System.Drawing.Point(0, 565)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(935, 60)
        Me.Panel1.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.Location = New System.Drawing.Point(707, 31)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 16)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Fat"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label15.Location = New System.Drawing.Point(599, 31)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 16)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Sugar"
        '
        'LblSumFat
        '
        Me.LblSumFat.AutoSize = True
        Me.LblSumFat.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblSumFat.Location = New System.Drawing.Point(707, 15)
        Me.LblSumFat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSumFat.Name = "LblSumFat"
        Me.LblSumFat.Size = New System.Drawing.Size(30, 16)
        Me.LblSumFat.TabIndex = 4
        Me.LblSumFat.Text = "N/A"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label16.Location = New System.Drawing.Point(491, 31)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 16)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Carbs"
        '
        'LblSumSug
        '
        Me.LblSumSug.AutoSize = True
        Me.LblSumSug.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblSumSug.Location = New System.Drawing.Point(599, 15)
        Me.LblSumSug.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSumSug.Name = "LblSumSug"
        Me.LblSumSug.Size = New System.Drawing.Size(30, 16)
        Me.LblSumSug.TabIndex = 3
        Me.LblSumSug.Text = "N/A"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label17.Location = New System.Drawing.Point(383, 31)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 16)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Proteins"
        '
        'LblSumCarb
        '
        Me.LblSumCarb.AutoSize = True
        Me.LblSumCarb.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblSumCarb.Location = New System.Drawing.Point(491, 15)
        Me.LblSumCarb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSumCarb.Name = "LblSumCarb"
        Me.LblSumCarb.Size = New System.Drawing.Size(30, 16)
        Me.LblSumCarb.TabIndex = 2
        Me.LblSumCarb.Text = "N/A"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label18.Location = New System.Drawing.Point(275, 31)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 16)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "Calories"
        '
        'LblSumProt
        '
        Me.LblSumProt.AutoSize = True
        Me.LblSumProt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblSumProt.Location = New System.Drawing.Point(383, 15)
        Me.LblSumProt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSumProt.Name = "LblSumProt"
        Me.LblSumProt.Size = New System.Drawing.Size(30, 16)
        Me.LblSumProt.TabIndex = 1
        Me.LblSumProt.Text = "N/A"
        '
        'LblSumCal
        '
        Me.LblSumCal.AutoSize = True
        Me.LblSumCal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblSumCal.Location = New System.Drawing.Point(275, 15)
        Me.LblSumCal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSumCal.Name = "LblSumCal"
        Me.LblSumCal.Size = New System.Drawing.Size(30, 16)
        Me.LblSumCal.TabIndex = 0
        Me.LblSumCal.Text = "N/A"
        '
        'StatisticBox
        '
        Me.StatisticBox.Controls.Add(Me.AvarageBox)
        Me.StatisticBox.Location = New System.Drawing.Point(1182, 15)
        Me.StatisticBox.Margin = New System.Windows.Forms.Padding(4)
        Me.StatisticBox.Name = "StatisticBox"
        Me.StatisticBox.Padding = New System.Windows.Forms.Padding(4)
        Me.StatisticBox.Size = New System.Drawing.Size(441, 610)
        Me.StatisticBox.TabIndex = 31
        Me.StatisticBox.TabStop = False
        Me.StatisticBox.Text = "Statistic"
        '
        'AvarageBox
        '
        Me.AvarageBox.Controls.Add(Me.dtpStatistic)
        Me.AvarageBox.Location = New System.Drawing.Point(20, 20)
        Me.AvarageBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AvarageBox.Name = "AvarageBox"
        Me.AvarageBox.Padding = New System.Windows.Forms.Padding(4)
        Me.AvarageBox.Size = New System.Drawing.Size(413, 174)
        Me.AvarageBox.TabIndex = 0
        Me.AvarageBox.TabStop = False
        Me.AvarageBox.Text = "1 Week avarage"
        '
        'dtpStatistic
        '
        Me.dtpStatistic.CustomFormat = "dd.MM.yyyy"
        Me.dtpStatistic.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStatistic.Location = New System.Drawing.Point(8, 23)
        Me.dtpStatistic.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpStatistic.Name = "dtpStatistic"
        Me.dtpStatistic.Size = New System.Drawing.Size(107, 22)
        Me.dtpStatistic.TabIndex = 1
        Me.dtpStatistic.Value = New Date(2022, 3, 29, 20, 31, 18, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(4, 10)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 16)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Current Calculation"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.lblCurrentCalcFat)
        Me.Panel2.Controls.Add(Me.lblCurrentCalcSug)
        Me.Panel2.Controls.Add(Me.lblCurrentCalcCarbs)
        Me.Panel2.Controls.Add(Me.lblCurrentCalcProt)
        Me.Panel2.Controls.Add(Me.lblCurrentCalcCal)
        Me.Panel2.Location = New System.Drawing.Point(237, 86)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(697, 34)
        Me.Panel2.TabIndex = 33
        '
        'lblCurrentCalcFat
        '
        Me.lblCurrentCalcFat.AutoSize = True
        Me.lblCurrentCalcFat.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCurrentCalcFat.Location = New System.Drawing.Point(593, 10)
        Me.lblCurrentCalcFat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentCalcFat.Name = "lblCurrentCalcFat"
        Me.lblCurrentCalcFat.Size = New System.Drawing.Size(30, 16)
        Me.lblCurrentCalcFat.TabIndex = 4
        Me.lblCurrentCalcFat.Text = "N/A"
        '
        'lblCurrentCalcSug
        '
        Me.lblCurrentCalcSug.AutoSize = True
        Me.lblCurrentCalcSug.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCurrentCalcSug.Location = New System.Drawing.Point(485, 10)
        Me.lblCurrentCalcSug.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentCalcSug.Name = "lblCurrentCalcSug"
        Me.lblCurrentCalcSug.Size = New System.Drawing.Size(30, 16)
        Me.lblCurrentCalcSug.TabIndex = 3
        Me.lblCurrentCalcSug.Text = "N/A"
        '
        'lblCurrentCalcCarbs
        '
        Me.lblCurrentCalcCarbs.AutoSize = True
        Me.lblCurrentCalcCarbs.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCurrentCalcCarbs.Location = New System.Drawing.Point(377, 10)
        Me.lblCurrentCalcCarbs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentCalcCarbs.Name = "lblCurrentCalcCarbs"
        Me.lblCurrentCalcCarbs.Size = New System.Drawing.Size(30, 16)
        Me.lblCurrentCalcCarbs.TabIndex = 2
        Me.lblCurrentCalcCarbs.Text = "N/A"
        '
        'lblCurrentCalcProt
        '
        Me.lblCurrentCalcProt.AutoSize = True
        Me.lblCurrentCalcProt.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCurrentCalcProt.Location = New System.Drawing.Point(269, 10)
        Me.lblCurrentCalcProt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentCalcProt.Name = "lblCurrentCalcProt"
        Me.lblCurrentCalcProt.Size = New System.Drawing.Size(30, 16)
        Me.lblCurrentCalcProt.TabIndex = 1
        Me.lblCurrentCalcProt.Text = "N/A"
        '
        'lblCurrentCalcCal
        '
        Me.lblCurrentCalcCal.AutoSize = True
        Me.lblCurrentCalcCal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCurrentCalcCal.Location = New System.Drawing.Point(161, 10)
        Me.lblCurrentCalcCal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentCalcCal.Name = "lblCurrentCalcCal"
        Me.lblCurrentCalcCal.Size = New System.Drawing.Size(30, 16)
        Me.lblCurrentCalcCal.TabIndex = 0
        Me.lblCurrentCalcCal.Text = "N/A"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Gold
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(68, 34)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 16)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Click to view list"
        '
        'BtnClearTbx
        '
        Me.BtnClearTbx.Location = New System.Drawing.Point(835, 139)
        Me.BtnClearTbx.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClearTbx.Name = "BtnClearTbx"
        Me.BtnClearTbx.Size = New System.Drawing.Size(100, 28)
        Me.BtnClearTbx.TabIndex = 45
        Me.BtnClearTbx.TabStop = False
        Me.BtnClearTbx.Text = "Clear"
        Me.BtnClearTbx.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(444, 176)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(329, 16)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "TODO: List will show based on Date showed in statistic"
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(835, 193)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(100, 28)
        Me.BtnDelete.TabIndex = 47
        Me.BtnDelete.TabStop = False
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
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
        'dgvTempList
        '
        Me.dgvTempList.AllowDrop = True
        Me.dgvTempList.AllowUserToAddRows = False
        Me.dgvTempList.AllowUserToDeleteRows = False
        Me.dgvTempList.AllowUserToOrderColumns = True
        Me.dgvTempList.AllowUserToResizeRows = False
        Me.dgvTempList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTempList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTempList.Location = New System.Drawing.Point(0, 235)
        Me.dgvTempList.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTempList.MultiSelect = False
        Me.dgvTempList.Name = "dgvTempList"
        Me.dgvTempList.RowHeadersVisible = False
        Me.dgvTempList.RowHeadersWidth = 51
        Me.dgvTempList.Size = New System.Drawing.Size(1174, 322)
        Me.dgvTempList.TabIndex = 48
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(233, 139)
        Me.LblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(44, 16)
        Me.LblStatus.TabIndex = 49
        Me.LblStatus.Text = "Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1636, 30)
        Me.MenuStrip1.TabIndex = 50
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ApplicationToolStripMenuItem
        '
        Me.ApplicationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButterButtonSettingsToolStripMenuItem})
        Me.ApplicationToolStripMenuItem.Name = "ApplicationToolStripMenuItem"
        Me.ApplicationToolStripMenuItem.Size = New System.Drawing.Size(100, 26)
        Me.ApplicationToolStripMenuItem.Text = "Application"
        '
        'ButterButtonSettingsToolStripMenuItem
        '
        Me.ButterButtonSettingsToolStripMenuItem.Name = "ButterButtonSettingsToolStripMenuItem"
        Me.ButterButtonSettingsToolStripMenuItem.Size = New System.Drawing.Size(237, 26)
        Me.ButterButtonSettingsToolStripMenuItem.Text = "Butter Button Settings"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.InstructionsToolStripMenuItem, Me.ShortcutsToolStripMenuItem})
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(49, 26)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.InstructionsToolStripMenuItem.Text = "Instructions"
        '
        'ShortcutsToolStripMenuItem
        '
        Me.ShortcutsToolStripMenuItem.Name = "ShortcutsToolStripMenuItem"
        Me.ShortcutsToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.ShortcutsToolStripMenuItem.Text = "Shortcuts"
        '
        'tbxNameSelector
        '
        Me.tbxNameSelector.FormattingEnabled = True
        Me.tbxNameSelector.ItemHeight = 16
        Me.tbxNameSelector.Location = New System.Drawing.Point(12, 54)
        Me.tbxNameSelector.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxNameSelector.Name = "tbxNameSelector"
        Me.tbxNameSelector.Size = New System.Drawing.Size(216, 24)
        Me.tbxNameSelector.TabIndex = 51
        Me.tbxNameSelector.Text = "N/A"
        '
        'ButtonFill
        '
        Me.ButtonFill.Location = New System.Drawing.Point(156, 86)
        Me.ButtonFill.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonFill.Name = "ButtonFill"
        Me.ButtonFill.Size = New System.Drawing.Size(73, 25)
        Me.ButtonFill.TabIndex = 2
        Me.ButtonFill.Text = "Fill"
        Me.ButtonFill.UseVisualStyleBackColor = True
        '
        'btnButter1
        '
        Me.btnButter1.Location = New System.Drawing.Point(15, 199)
        Me.btnButter1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnButter1.Name = "btnButter1"
        Me.btnButter1.Size = New System.Drawing.Size(145, 28)
        Me.btnButter1.TabIndex = 40
        Me.btnButter1.Text = "Button 1"
        Me.btnButter1.UseVisualStyleBackColor = True
        '
        'btnButter2
        '
        Me.btnButter2.Location = New System.Drawing.Point(168, 199)
        Me.btnButter2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnButter2.Name = "btnButter2"
        Me.btnButter2.Size = New System.Drawing.Size(145, 28)
        Me.btnButter2.TabIndex = 41
        Me.btnButter2.Text = "Button 2"
        Me.btnButter2.UseVisualStyleBackColor = True
        '
        'btnButter3
        '
        Me.btnButter3.Location = New System.Drawing.Point(321, 199)
        Me.btnButter3.Margin = New System.Windows.Forms.Padding(4)
        Me.btnButter3.Name = "btnButter3"
        Me.btnButter3.Size = New System.Drawing.Size(145, 28)
        Me.btnButter3.TabIndex = 43
        Me.btnButter3.Text = "Button 3"
        Me.btnButter3.UseVisualStyleBackColor = True
        '
        'btnButter4
        '
        Me.btnButter4.Location = New System.Drawing.Point(475, 199)
        Me.btnButter4.Margin = New System.Windows.Forms.Padding(4)
        Me.btnButter4.Name = "btnButter4"
        Me.btnButter4.Size = New System.Drawing.Size(145, 28)
        Me.btnButter4.TabIndex = 44
        Me.btnButter4.Text = "Button 4"
        Me.btnButter4.UseVisualStyleBackColor = True
        '
        'btnButter5
        '
        Me.btnButter5.Location = New System.Drawing.Point(628, 199)
        Me.btnButter5.Margin = New System.Windows.Forms.Padding(4)
        Me.btnButter5.Name = "btnButter5"
        Me.btnButter5.Size = New System.Drawing.Size(145, 28)
        Me.btnButter5.TabIndex = 45
        Me.btnButter5.Text = "Button 5"
        Me.btnButter5.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1636, 974)
        Me.Controls.Add(Me.btnButter5)
        Me.Controls.Add(Me.btnButter4)
        Me.Controls.Add(Me.btnButter3)
        Me.Controls.Add(Me.btnButter2)
        Me.Controls.Add(Me.ButtonFill)
        Me.Controls.Add(Me.tbxNameSelector)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.dgvTempList)
        Me.Controls.Add(Me.BtnDelete)
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
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbxBrandSelector)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSubmitCalc)
        Me.Controls.Add(Me.tbxWeightSelector)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatisticBox.ResumeLayout(False)
        Me.AvarageBox.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.CCS_V3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodHistorytableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodHistorytableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTempList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxWeightSelector As TextBox
    Friend WithEvents btnSubmitCalc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxBrandSelector As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TbxCalSelector As TextBox
    Friend WithEvents TbxProSelector As TextBox
    Friend WithEvents TbxCarbSelector As TextBox
    Friend WithEvents TbxFatSelector As TextBox
    Friend WithEvents TbxSugSelector As TextBox
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
    Friend WithEvents BtnDelete As Button
    Friend WithEvents FoodHistorytableBindingSource As BindingSource
    Friend WithEvents FoodHistorytableBindingSource1 As BindingSource
    Friend WithEvents dgvTempList As DataGridView
    Friend WithEvents LblStatus As Label
    Friend WithEvents CCS_V3DataSet As CCS_V3DataSet
    Friend WithEvents Food_History_tableTableAdapter As CCS_V3DataSetTableAdapters.Food_History_tableTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstructionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShortcutsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents ButterButtonSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbxNameSelector As ComboBox
    Friend WithEvents ButtonFill As Button
    Friend WithEvents btnButter1 As Button
    Friend WithEvents btnButter2 As Button
    Friend WithEvents btnButter3 As Button
    Friend WithEvents btnButter4 As Button
    Friend WithEvents btnButter5 As Button
End Class
