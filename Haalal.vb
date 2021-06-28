Public Class Haalal
    Dim strHalalOthr, strHalal As String
    Private Sub BtnSendHaalal_Click(sender As Object, e As EventArgs) Handles BtnSendHaalal.Click
        MessageBox.Show("Your Order has been Taken to the kitchen", "Food Ordered!!!", MessageBoxButtons.OK)
        Application.Exit()
    End Sub

    Private Sub BtnExitHaalal_Click(sender As Object, e As EventArgs) Handles BtnExitHaalal.Click
        Application.Exit()
    End Sub

    Private Sub BtnSpecific_Click(sender As Object, e As EventArgs) Handles BtnSpecific.Click

        strHalalOthr = InputBox("Please Specify Your Specific Meal")

        ' lblOtherAllergy.Text = strOthr

        If MessageBox.Show("is there Anything else?", "Oher", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            strHalal = InputBox("Please Specify Other Meal Type")

        End If

        lblHalaal.Text = ControlChars.NewLine + ControlChars.NewLine +
            ControlChars.NewLine + strHalal + ControlChars.NewLine + strHalalOthr
    End Sub
End Class