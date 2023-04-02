Public Class frmPayroll
    Const cdecFica = 0.0765D
    Const cdecFed = 0.22D
    Const cdecState = 0.04D
    Dim strIncome As String
    Dim decIncome As Decimal
    Dim decFica As Decimal
    Dim decFederal As Decimal
    Dim decState As Decimal
    Dim decNet As Decimal

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click, MyBase.Load
        'Clears the 4 selections and targets the textbox

        lblFederal.Text = ""
        lblFica.Text = ""
        lblState.Text = ""
        lblNet.Text = ""
        txtGross.Text = ""
        txtGross.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'closes the form
        Me.Close()

    End Sub

    Private Sub btnTaxCalc_Click(sender As Object, e As EventArgs) Handles btnTaxCalc.Click
        strIncome = txtGross.Text
        If IsNumeric(strIncome) Then
            decIncome = Convert.ToDecimal(txtGross.Text)
            decFica = decIncome * cdecFica
            decFederal = decIncome * cdecFed
            decState = decIncome * cdecState
            decNet = decIncome - (decFica + decFederal + decState)
            lblFica.Text = decFica.ToString("C")
            lblFederal.Text = decFederal.ToString("C")
            lblState.Text = decState.ToString("C")
            lblNet.Text = decNet.ToString("C")
        Else
            MsgBox("Please enter a valid amount", , "Input error")
        End If

    End Sub
End Class
