Imports System.Data.SqlClient
Imports Twilio
Imports Twilio.Rest.Api.V2010.Account
Imports Twilio.Types

Public Class Form1
    Dim Connection As New SqlConnection("Server=DESKTOP-7R2NPEI\SQLEXPRESS; Database=Transaction Data; Integrated Security = True")
    Dim dt_time As String
    Dim Card_no As String
    Dim ch_name As String
    Dim cvv As String
    Dim exp_date As String
    Dim amt As String
    Dim to_acc As String
    Dim tr_id As String
    Dim temp As String
    Dim t1 As String

    Dim gens As String = "0123456789"
    Dim r1 As New Random
    Dim otp As String = String.Empty

    Public Sub genOTP()
        Do Until otp.Length = 8
            temp = gens.Substring(r1.Next(0, 9), 1)
            otp &= temp
        Loop
    End Sub

    Public Sub addData()
        Card_no = cardNo.Text
        dt_time = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        ch_name = cardHolder.Text
        cvv = cardCVV.Text
        exp_date = cvvMM.SelectedItem + "/" + cvvYYYY.SelectedItem
        amt = amountVal.Text
        to_acc = toAcc.Text
        If (Card_no.Length <> 16) Or (cvv.Length <> 3) Or (cvvMM.SelectedItem.ToString = System.DateTime.Now.ToString("MM") AndAlso cvvYYYY.SelectedItem.ToString = System.DateTime.Now.ToString("yy")) Or (cardHolder.Text = "") Or (cardType.Text = "None") Then
            MessageBox.Show("Invalid Inputs. Check All the inputs Properly")
        Else
            tr_id = System.DateTime.Now.ToString("dd/MM/yy-HH:mm:ss") + ch_name.Substring(0, 2) + cardType.Text.Substring(0, 2)
            Dim Cmd As New SqlCommand("insert into TransactionLogs(timelog,tr_id,card_type,ch_name,card_no,cvv,exp_date,amount,to_acc) values(@timelog,@tr_id,@card_type,@ch_name,@card_no,@cvv,@exp_date,@amount,@to_acc)", Connection)
            Cmd.Parameters.Add("@timelog", SqlDbType.VarChar).Value = dt_time
            Cmd.Parameters.Add("@tr_id", SqlDbType.VarChar).Value = tr_id
            Cmd.Parameters.Add("@card_type", SqlDbType.VarChar).Value = cardType.Text
            Cmd.Parameters.Add("@ch_name", SqlDbType.VarChar).Value = ch_name
            Cmd.Parameters.Add("@card_no", SqlDbType.VarChar).Value = Card_no
            Cmd.Parameters.Add("@cvv", SqlDbType.VarChar).Value = cvv
            Cmd.Parameters.Add("@exp_date", SqlDbType.VarChar).Value = exp_date
            Cmd.Parameters.Add("@amount", SqlDbType.VarChar).Value = amt
            Cmd.Parameters.Add("@to_acc", SqlDbType.VarChar).Value = to_acc
            Dim CheckS As New SqlCommand("select * from UserDetails where card_no =" + Card_no + "", Connection)
            Dim CheckR As New SqlCommand("select * from UserDetails where account_no ='" + toAcc.Text + "'", Connection)
            Dim fetchSen As SqlDataReader
            Dim fetchRec As SqlDataReader

            Connection.Open()
            fetchRec = CheckR.ExecuteReader
            fetchRec.Read()
            Dim balSender As String = fetchRec("balance") + amt
            Dim balSenAcc As String = fetchRec("account_no")
            Dim balSenPh As String = fetchRec("ph_no")
            Connection.Close()

            Connection.Open()
            fetchSen = CheckS.ExecuteReader
            fetchSen.Read()
            Dim balReciever As String = fetchSen("balance") - amt
            Dim balRecAcc As String = fetchSen("account_no")
            Dim balRecPh As String = fetchSen("ph_no")
            Connection.Close()

            Dim updateS As New SqlCommand("update UserDetails set balance = " + balSender + "where account_no = '" + to_acc + "'", Connection)
            Dim updateR As New SqlCommand("update UserDetails set balance = " + balReciever + "where card_no = " + Card_no + "", Connection)
            Connection.Open()
            updateR.ExecuteNonQuery()
            Connection.Close()

            Connection.Open()
            updateS.ExecuteNonQuery()
            Connection.Close()

            Connection.Open()
            If updateS.ExecuteNonQuery() = 1 Then

            End If
            Connection.Close()

            Connection.Open()
            If updateS.ExecuteNonQuery() = 1 Then

            End If
            Connection.Close()


            Connection.Open()
            If Cmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Transaction Made Successfully")
                MessageBox.Show("Your Transaction ID is" + tr_id)
                Call msgRec(balSenAcc:=balSenAcc, balSender:=balSender, balSenPh:=balSenPh, balRecAcc:=balRecAcc, amt:=amt)
                Call msgSend(balRecAcc:=balRecAcc, balReciever:=balReciever, balRecPh:=balRecPh, balSenAcc:=balSenAcc, amt:=amt)
            End If
            Connection.Close()
        End If
    End Sub

    Public Sub msgRec(ByVal balSenAcc As String, ByVal balSender As String, ByVal balSenPh As String, ByVal balRecAcc As String, ByVal amt As String)

        Const accountSid = "<YOUR_TWILIO_ACCOUNT_SID>"
        Const authToken = "<YOUR_TWILIO_API_KEY>"
        TwilioClient.Init(accountSid, authToken)
        Dim toNumber = New PhoneNumber(balSenPh)
        Dim message = MessageResource.Create(
                    toNumber, from:=New PhoneNumber("<YOUR_TWILIO_PHONE_NUMBER>"),
                    body:="Reciever - Your Account Number" + balSenAcc.Substring(0, 3) + "XXX" + balSenAcc.Substring(8, 2) + "Has Been Credited With Rs " + amt + " To " + balRecAcc + " On " + System.DateTime.Now.ToString("MMM/dd/yyyy HH:mm:ss") + vbNewLine + "Your Account Balance Is Rs " + balSender + "")
    End Sub

    Public Sub msgSend(ByVal balRecAcc As String, ByVal balReciever As String, ByVal balRecPh As String, ByVal balSenAcc As String, ByVal amt As String)

    Const accountSid = "<YOUR_TWILIO_ACCOUNT_SID>"
    Const authToken = "<YOUR_TWILIO_API_KEY>"
        TwilioClient.Init(accountSid, authToken)
        Dim toNumber = New PhoneNumber(balRecPh)
        Dim message = MessageResource.Create(
        toNumber, from:=New PhoneNumber("<YOUR_TWILIO_PHONE_NUMBER>"),
                    body:="Sender - Your Account Number" + balRecAcc.Substring(0, 3) + "XXX" + balRecAcc.Substring(8, 2) + "Has Been Debited With Rs " + amt + " To " + balSenAcc + " On " + System.DateTime.Now.ToString("MMM/dd/yyyy HH:mm:ss") + vbNewLine + "Your Account Balance Is Rs " + balReciever + "")
    End Sub


    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Card_no = cardNo.Text
        dt_time = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        ch_name = cardHolder.Text
        cvv = cardCVV.Text
        exp_date = cvvMM.SelectedItem + "/" + cvvYYYY.SelectedItem
        amt = amountVal.Text
        to_acc = toAcc.Text
        If (Card_no.Length <> 16) Or (cvv.Length <> 3) Or (cvvMM.SelectedItem.ToString = System.DateTime.Now.ToString("MM") AndAlso cvvYYYY.SelectedItem.ToString = System.DateTime.Now.ToString("yy")) Or (cardHolder.Text = "") Or (cardType.Text = "None") Then
            MessageBox.Show("Invalid Inputs. Check All the inputs Properly")
        Else
            Connection.Open()
            Dim CheckS As New SqlCommand("select * from UserDetails where card_no =" + Card_no + "", Connection)
            Dim CheckR As New SqlCommand("select * from UserDetails where account_no ='" + toAcc.Text + "'", Connection)
            Dim fetchS As SqlDataReader
            Dim fetchR As SqlDataReader
            fetchR = CheckR.ExecuteReader
            fetchR.Read()
            Dim fetched_toAcc As String = fetchR("account_no")
            Connection.Close()

            Connection.Open()
            fetchS = CheckS.ExecuteReader
            fetchS.Read()


            If fetchS("card_no") = Card_no And fetchS("card_type") = cardType.Text And fetchS("ch_name") = ch_name And fetchS("cvv") = cvv And fetchS("exp_date") = exp_date And fetchS("balance") > amt And fetched_toAcc = to_acc Then
                genOTP()
                otpPage.otpCode = otp
                Dim senderPH As String = fetchS("ph_no")
                Const accountSid = "<YOUR_TWILIO_ACCOUNT_SID>"
                Const authToken = "<YOUR_TWILIO_API_KEY>"
                TwilioClient.Init(accountSid, authToken)
                Dim toNumber = New PhoneNumber(senderPH)
                Dim message = MessageResource.Create(
                    toNumber, from:=New PhoneNumber("<YOUR_TWILIO_PHONE_NUMBER>"),
                    body:="Your PAY-WAY Bill Desk OTP is " + otp)
                Console.WriteLine(message.Sid)

                Me.Hide()
                otpPage.Show()
            Else
                MessageBox.Show("Invalid Credentials. Please Enter the Correct Details")
            End If
            Connection.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cardCVV.UseSystemPasswordChar = False
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles cardNo.TextChanged
        Card_no = cardNo.Text
        cardLogoVi.Visible = False
        cardLogoMC.Visible = False
        cardLogoAE.Visible = False
        cardLogoDC.Visible = False
        cardLogoNo.Visible = True
        cardType.Text = "None"
        If Card_no.Length = 0 Then
            cardLogoVi.Visible = False
            cardLogoMC.Visible = False
            cardLogoAE.Visible = False
            cardLogoNo.Visible = True
            cardLogoDC.Visible = False
            cardType.Text = "None"
        End If
        If Card_no.Length > 0 Then
            If Card_no.Chars(0) = "3" Then
                cardLogoVi.Visible = False
                cardLogoMC.Visible = False
                cardLogoAE.Visible = True
                cardLogoNo.Visible = False
                cardLogoDC.Visible = False
                cardType.Text = "American Express"
            End If
            If Card_no.Chars(0) = "4" Then
                cardLogoVi.Visible = True
                cardLogoMC.Visible = False
                cardLogoAE.Visible = False
                cardLogoNo.Visible = False
                cardLogoDC.Visible = False
                cardType.Text = "Visa International"
            End If
            If Card_no.Chars(0) = "5" Then
                cardLogoVi.Visible = False
                cardLogoMC.Visible = True
                cardLogoAE.Visible = False
                cardLogoNo.Visible = False
                cardLogoDC.Visible = False
                cardType.Text = "Master Card"
            End If
            If Card_no.Chars(0) = "6" Then
                cardLogoVi.Visible = False
                cardLogoMC.Visible = False
                cardLogoAE.Visible = False
                cardLogoNo.Visible = False
                cardLogoDC.Visible = True
                cardType.Text = "Visa Discover"
            End If
        End If
    End Sub

    Private Sub cvvShow_Click(sender As Object, e As EventArgs) Handles cvvShow.Click
        If cardCVV.UseSystemPasswordChar = False Then
            cardCVV.UseSystemPasswordChar = True
        Else
            cardCVV.UseSystemPasswordChar = False
        End If
    End Sub

End Class
