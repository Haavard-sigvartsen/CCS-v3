Imports System.IO
Imports System.Data.SqlClient

Public Class MainMenu

    'TODO: make an Help page
    'TODO: make the name button a combobox that autocorrects what ever results and the user should be available to choose by pressing enter on it
    'TODO: store items to make an recipe or/and store for later
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
            sqlQuery &= "INSERT INTO [Food_History_table] (History_Name, History_Brand, History_Weight, History_Calories, History_Protein, "
            sqlQuery &= "History_Carbohydrates, History_Sugar, History_Fat, History_Date)"
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
                    sqlcmd.Parameters.AddWithValue("@History_Date", dtpStatistic.Value)

                    sqlcon.Open() 'opens connections
                    sqlcmd.ExecuteNonQuery() 'Send the new item to database
                    sqlcon.Close() 'closes connections

                End Using
            End Using

            LblStatus.Text = (tbxNameSelector.Text & " added")
            LblStatus.ForeColor = Color.Green

            UpdateGrid()

        Else
            MsgBox("you done goof")
        End If



    End Sub

    Private Sub UpdateGrid()
        Try
            ' checks if the DB exists, if not; lets the user choose the source, and saves it in settings
            ' If File.Exists(My.Settings.CCS_V3ConnectionString) Then
            'Else
            ' End If

            Dim sqlcon As SqlConnection = New SqlConnection(My.Settings.CCS_V3ConnectionString)
            Dim tempDT As New DataTable
            Dim SqlDa As New SqlDataAdapter
            sqlcon.Open()
            ' grabs the rows, filtered by date of day choosen by the Date Time Picker in statistc box
            Dim sqlcmd As New SqlCommand("SELECT * FROM Food_History_table WHERE History_Date BETWEEN @MinDate AND @MaxDate", sqlcon)
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
            dgvTempList.DataSource = tempDT
            sqlcon.Close()

        Catch ex As Exception
            MsgBox("An error with retriving the data from SQL DB has occured: " & ex.Message)
        End Try

        Try
            If dgvTempList.Columns.Count > 0 Then ' for some reason this solved the error it threw
                dgvTempList.Columns(0).Width = 200
                dgvTempList.Columns(1).Width = 150
                dgvTempList.Columns(2).Width = 50
                dgvTempList.Columns(3).Width = 50
                dgvTempList.Columns(4).Width = 50
                dgvTempList.Columns(5).Width = 50
                dgvTempList.Columns(6).Width = 50
                dgvTempList.Columns(7).Width = 50
                dgvTempList.Columns(8).Width = 70
            Else
            End If

        Catch ex As Exception
            MsgBox("An error with the Column setup has occured: " & ex.Message)
        End Try

        Try
            ' caluclate the visible rows and add it to a total
            Dim decCalSum As Decimal
            Dim decProtSum As Decimal
            Dim decCarbSum As Decimal
            Dim dntSugSum As Decimal
            Dim dntFatSum As Decimal
            For Each Row As DataGridViewRow In dgvTempList.Rows
                decCalSum += Row.Cells(3).Value
                decProtSum += Row.Cells(4).Value
                decCarbSum += Row.Cells(5).Value
                dntSugSum += Row.Cells(6).Value
                dntFatSum += Row.Cells(7).Value
            Next
            LblSumCal.Text = decCalSum
            LblSumProt.Text = decProtSum
            LblSumCarb.Text = decCarbSum
            LblSumSug.Text = dntSugSum
            LblSumFat.Text = dntFatSum
        Catch ex As Exception
            MsgBox("an error with the calculating the sumary has occured: " & ex.Message)
        End Try




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


        Dim sqlQuery As String = String.Empty
            sqlQuery &= "INSERT INTO [Food_History_table] (History_Name, History_Brand, History_Weight, History_Calories, History_Protein, "
            sqlQuery &= "History_Carbohydrates, History_Sugar, History_Fat, History_Date)"
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
                    sqlcmd.Parameters.AddWithValue("@History_Date", dtpStatistic.Text)

                    sqlcon.Open() 'opens connections
                    sqlcmd.ExecuteNonQuery() 'Send the new item to database
                    sqlcon.Close() 'closes connections

                End Using
            End Using
            UpdateGrid()

        LblStatus.Text = (Name & " Importet")
        LblStatus.ForeColor = Color.Green



    End Function
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UpdateGrid()
        dtpStatistic.Value = (Today) 'sets the time of date to today

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

        'loads the butter button names
        Dim tempArray1() As String = My.Settings.ButterButton1.Split(",")
        btnButter1.Text = tempArray1(0)
        Dim tempArray2() As String = My.Settings.ButterButton2.Split(",")
        btnButter2.Text = tempArray2(0)
        Dim tempArray3() As String = My.Settings.ButterButton3.Split(",")
        btnButter3.Text = tempArray3(0)
        Dim tempArray4() As String = My.Settings.ButterButton4.Split(",")
        btnButter4.Text = tempArray4(0)
        Dim tempArray5() As String = My.Settings.ButterButton5.Split(",")
        btnButter5.Text = tempArray5(0)



    End Sub

    Public Function UpdateSumary()
        ' prevent errors when calculating with zero's

        If IsNumeric(tbxWeightSelector.Text) Then
            If IsNumeric(TbxCalSelector.Text) Then
                lblCurrentCalcCal.Text = TbxCalSelector.Text / 100 * tbxWeightSelector.Text
            Else

            End If
            If IsNumeric(TbxProSelector.Text) Then
                lblCurrentCalcProt.Text = TbxProSelector.Text / 100 * tbxWeightSelector.Text
            Else

            End If
            If IsNumeric(TbxCarbSelector.Text) Then
                lblCurrentCalcCarbs.Text = TbxCarbSelector.Text / 100 * tbxWeightSelector.Text
            Else

            End If
            If IsNumeric(TbxSugSelector.Text) Then
                lblCurrentCalcSug.Text = TbxSugSelector.Text / 100 * tbxWeightSelector.Text
            Else

            End If
            If IsNumeric(TbxFatSelector.Text) Then
                lblCurrentCalcFat.Text = TbxFatSelector.Text / 100 * tbxWeightSelector.Text
            Else

            End If

        End If
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
            tbxWeightSelector.Text = dgvTempList.CurrentRow.Cells(2).Value.ToString
            'TbxCalSelector.Text = dgvTempList.CurrentRow.Cells(3).Value.ToString
            'TbxProSelector.Text = dgvTempList.CurrentRow.Cells(4).Value.ToString
            'TbxCarbSelector.Text = dgvTempList.CurrentRow.Cells(5).Value.ToString
            'TbxSugSelector.Text = dgvTempList.CurrentRow.Cells(6).Value.ToString
            'TbxFatSelector.Text = dgvTempList.CurrentRow.Cells(7).Value.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub DtpStatistic_ValueChanged(sender As Object, e As EventArgs) Handles dtpStatistic.ValueChanged
        UpdateGrid() ' updates the grid when value is changed
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        'checks if the record exists
        For i As Integer = 0 To dgvTempList.Rows.Count - 1
            If tbxNameSelector.Text = dgvTempList.Rows(i).Cells(0).Value Then
                Dim sqlcon As SqlConnection = New SqlConnection(My.Settings.CCS_V3ConnectionString)
                Dim sqlcmd As SqlCommand = New SqlCommand("DELETE From [Food_Table]
	            WHERE [FoodTableList]='" + tbxNameSelector.Text + "'", sqlcon) 'TODO, add date check, perhaps implement ID
                sqlcon.Open() 'opens connections
                sqlcmd.ExecuteNonQuery() 'Send the new item to database
                sqlcon.Close() 'closes connections
                UpdateGrid() 'updates the view
                LblStatus.Text = "Successfully Deleted: " & tbxNameSelector.Text
                LblStatus.ForeColor = Color.Green
                Exit Sub
            Else
                LblStatus.Text = "Record does not exist, check Name:"
                LblStatus.ForeColor = Color.Orange
            End If
        Next
    End Sub

    Private Sub ButterButtonSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ButterButtonSettingsToolStripMenuItem.Click
        formBTNShortCut.Show() ' opens the butter button meny
    End Sub
    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        My.Settings.FormCheck = 1
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

End Class