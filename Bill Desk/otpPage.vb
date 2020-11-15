Imports System.Data.SqlClient
Public Class otpPage
    Public otpCode As String

    Private Sub otpPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        transactNow.Enabled = False
        otpTxt.UseSystemPasswordChar = False
    End Sub

    Private Sub showOTP_Click(Sender As Object, e As EventArgs) Handles showOTP.Click
        If otpTxt.UseSystemPasswordChar = False Then
            otpTxt.UseSystemPasswordChar = True
        Else
            otpTxt.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub transactNow_Click(sender As Object, e As EventArgs) Handles transactNow.Click
        If otpTxt.Text = otpCode Then
            Me.Hide()
            Form1.Show()
            Call Form1.addData()
        Else
            MessageBox.Show("Invalid OTP. Please Enter the correct OTP")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles otpTxt.TextChanged
        If otpTxt.TextLength = 8 Then
            transactNow.Enabled = True
        Else
            transactNow.Enabled = False
        End If
    End Sub
End Class