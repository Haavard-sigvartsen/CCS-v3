<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FoodList
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FoodList))
        Me.Food_TableDataGridView = New System.Windows.Forms.DataGridView()
        Me.TbxFoodImportSug = New System.Windows.Forms.TextBox()
        Me.TbxFoodImportFat = New System.Windows.Forms.TextBox()
        Me.TbxFoodImportCarb = New System.Windows.Forms.TextBox()
        Me.TbxFoodImportProt = New System.Windows.Forms.TextBox()
        Me.TbxFoodImportCal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbxFoodImportBrand = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbxFoodImportName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnFoodImportButton = New System.Windows.Forms.Button()
        Me.TbxSearchName = New System.Windows.Forms.TextBox()
        Me.TbxSearchBrand = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblImportStatus = New System.Windows.Forms.Label()
        Me.BtnFoodUpdate = New System.Windows.Forms.Button()
        Me.BtnClearTbx = New System.Windows.Forms.Button()
        Me.BtnFoodDelete = New System.Windows.Forms.Button()
        Me.CCS_V3DataSet = New CCS_v3.CCS_V3DataSet()
        Me.Food_TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Food_TableTableAdapter = New CCS_v3.CCS_V3DataSetTableAdapters.Food_TableTableAdapter()
        Me.TableAdapterManager = New CCS_v3.CCS_V3DataSetTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Food_TableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CCS_V3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Food_TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Food_TableDataGridView
        '
        Me.Food_TableDataGridView.AllowDrop = True
        Me.Food_TableDataGridView.AllowUserToAddRows = False
        Me.Food_TableDataGridView.AllowUserToDeleteRows = False
        Me.Food_TableDataGridView.AllowUserToOrderColumns = True
        Me.Food_TableDataGridView.AllowUserToResizeColumns = False
        Me.Food_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Food_TableDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Food_TableDataGridView.Location = New System.Drawing.Point(0, 134)
        Me.Food_TableDataGridView.MultiSelect = False
        Me.Food_TableDataGridView.Name = "Food_TableDataGridView"
        Me.Food_TableDataGridView.RowHeadersVisible = False
        Me.Food_TableDataGridView.RowHeadersWidth = 51
        Me.Food_TableDataGridView.Size = New System.Drawing.Size(748, 317)
        Me.Food_TableDataGridView.TabIndex = 100
        '
        'TbxFoodImportSug
        '
        Me.TbxFoodImportSug.Location = New System.Drawing.Point(473, 25)
        Me.TbxFoodImportSug.Name = "TbxFoodImportSug"
        Me.TbxFoodImportSug.Size = New System.Drawing.Size(52, 20)
        Me.TbxFoodImportSug.TabIndex = 6
        '
        'TbxFoodImportFat
        '
        Me.TbxFoodImportFat.Location = New System.Drawing.Point(531, 25)
        Me.TbxFoodImportFat.Name = "TbxFoodImportFat"
        Me.TbxFoodImportFat.Size = New System.Drawing.Size(52, 20)
        Me.TbxFoodImportFat.TabIndex = 7
        '
        'TbxFoodImportCarb
        '
        Me.TbxFoodImportCarb.Location = New System.Drawing.Point(415, 25)
        Me.TbxFoodImportCarb.Name = "TbxFoodImportCarb"
        Me.TbxFoodImportCarb.Size = New System.Drawing.Size(52, 20)
        Me.TbxFoodImportCarb.TabIndex = 5
        '
        'TbxFoodImportProt
        '
        Me.TbxFoodImportProt.Location = New System.Drawing.Point(357, 25)
        Me.TbxFoodImportProt.Name = "TbxFoodImportProt"
        Me.TbxFoodImportProt.Size = New System.Drawing.Size(52, 20)
        Me.TbxFoodImportProt.TabIndex = 4
        '
        'TbxFoodImportCal
        '
        Me.TbxFoodImportCal.Location = New System.Drawing.Point(299, 25)
        Me.TbxFoodImportCal.Name = "TbxFoodImportCal"
        Me.TbxFoodImportCal.Size = New System.Drawing.Size(52, 20)
        Me.TbxFoodImportCal.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Location = New System.Drawing.Point(528, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Fat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Location = New System.Drawing.Point(470, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Sugar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(412, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Carbs"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(357, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Proteins"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(296, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Calories"
        '
        'TbxFoodImportBrand
        '
        Me.TbxFoodImportBrand.Location = New System.Drawing.Point(175, 25)
        Me.TbxFoodImportBrand.Name = "TbxFoodImportBrand"
        Me.TbxFoodImportBrand.Size = New System.Drawing.Size(115, 20)
        Me.TbxFoodImportBrand.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(172, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Brand"
        '
        'TbxFoodImportName
        '
        Me.TbxFoodImportName.Location = New System.Drawing.Point(8, 25)
        Me.TbxFoodImportName.Name = "TbxFoodImportName"
        Me.TbxFoodImportName.Size = New System.Drawing.Size(161, 20)
        Me.TbxFoodImportName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Name"
        '
        'BtnFoodImportButton
        '
        Me.BtnFoodImportButton.Location = New System.Drawing.Point(8, 51)
        Me.BtnFoodImportButton.Name = "BtnFoodImportButton"
        Me.BtnFoodImportButton.Size = New System.Drawing.Size(54, 23)
        Me.BtnFoodImportButton.TabIndex = 8
        Me.BtnFoodImportButton.Text = "Import"
        Me.BtnFoodImportButton.UseVisualStyleBackColor = True
        '
        'TbxSearchName
        '
        Me.TbxSearchName.Location = New System.Drawing.Point(24, 97)
        Me.TbxSearchName.Name = "TbxSearchName"
        Me.TbxSearchName.Size = New System.Drawing.Size(100, 20)
        Me.TbxSearchName.TabIndex = 39
        '
        'TbxSearchBrand
        '
        Me.TbxSearchBrand.Location = New System.Drawing.Point(122, 16)
        Me.TbxSearchBrand.Name = "TbxSearchBrand"
        Me.TbxSearchBrand.Size = New System.Drawing.Size(94, 20)
        Me.TbxSearchBrand.TabIndex = 40
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TbxSearchBrand)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 47)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Name Or Brand"
        '
        'LblImportStatus
        '
        Me.LblImportStatus.AutoSize = True
        Me.LblImportStatus.ForeColor = System.Drawing.Color.Green
        Me.LblImportStatus.Location = New System.Drawing.Point(126, 56)
        Me.LblImportStatus.Name = "LblImportStatus"
        Me.LblImportStatus.Size = New System.Drawing.Size(43, 13)
        Me.LblImportStatus.TabIndex = 42
        Me.LblImportStatus.Text = "Status: "
        '
        'BtnFoodUpdate
        '
        Me.BtnFoodUpdate.Location = New System.Drawing.Point(63, 51)
        Me.BtnFoodUpdate.Name = "BtnFoodUpdate"
        Me.BtnFoodUpdate.Size = New System.Drawing.Size(57, 23)
        Me.BtnFoodUpdate.TabIndex = 9
        Me.BtnFoodUpdate.Text = "Update"
        Me.BtnFoodUpdate.UseVisualStyleBackColor = True
        '
        'BtnClearTbx
        '
        Me.BtnClearTbx.Location = New System.Drawing.Point(599, 22)
        Me.BtnClearTbx.Name = "BtnClearTbx"
        Me.BtnClearTbx.Size = New System.Drawing.Size(75, 23)
        Me.BtnClearTbx.TabIndex = 10
        Me.BtnClearTbx.Text = "Clear"
        Me.BtnClearTbx.UseVisualStyleBackColor = True
        '
        'BtnFoodDelete
        '
        Me.BtnFoodDelete.Location = New System.Drawing.Point(599, 97)
        Me.BtnFoodDelete.Name = "BtnFoodDelete"
        Me.BtnFoodDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnFoodDelete.TabIndex = 45
        Me.BtnFoodDelete.Text = "Delete"
        Me.BtnFoodDelete.UseVisualStyleBackColor = True
        '
        'CCS_V3DataSet
        '
        Me.CCS_V3DataSet.CaseSensitive = True
        Me.CCS_V3DataSet.DataSetName = "CCS_V3DataSet"
        Me.CCS_V3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Food_TableBindingSource
        '
        Me.Food_TableBindingSource.DataMember = "Food_Table"
        Me.Food_TableBindingSource.DataSource = Me.CCS_V3DataSet
        '
        'Food_TableTableAdapter
        '
        Me.Food_TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Food_History_tableTableAdapter = Nothing
        Me.TableAdapterManager.Food_TableTableAdapter = Me.Food_TableTableAdapter
        Me.TableAdapterManager.UpdateOrder = CCS_v3.CCS_V3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Weight_HistoryTableAdapter = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(236, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Double Click to select Item"
        '
        'FoodList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(750, 451)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnFoodDelete)
        Me.Controls.Add(Me.BtnClearTbx)
        Me.Controls.Add(Me.LblImportStatus)
        Me.Controls.Add(Me.BtnFoodUpdate)
        Me.Controls.Add(Me.TbxSearchName)
        Me.Controls.Add(Me.BtnFoodImportButton)
        Me.Controls.Add(Me.TbxFoodImportSug)
        Me.Controls.Add(Me.TbxFoodImportFat)
        Me.Controls.Add(Me.TbxFoodImportCarb)
        Me.Controls.Add(Me.TbxFoodImportProt)
        Me.Controls.Add(Me.TbxFoodImportCal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbxFoodImportBrand)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbxFoodImportName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Food_TableDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FoodList"
        Me.Text = "Item Database"
        CType(Me.Food_TableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CCS_V3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Food_TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CCS_V3DataSet As CCS_V3DataSet
    Friend WithEvents Food_TableBindingSource As BindingSource
    Friend WithEvents Food_TableTableAdapter As CCS_V3DataSetTableAdapters.Food_TableTableAdapter
    Friend WithEvents TableAdapterManager As CCS_V3DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Food_TableDataGridView As DataGridView
    Friend WithEvents TbxFoodImportSug As TextBox
    Friend WithEvents TbxFoodImportFat As TextBox
    Friend WithEvents TbxFoodImportCarb As TextBox
    Friend WithEvents TbxFoodImportProt As TextBox
    Friend WithEvents TbxFoodImportCal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbxFoodImportBrand As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbxFoodImportName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnFoodImportButton As Button
    Friend WithEvents TbxSearchName As TextBox
    Friend WithEvents TbxSearchBrand As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblImportStatus As Label
    Friend WithEvents BtnFoodUpdate As Button
    Friend WithEvents BtnClearTbx As Button
    Friend WithEvents BtnFoodDelete As Button
    Friend WithEvents Label2 As Label
End Class
