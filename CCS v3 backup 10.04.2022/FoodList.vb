Imports System.Data.SqlClient
Public Class FoodList
    ' SQL connection string
    Dim sqlcon As New SqlClient.SqlConnection(My.Settings.CCS_V3ConnectionString)



    Private Sub FoodList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateGrid()


    End Sub

    Private Sub BtnFoodImportButton_Click(sender As Object, e As EventArgs) Handles BtnFoodImportButton.Click
        ' store them as variables
        Dim BRAND As String = TbxFoodImportBrand.Text
        Dim NAME As String = TbxFoodImportName.Text
        Dim CALORIES As Decimal = TbxFoodImportCal.Text
        Dim PROTEINS As Decimal = TbxFoodImportProt.Text
        Dim CARBOHYDRATES As Decimal = TbxFoodImportCarb.Text
        Dim SUGAR As Decimal = TbxFoodImportSug.Text
        Dim FAT As Decimal = TbxFoodImportFat.Text

        If String.IsNullOrEmpty(TbxFoodImportName.Text) Then
            LblImportStatus.Text = "You need a name!"
            LblImportStatus.ForeColor = Color.Red
            Exit Sub
        Else
        End If

        If String.IsNullOrEmpty(BRAND) Then
            BRAND = "N/A"
        Else
        End If
        If String.IsNullOrEmpty(CALORIES) Then
            CALORIES = "1"
        Else
        End If
        If String.IsNullOrEmpty(PROTEINS) Then
            PROTEINS = "0"
        Else
        End If
        If String.IsNullOrEmpty(CARBOHYDRATES) Then
            CARBOHYDRATES = "0"
        Else
        End If
        If String.IsNullOrEmpty(SUGAR) Then
            SUGAR = "0"
        Else
        End If
        If String.IsNullOrEmpty(FAT) Then
            FAT = "0"
        Else
        End If
        'checks for duplicates, just to prevent the app from crashing, easier this way
        For i As Integer = 0 To Food_TableDataGridView.Rows.Count - 1
            If String.Compare(TbxFoodImportName.Text, Food_TableDataGridView.Rows(i).Cells(0).Value, True) = 0 Then
                ' if it finds a dupe, it will end the
                LblImportStatus.Text = "Duplicated Names not allowed"
                LblImportStatus.ForeColor = Color.Red
                Exit Sub
            Else
                ' if everything is fine it will continue to the next procedure
            End If
        Next
        Dim queryWrite As String = "INSERT INTO Food_Table VALUES (@FoodTableList,@BrandTableList,@CalorieTableList,@ProteinTableList,@CarbTableList,@SugarTableList,@FatTableList)"
        Dim table As New DataSet
        Using sqlcmd As SqlCommand = New SqlCommand(queryWrite, sqlcon)
            sqlcmd.Parameters.AddWithValue("@FoodTableList", NAME)
            sqlcmd.Parameters.AddWithValue("@BrandTableList", BRAND)
            sqlcmd.Parameters.AddWithValue("@CalorieTableList", CALORIES)
            sqlcmd.Parameters.AddWithValue("@ProteinTableList", PROTEINS)
            sqlcmd.Parameters.AddWithValue("@CarbTableList", CARBOHYDRATES)
            sqlcmd.Parameters.AddWithValue("@SugarTableList", SUGAR)
            sqlcmd.Parameters.AddWithValue("@FatTableList", FAT)

            sqlcon.Open() 'opens connections
            sqlcmd.ExecuteNonQuery() 'Send the new item to database
            sqlcon.Close() 'closes connections
            UpdateGrid() 'updates the view

            ' serotonin feedback
            LblImportStatus.Text = "Successfully import: " & NAME
            LblImportStatus.ForeColor = Color.Green
        End Using
    End Sub

    Private Sub Food_TableDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Food_TableDataGridView.CellDoubleClick

        ' when form is opened, it will return a value, 1 is from the Main Menu, 2 is from the ButterButton, any other will throw and "error"
        If My.Settings.FormCheck = 1 Then
            MainMenu.tbxNameSelector.Text = Food_TableDataGridView.CurrentRow.Cells(0).Value.ToString
            MainMenu.tbxBrandSelector.Text = Food_TableDataGridView.CurrentRow.Cells(1).Value.ToString
            MainMenu.TbxCalSelector.Text = Food_TableDataGridView.CurrentRow.Cells(2).Value.ToString
            MainMenu.TbxProSelector.Text = Food_TableDataGridView.CurrentRow.Cells(3).Value.ToString
            MainMenu.TbxCarbSelector.Text = Food_TableDataGridView.CurrentRow.Cells(4).Value.ToString
            MainMenu.TbxSugSelector.Text = Food_TableDataGridView.CurrentRow.Cells(5).Value.ToString
            MainMenu.TbxFatSelector.Text = Food_TableDataGridView.CurrentRow.Cells(6).Value.ToString
            Me.Close()
        ElseIf My.Settings.FormCheck = 2 Then
            formBTNShortCut.CbNewShortCutName.Text = Food_TableDataGridView.CurrentRow.Cells(0).Value.ToString
            formBTNShortCut.tbxNewShortCutBrand.Text = Food_TableDataGridView.CurrentRow.Cells(1).Value.ToString
            formBTNShortCut.LblCal.Text = Food_TableDataGridView.CurrentRow.Cells(2).Value.ToString
            formBTNShortCut.LblProt.Text = Food_TableDataGridView.CurrentRow.Cells(3).Value.ToString
            formBTNShortCut.LblCarb.Text = Food_TableDataGridView.CurrentRow.Cells(4).Value.ToString
            formBTNShortCut.LblSug.Text = Food_TableDataGridView.CurrentRow.Cells(5).Value.ToString
            formBTNShortCut.LblFat.Text = Food_TableDataGridView.CurrentRow.Cells(6).Value.ToString
            Me.Close()
        Else
            MsgBox("There was an error checking which form was opening, this form will close")
            Me.Close()
        End If




    End Sub

    Private Sub Food_TableDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Food_TableDataGridView.CellClick
        ' get Name of the first colum in that row when a cell is clicked is clicked
        TbxFoodImportName.Text = ""
        TbxFoodImportName.Text = Food_TableDataGridView.CurrentRow.Cells(0).Value.ToString
        TbxFoodImportBrand.Text = Food_TableDataGridView.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub TbxFoodImportCal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxFoodImportCal.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub

    Private Sub TbxFoodImportProt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxFoodImportProt.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub

    Private Sub TbxFoodImportCarb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxFoodImportCarb.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub

    Private Sub TbxFoodImportSug_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxFoodImportSug.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub

    Private Sub TbxFoodImportFat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxFoodImportFat.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
        End If
    End Sub

    Private Sub UpdateGrid()

        sqlcon.Open()
        ' grabs the rows, filtered by date of day choosen by the Date Time Picker in statistc box
        Dim sqlcmd As New SqlCommand("SELECT * FROM Food_Table", sqlcon)
        Dim SqlDa As New SqlDataAdapter
        SqlDa.SelectCommand = sqlcmd
        Dim tempDT As New DataTable
        tempDT.Clear()
        SqlDa.Fill(tempDT)
        ' sets the columns name, so it looks nicer
        tempDT.Columns(0).ColumnName = "Name"
        tempDT.Columns(1).ColumnName = "Brand"
        tempDT.Columns(2).ColumnName = "Calories"
        tempDT.Columns(3).ColumnName = "Proteins"
        tempDT.Columns(4).ColumnName = "Carbohydrates"
        tempDT.Columns(5).ColumnName = "Sugar"
        tempDT.Columns(6).ColumnName = "Fat"

        Food_TableDataGridView.DataSource = tempDT
        sqlcon.Close()
        Food_TableDataGridView.Columns(0).Width = 200
        Food_TableDataGridView.Columns(1).Width = 150
        Food_TableDataGridView.Columns(2).Width = 70
        Food_TableDataGridView.Columns(3).Width = 70
        Food_TableDataGridView.Columns(4).Width = 70
        Food_TableDataGridView.Columns(5).Width = 70
        Food_TableDataGridView.Columns(6).Width = 70

    End Sub

    Private Sub BtnClearTbx_Click(sender As Object, e As EventArgs) Handles BtnClearTbx.Click
        'clears the text boxes, duh
        TbxFoodImportName.Text = ""
        TbxFoodImportBrand.Text = ""
        TbxFoodImportCal.Text = ""
        TbxFoodImportProt.Text = ""
        TbxFoodImportCarb.Text = ""
        TbxFoodImportSug.Text = ""
        TbxFoodImportFat.Text = ""
        TbxSearchName.Text = ""
        TbxSearchBrand.Text = ""
    End Sub

    Private Sub BtnFoodUpdate_Click(sender As Object, e As EventArgs) Handles BtnFoodUpdate.Click
        ' updates the record
        If IsNumeric(TbxFoodImportCal.Text) And IsNumeric(TbxFoodImportProt.Text) AndAlso IsNumeric(TbxFoodImportCarb.Text) AndAlso
           IsNumeric(TbxFoodImportSug.Text) AndAlso IsNumeric(TbxFoodImportSug.Text) AndAlso IsNumeric(TbxFoodImportFat.Text) AndAlso
           TbxFoodImportName.Text <> "" AndAlso TbxFoodImportBrand.Text <> "" Then

            Dim cmd As SqlCommand = New SqlCommand("UPDATE [Food_Table]
	    SET [FoodTableList] = '" + TbxFoodImportName.Text + "',[BrandTableList] = '" + TbxFoodImportBrand.Text +
        "',[CalorieTableList] = '" + TbxFoodImportCal.Text + "',[ProteinTableList] = '" + TbxFoodImportProt.Text +
        "',[CarbTableList] = '" + TbxFoodImportCarb.Text + "',[SugarTableList] = '" + TbxFoodImportSug.Text +
        "',[FatTableList] = '" + TbxFoodImportFat.Text + "'WHERE [FoodTableList]= '" + TbxFoodImportName.Text + "'", sqlcon)

            sqlcon.Open() 'opens connections
            cmd.ExecuteNonQuery() 'Send the new item to database
            sqlcon.Close() 'closes connections
            UpdateGrid() 'updates the view
            LblImportStatus.Text = "Successfully Updated: " & TbxFoodImportName.Text
            LblImportStatus.ForeColor = Color.Green
        Else
            LblImportStatus.Text = "All Text Boxes must be filled to Update"
            LblImportStatus.ForeColor = Color.Red
        End If
    End Sub

    Private Sub BtnFoodDelete_Click(sender As Object, e As EventArgs) Handles BtnFoodDelete.Click

        'checks if the record exists
        For i As Integer = 0 To Food_TableDataGridView.Rows.Count - 1
            If TbxFoodImportName.Text = Food_TableDataGridView.Rows(i).Cells(0).Value Then
                Dim sqlcmd As SqlCommand = New SqlCommand("DELETE From [Food_Table]
	            WHERE [FoodTableList]='" + TbxFoodImportName.Text + "'", sqlcon)
                sqlcon.Open() 'opens connections
                sqlcmd.ExecuteNonQuery() 'Send the new item to database
                sqlcon.Close() 'closes connections
                UpdateGrid() 'updates the view
                LblImportStatus.Text = "Successfully Deleted: " & TbxFoodImportName.Text
                LblImportStatus.ForeColor = Color.Green
                Exit Sub
            Else
                LblImportStatus.Text = "Record does not exist, check Name:"
                LblImportStatus.ForeColor = Color.Orange
            End If
        Next

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        For i As Integer = 0 To Food_TableDataGridView.Rows.Count - 1
            If TbxFoodImportName.Text = Food_TableDataGridView.Rows(i).Cells(0).Value Then
                MsgBox("there was a dupe")
                Exit Sub
            Else
                MsgBox("there is no dupes")
                Exit Sub
            End If
        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TbxSearchName.TextChanged
        TryCast(Food_TableDataGridView.DataSource, DataTable).DefaultView.RowFilter = String.Format("Name LIKE '" & TbxSearchName.Text & "%'")

    End Sub

    Private Sub TbxSearchBrand_TextChanged(sender As Object, e As EventArgs) Handles TbxSearchBrand.TextChanged
        TryCast(Food_TableDataGridView.DataSource, DataTable).DefaultView.RowFilter = String.Format("Brand LIKE '" & TbxSearchBrand.Text & "%'")

    End Sub
End Class