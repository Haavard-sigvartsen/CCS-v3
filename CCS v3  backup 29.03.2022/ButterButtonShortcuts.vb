Public Class formBTNShortCut
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnShortCutSubmit_Click(sender As Object, e As EventArgs) Handles btnShortCutSubmit.Click

        ' checks the input, then creates a setting file to store settings, such as the butter button
        If IsNumeric(tbxNewShortCutCal.Text) And IsNumeric(tbxNewShortCutProt.Text) AndAlso IsNumeric(tbxNewShortCutCarb.Text) AndAlso
           IsNumeric(tbxNewShortCutSug.Text) AndAlso IsNumeric(tbxNewShortCutFat.Text) AndAlso
           tbxNewShortCutName.Text.Trim.Length > 0 AndAlso tbxNewShortCutBrand.Text.Trim.Length > 0 Then
            Dim mySettings As IO.StreamWriter
            mySettings = New IO.StreamWriter("C:\Users\Paradigm249\Dropbox\Documents\CCS_V3\CCS_V3_Settings.txt")
            mySettings.WriteLine(tbxNewShortCutButtonName.Text)
            mySettings.WriteLine(tbxNewShortCutName.Text)
            mySettings.WriteLine(tbxNewShortCutBrand.Text)
            mySettings.WriteLine(tbxNewShortCutCal.Text)
            mySettings.WriteLine(tbxNewShortCutProt.Text)
            mySettings.WriteLine(tbxNewShortCutCarb.Text)
            mySettings.WriteLine(tbxNewShortCutSug.Text)
            mySettings.WriteLine(tbxNewShortCutFat.Text)
            mySettings.Close()

            ' exits and saves
            Me.Close()
        Else
            MsgBox("you fucking donkey")
        End If

    End Sub
End Class