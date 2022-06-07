<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe_Book
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recipe_Book))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblRecipeTotalWeight = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblRecipeTotalCalories = New System.Windows.Forms.Label()
        Me.LblRecipeTotalCarbs = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblRecipeTotalProt = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblRecipeTotalSug = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblRecipeName = New System.Windows.Forms.Label()
        Me.LblRecipeTotalFat = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblRecipe100gFat = New System.Windows.Forms.Label()
        Me.LblRecipe100gSug = New System.Windows.Forms.Label()
        Me.LblRecipe100gCarbs = New System.Windows.Forms.Label()
        Me.LblRecipe100gCalories = New System.Windows.Forms.Label()
        Me.LblRecipe100gProt = New System.Windows.Forms.Label()
        Me.LblRecipe100gWeight = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnSubmitCollection = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 16)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(273, 540)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.BurlyWood
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(611, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(279, 559)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Instructions"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.BurlyWood
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.LblRecipe100gFat)
        Me.GroupBox2.Controls.Add(Me.LblRecipe100gSug)
        Me.GroupBox2.Controls.Add(Me.LblRecipe100gCarbs)
        Me.GroupBox2.Controls.Add(Me.LblRecipe100gCalories)
        Me.GroupBox2.Controls.Add(Me.LblRecipe100gProt)
        Me.GroupBox2.Controls.Add(Me.LblRecipe100gWeight)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.LblRecipeTotalFat)
        Me.GroupBox2.Controls.Add(Me.LblRecipeName)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.LblRecipeTotalSug)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.LblRecipeTotalCarbs)
        Me.GroupBox2.Controls.Add(Me.LblRecipeTotalCalories)
        Me.GroupBox2.Controls.Add(Me.LblRecipeTotalProt)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.LblRecipeTotalWeight)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 498)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(593, 73)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nutrient Value"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Weight"
        '
        'LblRecipeTotalWeight
        '
        Me.LblRecipeTotalWeight.AutoSize = True
        Me.LblRecipeTotalWeight.Location = New System.Drawing.Point(81, 35)
        Me.LblRecipeTotalWeight.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.LblRecipeTotalWeight.Name = "LblRecipeTotalWeight"
        Me.LblRecipeTotalWeight.Size = New System.Drawing.Size(39, 13)
        Me.LblRecipeTotalWeight.TabIndex = 4
        Me.LblRecipeTotalWeight.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(150, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Calories"
        '
        'LblRecipeTotalCalories
        '
        Me.LblRecipeTotalCalories.AutoSize = True
        Me.LblRecipeTotalCalories.Location = New System.Drawing.Point(150, 35)
        Me.LblRecipeTotalCalories.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.LblRecipeTotalCalories.Name = "LblRecipeTotalCalories"
        Me.LblRecipeTotalCalories.Size = New System.Drawing.Size(39, 13)
        Me.LblRecipeTotalCalories.TabIndex = 6
        Me.LblRecipeTotalCalories.Text = "Label4"
        '
        'LblRecipeTotalCarbs
        '
        Me.LblRecipeTotalCarbs.AutoSize = True
        Me.LblRecipeTotalCarbs.Location = New System.Drawing.Point(288, 35)
        Me.LblRecipeTotalCarbs.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.LblRecipeTotalCarbs.Name = "LblRecipeTotalCarbs"
        Me.LblRecipeTotalCarbs.Size = New System.Drawing.Size(39, 13)
        Me.LblRecipeTotalCarbs.TabIndex = 7
        Me.LblRecipeTotalCarbs.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(219, 17)
        Me.Label6.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Protein"
        '
        'LblRecipeTotalProt
        '
        Me.LblRecipeTotalProt.AutoSize = True
        Me.LblRecipeTotalProt.Location = New System.Drawing.Point(219, 35)
        Me.LblRecipeTotalProt.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.LblRecipeTotalProt.Name = "LblRecipeTotalProt"
        Me.LblRecipeTotalProt.Size = New System.Drawing.Size(39, 13)
        Me.LblRecipeTotalProt.TabIndex = 9
        Me.LblRecipeTotalProt.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(288, 17)
        Me.Label8.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Carbs"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(357, 17)
        Me.Label9.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Sugar"
        '
        'LblRecipeTotalSug
        '
        Me.LblRecipeTotalSug.AutoSize = True
        Me.LblRecipeTotalSug.Location = New System.Drawing.Point(357, 35)
        Me.LblRecipeTotalSug.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.LblRecipeTotalSug.Name = "LblRecipeTotalSug"
        Me.LblRecipeTotalSug.Size = New System.Drawing.Size(45, 13)
        Me.LblRecipeTotalSug.TabIndex = 12
        Me.LblRecipeTotalSug.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 17)
        Me.Label11.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Name"
        '
        'LblRecipeName
        '
        Me.LblRecipeName.AutoSize = True
        Me.LblRecipeName.Location = New System.Drawing.Point(6, 35)
        Me.LblRecipeName.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.LblRecipeName.Name = "LblRecipeName"
        Me.LblRecipeName.Size = New System.Drawing.Size(45, 13)
        Me.LblRecipeName.TabIndex = 14
        Me.LblRecipeName.Text = "Label12"
        '
        'LblRecipeTotalFat
        '
        Me.LblRecipeTotalFat.AutoSize = True
        Me.LblRecipeTotalFat.Location = New System.Drawing.Point(432, 35)
        Me.LblRecipeTotalFat.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.LblRecipeTotalFat.Name = "LblRecipeTotalFat"
        Me.LblRecipeTotalFat.Size = New System.Drawing.Size(45, 13)
        Me.LblRecipeTotalFat.TabIndex = 15
        Me.LblRecipeTotalFat.Text = "Label13"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(432, 17)
        Me.Label14.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(22, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Fat"
        '
        'LblRecipe100gFat
        '
        Me.LblRecipe100gFat.AutoSize = True
        Me.LblRecipe100gFat.Location = New System.Drawing.Point(432, 53)
        Me.LblRecipe100gFat.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.LblRecipe100gFat.Name = "LblRecipe100gFat"
        Me.LblRecipe100gFat.Size = New System.Drawing.Size(45, 13)
        Me.LblRecipe100gFat.TabIndex = 23
        Me.LblRecipe100gFat.Text = "Label13"
        '
        'LblRecipe100gSug
        '
        Me.LblRecipe100gSug.AutoSize = True
        Me.LblRecipe100gSug.Location = New System.Drawing.Point(357, 53)
        Me.LblRecipe100gSug.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.LblRecipe100gSug.Name = "LblRecipe100gSug"
        Me.LblRecipe100gSug.Size = New System.Drawing.Size(45, 13)
        Me.LblRecipe100gSug.TabIndex = 21
        Me.LblRecipe100gSug.Text = "Label10"
        '
        'LblRecipe100gCarbs
        '
        Me.LblRecipe100gCarbs.AutoSize = True
        Me.LblRecipe100gCarbs.Location = New System.Drawing.Point(288, 53)
        Me.LblRecipe100gCarbs.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.LblRecipe100gCarbs.Name = "LblRecipe100gCarbs"
        Me.LblRecipe100gCarbs.Size = New System.Drawing.Size(39, 13)
        Me.LblRecipe100gCarbs.TabIndex = 19
        Me.LblRecipe100gCarbs.Text = "Label5"
        '
        'LblRecipe100gCalories
        '
        Me.LblRecipe100gCalories.AutoSize = True
        Me.LblRecipe100gCalories.Location = New System.Drawing.Point(150, 53)
        Me.LblRecipe100gCalories.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.LblRecipe100gCalories.Name = "LblRecipe100gCalories"
        Me.LblRecipe100gCalories.Size = New System.Drawing.Size(39, 13)
        Me.LblRecipe100gCalories.TabIndex = 18
        Me.LblRecipe100gCalories.Text = "Label4"
        '
        'LblRecipe100gProt
        '
        Me.LblRecipe100gProt.AutoSize = True
        Me.LblRecipe100gProt.Location = New System.Drawing.Point(219, 53)
        Me.LblRecipe100gProt.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.LblRecipe100gProt.Name = "LblRecipe100gProt"
        Me.LblRecipe100gProt.Size = New System.Drawing.Size(39, 13)
        Me.LblRecipe100gProt.TabIndex = 20
        Me.LblRecipe100gProt.Text = "Label7"
        '
        'LblRecipe100gWeight
        '
        Me.LblRecipe100gWeight.AutoSize = True
        Me.LblRecipe100gWeight.Location = New System.Drawing.Point(81, 53)
        Me.LblRecipe100gWeight.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.LblRecipe100gWeight.Name = "LblRecipe100gWeight"
        Me.LblRecipe100gWeight.Size = New System.Drawing.Size(39, 13)
        Me.LblRecipe100gWeight.TabIndex = 17
        Me.LblRecipe100gWeight.Text = "Label2"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(507, 53)
        Me.Label15.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Per 100/g"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(507, 17)
        Me.Label16.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Micronutrients"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(507, 35)
        Me.Label17.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Total"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(12, 459)
        Me.BtnSubmit.Margin = New System.Windows.Forms.Padding(9)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(64, 33)
        Me.BtnSubmit.TabIndex = 3
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'BtnSubmitCollection
        '
        Me.BtnSubmitCollection.Location = New System.Drawing.Point(94, 459)
        Me.BtnSubmitCollection.Margin = New System.Windows.Forms.Padding(9)
        Me.BtnSubmitCollection.Name = "BtnSubmitCollection"
        Me.BtnSubmitCollection.Size = New System.Drawing.Size(62, 33)
        Me.BtnSubmitCollection.TabIndex = 4
        Me.BtnSubmitCollection.Text = "Submit to Collection"
        Me.BtnSubmitCollection.UseCompatibleTextRendering = True
        Me.BtnSubmitCollection.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(174, 459)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(9)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(62, 33)
        Me.BtnUpdate.TabIndex = 5
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseCompatibleTextRendering = True
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(254, 459)
        Me.Button2.Margin = New System.Windows.Forms.Padding(9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 33)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Submit to Collection"
        Me.Button2.UseCompatibleTextRendering = True
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(537, 459)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(9)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(62, 33)
        Me.BtnDelete.TabIndex = 7
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseCompatibleTextRendering = True
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'Recipe_Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 583)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSubmitCollection)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Recipe_Book"
        Me.Text = "Recipe Book"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LblRecipeTotalFat As Label
    Friend WithEvents LblRecipeName As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LblRecipeTotalSug As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LblRecipeTotalCarbs As Label
    Friend WithEvents LblRecipeTotalCalories As Label
    Friend WithEvents LblRecipeTotalProt As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblRecipeTotalWeight As Label
    Friend WithEvents LblRecipe100gFat As Label
    Friend WithEvents LblRecipe100gSug As Label
    Friend WithEvents LblRecipe100gCarbs As Label
    Friend WithEvents LblRecipe100gCalories As Label
    Friend WithEvents LblRecipe100gProt As Label
    Friend WithEvents LblRecipe100gWeight As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnSubmitCollection As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnDelete As Button
End Class
