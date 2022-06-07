Imports System.Data.SqlClient
Public Class FoodList
    ' SQL connection string
    Dim sqlcon As New SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Paradigm249\source\repos\CCS v3\CCS v3\CCS_V3.mdf;Integrated Security=True;Connect Timeout=30")


    Private Sub FoodList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateGrid()
    End Sub

    Private Sub BtnFoodImportButton_Click(sender As Object, e As EventArgs) Handles BtnFoodImportButton.Click
        ' store them as variables
        Dim BRAND As String = TbxFoodImportBrand.Text
        Dim NAME As String = TbxFoodImportName.Text
        Dim CALORIES As String = TbxFoodImportCal.Text
        Dim PROTEINS As String = TbxFoodImportProt.Text
        Dim CARBOHYDRATES As String = TbxFoodImportCarb.Text
        Dim SUGAR As String = TbxFoodImportSug.Text
        Dim FAT As String = TbxFoodImportFat.Text
        ' TODO: Idiot proof with default values and check for empty boxes

        If String.IsNullOrEmpty(TbxFoodImportName.Text) Then
            LblImportStatus.Text = "You need a name!"
            LblImportStatus.ForeColor = Color.Red
            Exit Sub
        Else
        End If

        If String.IsNullOrEmpty(BRAND) Then
            BRAND = "N/A"
        Else
            NAME = NAME & " (" & BRAND & ")"
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
        ' for later, double click on row to add to Main Menu

        MainMenu.tbxNameSelector.Text = Food_TableDataGridView.CurrentRow.Cells(0).Value.ToString
        MainMenu.tbxBrandSelector.Text = Food_TableDataGridView.CurrentRow.Cells(1).Value.ToString
        MainMenu.TbxCalSelector.Text = Food_TableDataGridView.CurrentRow.Cells(2).Value.ToString
        MainMenu.TbxProSelector.Text = Food_TableDataGridView.CurrentRow.Cells(3).Value.ToString
        MainMenu.TbxCarbSelector.Text = Food_TableDataGridView.CurrentRow.Cells(4).Value.ToString
        MainMenu.TbxSugSelector.Text = Food_TableDataGridView.CurrentRow.Cells(5).Value.ToString
        MainMenu.TbxFatSelector.Text = Food_TableDataGridView.CurrentRow.Cells(6).Value.ToString
        Me.Hide()






    End Sub

    Private Sub Food_TableDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Food_TableDataGridView.CellClick
        ' get Name of the first colum in that row when a cell is clicked is clicked
        TbxFoodImportName.Text = ""
        TbxFoodImportName.Text = Food_TableDataGridView.CurrentRow.Cells(0).Value.ToString
        TbxFoodImportBrand.Text = Food_TableDataGridView.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub TbxFoodImportCal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxFoodImportCal.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TbxFoodImportProt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxFoodImportProt.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TbxFoodImportCarb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxFoodImportCarb.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TbxFoodImportSug_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxFoodImportSug.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TbxFoodImportFat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxFoodImportFat.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub UpdateGrid()
        ' clears the DGV
        Food_TableDataGridView.Columns.Clear()
        Food_TableDataGridView.Rows.Clear()
        ' sets up the DGV
        Food_TableDataGridView.Columns.Add("TempFoodTableList", "Name")
        Food_TableDataGridView.Columns.Add("TempBrandTableList", "Brand")
        Food_TableDataGridView.Columns.Add("TempCalorieTableList", "Calories")
        Food_TableDataGridView.Columns.Add("TempProteinTableList", "Protein")
        Food_TableDataGridView.Columns.Add("TempCarbTableList", "Carbs")
        Food_TableDataGridView.Columns.Add("TempSugarTableList", "Sugar")
        Food_TableDataGridView.Columns.Add("TempFatTableList", "Fat")
        Food_TableDataGridView.Columns(0).Width = 200
        Food_TableDataGridView.Columns(1).Width = 150
        Food_TableDataGridView.Columns(2).Width = 70
        Food_TableDataGridView.Columns(3).Width = 70
        Food_TableDataGridView.Columns(4).Width = 70
        Food_TableDataGridView.Columns(5).Width = 70
        Food_TableDataGridView.Columns(6).Width = 70
        ' opens a connection and grabs 
        sqlcon.Open()
        Dim command As SqlClient.SqlCommand = sqlcon.CreateCommand()
        command.CommandText = "SELECT * FROM Food_Table"
        Dim SQLReader As SqlClient.SqlDataReader = command.ExecuteReader

        ' read the information from the SQL DB
        While SQLReader.Read()
            Food_TableDataGridView.Rows.Add({SQLReader.Item("FoodTableList"), SQLReader.Item("BrandTableList"), SQLReader.Item("CalorieTableList"),
                                            SQLReader.Item("ProteinTableList"), SQLReader.Item("CarbTableList"), SQLReader.Item("SugarTableList"), SQLReader.Item("FatTableList")})
        End While
        sqlcon.Close()

    End Sub

    Private Sub BtnClearTbx_Click(sender As Object, e As EventArgs) Handles BtnClearTbx.Click
        TbxFoodImportName.Text = ""
        TbxFoodImportBrand.Text = ""
        TbxFoodImportCal.Text = ""
        TbxFoodImportProt.Text = ""
        TbxFoodImportCarb.Text = ""
        TbxFoodImportSug.Text = ""
        TbxFoodImportFat.Text = ""
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
        ' deletes data TODO: have the user select the row and then delete it

        'checks if the record exists
        For i As Integer = 0 To Food_TableDataGridView.Rows.Count - 1
            If TbxFoodImportName.Text = Food_TableDataGridView.Rows(i).Cells(0).Value Then
                Dim sqlcmd As SqlCommand = New SqlCommand("DELETE From [Food_Table]
	            WHERE [FoodTableList]='" + TbxFoodImportName.Text + "'", sqlcon)
                sqlcon.Open() 'opens connections
                sqlcmd.ExecuteNonQuery() 'Send the new item to database
                sqlcon.Close() 'closes connections
                UpdateGrid() 'updates the view
                LblImportStatus.Text = "Successfully Deleted: " & TbxFoodImportName.Text & " by BRAND" ' TODO: add brand
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class