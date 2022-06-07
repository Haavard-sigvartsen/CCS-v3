Imports System.Data.SqlClient

Public Class MainMenu
    Private Sub BtnSubmitCalc_Click(sender As Object, e As EventArgs) Handles btnSubmitCalc.Click
        ' Variables for the results of the calulation, TODO: press "enter" to submit
        Dim calTotal As Decimal
        Dim proTotal As Decimal
        Dim carbTotal As Decimal
        Dim sugTotal As Decimal
        Dim fatTotal As Decimal

        ' calculatiing the weight and values of said item and checks if the are all numeric, give you an error message if its not. TODO: error catching for symbols
        If IsNumeric(TbxCalSelector.Text) And IsNumeric(tbxWeightSelector.Text) AndAlso IsNumeric(TbxFatSelector.Text) AndAlso
           IsNumeric(TbxProSelector.Text) AndAlso IsNumeric(TbxCarbSelector.Text) AndAlso IsNumeric(TbxSugSelector.Text) AndAlso
           tbxNameSelector.Text.Trim.Length > 0 Then
            calTotal = TbxCalSelector.Text / 100 * tbxWeightSelector.Text
            proTotal = TbxProSelector.Text / 100 * tbxWeightSelector.Text
            carbTotal = TbxCarbSelector.Text / 100 * tbxWeightSelector.Text
            sugTotal = TbxSugSelector.Text / 100 * tbxWeightSelector.Text
            fatTotal = TbxFatSelector.Text / 100 * tbxWeightSelector.Text


            ' TODO: add History_Weight (Weight) too SQL and adjust code acordingly

            Dim sqlQuery As String = String.Empty
            sqlQuery &= "INSERT INTO [Food_History_table] (Name, Brand, Weight, Calories, Protein, "
            sqlQuery &= "Carbohydrates, Sugar, Fat, Date)"
            sqlQuery &= "VALUES (@History_Name, @History_Brand, @History_Weight, @History_Calories, @History_Protein, @History_Carbohydrates, @History_Sugar, @History_Fat, @History_Date)"
            Using sqlcon As New SqlConnection(My.Settings.CCS_V3ConnectionString)
                Using sqlcmd As SqlCommand = New SqlCommand(sqlQuery, sqlcon)
                    sqlcmd.Parameters.AddWithValue("@History_Name", tbxNameSelector.Text)
                    sqlcmd.Parameters.AddWithValue("@History_Brand", tbxBrandSelector.Text)
                    sqlcmd.Parameters.AddWithValue("@History_Weight", tbxWeightSelector.Text)
                    sqlcmd.Parameters.AddWithValue("@History_Calories", calTotal)
                    sqlcmd.Parameters.AddWithValue("@History_Protein", proTotal)
                    sqlcmd.Parameters.AddWithValue("@History_Carbohydrates", carbTotal)
                    sqlcmd.Parameters.AddWithValue("@History_Sugar", sugTotal)
                    sqlcmd.Parameters.AddWithValue("@History_Fat", fatTotal)
                    sqlcmd.Parameters.AddWithValue("@History_Date", DtpDateSelector.Value)

                    sqlcon.Open() 'opens connections
                    sqlcmd.ExecuteNonQuery() 'Send the new item to database
                    sqlcon.Close() 'closes connections

                End Using
            End Using

            LblStatus.Text = (tbxNameSelector.Text & " added")
            LblStatus.ForeColor = Color.Green

            UpdateGrid()
            UpdateStatistc()
        Else
            MsgBox("you done goof")
        End If
    End Sub

    Private Sub AButtonToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'opens the settings menu for the butter button
        formBTNShortCut.Show()
    End Sub
    Private Sub BtnButter_Click(sender As Object, e As EventArgs) Handles btnButter1.Click
        Dim TempArray() As String = My.Settings.ButterButton1.Split(",")
        Call SubmitButterButton(TempArray(1), TempArray(2), TempArray(3), TempArray(4), TempArray(5), TempArray(6), TempArray(7), TempArray(8))
    End Sub
    Function SubmitButterButton(Name, Brand, Weight, Calories, Proteins, Carbs, Sugar, Fat)
        'Purpose: Primarily for Butter button shortcuts 
        Try
            Dim sqlQuery As String = String.Empty
            sqlQuery &= "INSERT INTO [Food_History_table] (Name, Brand, Weight, Calories, Protein, "
            sqlQuery &= "Carbohydrates, Sugar, Fat, Date)"
            sqlQuery &= "VALUES (@History_Name, @History_Brand, @History_Weight, @History_Calories, @History_Protein, @History_Carbohydrates, @History_Sugar, @History_Fat, @History_Date)"
            Using sqlcon As New SqlConnection(My.Settings.CCS_V3ConnectionString)
                Using sqlcmd As SqlCommand = New SqlCommand(sqlQuery, sqlcon)
                    sqlcmd.Parameters.AddWithValue("@History_Name", Name)
                    sqlcmd.Parameters.AddWithValue("@History_Brand", Brand)
                    sqlcmd.Parameters.AddWithValue("@History_Weight", Weight)
                    sqlcmd.Parameters.AddWithValue("@History_Calories", Calories)
                    sqlcmd.Parameters.AddWithValue("@History_Protein", Proteins)
                    sqlcmd.Parameters.AddWithValue("@History_Carbohydrates", Carbs)
                    sqlcmd.Parameters.AddWithValue("@History_Sugar", Sugar)
                    sqlcmd.Parameters.AddWithValue("@History_Fat", Fat)
                    sqlcmd.Parameters.AddWithValue("@History_Date", dtpStatistic.Value)

                    sqlcon.Open()
                    sqlcmd.ExecuteNonQuery()
                    sqlcon.Close()
                End Using
            End Using
            LblStatus.Text = (Name & " Added successfully")
            LblStatus.ForeColor = Color.Green
        Catch ex As Exception
            MsgBox("There was an error adding the Item from the shortcut buttons; " & ex.Message)
        End Try
        UpdateGrid()
        UpdateStatistc()
        UpdateCollection()
    End Function
    Function InsertFoodHistory(Name As String, Weight As Decimal, Calories As Decimal, Proteins As Decimal, Carbs As Decimal, Sugar As Decimal, Fat As Decimal, Dato As Date)
        'Purpose: Collections, where the date is split and multiple records needs to be inserted
        Try
            Dim sqlQuery As String = String.Empty
            sqlQuery &= "INSERT INTO [Food_History_table] (Name, Brand, Weight, Calories, Protein, "
            sqlQuery &= "Carbohydrates, Sugar, Fat, Date)"
            sqlQuery &= "VALUES (@History_Name, @History_Brand, @History_Weight, @History_Calories, @History_Protein, @History_Carbohydrates, @History_Sugar, @History_Fat, @History_Date)"
            Using sqlcon As New SqlConnection(My.Settings.CCS_V3ConnectionString)
                Using sqlcmd As SqlCommand = New SqlCommand(sqlQuery, sqlcon)
                    sqlcmd.Parameters.AddWithValue("@History_Name", Name)
                    sqlcmd.Parameters.AddWithValue("@History_Brand", "Collection")
                    sqlcmd.Parameters.AddWithValue("@History_Weight", Weight)
                    sqlcmd.Parameters.AddWithValue("@History_Calories", Calories)
                    sqlcmd.Parameters.AddWithValue("@History_Protein", Proteins)
                    sqlcmd.Parameters.AddWithValue("@History_Carbohydrates", Carbs)
                    sqlcmd.Parameters.AddWithValue("@History_Sugar", Sugar)
                    sqlcmd.Parameters.AddWithValue("@History_Fat", Fat)
                    sqlcmd.Parameters.AddWithValue("@History_Date", Dato) ' Date is not allowed, so....

                    sqlcon.Open()
                    sqlcmd.ExecuteNonQuery()
                    sqlcon.Close()
                End Using
            End Using
            LblStatus.Text = (Name & " Added successfully")
            LblStatus.ForeColor = Color.Green
        Catch ex As Exception
            MsgBox("There was an error adding the Item: " & ex.Message)
        End Try

        UpdateGrid()
        UpdateStatistc()
        UpdateCollection()
    End Function

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Check if SQL Local DB is installed
        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions\15.0", "ParentInstance", "MSSQL15E.LOCALDB") Is Nothing Then
            MsgBox("You need to install SQl Local DB")
        Else
        End If


        'If My.Computer.FileSystem.FileExists(My.Settings.CCS_V3Path) Then
        '    MsgBox("its there")
        'Else
        '    MsgBox("its not there >:(")
        '    If GetFilePath() = False Then
        '        Application.Exit()
        '    End If
        'End If

        dtpStatistic.Value = (Today) 'sets the time of date to today

        'loads the butter button names
        Dim tempArray1() As String = My.Settings.ButterButton1.Split("-")
        btnButter1.Text = tempArray1(0)
        Dim tempArray2() As String = My.Settings.ButterButton2.Split("-")
        btnButter2.Text = tempArray2(0)
        Dim tempArray3() As String = My.Settings.ButterButton3.Split("-")
        btnButter3.Text = tempArray3(0)
        Dim tempArray4() As String = My.Settings.ButterButton4.Split("-")
        btnButter4.Text = tempArray4(0)
        Dim tempArray5() As String = My.Settings.ButterButton5.Split("-")
        btnButter5.Text = tempArray5(0)
        CbxSplitAmount.Text = "1"


        UpdateAutoCorrect()
        UpdateGrid()
        UpdateStatistc()
        UpdateCollection()


    End Sub
    Public Function UpdateSumary()
        ' prevent errors when calculating with zero's

        If IsNumeric(tbxWeightSelector.Text) Then
            If IsNumeric(TbxCalSelector.Text) Then
                lblCurrentCalcCal.Text = TbxCalSelector.Text / 100 * tbxWeightSelector.Text
            End If
            If IsNumeric(TbxProSelector.Text) Then
                lblCurrentCalcProt.Text = TbxProSelector.Text / 100 * tbxWeightSelector.Text
            End If
            If IsNumeric(TbxCarbSelector.Text) Then
                lblCurrentCalcCarbs.Text = TbxCarbSelector.Text / 100 * tbxWeightSelector.Text
            End If
            If IsNumeric(TbxSugSelector.Text) Then
                lblCurrentCalcSug.Text = TbxSugSelector.Text / 100 * tbxWeightSelector.Text
            End If
            If IsNumeric(TbxFatSelector.Text) Then
                lblCurrentCalcFat.Text = TbxFatSelector.Text / 100 * tbxWeightSelector.Text
            End If
        End If

        'preview of whats being added
        LblNewCal.Text = "+ " & lblCurrentCalcCal.Text
        LblNewProt.Text = "+ " & lblCurrentCalcProt.Text
        LblNewCarb.Text = "+ " & lblCurrentCalcCarbs.Text
        LblNewSug.Text = "+ " & lblCurrentCalcSug.Text
        LblNewFat.Text = "+ " & lblCurrentCalcFat.Text

        'Shows the new sum, could have been done diffent
        LblNewSumCal.Text = LblCheckAndConvertToDecimal(lblCurrentCalcCal) + LblCheckAndConvertToDecimal(LblSumCal)
        LblNewSumProt.Text = LblCheckAndConvertToDecimal(lblCurrentCalcProt) + LblCheckAndConvertToDecimal(LblSumProt)
        LblNewSumCarb.Text = LblCheckAndConvertToDecimal(lblCurrentCalcCarbs) + LblCheckAndConvertToDecimal(LblSumCarb)
        LblNewSumSug.Text = LblCheckAndConvertToDecimal(lblCurrentCalcSug) + LblCheckAndConvertToDecimal(LblSumSug)
        LblNewSumFat.Text = LblCheckAndConvertToDecimal(lblCurrentCalcFat) + LblCheckAndConvertToDecimal(LblSumFat)




    End Function
    Private Sub TbxWeightSelector_TextChanged(sender As Object, e As EventArgs) Handles tbxWeightSelector.TextChanged

        Call UpdateSumary()
    End Sub
    Private Sub TbxCalSelector_TextChanged(sender As Object, e As EventArgs) Handles TbxCalSelector.TextChanged
        Call UpdateSumary()
    End Sub
    Private Sub TbxProSelector_TextChanged(sender As Object, e As EventArgs) Handles TbxProSelector.TextChanged
        Call UpdateSumary()
    End Sub
    Private Sub TbxCarbSelector_TextChanged(sender As Object, e As EventArgs) Handles TbxCarbSelector.TextChanged
        Call UpdateSumary()
    End Sub
    Private Sub TbxSugSelector_TextChanged(sender As Object, e As EventArgs) Handles TbxSugSelector.TextChanged
        Call UpdateSumary()
    End Sub
    Private Sub TbxFatSelector_TextChanged(sender As Object, e As EventArgs) Handles TbxFatSelector.TextChanged
        Call UpdateSumary()
    End Sub

    Private Sub TbxCalSelector_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxCalSelector.KeyPress
        If e.KeyChar <> ControlChars.Back Then 'ensure that only numbers and backspace can be typed in the box
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub

    Private Sub TbxProSelector_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxProSelector.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If

    End Sub

    Private Sub TbxCarbSelector_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxCarbSelector.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub

    Private Sub TbxSugSelector_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxSugSelector.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub

    Private Sub TbxFatSelector_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxFatSelector.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub

    Private Sub TbxWeightSelector_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxWeightSelector.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub

    Private Sub DgvTemp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTempList.CellClick
        'allows the user to click on the grid and receive the name of the item, TODO: grab the item from the food list again automatically, with the weight
        Try
            tbxNameSelector.Text = dgvTempList.CurrentRow.Cells(0).Value.ToString
            tbxBrandSelector.Text = dgvTempList.CurrentRow.Cells(1).Value.ToString
            'tbxWeightSelector.Text = dgvTempList.CurrentRow.Cells(2).Value.ToString
            'TbxCalSelector.Text = dgvTempList.CurrentRow.Cells(3).Value.ToString
            'TbxProSelector.Text = dgvTempList.CurrentRow.Cells(4).Value.ToString
            'TbxCarbSelector.Text = dgvTempList.CurrentRow.Cells(5).Value.ToString
            'TbxSugSelector.Text = dgvTempList.CurrentRow.Cells(6).Value.ToString
            'TbxFatSelector.Text = dgvTempList.CurrentRow.Cells(7).Value.ToString
            DtpDateSelector.Value = dgvTempList.CurrentRow.Cells(8).Value.ToString
            TbxIDSelector.Text = dgvTempList.CurrentRow.Cells(9).Value.ToString
            My.Settings.DGVSelected = 1
            LblDGVDeleteSelector.Text = "Selected: Main"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub DtpStatistic_ValueChanged(sender As Object, e As EventArgs) Handles dtpStatistic.ValueChanged
        UpdateGrid() ' updates the grid when value is changed
        UpdateStatistc() ' Updates the Statistic and check if bodyweight has been posted that day
        UpdateCollection()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try 'Dev note: laziness 101, if it works, it aint stupid
            If My.Settings.DGVSelected = 1 Then ' Main DGV
                For i As Integer = 0 To dgvTempList.Rows.Count - 1
                    If tbxNameSelector.Text = dgvTempList.Rows(i).Cells(0).Value Then
                        Dim sqlcon As SqlConnection = New SqlConnection(My.Settings.CCS_V3ConnectionString)
                        Dim sqlcmd As SqlCommand = New SqlCommand("DELETE From [Food_History_Table]
	            WHERE [UID]='" + TbxIDSelector.Text + "'", sqlcon) ' ID is unique so its the most relaible without accidently deleting more than 1 record
                        sqlcon.Open() 'opens connections
                        sqlcmd.ExecuteNonQuery()
                        sqlcon.Close() 'closes connections
                        UpdateGrid() 'updates the view
                        UpdateStatistc()
                        UpdateCollection() 'updates the view
                        LblStatus.Text = "Successfully Deleted: " & tbxNameSelector.Text
                        LblStatus.ForeColor = Color.Green
                        Exit Sub
                    Else
                        LblStatus.Text = "Record does not exist, check Name:"
                        LblStatus.ForeColor = Color.Orange
                    End If
                Next
            ElseIf My.Settings.DGVSelected = 2 Then ' Collection DGV
                For i As Integer = 0 To DgvTempCollection.Rows.Count - 1
                    If tbxNameSelector.Text = DgvTempCollection.Rows(i).Cells(0).Value Then
                        Dim sqlcon As SqlConnection = New SqlConnection(My.Settings.CCS_V3ConnectionString)
                        Dim sqlcmd As SqlCommand = New SqlCommand("DELETE From [TempCollection]
	            WHERE [UID]='" + TbxIDSelector.Text + "'", sqlcon) ' ID is unique so its the most relaible without accidently deleting more than 1 record
                        sqlcon.Open() 'opens connections
                        sqlcmd.ExecuteNonQuery()
                        sqlcon.Close() 'closes connections
                        UpdateGrid()
                        UpdateStatistc()
                        UpdateCollection() 'updates the view
                        LblStatus.Text = "Successfully Deleted: " & tbxNameSelector.Text
                        LblStatus.ForeColor = Color.Green
                        Exit Sub
                    Else
                        LblStatus.Text = "Record does not exist, check Name:"
                        LblStatus.ForeColor = Color.Orange
                    End If
                Next
            Else
                LblStatus.Text = "You need to select a record"
                LblStatus.ForeColor = Color.Orange
            End If
            'checks if the record exists
        Catch ex As Exception
            MsgBox("there was an error with the deleting command" & ex.Message)
        End Try
    End Sub
    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        My.Settings.TempGrid = 1
        FoodList.Show() ' opens up the food list
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonFill.Click

        Dim sqlcon As SqlConnection = New SqlConnection(My.Settings.CCS_V3ConnectionString)
        sqlcon.Open()
        ' grabs the name rows
        Dim sqlcmd As New SqlCommand("SELECT * FROM Food_Table", sqlcon)
        Dim SqlDa As New SqlDataAdapter
        SqlDa.SelectCommand = sqlcmd
        Dim ButtoFillTempDT As New DataTable
        SqlDa.Fill(ButtoFillTempDT) ' and putt em over there!
        sqlcon.Close()
        ' case insensetive matching
        For i As Integer = 0 To ButtoFillTempDT.Rows.Count - 1
            If String.Compare(tbxNameSelector.Text, ButtoFillTempDT.Rows(i).Field(Of String)("FoodTableList"), True) = 0 Then
                ' if it finds a match, it will grab the rest of the values in that row, and fill in the text boxes
                tbxNameSelector.Text = ButtoFillTempDT.Rows(i).Field(Of String)("FoodTableList")
                tbxBrandSelector.Text = ButtoFillTempDT.Rows(i).Field(Of String)("BrandTableList")
                TbxCalSelector.Text = ButtoFillTempDT.Rows(i).Field(Of Decimal)("CalorieTableList")
                TbxProSelector.Text = ButtoFillTempDT.Rows(i).Field(Of Decimal)("ProteinTableList")
                TbxCarbSelector.Text = ButtoFillTempDT.Rows(i).Field(Of Decimal)("CarbTableList")
                TbxSugSelector.Text = ButtoFillTempDT.Rows(i).Field(Of Decimal)("SugarTableList")
                TbxFatSelector.Text = ButtoFillTempDT.Rows(i).Field(Of Decimal)("FatTableList")

                LblStatus.Text = (tbxNameSelector.Text & " found")
                LblStatus.ForeColor = Color.Green
                tbxWeightSelector.Focus() 'focuses on the weight txt box after entering finding a match

                Exit Sub
            Else
                ' if everything does not match it will do nothing
                LblStatus.Text = (tbxNameSelector.Text & " Not Found, check spelling")
                LblStatus.ForeColor = Color.Red
            End If
        Next
    End Sub

    Private Sub btnButter2_Click(sender As Object, e As EventArgs) Handles btnButter2.Click
        Dim TempArray() As String = My.Settings.ButterButton2.Split(",")
        Call SubmitButterButton(TempArray(1), TempArray(2), TempArray(3), TempArray(4), TempArray(5), TempArray(6), TempArray(7), TempArray(8))
    End Sub

    Private Sub btnButter3_Click(sender As Object, e As EventArgs) Handles btnButter3.Click
        Dim TempArray() As String = My.Settings.ButterButton3.Split(",")
        Call SubmitButterButton(TempArray(1), TempArray(2), TempArray(3), TempArray(4), TempArray(5), TempArray(6), TempArray(7), TempArray(8))
    End Sub

    Private Sub btnButter4_Click(sender As Object, e As EventArgs) Handles btnButter4.Click
        Dim TempArray() As String = My.Settings.ButterButton4.Split(",")
        Call SubmitButterButton(TempArray(1), TempArray(2), TempArray(3), TempArray(4), TempArray(5), TempArray(6), TempArray(7), TempArray(8))
    End Sub

    Private Sub btnButter5_Click(sender As Object, e As EventArgs) Handles btnButter5.Click
        Dim TempArray() As String = My.Settings.ButterButton5.Split(",")
        Call SubmitButterButton(TempArray(1), TempArray(2), TempArray(3), TempArray(4), TempArray(5), TempArray(6), TempArray(7), TempArray(8))
    End Sub

    Private Sub tbxWeightSelector_MouseDown(sender As Object, e As MouseEventArgs) Handles tbxWeightSelector.MouseDown
        tbxWeightSelector.SelectAll()
    End Sub

    Private Sub tbxNameSelector_KeyDown(sender As Object, e As KeyEventArgs) Handles tbxNameSelector.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tbxNameSelector.Text.Length > 0 Then
                ButtonFill.PerformClick()
                tbxWeightSelector.SelectAll()
            Else
            End If
        Else
        End If
    End Sub

    Private Sub tbxWeightSelector_KeyDown(sender As Object, e As KeyEventArgs) Handles tbxWeightSelector.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tbxNameSelector.Text.Length > 0 Then
                btnSubmitCalc.PerformClick()
            Else
            End If
        Else

        End If
    End Sub

    Private Sub ButterButtonSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ButterButtonSettingsToolStripMenuItem.Click
        formBTNShortCut.Show()
        'Starts up the Butter Button Menu
    End Sub

    Private Sub BtnSubtmitWeight_Click(sender As Object, e As EventArgs) Handles BtnSubtmitWeight.Click
        If IsNumeric(TbxWeightCurrent.Text) Then
            Dim sqlQuery As String = String.Empty
            Dim Weight As Decimal = TbxWeightCurrent.Text ' prevents SQL complaining about NVARIC when its trying to parse a decimal
            sqlQuery &= "IF EXISTS (SELECT BWeight FROM BodyWeight WHERE Date=@Date)
                        BEGIN
                        UPDATE BodyWeight SET BWeight = @BWeight WHERE Date = @date END
                        ELSE
                        INSERT INTO BodyWeight (BWeight, Date) VALUES (@BWeight, @Date)"
            Using sqlcon As New SqlConnection(My.Settings.CCS_V3ConnectionString)
                Using sqlcmd As SqlCommand = New SqlCommand(sqlQuery, sqlcon)
                    sqlcmd.Parameters.AddWithValue("@BWeight", Weight)
                    sqlcmd.Parameters.AddWithValue("@Date", dtpStatistic.Value)
                    sqlcon.Open() 'opens connections
                    sqlcmd.ExecuteNonQuery() 'Send the new item to database
                    sqlcon.Close() 'closes connections
                End Using
            End Using
            LblStatus.ForeColor = Color.Green
            LblStatus.Text = "Weight updated as per " & dtpStatistic.Value & " With the Weight of: " & Weight & "KG"
        Else
            LblStatus.ForeColor = Color.Red
            LblStatus.Text = "Enter a number"
        End If

        UpdateGrid()
        UpdateStatistc()
    End Sub

    Private Sub TbxWeightCurrent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxWeightCurrent.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub

    Private Sub TbxWeightCurrent_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxWeightCurrent.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TbxWeightCurrent.Text.Length > 0 Then
                BtnSubtmitWeight.PerformClick()
            Else
            End If
        Else

        End If
    End Sub
    Private Function UpdateStatistc()

        Dim DecCalSumP1 As Decimal
        Dim decProtSumP1 As Decimal
        Dim decCarbSumP1 As Decimal
        Dim decFatSumP1 As Decimal
        Dim decWeightSumP1 As Decimal
        Dim DecCalSumP2 As Decimal
        Dim decProtSumP2 As Decimal
        Dim decCarbSumP2 As Decimal
        Dim decFatSumP2 As Decimal
        Dim decWeightSumP2 As Decimal
        Dim CountP1 As Integer = 6
        Dim CountP2 As Integer


        If DgvStatistic.RowCount > 0 Then
            Try
                ' caluclate the visible rows and add it to a total
                If DgvStatistic.RowCount < 7 Then ' checks if the rowcount is higher than 7
                    CountP1 = DgvStatistic.RowCount - 1 ' if its lower than 7, it will set the stop to prevent index exception and not run the second weeks average
                ElseIf DgvStatistic.RowCount >= 7 Then ' if its lower than 14 it will it will set it to what ever amount
                    CountP2 = DgvStatistic.RowCount
                    For i = 7 To CountP2 - 1
                        If IsNumeric(DgvStatistic.Rows(i).Cells(1).Value) Then DecCalSumP2 += DgvStatistic.Rows(i).Cells(1).Value
                        If IsNumeric(DgvStatistic.Rows(i).Cells(2).Value) Then decProtSumP2 += DgvStatistic.Rows(i).Cells(2).Value
                        If IsNumeric(DgvStatistic.Rows(i).Cells(3).Value) Then decCarbSumP2 += DgvStatistic.Rows(i).Cells(3).Value
                        If IsNumeric(DgvStatistic.Rows(i).Cells(4).Value) Then decFatSumP2 += DgvStatistic.Rows(i).Cells(4).Value
                        If IsNumeric(DgvStatistic.Rows(i).Cells(5).Value) Then decWeightSumP2 += DgvStatistic.Rows(i).Cells(5).Value
                    Next
                Else
                End If
                For i = 0 To CountP1
                    If IsNumeric(DgvStatistic.Rows(i).Cells(1).Value) Then DecCalSumP1 += DgvStatistic.Rows(i).Cells(1).Value
                    If IsNumeric(DgvStatistic.Rows(i).Cells(2).Value) Then decProtSumP1 += DgvStatistic.Rows(i).Cells(2).Value
                    If IsNumeric(DgvStatistic.Rows(i).Cells(3).Value) Then decCarbSumP1 += DgvStatistic.Rows(i).Cells(3).Value
                    If IsNumeric(DgvStatistic.Rows(i).Cells(4).Value) Then decFatSumP1 += DgvStatistic.Rows(i).Cells(4).Value
                    If IsNumeric(DgvStatistic.Rows(i).Cells(5).Value) Then decWeightSumP1 += DgvStatistic.Rows(i).Cells(5).Value
                Next

                'First week Average adds the avarage
                LblWeekAverageCaloriesP1.Text = Math.Round(DecCalSumP1 / (CountP1 + 1), 2)
                LblWeekAverageProteinP1.Text = Math.Round(decProtSumP1 / (CountP1 + 1), 2)
                LblWeekAverageCarbsP1.Text = Math.Round(decCarbSumP1 / (CountP1 + 1), 2)
                LblWeekAverageFatP1.Text = Math.Round(decFatSumP1 / (CountP1 + 1), 2)
                LblWeekAverageWeightP1.Text = Math.Round(decWeightSumP1 / (CountP1 + 1), 2)

                'Second weeks Average minus 7 to not include previous week and headerrow in the calculation
                LblWeekAverageCaloriesP2.Text = Math.Round(DecCalSumP2 / (CountP2 - 7), 2) ' causes divide by zero exception
                LblWeekAverageProteinP2.Text = Math.Round(decProtSumP2 / (CountP2 - 7), 2)
                LblWeekAverageCarbsP2.Text = Math.Round(decCarbSumP2 / (CountP2 - 7), 2)
                LblWeekAverageFatP2.Text = Math.Round(decFatSumP2 / (CountP2 - 7), 2)
                LblWeekAverageWeightP2.Text = Math.Round(decWeightSumP2 / (CountP2 - 7), 2)


                LblTrendCal.Text = Math.Round(LblWeekAverageCaloriesP1.Text - LblWeekAverageCaloriesP2.Text, 2)
                LblTrendProt.Text = Math.Round(LblWeekAverageProteinP1.Text - LblWeekAverageProteinP2.Text, 2)
                LblTrendCarb.Text = Math.Round(LblWeekAverageCarbsP1.Text - LblWeekAverageCarbsP2.Text, 2)
                LblTrendFat.Text = Math.Round(LblWeekAverageFatP1.Text - LblWeekAverageFatP2.Text, 2)
                LblTrendWeight.Text = Math.Round(LblWeekAverageWeightP1.Text - LblWeekAverageWeightP2.Text, 2)

            Catch ex As Exception
                MsgBox("an error with the calculating the Total's has occured: " & ex.Message)
            End Try
        End If

        ' Grabs Weight
        Dim sqlcon As SqlConnection = New SqlConnection(My.Settings.CCS_V3ConnectionString)
        sqlcon.Open()
        Dim sqlcmd As New SqlCommand("SELECT BWeight
                                      FROM BodyWeight WHERE Date BETWEEN @MinDate AND @MaxDate", sqlcon)
        sqlcmd.Parameters.AddWithValue("@MinDate", dtpStatistic.Value)
        sqlcmd.Parameters.AddWithValue("@MaxDate", dtpStatistic.Value)
        Dim reader As SqlDataReader = sqlcmd.ExecuteReader()
        ' Use: reads select row, has to be called with reader(Name of column)

        ' TODO: Turn the weight to 0 if no query is found
        While reader.Read()
            TbxWeightCurrent.Text = Convert.ToString(reader("BWeight"))
        End While
        sqlcon.Close()

        UpdateStatisticColors()
    End Function
    Private Function ColorCodeTrend(Goal As TextBox, CurrentAverage As Label, Trend As Label)

        If IsNumeric(Goal.Text) AndAlso IsNumeric(CurrentAverage.Text) Then
            Dim DecGoal As Decimal = Goal.Text
            ' decides if it should be seen as positive or negative improvements, average is used as weight tends to shift alot
            If DecGoal > CurrentAverage.Text And Not DecGoal = "0" Then ' if the goal is greater than the current average weight, loosing weight is a negative
                If Trend.Text > 0 Then
                    Trend.BackColor = Color.YellowGreen
                ElseIf Trend.Text < 0 Then
                    Trend.BackColor = Color.IndianRed
                ElseIf DecGoal = 0 Then
                    Trend.BackColor = Color.LightBlue
                End If
            ElseIf DecGoal < CurrentAverage.Text And Not DecGoal = "0" Then ' if the goal is less than the current average weight, loosing wieght is a positive
                If Trend.Text < 0 Then
                    Trend.BackColor = Color.IndianRed
                ElseIf Trend.Text > 0 Then
                    Trend.BackColor = Color.YellowGreen
                ElseIf DecGoal = 0 Then
                    Trend.BackColor = Color.LightBlue
                End If
            ElseIf DecGoal = "0" Then
                Trend.BackColor = Color.LightBlue
            End If
        End If
        'how the decide the delta to show whats positive or negative: goal weight vs Current weight decide if it should show green or red
        'TODO: Minor bug; does not reset when value is put back to 0
    End Function
    Private Function UpdateStatisticColors()

        TbxCaloriesCurrent.Text = LblSumCal.Text
        TbxProteinCurrent.Text = LblSumProt.Text
        TbxCarbsCurrent.Text = LblSumCarb.Text
        TbxFatCurrent.Text = LblSumFat.Text

        Try ' Loads current goals, they are saved as they are typed
            TbxGoalWeight.Text = My.Settings.WeightGoal
            TbxGoalCal.Text = My.Settings.CalorieGoal
            TbxGoalProt.Text = My.Settings.ProteinGoal
            TbxGoalCarb.Text = My.Settings.CarbGoal
            TbxGoalFat.Text = My.Settings.FatGoal
        Catch ex As Exception
            MsgBox("There was an error loading the Current Goals: " & ex.Message)
        End Try

        Try ' Warns if the today's goal is not met
            ColorCodeDeviationForToday(TbxGoalWeight, TbxWeightCurrent)
            ColorCodeDeviationForToday(TbxGoalCal, TbxCaloriesCurrent)
            ColorCodeDeviationForToday(TbxGoalProt, TbxProteinCurrent)
            ColorCodeDeviationForToday(TbxGoalCarb, TbxCarbsCurrent)
            ColorCodeDeviationForToday(TbxGoalFat, TbxFatCurrent)
        Catch ex As Exception
            MsgBox("There was an error checking with the Color marking of Today: " & ex.Message)
        End Try
        Try
            ColorCodeTrend(TbxGoalWeight, LblWeekAverageWeightP1, LblTrendWeight)
            ColorCodeTrend(TbxGoalCal, LblWeekAverageCaloriesP1, LblTrendCal)
            ColorCodeTrend(TbxGoalProt, LblWeekAverageProteinP1, LblTrendProt)
            ColorCodeTrend(TbxGoalCarb, LblWeekAverageCarbsP1, LblTrendCarb)
            ColorCodeTrend(TbxGoalFat, LblWeekAverageFatP1, LblTrendFat)
        Catch ex As Exception
            MsgBox("There was an error checking with the Color marking of the Trend: " & ex.Message)
        End Try
        Try
            ColorCodeAverage(TbxGoalWeight, LblWeekAverageWeightP1)
            ColorCodeAverage(TbxGoalCal, LblWeekAverageCaloriesP1)
            ColorCodeAverage(TbxGoalProt, LblWeekAverageProteinP1)
            ColorCodeAverage(TbxGoalCarb, LblWeekAverageCarbsP1)
            ColorCodeAverage(TbxGoalFat, LblWeekAverageFatP1)
            ColorCodeAverage(TbxGoalWeight, LblWeekAverageWeightP2)
            ColorCodeAverage(TbxGoalCal, LblWeekAverageCaloriesP2)
            ColorCodeAverage(TbxGoalProt, LblWeekAverageProteinP2)
            ColorCodeAverage(TbxGoalCarb, LblWeekAverageCarbsP2)
            ColorCodeAverage(TbxGoalFat, LblWeekAverageFatP2)
        Catch ex As Exception
            MsgBox("There was an error checking with the Color marking of the Average: " & ex.Message)
        End Try


    End Function
    Private Function ColorCodeAverage(Goal As TextBox, Current As Label)
        ' Warns if the user is too far away or going above his goal
        'Note Converting text to decimal makes it works properly
        Try
            Dim DecGoal As Decimal = Goal.Text
            Dim DecCurrent As Decimal = Current.Text
            If Not DecGoal = 0 Then
                Select Case DecCurrent
                    Case (Goal.Text * 0.1) To (Goal.Text * 0.5)
                        Current.BackColor = Color.LightGoldenrodYellow
                    Case (Goal.Text * 0.5) To (Goal.Text * 0.8)
                        Current.BackColor = Color.LightYellow
                    Case (Goal.Text * 0.8) To (Goal.Text * 0.95)
                        Current.BackColor = Color.Yellow
                    Case (Goal.Text * 0.95) To (Goal.Text * 1.05)
                        Current.BackColor = Color.YellowGreen
                    Case (Goal.Text * 1.05) To (Goal.Text * 1.2)
                        Current.BackColor = Color.SeaGreen
                    Case (Goal.Text * 1.2) To (Goal.Text * 5)
                        Current.BackColor = Color.Red
                    Case Else
                        Current.BackColor = Color.LightBlue
                End Select
            Else
                Current.BackColor = Color.LightBlue
            End If
        Catch ex As Exception
            ' String errors expected
        End Try
    End Function
    Private Function ColorCodeDeviationForToday(Goal As TextBox, Current As TextBox)
        ' Warns if the user is too far away or going above his goal
        'Note Converting text to decimal makes it works properly
        Try
            Dim DecGoal As Decimal = Goal.Text
            Dim DecCurrent As Decimal = Current.Text
            If Not DecGoal = 0 Then
                Select Case DecCurrent
                    Case (Goal.Text * 0.1) To (Goal.Text * 0.5)
                        Current.BackColor = Color.LightGoldenrodYellow
                    Case (Goal.Text * 0.5) To (Goal.Text * 0.8)
                        Current.BackColor = Color.LightYellow
                    Case (Goal.Text * 0.8) To (Goal.Text * 0.95)
                        Current.BackColor = Color.Yellow
                    Case (Goal.Text * 0.95) To (Goal.Text * 1.05)
                        Current.BackColor = Color.YellowGreen
                    Case (Goal.Text * 1.05) To (Goal.Text * 1.2)
                        Current.BackColor = Color.SeaGreen
                    Case (Goal.Text * 1.2) To (Goal.Text * 5)
                        Current.BackColor = Color.Red
                    Case Else
                        Current.BackColor = Color.White
                End Select
            Else
                Current.BackColor = Color.LightGray
            End If
        Catch ex As Exception
            ' String errors expected
        End Try
    End Function
    Private Function UpdateGrid()
        Dim sqlcon As SqlConnection = New SqlConnection(My.Settings.CCS_V3ConnectionString)
        Dim SqlDa As New SqlDataAdapter
        Try
            ' checks if the DB exists, if not; lets the user choose the source, and saves it in settings
            ' If File.Exists(My.Settings.CCS_V3ConnectionString) Then
            'Else
            ' End If
            Dim tempDT As New DataTable

            sqlcon.Open()
            ' grabs the rows relevant rows, filtered by date of day choosen by the Date Time Picker in statistc box
            Dim sqlcmd As New SqlCommand("SELECT Name, Brand, Weight, Calories,
            Protein, Carbohydrates, Sugar, Fat, Date, UID 
            FROM Food_History_table WHERE Date BETWEEN @MinDate AND @MaxDate", sqlcon)
            sqlcmd.Parameters.AddWithValue("@MinDate", dtpStatistic.Value)
            sqlcmd.Parameters.AddWithValue("@MaxDate", dtpStatistic.Value)
            SqlDa.SelectCommand = sqlcmd
            tempDT.Clear()
            SqlDa.Fill(tempDT)

            ' sets the columns name, so it looks nicer
            tempDT.Columns(0).ColumnName = "Name"
            tempDT.Columns(1).ColumnName = "Brand"
            tempDT.Columns(2).ColumnName = "Weight"
            tempDT.Columns(3).ColumnName = "Calories"
            tempDT.Columns(4).ColumnName = "Proteins"
            tempDT.Columns(5).ColumnName = "Carbs"
            tempDT.Columns(6).ColumnName = "Sugar"
            tempDT.Columns(7).ColumnName = "Fat"
            tempDT.Columns(8).ColumnName = "Date"
            tempDT.Columns(9).ColumnName = "ID"
            dgvTempList.DataSource = tempDT
            sqlcon.Close()

        Catch ex As Exception
            MsgBox("An error with retriving the data from SQL DB has occured: " & ex.Message)
        End Try

        Try
            If dgvTempList.Columns.Count > 0 Then ' for some reason this solved the error it threw
                dgvTempList.Columns(0).Width = 230
                dgvTempList.Columns(1).Width = 160
                dgvTempList.Columns(2).Width = 50
                dgvTempList.Columns(3).Width = 50
                dgvTempList.Columns(4).Width = 50
                dgvTempList.Columns(5).Width = 50
                dgvTempList.Columns(6).Width = 50
                dgvTempList.Columns(7).Width = 50
                dgvTempList.Columns(8).Width = 70
                dgvTempList.Columns(9).Width = 45
            Else
            End If
        Catch ex As Exception
            MsgBox("An error with the Column setup has occured: " & ex.Message)
        End Try

        Try
            Dim TotalCal As Decimal
            Dim TotalProt As Decimal
            Dim TotalCarb As Decimal
            Dim TotalSug As Decimal
            Dim TotalFat As Decimal
            For Each Row As DataGridViewRow In dgvTempList.Rows
                TotalCal += Row.Cells(3).Value
                TotalProt += Row.Cells(4).Value
                TotalCarb += Row.Cells(5).Value
                TotalSug += Row.Cells(6).Value
                TotalFat += Row.Cells(7).Value
            Next
            LblSumCal.Text = TotalCal
            LblSumProt.Text = TotalProt
            LblSumCarb.Text = TotalCarb
            LblSumSug.Text = TotalSug
            LblSumFat.Text = TotalFat
        Catch ex As Exception
            MsgBox("an error with the calculating the sumary has occured: " & ex.Message)
        End Try

        Dim tempStatisticDT As New DataTable
        Try
            sqlcon.Open()
            ' grabs the relevant rows related to Macronutrients at todays date minus 14 days
            'TODO: BodyWeight Value wont be available unless the left table has a date posted, SUM or AVG?
            Dim sqlcmd As New SqlCommand("
            SELECT Food_History_table.Date, ROUND(SUM(Food_History_table.Calories) ,2) AS Calories, ROUND(SUM(Food_History_table.Protein) ,2) AS Protein, ROUND(SUM(Food_History_table.Carbohydrates) ,2) AS Carbs, ROUND(SUM(Food_History_table.Fat) ,2) AS Fat, BodyWeight.BWeight AS BWeight
            FROM Food_History_table
            INNER JOIN BodyWeight ON Food_History_table.Date = BodyWeight.Date
            WHERE Food_History_table.Date BETWEEN @Max_Date AND @Min_Date
            GROUP BY Food_History_table.Date, BodyWeight.Date, BodyWeight.BWeight
            ORDER BY Food_History_table.Date DESC", sqlcon)
            sqlcmd.Parameters.AddWithValue("@Min_Date", Today)
            sqlcmd.Parameters.AddWithValue("@Max_Date", Today.AddDays(-14))
            SqlDa.SelectCommand = sqlcmd
            tempStatisticDT.Clear()
            SqlDa.Fill(tempStatisticDT)
            DgvStatistic.DataSource = tempStatisticDT
            sqlcon.Close()
            DgvStatistic.Update()
            DgvStatistic.Refresh()

            If DgvStatistic.Columns.Count > 0 Then ' for some reason this solved the error it throws
                DgvStatistic.Columns(0).Width = 75
                DgvStatistic.Columns(0).DefaultCellStyle.Format = "d" 'forces dates format to dates
                DgvStatistic.Columns(1).Width = 60
                DgvStatistic.Columns(2).Width = 60
                DgvStatistic.Columns(3).Width = 60
                DgvStatistic.Columns(4).Width = 60
                DgvStatistic.Columns(5).Width = 55
            Else
            End If
        Catch ex As Exception
            MsgBox("An error with retriving the data from BodyWeight SQL DataBase has occured: " & ex.Message)
        End Try
    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnCollection.Click
        ' saves Information to DgvTempCollection and My.Settings.Tempgrid as temporarily storage
        Dim calTotal As Decimal
        Dim proTotal As Decimal
        Dim carbTotal As Decimal
        Dim sugTotal As Decimal
        Dim fatTotal As Decimal

        If IsNumeric(TbxCalSelector.Text) And IsNumeric(tbxWeightSelector.Text) AndAlso IsNumeric(TbxFatSelector.Text) AndAlso
           IsNumeric(TbxProSelector.Text) AndAlso IsNumeric(TbxCarbSelector.Text) AndAlso IsNumeric(TbxSugSelector.Text) AndAlso
           tbxNameSelector.Text.Trim.Length > 0 Then
            calTotal = TbxCalSelector.Text / 100 * tbxWeightSelector.Text
            proTotal = TbxProSelector.Text / 100 * tbxWeightSelector.Text
            carbTotal = TbxCarbSelector.Text / 100 * tbxWeightSelector.Text
            sugTotal = TbxSugSelector.Text / 100 * tbxWeightSelector.Text
            fatTotal = TbxFatSelector.Text / 100 * tbxWeightSelector.Text

            Dim sqlQuery As String = String.Empty
            sqlQuery &= "INSERT INTO [TempCollection] (Name, Brand, Weight, Calories, Protein, Carbs, Sugar, Fat)"
            sqlQuery &= "VALUES (@History_Name, @History_Brand, @History_Weight, @History_Calories, @History_Protein, @History_Carbohydrates, @History_Sugar, @History_Fat)"
            Using sqlcon As New SqlConnection(My.Settings.CCS_V3ConnectionString)
                Using sqlcmd As SqlCommand = New SqlCommand(sqlQuery, sqlcon)
                    sqlcmd.Parameters.AddWithValue("@History_Name", tbxNameSelector.Text)
                    sqlcmd.Parameters.AddWithValue("@History_Brand", tbxBrandSelector.Text)
                    sqlcmd.Parameters.AddWithValue("@History_Weight", tbxWeightSelector.Text)
                    sqlcmd.Parameters.AddWithValue("@History_Calories", calTotal)
                    sqlcmd.Parameters.AddWithValue("@History_Protein", proTotal)
                    sqlcmd.Parameters.AddWithValue("@History_Carbohydrates", carbTotal)
                    sqlcmd.Parameters.AddWithValue("@History_Sugar", sugTotal)
                    sqlcmd.Parameters.AddWithValue("@History_Fat", fatTotal)
                    sqlcon.Open() 'opens connections
                    sqlcmd.ExecuteNonQuery() 'Send the new item to database
                    sqlcon.Close() 'closes connections

                End Using
            End Using
            UpdateCollection()
            LblStatus.ForeColor = Color.Green
            LblStatus.Text = tbxNameSelector.Text & " Added to Collection"
        Else
            LblStatus.ForeColor = Color.Red
            LblStatus.Text = "Not a valid Entry"
        End If
    End Sub

    Private Function UpdateCollection()
        'Updates the collection information
        Try
            Dim TempDT As New DataTable
            Dim sqlcon As SqlConnection = New SqlConnection(My.Settings.CCS_V3ConnectionString)
            Dim SqlDa As New SqlDataAdapter

            sqlcon.Open()
            Dim sqlcmd As New SqlCommand("
            SELECT Name, Brand, Weight, Calories, Protein, Carbs, Sugar, Fat, UID
            FROM TempCollection
            ", sqlcon)
            SqlDa.SelectCommand = sqlcmd
            TempDT.Clear()
            SqlDa.Fill(TempDT)
            sqlcon.Close()
            DgvTempCollection.Columns.Clear()
            DgvTempCollection.DataSource = TempDT
            If DgvTempCollection.Columns.Count > 0 Then
                DgvTempCollection.Columns(0).Width = 200
                DgvTempCollection.Columns(1).Width = 150
                DgvTempCollection.Columns(2).Width = 65
                DgvTempCollection.Columns(3).Width = 65
                DgvTempCollection.Columns(4).Width = 65
                DgvTempCollection.Columns(5).Width = 65
                DgvTempCollection.Columns(6).Width = 65
                DgvTempCollection.Columns(7).Width = 65
                DgvTempCollection.Columns(8).Width = 50
            End If
        Catch ex As Exception
            LblStatus.ForeColor = Color.Red
            LblStatus.Text = "Could not update Collection"
            MsgBox(ex.Message) 'There shouldnt be any errors.
        End Try

        Try
            LblCurrentCollectionTotalWeight.Text = "0"
            LblCurrentCollectionTotalCal.Text = "0"
            LblCurrentCollectionTotalProt.Text = "0"
            LblCurrentCollectionTotalCarb.Text = "0"
            LblCurrentCollectionTotalSug.Text = "0"
            LblCurrentCollectionTotalFat.Text = "0"
            For Each Row As DataGridViewRow In DgvTempCollection.Rows
                ' for Total Sumary
                LblCurrentCollectionTotalWeight.Text += Row.Cells(2).Value
                LblCurrentCollectionTotalCal.Text += Row.Cells(3).Value
                LblCurrentCollectionTotalProt.Text += Row.Cells(4).Value
                LblCurrentCollectionTotalCarb.Text += Row.Cells(5).Value
                LblCurrentCollectionTotalSug.Text += Row.Cells(6).Value
                LblCurrentCollectionTotalFat.Text += Row.Cells(7).Value
            Next
        Catch ex As Exception 'errors arent expected, but just inchase
            MsgBox(ex.Message)
        End Try

        UpdateCollectionStatistic()

    End Function
    Private Function UpdateCollectionStatistic()

        Try
            ' for x/100g, Formula: what_ever / by_Total_weight * 100
            Dim TotalWeight As Decimal
            Dim TotalCal As Decimal
            Dim TotalProt As Decimal
            Dim TotalCarb As Decimal
            Dim TotalSug As Decimal
            Dim TotalFat As Decimal
            For Each Row As DataGridViewRow In DgvTempCollection.Rows
                TotalWeight += Row.Cells(2).Value
                TotalCal += Row.Cells(3).Value
                TotalProt += Row.Cells(4).Value
                TotalCarb += Row.Cells(5).Value
                TotalSug += Row.Cells(6).Value
                TotalFat += Row.Cells(7).Value
            Next

            LblCurrentCollectionXgCal.Text = Math.Round(TotalCal / TotalWeight * 100, 2)
            LblCurrentCollectionXgProt.Text = Math.Round(TotalProt / TotalWeight * 100, 2)
            LblCurrentCollectionXgCarb.Text = Math.Round(TotalCarb / TotalWeight * 100, 2)
            LblCurrentCollectionXgSug.Text = Math.Round(TotalSug / TotalWeight * 100, 2)
            LblCurrentCollectionXgFat.Text = Math.Round(TotalFat / TotalWeight * 100, 2)

            ' show current calculation, formula: what_ever * weight
            LblCurrentCollectionCurrentCal.Text = Math.Round(TotalCal / TotalWeight * TbxCollectionWeight.Text, 2)
            LblCurrentCollectionCurrentProt.Text = Math.Round(TotalProt / TotalWeight * TbxCollectionWeight.Text, 2)
            LblCurrentCollectionCurrentCarb.Text = Math.Round(TotalCarb / TotalWeight * TbxCollectionWeight.Text, 2)
            LblCurrentCollectionCurrentSug.Text = Math.Round(TotalSug / TotalWeight * TbxCollectionWeight.Text, 2)
            LblCurrentCollectionCurrentFat.Text = Math.Round(TotalFat / TotalWeight * TbxCollectionWeight.Text, 2)
        Catch ex As Exception ' errors expected with divide by 0 and nulls, lazy mans solutions
        End Try

    End Function

    Private Sub BtnClearTbx_Click(sender As Object, e As EventArgs) Handles BtnClearTbx.Click
        tbxNameSelector.Text = ""
        tbxBrandSelector.Text = ""
        tbxWeightSelector.Text = ""
        TbxCalSelector.Text = ""
        TbxProSelector.Text = ""
        TbxCarbSelector.Text = ""
        TbxSugSelector.Text = ""
        TbxFatSelector.Text = ""
        TbxIDSelector.Text = ""

        lblCurrentCalcCal.Text = "0"
        lblCurrentCalcProt.Text = "0"
        lblCurrentCalcCarbs.Text = "0"
        lblCurrentCalcSug.Text = "0"
        lblCurrentCalcFat.Text = "0"
    End Sub

    Private Sub DgvTempCollection_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTempCollection.CellClick
        Try
            tbxNameSelector.Text = DgvTempCollection.CurrentRow.Cells(0).Value.ToString
            tbxBrandSelector.Text = DgvTempCollection.CurrentRow.Cells(1).Value.ToString
            tbxWeightSelector.Text = DgvTempCollection.CurrentRow.Cells(2).Value.ToString
            'TbxCalSelector.Text = dgvTempList.CurrentRow.Cells(3).Value.ToString
            'TbxProSelector.Text = dgvTempList.CurrentRow.Cells(4).Value.ToString
            'TbxCarbSelector.Text = dgvTempList.CurrentRow.Cells(5).Value.ToString
            'TbxSugSelector.Text = dgvTempList.CurrentRow.Cells(6).Value.ToString
            'TbxFatSelector.Text = dgvTempList.CurrentRow.Cells(7).Value.ToString
            TbxIDSelector.Text = DgvTempCollection.CurrentRow.Cells(8).Value
            My.Settings.DGVSelected = 2
            LblDGVDeleteSelector.Text = "Selected: Collection"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TbxCollectionWeight_TextChanged(sender As Object, e As EventArgs) Handles TbxCollectionWeight.TextChanged
        UpdateCollectionStatistic()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles BtnCollectionSubmit.Click
        'TODO: Skip today button?
        If IsNumeric(TbxCollectionWeight.Text) And TbxCollectionName.Text.Length >= 1 Then
            If CbxSplitAmount.Text < 2 Then
                ' if there is just 1 record over 1 day, it will just post it all as a regular insert, with the custom food name
                InsertFoodHistory(TbxCollectionName.Text, TbxCollectionWeight.Text, LblCurrentCollectionCurrentCal.Text, LblCurrentCollectionCurrentProt.Text, LblCurrentCollectionCurrentCarb.Text, LblCurrentCollectionCurrentSug.Text, LblCurrentCollectionCurrentFat.Text, dtpStatistic.Value)
                If TbxCollectionWeight.Text = LblCurrentCollectionTotalWeight.Text Then ' if the weight equels to total of the collection, it will be emptied
                    ClearCollection()
                End If
            Else
                For i As Integer = 1 To CbxSplitAmount.Text  ' values gets divide by the amount of days (Minus today) and the amount of records get inserted over x days
                    InsertFoodHistory(TbxCollectionName.Text, TbxCollectionWeight.Text / CbxSplitAmount.Text, LblCurrentCollectionCurrentCal.Text / CbxSplitAmount.Text, LblCurrentCollectionCurrentProt.Text / CbxSplitAmount.Text, LblCurrentCollectionCurrentCarb.Text / CbxSplitAmount.Text, LblCurrentCollectionCurrentSug.Text / CbxSplitAmount.Text, LblCurrentCollectionCurrentFat.Text / CbxSplitAmount.Text, Today.AddDays(i))
                Next
                If TbxCollectionWeight.Text = LblCurrentCollectionTotalWeight.Text Then
                    ClearCollection()
                End If
            End If
            LblStatus.ForeColor = Color.Green
            LblStatus.Text = "Succesfully added item(S) to Collection"
        Else
            LblStatus.ForeColor = Color.Red
            LblStatus.Text = "Enter a Weight and Name"
        End If

        UpdateGrid()
        UpdateStatistc()
        UpdateCollectionStatistic()
    End Sub
    Public Function UpdateAutoCorrect()
        'for Autocorrecter
        Dim autoCorrect As New AutoCompleteStringCollection
        Dim sqlcon As SqlConnection = New SqlConnection(My.Settings.CCS_V3ConnectionString)
        sqlcon.Open()
        ' grabs the name rows
        Dim sqlcmd As New SqlCommand("SELECT FoodTableList, BrandTableList FROM Food_Table", sqlcon)
        Dim SqlDa As New SqlDataAdapter
        SqlDa.SelectCommand = sqlcmd
        Dim tempDT As New DataTable
        tempDT.Clear()
        SqlDa.Fill(tempDT)
        For i = 0 To tempDT.Rows.Count - 1 ' loads all the items into the suggestion box
            autoCorrect.Add(tempDT.Rows(i)("FoodTableList").ToString)
        Next
        sqlcon.Close()

        tbxNameSelector.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbxNameSelector.AutoCompleteCustomSource = autoCorrect
        tbxNameSelector.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Function
    Private Function ClearCollection()
        TbxCollectionName.Text = ""
        TbxCollectionWeight.Text = ""
        CbxSplitAmount.Text = "1"
        Dim sqlcon As SqlConnection = New SqlConnection(My.Settings.CCS_V3ConnectionString)
        Dim sqlcmd As SqlCommand = New SqlCommand("DELETE From [TempCollection] ", sqlcon)
        sqlcon.Open() 'opens connections
        sqlcmd.ExecuteNonQuery()
        sqlcon.Close() 'closes connections
    End Function
    Private Function LblCheckAndConvertToDecimal(Lbl As Label) As Decimal
        ' Converts *.text into decimals
        Dim ToDecimal As Decimal
        If IsNumeric(Lbl.Text) Then
            ToDecimal = Convert.ToDecimal(Lbl.Text)
            Return ToDecimal
        Else
            Return 0
        End If
    End Function
    Private Sub BtnClearCollection_Click(sender As Object, e As EventArgs) Handles BtnClearCollection.Click
        ClearCollection()
        UpdateGrid()
        UpdateStatistc()
    End Sub

    Private Sub BtnToday_Click(sender As Object, e As EventArgs) Handles BtnToday.Click
        dtpStatistic.Value = Today
    End Sub

    Private Sub TbxGoalWeight_TextChanged(sender As Object, e As EventArgs) Handles TbxGoalWeight.TextChanged
        Try
            My.Settings.WeightGoal = TbxGoalWeight.Text
            UpdateStatisticColors()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TbxGoalCal_TextChanged(sender As Object, e As EventArgs) Handles TbxGoalCal.TextChanged
        Try
            My.Settings.CalorieGoal = TbxGoalCal.Text
            UpdateStatisticColors()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TbxGoalProt_TextChanged(sender As Object, e As EventArgs) Handles TbxGoalProt.TextChanged
        Try
            My.Settings.ProteinGoal = TbxGoalProt.Text
            UpdateStatisticColors()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TbxGoalCarb.TextChanged
        Try
            My.Settings.CarbGoal = TbxGoalCarb.Text
            UpdateStatisticColors()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TbxGoalFat.TextChanged
        Try
            My.Settings.FatGoal = TbxGoalFat.Text
            UpdateStatisticColors()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TbxGoalWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxGoalWeight.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub

    Private Sub TbxGoalCal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxGoalCal.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub

    Private Sub TbxGoalProt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxGoalProt.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub

    Private Sub TbxGoalCarb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxGoalCarb.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub

    Private Sub TbxGoalFat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxGoalFat.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub

    Private Sub tbxBrandSelector_MouseDown(sender As Object, e As MouseEventArgs) Handles tbxBrandSelector.MouseDown
        tbxBrandSelector.SelectAll()
    End Sub

    Private Sub TbxCalSelector_MouseDown(sender As Object, e As MouseEventArgs) Handles TbxCalSelector.MouseDown
        TbxCalSelector.SelectAll()
    End Sub

    Private Sub TbxProSelector_MouseDown(sender As Object, e As MouseEventArgs) Handles TbxProSelector.MouseDown
        TbxProSelector.SelectAll()
    End Sub

    Private Sub TbxCarbSelector_MouseDown(sender As Object, e As MouseEventArgs) Handles TbxCarbSelector.MouseDown
        TbxCarbSelector.SelectAll()
    End Sub

    Private Sub TbxSugSelector_MouseDown(sender As Object, e As MouseEventArgs) Handles TbxSugSelector.MouseDown
        TbxSugSelector.SelectAll()
    End Sub

    Private Sub TbxFatSelector_MouseDown(sender As Object, e As MouseEventArgs) Handles TbxFatSelector.MouseDown
        TbxFatSelector.SelectAll()
    End Sub

    Private Sub BtnBodyMessures_Click(sender As Object, e As EventArgs) Handles BtnBodyMessures.Click
        BodyComposition.Show()
    End Sub
End Class