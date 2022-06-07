Imports System.IO
Imports System.Data.SqlClient

Public Class MainMenu
    Dim readMySettings As StreamReader



    Private Sub BtnSubmitCalc_Click(sender As Object, e As EventArgs) Handles btnSubmitCalc.Click
        ' Variables for the results of the calulation
        Dim calTotal As String
        Dim proTotal As String
        Dim carbTotal As String
        Dim sugTotal As String
        Dim fatTotal As String

        ' calculatiing the weight and values of said item and checks if the are all numeric, give you an error message if its not. TODO: Better
        If IsNumeric(TbxCalSelector.Text) And IsNumeric(tbxWeightSelector.Text) AndAlso IsNumeric(TbxFatSelector.Text) AndAlso
           IsNumeric(TbxProSelector.Text) AndAlso IsNumeric(TbxCarbSelector.Text) AndAlso IsNumeric(TbxSugSelector.Text) AndAlso
           tbxNameSelector.Text.Trim.Length > 0 AndAlso tbxBrandSelector.Text.Trim.Length > 0 Then
            calTotal = TbxCalSelector.Text / 100 * tbxWeightSelector.Text
            proTotal = TbxProSelector.Text / 100 * tbxWeightSelector.Text
            carbTotal = TbxCarbSelector.Text / 100 * tbxWeightSelector.Text
            sugTotal = TbxSugSelector.Text / 100 * tbxWeightSelector.Text
            fatTotal = TbxFatSelector.Text / 100 * tbxWeightSelector.Text


            Dim sqlcon As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Paradigm249\source\repos\CCS v3\CCS v3\CCS_V3.mdf;Integrated Security=True;Connect Timeout=30")
            Dim sqlcmd As SqlCommand = New SqlCommand("INSERT INTO [Food_History_table]
                ([History_Name]
                ,[History_Brand]
                ,[History_Calories]
                ,[History_Protein]
                ,[History_Carbohydrates]
                ,[History_Sugar]
                ,[History_Fat]
                ,[History_Date])
            VALUES
                ('" + tbxNameSelector.Text + "','" + tbxBrandSelector.Text + "','" + calTotal + "','" + proTotal +
                "','" + carbTotal + "','" + sugTotal + "','" + fatTotal + "', '" + dtpStatistic.Text + "')", sqlcon)
            sqlcon.Open()
            sqlcmd.ExecuteNonQuery()
            sqlcon.Close()
            LblStatus.Text = (tbxNameSelector.Text & " By " & tbxBrandSelector.Text & "added")
            LblStatus.ForeColor = Color.Green

            Call UpdateLabel()
        Else
            MsgBox("you done goof")
        End If


    End Sub

    Private Sub AButtonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AButtonToolStripMenuItem.Click
        'opens the settings menu for the butter button
        formBTNShortCut.Show()
    End Sub

    Private Sub BtnButter_Click(sender As Object, e As EventArgs) Handles btnButter1.Click

        If File.Exists("C:\Users\Paradigm249\Dropbox\Documents\CCS_V3\CCS_V3_Settings.txt") Then
            'load the settings when the button is used
            readMySettings = New IO.StreamReader("C:\Users\Paradigm249\Dropbox\Documents\CCS_V3\CCS_V3_Settings.txt")

            ' add its too the list, note to self: readline reads the next line after reading the first one
            Dim a As String ' used to skip a line
            a = readMySettings.ReadLine
            readMySettings.Close() ' closes the meny after submitting
            Call UpdateLabel()
        Else
        End If



    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CCS_V3DataSet.Food_History_table' table. You can move, or remove it, as needed.

        If File.Exists("C:\Users\Paradigm249\Dropbox\Documents\CCS_V3\CCS_V3_Settings.txt") Then
            readMySettings = New IO.StreamReader("C:\Users\Paradigm249\Dropbox\Documents\CCS_V3\CCS_V3_Settings.txt")
            btnButter1.Text = readMySettings.ReadLine
            readMySettings.Close()
        Else
        End If



    End Sub


    Private Sub BbxNameSelector_TextChanged(sender As Object, e As EventArgs) Handles tbxNameSelector.DoubleClick
        FoodList.Show()
    End Sub
    Public Function UpdateLabel() ' updates the label, saves resources, returns no Values
        Dim intCalSum As Decimal
        Dim intProtSum As Decimal
        Dim intCarbSum As Decimal
        Dim intSugSum As Decimal
        Dim intFatSum As Decimal

        ' summerizes the data grid for you, so you dont have to.
        'For i = 0 To dgvTempList.Rows.Count - 1
        'intCalSum += dgvTempList.Rows(i).Cells(2).Value
        'intProtSum += dgvTempList.Rows(i).Cells(3).Value
        'intCarbSum += dgvTempList.Rows(i).Cells(4).Value
        ' intSugSum += dgvTempList.Rows(i).Cells(5).Value
        ' intFatSum += dgvTempList.Rows(i).Cells(6).Value
        ' Next

        ' updates the labels
        LblSumCal.Text = intCalSum
        LblSumProt.Text = intProtSum
        LblSumCarb.Text = intCarbSum
        LblSumSug.Text = intSugSum
        LblSumFat.Text = intFatSum
    End Function

    Public Function UpdateSumary()


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
        Dim ch As Char = e.KeyChar 'Ensures that only Numbers are passed
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TbxProSelector_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxProSelector.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TbxCarbSelector_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxCarbSelector.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TbxSugSelector_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxSugSelector.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TbxFatSelector_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxFatSelector.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbxWeightSelector_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxWeightSelector.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DgvTemp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTemp.CellContentClick
        tbxNameSelector.Text = DgvTemp.CurrentRow.Cells(0).Value.ToString
        tbxBrandSelector.Text = DgvTemp.CurrentRow.Cells(1).Value.ToString
        TbxCalSelector.Text = DgvTemp.CurrentRow.Cells(2).Value.ToString
        TbxProSelector.Text = DgvTemp.CurrentRow.Cells(3).Value.ToString
        TbxCarbSelector.Text = DgvTemp.CurrentRow.Cells(4).Value.ToString
        TbxSugSelector.Text = DgvTemp.CurrentRow.Cells(2).Value.ToString
        TbxFatSelector.Text = DgvTemp.CurrentRow.Cells(2).Value.ToString




    End Sub
End Class
