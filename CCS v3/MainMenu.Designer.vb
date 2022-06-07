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
        Me.LblNewFat = New System.Windows.Forms.Label()
        Me.LblNewSug = New System.Windows.Forms.Label()
        Me.LblNewCarb = New System.Windows.Forms.Label()
        Me.LblNewProt = New System.Windows.Forms.Label()
        Me.LblNewCal = New System.Windows.Forms.Label()
        Me.LblNewSumFat = New System.Windows.Forms.Label()
        Me.LblNewSumSug = New System.Windows.Forms.Label()
        Me.LblNewSumCarb = New System.Windows.Forms.Label()
        Me.LblNewSumProt = New System.Windows.Forms.Label()
        Me.LblNewSumCal = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
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
        Me.DgvStatistic = New System.Windows.Forms.DataGridView()
        Me.BtnBodyMessures = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TbxWeightCurrent = New System.Windows.Forms.TextBox()
        Me.LblWeekAverageWeightP1 = New System.Windows.Forms.Label()
        Me.LblWeekAverageCaloriesP1 = New System.Windows.Forms.Label()
        Me.LblWeekAverageProteinP1 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.LblWeekAverageCarbsP1 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.LblTrendWeight = New System.Windows.Forms.Label()
        Me.LblTrendCal = New System.Windows.Forms.Label()
        Me.LblTrendProt = New System.Windows.Forms.Label()
        Me.LblTrendCarb = New System.Windows.Forms.Label()
        Me.LblTrendFat = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TbxGoalWeight = New System.Windows.Forms.TextBox()
        Me.TbxGoalCal = New System.Windows.Forms.TextBox()
        Me.TbxGoalProt = New System.Windows.Forms.TextBox()
        Me.TbxGoalCarb = New System.Windows.Forms.TextBox()
        Me.TbxGoalFat = New System.Windows.Forms.TextBox()
        Me.LblWeekAverageWeightP2 = New System.Windows.Forms.Label()
        Me.LblWeekAverageCaloriesP2 = New System.Windows.Forms.Label()
        Me.LblWeekAverageCarbsP2 = New System.Windows.Forms.Label()
        Me.LblWeekAverageProteinP2 = New System.Windows.Forms.Label()
        Me.LblWeekAverageFatP1 = New System.Windows.Forms.Label()
        Me.LblWeekAverageFatP2 = New System.Windows.Forms.Label()
        Me.TbxCaloriesCurrent = New System.Windows.Forms.TextBox()
        Me.TbxProteinCurrent = New System.Windows.Forms.TextBox()
        Me.TbxCarbsCurrent = New System.Windows.Forms.TextBox()
        Me.TbxFatCurrent = New System.Windows.Forms.TextBox()
        Me.BtnSubtmitWeight = New System.Windows.Forms.Button()
        Me.dtpStatistic = New System.Windows.Forms.DateTimePicker()
        Me.BtnToday = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCurrentCalcFat = New System.Windows.Forms.Label()
        Me.lblCurrentCalcSug = New System.Windows.Forms.Label()
        Me.lblCurrentCalcCarbs = New System.Windows.Forms.Label()
        Me.lblCurrentCalcProt = New System.Windows.Forms.Label()
        Me.lblCurrentCalcCal = New System.Windows.Forms.Label()
        Me.LblFoodList = New System.Windows.Forms.Label()
        Me.BtnClearTbx = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
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
        Me.TbxIDSelector = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DgvTempCollection = New System.Windows.Forms.DataGridView()
        Me.BtnCollection = New System.Windows.Forms.Button()
        Me.CCS_V3DataSet = New CCS_v3.CCS_V3DataSet()
        Me.FoodHistorytableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Food_History_tableTableAdapter = New CCS_v3.CCS_V3DataSetTableAdapters.Food_History_tableTableAdapter()
        Me.FoodHistorytableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TbxCollectionName = New System.Windows.Forms.TextBox()
        Me.CbxSplitAmount = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.LblCurrentCollectionTotalWeight = New System.Windows.Forms.Label()
        Me.LblCurrentCollectionTotalFat = New System.Windows.Forms.Label()
        Me.LblCurrentCollectionTotalSug = New System.Windows.Forms.Label()
        Me.LblCurrentCollectionTotalCarb = New System.Windows.Forms.Label()
        Me.LblCurrentCollectionTotalProt = New System.Windows.Forms.Label()
        Me.LblCurrentCollectionTotalCal = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.LblCurrentCollectionXgFat = New System.Windows.Forms.Label()
        Me.LblCurrentCollectionXgSug = New System.Windows.Forms.Label()
        Me.LblCurrentCollectionXgCarb = New System.Windows.Forms.Label()
        Me.LblCurrentCollectionXgProt = New System.Windows.Forms.Label()
        Me.LblCurrentCollectionXgCal = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.TbxCollectionWeight = New System.Windows.Forms.TextBox()
        Me.LblCurrentCollectionCurrentFat = New System.Windows.Forms.Label()
        Me.LblCurrentCollectionCurrentSug = New System.Windows.Forms.Label()
        Me.LblCurrentCollectionCurrentCarb = New System.Windows.Forms.Label()
        Me.LblCurrentCollectionCurrentProt = New System.Windows.Forms.Label()
        Me.LblCurrentCollectionCurrentCal = New System.Windows.Forms.Label()
        Me.BtnCollectionSubmit = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.LblDGVDeleteSelector = New System.Windows.Forms.Label()
        Me.BtnClearCollection = New System.Windows.Forms.Button()
        Me.DtpDateSelector = New System.Windows.Forms.DateTimePicker()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CbPlus1 = New System.Windows.Forms.CheckBox()
        Me.LblRecipeList = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.StatisticBox.SuspendLayout()
        CType(Me.DgvStatistic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvTempList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DgvTempCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCS_V3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodHistorytableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodHistorytableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbxWeightSelector
        '
        Me.tbxWeightSelector.Location = New System.Drawing.Point(9, 70)
        Me.tbxWeightSelector.Name = "tbxWeightSelector"
        Me.tbxWeightSelector.Size = New System.Drawing.Size(102, 20)
        Me.tbxWeightSelector.TabIndex = 9
        Me.tbxWeightSelector.Text = "0"
        '
        'btnSubmitCalc
        '
        Me.btnSubmitCalc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSubmitCalc.Location = New System.Drawing.Point(11, 113)
        Me.btnSubmitCalc.Margin = New System.Windows.Forms.Padding(2)
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
        Me.tbxBrandSelector.TabIndex = 3
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
        'TbxCalSelector
        '
        Me.TbxCalSelector.Location = New System.Drawing.Point(302, 44)
        Me.TbxCalSelector.Name = "TbxCalSelector"
        Me.TbxCalSelector.Size = New System.Drawing.Size(75, 20)
        Me.TbxCalSelector.TabIndex = 4
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Location = New System.Drawing.Point(14, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Butter Button's (Presets)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(6, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Current total of the Day"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.LblNewFat)
        Me.Panel1.Controls.Add(Me.LblNewSug)
        Me.Panel1.Controls.Add(Me.LblNewCarb)
        Me.Panel1.Controls.Add(Me.LblNewProt)
        Me.Panel1.Controls.Add(Me.LblNewCal)
        Me.Panel1.Controls.Add(Me.LblNewSumFat)
        Me.Panel1.Controls.Add(Me.LblNewSumSug)
        Me.Panel1.Controls.Add(Me.LblNewSumCarb)
        Me.Panel1.Controls.Add(Me.LblNewSumProt)
        Me.Panel1.Controls.Add(Me.LblNewSumCal)
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.Label30)
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
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(4, 387)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 67)
        Me.Panel1.TabIndex = 29
        '
        'LblNewFat
        '
        Me.LblNewFat.AutoSize = True
        Me.LblNewFat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblNewFat.Location = New System.Drawing.Point(530, 5)
        Me.LblNewFat.Name = "LblNewFat"
        Me.LblNewFat.Size = New System.Drawing.Size(27, 13)
        Me.LblNewFat.TabIndex = 520
        Me.LblNewFat.Text = "N/A"
        '
        'LblNewSug
        '
        Me.LblNewSug.AutoSize = True
        Me.LblNewSug.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblNewSug.Location = New System.Drawing.Point(449, 5)
        Me.LblNewSug.Name = "LblNewSug"
        Me.LblNewSug.Size = New System.Drawing.Size(27, 13)
        Me.LblNewSug.TabIndex = 519
        Me.LblNewSug.Text = "N/A"
        '
        'LblNewCarb
        '
        Me.LblNewCarb.AutoSize = True
        Me.LblNewCarb.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblNewCarb.Location = New System.Drawing.Point(368, 5)
        Me.LblNewCarb.Name = "LblNewCarb"
        Me.LblNewCarb.Size = New System.Drawing.Size(27, 13)
        Me.LblNewCarb.TabIndex = 518
        Me.LblNewCarb.Text = "N/A"
        '
        'LblNewProt
        '
        Me.LblNewProt.AutoSize = True
        Me.LblNewProt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblNewProt.Location = New System.Drawing.Point(287, 5)
        Me.LblNewProt.Name = "LblNewProt"
        Me.LblNewProt.Size = New System.Drawing.Size(27, 13)
        Me.LblNewProt.TabIndex = 517
        Me.LblNewProt.Text = "N/A"
        '
        'LblNewCal
        '
        Me.LblNewCal.AutoSize = True
        Me.LblNewCal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblNewCal.Location = New System.Drawing.Point(206, 5)
        Me.LblNewCal.Name = "LblNewCal"
        Me.LblNewCal.Size = New System.Drawing.Size(27, 13)
        Me.LblNewCal.TabIndex = 516
        Me.LblNewCal.Text = "N/A"
        '
        'LblNewSumFat
        '
        Me.LblNewSumFat.AutoSize = True
        Me.LblNewSumFat.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.LblNewSumFat.Location = New System.Drawing.Point(530, 21)
        Me.LblNewSumFat.Name = "LblNewSumFat"
        Me.LblNewSumFat.Size = New System.Drawing.Size(27, 13)
        Me.LblNewSumFat.TabIndex = 515
        Me.LblNewSumFat.Text = "N/A"
        '
        'LblNewSumSug
        '
        Me.LblNewSumSug.AutoSize = True
        Me.LblNewSumSug.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.LblNewSumSug.Location = New System.Drawing.Point(449, 21)
        Me.LblNewSumSug.Name = "LblNewSumSug"
        Me.LblNewSumSug.Size = New System.Drawing.Size(27, 13)
        Me.LblNewSumSug.TabIndex = 514
        Me.LblNewSumSug.Text = "N/A"
        '
        'LblNewSumCarb
        '
        Me.LblNewSumCarb.AutoSize = True
        Me.LblNewSumCarb.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.LblNewSumCarb.Location = New System.Drawing.Point(368, 21)
        Me.LblNewSumCarb.Name = "LblNewSumCarb"
        Me.LblNewSumCarb.Size = New System.Drawing.Size(27, 13)
        Me.LblNewSumCarb.TabIndex = 513
        Me.LblNewSumCarb.Text = "N/A"
        '
        'LblNewSumProt
        '
        Me.LblNewSumProt.AutoSize = True
        Me.LblNewSumProt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.LblNewSumProt.Location = New System.Drawing.Point(287, 21)
        Me.LblNewSumProt.Name = "LblNewSumProt"
        Me.LblNewSumProt.Size = New System.Drawing.Size(27, 13)
        Me.LblNewSumProt.TabIndex = 512
        Me.LblNewSumProt.Text = "N/A"
        '
        'LblNewSumCal
        '
        Me.LblNewSumCal.AutoSize = True
        Me.LblNewSumCal.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.LblNewSumCal.Location = New System.Drawing.Point(206, 21)
        Me.LblNewSumCal.Name = "LblNewSumCal"
        Me.LblNewSumCal.Size = New System.Drawing.Size(27, 13)
        Me.LblNewSumCal.TabIndex = 511
        Me.LblNewSumCal.Text = "N/A"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label36.Location = New System.Drawing.Point(6, 5)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(56, 13)
        Me.Label36.TabIndex = 510
        Me.Label36.Text = "Difference"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(6, 21)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 13)
        Me.Label30.TabIndex = 509
        Me.Label30.Text = "New Total"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.Location = New System.Drawing.Point(530, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(22, 13)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Fat"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label15.Location = New System.Drawing.Point(449, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 13)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Sugar"
        '
        'LblSumFat
        '
        Me.LblSumFat.AutoSize = True
        Me.LblSumFat.BackColor = System.Drawing.Color.BurlyWood
        Me.LblSumFat.Location = New System.Drawing.Point(530, 37)
        Me.LblSumFat.Name = "LblSumFat"
        Me.LblSumFat.Size = New System.Drawing.Size(27, 13)
        Me.LblSumFat.TabIndex = 4
        Me.LblSumFat.Text = "N/A"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label16.Location = New System.Drawing.Point(368, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Carbs"
        '
        'LblSumSug
        '
        Me.LblSumSug.AutoSize = True
        Me.LblSumSug.BackColor = System.Drawing.Color.BurlyWood
        Me.LblSumSug.Location = New System.Drawing.Point(449, 37)
        Me.LblSumSug.Name = "LblSumSug"
        Me.LblSumSug.Size = New System.Drawing.Size(27, 13)
        Me.LblSumSug.TabIndex = 3
        Me.LblSumSug.Text = "N/A"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label17.Location = New System.Drawing.Point(287, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Proteins"
        '
        'LblSumCarb
        '
        Me.LblSumCarb.AutoSize = True
        Me.LblSumCarb.BackColor = System.Drawing.Color.BurlyWood
        Me.LblSumCarb.Location = New System.Drawing.Point(368, 37)
        Me.LblSumCarb.Name = "LblSumCarb"
        Me.LblSumCarb.Size = New System.Drawing.Size(27, 13)
        Me.LblSumCarb.TabIndex = 2
        Me.LblSumCarb.Text = "N/A"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label18.Location = New System.Drawing.Point(206, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "Calories"
        '
        'LblSumProt
        '
        Me.LblSumProt.AutoSize = True
        Me.LblSumProt.BackColor = System.Drawing.Color.BurlyWood
        Me.LblSumProt.Location = New System.Drawing.Point(287, 37)
        Me.LblSumProt.Name = "LblSumProt"
        Me.LblSumProt.Size = New System.Drawing.Size(27, 13)
        Me.LblSumProt.TabIndex = 1
        Me.LblSumProt.Text = "N/A"
        '
        'LblSumCal
        '
        Me.LblSumCal.AutoSize = True
        Me.LblSumCal.BackColor = System.Drawing.Color.BurlyWood
        Me.LblSumCal.Location = New System.Drawing.Point(206, 37)
        Me.LblSumCal.Name = "LblSumCal"
        Me.LblSumCal.Size = New System.Drawing.Size(27, 13)
        Me.LblSumCal.TabIndex = 0
        Me.LblSumCal.Text = "N/A"
        '
        'StatisticBox
        '
        Me.StatisticBox.Controls.Add(Me.DgvStatistic)
        Me.StatisticBox.Controls.Add(Me.BtnBodyMessures)
        Me.StatisticBox.Controls.Add(Me.TableLayoutPanel1)
        Me.StatisticBox.Controls.Add(Me.dtpStatistic)
        Me.StatisticBox.Controls.Add(Me.BtnToday)
        Me.StatisticBox.Location = New System.Drawing.Point(822, 30)
        Me.StatisticBox.Name = "StatisticBox"
        Me.StatisticBox.Size = New System.Drawing.Size(407, 690)
        Me.StatisticBox.TabIndex = 31
        Me.StatisticBox.TabStop = False
        Me.StatisticBox.Text = "Statistic"
        '
        'DgvStatistic
        '
        Me.DgvStatistic.AllowUserToAddRows = False
        Me.DgvStatistic.AllowUserToDeleteRows = False
        Me.DgvStatistic.AllowUserToResizeRows = False
        Me.DgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvStatistic.Location = New System.Drawing.Point(7, 200)
        Me.DgvStatistic.Name = "DgvStatistic"
        Me.DgvStatistic.ReadOnly = True
        Me.DgvStatistic.RowHeadersVisible = False
        Me.DgvStatistic.Size = New System.Drawing.Size(394, 357)
        Me.DgvStatistic.TabIndex = 515
        '
        'BtnBodyMessures
        '
        Me.BtnBodyMessures.Location = New System.Drawing.Point(321, 15)
        Me.BtnBodyMessures.Name = "BtnBodyMessures"
        Me.BtnBodyMessures.Size = New System.Drawing.Size(75, 20)
        Me.BtnBodyMessures.TabIndex = 8
        Me.BtnBodyMessures.Text = "Body Messurements"
        Me.BtnBodyMessures.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label32, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label24, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label23, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label22, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label21, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TbxWeightCurrent, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblWeekAverageWeightP1, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblWeekAverageCaloriesP1, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblWeekAverageProteinP1, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label31, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LblWeekAverageCarbsP1, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label25, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTrendWeight, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTrendCal, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTrendProt, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTrendCarb, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTrendFat, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label33, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label26, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TbxGoalWeight, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TbxGoalCal, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TbxGoalProt, 5, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TbxGoalCarb, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TbxGoalFat, 5, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LblWeekAverageWeightP2, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblWeekAverageCaloriesP2, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblWeekAverageCarbsP2, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LblWeekAverageProteinP2, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblWeekAverageFatP1, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LblWeekAverageFatP2, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TbxCaloriesCurrent, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TbxProteinCurrent, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TbxCarbsCurrent, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TbxFatCurrent, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnSubtmitWeight, 0, 0)
        Me.TableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 40)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(393, 154)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label32
        '
        Me.Label32.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Khaki
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label32.Location = New System.Drawing.Point(2, 125)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(74, 29)
        Me.Label32.TabIndex = 20
        Me.Label32.Text = "Fat"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Khaki
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Location = New System.Drawing.Point(2, 75)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(74, 25)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Protein"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Khaki
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Location = New System.Drawing.Point(2, 50)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(74, 25)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Calories"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Khaki
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Location = New System.Drawing.Point(2, 25)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(74, 25)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "Weight"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Khaki
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Location = New System.Drawing.Point(158, 0)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 25)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "7-Day Average"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label21.UseCompatibleTextRendering = True
        '
        'Label20
        '
        Me.Label20.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Khaki
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Location = New System.Drawing.Point(80, 0)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 25)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Today"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TbxWeightCurrent
        '
        Me.TbxWeightCurrent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbxWeightCurrent.Location = New System.Drawing.Point(80, 27)
        Me.TbxWeightCurrent.Margin = New System.Windows.Forms.Padding(2)
        Me.TbxWeightCurrent.Name = "TbxWeightCurrent"
        Me.TbxWeightCurrent.Size = New System.Drawing.Size(74, 20)
        Me.TbxWeightCurrent.TabIndex = 2
        '
        'LblWeekAverageWeightP1
        '
        Me.LblWeekAverageWeightP1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblWeekAverageWeightP1.AutoSize = True
        Me.LblWeekAverageWeightP1.BackColor = System.Drawing.Color.LightBlue
        Me.LblWeekAverageWeightP1.Location = New System.Drawing.Point(158, 25)
        Me.LblWeekAverageWeightP1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblWeekAverageWeightP1.Name = "LblWeekAverageWeightP1"
        Me.LblWeekAverageWeightP1.Size = New System.Drawing.Size(54, 25)
        Me.LblWeekAverageWeightP1.TabIndex = 10
        Me.LblWeekAverageWeightP1.Text = "0"
        Me.LblWeekAverageWeightP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblWeekAverageCaloriesP1
        '
        Me.LblWeekAverageCaloriesP1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblWeekAverageCaloriesP1.AutoSize = True
        Me.LblWeekAverageCaloriesP1.BackColor = System.Drawing.Color.LightBlue
        Me.LblWeekAverageCaloriesP1.Location = New System.Drawing.Point(158, 50)
        Me.LblWeekAverageCaloriesP1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblWeekAverageCaloriesP1.Name = "LblWeekAverageCaloriesP1"
        Me.LblWeekAverageCaloriesP1.Size = New System.Drawing.Size(54, 25)
        Me.LblWeekAverageCaloriesP1.TabIndex = 11
        Me.LblWeekAverageCaloriesP1.Text = "0"
        Me.LblWeekAverageCaloriesP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblWeekAverageProteinP1
        '
        Me.LblWeekAverageProteinP1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblWeekAverageProteinP1.AutoSize = True
        Me.LblWeekAverageProteinP1.BackColor = System.Drawing.Color.LightBlue
        Me.LblWeekAverageProteinP1.Location = New System.Drawing.Point(158, 75)
        Me.LblWeekAverageProteinP1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblWeekAverageProteinP1.Name = "LblWeekAverageProteinP1"
        Me.LblWeekAverageProteinP1.Size = New System.Drawing.Size(54, 25)
        Me.LblWeekAverageProteinP1.TabIndex = 12
        Me.LblWeekAverageProteinP1.Text = "0"
        Me.LblWeekAverageProteinP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Khaki
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label31.Location = New System.Drawing.Point(2, 100)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(74, 25)
        Me.Label31.TabIndex = 19
        Me.Label31.Text = "Carbs"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblWeekAverageCarbsP1
        '
        Me.LblWeekAverageCarbsP1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblWeekAverageCarbsP1.AutoSize = True
        Me.LblWeekAverageCarbsP1.BackColor = System.Drawing.Color.LightBlue
        Me.LblWeekAverageCarbsP1.Location = New System.Drawing.Point(158, 100)
        Me.LblWeekAverageCarbsP1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblWeekAverageCarbsP1.Name = "LblWeekAverageCarbsP1"
        Me.LblWeekAverageCarbsP1.Size = New System.Drawing.Size(54, 25)
        Me.LblWeekAverageCarbsP1.TabIndex = 21
        Me.LblWeekAverageCarbsP1.Text = "0"
        Me.LblWeekAverageCarbsP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Khaki
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.Location = New System.Drawing.Point(286, 0)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(43, 25)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "(Δ)"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTrendWeight
        '
        Me.LblTrendWeight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTrendWeight.AutoSize = True
        Me.LblTrendWeight.BackColor = System.Drawing.Color.LightBlue
        Me.LblTrendWeight.Location = New System.Drawing.Point(286, 25)
        Me.LblTrendWeight.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTrendWeight.Name = "LblTrendWeight"
        Me.LblTrendWeight.Size = New System.Drawing.Size(43, 25)
        Me.LblTrendWeight.TabIndex = 13
        Me.LblTrendWeight.Text = "0"
        Me.LblTrendWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTrendCal
        '
        Me.LblTrendCal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTrendCal.AutoSize = True
        Me.LblTrendCal.BackColor = System.Drawing.Color.LightBlue
        Me.LblTrendCal.Location = New System.Drawing.Point(286, 50)
        Me.LblTrendCal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTrendCal.Name = "LblTrendCal"
        Me.LblTrendCal.Size = New System.Drawing.Size(43, 25)
        Me.LblTrendCal.TabIndex = 14
        Me.LblTrendCal.Text = "0"
        Me.LblTrendCal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTrendProt
        '
        Me.LblTrendProt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTrendProt.AutoSize = True
        Me.LblTrendProt.BackColor = System.Drawing.Color.LightBlue
        Me.LblTrendProt.Location = New System.Drawing.Point(286, 75)
        Me.LblTrendProt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTrendProt.Name = "LblTrendProt"
        Me.LblTrendProt.Size = New System.Drawing.Size(43, 25)
        Me.LblTrendProt.TabIndex = 15
        Me.LblTrendProt.Text = "0"
        Me.LblTrendProt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTrendCarb
        '
        Me.LblTrendCarb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTrendCarb.AutoSize = True
        Me.LblTrendCarb.BackColor = System.Drawing.Color.LightBlue
        Me.LblTrendCarb.Location = New System.Drawing.Point(286, 100)
        Me.LblTrendCarb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTrendCarb.Name = "LblTrendCarb"
        Me.LblTrendCarb.Size = New System.Drawing.Size(43, 25)
        Me.LblTrendCarb.TabIndex = 23
        Me.LblTrendCarb.Text = "0"
        Me.LblTrendCarb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTrendFat
        '
        Me.LblTrendFat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTrendFat.AutoSize = True
        Me.LblTrendFat.BackColor = System.Drawing.Color.LightBlue
        Me.LblTrendFat.Location = New System.Drawing.Point(286, 125)
        Me.LblTrendFat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTrendFat.Name = "LblTrendFat"
        Me.LblTrendFat.Size = New System.Drawing.Size(43, 29)
        Me.LblTrendFat.TabIndex = 24
        Me.LblTrendFat.Text = "0"
        Me.LblTrendFat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Khaki
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label33.Location = New System.Drawing.Point(216, 0)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(66, 25)
        Me.Label33.TabIndex = 27
        Me.Label33.Text = "Last week average"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label33.UseCompatibleTextRendering = True
        '
        'Label26
        '
        Me.Label26.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Khaki
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.Location = New System.Drawing.Point(333, 0)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(58, 25)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "Goal"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TbxGoalWeight
        '
        Me.TbxGoalWeight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbxGoalWeight.Location = New System.Drawing.Point(333, 27)
        Me.TbxGoalWeight.Margin = New System.Windows.Forms.Padding(2)
        Me.TbxGoalWeight.Name = "TbxGoalWeight"
        Me.TbxGoalWeight.Size = New System.Drawing.Size(58, 20)
        Me.TbxGoalWeight.TabIndex = 16
        '
        'TbxGoalCal
        '
        Me.TbxGoalCal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbxGoalCal.Location = New System.Drawing.Point(333, 52)
        Me.TbxGoalCal.Margin = New System.Windows.Forms.Padding(2)
        Me.TbxGoalCal.Name = "TbxGoalCal"
        Me.TbxGoalCal.Size = New System.Drawing.Size(58, 20)
        Me.TbxGoalCal.TabIndex = 18
        '
        'TbxGoalProt
        '
        Me.TbxGoalProt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbxGoalProt.Location = New System.Drawing.Point(333, 77)
        Me.TbxGoalProt.Margin = New System.Windows.Forms.Padding(2)
        Me.TbxGoalProt.Name = "TbxGoalProt"
        Me.TbxGoalProt.Size = New System.Drawing.Size(58, 20)
        Me.TbxGoalProt.TabIndex = 17
        '
        'TbxGoalCarb
        '
        Me.TbxGoalCarb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbxGoalCarb.Location = New System.Drawing.Point(333, 102)
        Me.TbxGoalCarb.Margin = New System.Windows.Forms.Padding(2)
        Me.TbxGoalCarb.Name = "TbxGoalCarb"
        Me.TbxGoalCarb.Size = New System.Drawing.Size(58, 20)
        Me.TbxGoalCarb.TabIndex = 26
        '
        'TbxGoalFat
        '
        Me.TbxGoalFat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbxGoalFat.Location = New System.Drawing.Point(333, 127)
        Me.TbxGoalFat.Margin = New System.Windows.Forms.Padding(2)
        Me.TbxGoalFat.Name = "TbxGoalFat"
        Me.TbxGoalFat.Size = New System.Drawing.Size(58, 20)
        Me.TbxGoalFat.TabIndex = 25
        '
        'LblWeekAverageWeightP2
        '
        Me.LblWeekAverageWeightP2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblWeekAverageWeightP2.AutoSize = True
        Me.LblWeekAverageWeightP2.BackColor = System.Drawing.Color.LightBlue
        Me.LblWeekAverageWeightP2.Location = New System.Drawing.Point(216, 25)
        Me.LblWeekAverageWeightP2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblWeekAverageWeightP2.Name = "LblWeekAverageWeightP2"
        Me.LblWeekAverageWeightP2.Size = New System.Drawing.Size(66, 25)
        Me.LblWeekAverageWeightP2.TabIndex = 29
        Me.LblWeekAverageWeightP2.Text = "0"
        Me.LblWeekAverageWeightP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblWeekAverageCaloriesP2
        '
        Me.LblWeekAverageCaloriesP2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblWeekAverageCaloriesP2.AutoSize = True
        Me.LblWeekAverageCaloriesP2.BackColor = System.Drawing.Color.LightBlue
        Me.LblWeekAverageCaloriesP2.Location = New System.Drawing.Point(216, 50)
        Me.LblWeekAverageCaloriesP2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblWeekAverageCaloriesP2.Name = "LblWeekAverageCaloriesP2"
        Me.LblWeekAverageCaloriesP2.Size = New System.Drawing.Size(66, 25)
        Me.LblWeekAverageCaloriesP2.TabIndex = 31
        Me.LblWeekAverageCaloriesP2.Text = "0"
        Me.LblWeekAverageCaloriesP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblWeekAverageCarbsP2
        '
        Me.LblWeekAverageCarbsP2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblWeekAverageCarbsP2.AutoSize = True
        Me.LblWeekAverageCarbsP2.BackColor = System.Drawing.Color.LightBlue
        Me.LblWeekAverageCarbsP2.Location = New System.Drawing.Point(216, 100)
        Me.LblWeekAverageCarbsP2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblWeekAverageCarbsP2.Name = "LblWeekAverageCarbsP2"
        Me.LblWeekAverageCarbsP2.Size = New System.Drawing.Size(66, 25)
        Me.LblWeekAverageCarbsP2.TabIndex = 32
        Me.LblWeekAverageCarbsP2.Text = "0"
        Me.LblWeekAverageCarbsP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblWeekAverageProteinP2
        '
        Me.LblWeekAverageProteinP2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblWeekAverageProteinP2.AutoSize = True
        Me.LblWeekAverageProteinP2.BackColor = System.Drawing.Color.LightBlue
        Me.LblWeekAverageProteinP2.Location = New System.Drawing.Point(216, 75)
        Me.LblWeekAverageProteinP2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblWeekAverageProteinP2.Name = "LblWeekAverageProteinP2"
        Me.LblWeekAverageProteinP2.Size = New System.Drawing.Size(66, 25)
        Me.LblWeekAverageProteinP2.TabIndex = 30
        Me.LblWeekAverageProteinP2.Text = "0"
        Me.LblWeekAverageProteinP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblWeekAverageFatP1
        '
        Me.LblWeekAverageFatP1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblWeekAverageFatP1.AutoSize = True
        Me.LblWeekAverageFatP1.BackColor = System.Drawing.Color.LightBlue
        Me.LblWeekAverageFatP1.Location = New System.Drawing.Point(158, 125)
        Me.LblWeekAverageFatP1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblWeekAverageFatP1.Name = "LblWeekAverageFatP1"
        Me.LblWeekAverageFatP1.Size = New System.Drawing.Size(54, 29)
        Me.LblWeekAverageFatP1.TabIndex = 22
        Me.LblWeekAverageFatP1.Text = "0"
        Me.LblWeekAverageFatP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblWeekAverageFatP2
        '
        Me.LblWeekAverageFatP2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblWeekAverageFatP2.AutoSize = True
        Me.LblWeekAverageFatP2.BackColor = System.Drawing.Color.LightBlue
        Me.LblWeekAverageFatP2.Location = New System.Drawing.Point(216, 125)
        Me.LblWeekAverageFatP2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblWeekAverageFatP2.Name = "LblWeekAverageFatP2"
        Me.LblWeekAverageFatP2.Size = New System.Drawing.Size(66, 29)
        Me.LblWeekAverageFatP2.TabIndex = 33
        Me.LblWeekAverageFatP2.Text = "0"
        Me.LblWeekAverageFatP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TbxCaloriesCurrent
        '
        Me.TbxCaloriesCurrent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbxCaloriesCurrent.BackColor = System.Drawing.SystemColors.Control
        Me.TbxCaloriesCurrent.Location = New System.Drawing.Point(80, 52)
        Me.TbxCaloriesCurrent.Margin = New System.Windows.Forms.Padding(2)
        Me.TbxCaloriesCurrent.Name = "TbxCaloriesCurrent"
        Me.TbxCaloriesCurrent.ReadOnly = True
        Me.TbxCaloriesCurrent.Size = New System.Drawing.Size(74, 20)
        Me.TbxCaloriesCurrent.TabIndex = 34
        '
        'TbxProteinCurrent
        '
        Me.TbxProteinCurrent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbxProteinCurrent.Location = New System.Drawing.Point(80, 77)
        Me.TbxProteinCurrent.Margin = New System.Windows.Forms.Padding(2)
        Me.TbxProteinCurrent.Name = "TbxProteinCurrent"
        Me.TbxProteinCurrent.ReadOnly = True
        Me.TbxProteinCurrent.Size = New System.Drawing.Size(74, 20)
        Me.TbxProteinCurrent.TabIndex = 35
        '
        'TbxCarbsCurrent
        '
        Me.TbxCarbsCurrent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbxCarbsCurrent.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TbxCarbsCurrent.Location = New System.Drawing.Point(80, 102)
        Me.TbxCarbsCurrent.Margin = New System.Windows.Forms.Padding(2)
        Me.TbxCarbsCurrent.Name = "TbxCarbsCurrent"
        Me.TbxCarbsCurrent.ReadOnly = True
        Me.TbxCarbsCurrent.Size = New System.Drawing.Size(74, 20)
        Me.TbxCarbsCurrent.TabIndex = 37
        '
        'TbxFatCurrent
        '
        Me.TbxFatCurrent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbxFatCurrent.Location = New System.Drawing.Point(80, 127)
        Me.TbxFatCurrent.Margin = New System.Windows.Forms.Padding(2)
        Me.TbxFatCurrent.Name = "TbxFatCurrent"
        Me.TbxFatCurrent.ReadOnly = True
        Me.TbxFatCurrent.Size = New System.Drawing.Size(74, 20)
        Me.TbxFatCurrent.TabIndex = 36
        '
        'BtnSubtmitWeight
        '
        Me.BtnSubtmitWeight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSubtmitWeight.Location = New System.Drawing.Point(2, 2)
        Me.BtnSubtmitWeight.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSubtmitWeight.Name = "BtnSubtmitWeight"
        Me.BtnSubtmitWeight.Size = New System.Drawing.Size(74, 21)
        Me.BtnSubtmitWeight.TabIndex = 9
        Me.BtnSubtmitWeight.Text = "Submit"
        Me.BtnSubtmitWeight.UseVisualStyleBackColor = True
        '
        'dtpStatistic
        '
        Me.dtpStatistic.CustomFormat = "dd.MM.yyyy"
        Me.dtpStatistic.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStatistic.Location = New System.Drawing.Point(5, 15)
        Me.dtpStatistic.Name = "dtpStatistic"
        Me.dtpStatistic.Size = New System.Drawing.Size(81, 20)
        Me.dtpStatistic.TabIndex = 1
        Me.dtpStatistic.Value = New Date(2022, 3, 29, 20, 31, 18, 0)
        '
        'BtnToday
        '
        Me.BtnToday.Location = New System.Drawing.Point(92, 15)
        Me.BtnToday.Name = "BtnToday"
        Me.BtnToday.Size = New System.Drawing.Size(75, 20)
        Me.BtnToday.TabIndex = 7
        Me.BtnToday.Text = "Today"
        Me.BtnToday.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(3, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 13)
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
        Me.Panel2.Location = New System.Drawing.Point(178, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(636, 28)
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
        'LblFoodList
        '
        Me.LblFoodList.AutoSize = True
        Me.LblFoodList.BackColor = System.Drawing.Color.Gold
        Me.LblFoodList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblFoodList.Location = New System.Drawing.Point(51, 28)
        Me.LblFoodList.Name = "LblFoodList"
        Me.LblFoodList.Size = New System.Drawing.Size(50, 13)
        Me.LblFoodList.TabIndex = 44
        Me.LblFoodList.Text = "Food List"
        '
        'BtnClearTbx
        '
        Me.BtnClearTbx.Location = New System.Drawing.Point(739, 108)
        Me.BtnClearTbx.Name = "BtnClearTbx"
        Me.BtnClearTbx.Size = New System.Drawing.Size(77, 23)
        Me.BtnClearTbx.TabIndex = 45
        Me.BtnClearTbx.TabStop = False
        Me.BtnClearTbx.Text = "Clear"
        Me.BtnClearTbx.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(739, 162)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(77, 23)
        Me.BtnDelete.TabIndex = 47
        Me.BtnDelete.TabStop = False
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'dgvTempList
        '
        Me.dgvTempList.AllowUserToAddRows = False
        Me.dgvTempList.AllowUserToDeleteRows = False
        Me.dgvTempList.AllowUserToOrderColumns = True
        Me.dgvTempList.AllowUserToResizeRows = False
        Me.dgvTempList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTempList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTempList.Location = New System.Drawing.Point(4, 191)
        Me.dgvTempList.MultiSelect = False
        Me.dgvTempList.Name = "dgvTempList"
        Me.dgvTempList.ReadOnly = True
        Me.dgvTempList.RowHeadersVisible = False
        Me.dgvTempList.RowHeadersWidth = 51
        Me.dgvTempList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTempList.Size = New System.Drawing.Size(810, 189)
        Me.dgvTempList.TabIndex = 48
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.BackColor = System.Drawing.Color.GhostWhite
        Me.LblStatus.Location = New System.Drawing.Point(202, 119)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(37, 13)
        Me.LblStatus.TabIndex = 49
        Me.LblStatus.Text = "Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1233, 24)
        Me.MenuStrip1.TabIndex = 50
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ApplicationToolStripMenuItem
        '
        Me.ApplicationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButterButtonSettingsToolStripMenuItem})
        Me.ApplicationToolStripMenuItem.Name = "ApplicationToolStripMenuItem"
        Me.ApplicationToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.ApplicationToolStripMenuItem.Text = "Application"
        '
        'ButterButtonSettingsToolStripMenuItem
        '
        Me.ButterButtonSettingsToolStripMenuItem.Name = "ButterButtonSettingsToolStripMenuItem"
        Me.ButterButtonSettingsToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ButterButtonSettingsToolStripMenuItem.Text = "Butter Button Settings"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.InstructionsToolStripMenuItem, Me.ShortcutsToolStripMenuItem})
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.InfoToolStripMenuItem.Text = "Information"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.InstructionsToolStripMenuItem.Text = "Instructions"
        '
        'ShortcutsToolStripMenuItem
        '
        Me.ShortcutsToolStripMenuItem.Name = "ShortcutsToolStripMenuItem"
        Me.ShortcutsToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ShortcutsToolStripMenuItem.Text = "Shortcuts"
        '
        'tbxNameSelector
        '
        Me.tbxNameSelector.FormattingEnabled = True
        Me.tbxNameSelector.ItemHeight = 13
        Me.tbxNameSelector.Location = New System.Drawing.Point(9, 44)
        Me.tbxNameSelector.Name = "tbxNameSelector"
        Me.tbxNameSelector.Size = New System.Drawing.Size(163, 21)
        Me.tbxNameSelector.TabIndex = 51
        Me.tbxNameSelector.Text = "N/A"
        '
        'ButtonFill
        '
        Me.ButtonFill.Location = New System.Drawing.Point(117, 70)
        Me.ButtonFill.Name = "ButtonFill"
        Me.ButtonFill.Size = New System.Drawing.Size(55, 20)
        Me.ButtonFill.TabIndex = 2
        Me.ButtonFill.Text = "Fill"
        Me.ButtonFill.UseVisualStyleBackColor = True
        '
        'btnButter1
        '
        Me.btnButter1.Location = New System.Drawing.Point(11, 162)
        Me.btnButter1.Name = "btnButter1"
        Me.btnButter1.Size = New System.Drawing.Size(109, 23)
        Me.btnButter1.TabIndex = 40
        Me.btnButter1.Text = "Button 1"
        Me.btnButter1.UseVisualStyleBackColor = True
        '
        'btnButter2
        '
        Me.btnButter2.Location = New System.Drawing.Point(126, 162)
        Me.btnButter2.Name = "btnButter2"
        Me.btnButter2.Size = New System.Drawing.Size(109, 23)
        Me.btnButter2.TabIndex = 41
        Me.btnButter2.Text = "Button 2"
        Me.btnButter2.UseVisualStyleBackColor = True
        '
        'btnButter3
        '
        Me.btnButter3.Location = New System.Drawing.Point(241, 162)
        Me.btnButter3.Name = "btnButter3"
        Me.btnButter3.Size = New System.Drawing.Size(109, 23)
        Me.btnButter3.TabIndex = 43
        Me.btnButter3.Text = "Button 3"
        Me.btnButter3.UseVisualStyleBackColor = True
        '
        'btnButter4
        '
        Me.btnButter4.Location = New System.Drawing.Point(356, 162)
        Me.btnButter4.Name = "btnButter4"
        Me.btnButter4.Size = New System.Drawing.Size(109, 23)
        Me.btnButter4.TabIndex = 44
        Me.btnButter4.Text = "Button 4"
        Me.btnButter4.UseVisualStyleBackColor = True
        '
        'btnButter5
        '
        Me.btnButter5.Location = New System.Drawing.Point(471, 162)
        Me.btnButter5.Name = "btnButter5"
        Me.btnButter5.Size = New System.Drawing.Size(109, 23)
        Me.btnButter5.TabIndex = 45
        Me.btnButter5.Text = "Button 5"
        Me.btnButter5.UseVisualStyleBackColor = True
        '
        'TbxIDSelector
        '
        Me.TbxIDSelector.Location = New System.Drawing.Point(706, 44)
        Me.TbxIDSelector.Margin = New System.Windows.Forms.Padding(2)
        Me.TbxIDSelector.Name = "TbxIDSelector"
        Me.TbxIDSelector.ReadOnly = True
        Me.TbxIDSelector.Size = New System.Drawing.Size(28, 20)
        Me.TbxIDSelector.TabIndex = 500
        Me.TbxIDSelector.TabStop = False
        Me.TbxIDSelector.WordWrap = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(704, 28)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(18, 13)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "ID"
        '
        'DgvTempCollection
        '
        Me.DgvTempCollection.AllowUserToAddRows = False
        Me.DgvTempCollection.AllowUserToDeleteRows = False
        Me.DgvTempCollection.AllowUserToOrderColumns = True
        Me.DgvTempCollection.AllowUserToResizeRows = False
        Me.DgvTempCollection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTempCollection.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvTempCollection.Location = New System.Drawing.Point(4, 461)
        Me.DgvTempCollection.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvTempCollection.MultiSelect = False
        Me.DgvTempCollection.Name = "DgvTempCollection"
        Me.DgvTempCollection.ReadOnly = True
        Me.DgvTempCollection.RowHeadersVisible = False
        Me.DgvTempCollection.RowHeadersWidth = 51
        Me.DgvTempCollection.RowTemplate.Height = 24
        Me.DgvTempCollection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvTempCollection.Size = New System.Drawing.Size(810, 126)
        Me.DgvTempCollection.TabIndex = 501
        '
        'BtnCollection
        '
        Me.BtnCollection.Location = New System.Drawing.Point(89, 113)
        Me.BtnCollection.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCollection.Name = "BtnCollection"
        Me.BtnCollection.Size = New System.Drawing.Size(108, 23)
        Me.BtnCollection.TabIndex = 502
        Me.BtnCollection.Text = "Add to Collection"
        Me.BtnCollection.UseCompatibleTextRendering = True
        Me.BtnCollection.UseVisualStyleBackColor = True
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.Controls.Add(Me.Label43)
        Me.Panel3.Location = New System.Drawing.Point(4, 591)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(810, 23)
        Me.Panel3.TabIndex = 56
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(5, 6)
        Me.Label43.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(93, 13)
        Me.Label43.TabIndex = 58
        Me.Label43.Text = "Collection Statistic"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label13.Location = New System.Drawing.Point(639, 596)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 13)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Fat"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label27.Location = New System.Drawing.Point(577, 596)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(35, 13)
        Me.Label27.TabIndex = 54
        Me.Label27.Text = "Sugar"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label29.Location = New System.Drawing.Point(516, 596)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(34, 13)
        Me.Label29.TabIndex = 53
        Me.Label29.Text = "Carbs"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label35.Location = New System.Drawing.Point(447, 596)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(45, 13)
        Me.Label35.TabIndex = 52
        Me.Label35.Text = "Proteins"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label37.Location = New System.Drawing.Point(370, 596)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(44, 13)
        Me.Label37.TabIndex = 51
        Me.Label37.Text = "Calories"
        '
        'TbxCollectionName
        '
        Me.TbxCollectionName.Location = New System.Drawing.Point(4, 697)
        Me.TbxCollectionName.Margin = New System.Windows.Forms.Padding(2)
        Me.TbxCollectionName.Name = "TbxCollectionName"
        Me.TbxCollectionName.Size = New System.Drawing.Size(222, 20)
        Me.TbxCollectionName.TabIndex = 56
        '
        'CbxSplitAmount
        '
        Me.CbxSplitAmount.FormattingEnabled = True
        Me.CbxSplitAmount.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.CbxSplitAmount.Location = New System.Drawing.Point(229, 696)
        Me.CbxSplitAmount.Margin = New System.Windows.Forms.Padding(2)
        Me.CbxSplitAmount.Name = "CbxSplitAmount"
        Me.CbxSplitAmount.Size = New System.Drawing.Size(42, 21)
        Me.CbxSplitAmount.TabIndex = 57
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label41.Location = New System.Drawing.Point(286, 596)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(41, 13)
        Me.Label41.TabIndex = 57
        Me.Label41.Text = "Weight"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(2, 720)
        Me.Label42.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(35, 13)
        Me.Label42.TabIndex = 503
        Me.Label42.Text = "Name"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel4.Controls.Add(Me.Label44)
        Me.Panel4.Controls.Add(Me.LblCurrentCollectionTotalWeight)
        Me.Panel4.Controls.Add(Me.LblCurrentCollectionTotalFat)
        Me.Panel4.Controls.Add(Me.LblCurrentCollectionTotalSug)
        Me.Panel4.Controls.Add(Me.LblCurrentCollectionTotalCarb)
        Me.Panel4.Controls.Add(Me.LblCurrentCollectionTotalProt)
        Me.Panel4.Controls.Add(Me.LblCurrentCollectionTotalCal)
        Me.Panel4.Location = New System.Drawing.Point(4, 617)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(810, 23)
        Me.Panel4.TabIndex = 59
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(5, 6)
        Me.Label44.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(68, 13)
        Me.Label44.TabIndex = 58
        Me.Label44.Text = "Current Total"
        '
        'LblCurrentCollectionTotalWeight
        '
        Me.LblCurrentCollectionTotalWeight.AutoSize = True
        Me.LblCurrentCollectionTotalWeight.BackColor = System.Drawing.Color.BurlyWood
        Me.LblCurrentCollectionTotalWeight.Location = New System.Drawing.Point(282, 6)
        Me.LblCurrentCollectionTotalWeight.Name = "LblCurrentCollectionTotalWeight"
        Me.LblCurrentCollectionTotalWeight.Size = New System.Drawing.Size(13, 13)
        Me.LblCurrentCollectionTotalWeight.TabIndex = 56
        Me.LblCurrentCollectionTotalWeight.Text = "0"
        '
        'LblCurrentCollectionTotalFat
        '
        Me.LblCurrentCollectionTotalFat.AutoSize = True
        Me.LblCurrentCollectionTotalFat.BackColor = System.Drawing.Color.BurlyWood
        Me.LblCurrentCollectionTotalFat.Location = New System.Drawing.Point(635, 6)
        Me.LblCurrentCollectionTotalFat.Name = "LblCurrentCollectionTotalFat"
        Me.LblCurrentCollectionTotalFat.Size = New System.Drawing.Size(13, 13)
        Me.LblCurrentCollectionTotalFat.TabIndex = 4
        Me.LblCurrentCollectionTotalFat.Text = "0"
        '
        'LblCurrentCollectionTotalSug
        '
        Me.LblCurrentCollectionTotalSug.AutoSize = True
        Me.LblCurrentCollectionTotalSug.BackColor = System.Drawing.Color.BurlyWood
        Me.LblCurrentCollectionTotalSug.Location = New System.Drawing.Point(573, 6)
        Me.LblCurrentCollectionTotalSug.Name = "LblCurrentCollectionTotalSug"
        Me.LblCurrentCollectionTotalSug.Size = New System.Drawing.Size(13, 13)
        Me.LblCurrentCollectionTotalSug.TabIndex = 3
        Me.LblCurrentCollectionTotalSug.Text = "0"
        '
        'LblCurrentCollectionTotalCarb
        '
        Me.LblCurrentCollectionTotalCarb.AutoSize = True
        Me.LblCurrentCollectionTotalCarb.BackColor = System.Drawing.Color.BurlyWood
        Me.LblCurrentCollectionTotalCarb.Location = New System.Drawing.Point(512, 6)
        Me.LblCurrentCollectionTotalCarb.Name = "LblCurrentCollectionTotalCarb"
        Me.LblCurrentCollectionTotalCarb.Size = New System.Drawing.Size(13, 13)
        Me.LblCurrentCollectionTotalCarb.TabIndex = 2
        Me.LblCurrentCollectionTotalCarb.Text = "0"
        '
        'LblCurrentCollectionTotalProt
        '
        Me.LblCurrentCollectionTotalProt.AutoSize = True
        Me.LblCurrentCollectionTotalProt.BackColor = System.Drawing.Color.BurlyWood
        Me.LblCurrentCollectionTotalProt.Location = New System.Drawing.Point(443, 6)
        Me.LblCurrentCollectionTotalProt.Name = "LblCurrentCollectionTotalProt"
        Me.LblCurrentCollectionTotalProt.Size = New System.Drawing.Size(13, 13)
        Me.LblCurrentCollectionTotalProt.TabIndex = 1
        Me.LblCurrentCollectionTotalProt.Text = "0"
        '
        'LblCurrentCollectionTotalCal
        '
        Me.LblCurrentCollectionTotalCal.AutoSize = True
        Me.LblCurrentCollectionTotalCal.BackColor = System.Drawing.Color.BurlyWood
        Me.LblCurrentCollectionTotalCal.Location = New System.Drawing.Point(366, 6)
        Me.LblCurrentCollectionTotalCal.Name = "LblCurrentCollectionTotalCal"
        Me.LblCurrentCollectionTotalCal.Size = New System.Drawing.Size(13, 13)
        Me.LblCurrentCollectionTotalCal.TabIndex = 0
        Me.LblCurrentCollectionTotalCal.Text = "0"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel5.Controls.Add(Me.Label51)
        Me.Panel5.Controls.Add(Me.LblCurrentCollectionXgFat)
        Me.Panel5.Controls.Add(Me.LblCurrentCollectionXgSug)
        Me.Panel5.Controls.Add(Me.LblCurrentCollectionXgCarb)
        Me.Panel5.Controls.Add(Me.LblCurrentCollectionXgProt)
        Me.Panel5.Controls.Add(Me.LblCurrentCollectionXgCal)
        Me.Panel5.Location = New System.Drawing.Point(4, 643)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(810, 23)
        Me.Panel5.TabIndex = 60
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(5, 6)
        Me.Label51.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(78, 13)
        Me.Label51.TabIndex = 58
        Me.Label51.Text = "Current x/100g"
        '
        'LblCurrentCollectionXgFat
        '
        Me.LblCurrentCollectionXgFat.AutoSize = True
        Me.LblCurrentCollectionXgFat.BackColor = System.Drawing.Color.BurlyWood
        Me.LblCurrentCollectionXgFat.Location = New System.Drawing.Point(635, 6)
        Me.LblCurrentCollectionXgFat.Name = "LblCurrentCollectionXgFat"
        Me.LblCurrentCollectionXgFat.Size = New System.Drawing.Size(13, 13)
        Me.LblCurrentCollectionXgFat.TabIndex = 4
        Me.LblCurrentCollectionXgFat.Text = "0"
        '
        'LblCurrentCollectionXgSug
        '
        Me.LblCurrentCollectionXgSug.AutoSize = True
        Me.LblCurrentCollectionXgSug.BackColor = System.Drawing.Color.BurlyWood
        Me.LblCurrentCollectionXgSug.Location = New System.Drawing.Point(573, 6)
        Me.LblCurrentCollectionXgSug.Name = "LblCurrentCollectionXgSug"
        Me.LblCurrentCollectionXgSug.Size = New System.Drawing.Size(13, 13)
        Me.LblCurrentCollectionXgSug.TabIndex = 3
        Me.LblCurrentCollectionXgSug.Text = "0"
        '
        'LblCurrentCollectionXgCarb
        '
        Me.LblCurrentCollectionXgCarb.AutoSize = True
        Me.LblCurrentCollectionXgCarb.BackColor = System.Drawing.Color.BurlyWood
        Me.LblCurrentCollectionXgCarb.Location = New System.Drawing.Point(512, 6)
        Me.LblCurrentCollectionXgCarb.Name = "LblCurrentCollectionXgCarb"
        Me.LblCurrentCollectionXgCarb.Size = New System.Drawing.Size(13, 13)
        Me.LblCurrentCollectionXgCarb.TabIndex = 2
        Me.LblCurrentCollectionXgCarb.Text = "0"
        '
        'LblCurrentCollectionXgProt
        '
        Me.LblCurrentCollectionXgProt.AutoSize = True
        Me.LblCurrentCollectionXgProt.BackColor = System.Drawing.Color.BurlyWood
        Me.LblCurrentCollectionXgProt.Location = New System.Drawing.Point(443, 6)
        Me.LblCurrentCollectionXgProt.Name = "LblCurrentCollectionXgProt"
        Me.LblCurrentCollectionXgProt.Size = New System.Drawing.Size(13, 13)
        Me.LblCurrentCollectionXgProt.TabIndex = 1
        Me.LblCurrentCollectionXgProt.Text = "0"
        '
        'LblCurrentCollectionXgCal
        '
        Me.LblCurrentCollectionXgCal.AutoSize = True
        Me.LblCurrentCollectionXgCal.BackColor = System.Drawing.Color.BurlyWood
        Me.LblCurrentCollectionXgCal.Location = New System.Drawing.Point(366, 6)
        Me.LblCurrentCollectionXgCal.Name = "LblCurrentCollectionXgCal"
        Me.LblCurrentCollectionXgCal.Size = New System.Drawing.Size(13, 13)
        Me.LblCurrentCollectionXgCal.TabIndex = 0
        Me.LblCurrentCollectionXgCal.Text = "0"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel6.Controls.Add(Me.Label58)
        Me.Panel6.Controls.Add(Me.TbxCollectionWeight)
        Me.Panel6.Controls.Add(Me.LblCurrentCollectionCurrentFat)
        Me.Panel6.Controls.Add(Me.LblCurrentCollectionCurrentSug)
        Me.Panel6.Controls.Add(Me.LblCurrentCollectionCurrentCarb)
        Me.Panel6.Controls.Add(Me.LblCurrentCollectionCurrentProt)
        Me.Panel6.Controls.Add(Me.LblCurrentCollectionCurrentCal)
        Me.Panel6.Location = New System.Drawing.Point(4, 669)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(810, 23)
        Me.Panel6.TabIndex = 61
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(5, 6)
        Me.Label58.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(95, 13)
        Me.Label58.TabIndex = 58
        Me.Label58.Text = "Current calculation"
        '
        'TbxCollectionWeight
        '
        Me.TbxCollectionWeight.Location = New System.Drawing.Point(272, 1)
        Me.TbxCollectionWeight.Margin = New System.Windows.Forms.Padding(2)
        Me.TbxCollectionWeight.Name = "TbxCollectionWeight"
        Me.TbxCollectionWeight.Size = New System.Drawing.Size(56, 20)
        Me.TbxCollectionWeight.TabIndex = 504
        '
        'LblCurrentCollectionCurrentFat
        '
        Me.LblCurrentCollectionCurrentFat.AutoSize = True
        Me.LblCurrentCollectionCurrentFat.BackColor = System.Drawing.Color.BurlyWood
        Me.LblCurrentCollectionCurrentFat.Location = New System.Drawing.Point(635, 6)
        Me.LblCurrentCollectionCurrentFat.Name = "LblCurrentCollectionCurrentFat"
        Me.LblCurrentCollectionCurrentFat.Size = New System.Drawing.Size(13, 13)
        Me.LblCurrentCollectionCurrentFat.TabIndex = 4
        Me.LblCurrentCollectionCurrentFat.Text = "0"
        '
        'LblCurrentCollectionCurrentSug
        '
        Me.LblCurrentCollectionCurrentSug.AutoSize = True
        Me.LblCurrentCollectionCurrentSug.BackColor = System.Drawing.Color.BurlyWood
        Me.LblCurrentCollectionCurrentSug.Location = New System.Drawing.Point(573, 6)
        Me.LblCurrentCollectionCurrentSug.Name = "LblCurrentCollectionCurrentSug"
        Me.LblCurrentCollectionCurrentSug.Size = New System.Drawing.Size(13, 13)
        Me.LblCurrentCollectionCurrentSug.TabIndex = 3
        Me.LblCurrentCollectionCurrentSug.Text = "0"
        '
        'LblCurrentCollectionCurrentCarb
        '
        Me.LblCurrentCollectionCurrentCarb.AutoSize = True
        Me.LblCurrentCollectionCurrentCarb.BackColor = System.Drawing.Color.BurlyWood
        Me.LblCurrentCollectionCurrentCarb.Location = New System.Drawing.Point(512, 6)
        Me.LblCurrentCollectionCurrentCarb.Name = "LblCurrentCollectionCurrentCarb"
        Me.LblCurrentCollectionCurrentCarb.Size = New System.Drawing.Size(13, 13)
        Me.LblCurrentCollectionCurrentCarb.TabIndex = 2
        Me.LblCurrentCollectionCurrentCarb.Text = "0"
        '
        'LblCurrentCollectionCurrentProt
        '
        Me.LblCurrentCollectionCurrentProt.AutoSize = True
        Me.LblCurrentCollectionCurrentProt.BackColor = System.Drawing.Color.BurlyWood
        Me.LblCurrentCollectionCurrentProt.Location = New System.Drawing.Point(443, 6)
        Me.LblCurrentCollectionCurrentProt.Name = "LblCurrentCollectionCurrentProt"
        Me.LblCurrentCollectionCurrentProt.Size = New System.Drawing.Size(13, 13)
        Me.LblCurrentCollectionCurrentProt.TabIndex = 1
        Me.LblCurrentCollectionCurrentProt.Text = "0"
        '
        'LblCurrentCollectionCurrentCal
        '
        Me.LblCurrentCollectionCurrentCal.AutoSize = True
        Me.LblCurrentCollectionCurrentCal.BackColor = System.Drawing.Color.BurlyWood
        Me.LblCurrentCollectionCurrentCal.Location = New System.Drawing.Point(366, 6)
        Me.LblCurrentCollectionCurrentCal.Name = "LblCurrentCollectionCurrentCal"
        Me.LblCurrentCollectionCurrentCal.Size = New System.Drawing.Size(13, 13)
        Me.LblCurrentCollectionCurrentCal.TabIndex = 0
        Me.LblCurrentCollectionCurrentCal.Text = "0"
        '
        'BtnCollectionSubmit
        '
        Me.BtnCollectionSubmit.Location = New System.Drawing.Point(276, 699)
        Me.BtnCollectionSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCollectionSubmit.Name = "BtnCollectionSubmit"
        Me.BtnCollectionSubmit.Size = New System.Drawing.Size(56, 19)
        Me.BtnCollectionSubmit.TabIndex = 505
        Me.BtnCollectionSubmit.Text = "Submit"
        Me.BtnCollectionSubmit.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(228, 721)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(197, 13)
        Me.Label28.TabIndex = 506
        Me.Label28.Text = "Split into X Amount of meals over X days"
        '
        'LblDGVDeleteSelector
        '
        Me.LblDGVDeleteSelector.AutoSize = True
        Me.LblDGVDeleteSelector.Location = New System.Drawing.Point(656, 148)
        Me.LblDGVDeleteSelector.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDGVDeleteSelector.Name = "LblDGVDeleteSelector"
        Me.LblDGVDeleteSelector.Size = New System.Drawing.Size(75, 13)
        Me.LblDGVDeleteSelector.TabIndex = 507
        Me.LblDGVDeleteSelector.Text = "Selected: N/A"
        '
        'BtnClearCollection
        '
        Me.BtnClearCollection.Location = New System.Drawing.Point(706, 697)
        Me.BtnClearCollection.Name = "BtnClearCollection"
        Me.BtnClearCollection.Size = New System.Drawing.Size(109, 23)
        Me.BtnClearCollection.TabIndex = 508
        Me.BtnClearCollection.Text = "Clear Collection"
        Me.BtnClearCollection.UseVisualStyleBackColor = True
        '
        'DtpDateSelector
        '
        Me.DtpDateSelector.CustomFormat = "dd.MM.yyyy"
        Me.DtpDateSelector.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpDateSelector.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DtpDateSelector.Location = New System.Drawing.Point(739, 45)
        Me.DtpDateSelector.Name = "DtpDateSelector"
        Me.DtpDateSelector.Size = New System.Drawing.Size(75, 20)
        Me.DtpDateSelector.TabIndex = 509
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(736, 28)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(30, 13)
        Me.Label34.TabIndex = 510
        Me.Label34.Text = "Date"
        '
        'CbPlus1
        '
        Me.CbPlus1.AutoSize = True
        Me.CbPlus1.Location = New System.Drawing.Point(333, 699)
        Me.CbPlus1.Name = "CbPlus1"
        Me.CbPlus1.Size = New System.Drawing.Size(63, 17)
        Me.CbPlus1.TabIndex = 513
        Me.CbPlus1.Text = "+ 1 Day"
        Me.CbPlus1.UseVisualStyleBackColor = True
        '
        'LblRecipeList
        '
        Me.LblRecipeList.AutoSize = True
        Me.LblRecipeList.BackColor = System.Drawing.Color.Gold
        Me.LblRecipeList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblRecipeList.Location = New System.Drawing.Point(107, 28)
        Me.LblRecipeList.Name = "LblRecipeList"
        Me.LblRecipeList.Size = New System.Drawing.Size(60, 13)
        Me.LblRecipeList.TabIndex = 514
        Me.LblRecipeList.Text = "Recipe List"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1233, 737)
        Me.Controls.Add(Me.LblRecipeList)
        Me.Controls.Add(Me.CbPlus1)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.DtpDateSelector)
        Me.Controls.Add(Me.BtnClearCollection)
        Me.Controls.Add(Me.LblDGVDeleteSelector)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.BtnCollectionSubmit)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.CbxSplitAmount)
        Me.Controls.Add(Me.TbxCollectionName)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BtnCollection)
        Me.Controls.Add(Me.DgvTempCollection)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TbxIDSelector)
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
        Me.Controls.Add(Me.BtnClearTbx)
        Me.Controls.Add(Me.LblFoodList)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatisticBox)
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
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatisticBox.ResumeLayout(False)
        CType(Me.DgvStatistic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvTempList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DgvTempCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCS_V3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodHistorytableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodHistorytableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
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
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblCurrentCalcFat As Label
    Friend WithEvents lblCurrentCalcSug As Label
    Friend WithEvents lblCurrentCalcCarbs As Label
    Friend WithEvents lblCurrentCalcProt As Label
    Friend WithEvents lblCurrentCalcCal As Label
    Friend WithEvents LblFoodList As Label
    Friend WithEvents BtnClearTbx As Button
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
    Friend WithEvents TbxIDSelector As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents DgvTempCollection As DataGridView
    Friend WithEvents BtnCollection As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents TbxCollectionName As TextBox
    Friend WithEvents CbxSplitAmount As ComboBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label44 As Label
    Friend WithEvents LblCurrentCollectionTotalWeight As Label
    Friend WithEvents LblCurrentCollectionTotalFat As Label
    Friend WithEvents LblCurrentCollectionTotalSug As Label
    Friend WithEvents LblCurrentCollectionTotalCarb As Label
    Friend WithEvents LblCurrentCollectionTotalProt As Label
    Friend WithEvents LblCurrentCollectionTotalCal As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label51 As Label
    Friend WithEvents LblCurrentCollectionXgFat As Label
    Friend WithEvents LblCurrentCollectionXgSug As Label
    Friend WithEvents LblCurrentCollectionXgCarb As Label
    Friend WithEvents LblCurrentCollectionXgProt As Label
    Friend WithEvents LblCurrentCollectionXgCal As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label58 As Label
    Friend WithEvents LblCurrentCollectionCurrentFat As Label
    Friend WithEvents LblCurrentCollectionCurrentSug As Label
    Friend WithEvents LblCurrentCollectionCurrentCarb As Label
    Friend WithEvents LblCurrentCollectionCurrentProt As Label
    Friend WithEvents LblCurrentCollectionCurrentCal As Label
    Friend WithEvents TbxCollectionWeight As TextBox
    Friend WithEvents BtnCollectionSubmit As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents LblDGVDeleteSelector As Label
    Friend WithEvents BtnClearCollection As Button
    Friend WithEvents BtnToday As Button
    Friend WithEvents LblNewFat As Label
    Friend WithEvents LblNewSug As Label
    Friend WithEvents LblNewCarb As Label
    Friend WithEvents LblNewProt As Label
    Friend WithEvents LblNewCal As Label
    Friend WithEvents LblNewSumFat As Label
    Friend WithEvents LblNewSumSug As Label
    Friend WithEvents LblNewSumCarb As Label
    Friend WithEvents LblNewSumProt As Label
    Friend WithEvents LblNewSumCal As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label32 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TbxWeightCurrent As TextBox
    Friend WithEvents BtnSubtmitWeight As Button
    Friend WithEvents LblWeekAverageWeightP1 As Label
    Friend WithEvents LblWeekAverageCaloriesP1 As Label
    Friend WithEvents LblWeekAverageProteinP1 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents LblWeekAverageCarbsP1 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents LblTrendWeight As Label
    Friend WithEvents LblTrendCal As Label
    Friend WithEvents LblTrendProt As Label
    Friend WithEvents LblTrendCarb As Label
    Friend WithEvents LblTrendFat As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents TbxGoalWeight As TextBox
    Friend WithEvents TbxGoalCal As TextBox
    Friend WithEvents TbxGoalProt As TextBox
    Friend WithEvents TbxGoalCarb As TextBox
    Friend WithEvents TbxGoalFat As TextBox
    Friend WithEvents LblWeekAverageWeightP2 As Label
    Friend WithEvents LblWeekAverageCaloriesP2 As Label
    Friend WithEvents LblWeekAverageCarbsP2 As Label
    Friend WithEvents LblWeekAverageProteinP2 As Label
    Friend WithEvents LblWeekAverageFatP1 As Label
    Friend WithEvents LblWeekAverageFatP2 As Label
    Friend WithEvents TbxCaloriesCurrent As TextBox
    Friend WithEvents TbxProteinCurrent As TextBox
    Friend WithEvents TbxCarbsCurrent As TextBox
    Friend WithEvents TbxFatCurrent As TextBox
    Friend WithEvents BtnBodyMessures As Button
    Friend WithEvents DtpDateSelector As DateTimePicker
    Friend WithEvents Label34 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CbPlus1 As CheckBox
    Friend WithEvents DgvStatistic As DataGridView
    Friend WithEvents LblRecipeList As Label
End Class
