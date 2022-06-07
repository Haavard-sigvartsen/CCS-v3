Imports System.Data.SqlClient
Public Class formBTNShortCut
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UpdateAutoCorrect()

    End Sub

    Sub FillTBX(ButtonName, FName, BrandName, Weight, Calorie, Protein, Carbs, Sugar, Fat)
        TbxNewShortCutButtonName.Text = ButtonName
        CbNewShortCutName.Text = FName
        TbxNewShortCutBrand.Text = BrandName
        TbxNewShortCutWeight.Text = Weight
        TbxNewShortCutCal.Text = Calorie
        TbxNewShortCutProt.Text = Protein
        TbxNewShortCutCarb.Text = Carbs
        TbxNewShortCutSug.Text = Sugar
        TbxNewShortCutFat.Text = Fat
    End Sub

    Public Function UpdateBBSumary()

        ' prevent errors when calculating with zero's
        If IsNumeric(TbxNewShortCutWeight.Text) Then
            If IsNumeric(LblCal.Text) Then
                TbxNewShortCutCal.Text = LblCal.Text / 100 * TbxNewShortCutWeight.Text
            Else

            End If
            If IsNumeric(LblProt.Text) Then
                TbxNewShortCutProt.Text = LblProt.Text / 100 * TbxNewShortCutWeight.Text
            Else

            End If
            If IsNumeric(LblCarb.Text) Then
                TbxNewShortCutCarb.Text = LblCarb.Text / 100 * TbxNewShortCutWeight.Text
            Else

            End If
            If IsNumeric(LblSug.Text) Then
                TbxNewShortCutSug.Text = LblSug.Text / 100 * TbxNewShortCutWeight.Text
            Else

            End If
            If IsNumeric(LblFat.Text) Then
                TbxNewShortCutFat.Text = LblFat.Text / 100 * TbxNewShortCutWeight.Text
            Else

            End If

        End If
    End Function

    Private Sub BtnShortCutSubmit_Click(sender As Object, e As EventArgs) Handles btnSaveAndExit.Click

        ' checks the input, then save the settings
        If IsNumeric(TbxNewShortCutCal.Text) And IsNumeric(TbxNewShortCutProt.Text) AndAlso IsNumeric(TbxNewShortCutCarb.Text) AndAlso
           IsNumeric(TbxNewShortCutSug.Text) AndAlso IsNumeric(TbxNewShortCutFat.Text) AndAlso IsNumeric(TbxNewShortCutWeight.Text) AndAlso
           CbNewShortCutName.Text.Trim.Length > 0 Then

            ' will save settings and exit
            If CBButterButttonSelector.SelectedItem = "Button 1" Then
                My.Settings.ButterButton1 = TbxNewShortCutButtonName.Text & "," & CbNewShortCutName.Text & "," & TbxNewShortCutBrand.Text & "," &
            TbxNewShortCutWeight.Text & "," & TbxNewShortCutCal.Text & "," & TbxNewShortCutProt.Text & "," & TbxNewShortCutCarb.Text & "," &
        TbxNewShortCutSug.Text & "," & TbxNewShortCutFat.Text
            ElseIf CBButterButttonSelector.SelectedItem = "Button 2" Then
                My.Settings.ButterButton2 = TbxNewShortCutButtonName.Text & "," & CbNewShortCutName.Text & "," & TbxNewShortCutBrand.Text & "," &
            TbxNewShortCutWeight.Text & "," & TbxNewShortCutCal.Text & "," & TbxNewShortCutProt.Text & "," & TbxNewShortCutCarb.Text & "," &
        TbxNewShortCutSug.Text & "," & TbxNewShortCutFat.Text
            ElseIf CBButterButttonSelector.SelectedItem = "Button 3" Then
                My.Settings.ButterButton3 = TbxNewShortCutButtonName.Text & "," & CbNewShortCutName.Text & "," & TbxNewShortCutBrand.Text & "," &
            TbxNewShortCutWeight.Text & "," & TbxNewShortCutCal.Text & "," & TbxNewShortCutProt.Text & "," & TbxNewShortCutCarb.Text & "," &
        TbxNewShortCutSug.Text & "," & TbxNewShortCutFat.Text
            ElseIf CBButterButttonSelector.SelectedItem = "Button 4" Then
                My.Settings.ButterButton4 = TbxNewShortCutButtonName.Text & "," & CbNewShortCutName.Text & "," & TbxNewShortCutBrand.Text & "," &
            TbxNewShortCutWeight.Text & "," & TbxNewShortCutCal.Text & "," & TbxNewShortCutProt.Text & "," & TbxNewShortCutCarb.Text & "," &
        TbxNewShortCutSug.Text & "," & TbxNewShortCutFat.Text
            ElseIf CBButterButttonSelector.SelectedItem = "Button 5" Then
                My.Settings.ButterButton5 = TbxNewShortCutButtonName.Text & "," & CbNewShortCutName.Text & "," & TbxNewShortCutBrand.Text & "," &
            TbxNewShortCutWeight.Text & "," & TbxNewShortCutCal.Text & "," & TbxNewShortCutProt.Text & "," & TbxNewShortCutCarb.Text & "," &
        TbxNewShortCutSug.Text & "," & TbxNewShortCutFat.Text
            ElseIf CBButterButttonSelector.SelectedItem IsNot Nothing Then
            End If

            ' changes the status
            StatusLbl.Text = "Changes Saved on " & CBButterButttonSelector.SelectedItem
            StatusLbl.ForeColor = Color.Green
            'updates the butter button names
            Dim tempArray1() As String = My.Settings.ButterButton1.Split(",")
            MainMenu.btnButter1.Text = tempArray1(0)
            Dim tempArray2() As String = My.Settings.ButterButton2.Split(",")
            MainMenu.btnButter2.Text = tempArray2(0)
            Dim tempArray3() As String = My.Settings.ButterButton3.Split(",")
            MainMenu.btnButter3.Text = tempArray3(0)
            Dim tempArray4() As String = My.Settings.ButterButton4.Split(",")
            MainMenu.btnButter4.Text = tempArray4(0)
            Dim tempArray5() As String = My.Settings.ButterButton5.Split(",")
            MainMenu.btnButter5.Text = tempArray5(0)
            Me.Close()
        Else
            StatusLbl.Text = "error, check parameters"
            StatusLbl.ForeColor = Color.Red
        End If

    End Sub

    Private Sub CBButterButttonSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBButterButttonSelector.SelectedIndexChanged
        ' loads current settings when the index is changed
        Dim TempArray() As String
        If CBButterButttonSelector.SelectedItem = "Button 1" Then
            TempArray = My.Settings.ButterButton1.Split("-")
            Call FillTBX(TempArray(0), TempArray(1), TempArray(2), TempArray(3), TempArray(4), TempArray(5), TempArray(6), TempArray(7), TempArray(8))
        ElseIf CBButterButttonSelector.SelectedItem = "Button 2" Then
            TempArray = My.Settings.ButterButton2.Split("-")
            Call FillTBX(TempArray(0), TempArray(1), TempArray(2), TempArray(3), TempArray(4), TempArray(5), TempArray(6), TempArray(7), TempArray(8))
        ElseIf CBButterButttonSelector.SelectedItem = "Button 3" Then
            TempArray = My.Settings.ButterButton3.Split("-")
            Call FillTBX(TempArray(0), TempArray(1), TempArray(2), TempArray(3), TempArray(4), TempArray(5), TempArray(6), TempArray(7), TempArray(8))
        ElseIf CBButterButttonSelector.SelectedItem = "Button 4" Then
            TempArray = My.Settings.ButterButton4.Split("-")
            Call FillTBX(TempArray(0), TempArray(1), TempArray(2), TempArray(3), TempArray(4), TempArray(5), TempArray(6), TempArray(7), TempArray(8))
        ElseIf CBButterButttonSelector.SelectedItem = "Button 5" Then
            TempArray = My.Settings.ButterButton5.Split("-")
            Call FillTBX(TempArray(0), TempArray(1), TempArray(2), TempArray(3), TempArray(4), TempArray(5), TempArray(6), TempArray(7), TempArray(8))
        ElseIf CBButterButttonSelector.SelectedItem IsNot Nothing Then
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ' will just save the settings
        If IsNumeric(TbxNewShortCutCal.Text) And IsNumeric(TbxNewShortCutProt.Text) AndAlso IsNumeric(TbxNewShortCutCarb.Text) AndAlso
   IsNumeric(TbxNewShortCutSug.Text) AndAlso IsNumeric(TbxNewShortCutFat.Text) AndAlso IsNumeric(TbxNewShortCutWeight.Text) AndAlso
   CbNewShortCutName.Text.Trim.Length > 0 AndAlso TbxNewShortCutBrand.Text.Trim.Length > 0 Then

            ' will save settings
            If CBButterButttonSelector.SelectedItem = "Button 1" Then
                My.Settings.ButterButton1 = TbxNewShortCutButtonName.Text & "-" & CbNewShortCutName.Text & "-" & TbxNewShortCutBrand.Text & "-" &
            TbxNewShortCutWeight.Text & "-" & TbxNewShortCutCal.Text & "-" & TbxNewShortCutProt.Text & "-" & TbxNewShortCutCarb.Text & "-" &
        TbxNewShortCutSug.Text & "-" & TbxNewShortCutFat.Text
            ElseIf CBButterButttonSelector.SelectedItem = "Button 2" Then
                My.Settings.ButterButton2 = TbxNewShortCutButtonName.Text & "-" & CbNewShortCutName.Text & "-" & TbxNewShortCutBrand.Text & "-" &
            TbxNewShortCutWeight.Text & "-" & TbxNewShortCutCal.Text & "-" & TbxNewShortCutProt.Text & "-" & TbxNewShortCutCarb.Text & "-" &
        TbxNewShortCutSug.Text & "-" & TbxNewShortCutFat.Text
            ElseIf CBButterButttonSelector.SelectedItem = "Button 3" Then
                My.Settings.ButterButton3 = TbxNewShortCutButtonName.Text & "-" & CbNewShortCutName.Text & "-" & TbxNewShortCutBrand.Text & "-" &
            TbxNewShortCutWeight.Text & "-" & TbxNewShortCutCal.Text & "-" & TbxNewShortCutProt.Text & "-" & TbxNewShortCutCarb.Text & "-" &
        TbxNewShortCutSug.Text & "-" & TbxNewShortCutFat.Text
            ElseIf CBButterButttonSelector.SelectedItem = "Button 4" Then
                My.Settings.ButterButton4 = TbxNewShortCutButtonName.Text & "-" & CbNewShortCutName.Text & "-" & TbxNewShortCutBrand.Text & "-" &
            TbxNewShortCutWeight.Text & "-" & TbxNewShortCutCal.Text & "-" & TbxNewShortCutProt.Text & "-" & TbxNewShortCutCarb.Text & "-" &
        TbxNewShortCutSug.Text & "-" & TbxNewShortCutFat.Text
            ElseIf CBButterButttonSelector.SelectedItem = "Button 5" Then
                My.Settings.ButterButton5 = TbxNewShortCutButtonName.Text & "-" & CbNewShortCutName.Text & "-" & TbxNewShortCutBrand.Text & "-" &
            TbxNewShortCutWeight.Text & "-" & TbxNewShortCutCal.Text & "-" & TbxNewShortCutProt.Text & "-" & TbxNewShortCutCarb.Text & "-" &
        TbxNewShortCutSug.Text & "-" & TbxNewShortCutFat.Text
            ElseIf CBButterButttonSelector.SelectedItem IsNot Nothing Then
            End If

            ' changes the status
            StatusLbl.Text = "Changes Saved on " & CBButterButttonSelector.SelectedItem
            StatusLbl.ForeColor = Color.Green
            'updates the butter button names
            Dim tempArray1() As String = My.Settings.ButterButton1.Split(",")
            MainMenu.btnButter1.Text = tempArray1(0)
            Dim tempArray2() As String = My.Settings.ButterButton2.Split(",")
            MainMenu.btnButter2.Text = tempArray2(0)
            Dim tempArray3() As String = My.Settings.ButterButton3.Split(",")
            MainMenu.btnButter3.Text = tempArray3(0)
            Dim tempArray4() As String = My.Settings.ButterButton4.Split(",")
            MainMenu.btnButter4.Text = tempArray4(0)
            Dim tempArray5() As String = My.Settings.ButterButton5.Split(",")
            MainMenu.btnButter5.Text = tempArray5(0)
        Else
            StatusLbl.Text = "error, check parameters"
            StatusLbl.ForeColor = Color.Red
        End If
    End Sub

    Private Sub BtnFIll_Click(sender As Object, e As EventArgs) Handles BtnFIll.Click
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
            If String.Compare(CbNewShortCutName.Text, ButtoFillTempDT.Rows(i).Field(Of String)("FoodTableList"), True) = 0 Then
                ' if it finds a match, it will grab the rest of the values in that row, and fill in the text boxes
                CbNewShortCutName.Text = ButtoFillTempDT.Rows(i).Field(Of String)("FoodTableList")
                TbxNewShortCutBrand.Text = ButtoFillTempDT.Rows(i).Field(Of String)("BrandTableList")
                LblCal.Text = ButtoFillTempDT.Rows(i).Field(Of Decimal)("CalorieTableList")
                LblProt.Text = ButtoFillTempDT.Rows(i).Field(Of Decimal)("ProteinTableList")
                LblCarb.Text = ButtoFillTempDT.Rows(i).Field(Of Decimal)("CarbTableList")
                LblSug.Text = ButtoFillTempDT.Rows(i).Field(Of Decimal)("SugarTableList")
                LblFat.Text = ButtoFillTempDT.Rows(i).Field(Of Decimal)("FatTableList")

                StatusLbl.Text = (CbNewShortCutName.Text & " found")
                StatusLbl.ForeColor = Color.Green
                TbxNewShortCutWeight.Focus() 'focuses on the weight txt box after entering finding a match

                Exit Sub
            Else
                ' if everything does not match it will do nothing
                StatusLbl.Text = (CbNewShortCutName.Text & " Not Found, check spelling")
                StatusLbl.ForeColor = Color.Red
            End If
        Next
    End Sub

    Private Sub CbNewShortCutName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNewShortCutName.TextChanged
        UpdateBBSumary()
    End Sub

    Private Sub tbxNewShortCutWeight_TextChanged(sender As Object, e As EventArgs) Handles TbxNewShortCutWeight.TextChanged
        UpdateBBSumary()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        My.Settings.TempGrid = 2
        FoodList.Show() ' opens up the food list
    End Sub
    Private Sub CbNewShortCutName_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CbNewShortCutName.SelectedIndexChanged
        CbNewShortCutName.SelectAll()
    End Sub
    Private Sub tbxNewShortCutWeight_MouseDown(sender As Object, e As MouseEventArgs) Handles TbxNewShortCutWeight.MouseDown
        TbxNewShortCutWeight.SelectAll()
    End Sub

    Private Sub tbxNewShortCutCal_MouseDown(sender As Object, e As MouseEventArgs) Handles TbxNewShortCutCal.MouseDown
        TbxNewShortCutCal.SelectAll()
    End Sub

    Private Sub tbxNewShortCutProt_MouseDown(sender As Object, e As MouseEventArgs) Handles TbxNewShortCutProt.MouseDown
        TbxNewShortCutProt.SelectAll()
    End Sub

    Private Sub tbxNewShortCutCarb_MouseDown(sender As Object, e As MouseEventArgs) Handles TbxNewShortCutCarb.MouseDown
        TbxNewShortCutCarb.SelectAll()
    End Sub

    Private Sub tbxNewShortCutSug_MouseDown(sender As Object, e As MouseEventArgs) Handles TbxNewShortCutSug.MouseDown
        TbxNewShortCutSug.SelectAll()
    End Sub

    Private Sub tbxNewShortCutFat_MouseDown(sender As Object, e As MouseEventArgs) Handles TbxNewShortCutFat.MouseDown
        TbxNewShortCutFat.SelectAll()
    End Sub

    Private Sub TbxNewShortCutButtonName_MouseDown(sender As Object, e As MouseEventArgs) Handles TbxNewShortCutButtonName.MouseDown
        TbxNewShortCutButtonName.SelectAll()
    End Sub

    Private Sub TbxNewShortCutBrand_MouseDown(sender As Object, e As MouseEventArgs) Handles TbxNewShortCutBrand.MouseDown
        TbxNewShortCutBrand.SelectAll()
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

        CbNewShortCutName.AutoCompleteSource = AutoCompleteSource.CustomSource
        CbNewShortCutName.AutoCompleteCustomSource = autoCorrect
        CbNewShortCutName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Function

    Private Sub CbNewShortCutName_KeyDown(sender As Object, e As KeyEventArgs) Handles CbNewShortCutName.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CbNewShortCutName.Text.Length > 0 Then
                BtnFIll.PerformClick()
            Else
            End If
        Else
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) 
        MsgBox(My.Settings.ButterButton1)
    End Sub
End Class